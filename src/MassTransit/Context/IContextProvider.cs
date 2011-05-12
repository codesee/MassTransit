﻿// Copyright 2007-2011 Chris Patterson, Dru Sellers, Travis Smith, et. al.
//  
// Licensed under the Apache License, Version 2.0 (the "License"); you may not use 
// this file except in compliance with the License. You may obtain a copy of the 
// License at 
// 
//     http://www.apache.org/licenses/LICENSE-2.0 
// 
// Unless required by applicable law or agreed to in writing, software distributed 
// under the License is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR 
// CONDITIONS OF ANY KIND, either express or implied. See the License for the 
// specific language governing permissions and limitations under the License.
namespace MassTransit.Context
{
	using System;

	/// <summary>
	/// A context provider is used to obtain context information about the message
	/// </summary>
	public interface IContextProvider
	{
		TContext ReceiveContext<TContext>(Action<TContext> contextAction)
			where TContext : IReceiveContext;

		/// <summary>
		/// Access the send context
		/// </summary>
		/// <typeparam name="TContext"></typeparam>
		/// <typeparam name="TMessage"></typeparam>
		/// <param name="message"></param>
		/// <param name="contextAction"></param>
		/// <returns></returns>
		TContext SendContext<TContext, TMessage>(TMessage message, Action<TContext> contextAction)
			where TContext : ISendContext<TMessage>
			where TMessage : class;
	}
}