﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace ObraSocial.API.Filters
{
    public class ValidationFilter : IActionFilter
    {
        public void OnActionExecuted(ActionExecutedContext context)
        {
            
        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
            if (!context.ModelState.IsValid)
            {
                var messages = context.ModelState
                                      .SelectMany(x => x.Value.Errors)
                                      .Select(e => e.ErrorMessage)
                                      .ToList();

                context.Result = new BadRequestObjectResult(messages);
            }
        }
    }
}