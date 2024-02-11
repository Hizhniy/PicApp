using PicApp.Data.Tables;
using System;
using System.Collections.Generic;
using System.Text;

namespace PicApp.Data
{
    public class CreatePhotos
    {      
        public CreatePhotos()
        {
            Create();
        }

        public async void Create()
        {
            Photo photo1 = new Photo() { Id = new Guid("c8480673-eed3-4097-b009-6ec7c4df33c8"), Name = "Земля", Image = "photo1.png", Date = "2024-02-11" };
            Photo photo2 = new Photo() { Id = new Guid("afd6d515-e09c-4fc4-a4b9-998d2cc4ca70"), Name = "Марс", Image = "photo2.png", Date = "2024-02-11" };
            Photo photo3 = new Photo() { Id = new Guid("f55e0320-34b4-490c-969b-02116111d04b"), Name = "Солнце", Image = "photo3.png", Date = "2024-02-11" };
            Photo photo4 = new Photo() { Id = new Guid("48434525-75ec-4693-a296-22666b9cdb20"), Name = "Сатурн", Image = "photo4.png", Date = "2024-02-11" };
            Photo photo5 = new Photo() { Id = new Guid("219363b0-69ae-458a-9824-a232ce995fe0"), Name = "Юпитер", Image = "photo5.png", Date = "2024-02-11" };
        }
    }
}
