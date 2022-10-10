using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class SongValidator : AbstractValidator<Song>
    {
        public SongValidator()
        {
            RuleFor(s => s.SongName).MinimumLength(1); // song name min length must be 1 letter
            RuleFor(s => s.SongName).NotEmpty();
            RuleFor(s => s.Duration).NotEmpty();
            RuleFor(s => s.Duration).GreaterThan(0);
        }
    }
}
