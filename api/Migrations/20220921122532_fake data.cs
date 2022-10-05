using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace api.Migrations
{
    public partial class fakedata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Authors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Authors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BlogPosts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AuthorId = table.Column<int>(type: "int", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Body = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Timestamp = table.Column<DateTime>(type: "datetime2", nullable: false)
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
                    { 1, "Tiffany Kerluke" },
                    { 18, "Lucas Pouros" },
                    { 17, "Tammy Moore" },
                    { 16, "Randall White" },
                    { 15, "Sherri Schmitt" },
                    { 14, "Arnold Hand" },
                    { 13, "Raquel Homenick" },
                    { 12, "Kristopher Purdy" },
                    { 11, "Debra Jacobs" },
                    { 10, "Eduardo Hermann" },
                    { 9, "Nettie Prohaska" },
                    { 8, "Sheila Klein" },
                    { 7, "Krystal Schumm" },
                    { 6, "Alberta Fay" },
                    { 5, "Elvira Gerhold" },
                    { 4, "Sara Smith" },
                    { 3, "Andrew Schneider" },
                    { 2, "Jeffery Bradtke" },
                    { 19, "Ken Lesch" },
                    { 20, "Erma Von" }
                });

            migrationBuilder.InsertData(
                table: "BlogPosts",
                columns: new[] { "Id", "AuthorId", "Body", "Timestamp", "Title" },
                values: new object[,]
                {
                    { 17, 1, "Totam ipsa laboriosam esse.\nAut ipsam itaque occaecati excepturi sint reprehenderit nemo corporis facilis.\nFugiat sint quasi soluta ea recusandae dolores totam.\nAtque natus facere et totam id aut.\nMagni reprehenderit harum minima.\nRepellendus numquam velit quo non dolores nobis ad sit.\nVoluptates quis sit asperiores sequi.\nQui provident et officiis et excepturi quia error quis.\nEst harum quaerat.\nVoluptates perferendis eum aut.", new DateTime(2022, 9, 21, 13, 25, 31, 479, DateTimeKind.Local).AddTicks(2323), "Sit repudiandae tempora laudantium." },
                    { 28, 17, "Velit tempora minus dolorem ea ratione sit repellat nemo.\nSit dolorem quos est dolorem a omnis tempora sed.\nAut alias quod et.\nAd nam qui excepturi adipisci sapiente animi.\nConsequatur ex et occaecati iste.\nQuia at dicta at sequi aut hic.\nDolor doloribus at deleniti harum voluptatibus.\nOptio velit corrupti.\nMollitia vitae atque id atque aut rerum qui.\nCorrupti suscipit ut iusto sed et aut.", new DateTime(2022, 9, 21, 13, 25, 31, 479, DateTimeKind.Local).AddTicks(7374), "Labore eos amet nemo." },
                    { 7, 17, "Doloribus aut itaque enim voluptatem corporis quisquam.\nNemo non deserunt omnis consequuntur corporis nam occaecati voluptas est.\nNecessitatibus id et dignissimos itaque assumenda quia aut.\nQuia quisquam saepe impedit minima inventore molestias pariatur in soluta.\nSuscipit libero minus.\nAd distinctio ad architecto consequuntur.\nEnim accusantium velit id eaque reiciendis.\nDistinctio alias et cumque exercitationem et soluta officia ipsam aut.\nEt quibusdam illum rerum neque et.\nModi accusamus assumenda ipsum minima.", new DateTime(2022, 9, 21, 13, 25, 31, 478, DateTimeKind.Local).AddTicks(7541), "Et sit labore non." },
                    { 27, 15, "Nihil perferendis iste.\nVeritatis et ut sequi quo.\nCorporis illum ut fugiat ipsa labore iusto placeat.\nEa eveniet cum a non dolor.\nSit voluptatem quisquam sit vero eligendi alias in reiciendis temporibus.\nQuas minima numquam quia id tempore ut.\nNemo praesentium voluptatem non atque sequi.\nIure adipisci neque placeat illo ut ratione dolores.\nQuia et qui repellendus laborum vel assumenda vero aliquam est.\nTotam sit vitae nesciunt consequatur doloribus est accusamus rem nesciunt.", new DateTime(2022, 9, 21, 13, 25, 31, 479, DateTimeKind.Local).AddTicks(6875), "Deserunt quam repellendus mollitia." },
                    { 2, 15, "Similique atque facilis.\nMollitia neque et nam et.\nMagnam dignissimos et nobis architecto.\nFacere repellendus enim recusandae.\nRerum ipsum expedita aut dolorem consequatur architecto cum esse rerum.\nMolestiae fuga dolor ipsum id corrupti enim ipsa quo repellendus.\nAccusantium laboriosam veniam exercitationem ipsa laboriosam animi tempore rerum.\nQui ab nobis.\nMaiores modi est aliquid molestiae.\nQui quam commodi occaecati debitis quas ut non voluptatem excepturi.", new DateTime(2022, 9, 21, 13, 25, 31, 478, DateTimeKind.Local).AddTicks(4430), "Molestiae qui voluptas sit." },
                    { 21, 14, "Qui et aliquid.\nDolor ut praesentium facere.\nIpsam eius aliquam accusantium facere sit quia nostrum.\nOfficia vero ab.\nEt non aliquam.\nOdit quis minus corrupti.\nExcepturi quasi dignissimos.\nSint molestias omnis non error.\nConsequuntur officia aliquid vitae consequatur.\nEnim corrupti dignissimos iste.", new DateTime(2022, 9, 21, 13, 25, 31, 479, DateTimeKind.Local).AddTicks(4270), "Nulla sed voluptatem tempora." },
                    { 11, 13, "Provident soluta magni ut.\nVoluptates alias reprehenderit et nam voluptate enim quidem.\nUt cumque et quis iure reiciendis.\nDistinctio fugit est blanditiis autem perspiciatis dolor voluptatibus minima possimus.\nSuscipit et officiis.\nConsequatur voluptatibus animi a.\nDolor quia maiores optio perspiciatis.\nFugit sed recusandae corrupti non.\nEt ad officiis similique atque consequatur officiis commodi.\nVelit facilis voluptates autem reiciendis sed iste placeat saepe.", new DateTime(2022, 9, 21, 13, 25, 31, 478, DateTimeKind.Local).AddTicks(9643), "Et eius ipsa deleniti." },
                    { 14, 12, "Mollitia soluta quod consequatur voluptas voluptatem et natus quam.\nPerspiciatis voluptatum ullam.\nEst ea tenetur.\nMolestiae exercitationem esse libero.\nFuga nisi vel odio.\nEst consequuntur sint itaque temporibus.\nQuae accusantium praesentium nam ut quo in molestias ut.\nTenetur culpa qui incidunt est neque.\nVoluptatem deleniti quaerat voluptate non praesentium fugit distinctio doloremque qui.\nVoluptates nostrum dolores id est.", new DateTime(2022, 9, 21, 13, 25, 31, 479, DateTimeKind.Local).AddTicks(1074), "Voluptates quas et omnis." },
                    { 25, 11, "Magnam tempora doloribus explicabo alias exercitationem iusto quidem eligendi optio.\nNulla alias aliquid minus veritatis repellendus blanditiis eligendi.\nAccusantium sed quos nemo dolorum omnis.\nOmnis sint praesentium.\nNostrum error vero dolore quaerat modi voluptatem.\nVoluptatem repudiandae similique maxime ut.\nMagni placeat est.\nTotam quia ut repellat architecto et quo minus nobis rem.\nTempora rerum porro incidunt.\nConsequatur minima qui.", new DateTime(2022, 9, 21, 13, 25, 31, 479, DateTimeKind.Local).AddTicks(5983), "Aut eligendi est totam." },
                    { 15, 11, "Deserunt quisquam voluptates et eum.\nVoluptas tempora quia soluta atque ipsum magnam praesentium.\nEx sed similique nisi consequatur itaque perferendis.\nMollitia earum eveniet ut saepe.\nNon odit eius.\nAsperiores rerum ut et dolores et dignissimos saepe.\nEt culpa molestiae quia dolore qui sequi dolor ut.\nId minima sit.\nEa ipsam corrupti recusandae quia officiis dolor.\nIn ut et quaerat in asperiores vero fuga itaque ut.", new DateTime(2022, 9, 21, 13, 25, 31, 479, DateTimeKind.Local).AddTicks(1538), "Voluptatem qui rerum quis." },
                    { 1, 11, "Possimus ullam quaerat ut optio harum non quo doloribus inventore.\nVoluptatem at facilis dolores aut vitae et quia occaecati.\nAliquam illo molestiae et neque.\nSed asperiores autem voluptas.\nIn odit doloribus necessitatibus nesciunt numquam cumque.\nArchitecto impedit et totam cumque consequuntur iusto minus eum similique.\nSint enim qui sed quas et eum dolorum.\nCorrupti velit voluptas laborum numquam aliquam fuga.\nExpedita dolore vel et sed laboriosam ducimus et.\nOfficia qui quibusdam est esse.", new DateTime(2022, 9, 21, 13, 25, 31, 476, DateTimeKind.Local).AddTicks(2172), "Qui quam mollitia sint." },
                    { 24, 10, "Soluta maiores ut ducimus illo repellat adipisci.\nDolorem autem voluptatibus labore a.\nOdio quia quae voluptas voluptatem illo quis cumque.\nNisi pariatur perspiciatis necessitatibus non.\nMagnam voluptatum alias non neque tempora a asperiores est.\nVoluptate cumque vitae voluptatem perferendis facilis officiis.\nPariatur eius ad qui repellendus enim maxime incidunt reiciendis.\nConsequatur mollitia excepturi aut voluptatem ducimus sunt ipsam.\nDoloremque autem et atque non ex sit et aliquid sed.\nLabore cumque aut placeat eaque quo.", new DateTime(2022, 9, 21, 13, 25, 31, 479, DateTimeKind.Local).AddTicks(5504), "Consectetur et suscipit quibusdam." },
                    { 12, 10, "Consequuntur hic voluptates deleniti et inventore ab.\nDolorem vel quo sequi alias expedita quia ipsum qui.\nPraesentium assumenda deleniti beatae voluptatem similique aut.\nQuis eaque aperiam et eius aut perspiciatis.\nOdio provident ut reprehenderit recusandae.\nEa at vitae repellat eos quae omnis explicabo similique.\nA fugiat incidunt delectus inventore.\nHarum nisi quis.\nNobis aut facere qui nesciunt doloremque laborum libero numquam.\nEnim laboriosam nam cumque voluptate fuga repellat quia molestiae.", new DateTime(2022, 9, 21, 13, 25, 31, 479, DateTimeKind.Local).AddTicks(113), "Est et eligendi minus." },
                    { 10, 10, "Iste quis est aliquid qui.\nNam eos iste in dolorem exercitationem culpa voluptatibus velit.\nSapiente ad mollitia est exercitationem quod.\nLabore ducimus aut in in asperiores enim consequatur.\nRerum voluptatum consequuntur.\nFugiat officiis rerum cum omnis.\nVoluptatem deleniti nihil assumenda facere.\nId dicta enim et velit.\nQuasi vel dolorum voluptate ut itaque dolore voluptatem et veniam.\nQuae et aut vero rerum perspiciatis sunt.", new DateTime(2022, 9, 21, 13, 25, 31, 478, DateTimeKind.Local).AddTicks(9194), "Ut necessitatibus autem placeat." },
                    { 8, 10, "Atque odit labore vitae qui consectetur sunt dolor.\nIpsa accusamus illo impedit a dolor.\nConsequatur voluptas et consequatur eos voluptates corporis illum aut.\nCorrupti est alias qui.\nEnim repellendus saepe fugiat est aliquam.\nNumquam et quis voluptatibus sunt aliquam ex illum inventore non.\nPorro labore iste accusamus non fugiat.\nAut nihil ut molestiae cumque pariatur dolor.\nHarum iste ut illum quia consequatur cupiditate sit fugit doloribus.\nAut qui quae laudantium nostrum aspernatur ad tempora quis numquam.", new DateTime(2022, 9, 21, 13, 25, 31, 478, DateTimeKind.Local).AddTicks(8119), "Dolore aut corrupti saepe." },
                    { 4, 10, "Voluptate esse quia et.\nConsequatur quidem voluptas ut consequuntur nisi ea.\nVel delectus quis omnis dolorum sunt ea sapiente eos possimus.\nDelectus deleniti ratione ea vero veniam.\nImpedit ut pariatur.\nExplicabo rerum laborum ipsum odit ab fuga excepturi magni voluptas.\nMaiores et neque fugit aut.\nIusto aperiam adipisci enim distinctio quo.\nAperiam nam incidunt totam veritatis sed quidem et.\nBlanditiis accusamus nihil.", new DateTime(2022, 9, 21, 13, 25, 31, 478, DateTimeKind.Local).AddTicks(6017), "Est odit non qui." },
                    { 6, 9, "Maiores vero et libero minus ut et.\nTotam esse ducimus nesciunt voluptatibus facilis ipsa soluta.\nMagni ut et id autem aperiam.\nIncidunt quo et expedita omnis sint quia aut nam doloremque.\nSunt unde quod quod.\nSaepe quia ut maiores assumenda et et aperiam temporibus quod.\nMinima modi tempore molestiae consectetur.\nCupiditate odio sit aperiam qui repudiandae hic non rerum.\nHic sint hic dolores rerum iure.\nEst atque magnam ab sed et aspernatur.", new DateTime(2022, 9, 21, 13, 25, 31, 478, DateTimeKind.Local).AddTicks(7028), "Expedita voluptate voluptas quia." },
                    { 29, 8, "Ut rerum id distinctio quo voluptas et.\nNemo rerum qui vero.\nQuos voluptas dolore animi quod ut eius et rerum dignissimos.\nQuam ad reiciendis aut maxime tempore.\nEveniet ea aut dolor animi.\nDolorem in natus ut ipsam sit reprehenderit in culpa.\nNeque eaque odit nihil.\nQuia quae consectetur perferendis odio veniam.\nOdio ut excepturi praesentium.\nSoluta et blanditiis maiores enim labore vel omnis.", new DateTime(2022, 9, 21, 13, 25, 31, 479, DateTimeKind.Local).AddTicks(7846), "Accusantium ratione officia voluptatem." },
                    { 20, 8, "Hic est quis error earum nesciunt eum debitis aut reprehenderit.\nAut neque atque aut numquam quisquam velit aut.\nVeniam sit eum sed ab.\nPlaceat expedita quo porro veritatis id odio.\nMaiores ut incidunt eos atque officia odio quas eos.\nBlanditiis facere iste.\nOfficia dolorem et numquam atque quam quidem.\nIure dolorem excepturi voluptatem voluptate quia ipsa eum sit eos.\nUllam et fugiat voluptatibus vero molestiae iure.\nDolor aut voluptatem nam ullam et modi et tempore.", new DateTime(2022, 9, 21, 13, 25, 31, 479, DateTimeKind.Local).AddTicks(3732), "Temporibus et praesentium est." },
                    { 30, 7, "Illo quo doloremque.\nVeritatis rerum dolore vero in ex repellendus dolorem nesciunt.\nQui a non blanditiis vero unde impedit.\nConsequuntur quaerat pariatur quibusdam.\nEst veritatis laborum autem architecto enim eum incidunt.\nVelit provident qui illum iure dolorem.\nAspernatur sed ratione vitae quibusdam adipisci iure et.\nVoluptatem sequi ut ut quo assumenda ut voluptatem sint.\nQuibusdam sapiente error impedit at est ex.\nUnde cum consequatur eaque.", new DateTime(2022, 9, 21, 13, 25, 31, 479, DateTimeKind.Local).AddTicks(8278), "Impedit magnam sed nihil." },
                    { 3, 6, "Qui non assumenda minus beatae.\nEarum accusamus non sunt dolores vero et voluptatem.\nEligendi velit quibusdam sit est reiciendis.\nEsse sed odio quasi velit et placeat ullam rerum.\nIpsum libero ea et culpa optio voluptates.\nVoluptatum quos doloribus nemo consequatur quae repudiandae alias.\nIn nobis consequatur.\nSed nisi inventore fugit ut exercitationem consequatur sit excepturi.\nTempora est sint.\nHic eos quaerat aut porro necessitatibus fuga magni.", new DateTime(2022, 9, 21, 13, 25, 31, 478, DateTimeKind.Local).AddTicks(5422), "Explicabo dolorem aut qui." },
                    { 5, 4, "Fuga optio et dolores ut et quod enim.\nEnim et et et iusto incidunt sapiente.\nOdio qui sequi qui.\nMagni vel recusandae.\nNostrum eligendi eos ipsa ducimus qui vero facilis aperiam.\nRepellat ut omnis.\nQui autem id commodi quidem in aut iusto consectetur consectetur.\nUnde corrupti sit quia et.\nQuo natus fugit hic ab velit voluptatum.\nDolores autem aut ea eius sapiente mollitia soluta eum.", new DateTime(2022, 9, 21, 13, 25, 31, 478, DateTimeKind.Local).AddTicks(6563), "Ducimus maiores nemo laboriosam." },
                    { 26, 3, "Voluptatum praesentium autem hic ut.\nAut eum in qui eos reprehenderit.\nQuos tenetur provident cupiditate ut.\nSunt explicabo doloremque at excepturi totam libero pariatur est.\nQuas fuga quibusdam odit fuga animi dignissimos.\nRepellendus esse maiores incidunt voluptas enim voluptatem sunt soluta architecto.\nAmet similique hic corporis minus eaque ad dignissimos est.\nDeleniti animi quidem in et.\nEum nisi veniam.\nSaepe molestias laborum quod quia aut vero aliquam.", new DateTime(2022, 9, 21, 13, 25, 31, 479, DateTimeKind.Local).AddTicks(6427), "Voluptatum voluptas cupiditate consequuntur." },
                    { 18, 3, "Dolor laboriosam sequi veniam nulla veniam veniam quod.\nAliquid in vero est ea voluptatem enim necessitatibus.\nOmnis nesciunt quisquam ab sit sequi consequatur saepe.\nQuia eos ullam exercitationem dolorem consequatur ut explicabo laudantium ea.\nPorro consequatur est.\nEt et est.\nQuis reiciendis maiores.\nDelectus at perferendis error repudiandae qui voluptatem repellat sint.\nExercitationem odit aut molestiae illo ut ab blanditiis enim natus.\nAt repudiandae unde eum est ratione aut eum ipsam est.", new DateTime(2022, 9, 21, 13, 25, 31, 479, DateTimeKind.Local).AddTicks(2789), "Vero atque error quisquam." },
                    { 16, 3, "Et sed id officiis enim sunt et reprehenderit distinctio.\nDolores amet consequatur optio sed.\nFuga dolorum consequatur.\nDolorum maiores similique neque.\nMinima architecto cumque dolorem adipisci.\nLibero qui libero minima.\nDolores nemo nobis.\nEst odit mollitia voluptatem vero tempore.\nEt dolor explicabo excepturi omnis minus aut.\nNam quidem in omnis.", new DateTime(2022, 9, 21, 13, 25, 31, 479, DateTimeKind.Local).AddTicks(1961), "Eos in id ipsum." },
                    { 13, 2, "Eum sunt culpa minima reprehenderit.\nIste sit veritatis architecto aliquid aspernatur et quo aut iusto.\nDebitis omnis perferendis et ipsum provident natus et ab nemo.\nEnim eos voluptate ut alias exercitationem est blanditiis doloremque iure.\nSaepe quo voluptatem id fuga illo non dolores atque.\nEt quia ea optio quod.\nNumquam eaque voluptatem nulla nisi deserunt facilis impedit.\nLibero vel aspernatur sed.\nEt ea dolores.\nAut corporis ullam.", new DateTime(2022, 9, 21, 13, 25, 31, 479, DateTimeKind.Local).AddTicks(610), "Consequatur minima rem facere." },
                    { 22, 1, "Eos voluptates asperiores nesciunt dicta voluptatem et.\nNihil sit qui quas voluptatem.\nProvident rerum accusantium sed et deleniti voluptatem magni.\nDoloribus autem aut nostrum recusandae alias.\nCumque odio id.\nQuis pariatur numquam ea incidunt.\nNisi illo autem.\nLaborum consequatur tempora quod accusantium dolores ea.\nVitae aperiam velit consequatur laudantium consequatur commodi quia minus.\nExercitationem fuga atque qui voluptas.", new DateTime(2022, 9, 21, 13, 25, 31, 479, DateTimeKind.Local).AddTicks(4617), "Et quis consequatur excepturi." },
                    { 19, 1, "Et ex commodi qui.\nSed assumenda impedit nam voluptatem.\nAt ut alias eum libero molestiae.\nFugit itaque laudantium sit tempora qui non et animi nisi.\nSint aut aspernatur est vitae.\nAut rerum esse omnis minus ratione quo quisquam sed.\nQuaerat voluptas ipsam omnis nisi omnis ab eius.\nEst veritatis consequuntur dolor recusandae maxime sint.\nMolestiae maxime enim eum et blanditiis.\nEst quisquam aut qui.", new DateTime(2022, 9, 21, 13, 25, 31, 479, DateTimeKind.Local).AddTicks(3235), "Amet repellat sit dignissimos." },
                    { 9, 18, "Fugiat sit temporibus non occaecati aut dolores dolorum quibusdam omnis.\nDicta quos consectetur modi.\nAut provident hic placeat possimus sapiente.\nVoluptas nihil fuga necessitatibus quod omnis fugit aut.\nEos aperiam eligendi alias quia veritatis voluptatum beatae est.\nNam quod eos consectetur minus explicabo.\nVelit natus est aut excepturi numquam accusamus laboriosam laudantium quas.\nRepudiandae reprehenderit voluptas soluta ut atque tempora praesentium et eius.\nQui inventore accusamus.\nSit exercitationem itaque.", new DateTime(2022, 9, 21, 13, 25, 31, 478, DateTimeKind.Local).AddTicks(8630), "Odio aliquam veritatis voluptatem." },
                    { 23, 19, "Illum dolores explicabo possimus qui.\nMaiores expedita unde voluptates et.\nEt ex nihil earum commodi iure quia eaque.\nAutem doloremque omnis.\nEos totam quae ipsam velit nisi laudantium dolor.\nUt eveniet ipsam dolore rerum harum vel.\nSit ea molestiae hic dolorum temporibus inventore.\nDelectus nostrum laudantium officia minima dignissimos odit suscipit aut nobis.\nEarum nisi dolores error ea eveniet suscipit dicta aut fuga.\nPlaceat in expedita.", new DateTime(2022, 9, 21, 13, 25, 31, 479, DateTimeKind.Local).AddTicks(5031), "Sit soluta tempore fuga." }
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
