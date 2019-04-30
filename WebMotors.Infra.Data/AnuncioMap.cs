using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebMotors.Domain;

namespace WebMotors.Infra.Data
{
    public class AnuncioMap : EntityTypeConfiguration<Anuncio>
    {
        public AnuncioMap()
        {
            HasKey(x => x.Id);
            Property(x => x.Id).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity).HasColumnName("ID");
            Property(x => x.Marca).HasColumnName("marca").HasMaxLength(45).IsRequired();
            Property(x => x.Modelo).HasColumnName("modelo").HasMaxLength(45).IsRequired();
            Property(x => x.Versao).HasColumnName("versao").HasMaxLength(45).IsRequired();
            Property(x => x.Ano).HasColumnName("ano").IsRequired();
            Property(x => x.Quilometragem).HasColumnName("quilometragem").IsRequired();
            Property(x => x.Observacao).HasColumnName("observacao").HasColumnType("text");
        }
    }
}
