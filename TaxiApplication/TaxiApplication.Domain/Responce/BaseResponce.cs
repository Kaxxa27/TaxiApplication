﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaxiApplication.Domain.Enum;

namespace TaxiApplication.Domain.Responce;

public class BaseResponce<T>
{
	public string Description { get; set; } = string.Empty;

	public StatusCode StatusCode { get; set; }

	public T Data { get; set; }

}