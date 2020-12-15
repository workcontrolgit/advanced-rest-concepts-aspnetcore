using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Entities.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "owner",
                columns: new[] { "OwnerId", "Address", "DateOfBirth", "Name" },
                values: new object[,]
                {
                    { new Guid("e545d578-e509-2d55-498a-544ddf36132e"), "789 Ricardo Coves, South Mona, Belgium", new DateTime(2020, 8, 23, 21, 56, 21, 465, DateTimeKind.Local).AddTicks(3671), "Pearl Murazik" },
                    { new Guid("e3cb99e3-9f0b-5f07-f133-385704fc077d"), "304 Lind Squares, Emoryside, Burkina Faso", new DateTime(2019, 12, 23, 13, 48, 1, 705, DateTimeKind.Local).AddTicks(9134), "Carissa Batz" },
                    { new Guid("d38c5c12-5679-c2ec-97fa-71868e600785"), "970 Kenyatta Mill, Christiansenland, Zimbabwe", new DateTime(2020, 11, 27, 17, 1, 42, 921, DateTimeKind.Local).AddTicks(4365), "Elna Shanahan" },
                    { new Guid("26f2daaa-77fb-8d29-2779-12e17b7a9cce"), "87594 Ryan Hill, Devanfort, American Samoa", new DateTime(2020, 1, 13, 0, 42, 39, 776, DateTimeKind.Local).AddTicks(9613), "Josie Shields" },
                    { new Guid("9cabc77d-0b3a-300e-7dce-4e7b8fd20224"), "54874 Lubowitz Dale, East Julie, Israel", new DateTime(2020, 1, 25, 1, 30, 19, 348, DateTimeKind.Local).AddTicks(6728), "Olin Gerlach" },
                    { new Guid("f0b3fdf7-4c32-c482-6600-f1ff37123a0d"), "9874 Cummerata Islands, Lake Estellfurt, Russian Federation", new DateTime(2020, 10, 22, 12, 3, 9, 438, DateTimeKind.Local).AddTicks(4294), "Sigurd Will" },
                    { new Guid("4ed49777-3c33-3b10-1bb0-fdf88c0772b2"), "5703 Bergnaum Forges, Welchton, French Southern Territories", new DateTime(2020, 1, 12, 10, 21, 6, 426, DateTimeKind.Local).AddTicks(4704), "Maria Homenick" },
                    { new Guid("7ac08ad8-bf66-91ba-04a6-132381e49254"), "251 Cordelia Field, Ondrickabury, Cambodia", new DateTime(2020, 8, 1, 23, 8, 54, 996, DateTimeKind.Local).AddTicks(2601), "Bianka Cormier" },
                    { new Guid("1f2a62fd-4702-4cf7-9a6f-f29c51c101fd"), "464 Bailey Inlet, Connellyside, Guyana", new DateTime(2020, 5, 29, 9, 1, 55, 537, DateTimeKind.Local).AddTicks(1162), "Eva Yundt" },
                    { new Guid("16cf8929-57c0-8fc4-0d4b-1eb280b7db2b"), "5245 Thiel Landing, Lake Moisesview, Slovenia", new DateTime(2020, 11, 3, 10, 23, 18, 676, DateTimeKind.Local).AddTicks(471), "Magdalen Hermiston" },
                    { new Guid("8112c816-40ab-2da5-b073-08db1edc7384"), "428 Strosin Ville, Strackefurt, Barbados", new DateTime(2020, 7, 14, 18, 4, 43, 848, DateTimeKind.Local).AddTicks(9430), "Tressa Graham" },
                    { new Guid("6a5fe15b-c9ef-35a9-31b3-5771731e010d"), "272 Marlin View, New Marleeville, Tajikistan", new DateTime(2019, 12, 15, 12, 55, 13, 850, DateTimeKind.Local).AddTicks(2985), "Sibyl Klocko" },
                    { new Guid("f9ad8f15-72bf-bb83-3808-63036ac5cf45"), "3623 Feest Walks, Lake Roelview, Cook Islands", new DateTime(2020, 7, 1, 17, 37, 44, 822, DateTimeKind.Local).AddTicks(1871), "Anne Ziemann" },
                    { new Guid("71e35c2f-4e07-08b6-7eda-e4f882271ab5"), "98170 Henri Stream, Bogisichmouth, Pakistan", new DateTime(2020, 10, 6, 4, 48, 56, 557, DateTimeKind.Local).AddTicks(6782), "Walton Muller" },
                    { new Guid("eb683a9e-ead4-db8d-c24d-ad1207d9a76f"), "651 Yost Knoll, North Hirammouth, Bangladesh", new DateTime(2020, 1, 31, 18, 40, 1, 125, DateTimeKind.Local).AddTicks(294), "Dasia Stoltenberg" },
                    { new Guid("ece4404f-c9b1-b195-5818-bf0fdf86a6c4"), "18230 Stephany Green, Bernitashire, Andorra", new DateTime(2020, 8, 9, 15, 18, 49, 628, DateTimeKind.Local).AddTicks(9375), "Marilou Bernier" },
                    { new Guid("f4c6c3f0-beba-1aea-cc35-9e23c4f0c41c"), "81035 Larson Row, Garrisonbury, Tokelau", new DateTime(2020, 4, 19, 11, 16, 45, 975, DateTimeKind.Local).AddTicks(8347), "Dock Hirthe" },
                    { new Guid("dfc3ee9d-8fcf-7bb9-d8d3-d16397a2a8dd"), "3171 Labadie Lake, Lake Gayleside, Sri Lanka", new DateTime(2020, 11, 2, 2, 15, 32, 539, DateTimeKind.Local).AddTicks(2184), "Letha Gleichner" },
                    { new Guid("01022637-d43c-9c84-0d11-4a77db91e36f"), "696 Raoul Dale, West Marcelinoview, Rwanda", new DateTime(2020, 10, 30, 23, 22, 11, 14, DateTimeKind.Local).AddTicks(3157), "Kade Bruen" },
                    { new Guid("7b60d1c5-dca6-08b8-9519-3c758803ac3a"), "85809 Cronin Summit, South Adellaport, Wallis and Futuna", new DateTime(2020, 8, 11, 7, 16, 59, 845, DateTimeKind.Local).AddTicks(3353), "Johan Erdman" },
                    { new Guid("67310ab1-6fc9-4ad8-783b-63a09145abc9"), "2129 Madison Harbor, Lake Erinside, Ireland", new DateTime(2020, 2, 28, 2, 14, 13, 483, DateTimeKind.Local).AddTicks(4068), "Ruby Kirlin" },
                    { new Guid("09a25175-6ce8-2d06-fe84-013270567239"), "09845 Batz Place, Hirtheport, Heard Island and McDonald Islands", new DateTime(2020, 6, 18, 19, 57, 24, 587, DateTimeKind.Local).AddTicks(4138), "Glenda Ortiz" },
                    { new Guid("08f31cf9-22c0-3c70-10ef-449296fa68b1"), "3217 Edna Park, East Corbinburgh, Spain", new DateTime(2020, 10, 19, 8, 26, 13, 471, DateTimeKind.Local).AddTicks(93), "Dina Huels" },
                    { new Guid("7e3976b7-4531-3afc-d481-35a4e3d101a3"), "535 Ford Green, South Verlie, Egypt", new DateTime(2020, 11, 11, 22, 18, 51, 100, DateTimeKind.Local).AddTicks(9000), "Stuart Purdy" },
                    { new Guid("de3bcc02-2e84-6833-ec51-aa02941bc548"), "10331 Gutmann Well, West Tierra, Niger", new DateTime(2020, 5, 14, 20, 10, 19, 52, DateTimeKind.Local).AddTicks(150), "Kory Torphy" },
                    { new Guid("a7d73399-7df2-6675-03f2-6d1aa250b0c5"), "54898 McKenzie Center, Runolfssonburgh, Gibraltar", new DateTime(2020, 10, 27, 22, 0, 10, 810, DateTimeKind.Local).AddTicks(9272), "Lulu Steuber" },
                    { new Guid("ede8faae-dca1-486c-bab9-1b4b777142bd"), "9218 Lizeth Mountain, Clayside, Puerto Rico", new DateTime(2020, 11, 17, 16, 59, 20, 639, DateTimeKind.Local).AddTicks(5542), "Rozella Schowalter" },
                    { new Guid("55f39ae2-d8c8-72f2-e009-a572d8c8315a"), "041 Zemlak Shores, East Aaliyahstad, Indonesia", new DateTime(2020, 6, 3, 11, 56, 36, 402, DateTimeKind.Local).AddTicks(7398), "Rhianna Will" },
                    { new Guid("e2f4811e-9d48-4429-a4fc-21f5b61321d0"), "67258 Roma Ranch, Deckowfort, French Guiana", new DateTime(2020, 2, 18, 19, 37, 14, 690, DateTimeKind.Local).AddTicks(5087), "Maia Koepp" },
                    { new Guid("dd69efc9-ec7d-56f5-ce63-99ce4efa66fc"), "23281 Ruecker Freeway, East Weldonchester, Eritrea", new DateTime(2019, 12, 28, 11, 36, 15, 585, DateTimeKind.Local).AddTicks(3171), "Liam Bode" },
                    { new Guid("0a83d7ce-122e-0564-9a3e-257db84cd7ed"), "94292 Zoie Springs, Miguelland, Tanzania", new DateTime(2020, 2, 3, 0, 51, 34, 87, DateTimeKind.Local).AddTicks(9472), "Emelia Effertz" },
                    { new Guid("5b0e4b09-2119-1a89-9aaf-99f1161f4263"), "3783 Rafaela Square, South Marcellus, Mauritania", new DateTime(2020, 8, 5, 0, 3, 6, 996, DateTimeKind.Local).AddTicks(7060), "Alexane Botsford" },
                    { new Guid("8de4047c-989d-f060-6605-9496158de087"), "873 Camila Spring, East Jaunitaland, Bahrain", new DateTime(2020, 3, 31, 0, 25, 16, 113, DateTimeKind.Local).AddTicks(5884), "Joany Lang" },
                    { new Guid("48d57dd1-1fd5-0a04-ba34-9a2e7f995072"), "44625 Nitzsche Plains, Noemimouth, Tuvalu", new DateTime(2020, 11, 28, 16, 14, 9, 69, DateTimeKind.Local).AddTicks(1963), "Brielle Koch" },
                    { new Guid("b797c5f0-b298-5e4f-2f4a-7a97c0a58b7e"), "30732 Boyer Stravenue, West Axel, Reunion", new DateTime(2020, 8, 25, 7, 41, 24, 39, DateTimeKind.Local).AddTicks(6479), "Madge Bradtke" },
                    { new Guid("b9d38e55-23ba-2b8f-55d1-1be2b25319dc"), "488 Denesik Lakes, Conroychester, Albania", new DateTime(2020, 1, 22, 21, 51, 42, 546, DateTimeKind.Local).AddTicks(5436), "Layla Becker" },
                    { new Guid("6ba5aa30-b717-9dc5-dfb9-1622d1503fd8"), "761 Hugh Way, Enriquefurt, Spain", new DateTime(2020, 2, 23, 13, 45, 16, 887, DateTimeKind.Local).AddTicks(5062), "Chesley Jakubowski" },
                    { new Guid("eadd2c93-0c37-02e8-2589-d9bf624f3f7b"), "5589 Crooks Coves, Savannatown, Ireland", new DateTime(2020, 7, 3, 7, 7, 0, 769, DateTimeKind.Local).AddTicks(4868), "Cloyd Legros" },
                    { new Guid("f583c620-65f4-cb08-f7f8-b55ceabb513d"), "958 Danny Circle, West Adeliaside, American Samoa", new DateTime(2020, 10, 25, 14, 25, 40, 848, DateTimeKind.Local).AddTicks(3579), "Kiarra Ledner" },
                    { new Guid("9c9eca07-49cb-a387-2e88-8ca908e745fb"), "4138 Muller Crescent, West Shanelle, Montenegro", new DateTime(2020, 2, 22, 12, 24, 55, 913, DateTimeKind.Local).AddTicks(3748), "Kelly Hayes" },
                    { new Guid("1f54cdcb-b41c-6b71-3ecd-deb0ada7cc02"), "831 Manuel Manor, South Olinshire, Equatorial Guinea", new DateTime(2020, 6, 23, 4, 36, 57, 256, DateTimeKind.Local).AddTicks(4212), "Mara Von" },
                    { new Guid("3bdd07b1-2592-f0de-6954-d2fd972539cd"), "8775 Thaddeus Squares, Martineburgh, Cocos (Keeling) Islands", new DateTime(2020, 10, 29, 11, 38, 0, 97, DateTimeKind.Local).AddTicks(7353), "Brenden Heaney" }
                });

            migrationBuilder.InsertData(
                table: "owner",
                columns: new[] { "OwnerId", "Address", "DateOfBirth", "Name" },
                values: new object[,]
                {
                    { new Guid("a6ff775b-90ca-4370-5aaa-af5c4a1eface"), "2287 Palma Heights, Percivalside, Vietnam", new DateTime(2020, 9, 9, 8, 22, 53, 741, DateTimeKind.Local).AddTicks(450), "Amos Streich" },
                    { new Guid("1fa2d526-9226-5103-999a-9e830f786492"), "661 Roob Throughway, East Selmerburgh, Malta", new DateTime(2020, 6, 13, 19, 12, 55, 934, DateTimeKind.Local).AddTicks(7602), "Carroll Rippin" },
                    { new Guid("75359947-db7c-eca8-56e9-9bc8dbb6e2b9"), "02859 Caesar Green, Willstad, Argentina", new DateTime(2020, 2, 10, 11, 44, 52, 871, DateTimeKind.Local).AddTicks(798), "Jeramy Lueilwitz" },
                    { new Guid("43753bbd-16ef-b4ec-f9dd-2f5ed005882a"), "521 Cesar Villages, Lake Mariamfurt, Norway", new DateTime(2020, 9, 7, 8, 24, 42, 507, DateTimeKind.Local).AddTicks(253), "Laisha Rogahn" },
                    { new Guid("7a1e78a2-756c-e2db-1ae8-9b51cdce6aba"), "30429 Einar Inlet, Whitebury, Montserrat", new DateTime(2020, 6, 9, 23, 16, 48, 796, DateTimeKind.Local).AddTicks(5784), "Clark Ebert" },
                    { new Guid("e758bc90-be0e-f544-2a7d-c3b1c5d039cf"), "6720 Zion Skyway, Johnsonbury, Spain", new DateTime(2020, 5, 26, 23, 48, 43, 342, DateTimeKind.Local).AddTicks(7169), "Esta Mueller" },
                    { new Guid("113c636f-d311-2f4a-1fa1-13e2e0c05e08"), "88209 Bahringer Cliffs, Port Patience, Monaco", new DateTime(2020, 10, 28, 12, 3, 58, 297, DateTimeKind.Local).AddTicks(5156), "Greg Blick" },
                    { new Guid("936241fe-be28-582d-714a-b54c5ff2ecf8"), "359 Mills Lodge, Port Brucestad, Mali", new DateTime(2020, 10, 24, 2, 26, 58, 590, DateTimeKind.Local).AddTicks(7030), "Terry Gutkowski" },
                    { new Guid("7ee18d6f-74fb-26d9-2df6-1177e1e41b92"), "3114 Rylan Plains, South Doloresview, Yemen", new DateTime(2020, 5, 20, 9, 25, 4, 237, DateTimeKind.Local).AddTicks(2034), "Lloyd Renner" },
                    { new Guid("10d2dce2-fc6d-6017-1aff-e23035ea277b"), "54536 Schaefer Track, Port Billyborough, Honduras", new DateTime(2020, 8, 13, 4, 1, 22, 649, DateTimeKind.Local).AddTicks(8159), "Leola Hilpert" },
                    { new Guid("814907ff-c3e0-7086-7277-988d5eab6115"), "651 Marquardt Common, East Tristian, Uganda", new DateTime(2020, 9, 25, 0, 55, 43, 303, DateTimeKind.Local).AddTicks(841), "Thaddeus Treutel" },
                    { new Guid("ebf28ab2-3220-6878-0fe0-d4d38178978b"), "66059 Elody Path, Octaviabury, Norfolk Island", new DateTime(2020, 6, 12, 6, 34, 10, 503, DateTimeKind.Local).AddTicks(6437), "Abby Lueilwitz" },
                    { new Guid("6c02e610-40bf-c0e3-e3e4-241bc9624755"), "2590 Zulauf Creek, Fritschmouth, Micronesia", new DateTime(2020, 9, 26, 0, 39, 12, 573, DateTimeKind.Local).AddTicks(3816), "Colleen Gulgowski" },
                    { new Guid("9271877b-1f95-49fa-4ffa-68577c3899c0"), "2308 Boyer Port, Schulistport, Lebanon", new DateTime(2020, 4, 17, 10, 34, 15, 641, DateTimeKind.Local).AddTicks(7973), "Kaycee Russel" },
                    { new Guid("419f9d01-b5f1-d7c0-e357-9671b21e6d66"), "5179 Benjamin Lock, Romagueraborough, Sri Lanka", new DateTime(2020, 6, 12, 6, 56, 10, 688, DateTimeKind.Local).AddTicks(1965), "Jena Reynolds" },
                    { new Guid("de56901c-5898-8ace-7f8e-6b60dc6e4351"), "95019 Adelbert Lakes, Carolinehaven, Saint Helena", new DateTime(2020, 10, 26, 23, 49, 48, 432, DateTimeKind.Local).AddTicks(5486), "Daija Reichel" },
                    { new Guid("c7225481-cd8f-6e97-de23-15296c2c3a38"), "759 Gottlieb Stream, Sebastianchester, Cuba", new DateTime(2020, 6, 21, 18, 40, 34, 882, DateTimeKind.Local).AddTicks(5361), "Chadd Rogahn" },
                    { new Guid("de0ce7e7-d05d-1720-46b7-4fcc6553cc3c"), "282 Mina Circle, Littlechester, Kazakhstan", new DateTime(2020, 8, 26, 10, 27, 29, 778, DateTimeKind.Local).AddTicks(5715), "Duncan Bauch" },
                    { new Guid("535ee8a9-c2dd-b90c-848c-78d96c92422c"), "84305 Lesch Pine, Gottliebmouth, Faroe Islands", new DateTime(2020, 7, 9, 6, 58, 11, 321, DateTimeKind.Local).AddTicks(8465), "Julia VonRueden" },
                    { new Guid("9d7e513b-ee78-a618-5e18-af5719cb35dc"), "602 Emerson Shoal, Wiegandmouth, Iraq", new DateTime(2020, 9, 29, 9, 5, 26, 507, DateTimeKind.Local).AddTicks(3244), "Cristian Orn" },
                    { new Guid("3180dfe5-c340-5d8f-faeb-391b140341d2"), "3899 Kreiger Gateway, New Chayaside, Congo", new DateTime(2020, 9, 15, 6, 57, 44, 377, DateTimeKind.Local).AddTicks(8254), "Aliya O'Kon" },
                    { new Guid("e05afad1-343a-fc23-d588-834dca70de19"), "9708 Katelin Causeway, West Nellefurt, Haiti", new DateTime(2020, 4, 21, 2, 37, 47, 750, DateTimeKind.Local).AddTicks(1547), "Dorthy Walter" },
                    { new Guid("5bcb003c-cb6e-3c7a-78b3-0e1eb879f4c4"), "762 Reuben Camp, West Jayden, Virgin Islands, U.S.", new DateTime(2020, 8, 2, 9, 34, 4, 661, DateTimeKind.Local).AddTicks(8579), "Shaniya Bogisich" },
                    { new Guid("8e99b768-126f-49bd-8a82-a106ceca8dae"), "1287 Renner Prairie, Wehnerport, Barbados", new DateTime(2020, 2, 27, 23, 21, 24, 600, DateTimeKind.Local).AddTicks(5293), "Lorna Huel" },
                    { new Guid("66a535a7-ea1e-b184-9f1c-719a20368156"), "51620 Koepp Road, North Chrisview, Honduras", new DateTime(2020, 6, 21, 0, 19, 38, 168, DateTimeKind.Local).AddTicks(8026), "Franz Morar" },
                    { new Guid("2625985e-9f90-b1d2-2dd4-b114d1c92f52"), "38775 Friesen Crossroad, Nonamouth, Liechtenstein", new DateTime(2020, 2, 5, 4, 26, 36, 18, DateTimeKind.Local).AddTicks(6465), "Jody Hane" },
                    { new Guid("31e9d7be-3bfb-be0c-e8d5-b792f4d5c68f"), "375 Jeanette Prairie, Velvaburgh, Jordan", new DateTime(2020, 2, 1, 10, 21, 11, 431, DateTimeKind.Local).AddTicks(4951), "Crystel Morissette" },
                    { new Guid("136a350c-45f1-9021-ecdd-42bdcef3ce69"), "5269 Timothy Prairie, Kossmouth, Denmark", new DateTime(2020, 1, 20, 21, 45, 20, 489, DateTimeKind.Local).AddTicks(2604), "Aryanna Kshlerin" },
                    { new Guid("5daa3680-c28a-49d4-f5f5-3f2eacfeecfb"), "9500 Bradtke Roads, Port Cassietown, Croatia", new DateTime(2020, 9, 28, 13, 35, 27, 219, DateTimeKind.Local).AddTicks(8452), "Claire Jenkins" },
                    { new Guid("49973c91-df71-c0de-eb3d-145b420e0430"), "21903 Gulgowski Fords, Port Shirley, Belize", new DateTime(2020, 4, 19, 19, 57, 57, 256, DateTimeKind.Local).AddTicks(4018), "Maximus Schoen" },
                    { new Guid("54c11a19-84b2-9980-edeb-f8811682a10b"), "628 Klein Rest, Port Garretstad, Saint Barthelemy", new DateTime(2020, 7, 20, 3, 28, 42, 176, DateTimeKind.Local).AddTicks(9260), "Miguel Gutkowski" },
                    { new Guid("f329e67c-db43-f44d-520f-2ced511f2116"), "777 Carroll Run, Eleanoraton, Libyan Arab Jamahiriya", new DateTime(2020, 7, 27, 6, 24, 2, 221, DateTimeKind.Local).AddTicks(7121), "Cathryn Gerlach" },
                    { new Guid("04fdff2b-5930-c7ae-c9fd-453812cfcba1"), "886 Talon Circles, Port Nona, Andorra", new DateTime(2020, 9, 24, 16, 32, 12, 41, DateTimeKind.Local).AddTicks(9667), "Manuel Padberg" },
                    { new Guid("00a2d748-54ee-f01a-bd89-df91b5c1d340"), "290 O'Conner Spring, Trinityhaven, Tuvalu", new DateTime(2020, 7, 21, 14, 28, 35, 834, DateTimeKind.Local).AddTicks(40), "Kayla Kreiger" },
                    { new Guid("fd514c52-7061-ddce-4dbb-fe0442a5d583"), "683 Chesley Course, Hoegerville, Lesotho", new DateTime(2020, 2, 9, 0, 28, 18, 968, DateTimeKind.Local).AddTicks(898), "Antonina Bailey" },
                    { new Guid("8c6d6f53-6445-72c4-d07f-b9e0ccb2e66b"), "9599 Littel Crossroad, Lake Erling, Italy", new DateTime(2020, 2, 8, 16, 39, 17, 600, DateTimeKind.Local).AddTicks(8737), "Scottie Nicolas" },
                    { new Guid("94ab3502-18d5-1e8f-6d2a-833d41662947"), "324 Alfred Viaduct, South Frankie, Gabon", new DateTime(2020, 2, 14, 18, 12, 36, 774, DateTimeKind.Local).AddTicks(8652), "Emmy Kovacek" },
                    { new Guid("dd04ec19-0796-9651-2a5f-2469ccc654df"), "561 Emanuel Rapids, Heidenreichhaven, Bermuda", new DateTime(2020, 7, 2, 19, 33, 40, 159, DateTimeKind.Local).AddTicks(9285), "Reina Walter" },
                    { new Guid("69f04811-3d50-9289-4025-254cecc109c3"), "5560 Hickle Haven, Port Milfordmouth, Norway", new DateTime(2020, 8, 15, 19, 50, 47, 472, DateTimeKind.Local).AddTicks(8210), "Tiana Dickens" },
                    { new Guid("db2112be-035d-1ba1-9bce-0256f25b0e86"), "8081 Walsh Crossing, Port Chaz, Portugal", new DateTime(2020, 2, 13, 13, 16, 35, 462, DateTimeKind.Local).AddTicks(7115), "Maritza Thompson" },
                    { new Guid("ae2db918-e7e7-86e6-cbc0-242ffa67e748"), "330 Deshawn Spring, Farrellburgh, Guam", new DateTime(2020, 2, 21, 16, 13, 35, 70, DateTimeKind.Local).AddTicks(4663), "Ophelia Krajcik" },
                    { new Guid("3e78f4fb-2d39-9f5f-fa76-a54ff9bce350"), "4043 Virgil Trail, East Lavinia, Nicaragua", new DateTime(2020, 6, 3, 6, 21, 15, 289, DateTimeKind.Local).AddTicks(234), "Trevor Bayer" }
                });

            migrationBuilder.InsertData(
                table: "owner",
                columns: new[] { "OwnerId", "Address", "DateOfBirth", "Name" },
                values: new object[,]
                {
                    { new Guid("3a29df32-2881-1aae-c728-1693caa2de21"), "79319 Ramiro Haven, Betsyberg, Mozambique", new DateTime(2020, 8, 2, 19, 46, 1, 853, DateTimeKind.Local).AddTicks(9476), "Alisa Weber" },
                    { new Guid("93191d75-cea8-f8a2-481a-4b793c508301"), "6296 Hazle Points, Harveyview, Canada", new DateTime(2020, 2, 21, 14, 12, 9, 331, DateTimeKind.Local).AddTicks(8715), "Dominique Hermann" },
                    { new Guid("8554365a-8dc5-b873-392e-ab9d21f1e80d"), "452 Ulises Underpass, Hudsonbury, Belarus", new DateTime(2020, 7, 22, 14, 43, 20, 875, DateTimeKind.Local).AddTicks(5452), "Oceane Kiehn" },
                    { new Guid("1fb2030a-fc05-3cfd-a11f-d027c38fdd50"), "84589 Carter Key, Turcotteburgh, Jamaica", new DateTime(2020, 1, 16, 3, 2, 54, 375, DateTimeKind.Local).AddTicks(5113), "Karolann Bernier" },
                    { new Guid("6f9aa18b-e3d2-9611-1a0c-fd3532a8aac5"), "780 Kuvalis Plains, West Susanastad, Luxembourg", new DateTime(2020, 7, 12, 6, 2, 16, 378, DateTimeKind.Local).AddTicks(714), "Joyce Jaskolski" },
                    { new Guid("ee377fc1-e142-49f9-03e5-e282fd5dce21"), "5564 Rolfson Viaduct, West Jordynshire, Heard Island and McDonald Islands", new DateTime(2020, 7, 30, 14, 23, 33, 229, DateTimeKind.Local).AddTicks(8087), "Stephania Lockman" },
                    { new Guid("486c4d70-c9b0-75a2-74e5-52f8d2c6b64f"), "59173 Amie Stream, Port Madalyn, Antarctica (the territory South of 60 deg S)", new DateTime(2020, 10, 27, 7, 57, 4, 540, DateTimeKind.Local).AddTicks(5052), "Kathleen Pouros" },
                    { new Guid("47a806a5-2346-c5b1-dcb0-db6aa84d82e5"), "2463 Berta Route, New Jazmin, Guyana", new DateTime(2020, 1, 26, 10, 23, 3, 564, DateTimeKind.Local).AddTicks(373), "Kenna Crist" },
                    { new Guid("e6a22ed5-8a3f-dc08-0457-114e5911e998"), "229 Collins Manors, East Kennedi, Liechtenstein", new DateTime(2019, 12, 16, 3, 44, 30, 397, DateTimeKind.Local).AddTicks(8423), "Sadie Hamill" },
                    { new Guid("5afb5ea0-4cd2-b59d-b71c-7472991c75c6"), "04669 Leannon Dam, West Jeffereyburgh, Ireland", new DateTime(2020, 10, 1, 1, 17, 9, 886, DateTimeKind.Local).AddTicks(1316), "Alexandrea Sipes" },
                    { new Guid("9877ca13-f499-f219-1bd8-0f5c7c683184"), "429 Miller Glen, Rosenbaumborough, Ukraine", new DateTime(2020, 2, 27, 3, 51, 1, 456, DateTimeKind.Local).AddTicks(9459), "Yvonne Reilly" },
                    { new Guid("01cec870-ca39-e039-fbe0-32ebfb8f6526"), "449 Lorenza Flats, West Lucychester, Gambia", new DateTime(2020, 8, 26, 21, 34, 7, 523, DateTimeKind.Local).AddTicks(5260), "Isadore Waters" },
                    { new Guid("949e34ce-67ad-baf7-5c3d-b35bb81316b2"), "383 Feest Hollow, Jeramiehaven, Croatia", new DateTime(2020, 2, 13, 6, 14, 22, 67, DateTimeKind.Local).AddTicks(5020), "Rachael Hyatt" },
                    { new Guid("1df84172-f0c7-78d0-0521-981efc19d9a8"), "6898 Emmalee Meadow, East Kieraland, Maldives", new DateTime(2020, 10, 3, 11, 14, 37, 939, DateTimeKind.Local).AddTicks(9115), "Horacio Barrows" },
                    { new Guid("c0194067-4ff5-88c1-effa-3fcdb36e8ab8"), "995 McKenzie Burgs, North Luefurt, Micronesia", new DateTime(2020, 10, 2, 5, 56, 17, 5, DateTimeKind.Local).AddTicks(7833), "Oswaldo Green" },
                    { new Guid("d8942171-e8c0-510b-c2f9-b28ffe07475b"), "88930 Lindgren Mountains, Dianaport, Somalia", new DateTime(2020, 4, 10, 15, 24, 9, 973, DateTimeKind.Local).AddTicks(9674), "Adriana Daniel" },
                    { new Guid("d9925b94-f8b2-dfdc-8f4d-e48059031cd9"), "59719 Kassandra Forks, Nienowburgh, Trinidad and Tobago", new DateTime(2019, 12, 30, 17, 10, 2, 791, DateTimeKind.Local).AddTicks(9101), "Fred Baumbach" },
                    { new Guid("b5ab6a1f-bc82-9e50-af06-c93bb3fd137f"), "23356 Howe Shores, Leilanistad, Cambodia", new DateTime(2020, 8, 8, 10, 0, 15, 427, DateTimeKind.Local).AddTicks(6200), "Garry Franecki" },
                    { new Guid("70993a84-1e24-35cb-1e4b-0f92c6ad8296"), "97711 Grady Wells, Keelingberg, Swaziland", new DateTime(2019, 12, 31, 2, 42, 45, 462, DateTimeKind.Local).AddTicks(7789), "Brendon Koelpin" },
                    { new Guid("79c32e96-d50f-7692-fedb-286f6ecbcaae"), "53787 Jaylin Parkway, East Monicaville, El Salvador", new DateTime(2020, 9, 30, 19, 26, 4, 229, DateTimeKind.Local).AddTicks(9243), "Juanita Keebler" },
                    { new Guid("1cbf7f2f-67bc-3fbb-0c26-827c3d583fdc"), "6449 King Passage, Lolitamouth, Senegal", new DateTime(2020, 3, 22, 4, 27, 13, 121, DateTimeKind.Local).AddTicks(8348), "Edythe Abbott" },
                    { new Guid("4a9b4fd6-9def-0207-885f-8b5b0d3187a8"), "829 Lafayette Harbors, Hermistonfurt, Lao People's Democratic Republic", new DateTime(2020, 5, 18, 15, 5, 34, 265, DateTimeKind.Local).AddTicks(1163), "Arnold Sipes" },
                    { new Guid("a59c5a42-bded-edf5-aa42-9baa75724f26"), "6858 Skiles Centers, East Emelie, Croatia", new DateTime(2020, 2, 19, 20, 29, 50, 967, DateTimeKind.Local).AddTicks(466), "Everette Kertzmann" },
                    { new Guid("5cca3454-a955-dd42-3c89-524cb9aca1a2"), "989 Stewart Plains, Lake Trevor, Maldives", new DateTime(2020, 4, 4, 1, 32, 47, 837, DateTimeKind.Local).AddTicks(16), "Rupert Renner" },
                    { new Guid("0049574a-8b71-eb99-df76-428309bcd4be"), "297 Abernathy Springs, West Clarechester, Chad", new DateTime(2020, 3, 8, 1, 13, 5, 744, DateTimeKind.Local).AddTicks(4529), "Ibrahim Ryan" },
                    { new Guid("ddd6e6ec-b65c-3594-b0a4-8424ccd9c9d2"), "9712 Schiller Alley, North Jasenshire, Italy", new DateTime(2020, 2, 15, 9, 2, 2, 554, DateTimeKind.Local).AddTicks(222), "Lauryn Hartmann" },
                    { new Guid("acb46f67-5759-187b-bc4c-f461e5e9481b"), "019 Hugh Orchard, West Mackview, Greenland", new DateTime(2020, 7, 10, 19, 0, 4, 7, DateTimeKind.Local).AddTicks(8735), "Omari Towne" },
                    { new Guid("69657b0c-2514-2acb-398d-d040cf653bc1"), "8385 Nella Hollow, South Elmer, Guinea-Bissau", new DateTime(2019, 12, 21, 5, 52, 19, 461, DateTimeKind.Local).AddTicks(7346), "Clementine Carter" },
                    { new Guid("6a550a3b-de83-b407-25a7-c366041f52a9"), "4831 Neil Fork, Virgilmouth, Ghana", new DateTime(2020, 10, 10, 3, 3, 25, 276, DateTimeKind.Local).AddTicks(5190), "Bradly Abbott" },
                    { new Guid("c405a6c6-d10f-d53d-2014-8840b84f8ef1"), "4698 Robbie Springs, Estevantown, Greenland", new DateTime(2020, 1, 7, 0, 37, 27, 305, DateTimeKind.Local).AddTicks(4854), "Glenna Mueller" },
                    { new Guid("5da04b22-8d1a-af99-b330-07b4d9c1d776"), "2550 Robb Burg, Faheymouth, Heard Island and McDonald Islands", new DateTime(2020, 6, 7, 23, 17, 40, 502, DateTimeKind.Local).AddTicks(8549), "Loy Bergstrom" },
                    { new Guid("6d1d90e8-31af-b2d6-596e-008a96acfe48"), "89817 Ziemann Mission, Willisfort, Hong Kong", new DateTime(2020, 11, 22, 3, 4, 47, 277, DateTimeKind.Local).AddTicks(2814), "Vinnie Friesen" },
                    { new Guid("a348cb6d-c76a-9112-8e3a-a2d03290992d"), "4654 Mallory Plains, Wintheiserton, Norfolk Island", new DateTime(2020, 6, 26, 16, 15, 30, 104, DateTimeKind.Local).AddTicks(7985), "Jamel Barton" },
                    { new Guid("e029aad8-a5b5-6682-5b8b-b65d45815be8"), "804 Ryan Village, Stokesside, Panama", new DateTime(2020, 8, 11, 23, 9, 10, 980, DateTimeKind.Local).AddTicks(514), "Alexys Turner" },
                    { new Guid("f8b630ae-6787-78b8-cddb-97c2a79ff364"), "646 Shania Road, Rigobertoborough, Burkina Faso", new DateTime(2020, 4, 2, 18, 51, 7, 390, DateTimeKind.Local).AddTicks(3747), "Austyn Thompson" },
                    { new Guid("07e361d5-8e2d-d389-81c6-479215ed4805"), "253 Thompson Squares, New Willardview, Honduras", new DateTime(2020, 2, 18, 21, 27, 30, 589, DateTimeKind.Local).AddTicks(5475), "Juliana Quitzon" },
                    { new Guid("60c1e300-97c3-d5c6-c0af-ccd3e1ed0478"), "18349 Hayes Roads, Renetown, Uruguay", new DateTime(2020, 7, 12, 7, 23, 10, 935, DateTimeKind.Local).AddTicks(2501), "Treva Treutel" },
                    { new Guid("2c3192e5-42e7-c1e1-66cd-57768c9d4112"), "0981 Sabrina Ville, Cormierchester, San Marino", new DateTime(2020, 1, 26, 9, 18, 4, 356, DateTimeKind.Local).AddTicks(1752), "Chadrick Rice" },
                    { new Guid("1d5f2bad-4e29-10b4-2a41-c85c9a8237b3"), "6529 Grimes Branch, East Reina, Tuvalu", new DateTime(2020, 9, 19, 21, 24, 42, 795, DateTimeKind.Local).AddTicks(5718), "Dallin Romaguera" },
                    { new Guid("70b273be-82bc-1175-1b90-30c2f90bc250"), "84699 Jarred Fall, South Giovanniberg, Madagascar", new DateTime(2020, 2, 5, 6, 20, 1, 402, DateTimeKind.Local).AddTicks(7024), "Francisco Jacobs" },
                    { new Guid("070acadf-161b-df8b-af27-1ce1d262bd45"), "904 Mohr Drive, Lake Ramonview, Qatar", new DateTime(2020, 10, 18, 1, 55, 32, 878, DateTimeKind.Local).AddTicks(9928), "Jerald Trantow" },
                    { new Guid("bc1281c7-d010-ea21-9c0c-c06b22b194f8"), "5213 Wilderman Glens, Pollichshire, Bahamas", new DateTime(2020, 2, 29, 0, 34, 27, 524, DateTimeKind.Local).AddTicks(2208), "Zakary Roberts" }
                });

            migrationBuilder.InsertData(
                table: "owner",
                columns: new[] { "OwnerId", "Address", "DateOfBirth", "Name" },
                values: new object[,]
                {
                    { new Guid("596622ea-48f6-006c-7e88-762a097449bf"), "62969 Keyshawn Island, South Alessia, Cook Islands", new DateTime(2020, 1, 30, 21, 24, 25, 452, DateTimeKind.Local).AddTicks(9432), "Jermaine Bashirian" },
                    { new Guid("1a9b2082-3293-12e4-0871-4f4bb8adfbb7"), "71045 Chadd Port, New Alexandro, Slovenia", new DateTime(2020, 8, 24, 2, 27, 33, 593, DateTimeKind.Local).AddTicks(7008), "Theodore Windler" },
                    { new Guid("ae54867d-08a4-9d0b-d31e-5e2086ded952"), "5567 Jaquelin Forges, East Augustahaven, Saint Martin", new DateTime(2020, 3, 28, 19, 23, 45, 978, DateTimeKind.Local).AddTicks(4972), "Davin Hettinger" },
                    { new Guid("a7263b6c-4c09-0266-1132-c9ba900fe395"), "5967 Elnora Parks, Greenfelderton, Lao People's Democratic Republic", new DateTime(2020, 11, 26, 17, 44, 50, 272, DateTimeKind.Local).AddTicks(5006), "Keshawn Carroll" },
                    { new Guid("a219414e-abb3-0672-4807-d674d14b5876"), "836 Haag Manors, Port Mylene, Holy See (Vatican City State)", new DateTime(2020, 3, 31, 14, 0, 8, 573, DateTimeKind.Local).AddTicks(326), "Sim Mosciski" },
                    { new Guid("6cf6395f-f54f-e141-fa49-626a5d21601b"), "47609 Kohler Mills, West Reyesland, Togo", new DateTime(2020, 1, 28, 2, 35, 15, 816, DateTimeKind.Local).AddTicks(1956), "Dustin Waelchi" },
                    { new Guid("deda3b76-8108-4bac-49d4-80f41c53051e"), "7119 Gus Street, Rodolfostad, Mauritius", new DateTime(2020, 9, 11, 1, 2, 21, 315, DateTimeKind.Local).AddTicks(6450), "Antwan Wunsch" },
                    { new Guid("25ab1051-2340-2662-9cce-230670fba951"), "740 Kaitlyn Summit, Rebecastad, Singapore", new DateTime(2020, 1, 18, 4, 38, 55, 873, DateTimeKind.Local).AddTicks(1843), "Justine Wisozk" },
                    { new Guid("a2f6b9a1-a80c-dddf-3375-5f49d1ce5695"), "77921 Hermiston Roads, Sadyeville, Taiwan", new DateTime(2020, 2, 4, 22, 28, 16, 389, DateTimeKind.Local).AddTicks(9519), "Keeley Halvorson" },
                    { new Guid("794d82eb-9d58-56a8-7ec7-def4e8dbb586"), "32012 Batz Shore, Marjoriechester, South Africa", new DateTime(2020, 9, 4, 9, 29, 33, 893, DateTimeKind.Local).AddTicks(9426), "Judy Blick" },
                    { new Guid("094be653-281c-5541-788d-e5e741358872"), "8506 Bode Way, Lorenzotown, Uruguay", new DateTime(2020, 1, 2, 14, 20, 26, 778, DateTimeKind.Local).AddTicks(9021), "Lemuel Cassin" },
                    { new Guid("f5958a4c-7d69-b723-5edd-5f4a0e0a7f4e"), "7014 Cronin Motorway, North Adan, Virgin Islands, U.S.", new DateTime(2020, 8, 31, 11, 0, 34, 157, DateTimeKind.Local).AddTicks(8177), "Westley Bruen" },
                    { new Guid("b79b8f80-92a0-4409-082a-e3e4bec88051"), "8525 Hyatt Brook, North Tannerland, Tunisia", new DateTime(2020, 6, 6, 20, 15, 49, 572, DateTimeKind.Local).AddTicks(6374), "Delbert Larkin" },
                    { new Guid("6e7ecaa6-adc8-068d-913c-656cc4770a3c"), "7976 Enos Trail, Zboncaktown, Algeria", new DateTime(2020, 8, 4, 23, 25, 7, 485, DateTimeKind.Local).AddTicks(196), "Eino Bayer" },
                    { new Guid("fd1834d0-e202-d96f-4812-568a608f1de8"), "865 Kuvalis Circle, Lucasfurt, Madagascar", new DateTime(2020, 11, 7, 15, 15, 4, 664, DateTimeKind.Local).AddTicks(4600), "Mabel Rowe" },
                    { new Guid("9b9ef21d-5e8f-390d-79bc-f42e03792e69"), "83660 Daphnee Crossroad, Walshville, Mozambique", new DateTime(2020, 5, 5, 13, 11, 1, 710, DateTimeKind.Local).AddTicks(5147), "Jose Kuphal" },
                    { new Guid("c2983969-8df3-0a89-36fa-d6a16e975ce3"), "42280 Savanah Rue, Lake Reagan, Bahamas", new DateTime(2020, 3, 10, 19, 58, 41, 316, DateTimeKind.Local).AddTicks(9953), "Janet Breitenberg" },
                    { new Guid("95409903-1ca6-d02a-4db7-06e090c603e6"), "26369 Garrick Locks, North Christy, Czech Republic", new DateTime(2020, 5, 20, 18, 2, 22, 354, DateTimeKind.Local).AddTicks(7804), "Jarrett Koch" },
                    { new Guid("1cfd6a1a-a44d-0fa1-4277-04175adba1f1"), "203 Elenora Gateway, Port Odessa, New Zealand", new DateTime(2020, 2, 22, 15, 58, 29, 553, DateTimeKind.Local).AddTicks(5055), "Verna Schinner" },
                    { new Guid("7648716d-065b-bac9-5db4-3319eea80301"), "5120 Reginald Flat, East Lorenzport, Norfolk Island", new DateTime(2020, 6, 28, 10, 58, 11, 913, DateTimeKind.Local).AddTicks(3611), "Mertie Lind" },
                    { new Guid("12a59712-4565-6cea-5d8b-5bc811b04321"), "74121 Jillian Field, Mitchellside, Solomon Islands", new DateTime(2020, 1, 4, 22, 33, 13, 302, DateTimeKind.Local).AddTicks(9737), "Lori Lubowitz" },
                    { new Guid("5e11db39-15ef-bca5-cb72-d528d3dd1ccd"), "48623 Goldner Branch, Emmyland, Tanzania", new DateTime(2020, 2, 9, 16, 5, 30, 603, DateTimeKind.Local).AddTicks(877), "Stanton Mayert" },
                    { new Guid("32d4d812-47c3-fec0-2d5f-2237c5daa973"), "573 Halvorson Point, North Lavonton, Bangladesh", new DateTime(2020, 8, 22, 19, 26, 43, 628, DateTimeKind.Local).AddTicks(1468), "Kara Simonis" },
                    { new Guid("05c06f52-9b47-9412-be6e-66545b54f28a"), "1314 Barton Cove, Volkmanland, Thailand", new DateTime(2020, 11, 6, 0, 30, 8, 500, DateTimeKind.Local).AddTicks(6982), "Estrella Crooks" },
                    { new Guid("55e5662d-a419-8c2b-ea35-cac7bb310131"), "1647 McCullough Haven, Port Violettechester, Saint Lucia", new DateTime(2020, 3, 23, 15, 49, 8, 625, DateTimeKind.Local).AddTicks(3139), "Lionel Robel" },
                    { new Guid("6ff52600-709d-178f-42b2-b72ebb342175"), "4982 Chauncey Crossroad, Mertzville, Belize", new DateTime(2020, 2, 12, 10, 12, 52, 398, DateTimeKind.Local).AddTicks(8874), "Shany Dickens" },
                    { new Guid("0abb6795-c20c-9016-7395-b6e3162b309c"), "167 Homenick Gateway, West Garfieldmouth, Saint Lucia", new DateTime(2020, 2, 12, 0, 5, 14, 740, DateTimeKind.Local).AddTicks(9912), "Justice Nitzsche" },
                    { new Guid("3d7b9348-35be-28f4-65c8-9a920abd81ed"), "8321 Freeda Alley, South Jazmynland, Ireland", new DateTime(2020, 4, 25, 5, 44, 42, 46, DateTimeKind.Local).AddTicks(8795), "Vella Schneider" },
                    { new Guid("549859be-1678-b869-522c-13cdb6b58160"), "814 Elta Harbor, Marquardtberg, Anguilla", new DateTime(2020, 3, 16, 21, 9, 3, 187, DateTimeKind.Local).AddTicks(735), "Della Block" },
                    { new Guid("f107ef51-b395-51df-40ab-6afad43307a1"), "796 Emmie View, Robertsmouth, Trinidad and Tobago", new DateTime(2020, 1, 7, 1, 31, 33, 810, DateTimeKind.Local).AddTicks(6327), "Green Marks" },
                    { new Guid("d9fee81f-cefd-59e7-bf23-36aee077c2d5"), "296 Kunde Club, North Madisen, Uganda", new DateTime(2020, 7, 1, 7, 14, 15, 199, DateTimeKind.Local).AddTicks(3079), "Edyth Bailey" },
                    { new Guid("ddeda53a-32b2-dbf0-57fa-ca19bc195e53"), "988 West Stravenue, Lake Ignatiusside, Swaziland", new DateTime(2020, 5, 31, 10, 16, 42, 381, DateTimeKind.Local).AddTicks(6018), "Kaitlin Schimmel" },
                    { new Guid("9085f46a-6c7f-cfff-1489-9f47c5c0f2ec"), "4135 Fadel Ford, Evanland, Guinea", new DateTime(2020, 1, 21, 0, 10, 32, 137, DateTimeKind.Local).AddTicks(683), "Aliyah Bayer" },
                    { new Guid("c8af13e2-cd94-8dd3-1861-24591e7be8a6"), "2254 Hayden Rapids, Konopelskiberg, Taiwan", new DateTime(2020, 11, 7, 9, 6, 42, 256, DateTimeKind.Local).AddTicks(5098), "Norene Williamson" },
                    { new Guid("b164e8ed-2910-2657-5e37-fcb7cab45e66"), "2110 Viva Run, West Tonyton, Saint Vincent and the Grenadines", new DateTime(2020, 7, 26, 6, 50, 23, 242, DateTimeKind.Local).AddTicks(4255), "Carleton Botsford" },
                    { new Guid("16356c48-9536-c9d3-9eaf-a405e6b033aa"), "0378 Pansy Expressway, Consuelotown, French Southern Territories", new DateTime(2020, 10, 29, 12, 24, 15, 952, DateTimeKind.Local).AddTicks(6599), "Narciso Reichel" },
                    { new Guid("47820020-4f28-3a20-f03a-d4df35da9083"), "78364 Homenick Turnpike, Dougburgh, Lesotho", new DateTime(2020, 2, 7, 3, 5, 23, 252, DateTimeKind.Local).AddTicks(7451), "Quincy Willms" },
                    { new Guid("2ee5e504-81eb-c7f7-eb87-6a937ed8a9ab"), "3205 Hector Groves, South Alizemouth, Mauritania", new DateTime(2020, 8, 17, 4, 3, 54, 368, DateTimeKind.Local).AddTicks(2981), "Felicity Volkman" },
                    { new Guid("aaf530fa-c254-df60-e384-dba74b8f4fe8"), "95429 Noah Knolls, Hayesfurt, Yemen", new DateTime(2020, 11, 21, 22, 33, 13, 552, DateTimeKind.Local).AddTicks(2836), "Oma Glover" },
                    { new Guid("b4a78356-0401-88d8-4f3b-aae14756aab2"), "50622 Dominic Extensions, Maviston, Ghana", new DateTime(2020, 2, 10, 3, 57, 32, 414, DateTimeKind.Local).AddTicks(6948), "Jed Paucek" },
                    { new Guid("a70cf579-4d33-175a-8c18-8a2a46b03606"), "278 Mante Islands, Heathcoteville, Benin", new DateTime(2020, 10, 14, 12, 35, 20, 799, DateTimeKind.Local).AddTicks(4568), "Henri Howe" },
                    { new Guid("cd278ff9-9e61-a00a-8ac8-5d9bbdab3086"), "06789 Helen Landing, Huelsborough, Saint Pierre and Miquelon", new DateTime(2020, 9, 10, 3, 28, 38, 415, DateTimeKind.Local).AddTicks(3155), "Arden Donnelly" }
                });

            migrationBuilder.InsertData(
                table: "owner",
                columns: new[] { "OwnerId", "Address", "DateOfBirth", "Name" },
                values: new object[,]
                {
                    { new Guid("1e9b906d-d4e2-c268-c53f-7e4f6bc4a31b"), "6514 Stiedemann Estate, Savionside, American Samoa", new DateTime(2020, 3, 2, 11, 16, 29, 269, DateTimeKind.Local).AddTicks(2422), "Destiney Schneider" },
                    { new Guid("1a50b60c-6794-bd1f-a250-783955bd07af"), "1322 Braxton Islands, Eviestad, Saint Pierre and Miquelon", new DateTime(2020, 4, 17, 2, 28, 45, 54, DateTimeKind.Local).AddTicks(5889), "Nat Prosacco" },
                    { new Guid("b443d5b3-8874-f986-2dec-1a44f448655d"), "35834 Henry Plain, Lake Alyson, Rwanda", new DateTime(2020, 2, 25, 16, 55, 13, 857, DateTimeKind.Local).AddTicks(6508), "Verner Williamson" },
                    { new Guid("7a808508-3b52-ba92-f184-87790b0cc77c"), "360 Hahn Station, North Alvena, Belarus", new DateTime(2020, 4, 25, 7, 13, 30, 406, DateTimeKind.Local).AddTicks(4093), "Danny McKenzie" },
                    { new Guid("ec07ff16-e4c2-01e2-0233-b37956aefe5c"), "27128 Maiya Burgs, Summerland, Bulgaria", new DateTime(2019, 12, 21, 1, 21, 23, 860, DateTimeKind.Local).AddTicks(7761), "Sage Batz" },
                    { new Guid("037a70ee-051f-c497-32a6-8ef18d82f1cc"), "533 Johns Camp, Daremouth, Niger", new DateTime(2020, 2, 28, 19, 31, 11, 96, DateTimeKind.Local).AddTicks(8627), "Kenneth Kunze" },
                    { new Guid("671ecc1e-843d-2358-3e9f-f73185caa574"), "10671 Alfred Keys, Eloystad, Togo", new DateTime(2020, 4, 17, 11, 21, 40, 367, DateTimeKind.Local).AddTicks(525), "Leopold Bahringer" },
                    { new Guid("6e246fba-b31a-9747-bcfa-fce2ff64dbca"), "41675 Hoppe Lock, Hickleport, Venezuela", new DateTime(2020, 4, 11, 22, 30, 54, 964, DateTimeKind.Local).AddTicks(9754), "Lucile Haley" },
                    { new Guid("805bcbfb-0f05-9b3c-7d79-e14f9ebd22f8"), "1250 Bogisich Mission, Gloverhaven, Comoros", new DateTime(2020, 2, 28, 17, 33, 23, 882, DateTimeKind.Local).AddTicks(1243), "Jeanette Ward" },
                    { new Guid("98047cf1-4980-da6f-d6b3-693b6032feed"), "1515 Lesch Track, Lake Eusebio, Mayotte", new DateTime(2020, 5, 8, 22, 25, 38, 270, DateTimeKind.Local).AddTicks(6450), "Cleora Kertzmann" },
                    { new Guid("225d35ab-89b9-7e77-502b-aa8fe6c9cc71"), "670 Rosenbaum Glens, North Douglas, Colombia", new DateTime(2020, 4, 25, 15, 22, 12, 347, DateTimeKind.Local).AddTicks(4144), "Claudie Wilkinson" },
                    { new Guid("8fbdae97-d42a-33dc-0a40-7ede1cde93c4"), "08624 Medhurst Rue, East Raphaelle, Guernsey", new DateTime(2020, 11, 10, 1, 36, 20, 14, DateTimeKind.Local).AddTicks(8119), "Kyle Ratke" },
                    { new Guid("29e013f0-a13a-f79c-4f5e-9e55c14688c6"), "949 Sawayn Views, Port Margaretview, Indonesia", new DateTime(2020, 3, 19, 20, 59, 19, 725, DateTimeKind.Local).AddTicks(2868), "Savannah Spinka" },
                    { new Guid("cb2cc96c-9ab2-bfc1-cf6a-cd7887814a8c"), "1099 Levi Drive, New Rebecabury, Saint Barthelemy", new DateTime(2020, 3, 13, 17, 23, 58, 117, DateTimeKind.Local).AddTicks(1702), "Kristy Aufderhar" },
                    { new Guid("1af8e983-14bc-16fa-302f-6f5048016539"), "89847 Earnestine Ports, West Tony, Somalia", new DateTime(2020, 1, 19, 3, 28, 48, 439, DateTimeKind.Local).AddTicks(6540), "Noemi Hoeger" },
                    { new Guid("5197036e-b072-d1ed-c705-e2cb820956dd"), "063 Paucek Forks, Littelbury, Zambia", new DateTime(2019, 12, 18, 21, 45, 35, 60, DateTimeKind.Local).AddTicks(5094), "Hubert Stroman" },
                    { new Guid("c34bbc2e-84e2-582f-0f94-248eae3ce5be"), "4580 Champlin Circle, Weberchester, Sweden", new DateTime(2020, 11, 18, 20, 49, 54, 690, DateTimeKind.Local).AddTicks(15), "Yolanda Farrell" },
                    { new Guid("2412d9d5-92bd-23dc-7af1-bb39ef9c2fdc"), "60304 Berta Squares, North Lucasville, Saint Martin", new DateTime(2020, 8, 24, 12, 49, 7, 488, DateTimeKind.Local).AddTicks(6183), "Leila Ferry" },
                    { new Guid("90a4f43d-cec4-895c-e50f-6d2d52493a4b"), "379 Jedidiah Mountain, South Dewittfurt, Senegal", new DateTime(2020, 7, 21, 12, 25, 13, 26, DateTimeKind.Local).AddTicks(5682), "Cody Harvey" },
                    { new Guid("3b5e2cc9-4938-b316-9ff0-57ab0e29c469"), "14843 Russ Terrace, Myrtleborough, Belgium", new DateTime(2020, 3, 21, 20, 47, 11, 700, DateTimeKind.Local).AddTicks(9701), "Elouise Mohr" },
                    { new Guid("a961bb22-18ae-f253-6e46-b57a19654cb0"), "626 Hagenes Junctions, West Aimee, Kuwait", new DateTime(2020, 1, 29, 13, 25, 8, 224, DateTimeKind.Local).AddTicks(2099), "Skylar Funk" },
                    { new Guid("026343ce-eb18-e53f-621d-af2e12fd36de"), "4748 Lon Stravenue, Port Deloresshire, Saint Pierre and Miquelon", new DateTime(2020, 1, 4, 6, 11, 47, 734, DateTimeKind.Local).AddTicks(9863), "Ellis Koelpin" },
                    { new Guid("b637e75a-3362-44c5-4996-346636b360d7"), "2290 Klocko Landing, East Olaf, Faroe Islands", new DateTime(2020, 3, 27, 3, 34, 18, 261, DateTimeKind.Local).AddTicks(8471), "Beth Bahringer" },
                    { new Guid("15b8a5d6-28fe-2661-8055-67c7359b8541"), "60373 Chelsea Vista, Jarenborough, Portugal", new DateTime(2020, 2, 18, 15, 1, 22, 258, DateTimeKind.Local).AddTicks(2754), "Mitchell Greenholt" },
                    { new Guid("fa918f91-d84a-ce9f-5752-f5d3a8a3c7bf"), "628 Maximillian Heights, Obiefurt, Comoros", new DateTime(2020, 9, 29, 15, 32, 44, 295, DateTimeKind.Local).AddTicks(745), "Callie Lueilwitz" },
                    { new Guid("a46ffcb5-f40b-5947-eaa0-26a5b2484bce"), "7755 Kemmer Stream, Elroyborough, Serbia", new DateTime(2020, 8, 5, 18, 2, 58, 628, DateTimeKind.Local).AddTicks(3752), "Mariam Mitchell" },
                    { new Guid("d73fb040-ff39-cbbc-99ea-f6fd23ff1f1e"), "13946 Ned Glen, New Courtneytown, Malawi", new DateTime(2020, 2, 11, 9, 45, 26, 721, DateTimeKind.Local).AddTicks(3328), "Boyd Reichert" },
                    { new Guid("73090164-bb94-91d0-95b0-c8d0e9eb9f0a"), "3920 Daren Knolls, Port Dale, Somalia", new DateTime(2020, 5, 28, 18, 23, 43, 190, DateTimeKind.Local).AddTicks(309), "Gennaro McGlynn" },
                    { new Guid("1d9a8628-db15-2a3b-7758-51562d5e78cc"), "6108 Tromp Stream, Fadelberg, Central African Republic", new DateTime(2020, 8, 29, 22, 40, 17, 986, DateTimeKind.Local).AddTicks(3327), "Bobby Hoppe" },
                    { new Guid("63a88475-8250-36f5-9e27-0b4608531c4a"), "1132 Dietrich Wells, South Violet, Jamaica", new DateTime(2020, 8, 8, 9, 41, 11, 533, DateTimeKind.Local).AddTicks(4225), "Cordia Kunde" },
                    { new Guid("a8e16ec7-14b5-2b7b-ca9f-343747b80105"), "830 McGlynn Knolls, Kyleechester, Estonia", new DateTime(2020, 5, 17, 8, 4, 43, 340, DateTimeKind.Local).AddTicks(7678), "Stevie Brakus" },
                    { new Guid("7ff47120-719a-9473-4bfe-97743e33ad8d"), "3454 Hanna Road, Raphaellebury, Albania", new DateTime(2020, 8, 6, 3, 10, 5, 418, DateTimeKind.Local).AddTicks(1934), "Cecil Predovic" },
                    { new Guid("c613792a-3853-9367-30eb-13fa07dcc5d9"), "463 Tremblay Fields, South Daisha, Namibia", new DateTime(2020, 11, 24, 16, 6, 2, 509, DateTimeKind.Local).AddTicks(2537), "Art Schimmel" },
                    { new Guid("4a284313-1fc4-3ae6-9627-2c80a50bc16f"), "7643 Rusty Cove, Raleighshire, Bangladesh", new DateTime(2020, 9, 8, 1, 36, 26, 958, DateTimeKind.Local).AddTicks(7721), "Leonor Rempel" },
                    { new Guid("b6ff39c7-92de-b900-0b0b-760acf6ef0f5"), "870 Beatrice Burgs, West Christina, Burkina Faso", new DateTime(2020, 8, 3, 19, 28, 53, 778, DateTimeKind.Local).AddTicks(8947), "Oren Prosacco" },
                    { new Guid("b936ef68-0c6b-900a-05a3-410c91b37ea1"), "091 Donavon Glen, Cronaside, Christmas Island", new DateTime(2020, 5, 30, 13, 46, 37, 952, DateTimeKind.Local).AddTicks(444), "Jacinthe Jacobson" },
                    { new Guid("0da736ac-991b-84b4-e9e7-7d6be6614583"), "26736 Heaney Estates, Emardmouth, Qatar", new DateTime(2020, 3, 16, 1, 8, 20, 391, DateTimeKind.Local).AddTicks(8178), "Lenny Kiehn" },
                    { new Guid("ead69483-62a5-1808-7033-374b50c6f32f"), "9909 Keegan Inlet, North Eveline, Cape Verde", new DateTime(2020, 11, 30, 0, 37, 44, 238, DateTimeKind.Local).AddTicks(5638), "Johnnie Hegmann" },
                    { new Guid("cc63ea14-996f-d991-0d28-7bbc7f515c7b"), "613 Andre Pines, South Lamontshire, Saudi Arabia", new DateTime(2020, 1, 15, 5, 50, 32, 444, DateTimeKind.Local).AddTicks(6516), "Elnora Kemmer" },
                    { new Guid("66365e40-2662-07bf-4ee5-051ab8ff00b9"), "2405 Edyth Vista, West Kathryn, Equatorial Guinea", new DateTime(2020, 11, 23, 3, 31, 23, 535, DateTimeKind.Local).AddTicks(8929), "Rosario Lockman" },
                    { new Guid("207c477f-f51a-c818-55a0-c869502395d8"), "01415 Chet Trace, Flatleychester, Puerto Rico", new DateTime(2020, 5, 7, 20, 7, 46, 770, DateTimeKind.Local).AddTicks(7099), "Jamal Hilll" },
                    { new Guid("82719b49-9fdf-450f-ff04-f413206d877f"), "958 Amaya Fork, South Everetttown, New Caledonia", new DateTime(2020, 5, 15, 13, 42, 22, 406, DateTimeKind.Local).AddTicks(9861), "Shanel Stanton" }
                });

            migrationBuilder.InsertData(
                table: "owner",
                columns: new[] { "OwnerId", "Address", "DateOfBirth", "Name" },
                values: new object[,]
                {
                    { new Guid("8806d4c6-5524-8675-30e4-8949aa50b30a"), "5203 Stamm Junction, Crooksfurt, Germany", new DateTime(2020, 12, 1, 4, 44, 15, 525, DateTimeKind.Local).AddTicks(9030), "Geo Hodkiewicz" },
                    { new Guid("4c4ca155-ff67-c65a-4e0e-dc42a9e7fec8"), "023 Fisher Track, Ryanburgh, Netherlands", new DateTime(2020, 1, 4, 19, 18, 12, 867, DateTimeKind.Local).AddTicks(9116), "Josiane Lueilwitz" },
                    { new Guid("f4216a5b-0308-a367-3374-4f94a8182a6d"), "0837 Koepp Inlet, Reichelmouth, Maldives", new DateTime(2020, 2, 2, 5, 45, 37, 866, DateTimeKind.Local).AddTicks(7336), "Hermina DuBuque" },
                    { new Guid("d880856b-f387-c4f5-32f4-d3883139f3b9"), "3785 Cassie Hill, Naomiberg, Singapore", new DateTime(2020, 8, 27, 1, 37, 57, 312, DateTimeKind.Local).AddTicks(1006), "Marcelle Stroman" },
                    { new Guid("22287476-5197-8ee6-d3dd-c771faf4b54e"), "451 Waylon Shoal, East Tiannaview, United Arab Emirates", new DateTime(2020, 11, 19, 14, 33, 12, 717, DateTimeKind.Local).AddTicks(5280), "Elmore Ebert" },
                    { new Guid("9fbf1020-7f1d-0311-cd24-fe7a24d44ce8"), "13363 Schoen Wall, New Deontae, Paraguay", new DateTime(2020, 11, 3, 18, 51, 17, 452, DateTimeKind.Local).AddTicks(3980), "Jakayla Bradtke" },
                    { new Guid("c7b38c2a-8af4-c9a4-7ece-24dc72684d36"), "8555 Kohler Mountain, Modestashire, Puerto Rico", new DateTime(2020, 9, 10, 6, 49, 44, 732, DateTimeKind.Local).AddTicks(6896), "Jamaal Cormier" },
                    { new Guid("bcd0d3de-a5bd-0625-5d11-8e9de92bd046"), "37313 Loy Curve, Cooperberg, Finland", new DateTime(2020, 2, 16, 18, 9, 51, 991, DateTimeKind.Local).AddTicks(7398), "Dexter Schowalter" },
                    { new Guid("b85ba4ce-b05c-f410-5421-6b8698b1484a"), "517 Kovacek Rapid, North Hayden, Bulgaria", new DateTime(2020, 1, 13, 23, 23, 15, 857, DateTimeKind.Local).AddTicks(7981), "Aniyah Dicki" },
                    { new Guid("eb26648b-13fe-bd58-a946-fd417388a4e1"), "344 Callie Islands, Tillmanmouth, Yemen", new DateTime(2020, 10, 25, 11, 30, 3, 447, DateTimeKind.Local).AddTicks(2025), "Osbaldo Dooley" },
                    { new Guid("83d3513a-9dc5-b27e-f1a0-27d244d76362"), "297 Padberg Flats, South Sherman, Fiji", new DateTime(2020, 1, 27, 17, 23, 47, 343, DateTimeKind.Local).AddTicks(494), "Marjory Kessler" },
                    { new Guid("c310e5c4-9fef-de05-43f7-8fdd462a93f9"), "56030 Marisol Fall, Jerdemouth, Bulgaria", new DateTime(2020, 8, 22, 7, 19, 35, 928, DateTimeKind.Local).AddTicks(6533), "Columbus Larson" },
                    { new Guid("33ed63ce-7413-80c2-40f9-829a0ad85a91"), "226 Gladyce Dam, Jaskolskiland, Lebanon", new DateTime(2020, 9, 2, 19, 49, 19, 356, DateTimeKind.Local).AddTicks(1905), "Charlotte Cummings" },
                    { new Guid("78d375aa-a5c7-6cc5-e141-2428c2c77148"), "079 Milo Knoll, New Allisonberg, Brunei Darussalam", new DateTime(2020, 7, 30, 21, 24, 38, 738, DateTimeKind.Local).AddTicks(238), "Luella Nitzsche" },
                    { new Guid("25d78301-5f36-eb93-66e2-fa521e4046d3"), "966 Rowe Burgs, Mrazfurt, Uruguay", new DateTime(2020, 7, 8, 22, 9, 31, 536, DateTimeKind.Local).AddTicks(3864), "Anabel Mohr" },
                    { new Guid("264bd02b-f03e-114b-f960-e00d9c7634a7"), "5786 Anika Islands, Colemanchester, Lithuania", new DateTime(2020, 10, 9, 19, 33, 7, 479, DateTimeKind.Local).AddTicks(2694), "Phyllis Frami" },
                    { new Guid("81cf19cf-1ad3-e308-4817-6afdfabd59c3"), "0151 Herzog Wells, Jordyberg, Afghanistan", new DateTime(2020, 9, 26, 1, 56, 55, 82, DateTimeKind.Local).AddTicks(1724), "Faustino Haley" },
                    { new Guid("833d483a-b2a6-09d3-0b9b-5263e7160479"), "223 Collier Land, Port Tyrique, Guernsey", new DateTime(2020, 5, 2, 7, 44, 6, 852, DateTimeKind.Local).AddTicks(7302), "Glennie Shanahan" },
                    { new Guid("c2bc2f32-80b1-1dd6-0792-e64f39a9ebf1"), "68920 Walter Courts, East Rebecca, Sierra Leone", new DateTime(2020, 2, 21, 12, 39, 9, 799, DateTimeKind.Local).AddTicks(7786), "Adonis Feeney" },
                    { new Guid("2b331f0b-5253-5ef9-bc74-30757b8a29de"), "23398 Tobin Vista, Port Jerelchester, Myanmar", new DateTime(2020, 7, 23, 7, 57, 52, 605, DateTimeKind.Local).AddTicks(286), "Asa Kub" },
                    { new Guid("c5b88a2d-f553-1e7d-bc24-f4ddf3fa40da"), "344 Dietrich Plain, West Arvid, Nauru", new DateTime(2020, 10, 18, 14, 0, 8, 126, DateTimeKind.Local).AddTicks(6283), "Chelsey Predovic" },
                    { new Guid("5ce06eea-259f-ca3f-4835-bc5b75158b5e"), "667 Murazik Street, Beierchester, Guadeloupe", new DateTime(2020, 6, 12, 23, 32, 35, 914, DateTimeKind.Local).AddTicks(3635), "Israel Turner" },
                    { new Guid("79aa17a1-f9e2-423e-9fbd-5739a92660b0"), "27894 Gunner Cliffs, Stantonberg, Morocco", new DateTime(2020, 6, 16, 18, 20, 46, 257, DateTimeKind.Local).AddTicks(9892), "Spencer Shanahan" },
                    { new Guid("0ac96cdd-136e-a19e-b46b-06c5f71b970f"), "30798 Mellie Stream, Port Karson, Namibia", new DateTime(2020, 5, 7, 1, 20, 42, 824, DateTimeKind.Local).AddTicks(738), "Paxton Larson" },
                    { new Guid("3b5c4c8d-63a8-1908-575e-db7137cf40b2"), "666 Sophia Fort, Labadiemouth, Mayotte", new DateTime(2020, 9, 15, 3, 33, 33, 684, DateTimeKind.Local).AddTicks(2316), "Buddy Kunze" },
                    { new Guid("b4276f2b-8526-fb6a-9172-b2567eb06da7"), "0822 Auer Courts, West Keara, Serbia", new DateTime(2020, 3, 3, 16, 0, 58, 889, DateTimeKind.Local).AddTicks(5854), "Reilly Kling" },
                    { new Guid("01af4602-1b10-2d1a-0c83-14a8bd731c5d"), "45177 Ernser Oval, South Tyresehaven, Brazil", new DateTime(2020, 9, 26, 21, 54, 28, 348, DateTimeKind.Local).AddTicks(6171), "Hilario Mraz" },
                    { new Guid("6b003854-cb96-fafb-727a-4d59025094f0"), "482 Considine Spring, Lake Rod, Slovenia", new DateTime(2020, 9, 12, 14, 54, 14, 644, DateTimeKind.Local).AddTicks(7843), "Sydni Renner" },
                    { new Guid("1ee089f0-5ce4-d228-43a2-2065a07b1466"), "4264 Elda Isle, Jaskolskiton, Chad", new DateTime(2020, 1, 16, 10, 48, 26, 360, DateTimeKind.Local).AddTicks(9982), "Aliza Bahringer" },
                    { new Guid("cf5d5b96-3221-93b0-7d5a-1b139bc58b6a"), "933 Damion Bypass, West Jules, Saint Martin", new DateTime(2020, 5, 21, 23, 48, 48, 411, DateTimeKind.Local).AddTicks(7158), "Johann Bogan" },
                    { new Guid("ce1b4ba2-1d44-4444-6d2f-b30ddbaa5584"), "8917 Lennie Lights, Port Lewbury, Switzerland", new DateTime(2020, 6, 27, 18, 27, 11, 556, DateTimeKind.Local).AddTicks(7859), "Elroy Yundt" },
                    { new Guid("80c77876-46f6-3a4c-fd1c-96fb430d80ca"), "549 Deion Spur, Caliport, Austria", new DateTime(2020, 7, 30, 18, 8, 28, 489, DateTimeKind.Local).AddTicks(5033), "Jalyn Cassin" },
                    { new Guid("65e06255-8e31-6c04-3a62-1daffafa5a01"), "1991 Alivia Vista, Alexieburgh, Slovenia", new DateTime(2020, 9, 9, 20, 28, 16, 389, DateTimeKind.Local).AddTicks(5087), "Lia White" },
                    { new Guid("9940eb19-a862-3c4f-3625-1c30da8991c1"), "85734 O'Conner Trail, Windlerburgh, Spain", new DateTime(2020, 2, 8, 11, 3, 57, 677, DateTimeKind.Local).AddTicks(6), "Crawford Senger" },
                    { new Guid("b90f9678-9ec1-62bc-a8ee-84668d59b45b"), "16419 Kessler Locks, Langfort, Malaysia", new DateTime(2020, 7, 17, 2, 14, 32, 916, DateTimeKind.Local).AddTicks(8433), "Lowell Lebsack" },
                    { new Guid("82f3622f-aa08-b1ea-d608-d0026c165372"), "68869 Feest Village, New Melba, Spain", new DateTime(2020, 10, 22, 19, 31, 7, 621, DateTimeKind.Local).AddTicks(8648), "Benjamin Halvorson" },
                    { new Guid("c1f75e10-42d8-f9a5-5451-eb8a6101dd62"), "3461 Rosalee Dam, New Graciela, Virgin Islands, British", new DateTime(2020, 1, 19, 21, 25, 52, 940, DateTimeKind.Local).AddTicks(5204), "Karine Schuster" },
                    { new Guid("acefdf9a-1c0b-944b-338d-564272e2a6a3"), "679 Benedict Groves, South Clarkmouth, Sweden", new DateTime(2020, 12, 5, 10, 21, 10, 254, DateTimeKind.Local).AddTicks(1706), "Pat DuBuque" },
                    { new Guid("413e04b5-139e-c40b-6046-ff92e4bf356c"), "14893 Julie Summit, West Darrickborough, Botswana", new DateTime(2019, 12, 21, 20, 3, 13, 141, DateTimeKind.Local).AddTicks(1183), "Greg Feil" },
                    { new Guid("b01be93e-9ab2-9c52-60e8-61222c868c62"), "75970 Caterina Lodge, Connellybury, Mayotte", new DateTime(2020, 11, 19, 13, 15, 10, 124, DateTimeKind.Local).AddTicks(1077), "Trevor Buckridge" },
                    { new Guid("b3b99146-262c-1cfa-a047-9acc38ef57a7"), "20349 Mueller Burgs, Shanelleshire, Taiwan", new DateTime(2020, 4, 23, 0, 44, 8, 829, DateTimeKind.Local).AddTicks(6054), "Sydni Ruecker" },
                    { new Guid("f5fbd850-77e6-fae8-e420-fe1944740000"), "5607 Coralie Run, Virginiaport, Ecuador", new DateTime(2020, 4, 19, 21, 3, 35, 209, DateTimeKind.Local).AddTicks(1378), "Sierra Hand" }
                });

            migrationBuilder.InsertData(
                table: "owner",
                columns: new[] { "OwnerId", "Address", "DateOfBirth", "Name" },
                values: new object[,]
                {
                    { new Guid("89319cc4-d0ef-f9bc-1254-f7b13791dd15"), "505 Blick Trafficway, Port Bell, Azerbaijan", new DateTime(2019, 12, 28, 0, 3, 13, 428, DateTimeKind.Local).AddTicks(3060), "Donnell Rath" },
                    { new Guid("542d8166-42a8-1077-e224-216b103250fd"), "0718 Johnathan Junction, Jakubowskiton, Uzbekistan", new DateTime(2019, 12, 28, 13, 0, 16, 804, DateTimeKind.Local).AddTicks(4223), "Rasheed Thiel" },
                    { new Guid("2f919437-3d0a-d235-4cc9-9285351b25f3"), "74149 Muller Road, West Cathrineborough, Madagascar", new DateTime(2020, 6, 30, 10, 0, 35, 584, DateTimeKind.Local).AddTicks(9786), "Tiffany Spinka" },
                    { new Guid("20a17b33-9af3-5c99-fe98-766f45214016"), "524 Otilia Vista, North Charlenehaven, Virgin Islands, British", new DateTime(2020, 9, 30, 12, 58, 25, 887, DateTimeKind.Local).AddTicks(4507), "Stephon MacGyver" },
                    { new Guid("a9e8d8e2-6652-19d4-d2a9-92c6e51e6cf4"), "9860 Marquardt Coves, Barneymouth, Algeria", new DateTime(2020, 7, 14, 7, 7, 57, 182, DateTimeKind.Local).AddTicks(6865), "Carroll Ernser" },
                    { new Guid("6d8c81b5-9739-c5c4-8d78-4315146f4e83"), "263 Freddy Inlet, Amaliamouth, British Indian Ocean Territory (Chagos Archipelago)", new DateTime(2020, 9, 11, 10, 29, 59, 987, DateTimeKind.Local).AddTicks(4825), "Danny Kirlin" },
                    { new Guid("111be72b-9264-bbff-695d-d3f593488778"), "9738 Stanton Causeway, Dameonmouth, British Indian Ocean Territory (Chagos Archipelago)", new DateTime(2020, 3, 26, 15, 20, 12, 426, DateTimeKind.Local).AddTicks(3521), "Judson West" },
                    { new Guid("2e18d153-5df8-f1ea-ed77-881b1c69550d"), "53967 Natalia Place, New Shanel, Belarus", new DateTime(2020, 1, 13, 15, 35, 47, 412, DateTimeKind.Local).AddTicks(395), "Gavin Stokes" },
                    { new Guid("30c1a2f6-7f58-3378-08c1-c92c2d6aec42"), "270 Faustino Ville, Darrellside, Andorra", new DateTime(2020, 6, 14, 15, 55, 5, 430, DateTimeKind.Local).AddTicks(2752), "Garrett Crist" },
                    { new Guid("269c519a-93c7-5bdd-6214-94e5ca9c4971"), "80156 Jose Knoll, Hermanbury, Hong Kong", new DateTime(2020, 4, 2, 15, 46, 49, 84, DateTimeKind.Local).AddTicks(6821), "Hallie Kuhn" },
                    { new Guid("90da2ea1-2444-4bae-2198-928108fdcf57"), "509 Beier Village, East Griffin, United States of America", new DateTime(2020, 6, 26, 0, 36, 23, 303, DateTimeKind.Local).AddTicks(4343), "Saige Christiansen" },
                    { new Guid("2871803e-6f6d-e5e1-aad9-e82e49fde7ff"), "778 Lorenza Lake, North Keshaunburgh, Pitcairn Islands", new DateTime(2020, 1, 12, 17, 47, 48, 278, DateTimeKind.Local).AddTicks(5312), "Lindsey Mayer" },
                    { new Guid("0054518e-d496-e862-3d53-27bb78a06fc5"), "491 Collier Drives, Mantehaven, American Samoa", new DateTime(2020, 9, 1, 2, 3, 35, 740, DateTimeKind.Local).AddTicks(7033), "Ilene Olson" },
                    { new Guid("a0eb6973-a9f7-68e6-0723-4d6c90dbc29a"), "1487 Lind Burgs, Markshaven, United States Minor Outlying Islands", new DateTime(2020, 11, 12, 2, 21, 57, 277, DateTimeKind.Local).AddTicks(5310), "Kelsie Yundt" },
                    { new Guid("52b493b8-ff8c-1c78-65b6-0895ca7dd35e"), "9268 Grady Isle, West Treviontown, Ukraine", new DateTime(2020, 11, 6, 1, 14, 13, 616, DateTimeKind.Local).AddTicks(5458), "Kayla Maggio" },
                    { new Guid("27fcb3bb-0e6f-8d32-36a9-511d221b281b"), "6446 Watson Isle, New Baileychester, Bangladesh", new DateTime(2020, 12, 4, 22, 49, 32, 386, DateTimeKind.Local).AddTicks(6785), "Walker Haley" },
                    { new Guid("d7c90edd-cf37-f0b6-64cd-cb652f8eebd2"), "84726 Mustafa Port, Joanneberg, Fiji", new DateTime(2020, 3, 13, 7, 8, 34, 967, DateTimeKind.Local).AddTicks(9274), "Katheryn Hartmann" },
                    { new Guid("5e0c449d-8344-bcef-6a14-c0777738129a"), "70665 Kitty Springs, Zettaside, Malaysia", new DateTime(2020, 10, 29, 0, 14, 42, 404, DateTimeKind.Local).AddTicks(6548), "Juana Bode" },
                    { new Guid("de499198-a774-3950-01c2-296df7a887bb"), "1948 Maryjane Walks, Trompland, Sierra Leone", new DateTime(2019, 12, 20, 9, 21, 40, 267, DateTimeKind.Local).AddTicks(3137), "Julie Cruickshank" },
                    { new Guid("a6ded89b-bbc8-dcbe-671b-c58f7473620f"), "187 Bednar Unions, Littleland, Armenia", new DateTime(2020, 9, 14, 18, 37, 3, 607, DateTimeKind.Local).AddTicks(9407), "Vernie West" },
                    { new Guid("d15c1a72-ca1f-f2e1-333c-bc88bb3fbb31"), "469 Bergnaum Vista, West Thaliamouth, Vanuatu", new DateTime(2019, 12, 30, 5, 51, 34, 848, DateTimeKind.Local).AddTicks(2816), "Malcolm Hodkiewicz" },
                    { new Guid("7553d022-a118-4543-0e53-0b8bf3ab0c53"), "08311 Dietrich Green, Cartwrighttown, Namibia", new DateTime(2020, 4, 2, 7, 39, 52, 238, DateTimeKind.Local).AddTicks(6047), "Raul Morissette" },
                    { new Guid("ecea65fb-1945-5f17-380d-5444542abc04"), "3617 Hilpert Rapid, Port Dion, Grenada", new DateTime(2020, 12, 8, 23, 51, 33, 835, DateTimeKind.Local).AddTicks(8327), "Trever Luettgen" },
                    { new Guid("45f79de1-6721-5945-e26d-651b4edde615"), "0925 Denesik Union, Friesenmouth, Kyrgyz Republic", new DateTime(2020, 11, 23, 2, 0, 48, 746, DateTimeKind.Local).AddTicks(308), "Annie Sporer" },
                    { new Guid("b762cf81-7632-90e2-8d58-2b13bedddf53"), "15787 Ophelia Harbors, North Ettie, Croatia", new DateTime(2020, 8, 11, 17, 55, 34, 208, DateTimeKind.Local).AddTicks(7560), "Barrett Rath" },
                    { new Guid("7b7e9af3-e22e-2737-f620-c2f057198ede"), "6776 Quinten Forks, South Jenifer, Northern Mariana Islands", new DateTime(2020, 7, 27, 23, 16, 50, 205, DateTimeKind.Local).AddTicks(4923), "Rubie Pfannerstill" },
                    { new Guid("d1cdcd14-a615-4229-c937-8262ebc5a370"), "522 Bahringer Island, Denesikton, Niue", new DateTime(2020, 11, 28, 8, 59, 46, 392, DateTimeKind.Local).AddTicks(1179), "Darby Marks" },
                    { new Guid("43cad028-d860-e125-5103-49bca6d4d905"), "3582 Raynor Turnpike, Turcotteborough, Western Sahara", new DateTime(2020, 5, 10, 6, 29, 39, 572, DateTimeKind.Local).AddTicks(4847), "Meggie Lehner" },
                    { new Guid("a0c5277f-fc10-4f7d-57ac-6709b445ba10"), "6413 Gregory Pine, Robertsfurt, Lesotho", new DateTime(2020, 10, 6, 17, 16, 2, 990, DateTimeKind.Local).AddTicks(7386), "Christiana Lockman" },
                    { new Guid("6a48767b-394b-f99e-b79e-4f9a03e8ed3d"), "35382 Donnelly Lane, Oberbrunnerland, Swaziland", new DateTime(2020, 6, 22, 7, 18, 46, 635, DateTimeKind.Local).AddTicks(5633), "Crystel Gislason" },
                    { new Guid("13122b92-ad2c-9b39-5745-881d298ff960"), "598 Kerluke Island, North Victor, Palau", new DateTime(2019, 12, 23, 11, 32, 35, 669, DateTimeKind.Local).AddTicks(6289), "Andres Robel" },
                    { new Guid("5454f90f-69eb-f1c4-d0ee-86166feea2b1"), "497 Kevin Plain, Kuphalville, Mauritania", new DateTime(2019, 12, 21, 23, 35, 0, 529, DateTimeKind.Local).AddTicks(8690), "Shawn Kerluke" },
                    { new Guid("78635794-d524-0d3b-f7d8-e01a443c39b2"), "7767 Stroman Trail, Port Eleanoraburgh, Fiji", new DateTime(2019, 12, 27, 22, 18, 49, 67, DateTimeKind.Local).AddTicks(4120), "Jodie Kilback" },
                    { new Guid("0cbff1ef-7e75-eedc-1656-99253c249409"), "20147 Freda Grove, Wehnerberg, Antarctica (the territory South of 60 deg S)", new DateTime(2019, 12, 23, 17, 30, 44, 75, DateTimeKind.Local).AddTicks(330), "Esteban Goldner" },
                    { new Guid("794a5494-1aa6-fc27-4afe-62f5b57c6aef"), "68090 Stan Plaza, Roselynfurt, Haiti", new DateTime(2020, 6, 24, 23, 10, 23, 498, DateTimeKind.Local).AddTicks(9372), "Edythe Little" },
                    { new Guid("49d0a895-af8f-fcea-cbc6-ea79d2d24329"), "17934 Wisoky Ferry, Rippinhaven, Gambia", new DateTime(2020, 1, 19, 0, 55, 53, 549, DateTimeKind.Local).AddTicks(6709), "Yessenia O'Hara" },
                    { new Guid("9ad31f39-77a6-e4dc-dabc-ae1c9d23b171"), "19995 Madalyn Ways, North Angelina, Liechtenstein", new DateTime(2020, 11, 24, 20, 34, 26, 57, DateTimeKind.Local).AddTicks(7406), "Ewald Rogahn" },
                    { new Guid("70b2994a-bb8f-c1ab-702d-4b7031965f70"), "9661 Mikel Forges, North Martine, Bangladesh", new DateTime(2020, 10, 21, 5, 40, 34, 962, DateTimeKind.Local).AddTicks(9105), "Hubert Nader" },
                    { new Guid("8a53456e-00ff-6c31-f68b-6f854218507f"), "4733 Rosalee Burg, Lake Alayna, Saudi Arabia", new DateTime(2020, 8, 2, 17, 28, 19, 828, DateTimeKind.Local).AddTicks(1671), "Vernie Block" },
                    { new Guid("ec02e911-d442-f370-4cdc-ec3ae0004f32"), "111 Muller Cliff, East Juliettown, American Samoa", new DateTime(2020, 2, 16, 4, 41, 19, 330, DateTimeKind.Local).AddTicks(8843), "Leon Ferry" },
                    { new Guid("58745d18-6315-d93d-ac9d-f43470d61912"), "9544 Stiedemann Rapids, Port Oran, Wallis and Futuna", new DateTime(2020, 9, 4, 5, 25, 13, 24, DateTimeKind.Local).AddTicks(1592), "Maximilian DuBuque" },
                    { new Guid("8221369b-f78b-651c-d2e2-8530e71ca15d"), "80403 Imogene Drive, Abernathyshire, Guadeloupe", new DateTime(2020, 6, 9, 15, 7, 24, 509, DateTimeKind.Local).AddTicks(1915), "Erin Olson" }
                });

            migrationBuilder.InsertData(
                table: "owner",
                columns: new[] { "OwnerId", "Address", "DateOfBirth", "Name" },
                values: new object[,]
                {
                    { new Guid("b4399962-8696-d6d9-4848-a2bb134e7c50"), "89749 Willms Road, Gerlachhaven, Malaysia", new DateTime(2020, 6, 29, 7, 5, 46, 949, DateTimeKind.Local).AddTicks(7422), "Reece Bauch" },
                    { new Guid("688284aa-a8a8-34df-11c4-dc8f1c06ef43"), "027 Rozella Unions, East Mauriceside, El Salvador", new DateTime(2020, 2, 10, 7, 8, 58, 411, DateTimeKind.Local).AddTicks(1994), "Armani Brekke" },
                    { new Guid("c9684f3d-e8f9-01b1-174e-1ebf98762d62"), "86482 Skiles Lake, Lake Briellemouth, Mali", new DateTime(2020, 1, 21, 22, 51, 18, 370, DateTimeKind.Local).AddTicks(1862), "Jocelyn Doyle" },
                    { new Guid("269dcd51-eb49-a89e-7048-371f8bbc3dcc"), "01535 Schmeler Estate, Herminaborough, Niger", new DateTime(2020, 5, 4, 5, 27, 26, 450, DateTimeKind.Local).AddTicks(3043), "Maximillian Kulas" },
                    { new Guid("c45f2586-a937-cb37-2c6c-8b1d85d37800"), "0783 Van Parkway, Nicolefurt, Argentina", new DateTime(2020, 9, 10, 3, 23, 11, 754, DateTimeKind.Local).AddTicks(1171), "Al Bruen" },
                    { new Guid("9604974c-07dd-06a4-8358-c8f4eff69ec8"), "18976 Casper Estate, West Benjamintown, Gibraltar", new DateTime(2020, 5, 23, 17, 14, 54, 408, DateTimeKind.Local).AddTicks(1240), "Roselyn Sanford" },
                    { new Guid("e1ceeed1-a623-dc25-f4ba-55fc629263e6"), "806 Tillman Vista, Morartown, Nauru", new DateTime(2020, 10, 24, 4, 48, 39, 643, DateTimeKind.Local).AddTicks(6936), "Mireille Wuckert" },
                    { new Guid("25ef87bc-f9af-4f59-3381-fd7fbb1238ab"), "928 Velda Pines, Haroldmouth, Luxembourg", new DateTime(2020, 9, 9, 19, 13, 11, 356, DateTimeKind.Local).AddTicks(7043), "Stephanie Bauch" },
                    { new Guid("990370d1-7275-b46d-eca4-6813d6b55864"), "034 Collier Valley, Kemmerstad, Estonia", new DateTime(2020, 1, 9, 16, 53, 47, 174, DateTimeKind.Local).AddTicks(3625), "Gaetano Herzog" },
                    { new Guid("2bca59fc-b80e-c379-383a-1d285d80b13f"), "63909 Brandyn Mountain, Anikachester, Lebanon", new DateTime(2020, 11, 13, 4, 38, 1, 416, DateTimeKind.Local).AddTicks(982), "Karli Bartoletti" },
                    { new Guid("0cba6cca-4989-11ac-65ec-ea7ecd244d46"), "143 Scot Views, Veumland, Cambodia", new DateTime(2020, 8, 25, 2, 31, 7, 607, DateTimeKind.Local).AddTicks(1527), "Ciara Goldner" },
                    { new Guid("92044bfa-f614-0d33-57bc-95f043ca9c0d"), "9530 Gutmann Route, Isabelfurt, Botswana", new DateTime(2020, 11, 3, 11, 9, 48, 613, DateTimeKind.Local).AddTicks(5954), "Felicity Rowe" },
                    { new Guid("33f083a5-91c9-4f38-fefd-33bb8b9389da"), "77520 Ozella Mission, Maggioborough, Turkey", new DateTime(2020, 3, 24, 5, 41, 58, 778, DateTimeKind.Local).AddTicks(7898), "Iliana Lowe" },
                    { new Guid("dabf4a5b-4468-ae38-0cd2-c7819d77b315"), "23554 Ritchie Run, Hodkiewiczview, Cape Verde", new DateTime(2020, 1, 9, 19, 35, 3, 304, DateTimeKind.Local).AddTicks(9321), "Celia Dickens" },
                    { new Guid("ca482f27-aa00-1cfd-ed6e-1cdcc3538999"), "1173 Runolfsson Causeway, East Brandoton, United Kingdom", new DateTime(2020, 10, 24, 17, 14, 22, 389, DateTimeKind.Local).AddTicks(4299), "Juliana Roob" },
                    { new Guid("41dd473e-142e-ee6e-e4a2-6a4df9db4639"), "1097 Johns Hill, Elijahberg, Panama", new DateTime(2020, 5, 5, 13, 54, 2, 270, DateTimeKind.Local).AddTicks(3812), "Dahlia Wunsch" },
                    { new Guid("87c883cd-4b4e-8e7d-929b-04fbe9e6c0c9"), "47557 Gulgowski Pass, West Damian, Central African Republic", new DateTime(2020, 6, 13, 2, 58, 52, 748, DateTimeKind.Local).AddTicks(7145), "Bryana Schaefer" },
                    { new Guid("0b22ef37-b652-0800-b7f0-01a747d61157"), "0054 Pfeffer Tunnel, Port Newell, Algeria", new DateTime(2020, 10, 6, 13, 3, 32, 190, DateTimeKind.Local).AddTicks(627), "Shanelle Stiedemann" },
                    { new Guid("f6b2a24e-bd9d-5559-50ee-e7e1a1d34433"), "8877 Kristina Mountains, Howardberg, Vanuatu", new DateTime(2020, 4, 15, 6, 56, 0, 107, DateTimeKind.Local).AddTicks(6264), "Gregory Crist" },
                    { new Guid("30db3128-1ca0-eeb0-fa85-6f3daf3a045e"), "35222 Lessie Lights, West Ricardofort, Tanzania", new DateTime(2020, 1, 20, 20, 53, 6, 118, DateTimeKind.Local).AddTicks(4464), "Jamison Kirlin" },
                    { new Guid("f1970937-6e43-3f79-b3d4-99c7a1167153"), "977 Keven Drive, Wolffmouth, Saint Vincent and the Grenadines", new DateTime(2020, 1, 30, 16, 42, 49, 721, DateTimeKind.Local).AddTicks(5286), "Elyssa Conroy" },
                    { new Guid("0386d3d9-c7fb-c36c-47da-ca5b7ca9a827"), "67547 Mante Cliff, East Reyfurt, Bolivia", new DateTime(2020, 4, 20, 11, 49, 49, 133, DateTimeKind.Local).AddTicks(3691), "Eugenia Bergnaum" },
                    { new Guid("131bf3bf-8b76-505f-099b-59bc63ef18b0"), "6358 Dante Mount, West Rosemarie, Iran", new DateTime(2020, 10, 25, 22, 58, 26, 833, DateTimeKind.Local).AddTicks(4055), "Jaida Veum" },
                    { new Guid("b5e957e9-5d0b-1fc7-8d72-3c58ab61c60e"), "189 Ima Lodge, South Scarlett, United Arab Emirates", new DateTime(2020, 10, 26, 22, 27, 27, 692, DateTimeKind.Local).AddTicks(2234), "Joyce Schulist" },
                    { new Guid("d3dd3a9d-050b-a463-c4fa-26c67a5787d6"), "817 Brekke Mews, Flatleyfort, Bangladesh", new DateTime(2020, 7, 30, 4, 23, 55, 370, DateTimeKind.Local).AddTicks(5261), "Jena Gerlach" },
                    { new Guid("9f78695c-cd1e-ba8e-08b5-17f3bae356bf"), "526 Mabel Creek, Port Clark, Cambodia", new DateTime(2020, 2, 19, 12, 33, 46, 869, DateTimeKind.Local).AddTicks(686), "Donald Stroman" },
                    { new Guid("c9d79632-015c-68b8-08f3-50b16d84bff0"), "0874 Cecilia Cove, Pourosstad, Philippines", new DateTime(2020, 11, 3, 18, 50, 37, 95, DateTimeKind.Local).AddTicks(7601), "Nash Mayer" },
                    { new Guid("5ce4f3c1-19e3-bef9-1a24-bbb9485793d9"), "5758 O'Hara Lock, New Ubaldoshire, Romania", new DateTime(2020, 11, 13, 17, 49, 11, 985, DateTimeKind.Local).AddTicks(6047), "Susana Brown" },
                    { new Guid("9f79ef84-0d62-7b76-a0d1-f0f2c741fcd4"), "191 Elsa Walk, Ratkemouth, Saint Martin", new DateTime(2020, 5, 30, 18, 39, 36, 140, DateTimeKind.Local).AddTicks(3291), "Emile Ward" },
                    { new Guid("c34d164b-1a67-c839-9064-15ef8abd914d"), "85859 Gisselle Shore, West Jocelynborough, Faroe Islands", new DateTime(2020, 6, 28, 11, 32, 4, 323, DateTimeKind.Local).AddTicks(9283), "Randall Deckow" },
                    { new Guid("7e7adca4-ba95-c109-6024-e04cdb88cef9"), "2955 Spencer Station, East Kenna, Turkey", new DateTime(2020, 9, 27, 8, 17, 52, 55, DateTimeKind.Local).AddTicks(6567), "Albert Lemke" },
                    { new Guid("b518d028-8dd2-64e3-9ab8-86f795fbaeaa"), "055 Schaden Views, Lake Flossiechester, Cayman Islands", new DateTime(2020, 11, 10, 9, 36, 38, 518, DateTimeKind.Local).AddTicks(685), "Nina Trantow" },
                    { new Guid("0b244192-1870-fc26-4682-9be3dd03427e"), "7228 Travis Glens, West Carter, Switzerland", new DateTime(2020, 6, 2, 5, 29, 26, 579, DateTimeKind.Local).AddTicks(4121), "Viviane Yundt" },
                    { new Guid("53643fa4-a3d7-5839-fbf0-610df63a63dd"), "7238 Pedro Throughway, Port Arlie, Anguilla", new DateTime(2020, 7, 4, 19, 9, 48, 209, DateTimeKind.Local).AddTicks(702), "Gay Ferry" },
                    { new Guid("9d3f10f2-ee9f-8ba7-012e-8f3b8801a078"), "67825 Jennifer Keys, New Alexander, Hungary", new DateTime(2020, 1, 23, 18, 56, 58, 167, DateTimeKind.Local).AddTicks(6768), "Derrick Zulauf" },
                    { new Guid("fae51b46-3ec6-dd72-fd96-59f8df2030ed"), "38623 Bins Stream, North Eudora, Mongolia", new DateTime(2020, 6, 15, 11, 37, 36, 830, DateTimeKind.Local).AddTicks(1569), "Macy Bogan" },
                    { new Guid("bae641bc-ac7d-5bb7-28a6-61a822459bf0"), "54685 Adele Summit, New Brycen, Armenia", new DateTime(2020, 1, 7, 11, 36, 49, 95, DateTimeKind.Local).AddTicks(8876), "Glenna Stamm" },
                    { new Guid("4ade236d-6232-9779-cd42-d09965013347"), "858 Damon Lakes, Port Leanneshire, Dominican Republic", new DateTime(2020, 12, 10, 4, 26, 14, 560, DateTimeKind.Local).AddTicks(7419), "Otis Block" },
                    { new Guid("22b5692c-a6bd-062a-012d-0dd0fe8672d5"), "1760 Goodwin Lodge, Schmelerview, Burkina Faso", new DateTime(2020, 1, 25, 18, 5, 30, 850, DateTimeKind.Local).AddTicks(9043), "Floyd Auer" },
                    { new Guid("fb6de69a-114b-368a-d4d0-e528a2d9723e"), "7413 Leone Corners, North Keven, Burkina Faso", new DateTime(2020, 2, 29, 18, 12, 28, 917, DateTimeKind.Local).AddTicks(76), "Pierre Mosciski" },
                    { new Guid("1835f5f1-7619-0889-8991-ad1468c11aa0"), "08806 Lueilwitz Lights, Townechester, Uruguay", new DateTime(2020, 10, 18, 23, 38, 4, 835, DateTimeKind.Local).AddTicks(7683), "Reyna Hirthe" },
                    { new Guid("a3ad36fe-255a-47fa-3bbd-5b79f075bfdd"), "0323 Veum Ranch, Amaratown, Saint Lucia", new DateTime(2020, 11, 25, 23, 23, 10, 154, DateTimeKind.Local).AddTicks(123), "Adam Okuneva" }
                });

            migrationBuilder.InsertData(
                table: "owner",
                columns: new[] { "OwnerId", "Address", "DateOfBirth", "Name" },
                values: new object[,]
                {
                    { new Guid("8a698fb3-fc6d-209e-e4a2-9a36cefaf11a"), "81156 Kiana Extensions, Lake Seanport, Christmas Island", new DateTime(2020, 5, 2, 10, 7, 58, 271, DateTimeKind.Local).AddTicks(4574), "Stewart Stracke" },
                    { new Guid("340b61c6-0b70-b9b7-16be-76c6fcc6446e"), "1298 McKenzie Freeway, Port Cleve, Heard Island and McDonald Islands", new DateTime(2020, 2, 26, 8, 13, 40, 15, DateTimeKind.Local).AddTicks(8496), "Leopold Denesik" },
                    { new Guid("9034efc8-870f-5505-2b81-e8657774e51b"), "779 Maeve Ports, Lake Lourdes, Gibraltar", new DateTime(2020, 2, 26, 20, 35, 1, 490, DateTimeKind.Local).AddTicks(18), "Nakia Koss" },
                    { new Guid("fd772e30-920d-5eb4-b8ba-e940bfcc0504"), "3744 Annie Rest, Morrisside, Kyrgyz Republic", new DateTime(2020, 3, 2, 10, 17, 41, 882, DateTimeKind.Local).AddTicks(8566), "Carleton Carroll" },
                    { new Guid("1a744bab-25d9-e1b0-f29c-33575f3b7221"), "40309 D'angelo Roads, McLaughlinburgh, Suriname", new DateTime(2020, 9, 3, 9, 35, 50, 598, DateTimeKind.Local).AddTicks(3683), "Oscar Beer" },
                    { new Guid("eb577514-83b6-07a7-4747-66e5dd26a4bb"), "3815 Luisa Falls, East Barrettton, Barbados", new DateTime(2020, 4, 9, 21, 50, 4, 843, DateTimeKind.Local).AddTicks(5492), "Lucius Lynch" },
                    { new Guid("6a58dfc3-8c45-7dc1-0547-7e5fe971c4db"), "5199 Lesch Hill, Lewisshire, Kiribati", new DateTime(2020, 8, 9, 14, 7, 44, 692, DateTimeKind.Local).AddTicks(3958), "Major Cole" },
                    { new Guid("cc531f73-b03b-ed9f-4403-621bca0eeeed"), "0740 Eden Street, Juliusborough, Bangladesh", new DateTime(2020, 1, 29, 16, 25, 23, 452, DateTimeKind.Local).AddTicks(4578), "Wilburn Dach" },
                    { new Guid("a55877da-1a24-56ba-a36d-fac48b1a3f79"), "291 Julien Cliffs, Schmidtfort, Belgium", new DateTime(2020, 7, 6, 19, 14, 34, 51, DateTimeKind.Local).AddTicks(8111), "Osvaldo Reichert" },
                    { new Guid("07c21a4e-7a29-0f9f-1f37-91dce071e139"), "441 Cummings Extensions, Kyleeport, Sierra Leone", new DateTime(2020, 9, 12, 16, 17, 39, 862, DateTimeKind.Local).AddTicks(3614), "Dannie Turcotte" },
                    { new Guid("ab89a057-c8aa-1513-fe16-01a50c19ba5b"), "7693 Hammes Coves, Terryberg, Poland", new DateTime(2020, 5, 22, 21, 9, 22, 304, DateTimeKind.Local).AddTicks(2810), "Chelsey Denesik" },
                    { new Guid("3b39d808-c557-7137-c5ec-478b6096835f"), "1809 Dewitt Island, Xzaviermouth, Uruguay", new DateTime(2020, 10, 28, 14, 15, 40, 913, DateTimeKind.Local).AddTicks(8706), "Gunnar Turner" },
                    { new Guid("339d2a20-7ee0-ac04-e342-636d72d4217b"), "746 Hagenes Park, Zettaview, Jamaica", new DateTime(2020, 8, 16, 14, 34, 57, 29, DateTimeKind.Local).AddTicks(8032), "Itzel Walker" },
                    { new Guid("6a4dc576-f935-7f4f-0adb-56ac418a962b"), "34543 Cassandra Wall, Shayneland, Greenland", new DateTime(2020, 4, 18, 0, 13, 51, 348, DateTimeKind.Local).AddTicks(4131), "Chaim Jacobs" },
                    { new Guid("24a8ed4f-eb69-b681-6a2f-33abba118f3d"), "16243 Dexter Drive, New Vada, Namibia", new DateTime(2020, 8, 8, 18, 53, 5, 383, DateTimeKind.Local).AddTicks(5659), "Luna Langosh" },
                    { new Guid("ed9df1df-0207-9bfa-632a-e5e44c00c4f4"), "1556 Heber Pike, New Fannie, Belarus", new DateTime(2020, 5, 8, 21, 23, 52, 721, DateTimeKind.Local).AddTicks(6764), "Furman Wolff" },
                    { new Guid("1fdad40c-50f1-8c67-6d73-98327bc80aaf"), "2312 Beier Falls, South Hassiestad, Bouvet Island (Bouvetoya)", new DateTime(2020, 8, 27, 4, 21, 8, 481, DateTimeKind.Local).AddTicks(5426), "Luis Blick" },
                    { new Guid("2677d83d-02a5-6dd1-69de-fd37bf1033c3"), "51478 Alden Mountains, Myrtleport, Gambia", new DateTime(2020, 4, 18, 21, 51, 14, 627, DateTimeKind.Local).AddTicks(6668), "Sydnee Nader" },
                    { new Guid("92f03e38-f589-fd7f-f828-fb67d73f00bf"), "69956 Stehr Ways, West Flo, Cayman Islands", new DateTime(2020, 1, 20, 22, 51, 5, 819, DateTimeKind.Local).AddTicks(9900), "Allison Murray" },
                    { new Guid("42d2873b-8030-09fb-f9d1-ee3707f3e0e0"), "550 Santiago Row, Angeltown, Israel", new DateTime(2020, 9, 27, 19, 38, 28, 657, DateTimeKind.Local).AddTicks(3800), "Regan Pfannerstill" },
                    { new Guid("9b4f1c03-2eb8-467c-be80-fcac5d376e00"), "6134 Franecki Lodge, North Joanie, Uganda", new DateTime(2020, 1, 31, 23, 46, 48, 745, DateTimeKind.Local).AddTicks(5622), "Hermann Senger" },
                    { new Guid("571c6608-0fb5-50b9-96e7-e6167bd81d7e"), "096 Nona Ramp, Watersville, Greenland", new DateTime(2020, 12, 10, 1, 31, 47, 428, DateTimeKind.Local).AddTicks(2312), "Abel Greenholt" },
                    { new Guid("1aeb186f-57b8-b128-226f-4601e2a9aae1"), "87441 Treutel Oval, New Mitchelside, Switzerland", new DateTime(2020, 8, 24, 18, 30, 26, 110, DateTimeKind.Local).AddTicks(2493), "Aubrey Padberg" },
                    { new Guid("6c910cd9-9565-4288-b751-8c04170965bb"), "9914 Matilda Drive, Stoneshire, Macedonia", new DateTime(2020, 10, 13, 10, 56, 38, 774, DateTimeKind.Local).AddTicks(7026), "Wilber Lebsack" },
                    { new Guid("4eff4a12-cfc6-436e-93d7-d26c02b5d0ff"), "1886 Milan Streets, New Watson, Switzerland", new DateTime(2020, 2, 11, 18, 51, 49, 119, DateTimeKind.Local).AddTicks(2634), "Rylan Bruen" },
                    { new Guid("ccf139c4-1609-a8f5-f859-d3af10ccbece"), "986 Vincenzo Crossing, Virginiebury, South Georgia and the South Sandwich Islands", new DateTime(2020, 4, 23, 3, 20, 21, 223, DateTimeKind.Local).AddTicks(7181), "Noemie Fisher" },
                    { new Guid("a7873803-c3c9-f503-dff3-808f466497e6"), "3134 Emory Circles, Port Bernadineland, Nauru", new DateTime(2020, 5, 27, 12, 17, 42, 484, DateTimeKind.Local).AddTicks(5589), "Noemie Little" },
                    { new Guid("8876cf67-f524-890b-4e23-c8c2766c766c"), "7177 Delmer Mountains, West Murphy, American Samoa", new DateTime(2020, 1, 29, 18, 29, 58, 632, DateTimeKind.Local).AddTicks(3087), "Rubye Streich" },
                    { new Guid("94defcbe-5e20-1de3-0ef2-be691a444719"), "41953 Bednar Garden, Lake Willis, Svalbard & Jan Mayen Islands", new DateTime(2020, 6, 10, 12, 28, 0, 635, DateTimeKind.Local).AddTicks(8899), "Lenore Koelpin" },
                    { new Guid("8d7a04d4-4ce2-8fc3-c5be-f8250c3b3ba2"), "353 Crooks Streets, Jeniferberg, Bermuda", new DateTime(2020, 1, 5, 18, 15, 4, 905, DateTimeKind.Local).AddTicks(1392), "Savanna Pfeffer" },
                    { new Guid("458964a3-cd40-bd8c-101b-995535b05e4c"), "7728 Audie Estate, Uptonport, Gambia", new DateTime(2020, 11, 21, 16, 49, 49, 527, DateTimeKind.Local).AddTicks(1035), "Jessie Sawayn" },
                    { new Guid("c0540d5a-f683-d5fb-9c50-cdfa7f8295a4"), "175 Louvenia Street, Breannebury, Lao People's Democratic Republic", new DateTime(2020, 7, 16, 5, 28, 33, 494, DateTimeKind.Local).AddTicks(6961), "Joanne Wuckert" },
                    { new Guid("fab3acc3-5b27-c89d-efd1-c2edffa34946"), "8206 Huels Place, Tatumview, French Guiana", new DateTime(2020, 2, 22, 19, 38, 50, 650, DateTimeKind.Local).AddTicks(5226), "Elisa Mitchell" },
                    { new Guid("4d093941-87cb-486e-5f26-2ab74ef4618e"), "5315 Barrows Meadow, Lake Richie, Anguilla", new DateTime(2019, 12, 25, 14, 54, 51, 176, DateTimeKind.Local).AddTicks(7076), "Adela Moore" },
                    { new Guid("c5ab94dd-fc9a-f27b-3538-d491072e8684"), "94018 Ole Circle, Port Abigayleland, Algeria", new DateTime(2020, 4, 2, 9, 19, 15, 952, DateTimeKind.Local).AddTicks(5547), "Tyrique Carroll" },
                    { new Guid("9b49b9da-daf4-db00-2eec-51cc899958fc"), "139 Green Terrace, East Laurynborough, Uganda", new DateTime(2020, 8, 11, 4, 19, 51, 711, DateTimeKind.Local).AddTicks(8373), "Eugene Moore" },
                    { new Guid("534c453d-0f47-8f7b-b118-d95a583cd3d8"), "500 Dakota Coves, North Magdalena, Barbados", new DateTime(2020, 11, 8, 20, 59, 0, 528, DateTimeKind.Local).AddTicks(3786), "Elwyn Konopelski" },
                    { new Guid("35d9cc9a-c168-0562-9f62-5f8c2f9c2a05"), "0922 Jessy Mission, East Lexusberg, Monaco", new DateTime(2020, 5, 15, 22, 47, 12, 76, DateTimeKind.Local).AddTicks(3777), "Amya Kuphal" },
                    { new Guid("848a2e2e-aac7-76f9-5003-061c92ca9050"), "922 Muller Groves, Lake Rosiefurt, Bangladesh", new DateTime(2020, 2, 29, 20, 58, 47, 77, DateTimeKind.Local).AddTicks(646), "Giovanni Ratke" },
                    { new Guid("d05e958c-d003-2236-b75b-da58e8ed665c"), "410 Kerluke Square, Lake Gracielaview, Bhutan", new DateTime(2020, 11, 11, 3, 24, 37, 884, DateTimeKind.Local).AddTicks(8482), "Precious Russel" },
                    { new Guid("1c5793bc-ed9d-de9a-81c0-55873b23ebed"), "32893 Emily Tunnel, West Aylinmouth, Antigua and Barbuda", new DateTime(2020, 12, 7, 1, 51, 5, 43, DateTimeKind.Local).AddTicks(4144), "Yasmin Powlowski" },
                    { new Guid("6f957149-c228-fb18-3832-6a1c94334eb1"), "44748 Ledner Rapid, Lake Timothyton, Dominican Republic", new DateTime(2020, 11, 12, 18, 49, 36, 366, DateTimeKind.Local).AddTicks(8251), "Kiara Rogahn" }
                });

            migrationBuilder.InsertData(
                table: "owner",
                columns: new[] { "OwnerId", "Address", "DateOfBirth", "Name" },
                values: new object[,]
                {
                    { new Guid("b65879d9-a626-809e-f269-933904c5aaf1"), "911 Trinity Grove, Dietrichborough, Lebanon", new DateTime(2020, 6, 20, 2, 47, 59, 846, DateTimeKind.Local).AddTicks(35), "Rosanna Herman" },
                    { new Guid("59eb7fd8-59d4-ffc0-0af6-0ba08ec78dfe"), "082 Friesen Meadow, West Margueritefurt, Bhutan", new DateTime(2020, 5, 16, 7, 10, 45, 518, DateTimeKind.Local).AddTicks(5893), "Manley Roberts" },
                    { new Guid("b9bab8f7-6c18-98d5-0c17-085dfb16ec73"), "0084 Lynch Union, Gerardochester, Equatorial Guinea", new DateTime(2020, 4, 12, 7, 53, 14, 404, DateTimeKind.Local).AddTicks(8797), "Arturo Fadel" },
                    { new Guid("d5a84ace-d30c-c2e5-22b1-645376eaa70c"), "0077 Lyric Stravenue, North Paxtonfurt, Australia", new DateTime(2020, 10, 18, 18, 48, 9, 332, DateTimeKind.Local).AddTicks(2728), "Casper Moore" },
                    { new Guid("6db08ed6-6616-4048-dd5c-c525f2e24ca0"), "6919 Gerlach Flats, Port Clement, Nigeria", new DateTime(2020, 2, 7, 11, 14, 39, 890, DateTimeKind.Local).AddTicks(5618), "Adrian Heathcote" },
                    { new Guid("5b9f3a0a-9ef7-42fc-a89b-5c4d8448807f"), "5696 Oberbrunner Hollow, Rachaelbury, Finland", new DateTime(2020, 2, 12, 22, 31, 21, 457, DateTimeKind.Local).AddTicks(4931), "Estrella Casper" },
                    { new Guid("b81b6f39-f042-8ba9-c64f-18879bd77cf2"), "462 Colten Ville, South Dahliastad, Andorra", new DateTime(2020, 11, 30, 20, 21, 44, 536, DateTimeKind.Local).AddTicks(8227), "Reynold Lindgren" },
                    { new Guid("15140b70-c72d-453d-8580-77787f6e4292"), "14701 Jalen Ports, North Tom, Kazakhstan", new DateTime(2020, 1, 9, 8, 20, 36, 645, DateTimeKind.Local).AddTicks(5739), "Shawn Hessel" },
                    { new Guid("c3901668-c466-ee1a-d461-ff6d14f1d47e"), "917 Schroeder Lodge, Jeffryside, Greenland", new DateTime(2020, 6, 3, 10, 41, 3, 109, DateTimeKind.Local).AddTicks(1615), "Annette Maggio" },
                    { new Guid("16b0f861-b258-cdce-7bb8-a109e2d1e6ce"), "1124 Bins Shoal, North Estefaniamouth, Morocco", new DateTime(2020, 11, 24, 0, 39, 42, 838, DateTimeKind.Local).AddTicks(2350), "Vivianne Deckow" },
                    { new Guid("64749d3d-7cdb-91cc-46b0-bc54c74b69d9"), "2858 Bailey Terrace, McLaughlinhaven, Bosnia and Herzegovina", new DateTime(2020, 1, 29, 5, 55, 28, 540, DateTimeKind.Local).AddTicks(9249), "Enola Morissette" },
                    { new Guid("33a47c6f-6a71-23dc-360d-07424d7dcf9d"), "656 Darrell Cliff, South Warrenberg, Pitcairn Islands", new DateTime(2020, 4, 3, 3, 6, 6, 50, DateTimeKind.Local).AddTicks(5335), "Rosalia Jast" },
                    { new Guid("4be5cb76-35a6-f968-ee8e-839bcd2ca160"), "96838 Glennie Landing, West Garth, British Indian Ocean Territory (Chagos Archipelago)", new DateTime(2020, 8, 8, 16, 27, 18, 50, DateTimeKind.Local).AddTicks(9799), "Herminio Streich" },
                    { new Guid("9782cc5a-f783-c1b6-d586-86f6489b02e4"), "79572 O'Conner Unions, New Georgianna, Moldova", new DateTime(2020, 1, 24, 6, 41, 22, 961, DateTimeKind.Local).AddTicks(9586), "Jonas Bogan" },
                    { new Guid("1f5f7254-2cc9-bad9-e1f3-3d54ff50a003"), "47445 Rene Pine, Schimmelburgh, Mongolia", new DateTime(2020, 1, 16, 7, 56, 6, 3, DateTimeKind.Local).AddTicks(5185), "Petra Robel" },
                    { new Guid("a228f33a-5cc5-637e-4342-f1749af061ca"), "24380 Samson Shoal, North Danykahaven, Spain", new DateTime(2020, 12, 7, 13, 23, 39, 358, DateTimeKind.Local).AddTicks(2982), "Dusty Mante" },
                    { new Guid("60775cc5-6242-7457-85e1-84a5f7b76fc2"), "5062 Koelpin Summit, Kathlynton, Faroe Islands", new DateTime(2020, 4, 25, 9, 29, 57, 560, DateTimeKind.Local).AddTicks(500), "Leatha Farrell" },
                    { new Guid("052a5250-cc52-f431-3f2c-6d4f799f946a"), "90040 Heller Land, North Carleymouth, Armenia", new DateTime(2020, 7, 4, 16, 47, 57, 512, DateTimeKind.Local).AddTicks(24), "Jovanny Wunsch" },
                    { new Guid("6a8ca555-8b6f-749e-433e-da73b2bda4cf"), "99937 Elody Keys, West Ismaelberg, Honduras", new DateTime(2020, 3, 30, 15, 37, 22, 996, DateTimeKind.Local).AddTicks(9040), "Arnold Mante" },
                    { new Guid("81deef4a-501b-542d-5e9d-a32699456558"), "451 Xavier Port, Lake Savannah, Niger", new DateTime(2020, 5, 29, 6, 5, 11, 65, DateTimeKind.Local).AddTicks(734), "Ward McKenzie" },
                    { new Guid("73fe5fe5-f1b4-6fb7-e1ac-a050d809446d"), "3179 Corkery Plains, Lake Brock, Swaziland", new DateTime(2020, 4, 20, 10, 53, 37, 60, DateTimeKind.Local).AddTicks(4267), "Krystal Schamberger" },
                    { new Guid("c7be2c26-d29b-67b1-4462-65b42f5455d5"), "042 Damon Rapid, Port Elvie, Malaysia", new DateTime(2020, 1, 30, 18, 45, 24, 180, DateTimeKind.Local).AddTicks(9039), "Elvie Stiedemann" },
                    { new Guid("2af4f552-4bac-d27c-b110-0cca984affb3"), "24122 Flatley Valley, Westonberg, Bermuda", new DateTime(2020, 7, 20, 9, 6, 35, 243, DateTimeKind.Local).AddTicks(2224), "Chelsea Cassin" },
                    { new Guid("3abe12a7-a92a-3e8a-288d-a4295ddbebab"), "9688 Tyrique Ports, Hettingerport, Germany", new DateTime(2020, 8, 4, 19, 33, 22, 833, DateTimeKind.Local).AddTicks(2313), "Leora Christiansen" },
                    { new Guid("37f1bb96-7841-c124-9e87-90c15d4ca0dc"), "152 Nikko Causeway, Lake Marisolmouth, Guatemala", new DateTime(2020, 11, 19, 5, 53, 33, 105, DateTimeKind.Local).AddTicks(6240), "Danyka Hilll" },
                    { new Guid("4f69fabd-4232-b4df-dd35-9a0605ed8cc6"), "1480 Dale Corners, Ignatiusfort, Micronesia", new DateTime(2020, 8, 25, 2, 3, 52, 976, DateTimeKind.Local).AddTicks(3081), "Maryam Doyle" },
                    { new Guid("a29250df-b4e9-ee6a-5bc7-2be772429631"), "207 Jarod Via, North Palma, Puerto Rico", new DateTime(2020, 2, 3, 3, 17, 36, 926, DateTimeKind.Local).AddTicks(4082), "Chandler Koch" },
                    { new Guid("4e792a80-328c-5eb4-a021-1516073ccc20"), "801 Landen Court, Joannetown, Saudi Arabia", new DateTime(2020, 8, 17, 14, 13, 26, 652, DateTimeKind.Local).AddTicks(596), "Charlotte Mante" },
                    { new Guid("a8f8e415-aad6-371c-0773-504357a37037"), "07686 Dooley Vista, New Benedict, Macedonia", new DateTime(2020, 5, 23, 4, 16, 12, 576, DateTimeKind.Local).AddTicks(8184), "Devin Lakin" },
                    { new Guid("710ae8f3-b751-1dec-cea1-2fa8f11ea366"), "6365 Laurie Forks, Balistrerimouth, Cameroon", new DateTime(2020, 2, 22, 2, 50, 48, 720, DateTimeKind.Local).AddTicks(8502), "Vladimir Gislason" },
                    { new Guid("0644991e-354c-2f8c-7b86-0ef9f3e129bf"), "4317 Dwight Drive, Mayertburgh, French Polynesia", new DateTime(2020, 1, 6, 16, 28, 37, 928, DateTimeKind.Local).AddTicks(9216), "Deondre Deckow" },
                    { new Guid("588ab597-9cd9-ec1a-04bb-0301aeb37b4d"), "944 Juvenal Ridges, South Daronfurt, Argentina", new DateTime(2020, 10, 14, 2, 4, 43, 720, DateTimeKind.Local).AddTicks(5046), "Henry Casper" },
                    { new Guid("3d61c261-d157-96e5-828b-ff27faa88889"), "7238 Koelpin Unions, Jeraldmouth, Saint Vincent and the Grenadines", new DateTime(2020, 10, 26, 10, 13, 33, 187, DateTimeKind.Local).AddTicks(5213), "Sabryna Bruen" },
                    { new Guid("eba023f4-3d51-9ef6-a986-d97f056e2646"), "06211 Kristy Mountain, Port Auguststad, Saint Vincent and the Grenadines", new DateTime(2020, 4, 11, 4, 20, 34, 328, DateTimeKind.Local).AddTicks(8354), "Annabel VonRueden" },
                    { new Guid("9c08d633-e238-aafd-2ff9-efc18cb04221"), "1997 Morissette Light, Farrellfurt, Vietnam", new DateTime(2020, 10, 31, 23, 38, 56, 642, DateTimeKind.Local).AddTicks(5839), "Ila Marvin" },
                    { new Guid("503b37eb-e93e-ac08-02df-bd65a8c0446d"), "0708 Carter Summit, East Agneschester, Central African Republic", new DateTime(2020, 5, 8, 6, 1, 9, 36, DateTimeKind.Local).AddTicks(3867), "Kory Hammes" },
                    { new Guid("7554d52e-e3f1-885c-2df5-c7485e5fa93c"), "10853 Hoyt Pine, Juddland, Nicaragua", new DateTime(2020, 5, 10, 9, 30, 47, 391, DateTimeKind.Local).AddTicks(7575), "Tyrique Huel" },
                    { new Guid("efea792e-b9f8-7863-a911-a660e4b3a089"), "171 Camille Extensions, New Raheemberg, Oman", new DateTime(2020, 7, 20, 10, 51, 16, 95, DateTimeKind.Local).AddTicks(3766), "Johnathon Fisher" },
                    { new Guid("e6302b5c-4dbf-a2b9-8c42-e570a8ae298b"), "24344 Rhoda Neck, South Kariane, Democratic People's Republic of Korea", new DateTime(2020, 2, 18, 5, 17, 40, 160, DateTimeKind.Local).AddTicks(1347), "Haylie Ferry" },
                    { new Guid("83b803bd-c9b9-572d-f6f8-a2c23bdd963d"), "79880 Tara Alley, Halvorsonburgh, Cuba", new DateTime(2020, 9, 8, 17, 10, 47, 858, DateTimeKind.Local).AddTicks(3596), "Kaitlin Doyle" },
                    { new Guid("70abeba3-e408-aa63-807b-ed96c3928712"), "522 Howard Glen, North Tyrellside, Macao", new DateTime(2020, 3, 27, 15, 6, 30, 652, DateTimeKind.Local).AddTicks(8340), "Colton Wehner" },
                    { new Guid("f1984f32-cceb-211f-15b6-eafb895ce686"), "6577 Delfina Brook, South Dorriston, Lao People's Democratic Republic", new DateTime(2020, 10, 24, 21, 7, 22, 215, DateTimeKind.Local).AddTicks(7663), "Kristin Marks" }
                });

            migrationBuilder.InsertData(
                table: "owner",
                columns: new[] { "OwnerId", "Address", "DateOfBirth", "Name" },
                values: new object[,]
                {
                    { new Guid("fa7464c4-2695-bf87-9644-5c774b0369f3"), "14895 Megane Stream, Dibbertshire, Botswana", new DateTime(2020, 6, 18, 8, 17, 3, 466, DateTimeKind.Local).AddTicks(4119), "Green Krajcik" },
                    { new Guid("71f8c5da-3d8c-4b6a-fd7f-d104c95a1b40"), "346 Abagail Junctions, Port Elseshire, Israel", new DateTime(2020, 3, 8, 4, 51, 52, 623, DateTimeKind.Local).AddTicks(8424), "Brayan Boehm" },
                    { new Guid("3e70dcc6-8171-5d8d-8c10-9f944ae98ef1"), "17909 Gwendolyn Field, Lake Jordane, Malta", new DateTime(2019, 12, 28, 12, 6, 52, 541, DateTimeKind.Local).AddTicks(6441), "Jovanny Parker" },
                    { new Guid("e9ec3ead-cfdd-9bba-fa9d-e3e41cfe9d14"), "77565 Lelia Mountain, Heaneymouth, Syrian Arab Republic", new DateTime(2020, 11, 23, 3, 6, 31, 832, DateTimeKind.Local).AddTicks(9646), "Priscilla Hoeger" },
                    { new Guid("a1ab9ccd-d407-f911-19cd-cec271f8b14d"), "547 Louie Crest, Omariside, Iraq", new DateTime(2020, 5, 2, 12, 32, 33, 474, DateTimeKind.Local).AddTicks(513), "Kaycee Predovic" },
                    { new Guid("4e72b921-f261-5172-d474-23e98e8d74a9"), "77464 Hand Wall, Lake Jordiberg, Iraq", new DateTime(2020, 5, 14, 17, 37, 42, 829, DateTimeKind.Local).AddTicks(9240), "Sydney Russel" },
                    { new Guid("a9ff09ad-5b50-4963-94eb-eedac3554125"), "50059 Wisozk Canyon, East Rethamouth, Barbados", new DateTime(2020, 2, 19, 23, 20, 14, 792, DateTimeKind.Local).AddTicks(3857), "Megane Abernathy" },
                    { new Guid("87a96be0-edbf-856b-7edf-722f8673ab13"), "88381 Bernier Forge, Clevelandchester, Kyrgyz Republic", new DateTime(2020, 11, 20, 5, 35, 46, 539, DateTimeKind.Local).AddTicks(9195), "Amara Langworth" },
                    { new Guid("7cd57571-3efb-bded-3a8f-0e9f1590b6da"), "8811 Doyle Cliffs, Alvenaborough, Pakistan", new DateTime(2020, 3, 30, 20, 7, 30, 30, DateTimeKind.Local).AddTicks(5947), "Milton DuBuque" },
                    { new Guid("fe141cd2-97d5-c6a2-0c3b-400f0c4e4fa8"), "700 Tracy Glen, New Jeffereyside, Timor-Leste", new DateTime(2020, 4, 26, 0, 24, 56, 116, DateTimeKind.Local).AddTicks(9433), "Kitty McKenzie" },
                    { new Guid("f8cda9f1-b87b-6d05-72a4-46929531436d"), "0200 Maritza Green, East Newton, Italy", new DateTime(2020, 2, 27, 9, 42, 32, 29, DateTimeKind.Local).AddTicks(3717), "Maia Cronin" },
                    { new Guid("621e590b-5681-c32d-fdbf-596b06b20602"), "76975 Keeling Extension, New Darleneland, Vanuatu", new DateTime(2020, 12, 2, 12, 9, 58, 760, DateTimeKind.Local).AddTicks(401), "Okey Wunsch" },
                    { new Guid("e0123b86-7ceb-7caf-8d67-78ea7e2472c7"), "71678 Bayer Square, Port Dillan, Andorra", new DateTime(2020, 11, 23, 11, 40, 56, 546, DateTimeKind.Local).AddTicks(5701), "Maximillian Donnelly" },
                    { new Guid("f0ca2b9a-6762-2b8a-7516-57a76ac9fd8f"), "87483 Brekke Turnpike, Dareshire, Palestinian Territory", new DateTime(2020, 6, 2, 3, 30, 56, 25, DateTimeKind.Local).AddTicks(507), "Sydney Towne" },
                    { new Guid("04e455dd-50e7-f5fe-b15b-0fcf5dbc2e41"), "936 Quinten Brook, New Addiefurt, Yemen", new DateTime(2020, 5, 31, 21, 46, 37, 534, DateTimeKind.Local).AddTicks(1470), "Willy Pouros" },
                    { new Guid("e2baa9d6-ba0c-f2fe-e805-29276d80b831"), "6801 Zachary Island, Brittanymouth, Liberia", new DateTime(2020, 1, 1, 13, 31, 6, 957, DateTimeKind.Local).AddTicks(4381), "Juliana Williamson" },
                    { new Guid("3e54bb35-5fb8-7789-8d24-3eea1104b16a"), "47555 Beau Points, West Hanna, Iceland", new DateTime(2020, 8, 14, 15, 42, 41, 738, DateTimeKind.Local).AddTicks(3698), "Roy Franecki" },
                    { new Guid("2bb1f1f7-7979-aa6c-13e6-7962048aaf80"), "710 Jason Squares, Botsfordland, Slovakia (Slovak Republic)", new DateTime(2020, 3, 21, 3, 23, 6, 170, DateTimeKind.Local).AddTicks(8108), "Kiley Schaefer" },
                    { new Guid("1683d784-4e11-c5d1-8f8e-922d1717aa65"), "0477 Marcelle Court, Keenanfurt, Lesotho", new DateTime(2020, 11, 29, 23, 35, 45, 905, DateTimeKind.Local).AddTicks(3120), "Jeromy Kuhlman" },
                    { new Guid("406e13f1-f51b-f42f-ac5b-bb8baf11b56d"), "55958 Corwin Trail, Blickmouth, Northern Mariana Islands", new DateTime(2020, 8, 22, 9, 5, 27, 128, DateTimeKind.Local).AddTicks(4283), "Jasen McCullough" },
                    { new Guid("a9033c58-4969-dc04-afdb-ee202ea30eb2"), "667 Destiny Extension, South Isabellastad, Monaco", new DateTime(2020, 2, 26, 16, 51, 6, 216, DateTimeKind.Local).AddTicks(9056), "Aron Batz" },
                    { new Guid("d557504d-c4b2-c9a3-f05f-8d173986f08c"), "42772 Strosin Street, Salliemouth, Rwanda", new DateTime(2020, 8, 21, 14, 35, 8, 318, DateTimeKind.Local).AddTicks(4976), "Betty McKenzie" },
                    { new Guid("4bddd3b1-0038-d4f9-c93b-b86fe6b13f31"), "972 Ferry Gateway, South Darius, Benin", new DateTime(2020, 4, 23, 19, 43, 59, 480, DateTimeKind.Local).AddTicks(7704), "Craig Jakubowski" },
                    { new Guid("889baf09-13b2-ae40-f76b-ffc20769eb57"), "7142 Tessie Camp, New Taylorberg, Germany", new DateTime(2020, 11, 23, 7, 40, 50, 583, DateTimeKind.Local).AddTicks(573), "Rebecca Rosenbaum" },
                    { new Guid("4bc0af4f-8d29-1e1d-6a96-018dee02c510"), "61250 Denesik Corner, Jesusport, Tonga", new DateTime(2020, 10, 18, 8, 28, 57, 493, DateTimeKind.Local).AddTicks(9056), "Addie Koch" },
                    { new Guid("2bb9b765-3c0c-f915-e082-326f6111c6e8"), "5482 Jeremy Lodge, Lake Marcelino, Saint Barthelemy", new DateTime(2019, 12, 23, 15, 57, 16, 831, DateTimeKind.Local).AddTicks(9156), "Arianna O'Hara" },
                    { new Guid("4a8906ae-e40c-f833-294a-8d7c0dcf4b77"), "848 Jed Walk, South Zanderberg, Mauritania", new DateTime(2020, 6, 12, 2, 49, 5, 982, DateTimeKind.Local).AddTicks(4018), "Rashawn Mertz" },
                    { new Guid("5ac02d24-7b87-5bdc-2d39-b0ea62d361b2"), "19624 Stacey Villages, West Clovis, Suriname", new DateTime(2020, 8, 30, 9, 27, 10, 65, DateTimeKind.Local).AddTicks(7570), "Frederik Glover" },
                    { new Guid("0ee058da-eff0-a0a6-557c-26c9661393e7"), "5581 Ila Parkway, Mateoville, New Zealand", new DateTime(2020, 11, 20, 5, 0, 9, 940, DateTimeKind.Local).AddTicks(3040), "Willow Blanda" },
                    { new Guid("7a87e0f9-a381-3b61-d99b-28357e6c4fff"), "49688 Eleanora Track, Cristmouth, Timor-Leste", new DateTime(2020, 8, 31, 16, 31, 12, 668, DateTimeKind.Local).AddTicks(3683), "Dovie Lang" },
                    { new Guid("8c86cf4a-6619-ba54-3517-680d3b0a1f55"), "170 Lauretta Extensions, Port Royceton, Pakistan", new DateTime(2020, 1, 13, 20, 16, 20, 610, DateTimeKind.Local).AddTicks(4513), "Estelle Johns" },
                    { new Guid("9c3321f4-73c8-7436-eeee-b6ad9d98ab4d"), "044 Brakus Trace, Vergieshire, Holy See (Vatican City State)", new DateTime(2020, 6, 1, 3, 4, 28, 380, DateTimeKind.Local).AddTicks(5705), "Everardo Graham" },
                    { new Guid("19534c75-d619-8c83-0113-caf0d038863d"), "3084 Johnson View, Gulgowskistad, Gabon", new DateTime(2020, 7, 22, 16, 28, 55, 521, DateTimeKind.Local).AddTicks(6982), "Osbaldo Reilly" },
                    { new Guid("61414aba-7e49-7691-e069-05b17c648422"), "11420 Sabrina Walk, East Kaitlin, Iran", new DateTime(2020, 2, 11, 6, 26, 17, 710, DateTimeKind.Local).AddTicks(8166), "Roosevelt Hintz" },
                    { new Guid("f7863592-f325-57cb-66dd-b6b355503a48"), "3148 Ernesto Turnpike, West Adolf, Wallis and Futuna", new DateTime(2020, 1, 15, 21, 57, 21, 211, DateTimeKind.Local).AddTicks(9541), "Arlie Bode" },
                    { new Guid("2eea4fcd-2afd-7bef-9544-f898ce08ef35"), "09046 Schaefer Skyway, Purdyshire, Jersey", new DateTime(2020, 8, 13, 3, 23, 6, 31, DateTimeKind.Local).AddTicks(9761), "Name Lemke" },
                    { new Guid("6605e6bd-4a0b-fc8b-31d1-d0e0acf67c2c"), "9259 Gutkowski Lodge, North Narciso, Central African Republic", new DateTime(2020, 1, 1, 8, 49, 27, 465, DateTimeKind.Local).AddTicks(5573), "Timmy O'Connell" },
                    { new Guid("2111190a-cfea-b933-bd99-92ff7cd844ca"), "90604 Ottis Mews, Salvatoreberg, Maldives", new DateTime(2020, 5, 13, 21, 6, 36, 730, DateTimeKind.Local).AddTicks(5383), "Mattie Zieme" },
                    { new Guid("e493d69e-425a-90bd-8572-2ea2fd8658f8"), "778 Oran Isle, Madisynborough, Equatorial Guinea", new DateTime(2020, 9, 25, 23, 37, 17, 965, DateTimeKind.Local).AddTicks(4039), "Hanna Quitzon" },
                    { new Guid("defcab84-b101-9ae5-99e6-714d4c89e4ec"), "44140 Bret Springs, Port Leopoldmouth, Nauru", new DateTime(2020, 8, 5, 4, 37, 42, 594, DateTimeKind.Local).AddTicks(4366), "Darien Collins" },
                    { new Guid("a700f7a9-4757-278c-71c0-5b11ffd8a44b"), "99606 Isaiah Brook, Luettgenton, Nauru", new DateTime(2020, 4, 9, 4, 9, 56, 286, DateTimeKind.Local).AddTicks(6905), "Eric Lebsack" },
                    { new Guid("ebede0c3-85d4-0e8d-e898-7fd92d8b59b6"), "1093 Gulgowski Alley, North Xander, Aruba", new DateTime(2019, 12, 24, 2, 18, 20, 289, DateTimeKind.Local).AddTicks(4244), "Polly Morissette" }
                });

            migrationBuilder.InsertData(
                table: "owner",
                columns: new[] { "OwnerId", "Address", "DateOfBirth", "Name" },
                values: new object[,]
                {
                    { new Guid("f83b9d16-5fb7-3997-0102-f1e1eced71ea"), "505 Violette Circles, Ebonychester, Madagascar", new DateTime(2020, 6, 18, 22, 57, 15, 59, DateTimeKind.Local).AddTicks(8441), "Reta Hermann" },
                    { new Guid("c3836538-5090-ff60-7858-2a99c6bc4d9e"), "9377 Walter Court, South Sylvestermouth, Russian Federation", new DateTime(2020, 7, 23, 1, 37, 17, 278, DateTimeKind.Local).AddTicks(2297), "Kianna Weimann" },
                    { new Guid("687cb9f5-e02a-c599-d527-f63510e45963"), "378 Sanford Key, Port Nikko, Saint Pierre and Miquelon", new DateTime(2020, 8, 12, 13, 40, 17, 148, DateTimeKind.Local).AddTicks(1407), "Nathanial Bernhard" },
                    { new Guid("3db13460-0f1f-1a9b-6d84-f2189e0b4043"), "282 Prosacco Mews, South Magdalen, Portugal", new DateTime(2020, 8, 4, 6, 2, 34, 622, DateTimeKind.Local).AddTicks(704), "Derrick Kessler" },
                    { new Guid("f27d7a8f-c793-db82-acaa-187645ff0ee4"), "662 Walter Junction, Lake Thadfort, American Samoa", new DateTime(2020, 3, 22, 10, 57, 12, 729, DateTimeKind.Local).AddTicks(5380), "Gunnar Schmitt" },
                    { new Guid("932ad285-116f-8517-3a9c-40b79d022fe2"), "113 Flatley Mountains, Meaghanland, Madagascar", new DateTime(2020, 7, 9, 17, 59, 30, 780, DateTimeKind.Local).AddTicks(5917), "Larue Durgan" },
                    { new Guid("88538368-9f8a-6480-6437-ff3a7866f216"), "4745 Howe Cove, West Burdetteburgh, Cape Verde", new DateTime(2020, 7, 24, 18, 54, 11, 393, DateTimeKind.Local).AddTicks(9272), "Lauriane Hudson" },
                    { new Guid("19d7e1ce-ff12-e93e-a3ef-981fcbf4d3b6"), "995 Lebsack Meadow, Lake Gerardobury, Saudi Arabia", new DateTime(2020, 10, 28, 3, 36, 24, 349, DateTimeKind.Local).AddTicks(5200), "Sylvester Zulauf" },
                    { new Guid("81aacfaf-712c-809c-fd3b-dc3d17e0b859"), "97954 Wiza Coves, Sauerton, Paraguay", new DateTime(2020, 10, 16, 11, 32, 21, 985, DateTimeKind.Local).AddTicks(5964), "Arch Konopelski" },
                    { new Guid("49fb709d-8a51-e222-dad8-16f9f14a17b5"), "6834 Haley Harbor, Darenburgh, Costa Rica", new DateTime(2020, 9, 5, 13, 47, 18, 809, DateTimeKind.Local).AddTicks(9706), "Kelley Rempel" },
                    { new Guid("70798919-0fbc-43fa-e3cf-7ab4aefec02b"), "37265 Carlee Mall, Dovieland, Pitcairn Islands", new DateTime(2020, 4, 25, 16, 11, 5, 843, DateTimeKind.Local).AddTicks(186), "Murray Beatty" },
                    { new Guid("d067e0cf-f9a7-c6fa-e4f6-b92b6e5bb40f"), "352 Brandyn Village, East Joannymouth, Saudi Arabia", new DateTime(2020, 5, 12, 18, 39, 16, 109, DateTimeKind.Local).AddTicks(4018), "Salvatore Sauer" },
                    { new Guid("1ddfa785-5b58-f661-96aa-e7f370cbdf95"), "8639 Sipes Manor, Abdullahborough, British Indian Ocean Territory (Chagos Archipelago)", new DateTime(2020, 11, 19, 12, 21, 47, 410, DateTimeKind.Local).AddTicks(5674), "Ara Keeling" },
                    { new Guid("c6a6d5e6-967b-2fb6-e310-bcb0933beeb6"), "20991 Green Point, East Zander, Kazakhstan", new DateTime(2020, 8, 29, 16, 36, 25, 968, DateTimeKind.Local).AddTicks(5536), "Lexus Mayer" },
                    { new Guid("259b0c72-1918-bc4b-19a9-d3e600c07619"), "71699 Fredy Lake, Isabellefurt, Colombia", new DateTime(2020, 5, 1, 16, 47, 25, 604, DateTimeKind.Local).AddTicks(5779), "Donna Balistreri" },
                    { new Guid("532e2155-2991-4c1c-470d-d82cfbf5cbf5"), "5432 Dayne Cliff, Cameronberg, Portugal", new DateTime(2020, 1, 16, 18, 57, 49, 889, DateTimeKind.Local).AddTicks(6576), "Kadin Wuckert" },
                    { new Guid("9fab408c-c548-1906-dc9e-03408ba7c8db"), "2072 Lillian Harbors, Kuhicview, Tuvalu", new DateTime(2020, 11, 12, 20, 33, 22, 824, DateTimeKind.Local).AddTicks(8632), "Della Jacobs" },
                    { new Guid("bba03616-2c49-70ad-6f7f-f48d0ce31c1e"), "980 Delores Lights, West Lesleyville, South Georgia and the South Sandwich Islands", new DateTime(2020, 1, 10, 9, 48, 12, 252, DateTimeKind.Local).AddTicks(9751), "Madisen Schroeder" },
                    { new Guid("542a1272-0d07-f791-87bf-3cee82ee3819"), "533 Chaim Tunnel, Shainastad, British Indian Ocean Territory (Chagos Archipelago)", new DateTime(2020, 12, 4, 12, 22, 58, 388, DateTimeKind.Local).AddTicks(5412), "Shaun Roob" },
                    { new Guid("1b0a4899-b9f9-16c7-8bdb-0d62660d4493"), "7974 Witting Dam, Ebbachester, Mauritius", new DateTime(2020, 12, 7, 12, 53, 25, 595, DateTimeKind.Local).AddTicks(9051), "Moshe Hoppe" },
                    { new Guid("9f695d2a-14b1-9355-8d42-7c534b864093"), "31800 Amelia Mill, Hectorside, Montenegro", new DateTime(2020, 4, 18, 9, 54, 45, 372, DateTimeKind.Local).AddTicks(9975), "Bonita Purdy" },
                    { new Guid("a6a2879c-d378-603e-a057-0b99dfde64be"), "7841 Macy Drive, Lake Franciscofurt, Nigeria", new DateTime(2020, 2, 24, 1, 49, 40, 476, DateTimeKind.Local).AddTicks(2084), "Jewell Schiller" },
                    { new Guid("3e6b97be-8418-2054-db1c-c7dad9fc275b"), "70926 Candelario Run, Leathafort, Paraguay", new DateTime(2020, 2, 18, 5, 54, 43, 22, DateTimeKind.Local).AddTicks(9271), "Arvilla Konopelski" },
                    { new Guid("be9bb38d-3ade-4a5f-72ab-da2f8f321d20"), "4763 Elbert Burgs, South Jena, Swaziland", new DateTime(2020, 9, 4, 8, 15, 30, 986, DateTimeKind.Local).AddTicks(9806), "Lamont Oberbrunner" },
                    { new Guid("484bb866-9c8b-5d11-6f72-7068a207a688"), "684 Dayton Island, Wadeshire, South Africa", new DateTime(2020, 12, 13, 4, 55, 37, 769, DateTimeKind.Local).AddTicks(5629), "Dewitt Carter" },
                    { new Guid("c8d980cf-e6d7-94d4-2969-f44fd4d64276"), "90654 Gino Turnpike, North Jerrodville, Iran", new DateTime(2020, 2, 4, 5, 15, 17, 549, DateTimeKind.Local).AddTicks(5813), "Benjamin Goldner" },
                    { new Guid("3ec9e7a1-a2ce-6dd4-8ccc-d554066fc50b"), "670 Adams Gateway, East Lukasfort, Palestinian Territory", new DateTime(2020, 10, 22, 2, 18, 28, 777, DateTimeKind.Local).AddTicks(8043), "Jennings Predovic" },
                    { new Guid("5a357a80-eead-3293-40c2-6128626fd594"), "067 Morar Drive, New Rowenaburgh, Namibia", new DateTime(2020, 7, 31, 7, 11, 21, 522, DateTimeKind.Local).AddTicks(594), "Kyler Green" },
                    { new Guid("8cd3609f-6a39-6e5e-e0d6-4b2780633e96"), "1583 Shaylee Lock, North Stephon, Malaysia", new DateTime(2020, 9, 21, 2, 27, 31, 471, DateTimeKind.Local).AddTicks(1275), "Austyn Kihn" },
                    { new Guid("0189ebe0-499b-0e5a-9e48-e7a1f7483ef9"), "2404 Gerlach Curve, New Faustinoland, Cote d'Ivoire", new DateTime(2020, 5, 29, 9, 45, 5, 150, DateTimeKind.Local).AddTicks(3993), "Verdie Jacobson" },
                    { new Guid("da94474a-fa3c-f2db-0def-177e5a46c238"), "68474 Lionel Estate, Bayerville, Cuba", new DateTime(2020, 6, 25, 12, 24, 13, 276, DateTimeKind.Local).AddTicks(9022), "Raleigh Koepp" },
                    { new Guid("a901ad3e-ac1f-d3a7-7f16-63fdbb094ebf"), "0333 Johns Lights, Lake Lillieshire, Norfolk Island", new DateTime(2020, 4, 18, 19, 32, 6, 469, DateTimeKind.Local).AddTicks(8047), "Eva Schneider" },
                    { new Guid("c0991cb6-e58f-6bf0-3d80-c729d99493b8"), "82807 Mayer Prairie, New Devan, New Zealand", new DateTime(2020, 3, 8, 22, 14, 49, 67, DateTimeKind.Local).AddTicks(4017), "Alice Maggio" },
                    { new Guid("b4ec0474-fafe-4c82-3bd0-e3a590e4f50b"), "074 Rose Dale, Floydstad, Tonga", new DateTime(2020, 8, 16, 10, 25, 36, 876, DateTimeKind.Local).AddTicks(325), "Kathryn Rempel" },
                    { new Guid("64f01b5a-a690-0a04-12b7-3bade7f79bb7"), "371 Douglas Valley, Roobberg, French Polynesia", new DateTime(2020, 12, 10, 12, 0, 5, 694, DateTimeKind.Local).AddTicks(4666), "Willis McKenzie" },
                    { new Guid("6adfc6a0-1b9e-ee03-27b8-7233291d52e3"), "116 Korey Crest, Sydneyfort, Saint Martin", new DateTime(2020, 5, 13, 9, 4, 34, 934, DateTimeKind.Local).AddTicks(2944), "Julia Bergstrom" },
                    { new Guid("50865a82-e6df-0444-f97b-6638efa92b1e"), "52295 Lurline Forks, Bartellville, Belgium", new DateTime(2020, 11, 18, 13, 28, 22, 779, DateTimeKind.Local).AddTicks(9080), "Barrett Orn" },
                    { new Guid("bda54580-7388-ae57-ce79-3f4d658798c8"), "85339 Flavie Junctions, West Giovannibury, Netherlands Antilles", new DateTime(2020, 6, 2, 12, 33, 20, 84, DateTimeKind.Local).AddTicks(5092), "Oceane Hickle" },
                    { new Guid("a29e7006-1004-505c-437f-efaecb02a02c"), "67980 Lorenz Court, Port Alexandrofort, Guernsey", new DateTime(2020, 7, 10, 20, 56, 43, 556, DateTimeKind.Local).AddTicks(8121), "Roxane Ruecker" },
                    { new Guid("51734ea9-f181-356c-119a-820a3b7f1a01"), "41975 Baumbach Green, Robelville, Solomon Islands", new DateTime(2020, 3, 21, 15, 9, 16, 980, DateTimeKind.Local).AddTicks(7307), "Travon Nicolas" },
                    { new Guid("42a3a043-2d14-deca-6cd8-502d3832d0c5"), "504 Koch Wells, West Robertfurt, Turks and Caicos Islands", new DateTime(2020, 2, 5, 8, 38, 56, 798, DateTimeKind.Local).AddTicks(4156), "Scottie Shields" },
                    { new Guid("dff7d7d9-bf76-54b4-1ea5-37ac853a9c3f"), "373 Willms Spur, North Frederickberg, Eritrea", new DateTime(2020, 10, 17, 2, 58, 57, 185, DateTimeKind.Local).AddTicks(1113), "Breana Lang" }
                });

            migrationBuilder.InsertData(
                table: "owner",
                columns: new[] { "OwnerId", "Address", "DateOfBirth", "Name" },
                values: new object[,]
                {
                    { new Guid("61531ce7-f13b-e14e-dc1a-29ab6477f2d1"), "04424 Adams Ways, West Presley, Estonia", new DateTime(2020, 3, 31, 19, 41, 49, 36, DateTimeKind.Local).AddTicks(466), "Dulce Bergnaum" },
                    { new Guid("e669c57c-033a-a505-00b2-dd3735430438"), "633 Moore Canyon, Goyettehaven, Saint Helena", new DateTime(2020, 10, 26, 1, 50, 53, 602, DateTimeKind.Local).AddTicks(5779), "Davion Schoen" },
                    { new Guid("e730ace4-89b2-a5eb-cc2c-1bcfb05e41bf"), "73955 Jessica Harbor, North Elsiebury, Benin", new DateTime(2020, 8, 13, 14, 44, 22, 780, DateTimeKind.Local).AddTicks(584), "Jacques Jones" },
                    { new Guid("5c058bf9-ae51-1179-8242-4e19d38298ac"), "5191 Streich Square, Nathanialton, Guinea", new DateTime(2020, 3, 26, 0, 45, 13, 501, DateTimeKind.Local).AddTicks(2655), "Elwyn Stiedemann" },
                    { new Guid("b564be26-aeba-630b-ac52-65ccc2796d06"), "4604 Leann Ridge, Schinnerchester, Cote d'Ivoire", new DateTime(2020, 12, 12, 22, 29, 0, 230, DateTimeKind.Local).AddTicks(578), "Lexus Jones" },
                    { new Guid("15f3d68b-e21d-31f2-268b-860997d15bda"), "05420 Tabitha Harbor, Justineville, Guatemala", new DateTime(2020, 8, 16, 7, 19, 28, 780, DateTimeKind.Local).AddTicks(3984), "Joanie Wisozk" },
                    { new Guid("86ec4097-e858-2e90-061e-26f08d641b8b"), "828 Pollich Branch, Rohanport, Sri Lanka", new DateTime(2020, 2, 16, 12, 47, 28, 118, DateTimeKind.Local).AddTicks(573), "Misty Kohler" },
                    { new Guid("00f075d5-6e91-ac54-12da-8775539fbf99"), "460 Flo Mountains, Stoltenbergburgh, Slovenia", new DateTime(2020, 1, 26, 8, 32, 49, 940, DateTimeKind.Local).AddTicks(3427), "Jed Gutmann" },
                    { new Guid("50237b0f-9c7b-8a64-1cd9-2fa055fcdbc6"), "7453 Raven Brooks, South Raegan, Papua New Guinea", new DateTime(2020, 11, 23, 8, 8, 29, 631, DateTimeKind.Local).AddTicks(7220), "Telly Kassulke" },
                    { new Guid("fa7864de-4f30-fd44-9e22-2b9f20628b98"), "5551 Gardner Lights, Jerroldport, Peru", new DateTime(2020, 2, 17, 5, 1, 1, 18, DateTimeKind.Local).AddTicks(4311), "Sydnee Trantow" },
                    { new Guid("f1c2edc7-e184-2095-3e56-124cac72896f"), "095 Fritsch Prairie, Bartonland, Czech Republic", new DateTime(2020, 5, 15, 4, 20, 36, 111, DateTimeKind.Local).AddTicks(2186), "Keyshawn Green" },
                    { new Guid("d8a003f4-a033-139a-88ca-4c80bf6fbb8a"), "023 Alisha Brook, East Meganechester, Nauru", new DateTime(2020, 6, 10, 22, 28, 14, 549, DateTimeKind.Local).AddTicks(4939), "Cassandre Reichert" },
                    { new Guid("491e9ae1-9a0c-cf55-6cb0-c841d8d16cec"), "03195 Gerhold Isle, South Ambrose, Saint Barthelemy", new DateTime(2020, 5, 1, 19, 7, 30, 959, DateTimeKind.Local).AddTicks(4668), "Stella Schroeder" },
                    { new Guid("50259ffc-7e71-985c-3f73-cb91d18da355"), "87742 Salvador Drives, New Drew, Lao People's Democratic Republic", new DateTime(2020, 8, 27, 3, 55, 58, 388, DateTimeKind.Local).AddTicks(1178), "Kylie Hickle" },
                    { new Guid("4632db54-2f9b-3c37-3083-0a74081eacbf"), "14927 Halvorson Center, Larrymouth, Tonga", new DateTime(2020, 10, 3, 16, 1, 53, 192, DateTimeKind.Local).AddTicks(610), "Duane Tillman" },
                    { new Guid("71b27c01-dd0e-56c2-7ae3-095ae57c3a26"), "39397 Maci Mill, Baileyhaven, Libyan Arab Jamahiriya", new DateTime(2020, 10, 9, 15, 25, 10, 813, DateTimeKind.Local).AddTicks(9212), "Bradly Abshire" },
                    { new Guid("f9a10689-0e4d-51e3-eb06-f466e1e64fdf"), "20628 Swift Canyon, Hershelbury, Andorra", new DateTime(2020, 11, 8, 4, 42, 57, 20, DateTimeKind.Local).AddTicks(9955), "Maegan Larson" },
                    { new Guid("98765b5c-2a2c-f0b7-00b2-098804159580"), "27885 Halle Plaza, North Isidro, Solomon Islands", new DateTime(2020, 7, 9, 23, 50, 54, 97, DateTimeKind.Local).AddTicks(3785), "Kassandra Dietrich" },
                    { new Guid("d88a8435-5947-3882-e6ba-9ae8784264fe"), "013 Murazik Mills, Lake Marvin, Grenada", new DateTime(2020, 8, 2, 10, 32, 19, 666, DateTimeKind.Local).AddTicks(3715), "Benton Connelly" },
                    { new Guid("cffc6690-0a91-f0a8-ace6-521b88a22b29"), "67655 Erdman Valleys, Cruickshankville, Niue", new DateTime(2020, 11, 19, 3, 53, 6, 774, DateTimeKind.Local).AddTicks(6518), "Lawson Beier" },
                    { new Guid("7b82095f-d372-e5f3-8317-138a14927c36"), "69709 Janick Spur, New Karen, Guinea-Bissau", new DateTime(2020, 9, 9, 22, 46, 30, 851, DateTimeKind.Local).AddTicks(4245), "Richard Rempel" },
                    { new Guid("a998284f-fdad-899a-63ae-459522f1d7ee"), "6369 Sigrid Mountain, Lake Leoneland, Wallis and Futuna", new DateTime(2020, 1, 2, 3, 15, 24, 640, DateTimeKind.Local).AddTicks(8242), "Angeline Wyman" },
                    { new Guid("e46ac434-1e8c-4e0a-3470-7aee282cd850"), "51328 Treutel Corners, Towneview, Algeria", new DateTime(2020, 3, 29, 6, 41, 2, 767, DateTimeKind.Local).AddTicks(6431), "Cora Jaskolski" },
                    { new Guid("6c2cee3d-b30a-cc65-f209-87bde79c00d0"), "4894 Christiansen Rapids, Abnerchester, Pitcairn Islands", new DateTime(2020, 4, 30, 22, 48, 58, 589, DateTimeKind.Local).AddTicks(4715), "Cassidy Metz" },
                    { new Guid("18e01917-2598-5679-d909-8349f2b566ae"), "3367 Bode Valleys, Wisokyshire, Andorra", new DateTime(2020, 8, 8, 15, 13, 6, 162, DateTimeKind.Local).AddTicks(9800), "May Konopelski" },
                    { new Guid("3deaf3b0-e4ab-3ea5-b628-860ed033db49"), "55186 Jammie Street, Haydenmouth, Brunei Darussalam", new DateTime(2020, 11, 22, 0, 40, 5, 69, DateTimeKind.Local).AddTicks(4030), "Nikko Kovacek" },
                    { new Guid("5aed192c-2088-a4d5-8518-0f8b6a610904"), "4601 McCullough Place, Leuschkeburgh, Palau", new DateTime(2020, 2, 9, 2, 2, 51, 479, DateTimeKind.Local).AddTicks(9104), "Dorothea Cruickshank" },
                    { new Guid("d8007ead-03d8-1841-1bf4-46fc52885f3f"), "2825 Green Lodge, North Adonis, Grenada", new DateTime(2020, 10, 27, 1, 32, 24, 878, DateTimeKind.Local).AddTicks(6820), "Bradly Morar" },
                    { new Guid("20faff89-1d8e-65fa-4e22-b7b7529bde10"), "3393 Abdul Views, McCulloughville, Kiribati", new DateTime(2020, 8, 8, 8, 40, 14, 947, DateTimeKind.Local).AddTicks(9621), "Leonardo Hamill" },
                    { new Guid("28077f81-29de-bc56-508b-4f92356b8494"), "060 Balistreri Forks, North Gene, Guadeloupe", new DateTime(2019, 12, 16, 12, 57, 50, 348, DateTimeKind.Local).AddTicks(3592), "Geovanni Smith" },
                    { new Guid("35a2f9db-93d2-31b5-0d55-0c32ba946dbb"), "6176 Sawayn Skyway, South Theodora, Bahamas", new DateTime(2020, 3, 23, 21, 52, 6, 995, DateTimeKind.Local).AddTicks(6744), "Kaylee Hansen" },
                    { new Guid("997399b1-3593-00b2-bee3-d7519304fd12"), "864 Watsica Forge, Jaceyton, Latvia", new DateTime(2020, 9, 19, 21, 5, 18, 28, DateTimeKind.Local).AddTicks(6688), "Cielo Dooley" },
                    { new Guid("81eac716-2020-28d4-4c8f-ee277bb731e2"), "25754 Zelda Isle, Hoppeshire, Paraguay", new DateTime(2019, 12, 25, 4, 16, 12, 578, DateTimeKind.Local).AddTicks(8607), "Rico Nicolas" },
                    { new Guid("a88ac086-dc83-bdf1-2463-f5bd90179545"), "8655 Vincenza Glen, North Norbertoville, Trinidad and Tobago", new DateTime(2020, 7, 15, 21, 17, 3, 113, DateTimeKind.Local).AddTicks(5870), "Sigurd Russel" },
                    { new Guid("a7f6f4f6-c23a-5eee-d863-e312b867ef91"), "64663 Myrna Viaduct, Lake Rosalinda, Chile", new DateTime(2020, 1, 23, 8, 55, 17, 542, DateTimeKind.Local).AddTicks(5491), "Brody Wehner" },
                    { new Guid("9e22999e-0f9e-4fe3-841e-70ebacbb202a"), "7056 Deckow Forge, Labadiemouth, San Marino", new DateTime(2020, 2, 19, 1, 57, 11, 492, DateTimeKind.Local).AddTicks(6208), "Oswald Stracke" },
                    { new Guid("cd1a0382-f2cc-0d3e-c11c-671b42051f77"), "871 Leif Dam, New Xander, Denmark", new DateTime(2020, 6, 11, 21, 25, 34, 206, DateTimeKind.Local).AddTicks(97), "Nelda Stiedemann" },
                    { new Guid("696f511d-a1a8-5e53-7695-979c5fcba2ff"), "78598 Denesik Underpass, West Chelsieborough, Cyprus", new DateTime(2020, 4, 22, 15, 52, 19, 301, DateTimeKind.Local).AddTicks(1502), "Bridgette Hand" },
                    { new Guid("9cd3c94a-d676-3a86-18a0-2667339f3ae1"), "63904 Hessel Camp, New Ramiroland, Tokelau", new DateTime(2020, 1, 7, 7, 28, 57, 91, DateTimeKind.Local).AddTicks(9261), "Eliseo Hilpert" },
                    { new Guid("622cd980-b745-5867-bff5-1c173c10b609"), "44770 Altenwerth Burg, Port Antonina, Holy See (Vatican City State)", new DateTime(2020, 5, 12, 0, 20, 33, 562, DateTimeKind.Local).AddTicks(654), "Aletha Schowalter" },
                    { new Guid("b5611ecc-c037-c5c2-3885-c710d2fbe0ac"), "15982 Corwin Tunnel, Lizziechester, United States Minor Outlying Islands", new DateTime(2020, 1, 25, 3, 43, 55, 500, DateTimeKind.Local).AddTicks(2466), "Aleen O'Keefe" },
                    { new Guid("55f170a5-8753-c7b5-b32e-7f4696df4305"), "72309 Scottie Meadow, Morarville, Anguilla", new DateTime(2020, 11, 18, 5, 56, 4, 570, DateTimeKind.Local).AddTicks(4335), "Aaron Huels" }
                });

            migrationBuilder.InsertData(
                table: "owner",
                columns: new[] { "OwnerId", "Address", "DateOfBirth", "Name" },
                values: new object[,]
                {
                    { new Guid("ee8a2d87-1657-eed6-41c8-d0fc86efd0c3"), "8088 Lang Union, North Wendellberg, Senegal", new DateTime(2020, 9, 20, 14, 22, 22, 771, DateTimeKind.Local).AddTicks(6103), "D'angelo Predovic" },
                    { new Guid("b9b20eec-2016-c746-f449-2cfda60f40b7"), "288 Dietrich Branch, Port Jessikahaven, Botswana", new DateTime(2020, 5, 7, 0, 28, 44, 847, DateTimeKind.Local).AddTicks(5311), "Ottis Raynor" },
                    { new Guid("e0993f49-0a1e-aab7-ec5d-96b584a5a8b0"), "75012 Rodrick Rest, Parkerville, Ecuador", new DateTime(2020, 10, 10, 5, 12, 30, 437, DateTimeKind.Local).AddTicks(2817), "Yazmin Klein" },
                    { new Guid("7566b395-995f-6bec-0b88-3e37d3f742f7"), "7440 Goodwin Oval, Schneiderside, United States Minor Outlying Islands", new DateTime(2020, 4, 24, 6, 54, 35, 161, DateTimeKind.Local).AddTicks(6316), "Jermey Watsica" },
                    { new Guid("f1efd596-3a42-ad82-1749-7189e1e7b13e"), "130 Minnie Heights, South Jovanny, Papua New Guinea", new DateTime(2020, 2, 10, 4, 12, 9, 81, DateTimeKind.Local).AddTicks(8129), "Randy Franecki" },
                    { new Guid("a0d1eeea-07fe-b450-ab8f-e2d76aa9ae3c"), "58732 Nader Fall, West Kaseybury, Virgin Islands, U.S.", new DateTime(2020, 3, 10, 0, 23, 49, 754, DateTimeKind.Local).AddTicks(8404), "Brett Pfeffer" },
                    { new Guid("46109b86-36b2-ca3e-f7b0-7d38c2d1ce0b"), "5005 Madeline Drive, Lake Evert, Ghana", new DateTime(2020, 3, 20, 22, 45, 58, 807, DateTimeKind.Local).AddTicks(3773), "Emory Schuster" },
                    { new Guid("12224b73-4c2b-72f6-6cf7-86a88f4ce6a2"), "193 Isabell Manors, Port Davin, Myanmar", new DateTime(2020, 5, 11, 18, 14, 36, 596, DateTimeKind.Local).AddTicks(9278), "Thaddeus Schultz" },
                    { new Guid("c4989e8b-af76-dfbb-1b64-959d72e6ec34"), "5401 Hamill Pines, Lindbury, Sao Tome and Principe", new DateTime(2020, 9, 4, 13, 11, 34, 463, DateTimeKind.Local).AddTicks(7272), "Cali Jast" },
                    { new Guid("09fae709-87f7-f270-eb0f-bbbe5ebc4333"), "9975 Alysson Points, Kallieport, Tonga", new DateTime(2020, 9, 24, 5, 26, 42, 393, DateTimeKind.Local).AddTicks(8134), "Braeden Glover" },
                    { new Guid("8a93c6ca-e3eb-463c-fffe-49bcd930935c"), "49885 Destin Forges, South Britney, Virgin Islands, British", new DateTime(2020, 6, 24, 16, 25, 4, 35, DateTimeKind.Local).AddTicks(7951), "Leopoldo Marquardt" },
                    { new Guid("2998f4c1-47b8-dc36-17ee-b3e4871c7d13"), "155 Auer Circle, Farrellberg, Saint Barthelemy", new DateTime(2020, 1, 10, 18, 22, 32, 671, DateTimeKind.Local).AddTicks(7301), "Ashlee Wyman" },
                    { new Guid("18ae0cb3-fa3c-9933-8cbd-e8adbe69f61c"), "8129 Cecilia Fork, West Miller, Spain", new DateTime(2020, 9, 12, 7, 6, 22, 495, DateTimeKind.Local).AddTicks(1581), "Rachael Tillman" },
                    { new Guid("3ffff80f-1d69-e543-9b24-710d32857f02"), "878 Kuhn Unions, New Pipermouth, New Caledonia", new DateTime(2020, 4, 29, 6, 37, 20, 806, DateTimeKind.Local).AddTicks(3049), "Dereck Lang" },
                    { new Guid("b1f40cc7-24c2-ff76-8412-2d570e9c4645"), "593 Felix Street, Denesikside, Italy", new DateTime(2020, 10, 31, 2, 46, 23, 540, DateTimeKind.Local).AddTicks(26), "Ford Toy" },
                    { new Guid("0904f211-e726-be97-601f-9169ef7708c2"), "6806 Bahringer Estate, Gottliebmouth, Tunisia", new DateTime(2020, 11, 5, 15, 56, 39, 384, DateTimeKind.Local).AddTicks(7618), "Valentine Grimes" },
                    { new Guid("641b2251-930a-5d20-c75e-d1a9de6abfd7"), "964 Beahan Pine, West Nathan, Ireland", new DateTime(2020, 2, 4, 20, 22, 42, 877, DateTimeKind.Local).AddTicks(8786), "Katelin Heller" },
                    { new Guid("833926aa-944a-d7e5-3b13-ab4f7e2a818a"), "17913 Steuber Brook, Gardnerberg, Cuba", new DateTime(2020, 7, 30, 8, 27, 19, 262, DateTimeKind.Local).AddTicks(1523), "Bret MacGyver" },
                    { new Guid("71bfffa2-6f3b-2ff2-0947-f515359be17f"), "43305 Marianne Summit, North Peggieview, Lesotho", new DateTime(2020, 11, 1, 9, 40, 40, 943, DateTimeKind.Local).AddTicks(8683), "Boris Ruecker" },
                    { new Guid("18c12bdc-4a38-1037-9281-f833ef49c956"), "54838 Ervin Glens, South Junestad, Somalia", new DateTime(2020, 9, 12, 19, 43, 0, 577, DateTimeKind.Local).AddTicks(7708), "Jalen Monahan" },
                    { new Guid("cebdb6bf-7d42-3a67-f960-3fbc6f1c20b9"), "04185 Altenwerth Turnpike, Tadtown, Guinea", new DateTime(2019, 12, 26, 0, 11, 52, 225, DateTimeKind.Local).AddTicks(8800), "Libbie Deckow" },
                    { new Guid("98128af0-f650-40db-931d-bc48c46dece8"), "66771 Domenick Corners, Lake Frankburgh, Brazil", new DateTime(2020, 5, 11, 21, 50, 24, 843, DateTimeKind.Local).AddTicks(5629), "Edythe Swift" },
                    { new Guid("210d927e-5563-7bc1-d4a8-50f2d2ee5445"), "07508 Sadie Forks, Port Matilda, Norfolk Island", new DateTime(2020, 1, 21, 8, 44, 38, 366, DateTimeKind.Local).AddTicks(2668), "Evelyn Barton" },
                    { new Guid("db5aee8b-2043-a21f-78c3-50579164f8e7"), "9377 Bruen Brook, South Estrella, Estonia", new DateTime(2020, 9, 10, 13, 5, 45, 696, DateTimeKind.Local).AddTicks(1956), "Brycen Johnston" },
                    { new Guid("ff47f134-6af9-b648-2af1-1595411283b5"), "2857 Abdullah Wells, Lake Laurieland, Guernsey", new DateTime(2020, 3, 13, 15, 21, 30, 292, DateTimeKind.Local).AddTicks(2718), "Maritza Vandervort" },
                    { new Guid("1ca02325-eef8-7388-102a-c19590bf9189"), "10509 Treutel Forks, Ninaland, Haiti", new DateTime(2020, 7, 10, 10, 44, 9, 297, DateTimeKind.Local).AddTicks(4863), "Horacio Okuneva" },
                    { new Guid("e2ee1b5c-1e98-8bc8-1aa6-9c8c4a3899a6"), "2394 Alycia Ways, West Erickaton, Slovenia", new DateTime(2020, 12, 9, 8, 39, 23, 720, DateTimeKind.Local).AddTicks(1559), "Grant Hackett" },
                    { new Guid("a2a43483-fca7-a30e-d4e0-ccd1161cfd06"), "26242 Bogisich Bypass, New Garrick, Democratic People's Republic of Korea", new DateTime(2020, 9, 12, 15, 6, 27, 342, DateTimeKind.Local).AddTicks(5934), "Dave Cole" },
                    { new Guid("f504c63c-0604-9d46-71d0-5fe6e5e699c4"), "0358 Cartwright Station, Malvinachester, Lebanon", new DateTime(2020, 4, 28, 8, 0, 20, 127, DateTimeKind.Local).AddTicks(7042), "Samson Conroy" },
                    { new Guid("55d90f56-11f9-5d87-5705-eb9cbd8153fe"), "4157 Rose Plaza, South Leolaborough, Puerto Rico", new DateTime(2020, 2, 29, 21, 53, 6, 916, DateTimeKind.Local).AddTicks(6681), "Kassandra O'Keefe" },
                    { new Guid("0cd58f37-cb44-4136-a03c-32077a59ba15"), "34965 Isaias Canyon, Dalestad, Syrian Arab Republic", new DateTime(2020, 3, 12, 17, 15, 40, 877, DateTimeKind.Local).AddTicks(8146), "Jasmin Bradtke" },
                    { new Guid("7ef1866a-03f1-fbcc-2b19-a557413694fd"), "67477 Renner Vista, Lake Corbinfort, Mauritius", new DateTime(2020, 1, 24, 12, 21, 21, 994, DateTimeKind.Local).AddTicks(2442), "Ambrose Bernhard" },
                    { new Guid("97c8d20f-cdd2-fa4e-0453-cf2f4e6e775a"), "1690 Edward Plaza, Lake Avery, Malta", new DateTime(2020, 5, 15, 14, 50, 24, 26, DateTimeKind.Local).AddTicks(7082), "Kristofer Cremin" },
                    { new Guid("c226dc3e-ed35-8eae-8158-fe764b1f2d31"), "68681 Auer Port, West Kadintown, Cameroon", new DateTime(2020, 11, 28, 18, 20, 5, 821, DateTimeKind.Local).AddTicks(8927), "Lane Lynch" },
                    { new Guid("b54871f0-7a25-40e9-c8f8-68468c0f4733"), "4147 Mosciski Glens, Yundtberg, Niue", new DateTime(2020, 5, 8, 1, 12, 55, 221, DateTimeKind.Local).AddTicks(4663), "Sheridan Fay" },
                    { new Guid("bc2f0fb5-93e8-735e-0501-071c40cf6557"), "84000 Madilyn Flat, West Sabrina, Saint Kitts and Nevis", new DateTime(2020, 7, 21, 18, 19, 20, 462, DateTimeKind.Local).AddTicks(403), "Alfredo Durgan" },
                    { new Guid("e07d9197-4a8a-3c30-769d-4e68ab3ddcdd"), "737 Hayley Lodge, West Ashley, Uganda", new DateTime(2020, 5, 6, 8, 15, 10, 417, DateTimeKind.Local).AddTicks(1770), "Shanelle Senger" },
                    { new Guid("a8a07ee6-e83e-8b77-eb4d-06cc809c18fd"), "0673 Arnaldo Union, East Dell, Antigua and Barbuda", new DateTime(2020, 12, 5, 9, 51, 6, 205, DateTimeKind.Local).AddTicks(2866), "Leanne Herzog" },
                    { new Guid("ea682ef7-940b-f59e-b6b0-037233c11787"), "93134 Kutch Crossing, New Philipborough, Turkmenistan", new DateTime(2020, 10, 15, 15, 4, 25, 126, DateTimeKind.Local).AddTicks(5199), "Braden Yundt" },
                    { new Guid("2d3351d4-f9f2-0e8d-0faa-29550f46e2d1"), "893 Casper Streets, Port Finnton, Venezuela", new DateTime(2020, 2, 21, 4, 21, 39, 303, DateTimeKind.Local).AddTicks(2337), "Dewitt Gorczany" },
                    { new Guid("c6ececca-6854-9622-d069-a8688f614d59"), "7259 White Center, Torphyton, Guinea-Bissau", new DateTime(2020, 5, 30, 17, 10, 40, 39, DateTimeKind.Local).AddTicks(2377), "Brandt Fadel" },
                    { new Guid("228ae50c-1c59-347d-4006-77de96b320d2"), "09104 Kilback Village, Port Oren, Afghanistan", new DateTime(2020, 2, 14, 7, 4, 46, 810, DateTimeKind.Local).AddTicks(3860), "Betsy Ratke" }
                });

            migrationBuilder.InsertData(
                table: "owner",
                columns: new[] { "OwnerId", "Address", "DateOfBirth", "Name" },
                values: new object[,]
                {
                    { new Guid("d7a95b0b-ff2a-3f46-746f-1ae81fff8162"), "10979 Sherman Greens, Lake Kayli, Austria", new DateTime(2020, 1, 27, 20, 5, 3, 969, DateTimeKind.Local).AddTicks(6399), "Dorthy Reinger" },
                    { new Guid("76578a1e-36fb-b19b-6955-7f0982cf570f"), "3824 Metz Lights, Botsfordside, Nicaragua", new DateTime(2020, 6, 26, 17, 42, 19, 300, DateTimeKind.Local).AddTicks(5549), "Malcolm Aufderhar" },
                    { new Guid("fea90af6-d6b7-a577-a010-a4c9a9e6abbe"), "87078 Pauline Burg, Schambergerside, Guatemala", new DateTime(2020, 4, 18, 8, 27, 13, 325, DateTimeKind.Local).AddTicks(2181), "Erick Cormier" },
                    { new Guid("a768e061-f422-e079-a4f6-1d432c494bbb"), "804 Adrianna Drives, Batzmouth, Cyprus", new DateTime(2020, 8, 10, 16, 22, 30, 25, DateTimeKind.Local).AddTicks(3390), "Callie Kertzmann" },
                    { new Guid("246b74b6-771d-2484-adae-b3872260973e"), "69100 Lockman Turnpike, West Tiffanymouth, Trinidad and Tobago", new DateTime(2020, 11, 10, 19, 7, 25, 348, DateTimeKind.Local).AddTicks(5224), "Jacklyn Okuneva" },
                    { new Guid("ae3ab9d4-cab6-0b9e-05c2-f21854d4cc40"), "5231 Lyric Ports, Austynport, Angola", new DateTime(2020, 11, 14, 8, 38, 42, 967, DateTimeKind.Local).AddTicks(581), "Krista Beatty" },
                    { new Guid("174e9a27-5ccc-b8a4-908c-46e64b1321bc"), "5523 Mitchell Brook, Antoinettechester, Turkey", new DateTime(2020, 9, 20, 0, 16, 56, 507, DateTimeKind.Local).AddTicks(6464), "Michelle Rau" },
                    { new Guid("0ea9f656-528f-7af2-def0-37b8d19ef819"), "9761 Annetta Via, Lake Emerald, Italy", new DateTime(2020, 10, 5, 19, 20, 23, 341, DateTimeKind.Local).AddTicks(7223), "Mitchel Ullrich" },
                    { new Guid("548f2a34-1369-372c-ab53-c5bc39875a2d"), "59973 Erica Court, South Amos, Cyprus", new DateTime(2020, 7, 17, 0, 7, 28, 681, DateTimeKind.Local).AddTicks(3831), "Jaida Will" },
                    { new Guid("0ea78423-afa3-80f2-547d-1f06fe7dd3c8"), "9196 Anna Summit, Dejonside, Japan", new DateTime(2020, 3, 30, 16, 37, 35, 950, DateTimeKind.Local).AddTicks(3051), "Dudley Smitham" },
                    { new Guid("0215e24e-1eb3-2541-4473-9db089843d75"), "7717 Shana Crossroad, North Josiahland, Heard Island and McDonald Islands", new DateTime(2020, 9, 26, 22, 55, 21, 255, DateTimeKind.Local).AddTicks(353), "Camylle Torp" },
                    { new Guid("671cb7d8-15d0-c7fe-73eb-af8355f780db"), "507 Kuphal Road, Bernierview, Aruba", new DateTime(2020, 10, 9, 0, 8, 28, 461, DateTimeKind.Local).AddTicks(6713), "Adolf Metz" },
                    { new Guid("b1da79b2-20cc-0f0e-8feb-34005b067f29"), "41965 Rolfson Manor, South Eusebiohaven, Nauru", new DateTime(2020, 6, 29, 22, 26, 47, 471, DateTimeKind.Local).AddTicks(4386), "Una Volkman" },
                    { new Guid("467a09fc-bab4-70f2-8a5a-77d1ac25935a"), "096 Tyler Village, South Adelia, Bahamas", new DateTime(2020, 8, 28, 8, 9, 17, 228, DateTimeKind.Local).AddTicks(5923), "Torrey Crist" },
                    { new Guid("09217823-ae75-d4e8-f445-a21b84b23403"), "1886 Lukas Rest, South Julesview, India", new DateTime(2020, 3, 10, 11, 37, 49, 436, DateTimeKind.Local).AddTicks(5461), "Philip Ankunding" },
                    { new Guid("8a595357-1d1b-75ab-b712-6efcf016fd76"), "25071 Bruen Stream, Bartside, Saint Helena", new DateTime(2020, 11, 8, 3, 15, 15, 440, DateTimeKind.Local).AddTicks(8996), "Consuelo Langosh" },
                    { new Guid("db5e2c98-ad78-47a3-b5a5-f6649d0058cd"), "171 Darron Summit, Connland, Marshall Islands", new DateTime(2020, 7, 26, 11, 50, 24, 376, DateTimeKind.Local).AddTicks(5936), "Jazmyne Hessel" },
                    { new Guid("570863a7-9eea-a09b-b955-8727ff2240ea"), "79373 Tillman Stream, Aidenshire, Mali", new DateTime(2020, 2, 8, 12, 48, 5, 730, DateTimeKind.Local).AddTicks(9591), "Ed McClure" },
                    { new Guid("94014e2b-6da8-882f-dd68-eb5880b31773"), "1990 Luigi Avenue, East Norene, Netherlands", new DateTime(2020, 7, 23, 10, 56, 51, 751, DateTimeKind.Local).AddTicks(5626), "Wilfredo MacGyver" },
                    { new Guid("11deb580-b39d-98ad-8e7b-7d3b7d9027d8"), "98794 Schimmel Freeway, Port Agustinaborough, Mauritius", new DateTime(2020, 7, 17, 21, 18, 32, 624, DateTimeKind.Local).AddTicks(942), "Dane Abshire" },
                    { new Guid("d3d49906-553e-406f-e7a0-e0e0dfbc70c5"), "6978 Vivien Key, New Dellmouth, Chad", new DateTime(2020, 3, 19, 4, 10, 36, 518, DateTimeKind.Local).AddTicks(9045), "Laney Treutel" },
                    { new Guid("896bbd86-cae6-997e-45fb-06319471b069"), "3981 Kevin Drives, North Sigurd, India", new DateTime(2020, 2, 23, 7, 5, 5, 320, DateTimeKind.Local).AddTicks(6111), "Sid Kutch" },
                    { new Guid("fbf7add2-6ccb-a1c4-4135-08aa30d8cf72"), "291 Tavares Oval, Lake Cyrilborough, Turkey", new DateTime(2020, 8, 10, 9, 14, 24, 636, DateTimeKind.Local).AddTicks(3787), "Phyllis Stanton" },
                    { new Guid("e75e6d18-b579-df9d-8da9-13b002d1e904"), "96585 Lori Pike, Lake Baileeville, Botswana", new DateTime(2020, 5, 13, 21, 12, 30, 850, DateTimeKind.Local).AddTicks(4710), "Donato Miller" },
                    { new Guid("e77ac291-6ef8-01ac-653c-2398786e67a8"), "2922 Rath Alley, New Eldora, Brunei Darussalam", new DateTime(2020, 2, 10, 4, 21, 1, 476, DateTimeKind.Local).AddTicks(9233), "Jayde Mosciski" },
                    { new Guid("2740f104-c389-cdf3-176a-8a7578cc034b"), "1839 Kunde Rest, Irvingport, Andorra", new DateTime(2020, 7, 1, 11, 53, 27, 713, DateTimeKind.Local).AddTicks(8533), "Doug Dooley" },
                    { new Guid("879334c9-402e-fd1f-8a13-ae209c454ab6"), "4391 Luna Heights, West Dandre, Liechtenstein", new DateTime(2020, 2, 2, 16, 35, 13, 755, DateTimeKind.Local).AddTicks(9115), "Elsie Kozey" },
                    { new Guid("43ab5989-7c38-d31c-f69b-2c2d3766cdc2"), "270 Katelyn Knolls, Port Alberthatown, Tajikistan", new DateTime(2020, 5, 7, 8, 4, 0, 36, DateTimeKind.Local).AddTicks(5131), "Bryce Connelly" },
                    { new Guid("439620ba-0699-7c7e-913d-13008e80e803"), "10525 Lesch Loop, Port Alf, Switzerland", new DateTime(2020, 10, 7, 17, 18, 29, 31, DateTimeKind.Local).AddTicks(5890), "Lazaro Rippin" },
                    { new Guid("d016739a-2889-2f67-8534-3cc2947f058b"), "913 Nicolas Ports, Port Mayefurt, Norfolk Island", new DateTime(2020, 12, 4, 18, 23, 12, 524, DateTimeKind.Local).AddTicks(6837), "Freda Hirthe" },
                    { new Guid("0cf4046a-33d1-337e-fb80-705fd8f02f1e"), "4999 Wiegand Manors, Marcelinatown, Cote d'Ivoire", new DateTime(2020, 3, 25, 2, 33, 1, 376, DateTimeKind.Local).AddTicks(1660), "Alexander Nitzsche" },
                    { new Guid("8f58b166-f88a-e5ba-d190-ef6e2cc733f2"), "73583 Carroll Gardens, Autumnburgh, British Indian Ocean Territory (Chagos Archipelago)", new DateTime(2020, 11, 27, 17, 12, 17, 915, DateTimeKind.Local).AddTicks(3577), "Nova Shanahan" },
                    { new Guid("9726f808-949f-7ec0-60a1-5dce9fd185d7"), "05374 Wellington Plains, North Lethaton, Netherlands", new DateTime(2020, 7, 22, 12, 41, 36, 148, DateTimeKind.Local).AddTicks(3823), "Alanis Schmitt" },
                    { new Guid("5b0ccf23-49af-02ce-77b8-3fde58263aef"), "846 Vandervort Spurs, East Sigmund, Argentina", new DateTime(2020, 9, 26, 20, 47, 17, 19, DateTimeKind.Local).AddTicks(9199), "Leopoldo Grimes" },
                    { new Guid("dfe65122-3543-7bc3-27c9-5eda7eb837f6"), "84064 Vivienne Summit, East Noel, India", new DateTime(2020, 4, 24, 13, 15, 1, 540, DateTimeKind.Local).AddTicks(5499), "Bette Prosacco" },
                    { new Guid("74010ca4-eb2a-ab2b-cf8a-957e9eb79c64"), "453 Jabari Ferry, North Fernbury, Montenegro", new DateTime(2020, 2, 17, 4, 14, 30, 319, DateTimeKind.Local).AddTicks(6718), "Beryl Renner" },
                    { new Guid("a6152253-585c-9b0e-e20a-893509b4d831"), "84282 Hahn Drives, Handview, Martinique", new DateTime(2020, 4, 9, 18, 36, 39, 948, DateTimeKind.Local).AddTicks(885), "Ken Welch" },
                    { new Guid("8a9aa00f-81d4-9f8b-9581-4fdfcd28233a"), "617 Keyshawn Landing, West Sophie, Ghana", new DateTime(2019, 12, 31, 21, 10, 26, 585, DateTimeKind.Local).AddTicks(6875), "Gay Stark" },
                    { new Guid("9eeb0b82-fc8a-fdd8-b28c-0a9e311d924a"), "7975 Pamela Pike, South Fredrickton, Cote d'Ivoire", new DateTime(2020, 7, 6, 13, 26, 33, 966, DateTimeKind.Local).AddTicks(1132), "Dolly Boyer" },
                    { new Guid("ec8ab369-c106-be0a-ae00-dab02949a334"), "3384 Glover Rue, Maceyton, Sri Lanka", new DateTime(2020, 9, 18, 3, 41, 3, 962, DateTimeKind.Local).AddTicks(4918), "Daron Volkman" },
                    { new Guid("69c7c80b-5d07-1f1a-336b-6a3d6e509d4b"), "8746 Padberg Parks, West Lavernastad, Burundi", new DateTime(2019, 12, 19, 4, 18, 45, 572, DateTimeKind.Local).AddTicks(8504), "Millie Lang" },
                    { new Guid("8160a44a-2d3a-32fc-f53c-ea3a0555993a"), "218 Kimberly Rapid, Halvorsonburgh, Ukraine", new DateTime(2020, 5, 16, 21, 27, 54, 538, DateTimeKind.Local).AddTicks(6716), "Herman Turner" }
                });

            migrationBuilder.InsertData(
                table: "owner",
                columns: new[] { "OwnerId", "Address", "DateOfBirth", "Name" },
                values: new object[,]
                {
                    { new Guid("2378cf36-3dac-52c9-ed93-f6f253948969"), "660 Konopelski Heights, New Jeramieborough, Venezuela", new DateTime(2020, 9, 21, 0, 42, 31, 287, DateTimeKind.Local).AddTicks(1462), "Eric Bauch" },
                    { new Guid("6ab347a2-318c-fced-e1ec-81ee1bb628b4"), "15330 Aidan Tunnel, Roobside, United Kingdom", new DateTime(2020, 12, 3, 11, 29, 11, 390, DateTimeKind.Local).AddTicks(2634), "Keon Spinka" },
                    { new Guid("e00b50af-dd1f-7b41-f840-13432997eb00"), "878 Skiles Estate, Lake Juston, Uganda", new DateTime(2020, 8, 18, 22, 14, 47, 239, DateTimeKind.Local).AddTicks(7763), "Wilma Bahringer" },
                    { new Guid("6bfb81da-1c65-5bd3-b28c-76fef0e12d8e"), "38162 Goyette Estates, Lake Douglasside, Bangladesh", new DateTime(2020, 6, 10, 11, 59, 7, 348, DateTimeKind.Local).AddTicks(5251), "Darryl Russel" },
                    { new Guid("2b2dc138-e385-a78f-fd93-375280711524"), "495 Glover Run, North Clairshire, Chile", new DateTime(2020, 2, 7, 10, 34, 53, 434, DateTimeKind.Local).AddTicks(2894), "Clifford Block" },
                    { new Guid("6ba944dd-0360-9e10-33a1-634c0c0c5e47"), "39233 Considine Valleys, Marlenbury, Algeria", new DateTime(2020, 10, 27, 15, 56, 20, 194, DateTimeKind.Local).AddTicks(4377), "Althea Hettinger" },
                    { new Guid("c83c75d2-c4a9-0793-49e0-ab1554aa0028"), "7690 Bayer Estate, Kipside, Montserrat", new DateTime(2020, 3, 18, 8, 21, 48, 222, DateTimeKind.Local).AddTicks(9126), "Niko Zemlak" },
                    { new Guid("973ab301-7f21-82df-ec73-df2cb3a9cbcb"), "995 McKenzie Dam, Dorothystad, Saudi Arabia", new DateTime(2020, 5, 7, 22, 45, 49, 858, DateTimeKind.Local).AddTicks(6352), "Rodger Waters" },
                    { new Guid("14c2082a-70a1-0669-9dcc-25300c5da332"), "175 Bernhard Underpass, West Desmond, Netherlands Antilles", new DateTime(2020, 6, 12, 23, 52, 38, 789, DateTimeKind.Local).AddTicks(2305), "Cheyenne VonRueden" },
                    { new Guid("b47d3ea8-f024-2994-5ab4-d0c5e2eb150c"), "9515 Samantha Course, Leannonville, Tokelau", new DateTime(2020, 8, 27, 5, 25, 38, 976, DateTimeKind.Local).AddTicks(7188), "Cleveland Funk" },
                    { new Guid("f17c49fc-a98f-417f-ab56-c4136af647ec"), "33403 Emard Curve, Lake Ignatiusport, Panama", new DateTime(2020, 11, 17, 6, 52, 23, 938, DateTimeKind.Local).AddTicks(3261), "Emie Huels" },
                    { new Guid("236e98c8-8e7c-e282-f385-f7d3507796fd"), "530 Mazie Overpass, Port Demetrismouth, Macao", new DateTime(2020, 6, 17, 8, 20, 38, 676, DateTimeKind.Local).AddTicks(4331), "Linnie Casper" },
                    { new Guid("ae2ed5d5-827d-e011-6fc4-0f20f48571ce"), "72125 Tromp Route, Boyermouth, Kazakhstan", new DateTime(2020, 1, 29, 8, 54, 19, 391, DateTimeKind.Local).AddTicks(6979), "Kory Herman" },
                    { new Guid("497bfdc3-7fe8-662f-7c16-d0eb829c145b"), "4648 Tobin Mission, East Donavon, Western Sahara", new DateTime(2020, 5, 20, 20, 39, 32, 138, DateTimeKind.Local).AddTicks(453), "Rodrick Hegmann" },
                    { new Guid("8731ce8b-84f6-88c7-5944-b5a130e27242"), "400 Brekke Ramp, Nitzschetown, Mexico", new DateTime(2020, 9, 25, 15, 34, 35, 89, DateTimeKind.Local).AddTicks(8423), "Cole Frami" },
                    { new Guid("5fb3f0c7-6ab3-658c-10c1-aa8d434c7ca3"), "96266 Dibbert Fords, Port Sallieview, Palau", new DateTime(2020, 3, 30, 6, 3, 5, 999, DateTimeKind.Local).AddTicks(5080), "Green Auer" },
                    { new Guid("827cb0ee-d7be-efe9-86fd-ca1086756303"), "7172 Else Manor, Rickville, Virgin Islands, U.S.", new DateTime(2019, 12, 23, 2, 59, 54, 566, DateTimeKind.Local).AddTicks(3956), "Jaycee Muller" },
                    { new Guid("cb5d026b-fb27-8688-981e-9968ddde7efa"), "90137 Elnora Lakes, Dareborough, Sri Lanka", new DateTime(2020, 1, 8, 18, 41, 31, 90, DateTimeKind.Local).AddTicks(130), "Ruby Cronin" },
                    { new Guid("1783a4c8-db97-5f6e-fb1d-d70f222e922f"), "188 Okuneva Course, Maggiomouth, United States of America", new DateTime(2020, 10, 21, 9, 12, 55, 760, DateTimeKind.Local).AddTicks(7935), "Rory Smitham" },
                    { new Guid("15938745-fa3a-abe2-70c2-522a4f723603"), "155 Marilyne Circle, Leonoraland, Virgin Islands, U.S.", new DateTime(2019, 12, 20, 6, 13, 4, 738, DateTimeKind.Local).AddTicks(8287), "Aliya Trantow" },
                    { new Guid("928950e6-8e87-5818-341d-f4597f25b0af"), "872 Torp Villages, Lake Josueburgh, Grenada", new DateTime(2020, 3, 2, 3, 58, 11, 712, DateTimeKind.Local).AddTicks(5686), "Edmond Zemlak" },
                    { new Guid("da6b3e4a-e0c5-75af-2a26-aabd6fb64f37"), "4404 Alessandra Harbors, Kaylahfort, Ukraine", new DateTime(2020, 4, 21, 9, 7, 52, 500, DateTimeKind.Local).AddTicks(806), "Sid O'Keefe" },
                    { new Guid("410f3b3a-d6b9-64ea-312c-4845ed12bf7f"), "153 Reichert Ports, East Desmondport, Malaysia", new DateTime(2020, 5, 18, 9, 45, 4, 362, DateTimeKind.Local).AddTicks(3426), "Baby Monahan" },
                    { new Guid("8ebbaff1-f10f-8f15-e4f1-ac54273596d8"), "64788 Barrows Rue, East Jermainside, Hungary", new DateTime(2020, 6, 17, 9, 59, 52, 744, DateTimeKind.Local).AddTicks(5600), "Marion Beer" },
                    { new Guid("3482a562-0ea6-657d-0b21-ec236ad35f6d"), "840 Bergstrom Shores, South Baylee, Cote d'Ivoire", new DateTime(2020, 8, 18, 1, 17, 15, 913, DateTimeKind.Local).AddTicks(6445), "Maribel Wehner" },
                    { new Guid("d3ba71e4-ef13-35c8-22f0-3f8374bba62d"), "06099 Stoltenberg Road, Creminfort, Mexico", new DateTime(2020, 11, 26, 23, 0, 18, 53, DateTimeKind.Local).AddTicks(8903), "Michele Marvin" },
                    { new Guid("e6624951-1e7a-76fa-c442-d7116a69ce35"), "685 Blanca Estates, Keelington, Montenegro", new DateTime(2020, 2, 3, 12, 20, 36, 466, DateTimeKind.Local).AddTicks(6142), "Jo Heller" },
                    { new Guid("ecddeeae-5552-fcf1-a5f1-b5c6806df527"), "8314 Gottlieb Union, McLaughlintown, Iran", new DateTime(2020, 10, 4, 6, 53, 45, 294, DateTimeKind.Local).AddTicks(6741), "Eric Jast" },
                    { new Guid("5ea5182a-4901-d8c0-67f9-10ad1f5f4981"), "30435 Oberbrunner Pines, Ferryburgh, Gibraltar", new DateTime(2020, 1, 5, 5, 11, 17, 408, DateTimeKind.Local).AddTicks(595), "Lincoln Leuschke" },
                    { new Guid("c8689b2c-2596-a859-b1e3-e16555b8f2c1"), "537 Jaylon Way, South Benton, American Samoa", new DateTime(2020, 5, 28, 22, 16, 37, 782, DateTimeKind.Local).AddTicks(2012), "Lavern Corkery" },
                    { new Guid("f3ce1e89-e1c3-a6b9-3035-3169efb4d296"), "5976 Denis Lodge, Nolanton, Bosnia and Herzegovina", new DateTime(2020, 5, 1, 11, 19, 40, 904, DateTimeKind.Local).AddTicks(5094), "Devante Kozey" },
                    { new Guid("4758b9d8-c486-df2f-19d0-07ee070466cc"), "169 Murphy Locks, North Rashad, Pitcairn Islands", new DateTime(2020, 5, 16, 7, 28, 14, 392, DateTimeKind.Local).AddTicks(3915), "Robbie Cartwright" },
                    { new Guid("91018b06-5c36-0f8a-8878-a612f532e09f"), "73630 Tremblay Crossroad, O'Reillytown, Bahamas", new DateTime(2020, 9, 5, 14, 44, 42, 581, DateTimeKind.Local).AddTicks(1694), "Chaya Reynolds" },
                    { new Guid("0562004e-3073-1070-cc26-8f4c9a6f1d6f"), "30326 Beer Brook, Quigleyfurt, Heard Island and McDonald Islands", new DateTime(2020, 9, 14, 22, 3, 44, 116, DateTimeKind.Local).AddTicks(8943), "Gene Botsford" },
                    { new Guid("7d32a657-469a-a8ad-b07b-5312f091e5ea"), "143 Luz Gateway, Swiftland, Falkland Islands (Malvinas)", new DateTime(2020, 3, 29, 23, 56, 34, 208, DateTimeKind.Local).AddTicks(1733), "Kavon Mosciski" },
                    { new Guid("438bc72e-ebc8-eef2-36f3-38eebf39d6d4"), "24599 Ashleigh Ridge, Gerlachmouth, Sao Tome and Principe", new DateTime(2020, 3, 11, 4, 7, 38, 225, DateTimeKind.Local).AddTicks(7433), "Caleigh Stoltenberg" },
                    { new Guid("644b245f-1c4e-96fe-e8dd-1acb2e5339a2"), "516 Lilliana Coves, Williamsonville, Dominican Republic", new DateTime(2020, 3, 9, 3, 57, 22, 255, DateTimeKind.Local).AddTicks(2484), "Harold Olson" },
                    { new Guid("60bbac93-8b15-8770-df6a-73f1079ef10c"), "6768 Robel Turnpike, Ilenetown, Malta", new DateTime(2020, 9, 6, 5, 27, 8, 70, DateTimeKind.Local).AddTicks(5531), "Dahlia Shields" },
                    { new Guid("1f87e054-f272-1723-fbb0-7149ff50416e"), "24174 Rolfson Drive, Kraigfurt, Tuvalu", new DateTime(2020, 9, 25, 7, 6, 19, 922, DateTimeKind.Local).AddTicks(6145), "Royal Dietrich" },
                    { new Guid("17269dcb-9ad1-614d-49f3-519d8ec0cd9a"), "68119 Eryn Mall, Lake Maeve, Turks and Caicos Islands", new DateTime(2020, 10, 23, 10, 28, 48, 458, DateTimeKind.Local).AddTicks(6328), "Arthur Robel" },
                    { new Guid("1ab233af-0b57-a762-4542-b2aae7453b75"), "9184 Schmitt Curve, South Hadleyville, Montserrat", new DateTime(2020, 11, 5, 3, 48, 37, 714, DateTimeKind.Local).AddTicks(2405), "Filomena Kessler" },
                    { new Guid("1b8cde24-777f-e7ae-4ce5-d8fb3b1a053a"), "666 Lubowitz Common, New Tracymouth, Sudan", new DateTime(2020, 2, 19, 2, 26, 47, 924, DateTimeKind.Local).AddTicks(9127), "Willa Carroll" }
                });

            migrationBuilder.InsertData(
                table: "owner",
                columns: new[] { "OwnerId", "Address", "DateOfBirth", "Name" },
                values: new object[,]
                {
                    { new Guid("66c3c8e0-59af-0620-7111-b889d7f205fb"), "97846 Ryan Pike, Rosinaburgh, Gambia", new DateTime(2020, 8, 16, 14, 50, 23, 813, DateTimeKind.Local).AddTicks(8285), "Summer Rogahn" },
                    { new Guid("57731b15-8b9e-2be1-4490-65bcb7abd0d3"), "40943 Witting Creek, Lake Hillard, Tajikistan", new DateTime(2020, 10, 7, 22, 36, 25, 602, DateTimeKind.Local).AddTicks(1597), "Magnus Schoen" },
                    { new Guid("92d7c272-e2a4-815e-01ef-3f06f3e65c86"), "99286 Orin Neck, Parisianland, Botswana", new DateTime(2020, 6, 25, 8, 49, 5, 72, DateTimeKind.Local).AddTicks(4528), "Marvin Blick" },
                    { new Guid("f8e94545-a141-f521-25a0-9dd1561fe249"), "7920 Deckow Mountain, Port Keiramouth, South Africa", new DateTime(2020, 10, 31, 4, 36, 27, 920, DateTimeKind.Local).AddTicks(5571), "Lilyan Prosacco" },
                    { new Guid("73a1ae08-8f8d-044f-5f75-d5e938c025f3"), "6894 Quigley Rapids, South Kelsi, Iran", new DateTime(2020, 2, 28, 7, 31, 50, 506, DateTimeKind.Local).AddTicks(8331), "Destany Cremin" },
                    { new Guid("714ddb23-d641-18ed-8e1d-b366275195ba"), "0355 Hammes Keys, Lefflerbury, Saudi Arabia", new DateTime(2020, 12, 8, 8, 0, 8, 101, DateTimeKind.Local).AddTicks(4204), "Talon Von" },
                    { new Guid("5cc685f1-b473-c5b1-75ef-070a3704215d"), "8336 Abshire Flats, Kochfort, Congo", new DateTime(2020, 6, 12, 17, 33, 47, 624, DateTimeKind.Local).AddTicks(7970), "Arden Zulauf" },
                    { new Guid("a174cf2e-398a-8647-6719-ca59dcc3e63e"), "6459 Celine Drive, South Zackerymouth, Mauritania", new DateTime(2020, 11, 25, 14, 58, 23, 969, DateTimeKind.Local).AddTicks(9692), "Abigail Wisozk" },
                    { new Guid("9068dc87-d280-c45b-7f95-8379ad624948"), "990 Kris Courts, New Alexane, Heard Island and McDonald Islands", new DateTime(2020, 11, 21, 22, 21, 4, 347, DateTimeKind.Local).AddTicks(337), "Rico Stoltenberg" },
                    { new Guid("55b9df65-7ee7-b6ae-9472-f8885cc333d0"), "3523 Doug Park, North Jasenfort, Tonga", new DateTime(2020, 10, 1, 12, 26, 26, 227, DateTimeKind.Local).AddTicks(926), "Heath Goldner" },
                    { new Guid("f49a1df7-620c-40ca-fa16-4a99f0dfc493"), "880 Waters Lock, Lake Mylesmouth, Portugal", new DateTime(2020, 5, 23, 1, 50, 57, 395, DateTimeKind.Local).AddTicks(6010), "Johanna Tillman" },
                    { new Guid("a6650936-db99-a318-3057-1cf2e2751ec0"), "5167 August Landing, East Prince, Eritrea", new DateTime(2020, 10, 5, 23, 21, 55, 682, DateTimeKind.Local).AddTicks(6961), "Carolanne Schneider" },
                    { new Guid("a17afd03-1299-4637-fe3b-932c48e20505"), "048 Conn Highway, Wizafort, Bangladesh", new DateTime(2020, 3, 4, 11, 31, 56, 555, DateTimeKind.Local).AddTicks(6068), "Mireya Pagac" },
                    { new Guid("e20d1052-9048-d88b-5a80-879387d8462c"), "7457 Angus Pike, Stehrfurt, French Guiana", new DateTime(2020, 5, 3, 10, 41, 5, 887, DateTimeKind.Local).AddTicks(7732), "Jany Schuppe" },
                    { new Guid("129a418a-f05c-dd16-1004-0bd97b91d59d"), "3722 Morissette Avenue, New Grahamchester, French Southern Territories", new DateTime(2020, 6, 3, 10, 51, 30, 824, DateTimeKind.Local).AddTicks(6114), "Asha Hills" },
                    { new Guid("3d45089d-d033-a763-0fbe-a26de9bcac72"), "4812 Wisozk Hills, New Miltonland, Nicaragua", new DateTime(2020, 10, 13, 17, 53, 21, 882, DateTimeKind.Local).AddTicks(406), "Tyrese Ortiz" },
                    { new Guid("98cc06e0-e86b-b6ea-7908-cbd4f6064f1d"), "5719 Bernhard Loop, Kuvalisborough, Saint Vincent and the Grenadines", new DateTime(2020, 3, 21, 6, 27, 18, 623, DateTimeKind.Local).AddTicks(1810), "Talia Greenholt" },
                    { new Guid("e173b376-47f0-4a20-eb1c-cbbebd66bf7a"), "350 Rodriguez Wells, Lake Germaine, Gibraltar", new DateTime(2020, 4, 30, 15, 50, 29, 3, DateTimeKind.Local).AddTicks(9216), "Corine Adams" },
                    { new Guid("5da333bb-9242-2c6d-e9cb-7bbd32d8201e"), "1595 Emil Alley, New Dawson, Iceland", new DateTime(2020, 3, 8, 7, 24, 18, 647, DateTimeKind.Local).AddTicks(6704), "Electa Crooks" },
                    { new Guid("8b106e5f-081a-e77d-535a-5f24d1f2b264"), "4042 Melany Creek, Bernierview, Sierra Leone", new DateTime(2020, 12, 8, 17, 58, 37, 212, DateTimeKind.Local).AddTicks(5823), "Rupert Jaskolski" },
                    { new Guid("c45e8d5b-95c8-a904-7d2a-492614c108d2"), "62558 Rickey Run, West Tabitha, Yemen", new DateTime(2020, 3, 18, 11, 25, 22, 209, DateTimeKind.Local).AddTicks(1642), "Manuel Lehner" },
                    { new Guid("9444c83e-9bed-cd70-2337-1ea605328bc1"), "390 Tremblay Views, Jeannebury, France", new DateTime(2020, 5, 11, 9, 12, 30, 276, DateTimeKind.Local).AddTicks(7965), "Leora Corkery" },
                    { new Guid("d5f8a89d-c3f8-2e3e-3744-62d78287c93d"), "288 Freeman Alley, South Vickieland, French Southern Territories", new DateTime(2020, 3, 16, 9, 34, 15, 410, DateTimeKind.Local).AddTicks(1881), "Lelah Treutel" },
                    { new Guid("fe81c3ea-5d0c-fd93-8728-4fb89a4e1f60"), "0109 Leuschke Islands, Lexihaven, Romania", new DateTime(2020, 5, 16, 18, 47, 9, 229, DateTimeKind.Local).AddTicks(2788), "Rhiannon Tremblay" },
                    { new Guid("bfed482a-ca05-3830-1f92-2389b5eb97ca"), "66019 Milan Crescent, West Makenzieport, Qatar", new DateTime(2020, 9, 11, 1, 44, 37, 673, DateTimeKind.Local).AddTicks(4041), "Ciara Torp" },
                    { new Guid("6060528d-5b5a-3114-8391-6b38e2182ef2"), "858 Nolan Fords, Corneliusborough, Honduras", new DateTime(2020, 2, 12, 11, 3, 5, 812, DateTimeKind.Local).AddTicks(8285), "Jettie Renner" },
                    { new Guid("5d012434-6945-a2a6-2412-00f265f0c806"), "738 Fritsch Causeway, Swiftmouth, Kuwait", new DateTime(2020, 6, 4, 14, 29, 38, 244, DateTimeKind.Local).AddTicks(8884), "Lorine Quitzon" },
                    { new Guid("36952599-e114-e8ba-8823-c7f48969c0ed"), "979 Lamont Mall, Gregghaven, Zambia", new DateTime(2020, 2, 11, 4, 11, 10, 479, DateTimeKind.Local).AddTicks(4738), "Estevan Lueilwitz" },
                    { new Guid("67e69a64-cfcd-b3ba-2526-3025d365e040"), "0693 Derick Mission, South Muriel, Hungary", new DateTime(2020, 4, 28, 14, 57, 25, 245, DateTimeKind.Local).AddTicks(6935), "Kiarra Mills" },
                    { new Guid("5a621eed-01a2-1df3-e643-f1c8a0c59469"), "657 Ivah Motorway, Laurelborough, Uzbekistan", new DateTime(2019, 12, 29, 0, 34, 34, 803, DateTimeKind.Local).AddTicks(2951), "Bruce Grant" },
                    { new Guid("378deffa-03b4-9e85-df26-f5466836d3ba"), "30460 Naomi Pine, Jenkinsstad, Bouvet Island (Bouvetoya)", new DateTime(2019, 12, 18, 8, 27, 20, 146, DateTimeKind.Local).AddTicks(3506), "Ethyl McCullough" },
                    { new Guid("12d8f64a-e08d-f965-7bf5-433e26f1072b"), "82777 Purdy Rue, Jacobiberg, Slovenia", new DateTime(2020, 12, 12, 5, 44, 26, 474, DateTimeKind.Local).AddTicks(5711), "Amos Dooley" },
                    { new Guid("fa3f1e43-5ba7-f749-5e26-608a3159d41d"), "8858 Hane Junction, North Eldridge, Puerto Rico", new DateTime(2020, 10, 20, 15, 53, 27, 108, DateTimeKind.Local).AddTicks(2269), "Selina Raynor" },
                    { new Guid("d3e35d00-30c7-7329-9cb4-2e314497ed5e"), "286 Danial Corner, Kautzertown, Albania", new DateTime(2020, 9, 29, 11, 21, 18, 749, DateTimeKind.Local).AddTicks(6074), "Kirstin McDermott" },
                    { new Guid("8901328e-75d4-5501-001c-0660b347c00d"), "130 Gorczany Bypass, Gerlachborough, Myanmar", new DateTime(2020, 4, 15, 6, 55, 24, 975, DateTimeKind.Local).AddTicks(8803), "Christop Kuhlman" },
                    { new Guid("9f4444ed-43ff-190e-e819-6cf82515e4c6"), "653 Robel Drive, East Vadashire, Sweden", new DateTime(2020, 2, 17, 7, 55, 33, 434, DateTimeKind.Local).AddTicks(9421), "Joshuah Wunsch" },
                    { new Guid("1c19a613-a86e-cac1-11ee-8ebd59dd8c2d"), "64927 Theo Route, Lake Arvidstad, Morocco", new DateTime(2020, 5, 8, 4, 23, 5, 581, DateTimeKind.Local).AddTicks(4631), "Beryl Zemlak" },
                    { new Guid("c7fb7ee4-dd57-15a9-13bd-80c351daf390"), "7937 Stroman Ford, Haneview, Guinea-Bissau", new DateTime(2020, 12, 1, 5, 4, 42, 109, DateTimeKind.Local).AddTicks(395), "Catherine Will" },
                    { new Guid("0ef867fd-0f32-b2c6-92e4-b40c5eff480c"), "98983 Alaina Ways, Garrybury, Bangladesh", new DateTime(2020, 11, 2, 3, 49, 11, 627, DateTimeKind.Local).AddTicks(8520), "Fabiola White" },
                    { new Guid("e2eac67a-5de4-0be7-1c8a-9c97d0dc598b"), "580 Tina Shoals, West Terrillville, Montserrat", new DateTime(2020, 11, 23, 10, 8, 4, 16, DateTimeKind.Local).AddTicks(7068), "Hester McClure" },
                    { new Guid("39e41472-2a5e-97a6-604b-9c17d401cfe4"), "125 Cletus Trail, South Mathildeport, Saint Pierre and Miquelon", new DateTime(2020, 7, 26, 20, 36, 46, 609, DateTimeKind.Local).AddTicks(9597), "Josefa Jenkins" },
                    { new Guid("bc25885e-1ff7-8a2d-10b9-2822b044215e"), "1243 Schmitt Brook, Bogisichborough, Guadeloupe", new DateTime(2020, 10, 11, 15, 2, 1, 694, DateTimeKind.Local).AddTicks(6835), "Callie Keeling" }
                });

            migrationBuilder.InsertData(
                table: "owner",
                columns: new[] { "OwnerId", "Address", "DateOfBirth", "Name" },
                values: new object[,]
                {
                    { new Guid("4cb91682-13dc-f5ed-c9de-9ec690677c25"), "20962 Gerhold Mill, Lake Alysson, Isle of Man", new DateTime(2019, 12, 18, 8, 16, 35, 353, DateTimeKind.Local).AddTicks(8920), "Tanner Stiedemann" },
                    { new Guid("715365a7-6e0e-37ac-b03b-d0e754e7bddf"), "56281 Mills Forest, Beerchester, Ecuador", new DateTime(2020, 3, 10, 18, 27, 47, 800, DateTimeKind.Local).AddTicks(1344), "Virgie Lind" },
                    { new Guid("7e48dc95-528a-d90c-54c9-ad32ebddf658"), "537 Jaskolski Summit, New Elvis, Ukraine", new DateTime(2020, 12, 7, 16, 47, 48, 449, DateTimeKind.Local).AddTicks(8398), "Orpha Howe" },
                    { new Guid("e0dcc9cc-ad21-de55-28f5-3206eab72bc1"), "3516 Beahan Mountains, Hauckburgh, Wallis and Futuna", new DateTime(2020, 9, 21, 10, 49, 20, 425, DateTimeKind.Local).AddTicks(9406), "Bryce Prosacco" },
                    { new Guid("3e094de9-67c2-de3e-2daf-54154866332d"), "8092 Allene Land, Kiehnmouth, Slovakia (Slovak Republic)", new DateTime(2020, 6, 3, 22, 28, 43, 566, DateTimeKind.Local).AddTicks(1892), "Kane Mayer" },
                    { new Guid("9088de3a-575f-637b-3480-f3966b641af9"), "30940 Treutel Points, West Hobartside, Georgia", new DateTime(2020, 7, 15, 4, 5, 18, 630, DateTimeKind.Local).AddTicks(9393), "Emmy Nikolaus" },
                    { new Guid("e223deae-800e-c868-d0d9-e57255606b51"), "2091 Pfannerstill Knoll, Port Gabriellaton, Montserrat", new DateTime(2020, 3, 23, 9, 22, 26, 479, DateTimeKind.Local).AddTicks(2362), "Flavio Bode" },
                    { new Guid("d53cb5a2-05aa-5dd0-71c7-6a49ca270dde"), "6279 Toy Falls, Farrellhaven, Monaco", new DateTime(2020, 7, 18, 2, 51, 46, 775, DateTimeKind.Local).AddTicks(9614), "Brendon Wilderman" },
                    { new Guid("abb224c8-7c2f-3fde-c636-f7d9300f88bb"), "4165 Beahan Station, Ornfurt, Norway", new DateTime(2019, 12, 20, 17, 31, 5, 503, DateTimeKind.Local).AddTicks(287), "Kimberly Bergstrom" },
                    { new Guid("a5815b9a-6275-4aae-2930-777d683313ba"), "18221 Cary Ridge, Sherwoodmouth, Bouvet Island (Bouvetoya)", new DateTime(2020, 2, 11, 1, 13, 25, 881, DateTimeKind.Local).AddTicks(3376), "Ford Tillman" },
                    { new Guid("8ed43f02-45e2-a479-3b72-29671cda74e5"), "02098 Smitham Extensions, West Elishaville, Niue", new DateTime(2020, 5, 21, 18, 33, 41, 422, DateTimeKind.Local).AddTicks(4630), "Vergie Larkin" },
                    { new Guid("2c3ef465-2a24-3f41-bb1f-89816e958e51"), "493 Rhiannon Estates, Leschstad, Georgia", new DateTime(2020, 1, 9, 20, 41, 35, 285, DateTimeKind.Local).AddTicks(634), "Logan Hilpert" },
                    { new Guid("74ae7c5e-a680-ee24-3d3c-0342e81e16ac"), "279 Dickens Stravenue, West Keon, Bahrain", new DateTime(2020, 7, 15, 19, 58, 27, 120, DateTimeKind.Local).AddTicks(3961), "Adrienne Hilpert" },
                    { new Guid("2b135911-bf05-0d21-abfb-c1bfd2cac24e"), "948 Enrique Mountain, Terrellchester, Tunisia", new DateTime(2020, 9, 20, 20, 27, 27, 681, DateTimeKind.Local).AddTicks(8414), "Dion Mraz" },
                    { new Guid("f1145391-d5e9-11f2-ec4d-c279bef30f09"), "24508 Ritchie Drive, North Giovanna, Cayman Islands", new DateTime(2020, 5, 6, 12, 40, 38, 610, DateTimeKind.Local).AddTicks(684), "Adella Heidenreich" },
                    { new Guid("bd6b300c-d9d8-1b79-ce2d-84878ee96481"), "568 Kuhic Fort, Gerholdtown, Norway", new DateTime(2020, 2, 9, 19, 3, 13, 102, DateTimeKind.Local).AddTicks(7276), "Jeffery Metz" },
                    { new Guid("b1627840-a3c2-fd4b-c5f4-e8881493557a"), "835 Reginald Lakes, Waelchitown, Falkland Islands (Malvinas)", new DateTime(2020, 7, 21, 0, 43, 53, 967, DateTimeKind.Local).AddTicks(8579), "Piper Collier" },
                    { new Guid("43f221c3-2c0f-a237-dd4b-3bb061a60f39"), "349 Lily Road, New Precious, Rwanda", new DateTime(2020, 2, 21, 15, 7, 56, 138, DateTimeKind.Local).AddTicks(8843), "Laurine Boyer" },
                    { new Guid("81b7bdfc-e2c6-fd9b-a14d-c027fb080026"), "94667 Schumm Loaf, South Nellabury, Sierra Leone", new DateTime(2020, 3, 14, 10, 18, 55, 689, DateTimeKind.Local).AddTicks(8503), "Rita King" },
                    { new Guid("2594250c-2266-4650-4e8f-b33b813ce792"), "27163 Block Greens, North Brown, Russian Federation", new DateTime(2020, 11, 14, 20, 37, 9, 520, DateTimeKind.Local).AddTicks(5999), "Xavier Bernhard" },
                    { new Guid("fbd1f093-5c0d-5fc6-bd92-3007654b8a81"), "6935 Luettgen Avenue, Pourosmouth, Rwanda", new DateTime(2020, 3, 6, 0, 24, 47, 280, DateTimeKind.Local).AddTicks(3083), "Lilla Goldner" },
                    { new Guid("1f4f22e1-6331-6478-2a99-19a4ba1a22ab"), "389 Chadrick Mews, East Mckenna, Nigeria", new DateTime(2020, 2, 5, 11, 29, 30, 384, DateTimeKind.Local).AddTicks(4743), "Sid Beatty" },
                    { new Guid("268d6f38-fc43-506b-802f-7570bf0be7c3"), "496 Ullrich Wells, Schneiderstad, United States of America", new DateTime(2020, 4, 6, 13, 25, 10, 708, DateTimeKind.Local).AddTicks(6660), "Simone Aufderhar" },
                    { new Guid("e01a369c-2c34-def3-af03-cec01c64b0e4"), "2755 Josiane Rest, Walshbury, France", new DateTime(2020, 5, 8, 22, 36, 42, 582, DateTimeKind.Local).AddTicks(7140), "Berneice Gerhold" },
                    { new Guid("39d81cb4-2aa4-97b2-56a6-3a60f283ba63"), "4069 Leuschke Mountains, East Julienside, Saint Martin", new DateTime(2020, 6, 14, 18, 50, 22, 70, DateTimeKind.Local).AddTicks(4643), "Vivienne Franecki" },
                    { new Guid("8bff0b5d-4076-ca39-f7f6-3aa42fca71dd"), "123 Bauch Tunnel, Kristianmouth, Ukraine", new DateTime(2020, 11, 21, 8, 14, 49, 843, DateTimeKind.Local).AddTicks(948), "Kira Schneider" },
                    { new Guid("950ca78c-bb77-9ad8-5a42-735787f61977"), "7294 Fritsch Cape, West Jarvis, Andorra", new DateTime(2020, 1, 3, 21, 56, 57, 64, DateTimeKind.Local).AddTicks(4956), "Dameon Schamberger" },
                    { new Guid("fdae2dc7-3422-22f9-89ba-d05effcaaef4"), "929 Edna Hills, Lake Lukas, New Zealand", new DateTime(2020, 11, 29, 6, 42, 19, 68, DateTimeKind.Local).AddTicks(818), "Ethyl Satterfield" },
                    { new Guid("8fbf4760-4759-541c-5e81-9b7c7e1e93e1"), "76470 Bogisich Flat, Mitchellmouth, Costa Rica", new DateTime(2020, 2, 25, 3, 55, 51, 306, DateTimeKind.Local).AddTicks(2911), "Sallie Schimmel" },
                    { new Guid("40176f04-543a-e3ac-c655-42bcae127e21"), "830 Joy Pike, Anikafurt, Saint Kitts and Nevis", new DateTime(2020, 3, 30, 11, 7, 32, 901, DateTimeKind.Local).AddTicks(3334), "Rod Kihn" },
                    { new Guid("79591f29-7bae-36a0-d372-8d03f1f49eef"), "38261 Kiley Island, Malliemouth, United States Minor Outlying Islands", new DateTime(2020, 8, 15, 6, 19, 52, 787, DateTimeKind.Local).AddTicks(3569), "Eudora Kutch" },
                    { new Guid("549d18d1-cf98-aaa5-b3a6-1367e9291bc4"), "9096 Lowe Fort, West Natashaside, Ecuador", new DateTime(2020, 5, 13, 6, 26, 55, 549, DateTimeKind.Local).AddTicks(9977), "Judge Ebert" },
                    { new Guid("01dc1f9b-f39a-80c4-013d-37e1c52e2bec"), "25527 Paucek Stravenue, Wernerview, Liechtenstein", new DateTime(2020, 5, 7, 0, 38, 19, 708, DateTimeKind.Local).AddTicks(8343), "Okey Yost" },
                    { new Guid("cc8b2f85-a881-5716-9b1e-e210035e86c0"), "767 Yasmin Alley, North Milo, Romania", new DateTime(2020, 8, 5, 10, 3, 56, 843, DateTimeKind.Local).AddTicks(1060), "Sven Gorczany" },
                    { new Guid("766471a6-e3ce-81e5-1b50-58d52cb89e31"), "5969 Talia Creek, Thielhaven, Nauru", new DateTime(2020, 4, 19, 21, 18, 0, 828, DateTimeKind.Local).AddTicks(588), "Dax Emmerich" },
                    { new Guid("2cd8bd94-2552-c795-96be-6315f4a7309a"), "78470 Farrell Ports, West Sebastianberg, Netherlands Antilles", new DateTime(2020, 1, 11, 6, 27, 35, 884, DateTimeKind.Local).AddTicks(8780), "Raphael Kerluke" },
                    { new Guid("71e06e40-f6df-89fc-a894-cc9362e87486"), "2084 Shanahan Wells, New Dee, Bulgaria", new DateTime(2020, 7, 10, 14, 28, 15, 288, DateTimeKind.Local).AddTicks(8492), "Waldo Kihn" },
                    { new Guid("2c75d2de-c479-d25a-327f-408757824f21"), "414 Lavina Vista, Vandervorthaven, Australia", new DateTime(2020, 1, 18, 5, 1, 28, 451, DateTimeKind.Local).AddTicks(5418), "Garfield Greenfelder" },
                    { new Guid("299c331a-96a3-5ce8-eb0a-3161d606de62"), "719 Huels Path, Emilborough, Belize", new DateTime(2020, 7, 16, 2, 53, 7, 436, DateTimeKind.Local).AddTicks(2318), "Nigel Medhurst" },
                    { new Guid("2669b745-ba54-ab58-8a25-cc658fa43f67"), "32116 Lisandro Club, Torrancetown, Japan", new DateTime(2020, 1, 27, 17, 56, 54, 464, DateTimeKind.Local).AddTicks(8931), "Jasper Kessler" },
                    { new Guid("6caaecfe-8adf-2fa7-e357-3b749a3775fd"), "45901 Boyer Keys, Magdalenfort, Yemen", new DateTime(2020, 11, 13, 14, 31, 22, 686, DateTimeKind.Local).AddTicks(1627), "Jaylen Brown" },
                    { new Guid("95b791b5-9cfa-d5c5-d0dc-54de617f350d"), "88005 Ulices Course, Selinamouth, Palestinian Territory", new DateTime(2020, 1, 1, 4, 58, 8, 190, DateTimeKind.Local).AddTicks(9), "Cruz Feest" }
                });

            migrationBuilder.InsertData(
                table: "owner",
                columns: new[] { "OwnerId", "Address", "DateOfBirth", "Name" },
                values: new object[,]
                {
                    { new Guid("bda6e569-3268-e7d9-476b-7045bf338cb1"), "005 Runte Squares, Mayerburgh, Martinique", new DateTime(2020, 2, 28, 15, 19, 44, 334, DateTimeKind.Local).AddTicks(7086), "Laurie Huels" },
                    { new Guid("f7dce395-8f9a-874f-ae54-575d08400d4d"), "11205 Brendan Rapid, Lake Vicente, Philippines", new DateTime(2020, 9, 1, 14, 31, 44, 598, DateTimeKind.Local).AddTicks(5008), "Patience Leuschke" },
                    { new Guid("e361db5e-f23b-d921-f50c-64a407399f57"), "702 Elvera Lakes, Lake Gissellechester, Togo", new DateTime(2020, 8, 17, 9, 22, 30, 345, DateTimeKind.Local).AddTicks(3747), "Annalise Block" },
                    { new Guid("64aa7a92-6aab-5568-d16d-527e5261fd6a"), "1000 Shanahan Track, Roxaneport, Ecuador", new DateTime(2020, 6, 10, 8, 31, 18, 624, DateTimeKind.Local).AddTicks(465), "Benedict Borer" },
                    { new Guid("8d12216d-3b8e-d0ab-152b-5eaf738cd874"), "63066 Darien Knolls, South Louvenia, Nicaragua", new DateTime(2020, 9, 14, 23, 40, 18, 922, DateTimeKind.Local).AddTicks(1010), "Greyson Borer" },
                    { new Guid("4f311004-db70-55ea-d37c-64361526445d"), "967 Ebert Ranch, O'Haratown, Jamaica", new DateTime(2020, 5, 8, 0, 42, 26, 397, DateTimeKind.Local).AddTicks(2929), "Hilton Carter" },
                    { new Guid("6e24e5d0-a77b-8325-b1b8-a02f904fc79e"), "357 Selena Station, Kaelynshire, Guam", new DateTime(2020, 10, 10, 15, 11, 10, 300, DateTimeKind.Local).AddTicks(7681), "Tristin Ortiz" },
                    { new Guid("9386601f-f151-c9b7-b672-d1bbfa4b1ad0"), "202 Mills Path, Lake Susan, Mongolia", new DateTime(2020, 1, 6, 16, 43, 44, 76, DateTimeKind.Local).AddTicks(6534), "Trycia Cartwright" },
                    { new Guid("817554eb-09cf-76bb-ad33-856251f831ca"), "176 Lauryn Loaf, Helenechester, Trinidad and Tobago", new DateTime(2020, 11, 22, 1, 31, 51, 380, DateTimeKind.Local).AddTicks(6484), "Drake Weissnat" },
                    { new Guid("e588d2fd-8567-4bc9-c663-d68d5fd3bb5c"), "50047 Daugherty Valley, Vanceland, Saint Vincent and the Grenadines", new DateTime(2020, 10, 3, 12, 14, 29, 443, DateTimeKind.Local).AddTicks(4368), "Garland Bartoletti" },
                    { new Guid("c98f872f-c913-8a45-5419-4116d06a1646"), "54728 Friesen Field, Keirabury, Costa Rica", new DateTime(2020, 2, 6, 11, 22, 29, 58, DateTimeKind.Local).AddTicks(6828), "Walter Hermann" },
                    { new Guid("2b4b304c-1f92-0ee9-a6bf-d2fde6bd1f74"), "723 Gerson Station, South Malvinaland, Bulgaria", new DateTime(2019, 12, 17, 10, 3, 11, 564, DateTimeKind.Local).AddTicks(2836), "Elisabeth Ratke" },
                    { new Guid("398484ea-1bca-0ac2-13ce-94313e95a39a"), "798 Kessler Islands, South Beverlyside, Faroe Islands", new DateTime(2020, 10, 26, 21, 3, 56, 184, DateTimeKind.Local).AddTicks(2067), "Pauline Wilkinson" },
                    { new Guid("6113d197-e539-1ea9-067a-fc99710d3866"), "654 Green Fall, North Travischester, Togo", new DateTime(2020, 11, 10, 19, 50, 21, 503, DateTimeKind.Local).AddTicks(3979), "Lera Dach" },
                    { new Guid("6c992f0b-4182-d860-dbf2-5e194a91d3e4"), "668 Kenneth Inlet, North Joaniehaven, Fiji", new DateTime(2020, 1, 28, 14, 59, 15, 306, DateTimeKind.Local).AddTicks(2500), "Katlynn Simonis" },
                    { new Guid("428ee6d4-cb74-59e3-c056-eb3e645357c9"), "40405 West Squares, Jaylenmouth, Bouvet Island (Bouvetoya)", new DateTime(2020, 2, 4, 15, 50, 12, 466, DateTimeKind.Local).AddTicks(7128), "Ludwig Sauer" },
                    { new Guid("036444c6-6f91-e4d0-5e82-7710f5711018"), "8540 Albin Shore, Edwinside, Central African Republic", new DateTime(2020, 5, 10, 13, 19, 6, 447, DateTimeKind.Local).AddTicks(5793), "Shaniya Hyatt" },
                    { new Guid("0f9d7ec4-c6f3-f4d9-883e-58e0cffd0551"), "37159 Moshe Ranch, Camillefurt, French Guiana", new DateTime(2020, 10, 28, 17, 30, 48, 867, DateTimeKind.Local).AddTicks(1930), "Hazle Pouros" },
                    { new Guid("d4764c5c-2401-b777-45d1-d18891ce8142"), "02776 Katherine Terrace, South Jonathon, Lao People's Democratic Republic", new DateTime(2020, 8, 5, 2, 30, 57, 0, DateTimeKind.Local).AddTicks(7127), "Elyssa Goldner" },
                    { new Guid("8eb173b9-f67d-85d3-1dbb-fbdf5d41f601"), "48832 Alysson Springs, Port Cecilville, Malta", new DateTime(2020, 12, 12, 9, 0, 14, 492, DateTimeKind.Local).AddTicks(7557), "Sidney Gutkowski" },
                    { new Guid("b3d05bd7-d5e1-9c05-685f-fcee5bfb3841"), "9589 Jannie Springs, East Anjali, Djibouti", new DateTime(2020, 2, 23, 17, 56, 2, 841, DateTimeKind.Local).AddTicks(4825), "Geovanni Cummings" },
                    { new Guid("9a6aed3a-5431-6a7d-3380-38e257bac0c9"), "16617 Collier Union, West Melvinton, Trinidad and Tobago", new DateTime(2020, 12, 1, 17, 23, 2, 230, DateTimeKind.Local).AddTicks(6344), "Nicola Abbott" },
                    { new Guid("9895c994-2b91-e991-7f6c-948c08760b14"), "64865 Floyd Roads, Lake Yoshiko, Mauritania", new DateTime(2020, 9, 23, 12, 33, 21, 328, DateTimeKind.Local).AddTicks(8591), "Jonathon Witting" },
                    { new Guid("9d916db4-3310-cf58-bf7b-df4f052ba168"), "91309 Vito Common, Schadenchester, South Georgia and the South Sandwich Islands", new DateTime(2020, 3, 22, 3, 40, 4, 780, DateTimeKind.Local).AddTicks(2459), "Micah Connelly" },
                    { new Guid("949c82f4-30a3-6990-535f-c814673ec212"), "36582 Gusikowski Ferry, Manteside, Pakistan", new DateTime(2020, 11, 11, 22, 38, 14, 780, DateTimeKind.Local).AddTicks(7289), "Nyah Steuber" },
                    { new Guid("31b2452f-3f81-468e-3e61-92d53c46a789"), "02051 Jessy Mission, Wiegandview, Western Sahara", new DateTime(2020, 8, 20, 10, 23, 34, 331, DateTimeKind.Local).AddTicks(198), "Kelsi Stracke" },
                    { new Guid("6bba7a63-2ca3-3517-f9c7-94c96baf7ab3"), "982 Tracy Meadows, Edwinafort, Congo", new DateTime(2020, 7, 1, 7, 38, 8, 148, DateTimeKind.Local).AddTicks(2166), "Isaac Bergnaum" },
                    { new Guid("d040a948-f536-530f-0fc2-043e7256421c"), "94743 Frank Coves, East Estelltown, Reunion", new DateTime(2020, 7, 23, 9, 53, 58, 624, DateTimeKind.Local).AddTicks(5645), "Sydnie Wintheiser" },
                    { new Guid("de2a204c-be44-70d2-5a5b-701874a18491"), "596 Manley Brooks, North Terrance, Ukraine", new DateTime(2020, 6, 7, 13, 9, 23, 8, DateTimeKind.Local).AddTicks(2248), "Lysanne Hane" },
                    { new Guid("09bff3c2-f122-9194-7fc8-6861cbfdf31f"), "2763 Stewart Stravenue, Hadleyfort, United States Minor Outlying Islands", new DateTime(2020, 10, 12, 7, 49, 58, 854, DateTimeKind.Local).AddTicks(803), "Kim Homenick" },
                    { new Guid("24ade903-98b5-9f61-6d5f-364cd329b6d4"), "087 Hintz Mission, Mantebury, Liberia", new DateTime(2020, 6, 5, 16, 0, 57, 621, DateTimeKind.Local).AddTicks(9019), "Arvel Walsh" },
                    { new Guid("5e5761f4-50e1-6acf-88be-c349ff55e9a3"), "6370 Angelo Garden, Gerholdburgh, Dominican Republic", new DateTime(2020, 6, 2, 7, 10, 15, 87, DateTimeKind.Local).AddTicks(4333), "Robyn Treutel" },
                    { new Guid("eb416ef3-cb7c-83d4-0118-8a8c385713e1"), "604 Swaniawski Camp, Dietrichchester, Burkina Faso", new DateTime(2020, 7, 17, 13, 49, 45, 776, DateTimeKind.Local).AddTicks(1486), "Marie Jerde" },
                    { new Guid("55bce039-1390-26fd-ca13-ff4906ed90dd"), "90812 Feest Parkways, North Kali, Cambodia", new DateTime(2020, 2, 2, 18, 11, 13, 673, DateTimeKind.Local).AddTicks(3776), "Anastacio Turcotte" },
                    { new Guid("7bab511a-8302-d6ce-7de7-8815e5cb8eb4"), "70193 Mann Street, Arnoldoside, Netherlands Antilles", new DateTime(2020, 3, 3, 14, 59, 11, 402, DateTimeKind.Local).AddTicks(7514), "Roy Prohaska" },
                    { new Guid("e49cebb0-0962-c63e-bb4a-b6badbdfd136"), "40192 Yundt Gardens, Bergstromfort, China", new DateTime(2020, 1, 25, 14, 43, 0, 591, DateTimeKind.Local).AddTicks(6938), "Elyse Mayer" },
                    { new Guid("f2e034be-01d0-0be4-801a-e9e5e3f0b022"), "0832 Vince Springs, South Devynview, British Indian Ocean Territory (Chagos Archipelago)", new DateTime(2019, 12, 23, 1, 4, 4, 113, DateTimeKind.Local).AddTicks(6098), "Brenda Howe" },
                    { new Guid("f0ab1c7c-2043-fdd6-72e2-a8fccf2abec1"), "73711 Lakin Village, Yasmeenside, United Kingdom", new DateTime(2020, 6, 15, 0, 32, 9, 655, DateTimeKind.Local).AddTicks(6529), "Effie Rowe" },
                    { new Guid("04d4671c-d432-3d45-1959-11450817abf4"), "362 Haley Ramp, Mertztown, Wallis and Futuna", new DateTime(2020, 3, 26, 2, 26, 50, 526, DateTimeKind.Local).AddTicks(3760), "Floyd Gerhold" },
                    { new Guid("b3cbcaa8-e9c2-39bc-93d3-41bb17b901d2"), "63813 Jenkins Expressway, Lake Abelardoborough, Switzerland", new DateTime(2020, 1, 2, 17, 27, 36, 944, DateTimeKind.Local).AddTicks(6733), "Milton Durgan" },
                    { new Guid("633d7a68-0be9-0919-4b50-f637f2976342"), "4707 Hammes Manors, Lake Frederique, Belarus", new DateTime(2020, 5, 11, 7, 46, 51, 848, DateTimeKind.Local).AddTicks(5372), "Amber Howell" },
                    { new Guid("8751d452-9095-4e65-5c0f-106901f169eb"), "2982 Emard Ville, West Elisaport, Uzbekistan", new DateTime(2020, 5, 12, 15, 22, 38, 53, DateTimeKind.Local).AddTicks(1247), "Elena Schiller" }
                });

            migrationBuilder.InsertData(
                table: "owner",
                columns: new[] { "OwnerId", "Address", "DateOfBirth", "Name" },
                values: new object[,]
                {
                    { new Guid("461de46a-acdb-73b2-e0dd-ee3da6d097fc"), "9707 Alycia Shoal, Vivianfort, Haiti", new DateTime(2020, 1, 23, 7, 23, 10, 895, DateTimeKind.Local).AddTicks(2995), "Hallie Beier" },
                    { new Guid("0d97ccbb-a44c-2e61-a7d3-a55056dec39a"), "27098 Herman Creek, Runteborough, Tajikistan", new DateTime(2020, 5, 9, 17, 41, 52, 423, DateTimeKind.Local).AddTicks(1729), "Hilario Bogisich" },
                    { new Guid("39da82cb-af8a-7dd6-13f5-9a60d439575a"), "835 Giovanna Springs, Lake Hollieland, Philippines", new DateTime(2019, 12, 29, 0, 37, 57, 295, DateTimeKind.Local).AddTicks(4315), "Leonard Borer" },
                    { new Guid("5b8ad16e-61e9-d7b7-52a0-96c39404eb54"), "232 Vanessa Lodge, Shyannside, Angola", new DateTime(2020, 8, 25, 7, 38, 15, 890, DateTimeKind.Local).AddTicks(8368), "Christine Spinka" },
                    { new Guid("f1584967-ae02-71fb-2fbc-832ea0e13f08"), "4013 Schimmel Burg, Obieborough, Belgium", new DateTime(2020, 10, 7, 1, 21, 37, 88, DateTimeKind.Local).AddTicks(919), "Elvie Gorczany" },
                    { new Guid("792ec50f-123c-a5e8-bdf3-c1cbb2879c71"), "0461 Javonte Road, Jammieberg, Falkland Islands (Malvinas)", new DateTime(2020, 10, 22, 22, 12, 3, 811, DateTimeKind.Local).AddTicks(5482), "Oliver Jacobson" },
                    { new Guid("db1f9e41-c5b3-1ccc-79c3-1d49f8585831"), "6463 Kozey Street, New Nedland, Burundi", new DateTime(2020, 6, 9, 23, 14, 35, 897, DateTimeKind.Local).AddTicks(675), "Ezequiel Weber" },
                    { new Guid("67148aed-bec1-677a-b960-c44b53b4ccf3"), "7094 Doyle Park, Port Rebekah, Bhutan", new DateTime(2020, 2, 12, 15, 16, 53, 72, DateTimeKind.Local).AddTicks(1286), "Elmore Hauck" },
                    { new Guid("cd0b1a7f-ca44-0735-2212-ca3f985bd3cd"), "4934 Rice Pine, Port Lilian, Haiti", new DateTime(2020, 10, 30, 11, 26, 52, 202, DateTimeKind.Local).AddTicks(7561), "Jacey Dare" },
                    { new Guid("39cc2e60-fea8-3baf-41a9-5f388460a91d"), "368 Maryam Ford, Gottliebhaven, Libyan Arab Jamahiriya", new DateTime(2020, 4, 18, 7, 28, 16, 142, DateTimeKind.Local).AddTicks(2142), "Gillian Rutherford" },
                    { new Guid("df52861a-8f69-2499-884c-98c1d2bcab1a"), "69399 Maryam Parkways, Ankundingshire, Belgium", new DateTime(2020, 1, 24, 16, 18, 14, 823, DateTimeKind.Local).AddTicks(8792), "Beryl Boyer" },
                    { new Guid("f976a3a8-07e8-42e9-e6ea-bd183526cec1"), "821 Irving Square, Phoebeport, Liberia", new DateTime(2020, 1, 5, 22, 31, 7, 698, DateTimeKind.Local).AddTicks(8629), "Vickie Hilpert" },
                    { new Guid("385306ff-e320-e16d-4bf3-f7dfda6ea2de"), "1056 Schmidt Isle, South Rashawnview, Western Sahara", new DateTime(2020, 3, 20, 19, 20, 19, 885, DateTimeKind.Local).AddTicks(3536), "Estefania Powlowski" },
                    { new Guid("4d250520-ff30-e878-8f3d-9383cb964fe3"), "62153 Angelo Run, Port Aliyaport, Dominica", new DateTime(2020, 2, 21, 20, 44, 22, 786, DateTimeKind.Local).AddTicks(3625), "Jeanne Marks" },
                    { new Guid("907d68ba-090a-3478-b291-9a6e1a9503ca"), "473 Ewell Common, Lake Bettiechester, Grenada", new DateTime(2020, 5, 23, 0, 20, 16, 540, DateTimeKind.Local).AddTicks(3434), "Alphonso Frami" },
                    { new Guid("780b0252-3e7a-f2d0-ba57-f46e75abc0a8"), "0509 Kaleigh Islands, Dayneborough, Haiti", new DateTime(2020, 12, 8, 8, 6, 16, 211, DateTimeKind.Local).AddTicks(6959), "Blake Dach" },
                    { new Guid("33afc1a4-dbea-d696-3a2a-9611a7700eab"), "703 Britney Tunnel, Kautzerborough, Sudan", new DateTime(2020, 5, 22, 7, 26, 57, 62, DateTimeKind.Local).AddTicks(4832), "Jaylin Bayer" },
                    { new Guid("cab612a6-fcb3-be8d-fd38-d53ba3253282"), "73895 Jaylon Orchard, Hoegerfort, Oman", new DateTime(2020, 7, 13, 17, 45, 33, 454, DateTimeKind.Local).AddTicks(3939), "Martine Wiegand" },
                    { new Guid("f1ffef4e-5aa6-96af-2295-488fc5dc718c"), "59092 Hills Field, Cristobalmouth, Bolivia", new DateTime(2020, 10, 7, 2, 38, 46, 481, DateTimeKind.Local).AddTicks(8165), "Casandra Cole" },
                    { new Guid("3236557a-2791-0c3c-9c12-e97a49dd65a7"), "1614 Melissa Springs, West Lorna, New Caledonia", new DateTime(2020, 7, 21, 0, 28, 0, 803, DateTimeKind.Local).AddTicks(1997), "Kellen Schuppe" },
                    { new Guid("864ab9d0-5a3b-44ce-010d-a9953dd39449"), "1802 Niko Roads, Lake Gersonville, Congo", new DateTime(2020, 3, 29, 19, 16, 4, 328, DateTimeKind.Local).AddTicks(9455), "D'angelo Kuhlman" },
                    { new Guid("9290a9b0-6cdf-db8d-f080-d7cf118adc7e"), "5779 Bennie Bypass, Abshireberg, Hong Kong", new DateTime(2020, 6, 11, 9, 12, 19, 497, DateTimeKind.Local).AddTicks(2225), "Shanny Bogan" },
                    { new Guid("2a8df08a-b604-ce2d-a32f-377518319de3"), "08483 Mafalda Mall, Nolanfort, Bahamas", new DateTime(2020, 10, 11, 17, 56, 42, 451, DateTimeKind.Local).AddTicks(6799), "Kaleigh Mertz" },
                    { new Guid("fc21450a-79b2-ae7e-c2a8-32db65af183a"), "8522 Craig Brook, Lake Traceshire, Slovakia (Slovak Republic)", new DateTime(2020, 1, 6, 2, 30, 35, 643, DateTimeKind.Local).AddTicks(7138), "Elisha Greenfelder" },
                    { new Guid("7bec0ea2-f2e6-f285-c9ed-290fc2681730"), "1544 Bogan Circle, Novellaberg, Comoros", new DateTime(2020, 1, 6, 4, 30, 2, 416, DateTimeKind.Local).AddTicks(4468), "Lina Labadie" },
                    { new Guid("a0c3f78e-bf2c-3f02-ca38-6b318e9e2cf2"), "9500 Keeling Fork, South Ferne, Cocos (Keeling) Islands", new DateTime(2020, 11, 23, 14, 41, 21, 498, DateTimeKind.Local).AddTicks(7178), "Florencio Morissette" },
                    { new Guid("cb816e59-76a5-0d04-b343-70ef32bbfed5"), "39930 Nyasia Harbor, East Violetville, Dominica", new DateTime(2020, 3, 25, 8, 27, 19, 510, DateTimeKind.Local).AddTicks(7327), "Robb Corwin" },
                    { new Guid("601c1fd7-ae4d-4b39-c426-f7ccd1676032"), "68253 DuBuque Meadow, New Wanda, Nicaragua", new DateTime(2020, 12, 8, 12, 0, 50, 871, DateTimeKind.Local).AddTicks(3176), "Jessica Gutkowski" },
                    { new Guid("b8dfe306-1880-9968-e456-292e6dee166c"), "939 Philip Track, Waelchiside, Colombia", new DateTime(2020, 3, 2, 8, 12, 37, 53, DateTimeKind.Local).AddTicks(4666), "Malcolm Rippin" },
                    { new Guid("cb330786-8083-7879-1ec9-752be8f42b22"), "870 Hackett Port, East Aubrey, Bosnia and Herzegovina", new DateTime(2020, 3, 4, 15, 27, 57, 718, DateTimeKind.Local).AddTicks(2482), "Vena Ratke" },
                    { new Guid("a21cef98-3926-9323-eb0a-b84f85d2f0ae"), "843 Foster Lights, East Julioport, New Zealand", new DateTime(2020, 7, 30, 13, 41, 17, 568, DateTimeKind.Local).AddTicks(8672), "Brandi McClure" },
                    { new Guid("3cdd166e-51cc-e904-d34e-dec6a1e21b7f"), "6864 Carlo Parkway, Norbertshire, Palau", new DateTime(2020, 7, 13, 7, 45, 57, 344, DateTimeKind.Local).AddTicks(3404), "Gilberto Conroy" },
                    { new Guid("6ee1ef87-b4f4-bae2-91c3-9d85585c3e71"), "0141 Adonis Garden, Klockoview, Equatorial Guinea", new DateTime(2020, 3, 14, 19, 15, 39, 780, DateTimeKind.Local).AddTicks(1828), "Camden Kautzer" },
                    { new Guid("b13f95f2-ac01-468a-ba18-ce3fa158076f"), "1616 Elda Estate, Calliechester, Portugal", new DateTime(2020, 10, 5, 14, 5, 51, 469, DateTimeKind.Local).AddTicks(3826), "Kay Aufderhar" },
                    { new Guid("c3920c32-8c1c-9f6f-d79f-dfb856868ddf"), "5051 Theresia Ports, Oceaneburgh, Turkey", new DateTime(2020, 1, 18, 16, 52, 9, 908, DateTimeKind.Local).AddTicks(8203), "Katheryn Schinner" },
                    { new Guid("950c8161-44c6-7252-6dd3-1dbde1c10da4"), "7835 Goyette Dam, North Coleshire, Honduras", new DateTime(2020, 1, 21, 13, 53, 5, 205, DateTimeKind.Local).AddTicks(8561), "Arvilla Hegmann" },
                    { new Guid("79d45677-19f7-ae30-1eb9-fe7e764f5bcf"), "66668 Hoeger Club, North Annette, New Caledonia", new DateTime(2020, 8, 28, 11, 8, 45, 953, DateTimeKind.Local).AddTicks(2073), "Meghan Kohler" },
                    { new Guid("386a691f-2d2a-d33e-95a2-d77b1862114c"), "7500 Ethelyn Lodge, Ethanfort, Taiwan", new DateTime(2020, 11, 8, 20, 36, 9, 799, DateTimeKind.Local).AddTicks(9636), "Rickey Kautzer" },
                    { new Guid("e6562554-96f0-fdb7-e03a-2903f98b5d5a"), "025 Angeline Flat, New Hettie, Kuwait", new DateTime(2020, 7, 7, 17, 45, 43, 496, DateTimeKind.Local).AddTicks(6377), "Erik Hand" },
                    { new Guid("266bf0f9-0bf2-5b2b-da6a-f82b7cb5cd8b"), "77790 Destini Extension, Port Domingo, Montenegro", new DateTime(2020, 1, 30, 3, 20, 54, 766, DateTimeKind.Local).AddTicks(66), "Lizeth Wyman" },
                    { new Guid("8e1330fa-6a64-284e-f4c7-e05e72248aca"), "4228 Henriette Club, Aliyaport, Japan", new DateTime(2020, 9, 29, 7, 29, 45, 924, DateTimeKind.Local).AddTicks(281), "Pablo Schowalter" },
                    { new Guid("8582d4ee-fcba-3cdb-9239-4e3386b64360"), "69676 Anderson Ramp, Brandiberg, Belarus", new DateTime(2020, 4, 4, 14, 14, 27, 550, DateTimeKind.Local).AddTicks(3858), "Polly Jaskolski" }
                });

            migrationBuilder.InsertData(
                table: "owner",
                columns: new[] { "OwnerId", "Address", "DateOfBirth", "Name" },
                values: new object[,]
                {
                    { new Guid("3abf281e-809f-4f96-1b10-0135f5531014"), "726 Marjorie Radial, Ziemannville, Qatar", new DateTime(2020, 8, 19, 19, 53, 23, 886, DateTimeKind.Local).AddTicks(8221), "Merlin Larkin" },
                    { new Guid("309927db-f7d1-5d3a-aed1-96a3fd0b923a"), "781 Ruecker Island, Port Leland, Canada", new DateTime(2020, 6, 20, 19, 25, 34, 557, DateTimeKind.Local).AddTicks(5385), "Rowan Thompson" },
                    { new Guid("9c96d293-0296-87a6-32c5-15c71ac72012"), "014 Rosanna Forges, Florencefurt, Guadeloupe", new DateTime(2020, 5, 28, 23, 4, 49, 681, DateTimeKind.Local).AddTicks(3083), "Fiona Schimmel" },
                    { new Guid("de0a37d5-440b-d905-13b6-8eb0c4a38dd6"), "5303 Chaya Estates, North Lilyborough, Antarctica (the territory South of 60 deg S)", new DateTime(2020, 1, 10, 16, 49, 0, 927, DateTimeKind.Local).AddTicks(5903), "Stanton Hermiston" },
                    { new Guid("e6dc04d4-8e65-f980-ca76-399f3ef2375d"), "733 Giovanni Knoll, Loweshire, Mauritania", new DateTime(2020, 11, 3, 3, 22, 37, 915, DateTimeKind.Local).AddTicks(3331), "Nayeli Block" },
                    { new Guid("994697aa-b916-641c-acfc-b93af8fb350e"), "42182 Norwood Neck, Boyleland, Bangladesh", new DateTime(2020, 10, 13, 13, 33, 50, 899, DateTimeKind.Local).AddTicks(1879), "Norris Torp" },
                    { new Guid("f7088e69-2159-70a4-919f-c9d370608a5d"), "5349 Ariel Manor, New Alfonzo, Albania", new DateTime(2020, 7, 20, 3, 30, 32, 715, DateTimeKind.Local).AddTicks(8436), "Dean Block" },
                    { new Guid("6c8e00bd-162d-85a0-09e8-a01c6bf2b94c"), "93728 Jasen Road, Port Breana, Christmas Island", new DateTime(2020, 2, 9, 11, 19, 15, 362, DateTimeKind.Local).AddTicks(3663), "Emanuel Pacocha" },
                    { new Guid("d16f1620-301e-090c-0044-5039d0f78db5"), "2498 Walker Shoals, New Boyd, United Arab Emirates", new DateTime(2020, 10, 16, 3, 8, 8, 191, DateTimeKind.Local).AddTicks(1967), "Reymundo Collier" },
                    { new Guid("db4a3e40-7a4a-c5ae-0337-ce68b056d0ae"), "980 Mossie Throughway, North Darryl, Eritrea", new DateTime(2019, 12, 23, 12, 25, 20, 533, DateTimeKind.Local).AddTicks(8870), "Halle Jacobs" },
                    { new Guid("f80f7c31-ac92-6ab1-a3e7-0e1c480ba64f"), "092 Juliet Cliffs, Angelinamouth, Virgin Islands, U.S.", new DateTime(2020, 11, 28, 22, 59, 36, 691, DateTimeKind.Local).AddTicks(8147), "Oren Cummings" },
                    { new Guid("9ce4961d-a1ec-3e5e-0137-c9f6c3c42316"), "7469 Tillman Glen, Earlberg, Senegal", new DateTime(2020, 9, 6, 17, 9, 41, 49, DateTimeKind.Local).AddTicks(7138), "Fernando Weissnat" },
                    { new Guid("85f18cfc-6f64-aeba-49bb-d77eb83e58a9"), "43684 Gust Circles, Elishatown, Kiribati", new DateTime(2020, 3, 7, 6, 29, 32, 514, DateTimeKind.Local).AddTicks(1657), "Marquise Von" },
                    { new Guid("d336f93a-b29d-a5cc-71e1-9df73818bf08"), "85443 Bradtke Coves, New Jacinto, Sao Tome and Principe", new DateTime(2020, 10, 4, 13, 16, 34, 132, DateTimeKind.Local).AddTicks(789), "Marian Bartoletti" },
                    { new Guid("21447e23-40d5-fc16-d04a-996457a6fbdf"), "412 Bell Falls, Rippinfort, Northern Mariana Islands", new DateTime(2020, 5, 7, 21, 38, 6, 881, DateTimeKind.Local).AddTicks(6173), "Vinnie Torp" },
                    { new Guid("15786cfe-7a99-22e7-d9d3-e59788e7254b"), "7514 Denesik Corner, West Haylietown, Congo", new DateTime(2020, 7, 31, 18, 41, 50, 739, DateTimeKind.Local).AddTicks(5564), "Vesta Streich" },
                    { new Guid("dff89b87-6191-9b65-e672-cd925bdf9086"), "2266 Shanel Drives, Diegomouth, French Guiana", new DateTime(2020, 5, 6, 4, 26, 56, 336, DateTimeKind.Local).AddTicks(8589), "Vicky Weissnat" },
                    { new Guid("9636d3e2-e517-b02a-6eee-2333b0b07af7"), "9036 Joseph Plaza, Gerryland, Sierra Leone", new DateTime(2020, 11, 26, 17, 35, 13, 272, DateTimeKind.Local).AddTicks(9911), "Susan Kreiger" },
                    { new Guid("4c003de4-6c2d-f36e-8a10-bd24c375d538"), "4039 Reanna Drive, Brennanshire, Iran", new DateTime(2020, 12, 5, 2, 48, 58, 983, DateTimeKind.Local).AddTicks(7160), "Josie Runte" },
                    { new Guid("c7144254-59b6-95f6-44ca-8e74d807f103"), "951 Padberg Loaf, Hirtheside, United Arab Emirates", new DateTime(2020, 10, 8, 21, 35, 6, 372, DateTimeKind.Local).AddTicks(6691), "Bradford Wolff" },
                    { new Guid("0cd1ad05-0400-5833-f07b-ed7a73e87bd3"), "429 Gudrun Brooks, Cliffordmouth, South Georgia and the South Sandwich Islands", new DateTime(2020, 6, 4, 5, 10, 21, 952, DateTimeKind.Local).AddTicks(7565), "Ollie Reinger" },
                    { new Guid("8804c74d-07c6-f1fb-fe41-44a3cab82e30"), "04857 Abernathy Canyon, North Shanietown, Vietnam", new DateTime(2020, 3, 6, 23, 39, 11, 442, DateTimeKind.Local).AddTicks(7580), "Salvatore Schamberger" },
                    { new Guid("5f6fb39f-cbb5-3595-0f47-e0dbc2897c6d"), "9050 Turcotte Lodge, Boscoburgh, Central African Republic", new DateTime(2020, 10, 2, 14, 59, 46, 578, DateTimeKind.Local).AddTicks(8463), "Meda Jaskolski" },
                    { new Guid("7b1819c6-f0c1-d38c-1fd0-2aacc0aa5e06"), "8965 Erich Turnpike, MacGyverport, France", new DateTime(2020, 9, 22, 4, 35, 11, 792, DateTimeKind.Local).AddTicks(2874), "Eileen Cormier" },
                    { new Guid("a814b02f-0170-9cab-3cd2-3ef4e927a257"), "476 Pouros Dam, New Lynn, Israel", new DateTime(2020, 5, 27, 21, 47, 11, 171, DateTimeKind.Local).AddTicks(5415), "Eden Purdy" },
                    { new Guid("7cf12925-950f-95b5-e349-fe249b3ff7a2"), "3954 Abernathy Inlet, North Magdalenville, South Africa", new DateTime(2020, 4, 24, 20, 37, 51, 895, DateTimeKind.Local).AddTicks(7456), "Marc Swift" },
                    { new Guid("f8ca1953-93aa-91c1-dcd3-503b93260836"), "6959 Powlowski Lodge, West Leonor, Malawi", new DateTime(2020, 11, 7, 23, 42, 14, 832, DateTimeKind.Local).AddTicks(2989), "Connie Ryan" },
                    { new Guid("264764f5-aa2c-d60d-4436-0570bbc2e4c7"), "670 Jennings Streets, East Destiny, United Kingdom", new DateTime(2020, 5, 4, 2, 30, 24, 196, DateTimeKind.Local).AddTicks(6246), "London Maggio" },
                    { new Guid("46fe552a-df2e-09e2-3fd4-74477d977061"), "669 Rodriguez Port, New Lailatown, Poland", new DateTime(2020, 7, 31, 21, 11, 52, 597, DateTimeKind.Local).AddTicks(4971), "Kamryn Shields" },
                    { new Guid("1adbdf4c-7bbd-e8b6-e13a-b9ae38368e1d"), "6182 Christiansen Trail, Sashafort, French Southern Territories", new DateTime(2020, 1, 11, 6, 55, 58, 91, DateTimeKind.Local).AddTicks(6455), "Alene Connelly" },
                    { new Guid("9dfa0f6d-55bc-b5a4-6970-24bbfd4c6d41"), "8278 Erika Neck, East Leland, Mayotte", new DateTime(2020, 7, 22, 5, 36, 58, 611, DateTimeKind.Local).AddTicks(2292), "Cassie Kub" },
                    { new Guid("28401fb0-f03b-7161-a61f-1ca7cda6740e"), "8257 Russel Plaza, Theodorabury, Saint Martin", new DateTime(2020, 12, 3, 9, 31, 43, 648, DateTimeKind.Local).AddTicks(5915), "Kiara Rempel" },
                    { new Guid("1eadaee2-44de-7958-8819-80b8604219fa"), "9032 Rebekah Loop, North Armaniside, Saudi Arabia", new DateTime(2020, 8, 1, 4, 37, 2, 648, DateTimeKind.Local).AddTicks(234), "Lia McLaughlin" },
                    { new Guid("d7557b04-cb57-923e-f29b-9c3ed9c32f1b"), "013 Stanton Canyon, Carleyhaven, Faroe Islands", new DateTime(2020, 3, 9, 2, 51, 0, 944, DateTimeKind.Local).AddTicks(3350), "Rudolph Pouros" },
                    { new Guid("8c15b076-02a4-ec05-d3cf-984d9b933b02"), "3927 Mable Viaduct, East Vladimirland, Guyana", new DateTime(2020, 1, 27, 23, 13, 5, 766, DateTimeKind.Local).AddTicks(4322), "Lila VonRueden" },
                    { new Guid("5df790b9-accc-3484-29ac-5c0ef206ede4"), "77346 Herzog Mountain, South Lynn, Guatemala", new DateTime(2020, 9, 22, 10, 54, 15, 0, DateTimeKind.Local).AddTicks(4917), "Malinda Thompson" },
                    { new Guid("a928de8b-b8d7-a042-f40e-51f527c49a19"), "9196 Trevor Curve, South Beauport, Maldives", new DateTime(2020, 10, 8, 20, 6, 28, 156, DateTimeKind.Local).AddTicks(2132), "Alfred Bernhard" },
                    { new Guid("5f5c553f-f0aa-8289-e52a-f7c0a03241c2"), "233 O'Hara Wells, Kylehaven, Pakistan", new DateTime(2020, 7, 27, 23, 51, 22, 992, DateTimeKind.Local).AddTicks(1897), "Veda Nitzsche" },
                    { new Guid("e8659639-3d6e-dab9-9be4-cc04af85eb00"), "2656 Marie Prairie, Franceschester, Suriname", new DateTime(2020, 9, 24, 11, 46, 41, 458, DateTimeKind.Local).AddTicks(3668), "Emelie Hudson" },
                    { new Guid("29bdc6c3-4a3a-85d2-8346-2b04e00e02db"), "32690 Arno Valley, Amelieshire, Zambia", new DateTime(2020, 8, 12, 13, 1, 22, 497, DateTimeKind.Local).AddTicks(9685), "Esther Heidenreich" },
                    { new Guid("c8e940d3-c6c1-e200-72be-2ae2cc011ea1"), "7966 Wiza Landing, South Pattieburgh, Guadeloupe", new DateTime(2020, 10, 26, 7, 32, 27, 888, DateTimeKind.Local).AddTicks(1765), "Derick Fritsch" },
                    { new Guid("18cd0de8-d012-1040-291e-21c849f8819d"), "366 Pfeffer Green, North Ariel, Cote d'Ivoire", new DateTime(2020, 6, 25, 12, 21, 37, 195, DateTimeKind.Local).AddTicks(3019), "Josefa Gutmann" }
                });

            migrationBuilder.InsertData(
                table: "owner",
                columns: new[] { "OwnerId", "Address", "DateOfBirth", "Name" },
                values: new object[,]
                {
                    { new Guid("e4bd1b11-50f4-0d88-815a-759248c10a47"), "56821 Jamaal Key, Port Jasentown, Cook Islands", new DateTime(2020, 6, 9, 8, 25, 13, 178, DateTimeKind.Local).AddTicks(7431), "Finn Sipes" },
                    { new Guid("138cac10-4c8d-13a0-0142-0bce229b0af0"), "99756 Lockman Lakes, Archside, Czech Republic", new DateTime(2020, 12, 2, 3, 12, 22, 157, DateTimeKind.Local).AddTicks(4897), "Aida Grant" },
                    { new Guid("ba5db058-a758-3da3-0e27-2e99b97fd4f8"), "5473 Juston Forge, North Connor, Saint Helena", new DateTime(2020, 5, 11, 6, 8, 18, 921, DateTimeKind.Local).AddTicks(2901), "Johanna Tillman" },
                    { new Guid("eac98a34-35ac-3397-ddbf-fdbf7b7fa3d3"), "95448 Rice Ways, West Daija, Malawi", new DateTime(2020, 1, 23, 3, 49, 22, 409, DateTimeKind.Local).AddTicks(4046), "Arnoldo Donnelly" },
                    { new Guid("b52e6416-4be9-ecb4-213e-91e76986f313"), "48322 Sporer Lake, Dixiemouth, Netherlands Antilles", new DateTime(2020, 3, 27, 22, 36, 11, 598, DateTimeKind.Local).AddTicks(6417), "Brad Gibson" },
                    { new Guid("741a658c-221d-9341-9db3-7c618c1ed453"), "53814 Ethyl Lakes, Zachariahborough, Belgium", new DateTime(2020, 5, 19, 18, 15, 42, 785, DateTimeKind.Local).AddTicks(4519), "Rocky Ebert" },
                    { new Guid("d821dd17-499e-4c3d-05cb-90fd35c9457c"), "8256 Felicita Ranch, North Julianne, Peru", new DateTime(2020, 2, 12, 20, 2, 27, 196, DateTimeKind.Local).AddTicks(6373), "Jacky Padberg" },
                    { new Guid("40756ee4-7ab2-bcf0-9947-8efe41ee6196"), "26865 Lenna Freeway, Hansenbury, Republic of Korea", new DateTime(2020, 10, 14, 1, 1, 34, 150, DateTimeKind.Local).AddTicks(9320), "Angelina McClure" },
                    { new Guid("54c71938-ca04-751f-0336-c1acc351407b"), "9829 Keshawn Lakes, East Marian, Antarctica (the territory South of 60 deg S)", new DateTime(2020, 6, 25, 3, 2, 30, 484, DateTimeKind.Local).AddTicks(4336), "Barney Halvorson" },
                    { new Guid("d408d954-429a-b33c-0c1a-9792282f583d"), "28429 Christiansen Square, East Nettiemouth, Benin", new DateTime(2020, 1, 4, 7, 20, 9, 293, DateTimeKind.Local).AddTicks(9884), "Macie Ritchie" },
                    { new Guid("6b48e958-e4e1-151e-93fc-24885b69cce6"), "61818 Odie Mission, West Lisette, Anguilla", new DateTime(2020, 7, 23, 5, 16, 6, 710, DateTimeKind.Local).AddTicks(7109), "Luis Kirlin" },
                    { new Guid("f56ed7a9-63fc-2780-2505-125774e85112"), "368 Isaias Harbor, Jensenmouth, Portugal", new DateTime(2020, 8, 30, 6, 23, 54, 670, DateTimeKind.Local).AddTicks(4745), "Theron Miller" },
                    { new Guid("b1345f27-5e92-6bf0-884b-8ae0b6b73562"), "3481 Hane Corners, Schimmelfurt, Oman", new DateTime(2019, 12, 21, 22, 22, 9, 926, DateTimeKind.Local).AddTicks(5921), "Juliet Lesch" },
                    { new Guid("f7eb301d-3740-b3bf-cf79-d2bb0197e567"), "062 Hilpert Meadows, Mabelland, Bouvet Island (Bouvetoya)", new DateTime(2020, 10, 8, 15, 4, 29, 333, DateTimeKind.Local).AddTicks(843), "Keith Prohaska" },
                    { new Guid("c32329af-cc86-213d-3776-977e5fa802c6"), "19631 Liliana Road, West Jeromechester, United States of America", new DateTime(2020, 7, 7, 8, 26, 36, 296, DateTimeKind.Local).AddTicks(9779), "John Stiedemann" },
                    { new Guid("d4de9222-9b5f-1049-e4b1-dc3d9d049ea5"), "335 Shaina Groves, Creminmouth, Uruguay", new DateTime(2020, 1, 22, 23, 55, 39, 730, DateTimeKind.Local).AddTicks(5286), "Danny Schiller" },
                    { new Guid("85e966f3-e870-f5c4-4c69-24d749152496"), "37974 Bernier Brook, West Bartholome, Guyana", new DateTime(2020, 3, 19, 21, 18, 24, 616, DateTimeKind.Local).AddTicks(3557), "Joel Howe" },
                    { new Guid("b3d6e9a2-2e7f-21bc-0ddb-99aa1ae51c3c"), "338 Dickens Corners, Rodrigoborough, Singapore", new DateTime(2020, 3, 22, 0, 6, 50, 235, DateTimeKind.Local).AddTicks(8318), "Clair Klein" },
                    { new Guid("a6736007-4e2b-bae2-8971-af56a17afb14"), "94641 Harvey Mountain, West Agustin, Belize", new DateTime(2020, 1, 12, 13, 56, 42, 768, DateTimeKind.Local).AddTicks(8499), "Neal Rippin" },
                    { new Guid("a74a929c-f03e-d9ee-9aa6-acff53d4d847"), "2298 Schiller Mill, Lauriannefort, Togo", new DateTime(2020, 2, 8, 10, 51, 46, 589, DateTimeKind.Local).AddTicks(9362), "Alexandro Zieme" },
                    { new Guid("e70431df-6db1-a040-4877-1e8bf7b6a59f"), "0685 Osinski Expressway, Lottiechester, Solomon Islands", new DateTime(2020, 7, 11, 18, 19, 21, 929, DateTimeKind.Local).AddTicks(4723), "Boris Donnelly" },
                    { new Guid("fcd736be-d516-2736-118a-3be13b8854c7"), "5455 Kiehn Drives, Stevieport, Liechtenstein", new DateTime(2020, 10, 28, 17, 3, 3, 298, DateTimeKind.Local).AddTicks(19), "Lucius Bernhard" },
                    { new Guid("abbd1474-f831-a67e-050f-6b8461e6dfaf"), "37392 Lindgren Shoal, East Lupehaven, Israel", new DateTime(2020, 1, 26, 5, 36, 20, 708, DateTimeKind.Local).AddTicks(6585), "Dewitt Orn" },
                    { new Guid("11710b09-cb0d-32a5-6942-be334b95a748"), "519 Kiehn Trail, Port Myleschester, Saint Lucia", new DateTime(2020, 4, 23, 2, 46, 39, 573, DateTimeKind.Local).AddTicks(8397), "Lavon O'Reilly" },
                    { new Guid("bb5e89bc-c051-2a3d-3fee-2ec7b6a3098c"), "9442 Senger Field, Watersburgh, Guam", new DateTime(2020, 5, 14, 12, 46, 8, 235, DateTimeKind.Local).AddTicks(5950), "Blair Weber" },
                    { new Guid("c166cc30-0ab9-2f7d-b1c2-0ef1aa36aafe"), "1454 Brycen Wall, South Edythe, Aruba", new DateTime(2020, 6, 6, 4, 38, 9, 982, DateTimeKind.Local).AddTicks(1955), "Quinton Altenwerth" },
                    { new Guid("95629afa-b282-89cc-8492-0c20ce46b62c"), "390 Prosacco Gardens, West Myriam, Nigeria", new DateTime(2020, 8, 4, 5, 14, 8, 98, DateTimeKind.Local).AddTicks(9680), "Antonio Krajcik" },
                    { new Guid("f7263e20-d40f-7b15-036f-b79edd1b2395"), "6352 Manuela Islands, Julianashire, Turkey", new DateTime(2020, 12, 12, 10, 37, 37, 43, DateTimeKind.Local).AddTicks(6455), "Viva Orn" },
                    { new Guid("e2eb1aa1-4fa7-58a7-84c5-b259c8d9e3ee"), "452 Gaylord Inlet, North Alfborough, Togo", new DateTime(2020, 7, 16, 13, 47, 52, 16, DateTimeKind.Local).AddTicks(1101), "Vinnie Gorczany" },
                    { new Guid("c3fc29dd-402f-a0ee-218a-7bb229609fa8"), "44441 Davis Lodge, Dooleytown, New Zealand", new DateTime(2020, 10, 14, 16, 57, 4, 842, DateTimeKind.Local).AddTicks(1807), "Cyrus Windler" },
                    { new Guid("dd9e7cd5-bf20-7d25-fa50-8f664c1b241f"), "1056 Spencer Pines, East Yesenia, Cyprus", new DateTime(2020, 10, 27, 16, 55, 34, 714, DateTimeKind.Local).AddTicks(9408), "Gussie Shields" },
                    { new Guid("e453e8fe-cb00-abd5-8196-91cfe558cf8c"), "9541 Bayer Mountain, Hiltonmouth, Puerto Rico", new DateTime(2020, 6, 6, 6, 3, 39, 402, DateTimeKind.Local).AddTicks(8595), "Erin Hamill" },
                    { new Guid("6368e2a0-3fc7-001e-6964-df50bfedd0e4"), "727 Rosina Extension, Heavenbury, French Southern Territories", new DateTime(2020, 7, 12, 5, 58, 44, 473, DateTimeKind.Local).AddTicks(6346), "Jeanie Effertz" },
                    { new Guid("2f5d1e40-f002-c56b-f9a9-0cc7683b93c5"), "02033 Hermann Street, Garnettmouth, Kyrgyz Republic", new DateTime(2020, 5, 26, 8, 37, 49, 400, DateTimeKind.Local).AddTicks(7200), "Ryan Hackett" },
                    { new Guid("62319fef-cdbd-6cf3-36b0-94acb777a872"), "7457 Cora Springs, East Jaydonshire, Saint Helena", new DateTime(2020, 10, 7, 13, 30, 43, 59, DateTimeKind.Local).AddTicks(5973), "Justen Roberts" },
                    { new Guid("619b78ba-1262-c74b-3306-e6a5cd698adb"), "8973 Jones Passage, Randyhaven, Myanmar", new DateTime(2020, 2, 25, 18, 15, 2, 928, DateTimeKind.Local).AddTicks(978), "Elvie Brekke" },
                    { new Guid("fefc75f2-100c-41a6-b2a7-8932c23f16a4"), "5376 Eddie Hollow, South Faustoshire, Grenada", new DateTime(2020, 6, 8, 11, 55, 49, 241, DateTimeKind.Local).AddTicks(9051), "Aubrey Goyette" },
                    { new Guid("6d57b214-ce8c-48db-8357-bec585340d68"), "28128 Jackie Mountain, West Pansy, Sri Lanka", new DateTime(2020, 5, 7, 17, 30, 4, 358, DateTimeKind.Local).AddTicks(5763), "Nick Leuschke" },
                    { new Guid("221fbc3e-f0cf-d396-4d0a-d11f6749c406"), "9872 Jordan View, South Flavie, Micronesia", new DateTime(2020, 2, 23, 23, 5, 49, 280, DateTimeKind.Local).AddTicks(6083), "Michele Schoen" },
                    { new Guid("be8dad95-ea37-45c1-9495-4013a63b6f07"), "9368 Earlene Junctions, Susanton, Kyrgyz Republic", new DateTime(2020, 5, 31, 0, 45, 19, 253, DateTimeKind.Local).AddTicks(5667), "Madyson Rosenbaum" },
                    { new Guid("97bd1cf0-e84b-d186-85bc-129a18393e22"), "86652 Terrell Parks, Clovisbury, Jordan", new DateTime(2020, 2, 10, 10, 24, 41, 747, DateTimeKind.Local).AddTicks(8561), "Sylvan Luettgen" },
                    { new Guid("d3fd32e8-b553-6d0f-7500-4d0d876c17f6"), "83529 Koepp Curve, Casandraside, Thailand", new DateTime(2020, 2, 6, 21, 58, 53, 524, DateTimeKind.Local).AddTicks(603), "Sister Leffler" }
                });

            migrationBuilder.InsertData(
                table: "owner",
                columns: new[] { "OwnerId", "Address", "DateOfBirth", "Name" },
                values: new object[,]
                {
                    { new Guid("41063005-9e4e-5e98-7dca-1fcc2964fe1f"), "634 Theodore Crescent, Dietrichfort, French Guiana", new DateTime(2020, 2, 12, 18, 9, 25, 858, DateTimeKind.Local).AddTicks(9738), "Jon Rath" },
                    { new Guid("82d662f4-103c-9ab5-cab5-8dfc05b0345c"), "75199 Dereck Bypass, West Thurmanfort, Aruba", new DateTime(2020, 6, 22, 13, 29, 19, 897, DateTimeKind.Local).AddTicks(7920), "Sigmund Wilderman" },
                    { new Guid("e2536a2a-0ec2-1b9e-46ce-611e13b2c6f0"), "57886 Derek Spring, Port Josiahfort, Malawi", new DateTime(2020, 4, 14, 13, 42, 53, 890, DateTimeKind.Local).AddTicks(8582), "Bennie Flatley" },
                    { new Guid("6309ca85-8420-6248-b498-e6cc03f17f10"), "953 Michelle Groves, Ethanburgh, Montenegro", new DateTime(2020, 1, 28, 1, 12, 25, 248, DateTimeKind.Local).AddTicks(6295), "Daisha Paucek" },
                    { new Guid("2c976cd4-e7fb-d0ff-4603-624463a8cb21"), "5951 Anderson Roads, West Raphaellemouth, Saint Kitts and Nevis", new DateTime(2020, 10, 5, 9, 42, 36, 623, DateTimeKind.Local).AddTicks(5214), "Skye Bergnaum" },
                    { new Guid("6b5f11bb-84c5-9228-02ef-fc61ed0b1c7f"), "0738 Baumbach Ports, Jeffereyland, Somalia", new DateTime(2020, 7, 20, 14, 2, 19, 682, DateTimeKind.Local).AddTicks(2518), "Malachi Parker" },
                    { new Guid("96a70182-b56c-6bb5-60af-1c67b5566651"), "79312 Demetris Fork, North Coby, Anguilla", new DateTime(2020, 8, 8, 13, 45, 37, 645, DateTimeKind.Local).AddTicks(6547), "Hertha Bauch" },
                    { new Guid("63ebdf12-1285-71c5-d399-7ea115068771"), "0687 Walsh Hollow, Allenestad, Angola", new DateTime(2020, 3, 8, 1, 26, 18, 682, DateTimeKind.Local).AddTicks(5129), "Hope Christiansen" },
                    { new Guid("77a2dc67-ed7a-87a1-414a-064c955c7e9e"), "389 Metz Prairie, East Ceceliaville, Guadeloupe", new DateTime(2020, 3, 27, 22, 54, 11, 656, DateTimeKind.Local).AddTicks(9958), "Cornell Nitzsche" },
                    { new Guid("39397bbe-1063-5ff6-dac5-035c0a4f574d"), "0848 Beatty Bridge, Johnsonburgh, Vanuatu", new DateTime(2020, 4, 10, 18, 57, 15, 955, DateTimeKind.Local).AddTicks(1524), "Melody Kautzer" },
                    { new Guid("1a8eb9a1-4422-f43b-8438-2e9a6c86f6f3"), "316 West Village, Lake Gay, Antigua and Barbuda", new DateTime(2020, 7, 12, 5, 32, 41, 115, DateTimeKind.Local).AddTicks(3575), "Dalton Strosin" },
                    { new Guid("87ef0e56-a980-6cd3-36f9-f7221990ea01"), "2812 Hodkiewicz Freeway, North Melany, Brunei Darussalam", new DateTime(2020, 3, 4, 23, 10, 36, 312, DateTimeKind.Local).AddTicks(1620), "Dock Predovic" },
                    { new Guid("37b74cee-76ff-89d8-2bce-069672c0df45"), "1648 Raynor Islands, Ambroseshire, Cayman Islands", new DateTime(2020, 6, 30, 10, 5, 19, 357, DateTimeKind.Local).AddTicks(9901), "Watson Bogan" },
                    { new Guid("3b4d1510-8397-bbcf-9114-45cbe370af72"), "013 Helena Canyon, North Craig, Guernsey", new DateTime(2020, 6, 20, 4, 10, 4, 445, DateTimeKind.Local).AddTicks(2233), "Claudia Grady" },
                    { new Guid("613527a6-765e-753f-02d6-a563cddb51af"), "48520 Crawford Park, Lake Haleigh, Guernsey", new DateTime(2020, 2, 23, 8, 30, 9, 444, DateTimeKind.Local).AddTicks(6639), "Justyn Hane" },
                    { new Guid("bb50975c-d2ac-cd6c-b3dd-45c9dd75a030"), "84445 Jaskolski Well, East Koleton, Cook Islands", new DateTime(2020, 9, 25, 2, 46, 6, 456, DateTimeKind.Local).AddTicks(6053), "Kennedy Brakus" },
                    { new Guid("af526446-2609-6f6c-cec5-4e598a284a9a"), "45245 Halvorson Orchard, East Jose, Pitcairn Islands", new DateTime(2020, 3, 2, 13, 11, 19, 159, DateTimeKind.Local).AddTicks(2598), "Herminio Olson" },
                    { new Guid("dd3c2e6a-bcb3-1e11-f323-6d3a71305875"), "129 Jacobson Mission, East Jaunitaburgh, Poland", new DateTime(2020, 6, 5, 15, 5, 48, 693, DateTimeKind.Local).AddTicks(899), "Bertha Smith" },
                    { new Guid("fa206673-bd0d-94ad-a055-b646f68c7ec0"), "9890 Abshire Street, Port Junemouth, Virgin Islands, British", new DateTime(2020, 3, 26, 22, 38, 31, 926, DateTimeKind.Local).AddTicks(7926), "Ubaldo Ankunding" },
                    { new Guid("100bc7b7-675d-b2cf-e818-0d129509fe40"), "26795 Tierra Mews, Port Bulah, Portugal", new DateTime(2020, 5, 18, 5, 31, 36, 239, DateTimeKind.Local).AddTicks(7817), "Gene Ebert" },
                    { new Guid("73c53fff-9ab0-48cf-e0a9-09838ebc3253"), "62426 Kihn Mill, Creminberg, Thailand", new DateTime(2019, 12, 20, 14, 44, 16, 495, DateTimeKind.Local).AddTicks(9165), "Alexie Labadie" },
                    { new Guid("38ca9685-a6cc-b941-6967-7b4752f1ec9f"), "621 Pacocha Route, New Narcisofort, Somalia", new DateTime(2020, 10, 4, 2, 43, 26, 290, DateTimeKind.Local).AddTicks(3880), "Orpha Goldner" },
                    { new Guid("25086c56-1b68-a6e7-1f1c-0d98172ee49e"), "676 Beer Highway, South Lila, Moldova", new DateTime(2020, 8, 15, 15, 26, 43, 780, DateTimeKind.Local).AddTicks(6593), "Prince Collins" },
                    { new Guid("f1ca7f84-e8e5-37c6-fc1d-fbe403096795"), "308 Parker Views, North Jacintheshire, Uzbekistan", new DateTime(2020, 11, 11, 11, 4, 7, 636, DateTimeKind.Local).AddTicks(8814), "Bonita Wyman" },
                    { new Guid("18899dc3-3c4c-b6fe-02be-4fd65acbf265"), "8593 Melba Route, New Margaretteside, Mayotte", new DateTime(2020, 1, 22, 6, 2, 45, 915, DateTimeKind.Local).AddTicks(2918), "Briana Aufderhar" },
                    { new Guid("7f6621db-484e-5ae5-cb1a-84491d01da83"), "921 Reilly Spur, Gorczanyton, Guadeloupe", new DateTime(2020, 7, 17, 9, 49, 53, 873, DateTimeKind.Local).AddTicks(8616), "Lucinda Vandervort" },
                    { new Guid("7e1086d1-8caa-e0e5-3fe0-db3923b6a26d"), "47407 Labadie Squares, Bradtkeville, Philippines", new DateTime(2019, 12, 16, 16, 38, 1, 414, DateTimeKind.Local).AddTicks(8513), "Rick O'Connell" },
                    { new Guid("0dc3b350-3082-4ff6-7f83-8c45e060abfa"), "27856 Lyda Green, Hudsontown, Maldives", new DateTime(2020, 12, 13, 23, 14, 52, 298, DateTimeKind.Local).AddTicks(5190), "Jaunita Wintheiser" },
                    { new Guid("df03d3d5-eb5f-f63f-ca58-a7d05edf3b58"), "7706 O'Reilly Route, Port Eldredburgh, Finland", new DateTime(2020, 6, 13, 4, 25, 22, 564, DateTimeKind.Local).AddTicks(3392), "Cecil Hauck" },
                    { new Guid("a78d0a36-bf1a-4084-aa82-9a00580dddd1"), "809 Hodkiewicz Freeway, Pagacmouth, Nicaragua", new DateTime(2020, 5, 6, 2, 5, 29, 363, DateTimeKind.Local).AddTicks(6080), "Lessie O'Conner" },
                    { new Guid("2731f7f6-aed4-cdb1-e276-328194c30b41"), "53642 Gerlach Keys, Schoenshire, Turkey", new DateTime(2020, 1, 13, 6, 40, 49, 915, DateTimeKind.Local).AddTicks(6610), "Yesenia O'Keefe" },
                    { new Guid("2708a303-09e5-7d23-4d99-6246622bb2ec"), "5742 Virgie Meadow, Koeppstad, Turkmenistan", new DateTime(2020, 6, 3, 15, 48, 20, 788, DateTimeKind.Local).AddTicks(6437), "Myles Schumm" },
                    { new Guid("1f905f0e-1a03-ddaf-2dc0-e44b74e0f120"), "836 Hoppe Mountains, Maryjanehaven, Saudi Arabia", new DateTime(2020, 7, 6, 6, 19, 6, 367, DateTimeKind.Local).AddTicks(3791), "Raphael Tillman" },
                    { new Guid("3749b854-9a03-e893-ea79-629d8a68c5ad"), "55659 Lehner Via, Langworthland, Pakistan", new DateTime(2020, 2, 3, 18, 5, 42, 976, DateTimeKind.Local).AddTicks(7188), "Emie Johnson" },
                    { new Guid("2a938f44-eda9-d186-d9e5-5fbbba4d4ecc"), "4255 Stoltenberg Dale, South Brendonville, Tokelau", new DateTime(2020, 3, 1, 22, 34, 48, 49, DateTimeKind.Local).AddTicks(9404), "Cierra Dicki" },
                    { new Guid("32d845fd-8183-e2f5-6065-43a73ffc3a8b"), "508 Arnaldo Cape, Eugeniashire, Vietnam", new DateTime(2020, 2, 9, 4, 48, 19, 696, DateTimeKind.Local).AddTicks(3393), "Breanne McDermott" },
                    { new Guid("bdb686f8-7508-b59a-7137-34fad6e80810"), "49030 Tillman Cape, Francesville, Lesotho", new DateTime(2020, 5, 5, 14, 32, 10, 563, DateTimeKind.Local).AddTicks(8540), "Jewell Koepp" },
                    { new Guid("88214b57-313e-2515-2d9a-3a114b327ada"), "02530 Gusikowski Fork, Elysemouth, Moldova", new DateTime(2020, 8, 3, 16, 26, 20, 208, DateTimeKind.Local).AddTicks(704), "Melody Dickens" },
                    { new Guid("e69d7e64-4587-1f0f-20ba-472dac6b09fa"), "78203 Viola Locks, Nitzscheview, India", new DateTime(2020, 6, 11, 21, 4, 29, 922, DateTimeKind.Local).AddTicks(2312), "Kassandra Schinner" },
                    { new Guid("dcb4e7fa-42f3-215e-6f63-6acef04b9bc3"), "0185 Bethany Plaza, Herzoghaven, Gabon", new DateTime(2020, 8, 16, 6, 8, 23, 356, DateTimeKind.Local).AddTicks(6409), "Cynthia Denesik" },
                    { new Guid("83b2a8c6-1e54-9a80-5531-1eadc7661344"), "9625 Schinner Flats, Koeppbury, Saint Vincent and the Grenadines", new DateTime(2020, 6, 2, 5, 39, 18, 955, DateTimeKind.Local).AddTicks(8566), "Keagan Heaney" },
                    { new Guid("4708d01c-1798-e76e-5694-0e316aa68402"), "52807 Rudolph Key, Patborough, Lao People's Democratic Republic", new DateTime(2020, 7, 20, 1, 22, 18, 525, DateTimeKind.Local).AddTicks(811), "Ardith Mante" }
                });

            migrationBuilder.InsertData(
                table: "owner",
                columns: new[] { "OwnerId", "Address", "DateOfBirth", "Name" },
                values: new object[,]
                {
                    { new Guid("23ef1cd5-aa1f-83f3-e655-d37fa3fca36b"), "83079 Conn Walks, Runolfsdottirfurt, Germany", new DateTime(2020, 3, 26, 20, 2, 40, 209, DateTimeKind.Local).AddTicks(9227), "Rodrick Kuphal" },
                    { new Guid("87b6c5c1-919e-1c93-5fac-d16c6dabd0f2"), "7900 Larkin Lodge, Schroederburgh, Ukraine", new DateTime(2020, 1, 14, 21, 17, 20, 706, DateTimeKind.Local).AddTicks(631), "Justyn Kemmer" },
                    { new Guid("e3058d8a-02e4-511d-9d2e-3a4cb0e9d632"), "80828 Larissa Estates, Kohlerburgh, Micronesia", new DateTime(2020, 6, 24, 7, 58, 51, 209, DateTimeKind.Local).AddTicks(9439), "Amalia Hansen" },
                    { new Guid("b44072c9-4e37-a304-3d92-4f448d817595"), "056 Enos Wells, North Jed, Portugal", new DateTime(2020, 4, 19, 18, 30, 9, 647, DateTimeKind.Local).AddTicks(8257), "Bernie Ondricka" },
                    { new Guid("1028e8d1-dfcf-1a41-2824-717790e70848"), "1206 Osinski Port, Lake Charity, Montserrat", new DateTime(2020, 2, 3, 6, 48, 37, 667, DateTimeKind.Local).AddTicks(5398), "Albina Grant" },
                    { new Guid("f2fcc839-9e29-c47e-cbfe-8a52ea1a88b6"), "3502 Strosin Trail, Wilkinsonbury, Italy", new DateTime(2020, 7, 12, 16, 34, 22, 203, DateTimeKind.Local).AddTicks(8808), "Cecilia Collins" },
                    { new Guid("c83df7a5-15eb-541f-3584-1e0685dde28a"), "187 Boyer Garden, North Jovanimouth, Saint Martin", new DateTime(2019, 12, 26, 18, 28, 7, 968, DateTimeKind.Local).AddTicks(45), "Boris Grimes" },
                    { new Guid("f2ac0b35-c0dc-fbcb-8685-988f638f3cdb"), "2314 Moshe Radial, North Orpha, Sao Tome and Principe", new DateTime(2020, 1, 28, 19, 6, 0, 163, DateTimeKind.Local).AddTicks(6596), "Ward Collins" },
                    { new Guid("79d037de-ef30-fead-3f50-244a18d654a2"), "7551 Bart Rest, Gloverhaven, Saint Martin", new DateTime(2020, 6, 6, 11, 14, 1, 641, DateTimeKind.Local).AddTicks(9046), "Francesco Block" },
                    { new Guid("2cb15963-c2bf-8aaa-34ca-d548fa65dcba"), "24710 Huels Streets, West Catharine, China", new DateTime(2020, 6, 18, 7, 56, 13, 500, DateTimeKind.Local).AddTicks(6143), "Nicolette Kuhn" },
                    { new Guid("25bee7f0-e327-b43b-c81b-63bb061cf6dc"), "180 Shields Village, Gianniport, Trinidad and Tobago", new DateTime(2020, 4, 23, 14, 23, 7, 874, DateTimeKind.Local).AddTicks(5021), "Krystal Bailey" },
                    { new Guid("0918b1f7-1d7d-0894-0e76-c736b6ad91e1"), "703 Gilda Hollow, Lake Ocieside, Hong Kong", new DateTime(2020, 12, 7, 17, 44, 0, 67, DateTimeKind.Local).AddTicks(2063), "Enrico O'Kon" },
                    { new Guid("0a6c3bcc-12ee-be78-111e-29f2ddfcdb9c"), "707 Bahringer Groves, West Lillie, Bulgaria", new DateTime(2020, 10, 21, 1, 3, 50, 395, DateTimeKind.Local).AddTicks(7862), "Brigitte Gaylord" },
                    { new Guid("6a45de31-407a-f387-8aae-dcd61070c8ad"), "0748 Murray Prairie, Hauckmouth, Iran", new DateTime(2020, 11, 12, 23, 45, 14, 887, DateTimeKind.Local).AddTicks(3179), "Colten Johnson" },
                    { new Guid("13f8f83e-9297-5b61-4a6e-ddcdba3da1ec"), "313 Johathan Points, Lake Makenzie, San Marino", new DateTime(2020, 8, 10, 7, 12, 36, 693, DateTimeKind.Local).AddTicks(6759), "Ethyl Halvorson" },
                    { new Guid("97c65ec3-7717-15b5-2d17-7da512974c31"), "5034 Esteban Lock, Heavenburgh, South Africa", new DateTime(2020, 2, 11, 2, 57, 5, 465, DateTimeKind.Local).AddTicks(8347), "Veda Heidenreich" },
                    { new Guid("6f1adbd6-a6f3-7489-78ca-5e97513e9023"), "4915 Cathryn Heights, Fisherport, Eritrea", new DateTime(2020, 9, 5, 10, 50, 49, 687, DateTimeKind.Local).AddTicks(4272), "Halle Harber" },
                    { new Guid("0eaea39e-fc51-6e89-8549-61b8938f4f46"), "64212 Friedrich Shoals, Lake Caesarport, Bouvet Island (Bouvetoya)", new DateTime(2020, 1, 7, 14, 18, 52, 926, DateTimeKind.Local).AddTicks(7857), "Noel Satterfield" },
                    { new Guid("37ce52a5-dd7d-d43d-5faf-6eb5db0af41c"), "48640 Hauck Stream, Sabrinaberg, Seychelles", new DateTime(2020, 8, 3, 0, 52, 9, 323, DateTimeKind.Local).AddTicks(2989), "Lisette Schaden" },
                    { new Guid("18c9c35b-acf5-736b-3e28-49c4bf2a69e2"), "9616 Johns Expressway, East Burdettehaven, Mauritania", new DateTime(2020, 9, 4, 13, 2, 45, 768, DateTimeKind.Local).AddTicks(1755), "Marcellus Nitzsche" },
                    { new Guid("e49ac3e8-9599-9172-ac4f-9b5876745a05"), "8325 Bart Common, South Jaylin, Turkmenistan", new DateTime(2020, 4, 18, 3, 43, 48, 754, DateTimeKind.Local).AddTicks(2251), "Bella Frami" },
                    { new Guid("67d7b552-fecf-5165-d638-6d3692184055"), "820 Emmerich Crossing, New Darien, Liberia", new DateTime(2020, 10, 13, 2, 46, 17, 384, DateTimeKind.Local).AddTicks(7470), "Clarissa Gulgowski" },
                    { new Guid("059380f2-9dc1-36f3-0bc5-914a94ee9f02"), "83919 Graciela Bridge, Abbottburgh, Netherlands", new DateTime(2020, 7, 1, 19, 35, 45, 211, DateTimeKind.Local).AddTicks(3264), "Maryjane Rowe" },
                    { new Guid("feb57a29-7f12-9cb7-aca3-7eac8aad9f4d"), "314 Waino Turnpike, Lake Darylfort, Svalbard & Jan Mayen Islands", new DateTime(2020, 10, 27, 15, 1, 21, 754, DateTimeKind.Local).AddTicks(7871), "Pearlie Maggio" },
                    { new Guid("736a23a9-03ea-a22c-1f95-f2680c1df2c5"), "7824 Reyes Corners, East Emmett, Russian Federation", new DateTime(2020, 4, 16, 1, 13, 17, 244, DateTimeKind.Local).AddTicks(3845), "Gia Quitzon" },
                    { new Guid("6603e709-2c43-0062-1f73-74e97d7ee8ac"), "7885 Jenkins Rapid, West Flossieland, Venezuela", new DateTime(2020, 7, 7, 1, 19, 3, 657, DateTimeKind.Local).AddTicks(8110), "Shaina Bartell" },
                    { new Guid("1a255eb4-818b-c97c-c505-a5dfbe3c15d7"), "630 Adriana Walks, Port Verna, Saint Helena", new DateTime(2020, 7, 28, 18, 58, 55, 885, DateTimeKind.Local).AddTicks(4082), "Hanna McGlynn" },
                    { new Guid("c977b702-c31f-0a92-072e-82e36ed976bc"), "208 Tromp Cliffs, New Kirsten, Honduras", new DateTime(2020, 10, 30, 11, 56, 40, 92, DateTimeKind.Local).AddTicks(1956), "Giuseppe Kovacek" },
                    { new Guid("a2889490-4727-f573-13f4-eaa18854b226"), "64451 Gardner Street, East Daniellafurt, South Africa", new DateTime(2020, 8, 16, 15, 7, 48, 389, DateTimeKind.Local).AddTicks(931), "Adrain Willms" },
                    { new Guid("36e64ff1-754e-d501-3e53-c3277d456ba3"), "7226 Johns Mount, Port Hiltonburgh, Oman", new DateTime(2020, 10, 8, 7, 18, 16, 321, DateTimeKind.Local).AddTicks(612), "Isabella Rice" },
                    { new Guid("3f63628a-e858-1cb8-ada7-950c1133973f"), "66730 Larry Pass, West Jacklynland, Saint Pierre and Miquelon", new DateTime(2020, 4, 1, 1, 55, 38, 142, DateTimeKind.Local).AddTicks(1004), "Lewis Schuster" },
                    { new Guid("6308e3f3-4dd5-b4ba-0002-16ac5742d188"), "6139 Langworth Summit, Lake Lucy, Antarctica (the territory South of 60 deg S)", new DateTime(2020, 9, 8, 13, 1, 12, 356, DateTimeKind.Local).AddTicks(2666), "Everardo Monahan" },
                    { new Guid("6ffff112-a658-eb9a-61a6-5d1e5dadb28b"), "9089 Jace Pike, Paucekland, Pakistan", new DateTime(2020, 1, 19, 20, 57, 42, 793, DateTimeKind.Local).AddTicks(1267), "River Hane" },
                    { new Guid("7252859b-ce14-6505-cc74-6f8820a72f06"), "5265 Swift Forges, New Uniqueville, Chad", new DateTime(2020, 7, 17, 4, 44, 2, 502, DateTimeKind.Local).AddTicks(5468), "Green Doyle" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("0049574a-8b71-eb99-df76-428309bcd4be"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("0054518e-d496-e862-3d53-27bb78a06fc5"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("00a2d748-54ee-f01a-bd89-df91b5c1d340"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("00f075d5-6e91-ac54-12da-8775539fbf99"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("01022637-d43c-9c84-0d11-4a77db91e36f"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("0189ebe0-499b-0e5a-9e48-e7a1f7483ef9"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("01af4602-1b10-2d1a-0c83-14a8bd731c5d"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("01cec870-ca39-e039-fbe0-32ebfb8f6526"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("01dc1f9b-f39a-80c4-013d-37e1c52e2bec"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("0215e24e-1eb3-2541-4473-9db089843d75"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("026343ce-eb18-e53f-621d-af2e12fd36de"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("036444c6-6f91-e4d0-5e82-7710f5711018"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("037a70ee-051f-c497-32a6-8ef18d82f1cc"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("0386d3d9-c7fb-c36c-47da-ca5b7ca9a827"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("04d4671c-d432-3d45-1959-11450817abf4"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("04e455dd-50e7-f5fe-b15b-0fcf5dbc2e41"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("04fdff2b-5930-c7ae-c9fd-453812cfcba1"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("052a5250-cc52-f431-3f2c-6d4f799f946a"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("0562004e-3073-1070-cc26-8f4c9a6f1d6f"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("059380f2-9dc1-36f3-0bc5-914a94ee9f02"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("05c06f52-9b47-9412-be6e-66545b54f28a"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("0644991e-354c-2f8c-7b86-0ef9f3e129bf"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("070acadf-161b-df8b-af27-1ce1d262bd45"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("07c21a4e-7a29-0f9f-1f37-91dce071e139"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("07e361d5-8e2d-d389-81c6-479215ed4805"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("08f31cf9-22c0-3c70-10ef-449296fa68b1"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("0904f211-e726-be97-601f-9169ef7708c2"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("0918b1f7-1d7d-0894-0e76-c736b6ad91e1"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("09217823-ae75-d4e8-f445-a21b84b23403"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("094be653-281c-5541-788d-e5e741358872"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("09a25175-6ce8-2d06-fe84-013270567239"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("09bff3c2-f122-9194-7fc8-6861cbfdf31f"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("09fae709-87f7-f270-eb0f-bbbe5ebc4333"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("0a6c3bcc-12ee-be78-111e-29f2ddfcdb9c"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("0a83d7ce-122e-0564-9a3e-257db84cd7ed"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("0abb6795-c20c-9016-7395-b6e3162b309c"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("0ac96cdd-136e-a19e-b46b-06c5f71b970f"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("0b22ef37-b652-0800-b7f0-01a747d61157"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("0b244192-1870-fc26-4682-9be3dd03427e"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("0cba6cca-4989-11ac-65ec-ea7ecd244d46"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("0cbff1ef-7e75-eedc-1656-99253c249409"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("0cd1ad05-0400-5833-f07b-ed7a73e87bd3"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("0cd58f37-cb44-4136-a03c-32077a59ba15"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("0cf4046a-33d1-337e-fb80-705fd8f02f1e"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("0d97ccbb-a44c-2e61-a7d3-a55056dec39a"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("0da736ac-991b-84b4-e9e7-7d6be6614583"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("0dc3b350-3082-4ff6-7f83-8c45e060abfa"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("0ea78423-afa3-80f2-547d-1f06fe7dd3c8"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("0ea9f656-528f-7af2-def0-37b8d19ef819"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("0eaea39e-fc51-6e89-8549-61b8938f4f46"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("0ee058da-eff0-a0a6-557c-26c9661393e7"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("0ef867fd-0f32-b2c6-92e4-b40c5eff480c"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("0f9d7ec4-c6f3-f4d9-883e-58e0cffd0551"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("100bc7b7-675d-b2cf-e818-0d129509fe40"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("1028e8d1-dfcf-1a41-2824-717790e70848"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("10d2dce2-fc6d-6017-1aff-e23035ea277b"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("111be72b-9264-bbff-695d-d3f593488778"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("113c636f-d311-2f4a-1fa1-13e2e0c05e08"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("11710b09-cb0d-32a5-6942-be334b95a748"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("11deb580-b39d-98ad-8e7b-7d3b7d9027d8"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("12224b73-4c2b-72f6-6cf7-86a88f4ce6a2"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("129a418a-f05c-dd16-1004-0bd97b91d59d"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("12a59712-4565-6cea-5d8b-5bc811b04321"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("12d8f64a-e08d-f965-7bf5-433e26f1072b"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("13122b92-ad2c-9b39-5745-881d298ff960"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("131bf3bf-8b76-505f-099b-59bc63ef18b0"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("136a350c-45f1-9021-ecdd-42bdcef3ce69"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("138cac10-4c8d-13a0-0142-0bce229b0af0"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("13f8f83e-9297-5b61-4a6e-ddcdba3da1ec"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("14c2082a-70a1-0669-9dcc-25300c5da332"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("15140b70-c72d-453d-8580-77787f6e4292"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("15786cfe-7a99-22e7-d9d3-e59788e7254b"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("15938745-fa3a-abe2-70c2-522a4f723603"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("15b8a5d6-28fe-2661-8055-67c7359b8541"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("15f3d68b-e21d-31f2-268b-860997d15bda"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("16356c48-9536-c9d3-9eaf-a405e6b033aa"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("1683d784-4e11-c5d1-8f8e-922d1717aa65"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("16b0f861-b258-cdce-7bb8-a109e2d1e6ce"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("16cf8929-57c0-8fc4-0d4b-1eb280b7db2b"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("17269dcb-9ad1-614d-49f3-519d8ec0cd9a"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("174e9a27-5ccc-b8a4-908c-46e64b1321bc"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("1783a4c8-db97-5f6e-fb1d-d70f222e922f"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("1835f5f1-7619-0889-8991-ad1468c11aa0"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("18899dc3-3c4c-b6fe-02be-4fd65acbf265"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("18ae0cb3-fa3c-9933-8cbd-e8adbe69f61c"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("18c12bdc-4a38-1037-9281-f833ef49c956"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("18c9c35b-acf5-736b-3e28-49c4bf2a69e2"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("18cd0de8-d012-1040-291e-21c849f8819d"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("18e01917-2598-5679-d909-8349f2b566ae"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("19534c75-d619-8c83-0113-caf0d038863d"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("19d7e1ce-ff12-e93e-a3ef-981fcbf4d3b6"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("1a255eb4-818b-c97c-c505-a5dfbe3c15d7"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("1a50b60c-6794-bd1f-a250-783955bd07af"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("1a744bab-25d9-e1b0-f29c-33575f3b7221"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("1a8eb9a1-4422-f43b-8438-2e9a6c86f6f3"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("1a9b2082-3293-12e4-0871-4f4bb8adfbb7"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("1ab233af-0b57-a762-4542-b2aae7453b75"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("1adbdf4c-7bbd-e8b6-e13a-b9ae38368e1d"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("1aeb186f-57b8-b128-226f-4601e2a9aae1"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("1af8e983-14bc-16fa-302f-6f5048016539"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("1b0a4899-b9f9-16c7-8bdb-0d62660d4493"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("1b8cde24-777f-e7ae-4ce5-d8fb3b1a053a"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("1c19a613-a86e-cac1-11ee-8ebd59dd8c2d"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("1c5793bc-ed9d-de9a-81c0-55873b23ebed"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("1ca02325-eef8-7388-102a-c19590bf9189"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("1cbf7f2f-67bc-3fbb-0c26-827c3d583fdc"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("1cfd6a1a-a44d-0fa1-4277-04175adba1f1"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("1d5f2bad-4e29-10b4-2a41-c85c9a8237b3"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("1d9a8628-db15-2a3b-7758-51562d5e78cc"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("1ddfa785-5b58-f661-96aa-e7f370cbdf95"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("1df84172-f0c7-78d0-0521-981efc19d9a8"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("1e9b906d-d4e2-c268-c53f-7e4f6bc4a31b"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("1eadaee2-44de-7958-8819-80b8604219fa"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("1ee089f0-5ce4-d228-43a2-2065a07b1466"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("1f2a62fd-4702-4cf7-9a6f-f29c51c101fd"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("1f4f22e1-6331-6478-2a99-19a4ba1a22ab"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("1f54cdcb-b41c-6b71-3ecd-deb0ada7cc02"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("1f5f7254-2cc9-bad9-e1f3-3d54ff50a003"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("1f87e054-f272-1723-fbb0-7149ff50416e"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("1f905f0e-1a03-ddaf-2dc0-e44b74e0f120"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("1fa2d526-9226-5103-999a-9e830f786492"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("1fb2030a-fc05-3cfd-a11f-d027c38fdd50"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("1fdad40c-50f1-8c67-6d73-98327bc80aaf"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("207c477f-f51a-c818-55a0-c869502395d8"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("20a17b33-9af3-5c99-fe98-766f45214016"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("20faff89-1d8e-65fa-4e22-b7b7529bde10"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("210d927e-5563-7bc1-d4a8-50f2d2ee5445"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("2111190a-cfea-b933-bd99-92ff7cd844ca"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("21447e23-40d5-fc16-d04a-996457a6fbdf"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("221fbc3e-f0cf-d396-4d0a-d11f6749c406"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("22287476-5197-8ee6-d3dd-c771faf4b54e"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("225d35ab-89b9-7e77-502b-aa8fe6c9cc71"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("228ae50c-1c59-347d-4006-77de96b320d2"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("22b5692c-a6bd-062a-012d-0dd0fe8672d5"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("236e98c8-8e7c-e282-f385-f7d3507796fd"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("2378cf36-3dac-52c9-ed93-f6f253948969"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("23ef1cd5-aa1f-83f3-e655-d37fa3fca36b"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("2412d9d5-92bd-23dc-7af1-bb39ef9c2fdc"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("246b74b6-771d-2484-adae-b3872260973e"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("24a8ed4f-eb69-b681-6a2f-33abba118f3d"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("24ade903-98b5-9f61-6d5f-364cd329b6d4"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("25086c56-1b68-a6e7-1f1c-0d98172ee49e"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("2594250c-2266-4650-4e8f-b33b813ce792"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("259b0c72-1918-bc4b-19a9-d3e600c07619"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("25ab1051-2340-2662-9cce-230670fba951"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("25bee7f0-e327-b43b-c81b-63bb061cf6dc"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("25d78301-5f36-eb93-66e2-fa521e4046d3"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("25ef87bc-f9af-4f59-3381-fd7fbb1238ab"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("2625985e-9f90-b1d2-2dd4-b114d1c92f52"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("264764f5-aa2c-d60d-4436-0570bbc2e4c7"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("264bd02b-f03e-114b-f960-e00d9c7634a7"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("2669b745-ba54-ab58-8a25-cc658fa43f67"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("266bf0f9-0bf2-5b2b-da6a-f82b7cb5cd8b"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("2677d83d-02a5-6dd1-69de-fd37bf1033c3"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("268d6f38-fc43-506b-802f-7570bf0be7c3"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("269c519a-93c7-5bdd-6214-94e5ca9c4971"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("269dcd51-eb49-a89e-7048-371f8bbc3dcc"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("26f2daaa-77fb-8d29-2779-12e17b7a9cce"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("2708a303-09e5-7d23-4d99-6246622bb2ec"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("2731f7f6-aed4-cdb1-e276-328194c30b41"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("2740f104-c389-cdf3-176a-8a7578cc034b"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("27fcb3bb-0e6f-8d32-36a9-511d221b281b"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("28077f81-29de-bc56-508b-4f92356b8494"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("28401fb0-f03b-7161-a61f-1ca7cda6740e"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("2871803e-6f6d-e5e1-aad9-e82e49fde7ff"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("2998f4c1-47b8-dc36-17ee-b3e4871c7d13"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("299c331a-96a3-5ce8-eb0a-3161d606de62"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("29bdc6c3-4a3a-85d2-8346-2b04e00e02db"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("29e013f0-a13a-f79c-4f5e-9e55c14688c6"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("2a8df08a-b604-ce2d-a32f-377518319de3"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("2a938f44-eda9-d186-d9e5-5fbbba4d4ecc"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("2af4f552-4bac-d27c-b110-0cca984affb3"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("2b135911-bf05-0d21-abfb-c1bfd2cac24e"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("2b2dc138-e385-a78f-fd93-375280711524"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("2b331f0b-5253-5ef9-bc74-30757b8a29de"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("2b4b304c-1f92-0ee9-a6bf-d2fde6bd1f74"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("2bb1f1f7-7979-aa6c-13e6-7962048aaf80"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("2bb9b765-3c0c-f915-e082-326f6111c6e8"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("2bca59fc-b80e-c379-383a-1d285d80b13f"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("2c3192e5-42e7-c1e1-66cd-57768c9d4112"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("2c3ef465-2a24-3f41-bb1f-89816e958e51"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("2c75d2de-c479-d25a-327f-408757824f21"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("2c976cd4-e7fb-d0ff-4603-624463a8cb21"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("2cb15963-c2bf-8aaa-34ca-d548fa65dcba"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("2cd8bd94-2552-c795-96be-6315f4a7309a"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("2d3351d4-f9f2-0e8d-0faa-29550f46e2d1"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("2e18d153-5df8-f1ea-ed77-881b1c69550d"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("2ee5e504-81eb-c7f7-eb87-6a937ed8a9ab"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("2eea4fcd-2afd-7bef-9544-f898ce08ef35"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("2f5d1e40-f002-c56b-f9a9-0cc7683b93c5"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("2f919437-3d0a-d235-4cc9-9285351b25f3"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("309927db-f7d1-5d3a-aed1-96a3fd0b923a"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("30c1a2f6-7f58-3378-08c1-c92c2d6aec42"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("30db3128-1ca0-eeb0-fa85-6f3daf3a045e"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("3180dfe5-c340-5d8f-faeb-391b140341d2"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("31b2452f-3f81-468e-3e61-92d53c46a789"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("31e9d7be-3bfb-be0c-e8d5-b792f4d5c68f"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("3236557a-2791-0c3c-9c12-e97a49dd65a7"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("32d4d812-47c3-fec0-2d5f-2237c5daa973"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("32d845fd-8183-e2f5-6065-43a73ffc3a8b"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("339d2a20-7ee0-ac04-e342-636d72d4217b"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("33a47c6f-6a71-23dc-360d-07424d7dcf9d"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("33afc1a4-dbea-d696-3a2a-9611a7700eab"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("33ed63ce-7413-80c2-40f9-829a0ad85a91"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("33f083a5-91c9-4f38-fefd-33bb8b9389da"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("340b61c6-0b70-b9b7-16be-76c6fcc6446e"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("3482a562-0ea6-657d-0b21-ec236ad35f6d"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("35a2f9db-93d2-31b5-0d55-0c32ba946dbb"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("35d9cc9a-c168-0562-9f62-5f8c2f9c2a05"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("36952599-e114-e8ba-8823-c7f48969c0ed"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("36e64ff1-754e-d501-3e53-c3277d456ba3"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("3749b854-9a03-e893-ea79-629d8a68c5ad"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("378deffa-03b4-9e85-df26-f5466836d3ba"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("37b74cee-76ff-89d8-2bce-069672c0df45"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("37ce52a5-dd7d-d43d-5faf-6eb5db0af41c"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("37f1bb96-7841-c124-9e87-90c15d4ca0dc"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("385306ff-e320-e16d-4bf3-f7dfda6ea2de"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("386a691f-2d2a-d33e-95a2-d77b1862114c"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("38ca9685-a6cc-b941-6967-7b4752f1ec9f"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("39397bbe-1063-5ff6-dac5-035c0a4f574d"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("398484ea-1bca-0ac2-13ce-94313e95a39a"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("39cc2e60-fea8-3baf-41a9-5f388460a91d"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("39d81cb4-2aa4-97b2-56a6-3a60f283ba63"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("39da82cb-af8a-7dd6-13f5-9a60d439575a"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("39e41472-2a5e-97a6-604b-9c17d401cfe4"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("3a29df32-2881-1aae-c728-1693caa2de21"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("3abe12a7-a92a-3e8a-288d-a4295ddbebab"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("3abf281e-809f-4f96-1b10-0135f5531014"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("3b39d808-c557-7137-c5ec-478b6096835f"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("3b4d1510-8397-bbcf-9114-45cbe370af72"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("3b5c4c8d-63a8-1908-575e-db7137cf40b2"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("3b5e2cc9-4938-b316-9ff0-57ab0e29c469"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("3bdd07b1-2592-f0de-6954-d2fd972539cd"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("3cdd166e-51cc-e904-d34e-dec6a1e21b7f"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("3d45089d-d033-a763-0fbe-a26de9bcac72"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("3d61c261-d157-96e5-828b-ff27faa88889"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("3d7b9348-35be-28f4-65c8-9a920abd81ed"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("3db13460-0f1f-1a9b-6d84-f2189e0b4043"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("3deaf3b0-e4ab-3ea5-b628-860ed033db49"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("3e094de9-67c2-de3e-2daf-54154866332d"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("3e54bb35-5fb8-7789-8d24-3eea1104b16a"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("3e6b97be-8418-2054-db1c-c7dad9fc275b"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("3e70dcc6-8171-5d8d-8c10-9f944ae98ef1"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("3e78f4fb-2d39-9f5f-fa76-a54ff9bce350"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("3ec9e7a1-a2ce-6dd4-8ccc-d554066fc50b"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("3f63628a-e858-1cb8-ada7-950c1133973f"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("3ffff80f-1d69-e543-9b24-710d32857f02"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("40176f04-543a-e3ac-c655-42bcae127e21"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("406e13f1-f51b-f42f-ac5b-bb8baf11b56d"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("40756ee4-7ab2-bcf0-9947-8efe41ee6196"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("41063005-9e4e-5e98-7dca-1fcc2964fe1f"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("410f3b3a-d6b9-64ea-312c-4845ed12bf7f"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("413e04b5-139e-c40b-6046-ff92e4bf356c"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("419f9d01-b5f1-d7c0-e357-9671b21e6d66"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("41dd473e-142e-ee6e-e4a2-6a4df9db4639"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("428ee6d4-cb74-59e3-c056-eb3e645357c9"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("42a3a043-2d14-deca-6cd8-502d3832d0c5"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("42d2873b-8030-09fb-f9d1-ee3707f3e0e0"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("43753bbd-16ef-b4ec-f9dd-2f5ed005882a"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("438bc72e-ebc8-eef2-36f3-38eebf39d6d4"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("439620ba-0699-7c7e-913d-13008e80e803"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("43ab5989-7c38-d31c-f69b-2c2d3766cdc2"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("43cad028-d860-e125-5103-49bca6d4d905"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("43f221c3-2c0f-a237-dd4b-3bb061a60f39"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("458964a3-cd40-bd8c-101b-995535b05e4c"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("45f79de1-6721-5945-e26d-651b4edde615"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("46109b86-36b2-ca3e-f7b0-7d38c2d1ce0b"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("461de46a-acdb-73b2-e0dd-ee3da6d097fc"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("4632db54-2f9b-3c37-3083-0a74081eacbf"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("467a09fc-bab4-70f2-8a5a-77d1ac25935a"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("46fe552a-df2e-09e2-3fd4-74477d977061"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("4708d01c-1798-e76e-5694-0e316aa68402"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("4758b9d8-c486-df2f-19d0-07ee070466cc"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("47820020-4f28-3a20-f03a-d4df35da9083"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("47a806a5-2346-c5b1-dcb0-db6aa84d82e5"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("484bb866-9c8b-5d11-6f72-7068a207a688"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("486c4d70-c9b0-75a2-74e5-52f8d2c6b64f"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("48d57dd1-1fd5-0a04-ba34-9a2e7f995072"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("491e9ae1-9a0c-cf55-6cb0-c841d8d16cec"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("497bfdc3-7fe8-662f-7c16-d0eb829c145b"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("49973c91-df71-c0de-eb3d-145b420e0430"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("49d0a895-af8f-fcea-cbc6-ea79d2d24329"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("49fb709d-8a51-e222-dad8-16f9f14a17b5"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("4a284313-1fc4-3ae6-9627-2c80a50bc16f"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("4a8906ae-e40c-f833-294a-8d7c0dcf4b77"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("4a9b4fd6-9def-0207-885f-8b5b0d3187a8"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("4ade236d-6232-9779-cd42-d09965013347"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("4bc0af4f-8d29-1e1d-6a96-018dee02c510"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("4bddd3b1-0038-d4f9-c93b-b86fe6b13f31"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("4be5cb76-35a6-f968-ee8e-839bcd2ca160"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("4c003de4-6c2d-f36e-8a10-bd24c375d538"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("4c4ca155-ff67-c65a-4e0e-dc42a9e7fec8"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("4cb91682-13dc-f5ed-c9de-9ec690677c25"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("4d093941-87cb-486e-5f26-2ab74ef4618e"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("4d250520-ff30-e878-8f3d-9383cb964fe3"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("4e72b921-f261-5172-d474-23e98e8d74a9"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("4e792a80-328c-5eb4-a021-1516073ccc20"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("4ed49777-3c33-3b10-1bb0-fdf88c0772b2"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("4eff4a12-cfc6-436e-93d7-d26c02b5d0ff"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("4f311004-db70-55ea-d37c-64361526445d"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("4f69fabd-4232-b4df-dd35-9a0605ed8cc6"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("50237b0f-9c7b-8a64-1cd9-2fa055fcdbc6"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("50259ffc-7e71-985c-3f73-cb91d18da355"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("503b37eb-e93e-ac08-02df-bd65a8c0446d"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("50865a82-e6df-0444-f97b-6638efa92b1e"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("51734ea9-f181-356c-119a-820a3b7f1a01"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("5197036e-b072-d1ed-c705-e2cb820956dd"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("52b493b8-ff8c-1c78-65b6-0895ca7dd35e"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("532e2155-2991-4c1c-470d-d82cfbf5cbf5"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("534c453d-0f47-8f7b-b118-d95a583cd3d8"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("535ee8a9-c2dd-b90c-848c-78d96c92422c"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("53643fa4-a3d7-5839-fbf0-610df63a63dd"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("542a1272-0d07-f791-87bf-3cee82ee3819"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("542d8166-42a8-1077-e224-216b103250fd"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("5454f90f-69eb-f1c4-d0ee-86166feea2b1"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("548f2a34-1369-372c-ab53-c5bc39875a2d"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("549859be-1678-b869-522c-13cdb6b58160"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("549d18d1-cf98-aaa5-b3a6-1367e9291bc4"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("54c11a19-84b2-9980-edeb-f8811682a10b"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("54c71938-ca04-751f-0336-c1acc351407b"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("55b9df65-7ee7-b6ae-9472-f8885cc333d0"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("55bce039-1390-26fd-ca13-ff4906ed90dd"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("55d90f56-11f9-5d87-5705-eb9cbd8153fe"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("55e5662d-a419-8c2b-ea35-cac7bb310131"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("55f170a5-8753-c7b5-b32e-7f4696df4305"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("55f39ae2-d8c8-72f2-e009-a572d8c8315a"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("570863a7-9eea-a09b-b955-8727ff2240ea"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("571c6608-0fb5-50b9-96e7-e6167bd81d7e"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("57731b15-8b9e-2be1-4490-65bcb7abd0d3"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("58745d18-6315-d93d-ac9d-f43470d61912"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("588ab597-9cd9-ec1a-04bb-0301aeb37b4d"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("596622ea-48f6-006c-7e88-762a097449bf"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("59eb7fd8-59d4-ffc0-0af6-0ba08ec78dfe"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("5a357a80-eead-3293-40c2-6128626fd594"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("5a621eed-01a2-1df3-e643-f1c8a0c59469"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("5ac02d24-7b87-5bdc-2d39-b0ea62d361b2"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("5aed192c-2088-a4d5-8518-0f8b6a610904"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("5afb5ea0-4cd2-b59d-b71c-7472991c75c6"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("5b0ccf23-49af-02ce-77b8-3fde58263aef"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("5b0e4b09-2119-1a89-9aaf-99f1161f4263"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("5b8ad16e-61e9-d7b7-52a0-96c39404eb54"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("5b9f3a0a-9ef7-42fc-a89b-5c4d8448807f"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("5bcb003c-cb6e-3c7a-78b3-0e1eb879f4c4"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("5c058bf9-ae51-1179-8242-4e19d38298ac"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("5cc685f1-b473-c5b1-75ef-070a3704215d"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("5cca3454-a955-dd42-3c89-524cb9aca1a2"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("5ce06eea-259f-ca3f-4835-bc5b75158b5e"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("5ce4f3c1-19e3-bef9-1a24-bbb9485793d9"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("5d012434-6945-a2a6-2412-00f265f0c806"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("5da04b22-8d1a-af99-b330-07b4d9c1d776"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("5da333bb-9242-2c6d-e9cb-7bbd32d8201e"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("5daa3680-c28a-49d4-f5f5-3f2eacfeecfb"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("5df790b9-accc-3484-29ac-5c0ef206ede4"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("5e0c449d-8344-bcef-6a14-c0777738129a"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("5e11db39-15ef-bca5-cb72-d528d3dd1ccd"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("5e5761f4-50e1-6acf-88be-c349ff55e9a3"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("5ea5182a-4901-d8c0-67f9-10ad1f5f4981"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("5f5c553f-f0aa-8289-e52a-f7c0a03241c2"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("5f6fb39f-cbb5-3595-0f47-e0dbc2897c6d"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("5fb3f0c7-6ab3-658c-10c1-aa8d434c7ca3"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("601c1fd7-ae4d-4b39-c426-f7ccd1676032"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("6060528d-5b5a-3114-8391-6b38e2182ef2"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("60775cc5-6242-7457-85e1-84a5f7b76fc2"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("60bbac93-8b15-8770-df6a-73f1079ef10c"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("60c1e300-97c3-d5c6-c0af-ccd3e1ed0478"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("6113d197-e539-1ea9-067a-fc99710d3866"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("613527a6-765e-753f-02d6-a563cddb51af"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("61414aba-7e49-7691-e069-05b17c648422"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("61531ce7-f13b-e14e-dc1a-29ab6477f2d1"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("619b78ba-1262-c74b-3306-e6a5cd698adb"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("621e590b-5681-c32d-fdbf-596b06b20602"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("622cd980-b745-5867-bff5-1c173c10b609"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("62319fef-cdbd-6cf3-36b0-94acb777a872"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("6308e3f3-4dd5-b4ba-0002-16ac5742d188"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("6309ca85-8420-6248-b498-e6cc03f17f10"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("633d7a68-0be9-0919-4b50-f637f2976342"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("6368e2a0-3fc7-001e-6964-df50bfedd0e4"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("63a88475-8250-36f5-9e27-0b4608531c4a"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("63ebdf12-1285-71c5-d399-7ea115068771"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("641b2251-930a-5d20-c75e-d1a9de6abfd7"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("644b245f-1c4e-96fe-e8dd-1acb2e5339a2"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("64749d3d-7cdb-91cc-46b0-bc54c74b69d9"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("64aa7a92-6aab-5568-d16d-527e5261fd6a"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("64f01b5a-a690-0a04-12b7-3bade7f79bb7"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("65e06255-8e31-6c04-3a62-1daffafa5a01"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("6603e709-2c43-0062-1f73-74e97d7ee8ac"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("6605e6bd-4a0b-fc8b-31d1-d0e0acf67c2c"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("66365e40-2662-07bf-4ee5-051ab8ff00b9"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("66a535a7-ea1e-b184-9f1c-719a20368156"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("66c3c8e0-59af-0620-7111-b889d7f205fb"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("67148aed-bec1-677a-b960-c44b53b4ccf3"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("671cb7d8-15d0-c7fe-73eb-af8355f780db"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("671ecc1e-843d-2358-3e9f-f73185caa574"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("67310ab1-6fc9-4ad8-783b-63a09145abc9"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("67d7b552-fecf-5165-d638-6d3692184055"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("67e69a64-cfcd-b3ba-2526-3025d365e040"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("687cb9f5-e02a-c599-d527-f63510e45963"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("688284aa-a8a8-34df-11c4-dc8f1c06ef43"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("69657b0c-2514-2acb-398d-d040cf653bc1"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("696f511d-a1a8-5e53-7695-979c5fcba2ff"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("69c7c80b-5d07-1f1a-336b-6a3d6e509d4b"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("69f04811-3d50-9289-4025-254cecc109c3"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("6a45de31-407a-f387-8aae-dcd61070c8ad"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("6a48767b-394b-f99e-b79e-4f9a03e8ed3d"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("6a4dc576-f935-7f4f-0adb-56ac418a962b"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("6a550a3b-de83-b407-25a7-c366041f52a9"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("6a58dfc3-8c45-7dc1-0547-7e5fe971c4db"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("6a5fe15b-c9ef-35a9-31b3-5771731e010d"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("6a8ca555-8b6f-749e-433e-da73b2bda4cf"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("6ab347a2-318c-fced-e1ec-81ee1bb628b4"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("6adfc6a0-1b9e-ee03-27b8-7233291d52e3"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("6b003854-cb96-fafb-727a-4d59025094f0"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("6b48e958-e4e1-151e-93fc-24885b69cce6"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("6b5f11bb-84c5-9228-02ef-fc61ed0b1c7f"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("6ba5aa30-b717-9dc5-dfb9-1622d1503fd8"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("6ba944dd-0360-9e10-33a1-634c0c0c5e47"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("6bba7a63-2ca3-3517-f9c7-94c96baf7ab3"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("6bfb81da-1c65-5bd3-b28c-76fef0e12d8e"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("6c02e610-40bf-c0e3-e3e4-241bc9624755"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("6c2cee3d-b30a-cc65-f209-87bde79c00d0"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("6c8e00bd-162d-85a0-09e8-a01c6bf2b94c"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("6c910cd9-9565-4288-b751-8c04170965bb"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("6c992f0b-4182-d860-dbf2-5e194a91d3e4"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("6caaecfe-8adf-2fa7-e357-3b749a3775fd"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("6cf6395f-f54f-e141-fa49-626a5d21601b"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("6d1d90e8-31af-b2d6-596e-008a96acfe48"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("6d57b214-ce8c-48db-8357-bec585340d68"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("6d8c81b5-9739-c5c4-8d78-4315146f4e83"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("6db08ed6-6616-4048-dd5c-c525f2e24ca0"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("6e246fba-b31a-9747-bcfa-fce2ff64dbca"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("6e24e5d0-a77b-8325-b1b8-a02f904fc79e"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("6e7ecaa6-adc8-068d-913c-656cc4770a3c"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("6ee1ef87-b4f4-bae2-91c3-9d85585c3e71"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("6f1adbd6-a6f3-7489-78ca-5e97513e9023"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("6f957149-c228-fb18-3832-6a1c94334eb1"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("6f9aa18b-e3d2-9611-1a0c-fd3532a8aac5"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("6ff52600-709d-178f-42b2-b72ebb342175"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("6ffff112-a658-eb9a-61a6-5d1e5dadb28b"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("70798919-0fbc-43fa-e3cf-7ab4aefec02b"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("70993a84-1e24-35cb-1e4b-0f92c6ad8296"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("70abeba3-e408-aa63-807b-ed96c3928712"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("70b273be-82bc-1175-1b90-30c2f90bc250"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("70b2994a-bb8f-c1ab-702d-4b7031965f70"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("710ae8f3-b751-1dec-cea1-2fa8f11ea366"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("714ddb23-d641-18ed-8e1d-b366275195ba"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("715365a7-6e0e-37ac-b03b-d0e754e7bddf"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("71b27c01-dd0e-56c2-7ae3-095ae57c3a26"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("71bfffa2-6f3b-2ff2-0947-f515359be17f"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("71e06e40-f6df-89fc-a894-cc9362e87486"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("71e35c2f-4e07-08b6-7eda-e4f882271ab5"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("71f8c5da-3d8c-4b6a-fd7f-d104c95a1b40"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("7252859b-ce14-6505-cc74-6f8820a72f06"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("73090164-bb94-91d0-95b0-c8d0e9eb9f0a"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("736a23a9-03ea-a22c-1f95-f2680c1df2c5"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("73a1ae08-8f8d-044f-5f75-d5e938c025f3"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("73c53fff-9ab0-48cf-e0a9-09838ebc3253"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("73fe5fe5-f1b4-6fb7-e1ac-a050d809446d"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("74010ca4-eb2a-ab2b-cf8a-957e9eb79c64"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("741a658c-221d-9341-9db3-7c618c1ed453"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("74ae7c5e-a680-ee24-3d3c-0342e81e16ac"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("75359947-db7c-eca8-56e9-9bc8dbb6e2b9"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("7553d022-a118-4543-0e53-0b8bf3ab0c53"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("7554d52e-e3f1-885c-2df5-c7485e5fa93c"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("7566b395-995f-6bec-0b88-3e37d3f742f7"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("7648716d-065b-bac9-5db4-3319eea80301"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("76578a1e-36fb-b19b-6955-7f0982cf570f"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("766471a6-e3ce-81e5-1b50-58d52cb89e31"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("77a2dc67-ed7a-87a1-414a-064c955c7e9e"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("780b0252-3e7a-f2d0-ba57-f46e75abc0a8"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("78635794-d524-0d3b-f7d8-e01a443c39b2"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("78d375aa-a5c7-6cc5-e141-2428c2c77148"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("792ec50f-123c-a5e8-bdf3-c1cbb2879c71"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("794a5494-1aa6-fc27-4afe-62f5b57c6aef"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("794d82eb-9d58-56a8-7ec7-def4e8dbb586"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("79591f29-7bae-36a0-d372-8d03f1f49eef"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("79aa17a1-f9e2-423e-9fbd-5739a92660b0"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("79c32e96-d50f-7692-fedb-286f6ecbcaae"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("79d037de-ef30-fead-3f50-244a18d654a2"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("79d45677-19f7-ae30-1eb9-fe7e764f5bcf"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("7a1e78a2-756c-e2db-1ae8-9b51cdce6aba"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("7a808508-3b52-ba92-f184-87790b0cc77c"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("7a87e0f9-a381-3b61-d99b-28357e6c4fff"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("7ac08ad8-bf66-91ba-04a6-132381e49254"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("7b1819c6-f0c1-d38c-1fd0-2aacc0aa5e06"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("7b60d1c5-dca6-08b8-9519-3c758803ac3a"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("7b7e9af3-e22e-2737-f620-c2f057198ede"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("7b82095f-d372-e5f3-8317-138a14927c36"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("7bab511a-8302-d6ce-7de7-8815e5cb8eb4"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("7bec0ea2-f2e6-f285-c9ed-290fc2681730"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("7cd57571-3efb-bded-3a8f-0e9f1590b6da"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("7cf12925-950f-95b5-e349-fe249b3ff7a2"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("7d32a657-469a-a8ad-b07b-5312f091e5ea"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("7e1086d1-8caa-e0e5-3fe0-db3923b6a26d"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("7e3976b7-4531-3afc-d481-35a4e3d101a3"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("7e48dc95-528a-d90c-54c9-ad32ebddf658"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("7e7adca4-ba95-c109-6024-e04cdb88cef9"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("7ee18d6f-74fb-26d9-2df6-1177e1e41b92"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("7ef1866a-03f1-fbcc-2b19-a557413694fd"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("7f6621db-484e-5ae5-cb1a-84491d01da83"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("7ff47120-719a-9473-4bfe-97743e33ad8d"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("805bcbfb-0f05-9b3c-7d79-e14f9ebd22f8"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("80c77876-46f6-3a4c-fd1c-96fb430d80ca"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("8112c816-40ab-2da5-b073-08db1edc7384"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("814907ff-c3e0-7086-7277-988d5eab6115"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("8160a44a-2d3a-32fc-f53c-ea3a0555993a"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("817554eb-09cf-76bb-ad33-856251f831ca"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("81aacfaf-712c-809c-fd3b-dc3d17e0b859"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("81b7bdfc-e2c6-fd9b-a14d-c027fb080026"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("81cf19cf-1ad3-e308-4817-6afdfabd59c3"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("81deef4a-501b-542d-5e9d-a32699456558"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("81eac716-2020-28d4-4c8f-ee277bb731e2"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("8221369b-f78b-651c-d2e2-8530e71ca15d"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("82719b49-9fdf-450f-ff04-f413206d877f"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("827cb0ee-d7be-efe9-86fd-ca1086756303"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("82d662f4-103c-9ab5-cab5-8dfc05b0345c"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("82f3622f-aa08-b1ea-d608-d0026c165372"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("833926aa-944a-d7e5-3b13-ab4f7e2a818a"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("833d483a-b2a6-09d3-0b9b-5263e7160479"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("83b2a8c6-1e54-9a80-5531-1eadc7661344"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("83b803bd-c9b9-572d-f6f8-a2c23bdd963d"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("83d3513a-9dc5-b27e-f1a0-27d244d76362"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("848a2e2e-aac7-76f9-5003-061c92ca9050"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("8554365a-8dc5-b873-392e-ab9d21f1e80d"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("8582d4ee-fcba-3cdb-9239-4e3386b64360"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("85e966f3-e870-f5c4-4c69-24d749152496"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("85f18cfc-6f64-aeba-49bb-d77eb83e58a9"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("864ab9d0-5a3b-44ce-010d-a9953dd39449"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("86ec4097-e858-2e90-061e-26f08d641b8b"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("8731ce8b-84f6-88c7-5944-b5a130e27242"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("8751d452-9095-4e65-5c0f-106901f169eb"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("879334c9-402e-fd1f-8a13-ae209c454ab6"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("87a96be0-edbf-856b-7edf-722f8673ab13"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("87b6c5c1-919e-1c93-5fac-d16c6dabd0f2"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("87c883cd-4b4e-8e7d-929b-04fbe9e6c0c9"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("87ef0e56-a980-6cd3-36f9-f7221990ea01"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("8804c74d-07c6-f1fb-fe41-44a3cab82e30"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("8806d4c6-5524-8675-30e4-8949aa50b30a"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("88214b57-313e-2515-2d9a-3a114b327ada"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("88538368-9f8a-6480-6437-ff3a7866f216"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("8876cf67-f524-890b-4e23-c8c2766c766c"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("889baf09-13b2-ae40-f76b-ffc20769eb57"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("8901328e-75d4-5501-001c-0660b347c00d"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("89319cc4-d0ef-f9bc-1254-f7b13791dd15"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("896bbd86-cae6-997e-45fb-06319471b069"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("8a53456e-00ff-6c31-f68b-6f854218507f"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("8a595357-1d1b-75ab-b712-6efcf016fd76"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("8a698fb3-fc6d-209e-e4a2-9a36cefaf11a"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("8a93c6ca-e3eb-463c-fffe-49bcd930935c"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("8a9aa00f-81d4-9f8b-9581-4fdfcd28233a"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("8b106e5f-081a-e77d-535a-5f24d1f2b264"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("8bff0b5d-4076-ca39-f7f6-3aa42fca71dd"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("8c15b076-02a4-ec05-d3cf-984d9b933b02"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("8c6d6f53-6445-72c4-d07f-b9e0ccb2e66b"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("8c86cf4a-6619-ba54-3517-680d3b0a1f55"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("8cd3609f-6a39-6e5e-e0d6-4b2780633e96"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("8d12216d-3b8e-d0ab-152b-5eaf738cd874"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("8d7a04d4-4ce2-8fc3-c5be-f8250c3b3ba2"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("8de4047c-989d-f060-6605-9496158de087"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("8e1330fa-6a64-284e-f4c7-e05e72248aca"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("8e99b768-126f-49bd-8a82-a106ceca8dae"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("8eb173b9-f67d-85d3-1dbb-fbdf5d41f601"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("8ebbaff1-f10f-8f15-e4f1-ac54273596d8"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("8ed43f02-45e2-a479-3b72-29671cda74e5"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("8f58b166-f88a-e5ba-d190-ef6e2cc733f2"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("8fbdae97-d42a-33dc-0a40-7ede1cde93c4"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("8fbf4760-4759-541c-5e81-9b7c7e1e93e1"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("9034efc8-870f-5505-2b81-e8657774e51b"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("9068dc87-d280-c45b-7f95-8379ad624948"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("907d68ba-090a-3478-b291-9a6e1a9503ca"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("9085f46a-6c7f-cfff-1489-9f47c5c0f2ec"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("9088de3a-575f-637b-3480-f3966b641af9"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("90a4f43d-cec4-895c-e50f-6d2d52493a4b"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("90da2ea1-2444-4bae-2198-928108fdcf57"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("91018b06-5c36-0f8a-8878-a612f532e09f"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("92044bfa-f614-0d33-57bc-95f043ca9c0d"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("9271877b-1f95-49fa-4ffa-68577c3899c0"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("928950e6-8e87-5818-341d-f4597f25b0af"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("9290a9b0-6cdf-db8d-f080-d7cf118adc7e"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("92d7c272-e2a4-815e-01ef-3f06f3e65c86"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("92f03e38-f589-fd7f-f828-fb67d73f00bf"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("93191d75-cea8-f8a2-481a-4b793c508301"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("932ad285-116f-8517-3a9c-40b79d022fe2"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("936241fe-be28-582d-714a-b54c5ff2ecf8"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("9386601f-f151-c9b7-b672-d1bbfa4b1ad0"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("94014e2b-6da8-882f-dd68-eb5880b31773"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("9444c83e-9bed-cd70-2337-1ea605328bc1"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("949c82f4-30a3-6990-535f-c814673ec212"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("949e34ce-67ad-baf7-5c3d-b35bb81316b2"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("94ab3502-18d5-1e8f-6d2a-833d41662947"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("94defcbe-5e20-1de3-0ef2-be691a444719"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("950c8161-44c6-7252-6dd3-1dbde1c10da4"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("950ca78c-bb77-9ad8-5a42-735787f61977"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("95409903-1ca6-d02a-4db7-06e090c603e6"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("95629afa-b282-89cc-8492-0c20ce46b62c"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("95b791b5-9cfa-d5c5-d0dc-54de617f350d"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("9604974c-07dd-06a4-8358-c8f4eff69ec8"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("9636d3e2-e517-b02a-6eee-2333b0b07af7"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("96a70182-b56c-6bb5-60af-1c67b5566651"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("9726f808-949f-7ec0-60a1-5dce9fd185d7"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("973ab301-7f21-82df-ec73-df2cb3a9cbcb"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("9782cc5a-f783-c1b6-d586-86f6489b02e4"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("97bd1cf0-e84b-d186-85bc-129a18393e22"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("97c65ec3-7717-15b5-2d17-7da512974c31"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("97c8d20f-cdd2-fa4e-0453-cf2f4e6e775a"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("98047cf1-4980-da6f-d6b3-693b6032feed"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("98128af0-f650-40db-931d-bc48c46dece8"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("98765b5c-2a2c-f0b7-00b2-098804159580"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("9877ca13-f499-f219-1bd8-0f5c7c683184"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("9895c994-2b91-e991-7f6c-948c08760b14"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("98cc06e0-e86b-b6ea-7908-cbd4f6064f1d"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("990370d1-7275-b46d-eca4-6813d6b55864"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("9940eb19-a862-3c4f-3625-1c30da8991c1"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("994697aa-b916-641c-acfc-b93af8fb350e"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("997399b1-3593-00b2-bee3-d7519304fd12"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("9a6aed3a-5431-6a7d-3380-38e257bac0c9"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("9ad31f39-77a6-e4dc-dabc-ae1c9d23b171"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("9b49b9da-daf4-db00-2eec-51cc899958fc"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("9b4f1c03-2eb8-467c-be80-fcac5d376e00"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("9b9ef21d-5e8f-390d-79bc-f42e03792e69"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("9c08d633-e238-aafd-2ff9-efc18cb04221"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("9c3321f4-73c8-7436-eeee-b6ad9d98ab4d"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("9c96d293-0296-87a6-32c5-15c71ac72012"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("9c9eca07-49cb-a387-2e88-8ca908e745fb"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("9cabc77d-0b3a-300e-7dce-4e7b8fd20224"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("9cd3c94a-d676-3a86-18a0-2667339f3ae1"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("9ce4961d-a1ec-3e5e-0137-c9f6c3c42316"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("9d3f10f2-ee9f-8ba7-012e-8f3b8801a078"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("9d7e513b-ee78-a618-5e18-af5719cb35dc"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("9d916db4-3310-cf58-bf7b-df4f052ba168"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("9dfa0f6d-55bc-b5a4-6970-24bbfd4c6d41"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("9e22999e-0f9e-4fe3-841e-70ebacbb202a"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("9eeb0b82-fc8a-fdd8-b28c-0a9e311d924a"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("9f4444ed-43ff-190e-e819-6cf82515e4c6"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("9f695d2a-14b1-9355-8d42-7c534b864093"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("9f78695c-cd1e-ba8e-08b5-17f3bae356bf"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("9f79ef84-0d62-7b76-a0d1-f0f2c741fcd4"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("9fab408c-c548-1906-dc9e-03408ba7c8db"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("9fbf1020-7f1d-0311-cd24-fe7a24d44ce8"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("a0c3f78e-bf2c-3f02-ca38-6b318e9e2cf2"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("a0c5277f-fc10-4f7d-57ac-6709b445ba10"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("a0d1eeea-07fe-b450-ab8f-e2d76aa9ae3c"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("a0eb6973-a9f7-68e6-0723-4d6c90dbc29a"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("a174cf2e-398a-8647-6719-ca59dcc3e63e"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("a17afd03-1299-4637-fe3b-932c48e20505"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("a1ab9ccd-d407-f911-19cd-cec271f8b14d"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("a219414e-abb3-0672-4807-d674d14b5876"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("a21cef98-3926-9323-eb0a-b84f85d2f0ae"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("a228f33a-5cc5-637e-4342-f1749af061ca"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("a2889490-4727-f573-13f4-eaa18854b226"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("a29250df-b4e9-ee6a-5bc7-2be772429631"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("a29e7006-1004-505c-437f-efaecb02a02c"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("a2a43483-fca7-a30e-d4e0-ccd1161cfd06"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("a2f6b9a1-a80c-dddf-3375-5f49d1ce5695"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("a348cb6d-c76a-9112-8e3a-a2d03290992d"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("a3ad36fe-255a-47fa-3bbd-5b79f075bfdd"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("a46ffcb5-f40b-5947-eaa0-26a5b2484bce"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("a55877da-1a24-56ba-a36d-fac48b1a3f79"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("a5815b9a-6275-4aae-2930-777d683313ba"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("a59c5a42-bded-edf5-aa42-9baa75724f26"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("a6152253-585c-9b0e-e20a-893509b4d831"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("a6650936-db99-a318-3057-1cf2e2751ec0"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("a6736007-4e2b-bae2-8971-af56a17afb14"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("a6a2879c-d378-603e-a057-0b99dfde64be"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("a6ded89b-bbc8-dcbe-671b-c58f7473620f"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("a6ff775b-90ca-4370-5aaa-af5c4a1eface"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("a700f7a9-4757-278c-71c0-5b11ffd8a44b"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("a70cf579-4d33-175a-8c18-8a2a46b03606"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("a7263b6c-4c09-0266-1132-c9ba900fe395"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("a74a929c-f03e-d9ee-9aa6-acff53d4d847"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("a768e061-f422-e079-a4f6-1d432c494bbb"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("a7873803-c3c9-f503-dff3-808f466497e6"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("a78d0a36-bf1a-4084-aa82-9a00580dddd1"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("a7d73399-7df2-6675-03f2-6d1aa250b0c5"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("a7f6f4f6-c23a-5eee-d863-e312b867ef91"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("a814b02f-0170-9cab-3cd2-3ef4e927a257"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("a88ac086-dc83-bdf1-2463-f5bd90179545"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("a8a07ee6-e83e-8b77-eb4d-06cc809c18fd"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("a8e16ec7-14b5-2b7b-ca9f-343747b80105"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("a8f8e415-aad6-371c-0773-504357a37037"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("a901ad3e-ac1f-d3a7-7f16-63fdbb094ebf"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("a9033c58-4969-dc04-afdb-ee202ea30eb2"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("a928de8b-b8d7-a042-f40e-51f527c49a19"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("a961bb22-18ae-f253-6e46-b57a19654cb0"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("a998284f-fdad-899a-63ae-459522f1d7ee"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("a9e8d8e2-6652-19d4-d2a9-92c6e51e6cf4"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("a9ff09ad-5b50-4963-94eb-eedac3554125"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("aaf530fa-c254-df60-e384-dba74b8f4fe8"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("ab89a057-c8aa-1513-fe16-01a50c19ba5b"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("abb224c8-7c2f-3fde-c636-f7d9300f88bb"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("abbd1474-f831-a67e-050f-6b8461e6dfaf"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("acb46f67-5759-187b-bc4c-f461e5e9481b"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("acefdf9a-1c0b-944b-338d-564272e2a6a3"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("ae2db918-e7e7-86e6-cbc0-242ffa67e748"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("ae2ed5d5-827d-e011-6fc4-0f20f48571ce"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("ae3ab9d4-cab6-0b9e-05c2-f21854d4cc40"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("ae54867d-08a4-9d0b-d31e-5e2086ded952"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("af526446-2609-6f6c-cec5-4e598a284a9a"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("b01be93e-9ab2-9c52-60e8-61222c868c62"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("b1345f27-5e92-6bf0-884b-8ae0b6b73562"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("b13f95f2-ac01-468a-ba18-ce3fa158076f"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("b1627840-a3c2-fd4b-c5f4-e8881493557a"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("b164e8ed-2910-2657-5e37-fcb7cab45e66"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("b1da79b2-20cc-0f0e-8feb-34005b067f29"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("b1f40cc7-24c2-ff76-8412-2d570e9c4645"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("b3b99146-262c-1cfa-a047-9acc38ef57a7"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("b3cbcaa8-e9c2-39bc-93d3-41bb17b901d2"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("b3d05bd7-d5e1-9c05-685f-fcee5bfb3841"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("b3d6e9a2-2e7f-21bc-0ddb-99aa1ae51c3c"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("b4276f2b-8526-fb6a-9172-b2567eb06da7"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("b4399962-8696-d6d9-4848-a2bb134e7c50"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("b44072c9-4e37-a304-3d92-4f448d817595"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("b443d5b3-8874-f986-2dec-1a44f448655d"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("b47d3ea8-f024-2994-5ab4-d0c5e2eb150c"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("b4a78356-0401-88d8-4f3b-aae14756aab2"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("b4ec0474-fafe-4c82-3bd0-e3a590e4f50b"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("b518d028-8dd2-64e3-9ab8-86f795fbaeaa"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("b52e6416-4be9-ecb4-213e-91e76986f313"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("b54871f0-7a25-40e9-c8f8-68468c0f4733"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("b5611ecc-c037-c5c2-3885-c710d2fbe0ac"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("b564be26-aeba-630b-ac52-65ccc2796d06"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("b5ab6a1f-bc82-9e50-af06-c93bb3fd137f"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("b5e957e9-5d0b-1fc7-8d72-3c58ab61c60e"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("b637e75a-3362-44c5-4996-346636b360d7"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("b65879d9-a626-809e-f269-933904c5aaf1"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("b6ff39c7-92de-b900-0b0b-760acf6ef0f5"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("b762cf81-7632-90e2-8d58-2b13bedddf53"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("b797c5f0-b298-5e4f-2f4a-7a97c0a58b7e"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("b79b8f80-92a0-4409-082a-e3e4bec88051"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("b81b6f39-f042-8ba9-c64f-18879bd77cf2"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("b85ba4ce-b05c-f410-5421-6b8698b1484a"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("b8dfe306-1880-9968-e456-292e6dee166c"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("b90f9678-9ec1-62bc-a8ee-84668d59b45b"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("b936ef68-0c6b-900a-05a3-410c91b37ea1"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("b9b20eec-2016-c746-f449-2cfda60f40b7"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("b9bab8f7-6c18-98d5-0c17-085dfb16ec73"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("b9d38e55-23ba-2b8f-55d1-1be2b25319dc"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("ba5db058-a758-3da3-0e27-2e99b97fd4f8"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("bae641bc-ac7d-5bb7-28a6-61a822459bf0"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("bb50975c-d2ac-cd6c-b3dd-45c9dd75a030"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("bb5e89bc-c051-2a3d-3fee-2ec7b6a3098c"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("bba03616-2c49-70ad-6f7f-f48d0ce31c1e"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("bc1281c7-d010-ea21-9c0c-c06b22b194f8"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("bc25885e-1ff7-8a2d-10b9-2822b044215e"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("bc2f0fb5-93e8-735e-0501-071c40cf6557"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("bcd0d3de-a5bd-0625-5d11-8e9de92bd046"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("bd6b300c-d9d8-1b79-ce2d-84878ee96481"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("bda54580-7388-ae57-ce79-3f4d658798c8"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("bda6e569-3268-e7d9-476b-7045bf338cb1"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("bdb686f8-7508-b59a-7137-34fad6e80810"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("be8dad95-ea37-45c1-9495-4013a63b6f07"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("be9bb38d-3ade-4a5f-72ab-da2f8f321d20"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("bfed482a-ca05-3830-1f92-2389b5eb97ca"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("c0194067-4ff5-88c1-effa-3fcdb36e8ab8"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("c0540d5a-f683-d5fb-9c50-cdfa7f8295a4"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("c0991cb6-e58f-6bf0-3d80-c729d99493b8"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("c166cc30-0ab9-2f7d-b1c2-0ef1aa36aafe"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("c1f75e10-42d8-f9a5-5451-eb8a6101dd62"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("c226dc3e-ed35-8eae-8158-fe764b1f2d31"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("c2983969-8df3-0a89-36fa-d6a16e975ce3"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("c2bc2f32-80b1-1dd6-0792-e64f39a9ebf1"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("c310e5c4-9fef-de05-43f7-8fdd462a93f9"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("c32329af-cc86-213d-3776-977e5fa802c6"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("c34bbc2e-84e2-582f-0f94-248eae3ce5be"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("c34d164b-1a67-c839-9064-15ef8abd914d"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("c3836538-5090-ff60-7858-2a99c6bc4d9e"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("c3901668-c466-ee1a-d461-ff6d14f1d47e"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("c3920c32-8c1c-9f6f-d79f-dfb856868ddf"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("c3fc29dd-402f-a0ee-218a-7bb229609fa8"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("c405a6c6-d10f-d53d-2014-8840b84f8ef1"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("c45e8d5b-95c8-a904-7d2a-492614c108d2"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("c45f2586-a937-cb37-2c6c-8b1d85d37800"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("c4989e8b-af76-dfbb-1b64-959d72e6ec34"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("c5ab94dd-fc9a-f27b-3538-d491072e8684"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("c5b88a2d-f553-1e7d-bc24-f4ddf3fa40da"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("c613792a-3853-9367-30eb-13fa07dcc5d9"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("c6a6d5e6-967b-2fb6-e310-bcb0933beeb6"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("c6ececca-6854-9622-d069-a8688f614d59"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("c7144254-59b6-95f6-44ca-8e74d807f103"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("c7225481-cd8f-6e97-de23-15296c2c3a38"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("c7b38c2a-8af4-c9a4-7ece-24dc72684d36"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("c7be2c26-d29b-67b1-4462-65b42f5455d5"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("c7fb7ee4-dd57-15a9-13bd-80c351daf390"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("c83c75d2-c4a9-0793-49e0-ab1554aa0028"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("c83df7a5-15eb-541f-3584-1e0685dde28a"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("c8689b2c-2596-a859-b1e3-e16555b8f2c1"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("c8af13e2-cd94-8dd3-1861-24591e7be8a6"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("c8d980cf-e6d7-94d4-2969-f44fd4d64276"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("c8e940d3-c6c1-e200-72be-2ae2cc011ea1"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("c9684f3d-e8f9-01b1-174e-1ebf98762d62"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("c977b702-c31f-0a92-072e-82e36ed976bc"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("c98f872f-c913-8a45-5419-4116d06a1646"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("c9d79632-015c-68b8-08f3-50b16d84bff0"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("ca482f27-aa00-1cfd-ed6e-1cdcc3538999"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("cab612a6-fcb3-be8d-fd38-d53ba3253282"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("cb2cc96c-9ab2-bfc1-cf6a-cd7887814a8c"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("cb330786-8083-7879-1ec9-752be8f42b22"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("cb5d026b-fb27-8688-981e-9968ddde7efa"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("cb816e59-76a5-0d04-b343-70ef32bbfed5"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("cc531f73-b03b-ed9f-4403-621bca0eeeed"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("cc63ea14-996f-d991-0d28-7bbc7f515c7b"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("cc8b2f85-a881-5716-9b1e-e210035e86c0"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("ccf139c4-1609-a8f5-f859-d3af10ccbece"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("cd0b1a7f-ca44-0735-2212-ca3f985bd3cd"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("cd1a0382-f2cc-0d3e-c11c-671b42051f77"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("cd278ff9-9e61-a00a-8ac8-5d9bbdab3086"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("ce1b4ba2-1d44-4444-6d2f-b30ddbaa5584"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("cebdb6bf-7d42-3a67-f960-3fbc6f1c20b9"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("cf5d5b96-3221-93b0-7d5a-1b139bc58b6a"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("cffc6690-0a91-f0a8-ace6-521b88a22b29"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("d016739a-2889-2f67-8534-3cc2947f058b"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("d040a948-f536-530f-0fc2-043e7256421c"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("d05e958c-d003-2236-b75b-da58e8ed665c"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("d067e0cf-f9a7-c6fa-e4f6-b92b6e5bb40f"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("d15c1a72-ca1f-f2e1-333c-bc88bb3fbb31"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("d16f1620-301e-090c-0044-5039d0f78db5"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("d1cdcd14-a615-4229-c937-8262ebc5a370"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("d336f93a-b29d-a5cc-71e1-9df73818bf08"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("d38c5c12-5679-c2ec-97fa-71868e600785"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("d3ba71e4-ef13-35c8-22f0-3f8374bba62d"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("d3d49906-553e-406f-e7a0-e0e0dfbc70c5"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("d3dd3a9d-050b-a463-c4fa-26c67a5787d6"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("d3e35d00-30c7-7329-9cb4-2e314497ed5e"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("d3fd32e8-b553-6d0f-7500-4d0d876c17f6"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("d408d954-429a-b33c-0c1a-9792282f583d"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("d4764c5c-2401-b777-45d1-d18891ce8142"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("d4de9222-9b5f-1049-e4b1-dc3d9d049ea5"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("d53cb5a2-05aa-5dd0-71c7-6a49ca270dde"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("d557504d-c4b2-c9a3-f05f-8d173986f08c"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("d5a84ace-d30c-c2e5-22b1-645376eaa70c"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("d5f8a89d-c3f8-2e3e-3744-62d78287c93d"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("d73fb040-ff39-cbbc-99ea-f6fd23ff1f1e"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("d7557b04-cb57-923e-f29b-9c3ed9c32f1b"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("d7a95b0b-ff2a-3f46-746f-1ae81fff8162"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("d7c90edd-cf37-f0b6-64cd-cb652f8eebd2"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("d8007ead-03d8-1841-1bf4-46fc52885f3f"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("d821dd17-499e-4c3d-05cb-90fd35c9457c"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("d880856b-f387-c4f5-32f4-d3883139f3b9"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("d88a8435-5947-3882-e6ba-9ae8784264fe"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("d8942171-e8c0-510b-c2f9-b28ffe07475b"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("d8a003f4-a033-139a-88ca-4c80bf6fbb8a"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("d9925b94-f8b2-dfdc-8f4d-e48059031cd9"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("d9fee81f-cefd-59e7-bf23-36aee077c2d5"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("da6b3e4a-e0c5-75af-2a26-aabd6fb64f37"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("da94474a-fa3c-f2db-0def-177e5a46c238"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("dabf4a5b-4468-ae38-0cd2-c7819d77b315"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("db1f9e41-c5b3-1ccc-79c3-1d49f8585831"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("db2112be-035d-1ba1-9bce-0256f25b0e86"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("db4a3e40-7a4a-c5ae-0337-ce68b056d0ae"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("db5aee8b-2043-a21f-78c3-50579164f8e7"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("db5e2c98-ad78-47a3-b5a5-f6649d0058cd"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("dcb4e7fa-42f3-215e-6f63-6acef04b9bc3"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("dd04ec19-0796-9651-2a5f-2469ccc654df"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("dd3c2e6a-bcb3-1e11-f323-6d3a71305875"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("dd69efc9-ec7d-56f5-ce63-99ce4efa66fc"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("dd9e7cd5-bf20-7d25-fa50-8f664c1b241f"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("ddd6e6ec-b65c-3594-b0a4-8424ccd9c9d2"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("ddeda53a-32b2-dbf0-57fa-ca19bc195e53"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("de0a37d5-440b-d905-13b6-8eb0c4a38dd6"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("de0ce7e7-d05d-1720-46b7-4fcc6553cc3c"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("de2a204c-be44-70d2-5a5b-701874a18491"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("de3bcc02-2e84-6833-ec51-aa02941bc548"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("de499198-a774-3950-01c2-296df7a887bb"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("de56901c-5898-8ace-7f8e-6b60dc6e4351"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("deda3b76-8108-4bac-49d4-80f41c53051e"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("defcab84-b101-9ae5-99e6-714d4c89e4ec"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("df03d3d5-eb5f-f63f-ca58-a7d05edf3b58"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("df52861a-8f69-2499-884c-98c1d2bcab1a"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("dfc3ee9d-8fcf-7bb9-d8d3-d16397a2a8dd"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("dfe65122-3543-7bc3-27c9-5eda7eb837f6"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("dff7d7d9-bf76-54b4-1ea5-37ac853a9c3f"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("dff89b87-6191-9b65-e672-cd925bdf9086"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("e00b50af-dd1f-7b41-f840-13432997eb00"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("e0123b86-7ceb-7caf-8d67-78ea7e2472c7"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("e01a369c-2c34-def3-af03-cec01c64b0e4"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("e029aad8-a5b5-6682-5b8b-b65d45815be8"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("e05afad1-343a-fc23-d588-834dca70de19"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("e07d9197-4a8a-3c30-769d-4e68ab3ddcdd"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("e0993f49-0a1e-aab7-ec5d-96b584a5a8b0"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("e0dcc9cc-ad21-de55-28f5-3206eab72bc1"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("e173b376-47f0-4a20-eb1c-cbbebd66bf7a"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("e1ceeed1-a623-dc25-f4ba-55fc629263e6"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("e20d1052-9048-d88b-5a80-879387d8462c"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("e223deae-800e-c868-d0d9-e57255606b51"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("e2536a2a-0ec2-1b9e-46ce-611e13b2c6f0"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("e2baa9d6-ba0c-f2fe-e805-29276d80b831"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("e2eac67a-5de4-0be7-1c8a-9c97d0dc598b"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("e2eb1aa1-4fa7-58a7-84c5-b259c8d9e3ee"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("e2ee1b5c-1e98-8bc8-1aa6-9c8c4a3899a6"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("e2f4811e-9d48-4429-a4fc-21f5b61321d0"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("e3058d8a-02e4-511d-9d2e-3a4cb0e9d632"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("e361db5e-f23b-d921-f50c-64a407399f57"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("e3cb99e3-9f0b-5f07-f133-385704fc077d"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("e453e8fe-cb00-abd5-8196-91cfe558cf8c"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("e46ac434-1e8c-4e0a-3470-7aee282cd850"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("e493d69e-425a-90bd-8572-2ea2fd8658f8"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("e49ac3e8-9599-9172-ac4f-9b5876745a05"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("e49cebb0-0962-c63e-bb4a-b6badbdfd136"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("e4bd1b11-50f4-0d88-815a-759248c10a47"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("e545d578-e509-2d55-498a-544ddf36132e"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("e588d2fd-8567-4bc9-c663-d68d5fd3bb5c"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("e6302b5c-4dbf-a2b9-8c42-e570a8ae298b"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("e6562554-96f0-fdb7-e03a-2903f98b5d5a"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("e6624951-1e7a-76fa-c442-d7116a69ce35"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("e669c57c-033a-a505-00b2-dd3735430438"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("e69d7e64-4587-1f0f-20ba-472dac6b09fa"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("e6a22ed5-8a3f-dc08-0457-114e5911e998"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("e6dc04d4-8e65-f980-ca76-399f3ef2375d"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("e70431df-6db1-a040-4877-1e8bf7b6a59f"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("e730ace4-89b2-a5eb-cc2c-1bcfb05e41bf"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("e758bc90-be0e-f544-2a7d-c3b1c5d039cf"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("e75e6d18-b579-df9d-8da9-13b002d1e904"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("e77ac291-6ef8-01ac-653c-2398786e67a8"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("e8659639-3d6e-dab9-9be4-cc04af85eb00"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("e9ec3ead-cfdd-9bba-fa9d-e3e41cfe9d14"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("ea682ef7-940b-f59e-b6b0-037233c11787"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("eac98a34-35ac-3397-ddbf-fdbf7b7fa3d3"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("ead69483-62a5-1808-7033-374b50c6f32f"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("eadd2c93-0c37-02e8-2589-d9bf624f3f7b"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("eb26648b-13fe-bd58-a946-fd417388a4e1"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("eb416ef3-cb7c-83d4-0118-8a8c385713e1"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("eb577514-83b6-07a7-4747-66e5dd26a4bb"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("eb683a9e-ead4-db8d-c24d-ad1207d9a76f"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("eba023f4-3d51-9ef6-a986-d97f056e2646"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("ebede0c3-85d4-0e8d-e898-7fd92d8b59b6"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("ebf28ab2-3220-6878-0fe0-d4d38178978b"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("ec02e911-d442-f370-4cdc-ec3ae0004f32"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("ec07ff16-e4c2-01e2-0233-b37956aefe5c"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("ec8ab369-c106-be0a-ae00-dab02949a334"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("ecddeeae-5552-fcf1-a5f1-b5c6806df527"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("ece4404f-c9b1-b195-5818-bf0fdf86a6c4"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("ecea65fb-1945-5f17-380d-5444542abc04"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("ed9df1df-0207-9bfa-632a-e5e44c00c4f4"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("ede8faae-dca1-486c-bab9-1b4b777142bd"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("ee377fc1-e142-49f9-03e5-e282fd5dce21"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("ee8a2d87-1657-eed6-41c8-d0fc86efd0c3"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("efea792e-b9f8-7863-a911-a660e4b3a089"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("f0ab1c7c-2043-fdd6-72e2-a8fccf2abec1"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("f0b3fdf7-4c32-c482-6600-f1ff37123a0d"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("f0ca2b9a-6762-2b8a-7516-57a76ac9fd8f"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("f107ef51-b395-51df-40ab-6afad43307a1"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("f1145391-d5e9-11f2-ec4d-c279bef30f09"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("f1584967-ae02-71fb-2fbc-832ea0e13f08"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("f17c49fc-a98f-417f-ab56-c4136af647ec"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("f1970937-6e43-3f79-b3d4-99c7a1167153"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("f1984f32-cceb-211f-15b6-eafb895ce686"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("f1c2edc7-e184-2095-3e56-124cac72896f"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("f1ca7f84-e8e5-37c6-fc1d-fbe403096795"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("f1efd596-3a42-ad82-1749-7189e1e7b13e"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("f1ffef4e-5aa6-96af-2295-488fc5dc718c"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("f27d7a8f-c793-db82-acaa-187645ff0ee4"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("f2ac0b35-c0dc-fbcb-8685-988f638f3cdb"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("f2e034be-01d0-0be4-801a-e9e5e3f0b022"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("f2fcc839-9e29-c47e-cbfe-8a52ea1a88b6"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("f329e67c-db43-f44d-520f-2ced511f2116"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("f3ce1e89-e1c3-a6b9-3035-3169efb4d296"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("f4216a5b-0308-a367-3374-4f94a8182a6d"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("f49a1df7-620c-40ca-fa16-4a99f0dfc493"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("f4c6c3f0-beba-1aea-cc35-9e23c4f0c41c"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("f504c63c-0604-9d46-71d0-5fe6e5e699c4"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("f56ed7a9-63fc-2780-2505-125774e85112"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("f583c620-65f4-cb08-f7f8-b55ceabb513d"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("f5958a4c-7d69-b723-5edd-5f4a0e0a7f4e"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("f5fbd850-77e6-fae8-e420-fe1944740000"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("f6b2a24e-bd9d-5559-50ee-e7e1a1d34433"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("f7088e69-2159-70a4-919f-c9d370608a5d"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("f7263e20-d40f-7b15-036f-b79edd1b2395"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("f7863592-f325-57cb-66dd-b6b355503a48"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("f7dce395-8f9a-874f-ae54-575d08400d4d"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("f7eb301d-3740-b3bf-cf79-d2bb0197e567"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("f80f7c31-ac92-6ab1-a3e7-0e1c480ba64f"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("f83b9d16-5fb7-3997-0102-f1e1eced71ea"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("f8b630ae-6787-78b8-cddb-97c2a79ff364"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("f8ca1953-93aa-91c1-dcd3-503b93260836"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("f8cda9f1-b87b-6d05-72a4-46929531436d"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("f8e94545-a141-f521-25a0-9dd1561fe249"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("f976a3a8-07e8-42e9-e6ea-bd183526cec1"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("f9a10689-0e4d-51e3-eb06-f466e1e64fdf"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("f9ad8f15-72bf-bb83-3808-63036ac5cf45"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("fa206673-bd0d-94ad-a055-b646f68c7ec0"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("fa3f1e43-5ba7-f749-5e26-608a3159d41d"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("fa7464c4-2695-bf87-9644-5c774b0369f3"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("fa7864de-4f30-fd44-9e22-2b9f20628b98"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("fa918f91-d84a-ce9f-5752-f5d3a8a3c7bf"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("fab3acc3-5b27-c89d-efd1-c2edffa34946"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("fae51b46-3ec6-dd72-fd96-59f8df2030ed"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("fb6de69a-114b-368a-d4d0-e528a2d9723e"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("fbd1f093-5c0d-5fc6-bd92-3007654b8a81"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("fbf7add2-6ccb-a1c4-4135-08aa30d8cf72"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("fc21450a-79b2-ae7e-c2a8-32db65af183a"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("fcd736be-d516-2736-118a-3be13b8854c7"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("fd1834d0-e202-d96f-4812-568a608f1de8"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("fd514c52-7061-ddce-4dbb-fe0442a5d583"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("fd772e30-920d-5eb4-b8ba-e940bfcc0504"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("fdae2dc7-3422-22f9-89ba-d05effcaaef4"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("fe141cd2-97d5-c6a2-0c3b-400f0c4e4fa8"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("fe81c3ea-5d0c-fd93-8728-4fb89a4e1f60"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("fea90af6-d6b7-a577-a010-a4c9a9e6abbe"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("feb57a29-7f12-9cb7-aca3-7eac8aad9f4d"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("fefc75f2-100c-41a6-b2a7-8932c23f16a4"));

            migrationBuilder.DeleteData(
                table: "owner",
                keyColumn: "OwnerId",
                keyValue: new Guid("ff47f134-6af9-b648-2af1-1595411283b5"));
        }
    }
}
