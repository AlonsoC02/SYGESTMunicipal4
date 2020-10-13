using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SYGESTMunicipal.Areas.OFIM.Models;
using SYGESTMunicipal.Areas.PATENTES.Models;

namespace SYGESTMunicipal.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<EstadoCivil> EstadoCivil { get; set; }
        public DbSet<Nacionalidad> Nacionalidad { get; set; }
        public DbSet<NivelAcademico> NivelAcademico { get; set; }
        public DbSet<Ocupacion> Ocupacion { get; set; }
        public DbSet<Seguro> Seguro { get; set; }
        public DbSet<PersonaOFIM> PersonaOFIM { get; set; }
        public DbSet<Consulta> Consulta { get; set; }
        public DbSet<TipoConsulta> TipoConsulta { get; set; }
        public DbSet<ActivityType> ActivityType { get; set; }
        public DbSet<Applicant> Applicant { get; set; }
        public DbSet<CIIU> CIIU { get; set; }
        public DbSet<EstablishmentType> EstablishmentType { get; set; }
        public DbSet<Establishment> Establishment { get; set; }
        public DbSet<PersonPatentes> PersonPatentes { get; set; }
        public DbSet<RequestReason> RequestReason { get; set; }


    }
}
