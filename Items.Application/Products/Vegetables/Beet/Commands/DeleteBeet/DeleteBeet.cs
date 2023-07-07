﻿using MediatR;

namespace Items.Application.Products.Vegetables.Beet.Commands.DeleteBeet
{
    public class DeleteBeet : IRequest<Unit>
    {
        public Guid PersonId { get; set; }
        public Guid ItemId { get; set; }
    }
}