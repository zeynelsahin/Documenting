﻿using Library.API.Models;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace Library.API.OperationFİlters;

public class CreateBookOperationFilter: IOperationFilter
{
    public void Apply(OpenApiOperation operation, OperationFilterContext context)
    {
        if (operation.OperationId!="CreateBook")
        {
            return;
        }
        operation.RequestBody.Content.Add("application/vnd.sahin.bookforcreationonwithamountofpages+json",new OpenApiMediaType()
        {
            Schema = context.SchemaGenerator.GenerateSchema(typeof(BookForCreationWithAmountOfPages),context.SchemaRepository)
        });
    }
}