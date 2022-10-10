using Core.Entities.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün Eklendi.";
        public static string ProductNameInvalid = "Ürün İsmi Geçersiz.";
        public static string MaintenanceTime="Sistem Bakımda";
        public static string ProductsListed="Ürün Listelendi";
        public static string ProductCountOfCategoryError= "Bir kategoride en falza 15 ürün bulundurulabilir.";
        public static string ProductNameAlreadyExists="Bu isimde mevcut başka bir ürünümüz var.";
        public static string CategoryLimitExceded="Kategori limiti aşıldığı için yeni ürün eklenemez.";
        public static string AuthorizationDenied="Bu işlem için yetkiniz yok.";
        public static string UserRegistered="Kayot oldunuz.";
        public static string UserNotFound="Kullanıcı bulunamadı.";
        public static string SuccessfulLogin="Başarılı Giriş.";
        public static string UserAlreadyExists="Kullanıcı Mevcut.";
        public static string PasswordError="Parola Hatası.";
        public static string AccessTokenCreated="Token oluşturuldu.";
    }
}
