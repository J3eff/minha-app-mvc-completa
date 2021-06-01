﻿using FluentValidation.Results;

namespace DevIO.Business.Services
{
    public abstract class BaseService
    {
        protected void Notificar(ValidationResult validationResult)
        {
            foreach( var error in validationResult.Errors)
            {
                Notificar(error.ErrorMessage);
            }
        }

        protected void Notificar(string mensagem)
        {
            //Propagar esse erro até a camada de apresentação
        }

        protected bool ExecutarValidacao()
        {
            return true;
        }
    }
}