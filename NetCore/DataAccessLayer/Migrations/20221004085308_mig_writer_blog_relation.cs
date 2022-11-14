﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class mig_writer_blog_relation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "WriterID",
                table: "blogs",
                type: "int",
                nullable: true,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_blogs_WriterID",
                table: "blogs",
                column: "WriterID");

            migrationBuilder.AddForeignKey(
                name: "FK_blogs_writers_WriterID",
                table: "blogs",
                column: "WriterID",
                principalTable: "writers",
                principalColumn: "WriterID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_blogs_writers_WriterID",
                table: "blogs");

            migrationBuilder.DropIndex(
                name: "IX_blogs_WriterID",
                table: "blogs");

            migrationBuilder.DropColumn(
                name: "WriterID",
                table: "blogs");
        }
    }
}
