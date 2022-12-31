
$(document).ready(function () {

    var arrLang = {

        'tr': {

            '0': 'Ana Sayfa',
            '1': 'Tüm Bloglar',
            '2': 'Giriş',
            '3': 'Seyahat Otobüsü',
            '4': 'Tüm Bloglar',
            '5': 'Son Paylaşımlar',
            '6': 'Paylaşımlardan haberdar olmak için bültene kayıt olun.',
            '7': 'Hakkımızda',
            '8': 'İletişim',
            '9': 'Sayfalar',
            '10': 'Abone ol',
            '11': "Paylaşımlardan haberdar olmak için bültene kayıt olun.",
            '12': 'Giriş',
            '13': 'Giriş Yap',
            '14': 'Kayıt Ol',
            '15': 'Websiteye git',
            '16': 'Kullanıcı Kayıt',
            '17': 'Kayıt Ol',
            '18': 'Yazarlar',
            '19': 'Yorumlar',
            '20': 'Kategoriler',
            '21': 'Çıkış',
            '22': 'Blog Listesi',
            '23': 'Başlık',
            '24': 'Kategori',
            '25': 'Sil',
            '26': 'Yorumlar',
            '27': 'Detaylar',
            '28': 'Yeni Blog Ekle',
            '29': 'Yazar',
            '30': 'Kullanıcı adı:',
            '31': 'Şifre:',
            '32': 'Düzenle',
            '33': 'Yayınlanmış Yorumlar',
            '34': 'Yorumu Sil',
            '35': 'Kategori Listesi',
            '36': 'Kategori Adı',
            '37': 'Düzenle',
            '38': 'Sil',
            '39': 'Yeni kategori ekle',
            '40': 'Kaydet',
            '41': 'Kategori Güncelleme',
            '42': 'Kategori ID(Değiştirmeyiniz!)',
            '43': 'Güncelle',
            '44': 'Yazar ID(Değiştirmeyiniz!)',
            '45': 'İsim Soyisim',
            '46': 'Yazar Güncelleme',
            '47': 'Yazar',
            '48': 'Yeni Blog Ekle',
            '49': 'Blog Başlığı',
            '50': 'Kategori',
            '51': 'Tarih (dd.mm.yyyy)*',
            '52': 'Yazar*',
            '53': '1.Fotoğraf URL',
            '54': 'İçerik 1.Paragraf (min 200 karakter)',
            '55': 'Kaydet',
            '56': 'Yorum bırakın',
            '57': 'Soru ve görüşlerinizi bizimle paylaşın...',
            '58': 'Gönder',
            '59': 'Henüz yorum yok. İlk yorumu siz yapın...'


        },


        'en': {
            '0': 'Home',
            '1': 'All Blogs',
            '2': 'Login',
            '3': 'Travel Bus',
            '4': 'All Blogs',
            '5': 'Recent Blogs',
            '6': 'Sign up for the newsletter to be informed about the shares.',
            '7': 'About us',
            '8': 'Contact',
            '9': 'Pages',
            '10': 'Subscribe Us',
            '11': 'Sign up for the newsletter to be informed about the shares',
            '12': 'Login',
            '13': 'Sign In',
            '14': 'Register',
            '15': 'Go to website',
            '16': 'User Register',
            '17': 'Sign Up',
            '18': 'Authors',
            '19': 'Comments',
            '20': 'Categories',
            '21': 'Exit',
            '22': 'Blog List',
            '23': 'Title',
            '24': 'Category',
            '25': 'Delete',
            '26': 'Comments',
            '27': 'Details',
            '28': 'Add New Blog',
            '29': 'Author',
            '30': 'Username:',
            '31': 'Password:',
            '32': 'Edit',
            '33': 'Posted Comments',
            '34': 'Delete Comment',
            '35': 'Category List',
            '36': 'Category Name',
            '37': 'Edit',
            '38': 'Delete',
            '39': 'Add new category',
            '40': 'Save',
            '41': 'Update Category',
            '42': 'Category ID(Do not change!)',
            '43': 'Update',
            '44': 'Author ID(Do not change!)',
            '45': 'Name Surname',
            '46': 'Update Author',
            '47': 'Author',
            '48': 'Add New Blog',
            '49': 'Blog Title',
            '50': 'Category',
            '51': 'Date (dd.mm.yyyy)*',
            '52': 'Author*',
            '53': '1.Photo URL',
            '54': 'Content 1.Paragraph (min 200 character)',
            '55': 'Save',
            '56': 'Leave a domment',
            '57': 'Share your questions and opinions with us...',
            '58': 'Send',
            '59': 'There are no comments yet. Make the first comment...'


        },


    };



    $('.dp').click(function () {
        localStorage.setItem('dil', JSON.stringify($(this).attr('id')));
        location.reload();
    });

    var lang = JSON.parse(localStorage.getItem('dil'));

    if (lang == "en") {
        $("#drop_yazı").html("English");
    }
    else {
        $("#drop_yazı").html("Türkçe");

    }

    $('a,h5,p,h1,h4,h2,span,li,button,h3,th,label,b,div,p').each(function (index, element) {
        $(this).text(arrLang[lang][$(this).attr('key')]);

    });

});
