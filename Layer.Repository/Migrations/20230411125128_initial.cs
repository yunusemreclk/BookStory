using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Layer.Repository.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryID);
                });

            migrationBuilder.CreateTable(
                name: "Invoices",
                columns: table => new
                {
                    InvoiceID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TotalPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Invoices", x => x.InvoiceID);
                });

            migrationBuilder.CreateTable(
                name: "Writers",
                columns: table => new
                {
                    WriterID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WriterName = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Biography = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Writers", x => x.WriterID);
                });

            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    BookID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BookName = table.Column<string>(type: "varchar(150)", maxLength: 150, nullable: false),
                    WriterID = table.Column<int>(type: "int", nullable: true),
                    Price = table.Column<decimal>(type: "money", nullable: false),
                    Summary = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Image = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    Pages = table.Column<short>(type: "smallint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.BookID);
                    table.ForeignKey(
                        name: "FK_Books_Writers_WriterID",
                        column: x => x.WriterID,
                        principalTable: "Writers",
                        principalColumn: "WriterID");
                });

            migrationBuilder.CreateTable(
                name: "Book_Categories",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BookID = table.Column<int>(type: "int", nullable: false),
                    CategoryID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Book_Categories", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Book_Categories_Books_BookID",
                        column: x => x.BookID,
                        principalTable: "Books",
                        principalColumn: "BookID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Book_Categories_Categories_CategoryID",
                        column: x => x.CategoryID,
                        principalTable: "Categories",
                        principalColumn: "CategoryID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Carts",
                columns: table => new
                {
                    CartID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BookID = table.Column<int>(type: "int", nullable: false),
                    Number = table.Column<byte>(type: "tinyint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Carts", x => x.CartID);
                    table.ForeignKey(
                        name: "FK_Carts_Books_BookID",
                        column: x => x.BookID,
                        principalTable: "Books",
                        principalColumn: "BookID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Comments",
                columns: table => new
                {
                    CommentID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BookID = table.Column<int>(type: "int", nullable: false),
                    CommentText = table.Column<string>(type: "varchar(500)", maxLength: 500, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.CommentID);
                    table.ForeignKey(
                        name: "FK_Comments_Books_BookID",
                        column: x => x.BookID,
                        principalTable: "Books",
                        principalColumn: "BookID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "InvoiceDetails",
                columns: table => new
                {
                    InvoiceDetailID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InvoiceID = table.Column<int>(type: "int", nullable: false),
                    BookID = table.Column<int>(type: "int", nullable: false),
                    Number = table.Column<byte>(type: "tinyint", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InvoiceDetails", x => x.InvoiceDetailID);
                    table.ForeignKey(
                        name: "FK_InvoiceDetails_Books_BookID",
                        column: x => x.BookID,
                        principalTable: "Books",
                        principalColumn: "BookID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_InvoiceDetails_Invoices_InvoiceID",
                        column: x => x.InvoiceID,
                        principalTable: "Invoices",
                        principalColumn: "InvoiceID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Writers",
                columns: new[] { "WriterID", "Biography", "WriterName" },
                values: new object[,]
                {
                    { 1, "Tolstoy Rusya'nın Polyana şehrinde dünyaya gelmiştir. 1828 yılında oldukça varlıklı bir ailenin çocuğu olarak dünyaya elen Tolstoy küçük yaşlardan itibaren annesiz babasız olarak büyüdü. Henüz daha çocukken önce annesini daha sonra da babasını kaybetti. Tolstoy babası ve annesi vefat ettikten sonra yakınlarının yanına yerleşmiş ve yetişmeye başlamıştır. Tolstoy küçük yaşlardan itibaren Fransızcayı da öğrenmiştir. Fransızcayı öğrendikten sonra Fransız yazarlardan olan Voltaire ve Jack Roussa'nun eserlerini orijinalinden okumuştur.Tolstoy yetişkin olduktan sonra orduya katılmıştır. Rus ordusu ile birlikte Kafkasya'ya gitmiştir Kafkasya'da gözlemlediklerini de eserlerine eklemiştir. Daha sonra ilk kez 1854 yılında Kırım savaşına katılmıştır. Kırım savaşına katılınca subay olarak görev yapıyordu. Askerliği bittikten sonra Petersburg'a gitmiştir. Burada da bir ev tutup pek çok eser yazmıştır.", "Lev Tolstoy" },
                    { 2, "Birçok sözü oldukça bilinen Shakespeare sözleri oldukça beğenilmektedir. Tüm dünyada ünlü bir yazar olan William Shakespeare' in özellikle aşk üzerine anlamlı sözlerini sizlerde paylaşabilirsiniz. Bu anlamlı Shakespeare sözleri: William Shakespeare'in aşk ve hayat üzerine en anlamlı sözlerini sizler için derledik.William Shakespeare (1564-1616) dünyaca tanınan en büyük yazarlardan biri olarak kabul edilmektedir. Hayat, aşk gibi konularda oyun, sone ve öykü tarzında şiirleri bulunmaktadır.Tüm dünyanın tanımış olduğu yazarın en anlamlı sözlerini sosyal platformlarda resimli olarak kolaylıkla paylaşabilirsiniz. En anlamlı Shakespeare Sözlerini paylaşarak düşüncelerinizi yansıtabilirsiniz.", "William Shakespeare" },
                    { 3, "Batı Edebiyatı’nın önemli yazarlarından olan James Joyce 1882 yılında İrlanda-Dublin’de Kanada göçmeni bir ailenin çocuğu olarak dünyaya gelmiştir.", "James Joyce " },
                    { 4, "Dostoyevski 1821'de Moskova'da, yoksul bir evde doğdu. Doğar doğmaz yakasına yapışan yoksulluk, bir ömür boyu peşini bırakmadı. Doktorluk yapan alkolik, sinirli bir baba ve hasta bir annenin yanında mutsuz bir çocukluk geçirdi. Altı çocuklu ailenin ikinci çocuğuydu. Genç yaşta tüberküloz hastalığı yüzünden önce annesini, sonra babasını kaybetti. Babasının ölümünü kendisi istediği düşüncesi yüzünden depresyona girdi. Epilepsi hastalığı da bu yıllarda ortaya çıktı.", "Fyodor Dostoyevski " },
                    { 5, "Charles Dickens, 1812’de İngiltere’nin Portsmouth kentinde doğdu. Babası hapse düşünce okuldan ayrılıp bir fabrikada çalışmak zorunda kaldı. Bu dönemde işçi sınıfının yaşamını ve sıkıntılarını yakından tanıma fırsatı buldu. Babası dönünce eğitimini tamamladı. Önce bir avukatla, sonra liberal bir gazetede çalıştı. Mister Pickwick’in Serüvenleri (1837) adlı ilk romanı çok tutuldu. Ardından gelen Oliver Twist önce yayın yönetmenliğini üstlendiği bir dergide tefrika edildi. Bunu Nicholas Nickleby, Antikacı Dükkânı ve Martin Chuzzlewit izledi. Bir Noel Şarkısı (1843) olağanüstü bir başarı elde etti. Dombey and Son, Dickens’ın romancılığında bir dönüm noktası oldu. David Copperfield’da, toplumsal sorunlardan çok kendi deneyimlerine ağırlık veren Dickens, İki Şehrin Hikâyesi ve Büyük Umutlar’la zirveye çıktı. Dickens’ın yapıtları, gerçekçi biçemin, düzyazı ustalığının, mizahi bir dehanın ve benzersiz edebî karakterlerin en önemli örnekleri olarak değerlendirildi. Dickens, 1870’te öldü.", " Charles Dickens" },
                    { 6, "Anton Çehov, 1860’ta, Taganrog’da, küçük bir taşra bakkalının oğlu olarak dünyaya geldi. Yunan ve Latin klasiklerini temel alan bir öğrenim gördü. 1879’da Moskova Tıp Fakültesi’ne girdi. 1884’te çeşitli hastanelerde görev almaya başladı ve Bukalemun başlıklı ilk öykü kitabı aynı yıl yayımlandı. Bu dönemde kısa oyunlar da yazdı ve İvanov (1887) adlı oyunuyla dram tekniği alanında Rus tiyatrosuna büyük yenilikler getirdi. “Alacakaranlık” adlı öykü kitabıyla Puşkin Ödülü’nü kazandı. Bozkır (1888) başlıklı uzun öyküsüyle büyük bir yazar olarak tanındı. Vanya Dayı (1897), Üç Kız Kardeş (1900), Vişne Bahçesi (1903) gibi büyük oyunlarını hayatının son yıllarında yarattı. 1904’te, eşi ünlü tiyatro oyuncusu Olga Knipper’le gittiği Badenweiler’da ölen Çehov, çarlık dönemindeki siyasi çıkmazları, basit insan yaşantılarını büyüteç altına almaktaki ustalığı, Tolstoy’u hayran bırakan yalın ve ölçülü biçemi, gelenekselliği aşan anlatım biçimiyle dünya edebiyatının ustaları arasına katıldı.", "Anton Çehov" },
                    { 7, "Jules Verne, 1828’de Fransa’nın Nantes şehrinde doğdu. Jules Verne kısa öyküler ve şiirler yazmaya başladığı yatılı okul döneminin ardından 1846’da hukuk öğrenimi görmek üzere Paris’e gitti. Yazarlığa, arkadaşı müzisyen Jean-Louis Aristide Hignard’la birlikte tiyatro oyunları yazarak başladı. İlk tiyatro eseri 12 Haziran 1850’de sahnelendi. 1852-1855’te bir Paris tiyatrosunda sekreterlik yaptı; komediler, operetler yazdı; kısa hikâyeler kaleme alıp dergilerde yayımlatmaya başladı. Üzerinde çalıştığı kitabı çeşitli yayıncılar tarafından reddedilen Jules Verne’in edebî kariyeri yayıncı Pierre-Jules Hetzel’le tanıştıktan sonra başladı. Balonla Beş Hafta 1863’te Hetzel tarafından yayımlandı ve bir anda büyük başarı kazandı. Jules Verne ömrü boyunca ardı ardına eser vermeyi sürdürdü. İlerleyen şeker hastalığı sonucu 1902’de kısmen görme yeteneğini kaybeden yazar, 24 Mart 1905’te Amiens’teki evinde hayatını kaybetti.", "Jules Verne" },
                    { 8, "Dünyaca ünlü yazarlardan olan Dan Brown 22 Haziran 1964 yılında Amerika’da doğmuştur. Annesi ilahiyat müzisyen, babası da matematik profesörü olan yazarın gençliği din ile bilim arasındaki çatışmanın olduğu bir ortamda geçmiştir.Amherst Kolejinden ve Philips Exeter Akademisinden mezun olmuştur. Öğrenim gördüğü okullarda İngilizce öğretmenliği yapmıştır ancak daha sonra yazar olma hayaliyle mesleğini bırakmıştır.Hep yazar olmanın hayalini kuran Dan Brown ilk kitabını 1996 yılında Digital Kale adıyla çıkarmıştır. Elektronik kitap listelerinde bir numaraya çıkan bu eserinde ulusal güvenlik ve sivil halk arasındaki ilişkiyi anlatmıştır.İkinci kitabı ise İhanet Noktası adlı eserdir. Bu kitabında da ahlak ve gizli teknolojiler hakkında bilgiler veren yazar tüm dünyada ses getirmiştir. Dan Brown’un en büyük eseri olan Melekler ve Şeytanlar’da bilim ve din çatışması ele alınmıştır. Bir gerilim romanıdır.", "Dan Brown" },
                    { 9, "ÖMER SEYFETTİN, 1884’te Balıkesir, Gönen’de doğdu. 1903’te Mekteb-i Harbiye’den mezun oldu. İzmir’e atanmışken Makedonya’da başlayan isyanı bastırmak üzere Selanik’e ve Manastır’a gönderildi, bu bölgede görev yaptı. Buradaki görevinde gösterdiği başarılardan dolayı iki liyakat madalyasıyla ödüllendirildi. İsyanın bastırılmasının ardından Kuşadası’na döndü. 1909 başında Selanik’te teğmen olarak görev yaptı. 31 Mart Vakası esnasında Hareket Ordusu subayı olarak İstanbul’a geldi. 1911’de askerlik mesleğinden istifa ederek Selanik’e yerleşti. Balkan Savaşı başlayınca yeniden askere alındı. 20 Ocak 1913’te Kanlıtepe’de Yunan ordusuna esir düştü. Atina yakınlarındaki Naflion kasabasında on ay kadar süren esirlik hayatı bitince 17 Aralık 1913’te İstanbul’a döndü. 1914’te askerlikten ikinci defa istifa etti. 6 Mart 1920’de İstanbul’da vefat edene kadar Da­rül­muallimin’de ve Kabataş Sultanisi’nde öğretmenlik yaptı. Ömer Seyfettin, ilerleyen yıllarda “hikâyeci” olarak ünlenmesine rağmen edebiyat hayatına şiirleriyle girdi. Ali Canip Yöntem ve Ziya Gökalp’la birlikte 1911’de Genç Kalemler dergisinde ortaya konulan Yeni Lisan hareketinin önemli temsilcisi oldu. Yazı ve hikâyeleriyle Türk dilinin sadeleşmesi hususunda gayret gösterdi.", "Ömer Seyfettin" },
                    { 10, "SABAHATTİN ALİ, 1907’de Gümülcine’nin Eğridere (bugün Ardino, Bulgaristan) kasabasında doğdu. Çocukluk yılları ve eğitim hayatı savaş şartlarında geçti. 1926’da İstanbul Öğretmen Okulu’ndan mezun olan Ali, Yozgat’ta bir yıl öğretmenlik yaptıktan sonra Milli Eğitim Bakanlığı bursuyla Almanya’ya gitti. 1928-1930 yıllarında Potsdam’da yaşadı. Türkiye’ye döndükten sonra okullarda Almanca dersleri verdi; Türk Dil Kurumu’nda ve Tercüme Odası’nda çalıştı, Kleist ve Hebbel gibi yazarlardan çeviriler yaptı. 1926’dan sonra dönemin çeşitli dergilerine yazdı,Değirmen (1935), Kağnı (1936), Ses (1937), Yeni Dünya (1943) ve Sırça Köşk (1947) adlı öykü kitaplarıyla çağdaş Türk öykücülüğünün seyrini değiştiren yazarlardan oldu. Modern ve sade üslubunu romanlarına da taşıyan yazar, Kuyucaklı Yusuf’ta (1937) taşra insanını ve İçimizdeki Şeytan’da (1940) dönemin aydınlarının dünyasını çarpıcı bir dille anlattı. Yıllara yayılan bir aşkı anlattığı son romanı Kürk Mantolu Madonna (1943) başyapıtı oldu. 1940’larda Markopaşa adlı mizah dergisini çıkardı; siyasi düşünceleri sebebiyle hapse girdi. 1948’de Avrupa’ya kaçmak istedi fakat anlaştığı kaçakçı tarafından Bulgaristan sınırında öldürüldü. Ali’nin pek çok şiiri bestelendi; öyküleri, romanları sahneye ve filmlere uyarlandı.", "Sabahattin Ali" }
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "BookID", "BookName", "Image", "Pages", "Price", "Summary", "WriterID" },
                values: new object[,]
                {
                    { 1, "Suç ve Ceza", "sucvecezakapak-1620229164.jpg", (short)452, 68m, "Dostoyevski’nin Rusya’yı, Rus halkını gözlemleyerek içlerinden çekip çıkardığı Raskolnikov hem yazarın hem de edebiyat tarihinin en karanlık karakteridir. Yoksulluğunun güzel ve parlak bir hayat kurmasına izin vermeyeceğine inanan genç bir hukuk öğrencisinin, yaşlı tefeci kadını öldürüp parasını çalmayı planlamasıyla başlayan hikâyesi, Raskolnikov’un ikilemlerinden, iç çatışmalarından hareketle insanlığa sorduğu ahlaki ve felsefi sorularla edebiyatı başka bir boyuta taşımıştır. Suç ve Ceza yayımlandığı 1866 tarihinden bu yana, modern insana yaklaşımıyla ve sorduğu can alıcı sorularla güncelliğini hiç kaybetmediği gibi, edebiyatın çıtasını erişilmesi güç bir seviyeye yükseltmiştir. Dostoyevski’nin dehasını tüm yönleriyle yansıttığı roman, bir suçun psikolojik kaydıdır aynı zamanda. “Aşkı ilk defa yaşamak gibi, denizi ilk defa görmek gibi, Dostoyevski’ yi keşfetmek de insanın hayatında önemli bir tarihtir.", 4 },
                    { 2, "Karamazov Kardeşler", "karamazovkardeşler.jpg", (short)652, 96m, "Karamazov Kardeşler, edebiyat tarihinde çok az romana nasip olmuş bir üne sahip. Klasik Rus edebiyatının dev yazarı Dostoyevski’nin bu son romanı, Rusya’nın ruhunu simgeleyen temsilcileriyle Karamazov ailesine odaklanmış, ama girmedik alan, değinmedik konu bırakmamış: din, ahlak, baba katli, şiddet, Doğu-Batı sorunu, sınıf mücadelesi, feodalizm, sosyalizm… Dostoyevski’nin, “Hiçbir romanımı bu kadar önemsemedim,” dediği Karamazov Kardeşler, daha yayımlandığı tarihten itibaren kült bir eser haline gelmiş ve tüm dünyada büyük tartışmalara yol açmıştır; XX. yüzyılın temel yazınsal izleklerini belirlemiş ve pek çok yazarı peşinden sürüklemiştir. Kitabın yayımlanmasından kısa bir süre sonra ölen Dostoyevski, tıpkı Suç ve Ceza’da olduğu gibi bu kitabında da insanlığın evrensel sorunlarını ortaya koyar. Karamazov Kardeşler, bu anlamda “kuyuya atılmış bir taş” kadar etkili bir yapıt olarak önemini koruyor. Türkiye’den 20 çağdaş fotoğrafçı Can Klasikleri’nin bu özel dizisi için 20 kitabın kapak fotoğrafını özgün yorumlarıyla hazırladı.", 4 },
                    { 3, "Ulysses", "ulysses.jpg", (short)325, 87m, "James Joyce’un modern epiği Ulysses tek bir günde, 16 Haziran 1904’te Dublin’de geçer ve reklam ajanı Leopold Bloom, yazar olma düşleri kuran Stephen Dedalus ve Leopold’un karısı Molly’nin başından geçenleri anlatır. Bu üç karakterin düşünceleri, hayalleri ve şehir içindeki hareketleri üzerine kurulan roman, bir yanıyla yenilikçi, iddialı bir modernist deney, öbür yanıyla gündelik hayatın ayrıntılarına merakla eğilen gerçekçi bir yapıttır.", 3 },
                    { 4, "Savaş ve Barış", "savasvebaris.jpg", (short)1180, 120m, "Savaş ve Barış, klasik dendiğinde akla gelen ilk kitaplardan. Napolyon’un Rusya’yı işgalini anlatan dev bir savaş romanı, aynı zamanda bir Rusya panoraması. 1800’lerin ortalarında Rusya’nın içinde bulunduğu sosyal ve ekonomik koşullar, kentlerde, köy ve kasabalarda, büyük çiftliklerde sürdürülen hayat, dönemin önde gelen kişilikleri, saray yaşamı, özellikle üst sınıf ustaca çiziliyor.Tolstoy, birinci cildin önsözünde Savaş ve Barış’ı yazarken hissettiklerini, yaptığı zorlu çalışmaları ve romanın geçirdiği aşamaları anlatıyor. Bu metinler, özellikle bu dev romana yazarının gözünden, daha yakından bakma fırsatı verdiği için çok önemli.Elinizdeki çeviri, Savaş ve Barış’ın, dönemin Maarif Vekâleti’nin Zeki Baştımar’a ısmarladığı, 1943-1949 yılları arasında yapılan eksiksiz çevirisi. Zeki Baştımar bu çeviriyi o sırada Bursa’da hapiste olan Nâzım Hikmet’le birlikte yaptığı halde, bilinen siyasi nedenlerle Nazım’ın adı hiçbir zaman kitapta yer almadı. Bugün bu çeviri Baştımar ailesinin de isteği üzerine iki çevirmen adıyla yayımlanırken metne, günümüz için eskimiş ve anlaşılması güçleşmiş sözcüklerin yenileştirilmesi dışında dokunmamaya özen gösterildi; ilk baskılardaki Harb ve Sulh yerine, eserin yıllardır alışılmış yeni adı Savaş ve Barış tercih edildi.", 1 },
                    { 5, "Anne Karenina", "annakarenina.jpg", (short)685, 78m, "Ne yapalım? dedi kendi kendine, kararlı bir şekilde. “Bu ne demek? Bu meseleye dosdoğru yaklaşmaktan korkuyor muyum? Ne yani? Bu genç subayla aramızda, diğer tanıdıklarımla ilişkimden başka bir ilişki mi var, böyle bir şey olabilir mi?” Küçümsercesine gülümsedi ve yeniden kitabı aldı ama artık okuduğunu kesinlikle anlamıyordu. Kitap açacağını cama tuttu, sonra onun pürüzsüz, soğuk yüzeyini yanağına koydu ve onu nedensizce saran ani bir mutlulukla neredeyse duyulacak şekilde güldü. Sinirlerinin iki çivi arasında gerdirilen bir tel gibi gittikçe daha çok gerildiğini hissediyordu.Anna Karenina, tüm dünyada roman denince ilk akla gelen iki-üç kitaptan biri. Tolstoy’un eşsiz bir gözlem gücüyle Moskova ve Petersburg soylu yaşamına odaklandığı eser, 19. yüzyıl Rusya gerçekliği ve önemli toplumsal sentezlerle örülü. Aynı zamanda aşka ve ilişkilere dair yazılmış belki de en başarılı roman olan Anna Karenina’da Tolstoy, zengin karakter ağıyla dönemin insan haritasını çıkarıyor.", 1 },
                    { 6, "Hamlet", "hamlet.jpg", (short)200, 49m, "Hamlet, William Shakespeare tarafından 1599-1601 yılları arasında yazıldığına inanılan bir trajedidir. Oyunun konusu Hamlet'in babasını öldüren, annesiyle evlenen ve Danimarka tahtına geçen amcası Caludius'tan intikam alma çabasıdır. Oyun gerçek bir kederden bir gazaba dönüşen hayatı, yapmacık bir delilikle gerçek delilik arasındaki geçişleri, ensest ilişkileri, ihaneti, öfkeyi, ahlaksızlığı ele alır.", 2 },
                    { 7, "İki Şehrin Hikayesi", "ikişehrinhikayesi.jpg", (short)567, 74m, "Dünya edebiyatının en önemli yapıtlarından olan İki Şehrin Hikâyesi, Paris ve Londra arasında gelişen olay kurgusuyla, tarihin en hareketli anlarından birinin, Fransız Devrimi’nin ekseni etrafında biçimlenir. Edebiyat dünyasının “Dickens’ın en büyük tarihî romanı”, yazarın kendisinin ise “yazdığım en iyi hikâye” diye tanımladıkları yapıt, Fransız Devrimi’nin Terör döneminde, Paris’in öfkeli, kana bulanmış sokaklarında, giyotinin gölgesinde yaşamak zorunda kalan bir grup insanın hayatına odaklanır. On sekiz yıl yattığı Bastille Hapishanesi’nden çıkan Doktor Manette’ le, İngiltere’ye gönderdiği kızının Londra’da sürdürdükleri yaşamları, yollarının tekrar Paris’e düşmesiyle iradeleri dışında bir seyir kazanır. Sürükleyici gerilimi, güçlü lirizmiyle devrimi, toplumsal mücadeleyi, zalimliği, yoksulluğu ve aşkı çağının nabzını da tutarak olanca ihtişamıyla anlatan İki Şehrin Hikâyesi, bu nitelikleriyle hem klasik edebiyatın zirvelerinden hem de tarihin en güçlü hikâyelerinden biridir.", 5 },
                    { 8, "Üç Kız Kardeş", "uckızkardeş.jpg", (short)156, 26m, "Çağdaşı, oyun yazarı Sergey Naidyonov, Çehov’a yazdığı bir mektupta Üç Kız Kardeş’ten söz eder: “Oyunu izledikten sonra birden yaşama, yazma, daha çok çalışma isteğine kapıldım… oysa oyun acı ve kederle doluydu. Tuhaf, iyimser… teskin edici bir acı.”Çehov Üç Kız Kardeş’te 20. yüzyılın başında Rusya’da ayrıcalıklı sınıfların inişe geçmesiyle yüzleşmeye çalışan aristokrat Prozorov ailesinin öyküsünü anlatır. Moskova’da büyümüş üç kız kardeş; Olga, Mâşa ve İrina on bir yıldır küçük bir taşra kasabasında yaşamaktadır. İnce zevklerine ve duyarlıklarına daha uygun bir hayat düşlerini simgeleyen Moskova’ya dönüş umutları, amansızca akıp giden gerçek hayatla dokunaklı bir tezat içindedir.Yazılışından bir yıl sonra, 1901’de Moskova Sanat Tiyatrosu tarafından sahnelenen Üç Kız Kardeş modern tiyatronun kilometretaşlarından biridir.", 6 },
                    { 9, "Seksen Günde Devri Alem", "sekengündedevrialem.jpg", (short)120, 24m, "Phileas Fogg, son derece dakik bir insandı. Asla acele etmez, her adımını hesaplar ve hep en pratik yolu seçerdi. Reform Kulübü’ndeki arkadaşlarıyla sadece seksen günde dünyayı dolaşabileceğine dair servetinin yarısı üzerine bahse girince tüm hayatı değişti.Fogg başlamak üzere olduğu destansı seyahat hakkında çok az şey biliyordu. Tek bildiği sadık hizmetkârı Passepartout’yla kimi zaman bir filin sırtında, bazen bir trenin kompartımanında, belki de buharlı bir geminin güvertesinde bu yolculuğu tamamlamaya çalışacaklarıydı.", 7 },
                    { 10, "Başlangıç", "baslangic.jpg", (short)514, 99m, "Genç adam, aniden üç büyük dinin temsilcilerine döndü. “Şaşırtıcı bulacağınızı tahmin ettiğim bilimsel bir buluşum sebebiyle bugün buradayım. İnsanlık deneyimimizin en temel iki sorusuna cevap bulma ümidi ile yıllardır peşinden koşuyordum. Bu bilginin tüm inananları derinden etkileyeceğine inanıyorum. Nasıl desem, ‘yıkıcı’ diye tanımlanabilecek bir değişikliğe sebep olabilir. Birazdan görecekleriniz, dünyayla paylaşmayı umduğum sunumun kaba bir kesiti. Fakat bunu yapmadan önce dünyanın en etkili din adamlarına danışmak, en çok etkilenecek kişilerce nasıl algılanacağını öğrenmek istedim.”", 8 },
                    { 11, "Kaşağı", "kasagi.jpg", (short)85, 20m, "Ömer ve kardeşi Hasan, çocukluklarını büyük bir çiftlikte geçirmişlerdi. Küçük Ömer ve Hasan, en çok atlarla oynamayı, özellikle de onları tımar etmeyi seviyorlardı. Bunun için İstanbul’dan özel getirtilen KAŞAĞI’yı kullanıyorlardı. Ama bir gün Küçük Ömer, çocukluk heyecanıyla KAŞAĞI’yı kırar ve suçu kardeşi Hasan’a atar. Babası bu olaydan sonra Hasan’a çok kızar ve ona:-Yalancı, der..Hasan, bu olaydan sonra içine kapanır ve bir gün hastalanır. İşte o zaman Ömer için zor günler başlar.", 9 },
                    { 12, "Yanlız Efe", "yanlızefe.jpg", (short)100, 22m, "Türk edebiyatının ölümsüz yazarlarından Ömer Seyfettin tarihimize ve kültürümüze ayna tutar. Onun hikâyelerinde kendimizden bir şeyler buluruz. Onu okumak, onu anlamak, onunla mazinin şanlı sayfalarında gezinmek, çocukluk günlerimize dönmek mümkündür. Onun satırlarında bizi ve kültürümüzü hor görenlere ince bir alayla, en güzel şekilde verilmiş cevapları bulabiliriz. Onun düşünce ve idealleriyle ufkumuzu donatabiliriz. Bütün bunlar için yapılması gereken onun hikâyelerini elimize alıp satırların dünyasına yolculuk yapmak...", 9 },
                    { 13, "Kürk Mantolu Madonna", "kurkmantolumadonna.jpg", (short)132, 25m, "Hüzünlü bir aşk öyküsü olan Kürk Mantolu Madonna, iki hikayeden oluşan bir anlatıma sahip. İlk hikayede Rasim adlı karakterin iş bulması ve Raif Efendi ile tanışması anlatılıyor. Kimseler ile konuşmayan sessiz sakin Raif Efendi’yi gözlemleyen ve onu daha yakından tanımak isteyen Rasim’in anlatımı ile Raif Efendi’yi dinliyoruz. Onun neden bu kadar yalnız ve topluma yabancı olduğunu ise kendisinin kaleme aldığı siyah kaplı defter aracılığı ile ikinci hikayede öğreniyoruz. İkinci hikaye Raif Efendi’nin kimselere söylemediği ve anlatmadığı bir aşk hikayesi ile başlıyor. Gençlik yıllarına gittiğimiz bu defterde Raif Efendi’nin Almanya’da bir resim sergisinde Maria Puder ile tanışması ve sonrasında birbirlerine aşık olmasının hikayesi içinde bir anda kendimizi buluyoruz.", 10 },
                    { 14, "Ulysses", "ulysses.jpg", (short)132, 25m, "Ulysses", 3 },
                    { 15, "Jules Caesar", "julescaesar.jpg", (short)132, 25m, "Jules Caesar", 2 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Book_Categories_BookID",
                table: "Book_Categories",
                column: "BookID");

            migrationBuilder.CreateIndex(
                name: "IX_Book_Categories_CategoryID",
                table: "Book_Categories",
                column: "CategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_Books_WriterID",
                table: "Books",
                column: "WriterID");

            migrationBuilder.CreateIndex(
                name: "IX_Carts_BookID",
                table: "Carts",
                column: "BookID");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_BookID",
                table: "Comments",
                column: "BookID");

            migrationBuilder.CreateIndex(
                name: "IX_InvoiceDetails_BookID",
                table: "InvoiceDetails",
                column: "BookID");

            migrationBuilder.CreateIndex(
                name: "IX_InvoiceDetails_InvoiceID",
                table: "InvoiceDetails",
                column: "InvoiceID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Book_Categories");

            migrationBuilder.DropTable(
                name: "Carts");

            migrationBuilder.DropTable(
                name: "Comments");

            migrationBuilder.DropTable(
                name: "InvoiceDetails");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Books");

            migrationBuilder.DropTable(
                name: "Invoices");

            migrationBuilder.DropTable(
                name: "Writers");
        }
    }
}
