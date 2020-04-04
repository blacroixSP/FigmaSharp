﻿/* 
 * CustomTextFieldConverter.cs
 * 
 * Author:
 *   Jose Medrano <josmed@microsoft.com>
 *
 * Copyright (C) 2018 Microsoft, Corp
 *
 * Permission is hereby granted, free of charge, to any person obtaining
 * a copy of this software and associated documentation files (the
 * "Software"), to deal in the Software without restriction, including
 * without limitation the rights to use, copy, modify, merge, publish,
 * distribute, sublicense, and/or sell copies of the Software, and to permit
 * persons to whom the Software is furnished to do so, subject to the
 * following conditions:
 * 
 * The above copyright notice and this permission notice shall be included in
 * all copies or substantial portions of the Software.
 *
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS
 * OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
 * MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN
 * NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM,
 * DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR
 * OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE
 * USE OR OTHER DEALINGS IN THE SOFTWARE.
 */

using System.Linq;
using System.Text;

using AppKit;

using FigmaSharp.Cocoa;
using FigmaSharp.Models;
using FigmaSharp.Services;
using FigmaSharp.Views;
using FigmaSharp.Views.Cocoa;

namespace FigmaSharp.NativeControls.Cocoa
{
	public class TextViewConverter : FigmaNativeControlConverter
	{
		public override bool CanConvert(FigmaNode currentNode)
		{
			return currentNode.TryGetNativeControlType(out var value) && (value == NativeControlType.TextView);
		}

		protected override IView OnConvertToView(FigmaNode currentNode, ProcessedNode parent, FigmaRendererService rendererService)
		{
			var figmaInstance = (FigmaFrameEntity)currentNode;

			figmaInstance.TryGetNativeControlType(out var controlType);
			ITextBox textBox = new TextBox();
			var view = (NSTextView)textBox.NativeObject;

			view.Configure(currentNode);
			view.AlphaValue = figmaInstance.opacity;

			figmaInstance.TryGetNativeControlComponentType(out var controlComponentType);
			switch (controlComponentType)
			{
				case NativeControlComponentType.TextViewSmall:
				case NativeControlComponentType.TextViewSmallDark:
					//view.ControlSize = NSControlSize.Small;
					break;
			}

			var texts = figmaInstance.children
				.OfType<FigmaText>();

			var text = texts.FirstOrDefault(s => s.name == "lbl" && s.visible);
			if (text != null)
			{
				textBox.Text = text.characters;
				//view.Configure (text);
			}

			return textBox;
		}

		protected override StringBuilder OnConvertToCode(FigmaCodeNode currentNode, FigmaCodeNode parentNode, FigmaCodeRendererService rendererService)
		{
			var instance = (FigmaFrameEntity)currentNode.Node;
			var name = currentNode.Name;

			var builder = new StringBuilder();
			/*
			if (rendererService.NeedsRenderConstructor (currentNode, parentNode))
				builder.WriteConstructor (name, typeof (NSTextField));

			builder.Configure (instance, name);

			var texts = instance.children.OfType<FigmaText> ();

			var figmaTextNode = texts.FirstOrDefault (s => s.name == "lbl" && s.visible);

			if (figmaTextNode != null) {
				var text = figmaTextNode.characters ?? string.Empty;
				builder.WriteEquality (name, nameof (NSTextField.StringValue), text, true);
				//builder.Configure (figmaTextNode, name);
			}

			var placeholderTextNode = texts.FirstOrDefault (s => s.name == "placeholder");
			if (placeholderTextNode != null && !placeholderTextNode.characters.Equals("Placeholder", StringComparison.InvariantCultureIgnoreCase))
				builder.WriteEquality(name, nameof(NSTextField.PlaceholderString), placeholderTextNode.characters, true);
				*/
			return builder;
		}
	}
}