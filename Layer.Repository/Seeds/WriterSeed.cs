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
    internal class WriterSeed:IEntityTypeConfiguration<Writer>
    {
        public void Configure(EntityTypeBuilder<Writer> builder)
        {
            builder.HasData(
                new Writer
                {
                    Id = 1,
                    Name = "Lev Tolstoy",
                    Biography = "Tolstoy Rusya'nın Polyana şehrinde dünyaya gelmiştir. 1828 yılında oldukça varlıklı bir ailenin çocuğu olarak dünyaya elen Tolstoy küçük yaşlardan itibaren annesiz babasız olarak büyüdü. Henüz daha çocukken önce annesini daha sonra da babasını kaybetti. Tolstoy babası ve annesi vefat ettikten sonra yakınlarının yanına yerleşmiş ve yetişmeye başlamıştır. Tolstoy küçük yaşlardan itibaren Fransızcayı da öğrenmiştir. Fransızcayı öğrendikten sonra Fransız yazarlardan olan Voltaire ve Jack Roussa'nun eserlerini orijinalinden okumuştur.Tolstoy yetişkin olduktan sonra orduya katılmıştır. Rus ordusu ile birlikte Kafkasya'ya gitmiştir Kafkasya'da gözlemlediklerini de eserlerine eklemiştir. Daha sonra ilk kez 1854 yılında Kırım savaşına katılmıştır. Kırım savaşına katılınca subay olarak görev yapıyordu. Askerliği bittikten sonra Petersburg'a gitmiştir. Burada da bir ev tutup pek çok eser yazmıştır."
                },
                new Writer { Id = 2, Name = "William Shakespeare", Biography = "Birçok sözü oldukça bilinen Shakespeare sözleri oldukça beğenilmektedir. Tüm dünyada ünlü bir yazar olan William Shakespeare' in özellikle aşk üzerine anlamlı sözlerini sizlerde paylaşabilirsiniz. Bu anlamlı Shakespeare sözleri: William Shakespeare'in aşk ve hayat üzerine en anlamlı sözlerini sizler için derledik.William Shakespeare (1564-1616) dünyaca tanınan en büyük yazarlardan biri olarak kabul edilmektedir. Hayat, aşk gibi konularda oyun, sone ve öykü tarzında şiirleri bulunmaktadır.Tüm dünyanın tanımış olduğu yazarın en anlamlı sözlerini sosyal platformlarda resimli olarak kolaylıkla paylaşabilirsiniz. En anlamlı Shakespeare Sözlerini paylaşarak düşüncelerinizi yansıtabilirsiniz." },
                new Writer { Id = 3, Name = "James Joyce ", Biography = "Batı Edebiyatı’nın önemli yazarlarından olan James Joyce 1882 yılında İrlanda-Dublin’de Kanada göçmeni bir ailenin çocuğu olarak dünyaya gelmiştir." },
                new Writer { Id = 4, Name = "Fyodor Dostoyevski ", Biography = "Dostoyevski 1821'de Moskova'da, yoksul bir evde doğdu. Doğar doğmaz yakasına yapışan yoksulluk, bir ömür boyu peşini bırakmadı. Doktorluk yapan alkolik, sinirli bir baba ve hasta bir annenin yanında mutsuz bir çocukluk geçirdi. Altı çocuklu ailenin ikinci çocuğuydu. Genç yaşta tüberküloz hastalığı yüzünden önce annesini, sonra babasını kaybetti. Babasının ölümünü kendisi istediği düşüncesi yüzünden depresyona girdi. Epilepsi hastalığı da bu yıllarda ortaya çıktı." },
                new Writer { Id = 5, Name = " Charles Dickens", Biography = "Charles Dickens, 1812’de İngiltere’nin Portsmouth kentinde doğdu. Babası hapse düşünce okuldan ayrılıp bir fabrikada çalışmak zorunda kaldı. Bu dönemde işçi sınıfının yaşamını ve sıkıntılarını yakından tanıma fırsatı buldu. Babası dönünce eğitimini tamamladı. Önce bir avukatla, sonra liberal bir gazetede çalıştı. Mister Pickwick’in Serüvenleri (1837) adlı ilk romanı çok tutuldu. Ardından gelen Oliver Twist önce yayın yönetmenliğini üstlendiği bir dergide tefrika edildi. Bunu Nicholas Nickleby, Antikacı Dükkânı ve Martin Chuzzlewit izledi. Bir Noel Şarkısı (1843) olağanüstü bir başarı elde etti. Dombey and Son, Dickens’ın romancılığında bir dönüm noktası oldu. David Copperfield’da, toplumsal sorunlardan çok kendi deneyimlerine ağırlık veren Dickens, İki Şehrin Hikâyesi ve Büyük Umutlar’la zirveye çıktı. Dickens’ın yapıtları, gerçekçi biçemin, düzyazı ustalığının, mizahi bir dehanın ve benzersiz edebî karakterlerin en önemli örnekleri olarak değerlendirildi. Dickens, 1870’te öldü." },
                new Writer { Id = 6, Name = "Anton Çehov", Biography = "Anton Çehov, 1860’ta, Taganrog’da, küçük bir taşra bakkalının oğlu olarak dünyaya geldi. Yunan ve Latin klasiklerini temel alan bir öğrenim gördü. 1879’da Moskova Tıp Fakültesi’ne girdi. 1884’te çeşitli hastanelerde görev almaya başladı ve Bukalemun başlıklı ilk öykü kitabı aynı yıl yayımlandı. Bu dönemde kısa oyunlar da yazdı ve İvanov (1887) adlı oyunuyla dram tekniği alanında Rus tiyatrosuna büyük yenilikler getirdi. “Alacakaranlık” adlı öykü kitabıyla Puşkin Ödülü’nü kazandı. Bozkır (1888) başlıklı uzun öyküsüyle büyük bir yazar olarak tanındı. Vanya Dayı (1897), Üç Kız Kardeş (1900), Vişne Bahçesi (1903) gibi büyük oyunlarını hayatının son yıllarında yarattı. 1904’te, eşi ünlü tiyatro oyuncusu Olga Knipper’le gittiği Badenweiler’da ölen Çehov, çarlık dönemindeki siyasi çıkmazları, basit insan yaşantılarını büyüteç altına almaktaki ustalığı, Tolstoy’u hayran bırakan yalın ve ölçülü biçemi, gelenekselliği aşan anlatım biçimiyle dünya edebiyatının ustaları arasına katıldı." },
                new Writer { Id = 7, Name = "Jules Verne", Biography = "Jules Verne, 1828’de Fransa’nın Nantes şehrinde doğdu. Jules Verne kısa öyküler ve şiirler yazmaya başladığı yatılı okul döneminin ardından 1846’da hukuk öğrenimi görmek üzere Paris’e gitti. Yazarlığa, arkadaşı müzisyen Jean-Louis Aristide Hignard’la birlikte tiyatro oyunları yazarak başladı. İlk tiyatro eseri 12 Haziran 1850’de sahnelendi. 1852-1855’te bir Paris tiyatrosunda sekreterlik yaptı; komediler, operetler yazdı; kısa hikâyeler kaleme alıp dergilerde yayımlatmaya başladı. Üzerinde çalıştığı kitabı çeşitli yayıncılar tarafından reddedilen Jules Verne’in edebî kariyeri yayıncı Pierre-Jules Hetzel’le tanıştıktan sonra başladı. Balonla Beş Hafta 1863’te Hetzel tarafından yayımlandı ve bir anda büyük başarı kazandı. Jules Verne ömrü boyunca ardı ardına eser vermeyi sürdürdü. İlerleyen şeker hastalığı sonucu 1902’de kısmen görme yeteneğini kaybeden yazar, 24 Mart 1905’te Amiens’teki evinde hayatını kaybetti." },
                new Writer { Id = 8, Name = "Dan Brown", Biography = "Dünyaca ünlü yazarlardan olan Dan Brown 22 Haziran 1964 yılında Amerika’da doğmuştur. Annesi ilahiyat müzisyen, babası da matematik profesörü olan yazarın gençliği din ile bilim arasındaki çatışmanın olduğu bir ortamda geçmiştir.Amherst Kolejinden ve Philips Exeter Akademisinden mezun olmuştur. Öğrenim gördüğü okullarda İngilizce öğretmenliği yapmıştır ancak daha sonra yazar olma hayaliyle mesleğini bırakmıştır.Hep yazar olmanın hayalini kuran Dan Brown ilk kitabını 1996 yılında Digital Kale adıyla çıkarmıştır. Elektronik kitap listelerinde bir numaraya çıkan bu eserinde ulusal güvenlik ve sivil halk arasındaki ilişkiyi anlatmıştır.İkinci kitabı ise İhanet Noktası adlı eserdir. Bu kitabında da ahlak ve gizli teknolojiler hakkında bilgiler veren yazar tüm dünyada ses getirmiştir. Dan Brown’un en büyük eseri olan Melekler ve Şeytanlar’da bilim ve din çatışması ele alınmıştır. Bir gerilim romanıdır." },
                new Writer { Id = 9, Name = "Ömer Seyfettin", Biography = "ÖMER SEYFETTİN, 1884’te Balıkesir, Gönen’de doğdu. 1903’te Mekteb-i Harbiye’den mezun oldu. İzmir’e atanmışken Makedonya’da başlayan isyanı bastırmak üzere Selanik’e ve Manastır’a gönderildi, bu bölgede görev yaptı. Buradaki görevinde gösterdiği başarılardan dolayı iki liyakat madalyasıyla ödüllendirildi. İsyanın bastırılmasının ardından Kuşadası’na döndü. 1909 başında Selanik’te teğmen olarak görev yaptı. 31 Mart Vakası esnasında Hareket Ordusu subayı olarak İstanbul’a geldi. 1911’de askerlik mesleğinden istifa ederek Selanik’e yerleşti. Balkan Savaşı başlayınca yeniden askere alındı. 20 Ocak 1913’te Kanlıtepe’de Yunan ordusuna esir düştü. Atina yakınlarındaki Naflion kasabasında on ay kadar süren esirlik hayatı bitince 17 Aralık 1913’te İstanbul’a döndü. 1914’te askerlikten ikinci defa istifa etti. 6 Mart 1920’de İstanbul’da vefat edene kadar Da­rül­muallimin’de ve Kabataş Sultanisi’nde öğretmenlik yaptı. Ömer Seyfettin, ilerleyen yıllarda “hikâyeci” olarak ünlenmesine rağmen edebiyat hayatına şiirleriyle girdi. Ali Canip Yöntem ve Ziya Gökalp’la birlikte 1911’de Genç Kalemler dergisinde ortaya konulan Yeni Lisan hareketinin önemli temsilcisi oldu. Yazı ve hikâyeleriyle Türk dilinin sadeleşmesi hususunda gayret gösterdi." },
                 new Writer { Id = 10, Name = "Sabahattin Ali", Biography = "SABAHATTİN ALİ, 1907’de Gümülcine’nin Eğridere (bugün Ardino, Bulgaristan) kasabasında doğdu. Çocukluk yılları ve eğitim hayatı savaş şartlarında geçti. 1926’da İstanbul Öğretmen Okulu’ndan mezun olan Ali, Yozgat’ta bir yıl öğretmenlik yaptıktan sonra Milli Eğitim Bakanlığı bursuyla Almanya’ya gitti. 1928-1930 yıllarında Potsdam’da yaşadı. Türkiye’ye döndükten sonra okullarda Almanca dersleri verdi; Türk Dil Kurumu’nda ve Tercüme Odası’nda çalıştı, Kleist ve Hebbel gibi yazarlardan çeviriler yaptı. 1926’dan sonra dönemin çeşitli dergilerine yazdı,Değirmen (1935), Kağnı (1936), Ses (1937), Yeni Dünya (1943) ve Sırça Köşk (1947) adlı öykü kitaplarıyla çağdaş Türk öykücülüğünün seyrini değiştiren yazarlardan oldu. Modern ve sade üslubunu romanlarına da taşıyan yazar, Kuyucaklı Yusuf’ta (1937) taşra insanını ve İçimizdeki Şeytan’da (1940) dönemin aydınlarının dünyasını çarpıcı bir dille anlattı. Yıllara yayılan bir aşkı anlattığı son romanı Kürk Mantolu Madonna (1943) başyapıtı oldu. 1940’larda Markopaşa adlı mizah dergisini çıkardı; siyasi düşünceleri sebebiyle hapse girdi. 1948’de Avrupa’ya kaçmak istedi fakat anlaştığı kaçakçı tarafından Bulgaristan sınırında öldürüldü. Ali’nin pek çok şiiri bestelendi; öyküleri, romanları sahneye ve filmlere uyarlandı." });
        }
    }
}