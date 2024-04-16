using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Newsletter.Domain.Events;
public sealed record BlogEvent(
    Guid BlogId) : INotification;
