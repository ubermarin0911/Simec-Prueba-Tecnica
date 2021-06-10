﻿using app.api.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace app.api.Interfaces
{
    public interface IClienteService
    {
        Task<Cliente> CrearClienteAsync(Cliente cliente);
        Task<Cliente> EditarClienteAsync(Cliente cliente);
        Task<IReadOnlyList<Cliente>> GetClientesAsync();
        Task EliminarClienteAsync(Cliente cliente);
    }
}
