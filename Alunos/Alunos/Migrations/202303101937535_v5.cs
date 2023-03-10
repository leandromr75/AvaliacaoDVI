namespace Alunos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v5 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Matriculas",
                c => new
                    {
                        Id = c.Int(nullable: false),
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
            DropForeignKey("dbo.Matriculas", "IdMateria", "dbo.Materias");
            DropForeignKey("dbo.Matriculas", "Id", "dbo.Alunoes");
            DropIndex("dbo.Matriculas", new[] { "IdMateria" });
            DropIndex("dbo.Matriculas", new[] { "Id" });
            DropTable("dbo.Matriculas");
        }
    }
}
