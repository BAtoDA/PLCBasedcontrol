using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PLC通讯基础控件项目.Migrations
{
    public partial class Migration_001 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EventHistory",
                columns: table => new
                {
                    id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    MessageID = table.Column<int>(type: "INTEGER", nullable: false),
                    类型 = table.Column<int>(type: "INTEGER", nullable: false),
                    设备 = table.Column<string>(type: "TEXT", nullable: true),
                    设备_地址 = table.Column<string>(type: "TEXT", nullable: true),
                    设备_具体地址 = table.Column<string>(type: "TEXT", nullable: true),
                    位触发条件 = table.Column<bool>(type: "INTEGER", nullable: false),
                    字触发条件 = table.Column<string>(type: "TEXT", nullable: true),
                    字触发条件_具体 = table.Column<string>(type: "TEXT", nullable: true),
                    报警内容 = table.Column<string>(type: "TEXT", nullable: true),
                    报警发生时间 = table.Column<DateTime>(type: "TEXT", nullable: false),
                    报警处理时间 = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EventHistory", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "EventMessage",
                columns: table => new
                {
                    id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    MessageID = table.Column<int>(type: "INTEGER", nullable: false),
                    类型 = table.Column<int>(type: "INTEGER", nullable: false),
                    设备 = table.Column<string>(type: "TEXT", nullable: true),
                    设备_地址 = table.Column<string>(type: "TEXT", nullable: true),
                    设备_具体地址 = table.Column<string>(type: "TEXT", nullable: true),
                    位触发条件 = table.Column<bool>(type: "INTEGER", nullable: false),
                    字触发条件 = table.Column<string>(type: "TEXT", nullable: true),
                    字触发条件_具体 = table.Column<string>(type: "TEXT", nullable: true),
                    报警内容 = table.Column<string>(type: "TEXT", nullable: true),
                    报警发生时间 = table.Column<string>(type: "TEXT", nullable: true),
                    报警处理时间 = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EventMessage", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EventHistory");

            migrationBuilder.DropTable(
                name: "EventMessage");
        }
    }
}
