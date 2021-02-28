using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RestAPI_NoSQL.Domain.Dtos;
using RestAPI_NoSQL.Domain.Entities;
using RestAPI_NoSQL.Domain.Helpers;
using RestAPI_NoSQL.Domain.Interfaces;

namespace RestAPI_NoSQL.WebApi.Controllers
{
    [ApiController]
    [Route("items")]
    public class CatalogItemsController : ControllerBase
    {
        private readonly ICatalogItemRepository repository;

        public CatalogItemsController(ICatalogItemRepository repository)
        {
            this.repository = repository;
        }

        [HttpGet]
        public async Task<IEnumerable<Dtos.CatalogItemDto>> GetAsync()
        {
            var itemEntities = await repository.GetAllAsync();
            var itemDtos = itemEntities.Select(entity => entity.AsDto());

            return itemDtos;
        }

        [HttpGet("{id}", Name = "GetById")]
        public async Task<ActionResult<Dtos.CatalogItemDto>> GetByIdAsync(Guid id)
        {
            var item = await repository.GetAsync(id);
            if (item == null)
            {
                return NotFound();
            }

            return item.AsDto();
        }

        [HttpPost]
        public async Task<ActionResult<Dtos.CatalogItemDto>> PostAsync(Dtos.CreateCatalogItemDto createItemDto)
        {
            var item = new CatalogItem
            {
                Name = createItemDto.Name,
                Description = createItemDto.Description,
                Price = createItemDto.Price,
                CreatedDate = DateTimeOffset.UtcNow
            };
            await repository.CreateAsync(item);

            return CreatedAtRoute("GetById", new {id = item.Id}, item);
        }
    }
}