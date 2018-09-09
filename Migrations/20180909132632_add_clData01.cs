using Microsoft.EntityFrameworkCore.Migrations;

namespace checkListServer.Migrations
{
    public partial class add_clData01 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("Insert into checklists(Title) values ('RV Road Check')");
            migrationBuilder.Sql("Insert into checklists(Title) values ('Winterize Boat')");
            migrationBuilder.Sql("Insert into checklistitems(checkListId,Title) values ((select id from checklists where title = 'RV Road Check'),'Check tires')");
            migrationBuilder.Sql("Insert into checklistitems(checkListId,Title) values ((select id from Checklists where title = 'RV Road Check'),'Connect to trail hitch')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("delete from  checklists where title ='RV Setup'");
            migrationBuilder.Sql("delete from  checklists where title ='Winterize Boat'");
            migrationBuilder.Sql("delete from  checklistitems where checklistid = (select id from lists where title = 'RV Road Check')");
        }
    }
}
