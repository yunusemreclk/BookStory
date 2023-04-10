﻿using Layer.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Layer.Repository.Seeds
{
    internal class BookSeed:IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {

            builder.HasData(
             new Book { Id = 1, Name = "Suç ve Ceza", WriterID = 4, Image = "sucvecezakapak-1620229164.jpg", Summary = "Dostoyevski’nin Rusya’yı, Rus halkını gözlemleyerek içlerinden çekip çıkardığı Raskolnikov hem yazarın hem de edebiyat tarihinin en karanlık karakteridir. Yoksulluğunun güzel ve parlak bir hayat kurmasına izin vermeyeceğine inanan genç bir hukuk öğrencisinin, yaşlı tefeci kadını öldürüp parasını çalmayı planlamasıyla başlayan hikâyesi, Raskolnikov’un ikilemlerinden, iç çatışmalarından hareketle insanlığa sorduğu ahlaki ve felsefi sorularla edebiyatı başka bir boyuta taşımıştır. Suç ve Ceza yayımlandığı 1866 tarihinden bu yana, modern insana yaklaşımıyla ve sorduğu can alıcı sorularla güncelliğini hiç kaybetmediği gibi, edebiyatın çıtasını erişilmesi güç bir seviyeye yükseltmiştir. Dostoyevski’nin dehasını tüm yönleriyle yansıttığı roman, bir suçun psikolojik kaydıdır aynı zamanda. “Aşkı ilk defa yaşamak gibi, denizi ilk defa görmek gibi, Dostoyevski’ yi keşfetmek de insanın hayatında önemli bir tarihtir.", Pages = 452, Price = 68 },

            new Book { Id = 2, Name = "Karamazov Kardeşler", WriterID = 4, Image = "karamazovkardeşler.jpg", Summary = "Karamazov Kardeşler, edebiyat tarihinde çok az romana nasip olmuş bir üne sahip. Klasik Rus edebiyatının dev yazarı Dostoyevski’nin bu son romanı, Rusya’nın ruhunu simgeleyen temsilcileriyle Karamazov ailesine odaklanmış, ama girmedik alan, değinmedik konu bırakmamış: din, ahlak, baba katli, şiddet, Doğu-Batı sorunu, sınıf mücadelesi, feodalizm, sosyalizm… Dostoyevski’nin, “Hiçbir romanımı bu kadar önemsemedim,” dediği Karamazov Kardeşler, daha yayımlandığı tarihten itibaren kült bir eser haline gelmiş ve tüm dünyada büyük tartışmalara yol açmıştır; XX. yüzyılın temel yazınsal izleklerini belirlemiş ve pek çok yazarı peşinden sürüklemiştir. Kitabın yayımlanmasından kısa bir süre sonra ölen Dostoyevski, tıpkı Suç ve Ceza’da olduğu gibi bu kitabında da insanlığın evrensel sorunlarını ortaya koyar. Karamazov Kardeşler, bu anlamda “kuyuya atılmış bir taş” kadar etkili bir yapıt olarak önemini koruyor. Türkiye’den 20 çağdaş fotoğrafçı Can Klasikleri’nin bu özel dizisi için 20 kitabın kapak fotoğrafını özgün yorumlarıyla hazırladı.", Pages = 652, Price = 96 },
            new Book { Id = 3, Name = "Ulysses", WriterID = 3, Image = "ulysses.jpg", Summary = "James Joyce’un modern epiği Ulysses tek bir günde, 16 Haziran 1904’te Dublin’de geçer ve reklam ajanı Leopold Bloom, yazar olma düşleri kuran Stephen Dedalus ve Leopold’un karısı Molly’nin başından geçenleri anlatır. Bu üç karakterin düşünceleri, hayalleri ve şehir içindeki hareketleri üzerine kurulan roman, bir yanıyla yenilikçi, iddialı bir modernist deney, öbür yanıyla gündelik hayatın ayrıntılarına merakla eğilen gerçekçi bir yapıttır.", Pages = 325, Price = 87 },
            new Book { Id = 4, Name = "Savaş ve Barış", WriterID = 1, Image = "savasvebaris.jpg ", Summary = "Savaş ve Barış, “klasik” dendiğinde akla gelen ilk kitaplardan. Napoléon’un Rusya’yı işgalini anlatan dev bir savaş romanı, aynı zamanda bir Rusya panoraması. 1800’lerin ortalarında Rusya’nın içinde bulunduğu sosyal ve ekonomik koşullar, kentlerde, köy ve kasabalarda, büyük çiftliklerde sürdürülen hayat, dönemin önde gelen kişilikleri, saray yaşamı, özellikle üst sınıf ustaca çiziliyor.Tolstoy, birinci cildin önsözünde Savaş ve Barış’ı yazarken hissettiklerini, yaptığı zorlu çalışmaları ve romanın geçirdiği aşamaları anlatıyor. Bu metinler, özellikle bu dev romana yazarının gözünden, daha yakından bakma fırsatı verdiği için çok önemli.Elinizdeki çeviri, Savaş ve Barış’ın, dönemin Maarif Vekâleti’nin Zeki Baştımar’a ısmarladığı, 1943-1949 yılları arasında yapılan eksiksiz çevirisi. Zeki Baştımar bu çeviriyi o sırada Bursa’da hapiste olan Nâzım Hikmet’le birlikte yaptığı halde, bilinen siyasi nedenlerle Nâzım’ın adı hiçbir zaman kitapta yer almadı. Bugün bu çeviri Baştımar ailesinin de isteği üzerine iki çevirmen adıyla yayımlanırken metne, günümüz için eskimiş ve anlaşılması güçleşmiş sözcüklerin yenileştirilmesi dışında dokunmamaya özen gösterildi; ilk baskılardaki Harb ve Sulh yerine, eserin yıllardır alışılmış yeni adı Savaş ve Barış tercih edildi.", Pages = 1180, Price = 120 },
            new Book { Id = 5, Name = "Anne Karenina", WriterID = 1, Image = "annakarenina.jpg", Summary = "“Ne yapalım?” dedi kendi kendine, kararlı bir şekilde. “Bu ne demek? Bu meseleye dosdoğru yaklaşmaktan korkuyor muyum? Ne yani? Bu genç subayla aramızda, diğer tanıdıklarımla ilişkimden başka bir ilişki mi var, böyle bir şey olabilir mi?” Küçümsercesine gülümsedi ve yeniden kitabı aldı ama artık okuduğunu kesinlikle anlamıyordu. Kitap açacağını cama tuttu, sonra onun pürüzsüz, soğuk yüzeyini yanağına koydu ve onu nedensizce saran ani bir mutlulukla neredeyse duyulacak şekilde güldü. Sinirlerinin iki çivi arasında gerdirilen bir tel gibi gittikçe daha çok gerildiğini hissediyordu.Anna Karenina, tüm dünyada roman denince ilk akla gelen iki-üç kitaptan biri. Tolstoy’un eşsiz bir gözlem gücüyle Moskova ve Petersburg soylu yaşamına odaklandığı eser, 19. yüzyıl Rusya gerçekliği ve önemli toplumsal sentezlerle örülü. Aynı zamanda aşka ve ilişkilere dair yazılmış belki de en başarılı roman olan Anna Karenina’da Tolstoy, zengin karakter ağıyla dönemin insan haritasını çıkarıyor.", Pages = 685, Price = 78 },
            new Book { Id = 6, Name = "", WriterID = 2, Image = "hamlet.jpg", Summary = "Hamlet, William Shakespeare tarafından 1599-1601 yılları arasında yazıldığına inanılan bir trajedidir. Oyunun konusu Hamlet'in babasını öldüren, annesiyle evlenen ve Danimarka tahtına geçen amcası Caludius'tan intikam alma çabasıdır. Oyun gerçek bir kederden bir gazaba dönüşen hayatı, yapmacık bir delilikle gerçek delilik arasındaki geçişleri, ensest ilişkileri, ihaneti, öfkeyi, ahlaksızlığı ele alır.", Pages = 200, Price = 49 },
            new Book { Id = 7, Name = "İki Şehrin Hikayesi", WriterID = 5, Image = "ikişehrinhikayesi.jpg", Summary = "Dünya edebiyatının en önemli yapıtlarından olan İki Şehrin Hikâyesi, Paris ve Londra arasında gelişen olay kurgusuyla, tarihin en hareketli anlarından birinin, Fransız Devrimi’nin ekseni etrafında biçimlenir. Edebiyat dünyasının “Dickens’ın en büyük tarihî romanı”, yazarın kendisinin ise “yazdığım en iyi hikâye” diye tanımladıkları yapıt, Fransız Devrimi’nin Terör döneminde, Paris’in öfkeli, kana bulanmış sokaklarında, giyotinin gölgesinde yaşamak zorunda kalan bir grup insanın hayatına odaklanır. On sekiz yıl yattığı Bastille Hapishanesi’nden çıkan Doktor Manette’ le, İngiltere’ye gönderdiği kızının Londra’da sürdürdükleri yaşamları, yollarının tekrar Paris’e düşmesiyle iradeleri dışında bir seyir kazanır. Sürükleyici gerilimi, güçlü lirizmiyle devrimi, toplumsal mücadeleyi, zalimliği, yoksulluğu ve aşkı çağının nabzını da tutarak olanca ihtişamıyla anlatan İki Şehrin Hikâyesi, bu nitelikleriyle hem klasik edebiyatın zirvelerinden hem de tarihin en güçlü hikâyelerinden biridir.", Pages = 567, Price = 74 },
            new Book { Id = 8, Name = "Üç Kız Kardeş", WriterID = 6, Image = "uckızkardeş.jpg", Summary = "Çağdaşı, oyun yazarı Sergey Naidyonov, Çehov’a yazdığı bir mektupta Üç Kız Kardeş’ten söz eder: “Oyunu izledikten sonra birden yaşama, yazma, daha çok çalışma isteğine kapıldım… oysa oyun acı ve kederle doluydu. Tuhaf, iyimser… teskin edici bir acı.”Çehov Üç Kız Kardeş’te 20. yüzyılın başında Rusya’da ayrıcalıklı sınıfların inişe geçmesiyle yüzleşmeye çalışan aristokrat Prozorov ailesinin öyküsünü anlatır. Moskova’da büyümüş üç kız kardeş; Olga, Mâşa ve İrina on bir yıldır küçük bir taşra kasabasında yaşamaktadır. İnce zevklerine ve duyarlıklarına daha uygun bir hayat düşlerini simgeleyen Moskova’ya dönüş umutları, amansızca akıp giden gerçek hayatla dokunaklı bir tezat içindedir.Yazılışından bir yıl sonra, 1901’de Moskova Sanat Tiyatrosu tarafından sahnelenen Üç Kız Kardeş modern tiyatronun kilometretaşlarından biridir.", Pages = 156, Price = 26 },
            new Book { Id = 9, Name = "Seksen Günde Devri Alem", WriterID = 7, Image = "sekengündedevrialem.jpg", Summary = "Phileas Fogg, son derece dakik bir insandı. Asla acele etmez, her adımını hesaplar ve hep en pratik yolu seçerdi. Reform Kulübü’ndeki arkadaşlarıyla sadece seksen günde dünyayı dolaşabileceğine dair servetinin yarısı üzerine bahse girince tüm hayatı değişti.Fogg başlamak üzere olduğu destansı seyahat hakkında çok az şey biliyordu. Tek bildiği sadık hizmetkârı Passepartout’yla kimi zaman bir filin sırtında, bazen bir trenin kompartımanında, belki de buharlı bir geminin güvertesinde bu yolculuğu tamamlamaya çalışacaklarıydı.", Pages = 120, Price = 24 },
            new Book { Id = 10, Name = "Başlangıç", WriterID = 8, Image = "baslangic.jpg", Summary = "Genç adam, aniden üç büyük dinin temsilcilerine döndü. “Şaşırtıcı bulacağınızı tahmin ettiğim bilimsel bir buluşum sebebiyle bugün buradayım. İnsanlık deneyimimizin en temel iki sorusuna cevap bulma ümidi ile yıllardır peşinden koşuyordum. Bu bilginin tüm inananları derinden etkileyeceğine inanıyorum. Nasıl desem, ‘yıkıcı’ diye tanımlanabilecek bir değişikliğe sebep olabilir. Birazdan görecekleriniz, dünyayla paylaşmayı umduğum sunumun kaba bir kesiti. Fakat bunu yapmadan önce dünyanın en etkili din adamlarına danışmak, en çok etkilenecek kişilerce nasıl algılanacağını öğrenmek istedim.”", Pages = 514, Price = 99 },
            new Book { Id = 11, Name = "Kaşağı", WriterID = 9, Image = "kasagi.jpg", Summary = "Ömer ve kardeşi Hasan, çocukluklarını büyük bir çiftlikte geçirmişlerdi. Küçük Ömer ve Hasan, en çok atlarla oynamayı, özellikle de onları tımar etmeyi seviyorlardı. Bunun için İstanbul’dan özel getirtilen KAŞAĞI’yı kullanıyorlardı. Ama bir gün Küçük Ömer, çocukluk heyecanıyla KAŞAĞI’yı kırar ve suçu kardeşi Hasan’a atar. Babası bu olaydan sonra Hasan’a çok kızar ve ona:-Yalancı, der..Hasan, bu olaydan sonra içine kapanır ve bir gün hastalanır. İşte o zaman Ömer için zor günler başlar.", Pages = 85, Price = 20 },
            new Book { Id = 12, Name = "Yanlız Efe", WriterID = 9, Image = "yanlızefe.jpg", Summary = "Türk edebiyatının ölümsüz yazarlarından Ömer Seyfettin tarihimize ve kültürümüze ayna tutar. Onun hikâyelerinde kendimizden bir şeyler buluruz. Onu okumak, onu anlamak, onunla mazinin şanlı sayfalarında gezinmek, çocukluk günlerimize dönmek mümkündür. Onun satırlarında bizi ve kültürümüzü hor görenlere ince bir alayla, en güzel şekilde verilmiş cevapları bulabiliriz. Onun düşünce ve idealleriyle ufkumuzu donatabiliriz. Bütün bunlar için yapılması gereken onun hikâyelerini elimize alıp satırların dünyasına yolculuk yapmak...", Pages = 100, Price = 22 },
            new Book { Id = 13, Name = "Kürk Mantolu Madonna", WriterID = 10, Image = "kurkmantolumadonna.jpg", Summary = "Hüzünlü bir aşk öyküsü olan Kürk Mantolu Madonna, iki hikayeden oluşan bir anlatıma sahip. İlk hikayede Rasim adlı karakterin iş bulması ve Raif Efendi ile tanışması anlatılıyor. Kimseler ile konuşmayan sessiz sakin Raif Efendi’yi gözlemleyen ve onu daha yakından tanımak isteyen Rasim’in anlatımı ile Raif Efendi’yi dinliyoruz. Onun neden bu kadar yalnız ve topluma yabancı olduğunu ise kendisinin kaleme aldığı siyah kaplı defter aracılığı ile ikinci hikayede öğreniyoruz. İkinci hikaye Raif Efendi’nin kimselere söylemediği ve anlatmadığı bir aşk hikayesi ile başlıyor. Gençlik yıllarına gittiğimiz bu defterde Raif Efendi’nin Almanya’da bir resim sergisinde Maria Puder ile tanışması ve sonrasında birbirlerine aşık olmasının hikayesi içinde bir anda kendimizi buluyoruz.", Pages = 132, Price = 25 }

            );
        }
    }
}

