using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TidePortal.Core.Migrations
{
    public partial class i1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Resources",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false, comment: "编号")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateTime = table.Column<DateTime>(type: "datetime", nullable: false, comment: "创建时间"),
                    CreatorId = table.Column<int>(nullable: false),
                    LastModifyTime = table.Column<DateTime>(nullable: true),
                    LastModifierId = table.Column<int>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Author = table.Column<string>(nullable: true),
                    Text = table.Column<string>(nullable: true),
                    LessonUrl = table.Column<string>(nullable: true),
                    ImageUrl = table.Column<string>(nullable: true),
                    Sort = table.Column<int>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    VisitNum = table.Column<int>(nullable: false),
                    Status = table.Column<byte>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Resources", x => x.Id);
                },
                comment: "课程资源");

            migrationBuilder.CreateTable(
                name: "UserResourceMapping",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(nullable: false),
                    ResourceId = table.Column<int>(nullable: false),
                    OrderNumber = table.Column<int>(nullable: false),
                    Remark = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserResourceMapping", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false, comment: "编号")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateTime = table.Column<DateTime>(type: "datetime", nullable: false, comment: "创建时间"),
                    CreatorId = table.Column<int>(nullable: false),
                    LastModifyTime = table.Column<DateTime>(nullable: true),
                    LastModifierId = table.Column<int>(nullable: true),
                    QQ = table.Column<string>(nullable: true),
                    Mobile = table.Column<string>(maxLength: 12, nullable: true),
                    PassWord = table.Column<string>(nullable: true),
                    NickName = table.Column<string>(nullable: true),
                    RegDate = table.Column<DateTime>(nullable: false),
                    LoginNum = table.Column<int>(nullable: false),
                    LastLoginTime = table.Column<DateTime>(nullable: true),
                    Status = table.Column<byte>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                },
                comment: "网站用户");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Resources");

            migrationBuilder.DropTable(
                name: "UserResourceMapping");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
