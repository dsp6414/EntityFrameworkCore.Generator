using System;
using FluentValidation;
using Tracker.PostgreSQL.Core.Domain.Models;

namespace Tracker.PostgreSQL.Core.Domain.Validation
{
    public partial class TaskUpdateModelValidator
        : AbstractValidator<TaskUpdateModel>
    {
        public TaskUpdateModelValidator()
        {
            #region Generated Constructor
            RuleFor(p => p.Title).NotEmpty();
            RuleFor(p => p.Title).MaximumLength(255);
            RuleFor(p => p.CreatedBy).MaximumLength(100);
            RuleFor(p => p.UpdatedBy).MaximumLength(100);
            #endregion
        }

    }
}
