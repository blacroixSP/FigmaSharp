// WARNING
//
// This file has been generated automatically by Visual Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace FigmaSharpApp
{
	[Register ("DocumentWindowController")]
	partial class DocumentWindowController
	{
		[Outlet]
		AppKit.NSButton DarkModeButton { get; set; }

		[Outlet]
		AppKit.NSToolbar MainToolbar { get; set; }

		[Outlet]
		AppKit.NSPopUpButton PagePopUpButton { get; set; }

		[Outlet]
		AppKit.NSButton RefreshButton { get; set; }

		[Outlet]
		AppKit.NSToolbarItem Spinner { get; set; }

		[Outlet]
		AppKit.NSTextField TitleTextField { get; set; }

		[Outlet]
		AppKit.NSProgressIndicator ToolbarSpinner { get; set; }

		[Outlet]
		AppKit.NSToolbarItem WarningsButton { get; set; }

		[Action ("DarkModeClicked:")]
		partial void DarkModeClicked (Foundation.NSObject sender);

		[Action ("RefreshClicked:")]
		partial void RefreshClicked (Foundation.NSObject sender);

		[Action ("ToggleDarkModeClicked:")]
		partial void ToggleDarkModeClicked (Foundation.NSObject sender);

		[Action ("WarningsClicked:")]
		partial void WarningsClicked (Foundation.NSObject sender);
		
		void ReleaseDesignerOutlets ()
		{
			if (DarkModeButton != null) {
				DarkModeButton.Dispose ();
				DarkModeButton = null;
			}

			if (MainToolbar != null) {
				MainToolbar.Dispose ();
				MainToolbar = null;
			}

			if (PagePopUpButton != null) {
				PagePopUpButton.Dispose ();
				PagePopUpButton = null;
			}

			if (RefreshButton != null) {
				RefreshButton.Dispose ();
				RefreshButton = null;
			}

			if (Spinner != null) {
				Spinner.Dispose ();
				Spinner = null;
			}

			if (TitleTextField != null) {
				TitleTextField.Dispose ();
				TitleTextField = null;
			}

			if (ToolbarSpinner != null) {
				ToolbarSpinner.Dispose ();
				ToolbarSpinner = null;
			}

			if (WarningsButton != null) {
				WarningsButton.Dispose ();
				WarningsButton = null;
			}
		}
	}
}
