﻿using PhoneBookCore.Model;

namespace PhoneBook.Interface.UseCase
{
    public  interface IDeleteUseCase
    {

        void Handle(Contact c);
    }
}