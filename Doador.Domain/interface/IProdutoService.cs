﻿using Doador.Domain.commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doador.Domain.Interface
{
    public interface IProdutoService
    {
        Task<string>postAsync(ProdutoCommand Command);

        void postAsync();
    }
}
