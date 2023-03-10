namespace Alunos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Materias",
                c => new
                    {
                        IdMateria = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                        Descricao = c.String(),
                    })
                .PrimaryKey(t => t.IdMateria);
            
            CreateTable(
                "dbo.Notas",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        NotaAluno = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Data = c.DateTime(nullable: false),
                        IdMateria = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Alunoes", t => t.Id)
                .ForeignKey("dbo.Materias", t => t.IdMateria)
                .Index(t => t.Id)
                .Index(t => t.IdMateria);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Notas", "IdMateria", "dbo.Materias");
            DropForeignKey("dbo.Notas", "Id", "dbo.Alunoes");
            DropIndex("dbo.Notas", new[] { "IdMateria" });
            DropIndex("dbo.Notas", new[] { "Id" });
            DropTable("dbo.Notas");
            DropTable("dbo.Materias");
        }
    }
}
