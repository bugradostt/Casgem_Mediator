﻿using Casgem_Mediator.MeditorPattern.Commands;
using Casgem_Mediator.MeditorPattern.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Casgem_Mediator.Controllers
{
    public class DefaultController : Controller
    {
        readonly IMediator _mediator;

        public DefaultController(IMediator mediator)
        {
            _mediator = mediator;
        }

        public async Task<IActionResult> Index()
        {
            var values = await _mediator.Send(new GetProductQuery());
            return View(values);
        }

        [HttpGet]
        public IActionResult AddProduct()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddProduct(CreateProductCommand p)
        {
            await _mediator.Send(p);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> DeleteProduct(int id)
        {
            await _mediator.Send( new RemoveProductCommand(id));
            return RedirectToAction("Index");
        }


        [HttpGet]
        public async Task<IActionResult> UpdateProduct(int id)
        {
            var foundId = await _mediator.Send(new GetProductUpdateByIdQuery(id));
            return View(foundId);
        }

        [HttpPost]
        public async Task<IActionResult> UpdateProduct(UpdateüProductCommand p)
        {
            var foundId = await _mediator.Send(p);
            return RedirectToAction("Index");
        }
    }
}
