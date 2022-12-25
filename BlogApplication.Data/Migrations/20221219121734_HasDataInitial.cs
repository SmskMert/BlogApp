using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BlogApplication.Data.Migrations
{
    /// <inheritdoc />
    public partial class HasDataInitial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CategoryUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsPublished = table.Column<bool>(type: "bit", nullable: false),
                    PublishedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Posts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Summary = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Contents = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PostUrl = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Posts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tags",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TagUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsPublished = table.Column<bool>(type: "bit", nullable: false),
                    PublishedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tags", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Comments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ParentComment = table.Column<int>(type: "int", nullable: false),
                    PostedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PostId = table.Column<int>(type: "int", nullable: true),
                    IsPublished = table.Column<bool>(type: "bit", nullable: false),
                    PublishedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Comments_Posts_PostId",
                        column: x => x.PostId,
                        principalTable: "Posts",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "PostCategories",
                columns: table => new
                {
                    PostId = table.Column<int>(type: "int", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PostCategories", x => new { x.PostId, x.CategoryId });
                    table.ForeignKey(
                        name: "FK_PostCategories_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PostCategories_Posts_PostId",
                        column: x => x.PostId,
                        principalTable: "Posts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PostTags",
                columns: table => new
                {
                    PostId = table.Column<int>(type: "int", nullable: false),
                    TagId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PostTags", x => new { x.PostId, x.TagId });
                    table.ForeignKey(
                        name: "FK_PostTags_Posts_PostId",
                        column: x => x.PostId,
                        principalTable: "Posts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PostTags_Tags_TagId",
                        column: x => x.TagId,
                        principalTable: "Tags",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CategoryUrl", "CreatedOn", "Description", "IsPublished", "LastModifiedOn", "PublishedOn", "Title" },
                values: new object[,]
                {
                    { 1, "information-technology", new DateTime(2022, 12, 19, 15, 17, 34, 161, DateTimeKind.Local).AddTicks(3041), null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Information Technology" },
                    { 2, "art", new DateTime(2022, 12, 19, 15, 17, 34, 161, DateTimeKind.Local).AddTicks(3043), null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Art" },
                    { 3, "life-style", new DateTime(2022, 12, 19, 15, 17, 34, 161, DateTimeKind.Local).AddTicks(3044), null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Life Style" }
                });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Contents", "PostUrl", "Summary", "Title" },
                values: new object[,]
                {
                    { 1, "Don’t let the above list intimidate you. You can become a front end developer if you follow these simple steps.\r\n\r\nLearn CSS, JavaScript and HTML\r\nThese coding languages are the essential building blocks for web and app development, so you need to learn them. Fortunately, it’s not a very difficult undertaking. There are lots of online resources available out there that can help further your education in the coding languages. For extra credit, familiarize yourself with jQuery and JavaScript Frameworks.\r\nGet Informed\r\nThat means reading articles and books about front end development. By getting an understanding of how things work on a website, you can make better sense of the various coding languages. If you want to round out your learning experience, check out some videos on YouTube.\r\nPractice\r\nHere’s where the old saying “practice makes perfect” comes into play. Start small by using your newfound knowledge to build small parts of a user interface, then expand slowly. If you end up making mistakes, don’t worry. Sometimes we learn more from our errors than we do from a flawless performance.\r\nLearn the Command Line\r\nWhen pursuing a profession that has anything to do with web design, it’s a good idea to get at least a basic grasp of concepts like displaying files and file system navigation. On a related note, you should familiarize yourself with the properties of the Shell, which is the means of accessing operating system functions via a text interface.\r\nLearn Version Control\r\nOne of the hazards of coding is having it break when you change one small thing. Even after you try to rectify the problem, things are never quite the same again. That’s why a good front end developer learns version control. There is an impressive selection of version control systems to choose from, but if you want to go with the most popular, go with Git.\r\nAlso Read: Git Tutorial\r\n\r\nEnhance Your Skills\r\nCheck out some tutorials, tools, and open-source projects. Resources such as freeCodeCamp, Codecademy, Bootstrap, Vue.js, CSS Layout, and Front-end Checklist exist to help you master the skills of front end development without having to lay out any money for the opportunity. These tools are easily accessible online and can be a much-needed boost to your front end development education.\r\nTake a Course\r\nTake a front end developer course. There’s nothing like learning from experienced people in a structured environment. You could do this by physically attending classes (which can be a drain on your free time), or taking an online course. There are many appropriate courses out there, but later on, we’ll show you an excellent and well-tested option that would perfectly fit your needs!\r\nGet an Internship\r\nBecome a junior front end developer. Sometimes, the best way to learn new skills is to work under more knowledgeable people, and that’s what a junior front end developer or an intern does. Of course, the pay is less, but you need fewer qualifications. Besides, you’ll be learning from more experienced people, and that’s always beneficial.", "become-frontEnd-developer", "This article explains how to became a frontend developer.", "Become A Frontend Developer" },
                    { 2, "Art-portrait-collage 2\r\nArt refers to a diverse range of human activities in creating visual, auditory or performing artifacts. These artworks express the author's imaginative or technical skill. Art is intended to be appreciated for its beauty or emotional power. In their most general form these activities include the production of works of art, the criticism of art, the study of the history of art, and the aesthetic dissemination of art.\r\n\r\nFunctions of arts\r\nArt has had a great number of different functions throughout its history, making its purpose difficult to abstract or quantify to any single concept. This does not imply that the purpose of Art is \"vague\", but that it has had many unique, different reasons for being created.\r\n\r\nArt can have a personal function, it is an expression of basic human instinct for harmony, balance, rhythm. Art at this level is not an action or an object, but an internal appreciation of balance and harmony (beauty), and therefore an aspect of being human beyond utility. Art also provides a way to experience one's self in relation to the universe. This experience may often come unmotivated, as one appreciates art, music or poetry.\r\n\r\nOn the other hand art may have a social function. At its simplest, art is a form of communication. It seeks to entertain and bring about a particular emotion or mood, for the purpose of relaxing or entertaining the viewer. Art may also be an expression of social protest, seeking to question aspects of society.\r\n\r\nTypes of art\r\nThe oldest form of art are visual arts, which include creation of images or objects in fields including painting, sculpture, printmaking, photography, and other visual media. Architecture is often included as one of the visual arts; however, like the decorative arts, it involves the creation of objects where the practical considerations of use are essential, in a way that they usually are not in a painting, for example.\r\n\r\nMusic, theater, film, dance, and other performing arts, as well as literature and other media such as interactive media, are included in a broader definition of art or the arts.\r\n\r\nHistory\r\nUntil the 17th century, art referred to any skill or mastery and was not differentiated from crafts or sciences. In modern usage after the 17th century, where aesthetic considerations are paramount, the fine arts are separated and distinguished from acquired skills in general, such as the decorative or applied arts.\r\n\r\nCharacteristics of art\r\nArt may be characterized in terms of mimesis (i.e. its representation of reality), expression, communication of emotion, or other qualities. During the Romantic period, art came to be seen as \"a special faculty of the human mind to be classified with religion and science\". Though the definition of what constitutes art is disputed and has changed over time, general descriptions mention an idea of imaginative or technical skill stemming from human agency and creation.\r\n\r\nAesthetics\r\nThe nature of art, and related concepts such as creativity and interpretation, are explored in a branch of philosophy known as aesthetics.", "what-is-art", "This article explains what is art.", "What is art?" },
                    { 3, "Design Development is the second major phase of a residential following Schematic Design – assuming that you don’t identify programming as its own phase (which I don’t – but this is one of the glaring differences between residential projects and commercial projects). To define Design Development, we can look at the proposals I send out that are generated in-house and the AIA B101 contract between the Owner and the Architect.\r\n\r\nAIA B101 definition:\r\n§ 3.3.1 Based on the Owner’s approval of the Schematic Design Documents, and on the Owner’s authorization of any adjustments in the Project requirements and the budget for the Cost of the Work, the Architect shall prepare Design Development Documents for the Owner’s approval. The Design Development Documents shall illustrate and describe the development of the approved Schematic Design Documents and shall consist of drawings and other documents including plans, sections, elevations, typical construction details, and diagrammatic layouts of building systems to fix and describe the size and character of the Project as to architectural, structural, mechanical and electrical systems, and other appropriate elements. The Design Development Documents shall also include outline specifications that identify major materials and systems and establish, in general, their quality levels.\r\n\r\nI would typically refer people to the small project family of contracts that the AIA has assembled which is more suited to projects that are modest in size and brief in duration. (B105-2017) mostly because on residential projects, a great deal of what is listed in 3.3.1 on the B101 version listed scope of services that are not typically either provided or when they are provided, they are directional rather than comprehensive in their scope. It isn’t typical that consultants are retained to provide engineering services such as mechanical and electrical systems during the project in any capacity as these are typically resolved as part of a design-build scope of work that is coordinated between the architect and the contractor on the project.\r\n\r\nAndrew’s definition is very succinct: The phase in which most design decisions are finalized.\r\n\r\nI lifted my definition directly from the contract language we use and it is specifically set up so that we can identify and communicate what problems we are solving, how we will present our intents, where and how we will meet, and the decisions that will be required. It is:\r\n\r\nBased on the approved Schematic Design package, BOKA Powell will create Design Development drawings and other documents to fix and describe the size and character of the home’s building exterior and interior finish-out. Deliverables will include ¼” scale hard line floor plans, ¼” scale exterior and interior elevations. We will meet with the clients through regularly scheduled meetings, to present and review the Design Development concepts. Meetings required during the Design Development phase will occur virtually, or with prior arrangements, at predetermined locations, including the current home of the client, the project site, or BOKA Powell’s Dallas office. We will make revisions to plans in an iterative process as feedback is gathered. We will seek approval from the client prior to proceeding.\r\n\r\nI feel the need to point out that the language above is specific to our residential projects and not our larger-scale projects.", "what-is-Design-Development", "This article explains how a design development should be in architecture", "What is Design Development in Architecture?" }
                });

            migrationBuilder.InsertData(
                table: "Tags",
                columns: new[] { "Id", "CreatedOn", "Description", "IsPublished", "LastModifiedOn", "PublishedOn", "TagUrl", "Title" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 12, 19, 15, 17, 34, 161, DateTimeKind.Local).AddTicks(2869), null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "javascript", "JavaScript" },
                    { 2, new DateTime(2022, 12, 19, 15, 17, 34, 161, DateTimeKind.Local).AddTicks(2882), null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "web-development", "Web Development" },
                    { 3, new DateTime(2022, 12, 19, 15, 17, 34, 161, DateTimeKind.Local).AddTicks(2884), null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "programming", "Programming" },
                    { 4, new DateTime(2022, 12, 19, 15, 17, 34, 161, DateTimeKind.Local).AddTicks(2885), null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "self-improvement", "Self Improvement" },
                    { 5, new DateTime(2022, 12, 19, 15, 17, 34, 161, DateTimeKind.Local).AddTicks(2886), null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "architecuture", "Architecture" }
                });

            migrationBuilder.InsertData(
                table: "PostCategories",
                columns: new[] { "CategoryId", "PostId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 2 },
                    { 3, 3 }
                });

            migrationBuilder.InsertData(
                table: "PostTags",
                columns: new[] { "PostId", "TagId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 1, 2 },
                    { 1, 3 },
                    { 2, 4 },
                    { 3, 5 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Comments_PostId",
                table: "Comments",
                column: "PostId");

            migrationBuilder.CreateIndex(
                name: "IX_PostCategories_CategoryId",
                table: "PostCategories",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_PostTags_TagId",
                table: "PostTags",
                column: "TagId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Comments");

            migrationBuilder.DropTable(
                name: "PostCategories");

            migrationBuilder.DropTable(
                name: "PostTags");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Posts");

            migrationBuilder.DropTable(
                name: "Tags");
        }
    }
}
