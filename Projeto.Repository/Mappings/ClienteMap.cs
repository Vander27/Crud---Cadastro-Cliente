using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using Projeto.Entities;

namespace Projeto.Repository.Mappings
{
    public class ClienteMap : EntityTypeConfiguration<Cliente>
    {
        public ClienteMap()
        {
            //nome da tabela..
            ToTable("Cliente");

            //chave primário..
            HasKey(c => c.IdCliente);

            //mapear os demais campos da tabela
            Property(c => c.IdCliente)
                .HasColumnName("IdCliente")
                .IsRequired();

            Property(c => c.Nome)
               .HasColumnName("Nome")
               .HasMaxLength(100)
               .IsRequired();


            Property(c => c.Endereco)
                .HasColumnName("Endereco")
                .HasMaxLength(100)
                .IsRequired();


            Property(c => c.CEP)
                .HasColumnName("CEP")
                .HasMaxLength(100)
                .IsRequired();


            Property(c => c.Bairro)
                .HasColumnName("Bairro")
                .HasMaxLength(100)
                .IsRequired();


            Property(c => c.UF)
                .HasColumnName("UF")
                .HasMaxLength(100)
                .IsRequired();

            Property(c => c.Telefone)
                .HasColumnName("Telefone")
                .HasMaxLength(100)
                .IsRequired();

            Property(c => c.Email)
                .HasColumnName("Email")
                .HasMaxLength(100)
                .IsRequired();
        }
    }
}
