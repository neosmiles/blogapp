using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace api.Migrations
{
    public partial class initialmigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Authors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Authors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BlogPosts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    AuthorId = table.Column<int>(type: "integer", nullable: false),
                    Title = table.Column<string>(type: "text", nullable: true),
                    Body = table.Column<string>(type: "text", nullable: true),
                    Timestamp = table.Column<DateTime>(type: "timestamp without time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BlogPosts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BlogPosts_Authors_AuthorId",
                        column: x => x.AuthorId,
                        principalTable: "Authors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Mildred Prohaska" },
                    { 18, "Mack Toy" },
                    { 17, "Lula Cummings" },
                    { 16, "Sophie Monahan" },
                    { 15, "Francis Wuckert" },
                    { 14, "Angie MacGyver" },
                    { 13, "Randal Harber" },
                    { 12, "Elbert Farrell" },
                    { 11, "Rachel Schimmel" },
                    { 10, "John Jenkins" },
                    { 9, "Betty Erdman" },
                    { 8, "Krystal Cole" },
                    { 7, "Hannah Cassin" },
                    { 6, "Angela Kilback" },
                    { 5, "Deborah Turcotte" },
                    { 4, "Timmy Conn" },
                    { 3, "Ken Farrell" },
                    { 2, "Tina Hamill" },
                    { 19, "Eleanor Jast" },
                    { 20, "Stanley Bergstrom" }
                });

            migrationBuilder.InsertData(
                table: "BlogPosts",
                columns: new[] { "Id", "AuthorId", "Body", "Timestamp", "Title" },
                values: new object[,]
                {
                    { 19, 1, "Dolor eos et nesciunt.\nCupiditate eos reiciendis.\nIncidunt qui ut animi ab quia est accusantium reiciendis.\nFugiat fugiat laboriosam vitae odio natus et.\nIn velit fuga ut quam quia qui dicta esse quam.\nBeatae voluptatem repudiandae molestias amet qui totam quo at facilis.\nUllam sit rem praesentium accusantium enim.\nDolor consectetur mollitia fuga est id similique non quaerat.\nVoluptatem officiis delectus nihil corporis.\nUt deserunt et.", new DateTime(2022, 10, 5, 17, 6, 30, 975, DateTimeKind.Local).AddTicks(3597), "Non qui architecto vero." },
                    { 10, 20, "Exercitationem ut sint voluptate consectetur impedit dolores.\nSit eos eum.\nIure deleniti ab.\nSunt aspernatur at autem numquam voluptatum voluptate.\nSit eius ut aut at tenetur nobis tempora quas quisquam.\nArchitecto minima beatae.\nDicta nihil nihil modi dignissimos non earum vel.\nSunt ducimus hic architecto deleniti ut quia illum dolores.\nReprehenderit aut rem occaecati neque autem blanditiis nesciunt.\nNam velit aut ut aut ducimus voluptas.", new DateTime(2022, 10, 5, 17, 6, 30, 974, DateTimeKind.Local).AddTicks(9858), "Ipsa ipsum sit voluptas." },
                    { 9, 20, "Repellendus saepe sit ab cupiditate ullam aut in sed.\nVelit sequi neque laboriosam dolorum.\nVoluptatibus voluptatum consectetur.\nNecessitatibus doloribus voluptate dolor magnam.\nEos voluptas asperiores earum nemo facilis voluptas.\nUt culpa itaque.\nQuo et doloremque maiores rem repellat maiores perspiciatis.\nNulla repellat vero.\nUt quaerat commodi reiciendis quibusdam corrupti voluptas.\nSint odio omnis culpa deserunt voluptatibus assumenda enim eos.", new DateTime(2022, 10, 5, 17, 6, 30, 974, DateTimeKind.Local).AddTicks(9440), "Perspiciatis maxime ducimus est." },
                    { 7, 20, "Doloremque laudantium vel beatae veritatis animi tempore et adipisci praesentium.\nAut dolor illo neque aut voluptatum ex odit aut.\nNihil facilis temporibus consectetur.\nAutem est iste vero.\nMaxime cupiditate est voluptatem quia cumque laboriosam dicta quisquam.\nEt eaque veniam aliquid eius harum voluptas praesentium beatae occaecati.\nIpsa et expedita est illum accusantium necessitatibus.\nConsequatur eveniet architecto laboriosam quidem ab atque provident minus voluptas.\nDolores ut eum sequi.\nEum ea odio ut iste accusantium enim.", new DateTime(2022, 10, 5, 17, 6, 30, 974, DateTimeKind.Local).AddTicks(8552), "Repellat a ratione reiciendis." },
                    { 30, 19, "Dolorem soluta molestias.\nQuidem sunt fugiat aut dolorem dolore.\nAut et recusandae quae impedit voluptatem animi aliquid.\nEaque omnis perferendis voluptas expedita minus velit eum quisquam.\nQuod nulla minus qui.\nExplicabo optio harum facilis quam sed error exercitationem qui rerum.\nAut tenetur corrupti modi in occaecati odit eius consequatur iure.\nQuod voluptas ut saepe consequatur magnam expedita molestias.\nRatione totam sapiente tenetur perferendis est tenetur recusandae numquam.\nAtque molestiae quia quisquam fuga et.", new DateTime(2022, 10, 5, 17, 6, 30, 975, DateTimeKind.Local).AddTicks(7817), "Porro quia praesentium ut." },
                    { 4, 19, "Velit veritatis dolore veritatis voluptatem ea.\nMaxime in enim inventore et ad sint.\nDolorem et voluptatem dolorem eos.\nQui et laudantium ducimus iste.\nPossimus nam quasi rerum iure.\nDelectus modi aut minima quod.\nNatus consectetur sunt impedit et.\nDoloribus aut et quia quia.\nVoluptatem aliquid odio dolor officia adipisci dolor et totam aut.\nVitae voluptas harum tempore fugit enim nostrum eum.", new DateTime(2022, 10, 5, 17, 6, 30, 974, DateTimeKind.Local).AddTicks(7284), "Aut qui quia culpa." },
                    { 29, 18, "Possimus earum et nobis error.\nQuo rerum tempora qui.\nSapiente aliquid nulla sunt alias.\nSunt dolorum et non iste.\nUt quia adipisci et porro aut rerum qui nemo architecto.\nRepudiandae quis aut eos sed in ut nulla quae.\nQuo dicta ea expedita necessitatibus et.\nNihil odio eos est sed.\nMinima molestias consequatur.\nQuia fugiat minima vel reiciendis necessitatibus provident.", new DateTime(2022, 10, 5, 17, 6, 30, 975, DateTimeKind.Local).AddTicks(7456), "Et autem inventore quia." },
                    { 18, 17, "Qui molestiae sit aut mollitia ipsam officiis architecto nobis sit.\nOptio doloremque quam qui molestiae aut doloribus quibusdam sit natus.\nMaxime laudantium ut ipsam.\nOmnis earum dolores magni esse.\nEt modi non rem ipsam in est quia.\nNeque rerum voluptatem.\nBlanditiis quidem dolorum rerum est.\nIusto fugiat nihil quos sit accusamus voluptatem minima ab explicabo.\nUnde ab atque voluptatem.\nVelit inventore blanditiis optio deserunt.", new DateTime(2022, 10, 5, 17, 6, 30, 975, DateTimeKind.Local).AddTicks(3207), "Dolorum maiores incidunt dolorem." },
                    { 23, 15, "Voluptas itaque id repudiandae quis quia at recusandae est repudiandae.\nConsequuntur aperiam numquam nihil laudantium.\nDolor sit culpa et.\nLibero culpa amet.\nRerum est deserunt doloremque nemo.\nEt dolorem debitis harum autem est assumenda perspiciatis non.\nQui architecto delectus voluptatibus at cumque.\nVoluptatem voluptas aliquid aperiam similique ratione.\nUt sequi qui odit.\nNeque laboriosam et id blanditiis.", new DateTime(2022, 10, 5, 17, 6, 30, 975, DateTimeKind.Local).AddTicks(5118), "Aut provident numquam voluptatem." },
                    { 16, 15, "Ipsa et qui repudiandae nesciunt.\nPraesentium assumenda nisi est nulla maiores.\nTotam cumque autem atque.\nVel et voluptas et quasi nisi eum possimus aut.\nOdit et mollitia non cupiditate harum consequuntur enim.\nAutem voluptates molestiae quos maiores quo itaque odit.\nOdit minus sed recusandae sed.\nFacere beatae dignissimos quia.\nDeleniti dicta ea nisi qui distinctio voluptatum.\nRepudiandae laudantium officia nisi.", new DateTime(2022, 10, 5, 17, 6, 30, 975, DateTimeKind.Local).AddTicks(2371), "Id vitae error debitis." },
                    { 24, 14, "Voluptate quidem et suscipit reiciendis mollitia et.\nVelit sit quaerat sit.\nA temporibus eos sit nam.\nRerum et nam modi voluptas.\nCupiditate totam molestias quis.\nCommodi quidem mollitia dolorem rerum qui sint vel ut tempore.\nCupiditate optio eos ut aut aliquid est.\nFugiat pariatur tempore molestiae accusantium tempore maxime esse.\nNon qui consequuntur odit repudiandae nihil illum dolorum id aspernatur.\nReprehenderit rerum quia.", new DateTime(2022, 10, 5, 17, 6, 30, 975, DateTimeKind.Local).AddTicks(5475), "Et suscipit autem libero." },
                    { 26, 11, "Sed accusamus odit est dolorem et reiciendis eaque officia qui.\nQuos vitae culpa iusto magnam.\nQuia optio eveniet repellendus libero.\nNon reprehenderit reprehenderit voluptas et explicabo voluptatem et quas quidem.\nIste quo id enim ea nihil officia praesentium.\nSaepe iure quisquam laboriosam et sunt quaerat qui sed.\nMagnam quia sed itaque culpa aliquam.\nAspernatur architecto earum odio cum placeat.\nVel voluptatem est excepturi dicta omnis asperiores enim quia.\nEaque eos libero ab cumque sit quo consequatur temporibus.", new DateTime(2022, 10, 5, 17, 6, 30, 975, DateTimeKind.Local).AddTicks(6226), "Et labore dolorem voluptatem." },
                    { 15, 11, "Maxime eaque aut aliquam aliquid est ullam nemo.\nA commodi doloribus dolorem nostrum distinctio praesentium.\nPraesentium illo autem consequatur magnam harum necessitatibus dicta velit.\nPerferendis et placeat.\nEst vel qui.\nReprehenderit dolores quidem rerum voluptas.\nEt nobis facere animi quae dolor exercitationem aspernatur vitae.\nUnde quo totam soluta dolores.\nSint dolorem itaque provident quis et.\nHic possimus dolor quo hic enim quia velit illum.", new DateTime(2022, 10, 5, 17, 6, 30, 975, DateTimeKind.Local).AddTicks(1990), "Eos aut necessitatibus nulla." },
                    { 5, 11, "Fugit sapiente sed praesentium.\nReprehenderit unde ut ipsum voluptatem eaque.\nRepellendus quidem omnis et consequuntur necessitatibus praesentium ducimus aut vel.\nTempore officiis autem in dolorem.\nId esse sunt quos consequatur voluptatum ut.\nSequi sit impedit adipisci ut sequi enim quidem.\nNon expedita est quae.\nSit et et.\nMinus est dignissimos qui.\nIllum est sapiente iusto et rerum eum omnis.", new DateTime(2022, 10, 5, 17, 6, 30, 974, DateTimeKind.Local).AddTicks(7672), "Neque et voluptatem hic." },
                    { 8, 10, "Quo quas cum qui non repudiandae inventore iste cumque est.\nId aut doloremque dolorum ut.\nSuscipit expedita quo aperiam tempora blanditiis.\nEt voluptatem dolor qui mollitia alias velit.\nDolorem sed voluptatem suscipit quas.\nInventore rem explicabo et soluta quo eos ut.\nRepellat eligendi in tenetur rerum quae.\nSapiente corrupti ab sunt provident saepe magni voluptatum a cumque.\nHic voluptates error consequatur.\nIn cumque minima amet et.", new DateTime(2022, 10, 5, 17, 6, 30, 974, DateTimeKind.Local).AddTicks(9001), "Laboriosam modi nihil expedita." },
                    { 25, 9, "Et sed ipsum.\nVoluptas blanditiis eos eligendi non similique quos velit voluptatibus.\nAnimi dolor perspiciatis.\nLaborum ad quia minima ad magnam.\nAd necessitatibus rerum labore minus molestiae minima omnis.\nVoluptatem explicabo minima nemo voluptatem.\nVeniam quia velit dolorem id vel.\nRepudiandae id est ratione tempore repellendus.\nPossimus qui voluptas et sit similique error dolores.\nDeleniti rerum numquam nihil facilis aut.", new DateTime(2022, 10, 5, 17, 6, 30, 975, DateTimeKind.Local).AddTicks(5861), "Eligendi aut qui ut." },
                    { 17, 8, "Vero accusantium magni ut unde.\nQuis laborum quia placeat consequatur dolor ducimus amet.\nFacere incidunt quis molestias dicta voluptas quia commodi omnis adipisci.\nOccaecati iure qui pariatur consequatur veniam consequatur voluptas officia.\nMolestiae dolore ut facere.\nSed corrupti est consequatur id perferendis in qui rerum vero.\nOdio ullam unde provident nam quis ipsa qui magni.\nRerum quia maxime vitae consequatur soluta mollitia et quia voluptatibus.\nPossimus sed facilis quo quidem hic blanditiis aut sed.\nDicta asperiores sit nulla et eius inventore atque inventore sed.", new DateTime(2022, 10, 5, 17, 6, 30, 975, DateTimeKind.Local).AddTicks(2741), "Dicta aut rerum eum." },
                    { 11, 8, "Quo ea rerum.\nConsequatur est placeat provident qui magnam.\nRerum est tempore et ut voluptatem pariatur.\nAb voluptate quo quam sed dolor earum et quo mollitia.\nNatus provident ut ipsam eos quasi harum.\nQuis nulla voluptate alias enim nesciunt reprehenderit fuga voluptatem.\nVoluptatem totam non voluptate reiciendis et libero quia maiores.\nTempora veritatis voluptatibus eaque recusandae et eligendi quae tempore.\nSed perspiciatis ut quas voluptatum qui.\nEa dignissimos quaerat est omnis dolorum at natus.", new DateTime(2022, 10, 5, 17, 6, 30, 975, DateTimeKind.Local).AddTicks(275), "Temporibus aliquam sapiente libero." },
                    { 2, 8, "Quo fuga doloribus eos ab.\nNam voluptatibus et atque aut deserunt neque.\nBlanditiis minus corrupti et qui enim id a.\nUt quia aperiam alias impedit illum voluptas quia ut.\nInventore veritatis consequatur laborum a expedita veniam nostrum.\nEt rem ipsa.\nDolores iure impedit est corrupti exercitationem a.\nIn possimus pariatur rerum.\nPerferendis unde tenetur neque aut ad distinctio earum odit.\nFacilis sed provident asperiores ducimus reiciendis expedita nisi.", new DateTime(2022, 10, 5, 17, 6, 30, 974, DateTimeKind.Local).AddTicks(5948), "Aut hic est rem." },
                    { 20, 7, "Enim molestiae fugit dignissimos et a ullam.\nDolore quidem incidunt suscipit qui velit.\nItaque aut aut sequi.\nVoluptatibus cum assumenda asperiores sunt sunt et odit.\nNobis voluptas numquam placeat quae laboriosam consequatur blanditiis assumenda omnis.\nQuisquam blanditiis porro quasi architecto.\nDucimus dolor maxime iure dolor illo illum nesciunt deserunt.\nNesciunt sed aliquid molestiae explicabo adipisci et.\nAutem perferendis officia ea architecto consequatur atque.\nQuia et ut non.", new DateTime(2022, 10, 5, 17, 6, 30, 975, DateTimeKind.Local).AddTicks(3984), "Voluptatem itaque aut pariatur." },
                    { 3, 7, "Dolorem minima repudiandae iure ducimus deleniti nemo sapiente ut eos.\nId suscipit repudiandae sint velit vel libero doloremque.\nEt provident a ullam excepturi modi sint velit.\nSuscipit odit fugit non a asperiores qui.\nAd dolores fuga voluptas nobis.\nReprehenderit aliquid impedit rerum.\nEum aut molestiae ipsa accusamus accusamus recusandae quidem.\nLaborum officiis modi error eveniet.\nHarum aperiam non aut vel sint.\nQuo odit quia voluptate quam vel vel error.", new DateTime(2022, 10, 5, 17, 6, 30, 974, DateTimeKind.Local).AddTicks(6842), "Nemo quo eveniet et." },
                    { 28, 6, "Enim porro architecto.\nRerum exercitationem sit sit eum vel et similique.\nPerferendis dolorum qui optio ut voluptates.\nExercitationem provident molestiae et est est.\nTotam sint ea excepturi.\nEst ea aut voluptatem dolorem possimus nisi tempora et.\nOptio reiciendis in autem.\nVeniam sed tempore ipsam molestias.\nNobis id id autem enim et asperiores.\nQuo et reiciendis.", new DateTime(2022, 10, 5, 17, 6, 30, 975, DateTimeKind.Local).AddTicks(7103), "Perferendis deleniti blanditiis sequi." },
                    { 6, 4, "Aliquam rem modi sapiente eaque quidem voluptatem sint.\nSed optio in quis.\nVoluptas quod perspiciatis modi sunt ex saepe totam in quisquam.\nEst at placeat dolores et non.\nQui ab dolore.\nExcepturi qui ea rerum qui eveniet molestias molestiae.\nQuas distinctio reprehenderit itaque quam alias laborum in.\nAt repellendus saepe quas omnis aliquid repellendus.\nQuam voluptatem quia et aliquam ut maxime.\nTempora vel illum fuga.", new DateTime(2022, 10, 5, 17, 6, 30, 974, DateTimeKind.Local).AddTicks(8073), "Perspiciatis fugiat ut officiis." },
                    { 1, 4, "Nostrum qui deleniti recusandae repellendus asperiores.\nDicta voluptatum quos et dicta deserunt aspernatur sint eum.\nInventore porro iste enim aliquam optio aut.\nUt reprehenderit nam vel.\nUt sit id rerum quae porro provident deleniti.\nSuscipit qui ea error modi quibusdam odio est in cupiditate.\nSunt debitis velit quod nesciunt.\nQuia quis omnis.\nId explicabo impedit fugiat tenetur veritatis.\nTenetur ab sed exercitationem dicta dolorem.", new DateTime(2022, 10, 5, 17, 6, 30, 972, DateTimeKind.Local).AddTicks(4607), "Expedita recusandae sint exercitationem." },
                    { 13, 3, "Molestiae quidem non distinctio architecto omnis excepturi cupiditate.\nDebitis voluptatem est rerum aliquid sit aspernatur in sed ullam.\nAutem beatae quos et non ut totam.\nConsequatur consequuntur recusandae praesentium neque cum qui cumque et neque.\nOdit modi quis vel tempore est vitae est vero.\nAb modi recusandae laudantium perferendis voluptas pariatur.\nEt dolores odit exercitationem.\nPorro facere rerum eos est enim ut.\nNam velit suscipit consectetur voluptatem consequatur.\nQui aliquam ducimus minima est commodi possimus ut.", new DateTime(2022, 10, 5, 17, 6, 30, 975, DateTimeKind.Local).AddTicks(1115), "Et ab omnis iste." },
                    { 12, 3, "Perferendis dicta et provident nemo et quis et.\nTotam nisi tenetur rerum labore id.\nVoluptatem non fugiat aut.\nCum est ipsa tempore odio.\nVoluptatum consequatur vero ut.\nQuia minus occaecati praesentium in aut.\nMinima enim laboriosam eaque.\nVel animi cum et tenetur molestiae voluptatibus modi quisquam.\nVel laboriosam commodi dolorem vero accusamus.\nSaepe quaerat unde non at harum non porro.", new DateTime(2022, 10, 5, 17, 6, 30, 975, DateTimeKind.Local).AddTicks(722), "Consequatur voluptatem iste aliquid." },
                    { 27, 1, "Sit molestiae id sint.\nMolestiae numquam rerum eos sapiente ipsa pariatur.\nIllo ex voluptatum earum aut minus eveniet odio.\nEum qui quod aut et necessitatibus quo.\nRerum alias hic ex quasi quo.\nAutem et autem dolorem dolores aut.\nDistinctio atque sunt.\nEt natus odio laborum quis debitis porro molestiae ut quia.\nQuam asperiores voluptas non reprehenderit architecto eaque eveniet reprehenderit.\nOccaecati dicta ratione beatae ea architecto rerum dolor exercitationem id.", new DateTime(2022, 10, 5, 17, 6, 30, 975, DateTimeKind.Local).AddTicks(6668), "Eum dolores voluptatem omnis." },
                    { 22, 1, "Odio ipsum sunt omnis nam.\nDolor est voluptatum quod error qui eaque suscipit at.\nIllum pariatur ratione sint sequi ut mollitia natus.\nCupiditate aut qui magnam.\nFacere voluptatem impedit voluptatem quam repellat asperiores consequatur.\nNon commodi sed et distinctio.\nExercitationem voluptatem et perspiciatis voluptatem eaque voluptas eaque qui.\nQuia sunt non.\nQui placeat dolor in temporibus doloribus et.\nNecessitatibus sint at.", new DateTime(2022, 10, 5, 17, 6, 30, 975, DateTimeKind.Local).AddTicks(4741), "Vero eligendi amet aspernatur." },
                    { 14, 20, "Consequatur doloremque cum vel est expedita fuga.\nPlaceat voluptatum quam a inventore eum vel mollitia.\nOptio voluptatem voluptatem quia consequatur.\nDolorem est magnam a at rerum et praesentium.\nUllam et ullam eum expedita vel impedit ut architecto explicabo.\nAut eos est corporis autem sunt in.\nQui doloremque qui ut iste nisi pariatur consequuntur.\nCumque est repellendus rerum perferendis.\nExpedita eos vitae molestiae earum necessitatibus.\nAut architecto incidunt corporis quo sapiente eaque rerum qui omnis.", new DateTime(2022, 10, 5, 17, 6, 30, 975, DateTimeKind.Local).AddTicks(1557), "Asperiores ratione ut animi." },
                    { 21, 20, "Ea mollitia molestias repellendus in officia blanditiis maxime.\nSuscipit esse quo quaerat cupiditate voluptatem sequi ad.\nDolorem ipsa aut.\nEt ut recusandae sit amet et.\nPraesentium velit sit et ea fugiat quo illo.\nEt repellat hic.\nQuo ratione autem quis ut.\nQuas consequatur nihil eos dolorem vitae.\nVoluptatibus est ut at vel in iure.\nConsectetur eos qui.", new DateTime(2022, 10, 5, 17, 6, 30, 975, DateTimeKind.Local).AddTicks(4382), "Optio et suscipit consequuntur." }
                });

            migrationBuilder.CreateIndex(
                name: "IX_BlogPosts_AuthorId",
                table: "BlogPosts",
                column: "AuthorId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BlogPosts");

            migrationBuilder.DropTable(
                name: "Authors");
        }
    }
}
