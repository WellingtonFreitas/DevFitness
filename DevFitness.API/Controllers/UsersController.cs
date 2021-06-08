using AutoMapper;
using DevFitness.API.Core.Entities;
using DevFitness.API.Models.InputModels;
using DevFitness.API.Models.ViewModels;
using DevFitness.API.Persistence;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevFitness.API.Controllers
{
    //api/users
    [Route("api/[controller]")]
    public class UsersController : ControllerBase
    {
        private readonly DevFitnessDbContext _dbContext;
        private readonly IMapper _mapper;
        public UsersController(DevFitnessDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }
        /// <summary>
        /// Retorna detalhes do usuário
        /// </summary>
        /// <param name="id">Identificador de usuário.</param>
        /// <returns>Objeto de detalhes do usuário.</returns>
        /// <response code="404">Usuário não encontrado.</response>
        /// <response code="200">Usuário encontrado com sucesso.</response>
        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult Get(int id)
        {
            var user = _dbContext.Users.SingleOrDefault(u => u.Id == id);

            if (user == null)
                return NotFound();

            var userViewModel = _mapper.Map<UserViewModel>(user);

            return Ok(userViewModel);
        }
        /// <summary>
        /// Cadastrar Usuario
        /// </summary>
        /// <remarks>
        /// Requisições de exemplo
        /// {
        ///     "fullName": "string",
        ///     "height": 10,
        ///     "weight": 10,
        ///     "birthDate": "2021-06-08T14:59:08.768Z"
        /// }
        /// </remarks>
        /// <param name="inputModel">Objeto com dados de cadastro do usuário</param>
        /// <returns>Objeto recém-criado.</returns>
        /// <response code="201">Objeto criado ocm sucesso.</response>
        /// <response code="400">Dados inválidos..</response>
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult Post([FromBody] CreateUserInputModel inputModel)
        {
            var user = _mapper.Map<User>(inputModel);

            _dbContext.Users.Add(user);
            _dbContext.SaveChanges();

            return CreatedAtAction(nameof(Get), new { id = user.Id }, inputModel);
        }
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] UpdateUserInputModel updateUser)
        {
            var user = _dbContext.Users.SingleOrDefault(u => u.Id == id);
            if (user == null)
                return NotFound();

            user.Update(updateUser.Height, updateUser.Weight);
            _dbContext.SaveChanges();

            return NoContent();
        }
    }
}
