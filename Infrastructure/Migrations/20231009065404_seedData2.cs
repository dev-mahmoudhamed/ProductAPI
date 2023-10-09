using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class seedData2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "27fab1ad-b867-42bc-8500-eac047d57f5f");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "e5340148-09d5-4aa9-be3c-f8ae8dfc6145");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "f1e8c926-1f2b-4f65-8499-176456b23c3d");

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "IsDeleted", "Name", "Price", "UserId" },
                values: new object[,]
                {
                    { 1, 2, "Description U7FR3HVR7J9OGQK07JLU2YAL3L19BCR3M45UTTAB72HS4XIKHH", false, "Product1 WKQXV11R3F", 10m, "951d5cf7-c470-4504-ba7e-31bd07e43589" },
                    { 2, 2, "Description ATUWLV1PR5CI3P8NP0FS33R2V2TUYNLGOJZU2SVFUWKG8ORA5G", false, "Product2 741MHT94LT", 20m, "951d5cf7-c470-4504-ba7e-31bd07e43589" },
                    { 3, 2, "Description 6GX4QE8A2OYRF0OTLVXNOP33CM9T0UHD1K3WVKXBH7RXHMQ1EC", false, "Product3 TT9CBETDI0", 30m, "951d5cf7-c470-4504-ba7e-31bd07e43589" },
                    { 4, 2, "Description 93E1KINFQOPPQUQL5DOHGL9H5HCL32WJFM9EWK654XU61TR144", false, "Product4 MEH1FLKETN", 40m, "951d5cf7-c470-4504-ba7e-31bd07e43589" },
                    { 5, 2, "Description VCB046IXHL3HSEPD75352GQ1ASJLNU2CTAZ44NFNBG0HNLQLLB", false, "Product5 CV3P3YUSKK", 50m, "951d5cf7-c470-4504-ba7e-31bd07e43589" },
                    { 6, 2, "Description 211KYSZXQ17PCQRQ3LLU0NV7P4CH9SXNQBD4R1S7XQYXCDTHYO", false, "Product6 0CTH6F4NGN", 60m, "951d5cf7-c470-4504-ba7e-31bd07e43589" },
                    { 7, 2, "Description YM8EKLKZEYVWFHUGTJJCRYNOA7JKDBOH5YJXTAOGQEJPG0B06L", false, "Product7 MTVSV5QI8F", 70m, "951d5cf7-c470-4504-ba7e-31bd07e43589" },
                    { 8, 2, "Description HVQHJNU859VGUXA6YSSD86WDPIFDO089BJMKIE7058TXTMZLH7", false, "Product8 426ZFJB3IU", 80m, "951d5cf7-c470-4504-ba7e-31bd07e43589" },
                    { 9, 2, "Description PZ4R5HHM3ZXTKDTD9BIU8LIX22FL88V1E7SKO5QVIMJSNSKWXD", false, "Product9 D81X1E073D", 90m, "951d5cf7-c470-4504-ba7e-31bd07e43589" },
                    { 10, 2, "Description DO6XQC9G830QQZ1H7I508BSOWB7LU3DG8WWAFLWCLCY58U7HX9", false, "Product10 FN2THGUTHF", 100m, "951d5cf7-c470-4504-ba7e-31bd07e43589" },
                    { 11, 2, "Description 50Q94K37WRFEQMD0YGMTRR9HNAEH7N2A5528APK0K97C8BNRJF", false, "Product11 FNEKOAM3JC", 110m, "951d5cf7-c470-4504-ba7e-31bd07e43589" },
                    { 12, 2, "Description 6S03IHOKA9IRTXDFUAMJE2OYW6XH6ACV45H2V662K4IY5TZ4L7", false, "Product12 CDR7RVDAFY", 120m, "951d5cf7-c470-4504-ba7e-31bd07e43589" },
                    { 13, 2, "Description BUW174R2C7P7UB2JH91R3VQB8BUGS6WBBKB03J5PMLSJ2LLQ8G", false, "Product13 S39WMKD1D3", 130m, "951d5cf7-c470-4504-ba7e-31bd07e43589" },
                    { 14, 2, "Description A7KC63D7J4OT6NG883SRDLP4P3U8NPSRZJV6QB671ERULU9NZQ", false, "Product14 PGSQDJR2N0", 140m, "951d5cf7-c470-4504-ba7e-31bd07e43589" },
                    { 15, 2, "Description XF7RZAD5Y7VCQU9N9X8TJ4MV9BQELXFZ2PQL5I4YRJ09RCC17L", false, "Product15 B7PQ3YX889", 150m, "951d5cf7-c470-4504-ba7e-31bd07e43589" },
                    { 16, 2, "Description CWCTKDBYWZ9PD6K13BTMWHASN3XBYFRXXQWMFWF1MV3P12UEX2", false, "Product16 6OQMTSXT7D", 160m, "951d5cf7-c470-4504-ba7e-31bd07e43589" },
                    { 17, 2, "Description RWQRE3QCQGAS3NZQP5LPAIHV7BGYFFFPCTV42L5R6T2UY3DNK3", false, "Product17 OPVGVKH1LG", 170m, "951d5cf7-c470-4504-ba7e-31bd07e43589" },
                    { 18, 2, "Description J50U2IRK4T3XIJXWVWKBY8478QQE5K9BR1RX55H4DSWR4WCGJX", false, "Product18 M4EAZIS6ZG", 180m, "951d5cf7-c470-4504-ba7e-31bd07e43589" },
                    { 19, 2, "Description KOKH2ISGMQMB1WW3MBGR2LSZW5JK11296ORTW2ELXBDF1VA53C", false, "Product19 22J7OM1KWN", 190m, "951d5cf7-c470-4504-ba7e-31bd07e43589" },
                    { 20, 2, "Description 6OI87AGPQL9KLLYZBROCYMLKNXV0GSFJIE9VXBKZO07YVND6H9", false, "Product20 VPRFSAY5DY", 200m, "951d5cf7-c470-4504-ba7e-31bd07e43589" },
                    { 21, 2, "Description DUB6RB3OVX9YFFQC47A1BHD1UGFG320J205A2GZ4VHYNX4B2H9", false, "Product21 H58Y1CA8LF", 210m, "951d5cf7-c470-4504-ba7e-31bd07e43589" },
                    { 22, 2, "Description VRRANSLOC8A59PBXAE7QJ3X76D385SKWYN1WCZTA9JUTNG34AX", false, "Product22 3Q2CRHQHNO", 220m, "951d5cf7-c470-4504-ba7e-31bd07e43589" },
                    { 23, 2, "Description AVYL18ESOE4D750MWHCI16T9SQ968ARK1YR8SWDSMJNS2F2IK3", false, "Product23 DHAZIO044J", 230m, "951d5cf7-c470-4504-ba7e-31bd07e43589" },
                    { 24, 2, "Description PQ2C3OOI0A1RS3WYLBMAZIS21C0P91ORS6Z6TUN53P370INAKX", false, "Product24 05E9ZIRFCJ", 240m, "951d5cf7-c470-4504-ba7e-31bd07e43589" },
                    { 25, 2, "Description 1RNH9SCYCCGJSER48A8207JAQ1BA4JN67Y9ZETO7AAJOLNKSW1", false, "Product25 73TT3CD1ZL", 250m, "951d5cf7-c470-4504-ba7e-31bd07e43589" },
                    { 26, 2, "Description ZE8OFGDIPVMOULUED430YKVVIRZFSPP2YSS3ACHRYVAKU2U8AZ", false, "Product26 TFDLP9C4E6", 260m, "951d5cf7-c470-4504-ba7e-31bd07e43589" },
                    { 27, 2, "Description 3X4YWZ8PEOPI2UQ0J3HJSDDDS9ULTR39KIW33XR52FI7R9Z8QS", false, "Product27 P8RTEM18HP", 270m, "951d5cf7-c470-4504-ba7e-31bd07e43589" },
                    { 28, 2, "Description 21LV8EFVK72LA2RZC7Q1GNJGKKRWDGKH8M6U7WHPKSG5Q1B0CW", false, "Product28 33MVZFZWYJ", 280m, "951d5cf7-c470-4504-ba7e-31bd07e43589" },
                    { 29, 2, "Description NGJGJVY2KU09FJFH5R3NH3EB1SC7EQRZHKPHIP7ND7YTM1PNZZ", false, "Product29 C1PHPY4DK5", 290m, "951d5cf7-c470-4504-ba7e-31bd07e43589" },
                    { 30, 2, "Description FHRL2PZ8H12VM80S5COE2ESFV8FP97Q6F01T6SJV1M3WEBS7FQ", false, "Product30 0XGZPQ93DN", 300m, "951d5cf7-c470-4504-ba7e-31bd07e43589" },
                    { 31, 2, "Description MSDXPSQO4K5DE8ZDD1OBRMZ1I7SWCYBR13E887LMK745CXSS5Z", false, "Product31 RM1W1AROKN", 310m, "951d5cf7-c470-4504-ba7e-31bd07e43589" },
                    { 32, 2, "Description VGHUW14IAKFXKK4XV4TZZNO7C1S4COK4CQB8JD3NFOI36P04SW", false, "Product32 G0MRXFTNRC", 320m, "951d5cf7-c470-4504-ba7e-31bd07e43589" },
                    { 33, 2, "Description C9DJCVO74G3AIDJU8SRVSV9GI3297GL96N7YQ8G5Y1BBA5FH17", false, "Product33 CX6BHAOEK7", 330m, "951d5cf7-c470-4504-ba7e-31bd07e43589" },
                    { 34, 2, "Description 1VN81V85SEW2POBEK84SKM7ENNI2WMN15FNK4I2MEPBIS5EBL6", false, "Product34 6LKAFHEWCN", 340m, "951d5cf7-c470-4504-ba7e-31bd07e43589" },
                    { 35, 2, "Description AMUEB3PQLU2VDJQLWG8FU3UU42GBB1Y16XAKDC91L0DPFSZWXH", false, "Product35 16F4ZFJHJP", 350m, "951d5cf7-c470-4504-ba7e-31bd07e43589" },
                    { 36, 2, "Description Y6QC4QHS68B0RUBK1W6SQFSCLQGNR6DXUM73HTO8KWPL9UPWRA", false, "Product36 LLIYT43KLL", 360m, "951d5cf7-c470-4504-ba7e-31bd07e43589" },
                    { 37, 2, "Description N6CL3O437K3ZZXQN0RKZ1P7XORPKLIDZZY9JEVR5BOR9YDOF3J", false, "Product37 7IRMPMJ1J2", 370m, "951d5cf7-c470-4504-ba7e-31bd07e43589" },
                    { 38, 2, "Description 6YI3GPQJ81IUJWRAH3BP2ZJGFSJ2B3WBL860GUGSWJ0OGOO37K", false, "Product38 FNOBHBFX4J", 380m, "951d5cf7-c470-4504-ba7e-31bd07e43589" },
                    { 39, 2, "Description DKSUAZ0MAXL5DES06KBJN9YM1G3NZS0MGO3YCO33KETPXMRKRC", false, "Product39 W2J5BMSZ21", 390m, "951d5cf7-c470-4504-ba7e-31bd07e43589" },
                    { 40, 2, "Description 8AT0BDXQTXTIZJJDEMNSL0207UYTCOXPQ5TQXLRIMXYLR7687F", false, "Product40 1IO6QUC46L", 400m, "951d5cf7-c470-4504-ba7e-31bd07e43589" },
                    { 41, 2, "Description X854PRH7P07LDSN1M3K8YY4IDMHDGLED83O7ITZ3XMMJW6TT8N", false, "Product41 6VQ631DLKV", 410m, "951d5cf7-c470-4504-ba7e-31bd07e43589" },
                    { 42, 2, "Description LFK1DRTKBOWR6HZQ9ONWE7RULJZAYNR2EWMOHZ4QXEPWWT2YOX", false, "Product42 9WL23SR0AJ", 420m, "951d5cf7-c470-4504-ba7e-31bd07e43589" },
                    { 43, 2, "Description TK32OQROU75NVV2E9VMWOY2N2Z974ZC7P7XS2SEY0A60KXXNAF", false, "Product43 82J5VQICMF", 430m, "951d5cf7-c470-4504-ba7e-31bd07e43589" },
                    { 44, 2, "Description VXR6CVNTVVX6R9BFLVYI9EEQD3CUHXFJIFD3HYZSZAH3DCCFD4", false, "Product44 OB7A07T414", 440m, "951d5cf7-c470-4504-ba7e-31bd07e43589" },
                    { 45, 2, "Description OKCSUACMG9MIGK25060MSXR7VB64J5E0SD7XPYFCJA3S894PRG", false, "Product45 ZJB3HSAVS3", 450m, "951d5cf7-c470-4504-ba7e-31bd07e43589" },
                    { 46, 2, "Description 76SFRI2EAI0DDHISQGKP36RAHEWH57BP3TRYSCEOZCYIA6J5AM", false, "Product46 SH4EJ30LKN", 460m, "951d5cf7-c470-4504-ba7e-31bd07e43589" },
                    { 47, 2, "Description CRBRE0UPR4EVSUF93XWF64H23D4OF7R0XYTOOW67NUV0WDELHV", false, "Product47 US5PAMXGPD", 470m, "951d5cf7-c470-4504-ba7e-31bd07e43589" },
                    { 48, 2, "Description SMB9OEOGLKYDW9PLJEDBY477TRC4RMZ1L8POP35TE3347WSG7R", false, "Product48 QU3L6YM8VX", 480m, "951d5cf7-c470-4504-ba7e-31bd07e43589" },
                    { 49, 2, "Description AMRQIGS5E4FF86IQEDZWF9PW7K8V1DAY0FDK5MLQYH5HV2Y0UG", false, "Product49 HMBU805RDI", 490m, "951d5cf7-c470-4504-ba7e-31bd07e43589" },
                    { 50, 2, "Description 30EDCVDI6YHTBNBF87BN9LO9SC82Z2XS0S9OK2TEW1JAQWVWS5", false, "Product50 UGH3ST7FMR", 500m, "951d5cf7-c470-4504-ba7e-31bd07e43589" },
                    { 51, 2, "Description RECHRL3BW5RASDCELNZBNIUW4RTPO5TM9BXZXTE8YM904LC1TO", false, "Product51 TWVEJXYHHK", 510m, "951d5cf7-c470-4504-ba7e-31bd07e43589" },
                    { 52, 2, "Description LQUY0I6WOZDYYJ540TI18V4HPAT4G61HJCFBU5KN7UZVZJ7DO8", false, "Product52 WR5LO86VFQ", 520m, "951d5cf7-c470-4504-ba7e-31bd07e43589" },
                    { 53, 2, "Description 4N1FET8NAWEOSZQTFBD40RIMI49NQYBH3SZQX1HF8TV2AYVPOI", false, "Product53 8EDG4DKNW1", 530m, "951d5cf7-c470-4504-ba7e-31bd07e43589" },
                    { 54, 2, "Description E09BWDJGPEZ2G0HWCYCRHEEK90KFALD94DK1GFLD17U15CPRO1", false, "Product54 TFS7TP5CPX", 540m, "951d5cf7-c470-4504-ba7e-31bd07e43589" },
                    { 55, 2, "Description MIYPMZ78MWZUDMDANKN696BPIGQ2COXACE0A2HW8LRA0HFFCTR", false, "Product55 3UKWAZXUC3", 550m, "951d5cf7-c470-4504-ba7e-31bd07e43589" },
                    { 56, 2, "Description L2UIKNKZ2UXG5LG1WMYT8LC73HCPQZZIGMFT0CRA3X337SRNF6", false, "Product56 SHCAQOVGSQ", 560m, "951d5cf7-c470-4504-ba7e-31bd07e43589" },
                    { 57, 2, "Description YFQ8PXDJJSTLTNRDMRX7PS58RKQRWDCS7Y3L97D3VKV5REO3U8", false, "Product57 MPNI0QPRNT", 570m, "951d5cf7-c470-4504-ba7e-31bd07e43589" },
                    { 58, 2, "Description 7W9114PO2408IZMPOUYAAXWD0KCM0UEQI1W4PZYD3RSNO6F9SH", false, "Product58 7TKL0FVWYC", 580m, "951d5cf7-c470-4504-ba7e-31bd07e43589" },
                    { 59, 2, "Description Y994BJTVRZTH1RB4V9V6DED6BWEH602O22BAGD74TPEIH2RMAP", false, "Product59 233NGWCSXG", 590m, "951d5cf7-c470-4504-ba7e-31bd07e43589" },
                    { 60, 2, "Description 1PXICLY7BP6WI57BUAPD8Z3F4645NW65B9O4PRD73NS2Z5309I", false, "Product60 4QXLB7EATW", 600m, "951d5cf7-c470-4504-ba7e-31bd07e43589" },
                    { 61, 2, "Description AKRHO218CN48P51WJ6JRAYQB106A74M3APMWSBXEV1BTMVNPWY", false, "Product61 AQRUI3PVVF", 610m, "951d5cf7-c470-4504-ba7e-31bd07e43589" },
                    { 62, 2, "Description HWS2KQBW9A3J902G87W3U47V3S8JTH4VPTCHH32KUEMUG45ZI9", false, "Product62 V9H8N8XV6M", 620m, "951d5cf7-c470-4504-ba7e-31bd07e43589" },
                    { 63, 2, "Description HTRDDMJMV9GZ2V3KK6C4SYOKWBW56B75AR5NY8CJ9LLFPGQQSP", false, "Product63 N33C2R19K2", 630m, "951d5cf7-c470-4504-ba7e-31bd07e43589" },
                    { 64, 2, "Description UH71WGJCBV3N6X9ST4J6WG469BJCUJ4DQN68XKFV40WSSRPDMD", false, "Product64 JPQCD75RXC", 640m, "951d5cf7-c470-4504-ba7e-31bd07e43589" },
                    { 65, 2, "Description J02EM700OUT0286FSH3R7ZGHY4QALVUL5KDV4HNTCSQ54T3WIK", false, "Product65 TK6Y4J8HS9", 650m, "951d5cf7-c470-4504-ba7e-31bd07e43589" },
                    { 66, 2, "Description 0SABTIGQETDAZTEEUETER6EYTG5158Z1LDJ7YB69X11FZRY21H", false, "Product66 O7RTAAZHRV", 660m, "951d5cf7-c470-4504-ba7e-31bd07e43589" },
                    { 67, 2, "Description OAWWH0MVVW8UHM6UH4M93UU7M4DNGYHVCUS66D6ZDG7JEQTBNB", false, "Product67 RTNULU5Y6B", 670m, "951d5cf7-c470-4504-ba7e-31bd07e43589" },
                    { 68, 2, "Description 3XWWZ2EETHB2XMIJCPL5AQMSZ2582E63LH4ZZUG7XZ4AJSGZNO", false, "Product68 VI4QTEDBQ8", 680m, "951d5cf7-c470-4504-ba7e-31bd07e43589" },
                    { 69, 2, "Description MDW9PX9ZQUONUMU418SD2SN83AVPW0FYABZC0K3OCV59CA4EJ2", false, "Product69 9C54NISD4Y", 690m, "951d5cf7-c470-4504-ba7e-31bd07e43589" },
                    { 70, 2, "Description BJBS2HEF68U6Z0A0GQPJXCFSZID1OSKZUD1W38YGJG6WGTWD02", false, "Product70 PL90K6Y0TR", 700m, "951d5cf7-c470-4504-ba7e-31bd07e43589" },
                    { 71, 2, "Description 51HL38J6Z7NP6MYEZ6TZRJ0T2795LQW2BI9P44X1E7RSY09W5H", false, "Product71 HQJGOWTY15", 710m, "951d5cf7-c470-4504-ba7e-31bd07e43589" },
                    { 72, 2, "Description AC11HUJEZ677T0POMK3M7GIB0U2KPEPFXE5M95C5PJUQC86UV1", false, "Product72 M8C2X5PTC4", 720m, "951d5cf7-c470-4504-ba7e-31bd07e43589" },
                    { 73, 2, "Description C4ZKK82RI5BIR22C60PKSHGOPB75R01CGRFG5OMJI3AR2RA56G", false, "Product73 OY3U89T9RA", 730m, "951d5cf7-c470-4504-ba7e-31bd07e43589" },
                    { 74, 2, "Description QL0J825RYV20YLGALQISR3C9JVOC69X72TGL2DNHCGO4E1XFH2", false, "Product74 EQPN4T6KWG", 740m, "951d5cf7-c470-4504-ba7e-31bd07e43589" },
                    { 75, 2, "Description JRKN6J72GWY2LNS2G918K6IM2CWPTZZNT30V62HJ7D5WBEHJYJ", false, "Product75 WVQBY9GHG3", 750m, "951d5cf7-c470-4504-ba7e-31bd07e43589" },
                    { 76, 2, "Description 5Y0RODPDNG6P1GSOO4STLJUIH5XW7HQEW01AIP6OUGQQ2OH3RJ", false, "Product76 4C1SW8BI91", 760m, "951d5cf7-c470-4504-ba7e-31bd07e43589" },
                    { 77, 2, "Description 3PRU9Y3M37YCZOAU5PT1O1XETEK38BX5QDYT97DUXKY7Q95V6B", false, "Product77 F83IAY17OV", 770m, "951d5cf7-c470-4504-ba7e-31bd07e43589" },
                    { 78, 2, "Description LGC482GXJLNOVIBWMTNFCQZ3PWZDDWDI3R8RPV1QK95QJU7IG2", false, "Product78 PQ36418R4F", 780m, "951d5cf7-c470-4504-ba7e-31bd07e43589" },
                    { 79, 2, "Description XEFDCKPSI40K5TGGRLGL8QEDID7WEL7W7WADVHDJPG61ZRDZVJ", false, "Product79 SJ7GX14E8U", 790m, "951d5cf7-c470-4504-ba7e-31bd07e43589" },
                    { 80, 2, "Description FRF4I16NI92GR69FQHK9BB4YHNRMD14E4EBXKQ6TY4MTYQI2IL", false, "Product80 T8CVUE0UGV", 800m, "951d5cf7-c470-4504-ba7e-31bd07e43589" },
                    { 81, 2, "Description LCHCTDHKW5363IU8N8Y6FE7FGFQ4YZJTH04Y1Y1CEMT5PO4QPP", false, "Product81 REL6PZDQOT", 810m, "951d5cf7-c470-4504-ba7e-31bd07e43589" },
                    { 82, 2, "Description 3PFJSU53D3E5OBE0C3B9XZ5UGCUD2RI9CHLOQPPMKMETZX9S89", false, "Product82 9ODUA9JFB6", 820m, "951d5cf7-c470-4504-ba7e-31bd07e43589" },
                    { 83, 2, "Description PXHBDAHSIZOU2MTX9FMC1WIGAOF32PXL01RARVO5NJB0A1DLM9", false, "Product83 KYP36S50PH", 830m, "951d5cf7-c470-4504-ba7e-31bd07e43589" },
                    { 84, 2, "Description O04DN7RYDYYONIOG4V11XM8OGGIEF53VIGOT1513KFG59PUXHU", false, "Product84 28R0HKF7VJ", 840m, "951d5cf7-c470-4504-ba7e-31bd07e43589" },
                    { 85, 2, "Description ASFKRRY6XRK23DWEQEBVKFVQ4AZ3HKBMP4TKNHPPEZVSJQFQ3Q", false, "Product85 AKR24OATQW", 850m, "951d5cf7-c470-4504-ba7e-31bd07e43589" },
                    { 86, 2, "Description VW7FZX3LU0545QILQ2VDVKQH4U8UL4WPRZCRASXWACXSKG5KDH", false, "Product86 U099LI6CL9", 860m, "951d5cf7-c470-4504-ba7e-31bd07e43589" },
                    { 87, 2, "Description 84EN7HDIWTJR8YAZHP2RF0A17ZXNDKNF9W4RLN7G43S6MPIWNK", false, "Product87 BDHJGCZKBQ", 870m, "951d5cf7-c470-4504-ba7e-31bd07e43589" },
                    { 88, 2, "Description U6CBS77TERH1NIL8I5N37UYL3HP1DSR733JGPIZVI42KXZ7UN1", false, "Product88 PMJH95XK6V", 880m, "951d5cf7-c470-4504-ba7e-31bd07e43589" },
                    { 89, 2, "Description Y1FDZWN5NTNTGPRK2TW1OISIC4DMUWYVYTN7B8VFYH38O2EHDH", false, "Product89 UYCGSLIWPY", 890m, "951d5cf7-c470-4504-ba7e-31bd07e43589" },
                    { 90, 2, "Description 2F5V9FR6Q6VJH97PT1C5XN5Q3TASUA4N5L495L6A4QZ3LC0RN8", false, "Product90 1UHUJ47L8I", 900m, "951d5cf7-c470-4504-ba7e-31bd07e43589" },
                    { 91, 2, "Description IMI46ONE5G4FHJQ12IJLNMZCD1WVKIH0MTDN24SUKNHA01PBSB", false, "Product91 ZRZFPTKI76", 910m, "951d5cf7-c470-4504-ba7e-31bd07e43589" },
                    { 92, 2, "Description L91A6HMRMNI8TRWXQ2GNMCRG10JHG6X0HXMJ1NG6FGTHJNZHR7", false, "Product92 91C6N5PUYA", 920m, "951d5cf7-c470-4504-ba7e-31bd07e43589" },
                    { 93, 2, "Description ZLXCIQMLIROESDP051UX2XNED008Q8GVNCJUBA7UJPCYLXE4RK", false, "Product93 Y5EMFK82RK", 930m, "951d5cf7-c470-4504-ba7e-31bd07e43589" },
                    { 94, 2, "Description GBIY30PLJBK3FBA50ADW0UVJLDVZSJ7SCNG1DQQ8R22W0DTK52", false, "Product94 5FSTXNCMON", 940m, "951d5cf7-c470-4504-ba7e-31bd07e43589" },
                    { 95, 2, "Description H7BLN865MZAOR90DI8H5MV3BORYIEAUTXCPOKI4VB36V5438PW", false, "Product95 GF4CFAQSSA", 950m, "951d5cf7-c470-4504-ba7e-31bd07e43589" },
                    { 96, 2, "Description KKTDOQBRG25RG81DP4FJ9Z4YZHQCBZPRW4F4KZJVY93BO165S0", false, "Product96 KXMERU02FP", 960m, "951d5cf7-c470-4504-ba7e-31bd07e43589" },
                    { 97, 2, "Description 0G0C3UL5SUXSE4RAM3UQ0A8ZP7UHKYYTI39RAMHERP5BFXKPGD", false, "Product97 23P0N29CBR", 970m, "951d5cf7-c470-4504-ba7e-31bd07e43589" },
                    { 98, 2, "Description E34F0ZIT6SF19JI5U6BFBZU5WRD9WFGA6Z4AIGMIFKLS484X4K", false, "Product98 VHG1GEQQ1F", 980m, "951d5cf7-c470-4504-ba7e-31bd07e43589" },
                    { 99, 2, "Description HRPJ0JLUFCV0H9702BCQM66SQM3WPK6QK1XS79I0D6DJGRCGT0", false, "Product99 D2R4IP2EYJ", 990m, "951d5cf7-c470-4504-ba7e-31bd07e43589" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "aec66ad6-82e6-4b85-a19d-483f3b202439", null, "Administrator", "ADMINISTRATOR" },
                    { "df7900ec-a99a-453a-84d0-a296bd5614c6", null, "Manager", "MANAGER" },
                    { "e9325ad8-cd6e-4751-90a4-d168bdff082d", null, "Customer", "CUSTOMER" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "aec66ad6-82e6-4b85-a19d-483f3b202439");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "df7900ec-a99a-453a-84d0-a296bd5614c6");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "e9325ad8-cd6e-4751-90a4-d168bdff082d");

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "27fab1ad-b867-42bc-8500-eac047d57f5f", null, "Manager", "MANAGER" },
                    { "e5340148-09d5-4aa9-be3c-f8ae8dfc6145", null, "Administrator", "ADMINISTRATOR" },
                    { "f1e8c926-1f2b-4f65-8499-176456b23c3d", null, "Customer", "CUSTOMER" }
                });
        }
    }
}
