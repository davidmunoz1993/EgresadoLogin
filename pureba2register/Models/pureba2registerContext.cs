﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace pureba2register.Models
{
    public class pureba2registerContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public pureba2registerContext() : base("name=pureba2registerContext")
        {
        }

        public System.Data.Entity.DbSet<pureba2register.Models.Egresado> Egresadoes { get; set; }

<<<<<<< HEAD
        public System.Data.Entity.DbSet<pureba2register.Models.AgregarOferta> AgregarOfertas { get; set; }

        public System.Data.Entity.DbSet<pureba2register.Models.ConsultarOferta> ConsultarOfertas { get; set; }

        public System.Data.Entity.DbSet<pureba2register.Models.CrearPerfilEmpresa> CrearPerfilEmpresas { get; set; }

        public System.Data.Entity.DbSet<pureba2register.Models.PerfilEmpresa> PerfilEmpresas { get; set; }
=======
        public System.Data.Entity.DbSet<pureba2register.Models.Administrador> Administradors { get; set; }

        public System.Data.Entity.DbSet<pureba2register.Models.PublicacionesEnEspera> PublicacionesEnEsperas { get; set; }

        public System.Data.Entity.DbSet<pureba2register.Models.PublicacionAdmin> PublicacionAdmins { get; set; }
>>>>>>> 30da0560b41b0ca980d32937b25d1e52743955c6
    }
}
