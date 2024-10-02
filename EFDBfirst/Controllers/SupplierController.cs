﻿using EFDBfirst.Models;
using EFDBfirst.Repository.IRepository;
using EFDBfirst.Repository.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EFDBfirst.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SupplierController : ControllerBase
    {
        private readonly IRepository<Supplier> repository;

        public SupplierController(IRepository<Supplier> repository)
        {
            this.repository = repository;
        }

        [HttpGet]

        public async Task<ActionResult> GetSupplier()
        {
            try
            {
                var Category = await repository.GetAllAsync();

                return Ok(Category);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                 "Error retrieving data from the database");
            }
        }

        [HttpGet("SupplierId")]

        public async Task<ActionResult> GetSupplierId(int SupplierId)
        {
            try
            {
                var Category = await repository.GetById(SupplierId);

                return Ok(Category);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                 "Error retrieving data from the database");
            }
        }
        [HttpPost]
        public async Task<ActionResult> CreateSupplier([FromBody] Supplier supplier) {

            try
            {
                if (supplier == null)
                {
                    return BadRequest();
                }

                    var createSupplier = await repository.Add(supplier);
                    return Ok(createSupplier);

            }
            catch (Exception)
            {

                throw;
            }
        
        }
    }
}
