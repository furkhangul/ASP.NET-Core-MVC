MetaData Kullanım amacı

      Biz modelimizdeki sınıf tek bir amaç için kullanmamız kod sağlığını ve düzenini önemli derecede etkileyeceğinden dolayı
      ana model tablomuzda yalnızca değişkenleri koymamız beklenir.
      Ekstra olarak koyacağımız validationlar ise metadata'da saklanması kodun sağlığını ve okunabilirliğini arttırır.
      MetaData Dışında FluentValidation ile de bu işlemler gerçekleştirilebilir.
      Gözden kaçırılmaması gereken nokta ise ana modelimizin üzerinde MetaDatayı tanımlamamız gerekmektedir.

      [MetadataType(TypeOf(Sınıf_adı)] şeklinde sınıfın önüne getirilmesi gerekmektedir.
