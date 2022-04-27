﻿using System;
using System.ComponentModel.DataAnnotations;

namespace CadastroCasaPopular.Domain.Model
{
    public abstract class Entity
    {
        protected Entity()
        {
            Id = Guid.NewGuid();
        }

        [Key]
        public Guid Id { get; set; }
    }
}
