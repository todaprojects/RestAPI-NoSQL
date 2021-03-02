using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using RestAPI_NoSQL.Application.Commands;
using RestAPI_NoSQL.Domain.Dtos;
using RestAPI_NoSQL.Domain.Entities;
using RestAPI_NoSQL.Domain.Helpers;
using RestAPI_NoSQL.Domain.Interfaces;

namespace RestAPI_NoSQL.WebApi.Controllers
{
    [ApiController]
    [Route("items")]
    public class CatalogItemsController : Controller
    {
        private readonly IMediator _mediator;

        public CatalogItemsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        // private readonly ICatalogItemRepository _repository;
        //
        // public CatalogItemsController(ICatalogItemRepository repository)
        // {
        //     _repository = repository;
        // }

        // [HttpGet]
        // public async Task<IEnumerable<Dtos.CatalogItemDto>> GetAsync()
        // {
        //     var itemEntities = await _repository.GetAllAsync();
        //     var itemDtos = itemEntities.Select(entity => entity.AsDto());
        //
        //     return itemDtos;
        // }

        // [HttpGet("{id}", Name = "GetById")]
        // public async Task<ActionResult<Dtos.CatalogItemDto>> GetByIdAsync(Guid id)
        // {
        //     var item = await _repository.GetAsync(id);
        //     if (item == null)
        //     {
        //         return NotFound();
        //     }
        //
        //     return item.AsDto();
        // }

        [HttpPost]
        public async Task<ActionResult<CatalogItem>> AddItemAsync([FromBody] AddCatalogItemCommand command)
        {
            var item = await _mediator.Send(command);
            if (item != null)
            {
                // return CreatedAtRoute("GetById", new {id = item.Id}, item);
                return Ok(item);
            }

            return BadRequest("Failed saving item");
        }
    }
}