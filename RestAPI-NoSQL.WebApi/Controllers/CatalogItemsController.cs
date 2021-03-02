using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using RestAPI_NoSQL.Application.Commands;
using RestAPI_NoSQL.Application.Queries;
using RestAPI_NoSQL.Domain.Entities;

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

        [HttpGet]
        public async Task<ActionResult<IEnumerable<CatalogItem>>> GetAllItemsAsync()
        {
            var items = await _mediator.Send(new GetAllCatalogItemsQuery());
            if (items != null)
            {
                return Ok(items);
            }
            
            return NotFound();
        }

        [HttpGet("{id}", Name = "GetById")]
        public async Task<ActionResult<CatalogItem>> GetItemAsync(Guid id)
        {
            var item = await _mediator.Send(new GetCatalogItemQuery(){Id = id});
            if (item != null)
            {
                return Ok(item);
            }
            
            return NotFound();
        }

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