/* Generated by Myra UI Editor at 03.12.2018 0:39:28 */
using Microsoft.Xna.Framework;
using Myra.Graphics2D.UI;

namespace Myra.UIEditor.UI
{
	partial class StudioWidget
	{
		private void BuildUI()
		{
			_menuFileNew = new MenuItem();
			_menuFileNew.Id = "_menuFileNew";
			_menuFileNew.Text = "&New";

			_menuFileOpen = new MenuItem();
			_menuFileOpen.Id = "_menuFileOpen";
			_menuFileOpen.Text = "&Open";

			_menuFileReload = new MenuItem();
			_menuFileReload.Id = "_menuFileReload";
			_menuFileReload.Text = "&Reload";

			_menuFileSave = new MenuItem();
			_menuFileSave.Id = "_menuFileSave";
			_menuFileSave.Text = "&Save";

			_menuFileSaveAs = new MenuItem();
			_menuFileSaveAs.Id = "_menuFileSaveAs";
			_menuFileSaveAs.Text = "Save &As...";

			_menuFileExportToCS = new MenuItem();
			_menuFileExportToCS.Id = "_menuFileExportToCS";
			_menuFileExportToCS.Text = "&Export To C#...";

			var menuSeparator1 = new MenuSeparator();

			_menuFileLoadStylesheet = new MenuItem();
			_menuFileLoadStylesheet.Id = "_menuFileLoadStylesheet";
			_menuFileLoadStylesheet.Text = "&Load Stylesheet";

			_menuFileReloadStylesheet = new MenuItem();
			_menuFileReloadStylesheet.Id = "_menuFileReloadStylesheet";
			_menuFileReloadStylesheet.Text = "Rel&oad Stylesheet";

			_menuFileResetStylesheet = new MenuItem();
			_menuFileResetStylesheet.Id = "_menuFileResetStylesheet";
			_menuFileResetStylesheet.Text = "Rese&t Stylesheet";

			var menuSeparator2 = new MenuSeparator();

			_menuFileDebugOptions = new MenuItem();
			_menuFileDebugOptions.Id = "_menuFileDebugOptions";
			_menuFileDebugOptions.Text = "&UI Debug Options";

			var menuSeparator3 = new MenuSeparator();

			_menuFileQuit = new MenuItem();
			_menuFileQuit.Id = "_menuFileQuit";
			_menuFileQuit.Text = "&Quit";

			var menuItem1 = new MenuItem();
			menuItem1.Id = "";
			menuItem1.Text = "&File";
			menuItem1.Items.Add(_menuFileNew);
			menuItem1.Items.Add(_menuFileOpen);
			menuItem1.Items.Add(_menuFileReload);
			menuItem1.Items.Add(_menuFileSave);
			menuItem1.Items.Add(_menuFileSaveAs);
			menuItem1.Items.Add(_menuFileExportToCS);
			menuItem1.Items.Add(menuSeparator1);
			menuItem1.Items.Add(_menuFileLoadStylesheet);
			menuItem1.Items.Add(_menuFileReloadStylesheet);
			menuItem1.Items.Add(_menuFileResetStylesheet);
			menuItem1.Items.Add(menuSeparator2);
			menuItem1.Items.Add(_menuFileDebugOptions);
			menuItem1.Items.Add(menuSeparator3);
			menuItem1.Items.Add(_menuFileQuit);

			_menuControlsAddButton = new MenuItem();
			_menuControlsAddButton.Id = "_menuControlsAddButton";
			_menuControlsAddButton.Text = "Add Button";

			_menuControlsAddCheckBox = new MenuItem();
			_menuControlsAddCheckBox.Id = "_menuControlsAddCheckBox";
			_menuControlsAddCheckBox.Text = "Add CheckBox";

			_menuControlsAddImageButton = new MenuItem();
			_menuControlsAddImageButton.Id = "_menuControlsAddImageButton";
			_menuControlsAddImageButton.Text = "Add ImageButton";

			_menuControlsAddTextButton = new MenuItem();
			_menuControlsAddTextButton.Id = "_menuControlsAddTextButton";
			_menuControlsAddTextButton.Text = "Add TextButton";

			_menuControlsAddHorizontalSlider = new MenuItem();
			_menuControlsAddHorizontalSlider.Id = "_menuControlsAddHorizontalSlider";
			_menuControlsAddHorizontalSlider.Text = "Add Horizontal Slider";

			_menuControlsAddVerticalSlider = new MenuItem();
			_menuControlsAddVerticalSlider.Id = "_menuControlsAddVerticalSlider";
			_menuControlsAddVerticalSlider.Text = "Add Vertical Slider";

			_menuControlsAddHorizontalProgressBar = new MenuItem();
			_menuControlsAddHorizontalProgressBar.Id = "_menuControlsAddHorizontalProgressBar";
			_menuControlsAddHorizontalProgressBar.Text = "Add Horizontal ProgressBar";

			_menuControlsAddVerticalProgressBar = new MenuItem();
			_menuControlsAddVerticalProgressBar.Id = "_menuControlsAddVerticalProgressBar";
			_menuControlsAddVerticalProgressBar.Text = "Add Vertical ProgressBar";

			_menuControlsAddHorizontalSeparator = new MenuItem();
			_menuControlsAddHorizontalSeparator.Id = "_menuControlsAddHorizontalSeparator";
			_menuControlsAddHorizontalSeparator.Text = "Add Horizontal Separator";

			_menuControlsAddVerticalSeparator = new MenuItem();
			_menuControlsAddVerticalSeparator.Id = "_menuControlsAddVerticalSeparator";
			_menuControlsAddVerticalSeparator.Text = "Add Vertical Separator";

			_menuControlsAddComboBox = new MenuItem();
			_menuControlsAddComboBox.Id = "_menuControlsAddComboBox";
			_menuControlsAddComboBox.Text = "Add ComboBox";

			_menuControlsAddListBox = new MenuItem();
			_menuControlsAddListBox.Id = "_menuControlsAddListBox";
			_menuControlsAddListBox.Text = "Add ListBox";

			_menuControlsAddImage = new MenuItem();
			_menuControlsAddImage.Id = "_menuControlsAddImage";
			_menuControlsAddImage.Text = "Add Image";

			_menuControlsAddTextBlock = new MenuItem();
			_menuControlsAddTextBlock.Id = "_menuControlsAddTextBlock";
			_menuControlsAddTextBlock.Text = "Add TextBlock";

			_menuControlsAddTextField = new MenuItem();
			_menuControlsAddTextField.Id = "_menuControlsAddTextField";
			_menuControlsAddTextField.Text = "Add TextField";

			_menuControlsAddSpinButton = new MenuItem();
			_menuControlsAddSpinButton.Id = "_menuControlsAddSpinButton";
			_menuControlsAddSpinButton.Text = "Add SpinButton";

			var menuSeparator4 = new MenuSeparator();

			_menuControlsAddPanel = new MenuItem();
			_menuControlsAddPanel.Id = "_menuControlsAddPanel";
			_menuControlsAddPanel.Text = "Add Panel";

			_menuControlsAddGrid = new MenuItem();
			_menuControlsAddGrid.Id = "_menuControlsAddGrid";
			_menuControlsAddGrid.Text = "Add Grid";

			_menuControlsAddScrollPane = new MenuItem();
			_menuControlsAddScrollPane.Id = "_menuControlsAddScrollPane";
			_menuControlsAddScrollPane.Text = "Add ScrollPane";

			_menuControlsAddHorizontalSplitPane = new MenuItem();
			_menuControlsAddHorizontalSplitPane.Id = "_menuControlsAddHorizontalSplitPane";
			_menuControlsAddHorizontalSplitPane.Text = "Add Horizontal SplitPane";

			_menuControlsAddVerticalSplitPane = new MenuItem();
			_menuControlsAddVerticalSplitPane.Id = "_menuControlsAddVerticalSplitPane";
			_menuControlsAddVerticalSplitPane.Text = "Add Vertical SplitPane";

			_menuControlsAddWindow = new MenuItem();
			_menuControlsAddWindow.Id = "_menuControlsAddWindow";
			_menuControlsAddWindow.Text = "Add Window";

			_menuControlsAddDialog = new MenuItem();
			_menuControlsAddDialog.Id = "_menuControlsAddDialog";
			_menuControlsAddDialog.Text = "Add Dialog";

			var menuSeparator5 = new MenuSeparator();

			_menuControlsAddHorizontalMenu = new MenuItem();
			_menuControlsAddHorizontalMenu.Id = "_menuControlsAddHorizontalMenu";
			_menuControlsAddHorizontalMenu.Text = "Add HorizontalMenu";

			_menuControlsAddVerticalMenu = new MenuItem();
			_menuControlsAddVerticalMenu.Id = "_menuControlsAddVerticalMenu";
			_menuControlsAddVerticalMenu.Text = "Add Vertical Menu";

			_menuControlsAddMenuItem = new MenuItem();
			_menuControlsAddMenuItem.Id = "_menuControlsAddMenuItem";
			_menuControlsAddMenuItem.Text = "Add Menu Item";

			_menuControlsAddMenuSeparator = new MenuItem();
			_menuControlsAddMenuSeparator.Id = "_menuControlsAddMenuSeparator";
			_menuControlsAddMenuSeparator.Text = "Add Menu Separator";

			_menuControls = new MenuItem();
			_menuControls.Id = "_menuControls";
			_menuControls.Text = "&Controls";
			_menuControls.Items.Add(_menuControlsAddButton);
			_menuControls.Items.Add(_menuControlsAddCheckBox);
			_menuControls.Items.Add(_menuControlsAddImageButton);
			_menuControls.Items.Add(_menuControlsAddTextButton);
			_menuControls.Items.Add(_menuControlsAddHorizontalSlider);
			_menuControls.Items.Add(_menuControlsAddVerticalSlider);
			_menuControls.Items.Add(_menuControlsAddHorizontalProgressBar);
			_menuControls.Items.Add(_menuControlsAddVerticalProgressBar);
			_menuControls.Items.Add(_menuControlsAddHorizontalSeparator);
			_menuControls.Items.Add(_menuControlsAddVerticalSeparator);
			_menuControls.Items.Add(_menuControlsAddComboBox);
			_menuControls.Items.Add(_menuControlsAddListBox);
			_menuControls.Items.Add(_menuControlsAddImage);
			_menuControls.Items.Add(_menuControlsAddTextBlock);
			_menuControls.Items.Add(_menuControlsAddTextField);
			_menuControls.Items.Add(_menuControlsAddSpinButton);
			_menuControls.Items.Add(menuSeparator4);
			_menuControls.Items.Add(_menuControlsAddPanel);
			_menuControls.Items.Add(_menuControlsAddGrid);
			_menuControls.Items.Add(_menuControlsAddScrollPane);
			_menuControls.Items.Add(_menuControlsAddHorizontalSplitPane);
			_menuControls.Items.Add(_menuControlsAddVerticalSplitPane);
			_menuControls.Items.Add(_menuControlsAddWindow);
			_menuControls.Items.Add(_menuControlsAddDialog);
			_menuControls.Items.Add(menuSeparator5);
			_menuControls.Items.Add(_menuControlsAddHorizontalMenu);
			_menuControls.Items.Add(_menuControlsAddVerticalMenu);
			_menuControls.Items.Add(_menuControlsAddMenuItem);
			_menuControls.Items.Add(_menuControlsAddMenuSeparator);

			_menuHelpAbout = new MenuItem();
			_menuHelpAbout.Id = "_menuHelpAbout";
			_menuHelpAbout.Text = "&About";

			var menuItem2 = new MenuItem();
			menuItem2.Id = "";
			menuItem2.Text = "&Help";
			menuItem2.Items.Add(_menuHelpAbout);

			var horizontalMenu1 = new HorizontalMenu();
			horizontalMenu1.Id = "";
			horizontalMenu1.Items.Add(menuItem1);
			horizontalMenu1.Items.Add(_menuControls);
			horizontalMenu1.Items.Add(menuItem2);

			_projectHolder = new Panel();
			_projectHolder.Id = "_projectHolder";

			_explorerHolder = new Panel();
			_explorerHolder.Id = "_explorerHolder";

			_propertyGridPane = new ScrollPane();
			_propertyGridPane.Child = null;
			_propertyGridPane.Id = "_propertyGridPane";
			_propertyGridPane.GridPositionY = 2;

			_rightSplitPane = new VerticalSplitPane();
			_rightSplitPane.Id = "_rightSplitPane";
			_rightSplitPane.GridPositionX = 2;
			_rightSplitPane.Widgets.Add(_explorerHolder);
			_rightSplitPane.Widgets.Add(_propertyGridPane);

			_topSplitPane = new HorizontalSplitPane();
			_topSplitPane.Id = "_topSplitPane";
			_topSplitPane.GridPositionY = 1;
			_topSplitPane.Widgets.Add(_projectHolder);
			_topSplitPane.Widgets.Add(_rightSplitPane);

			
			RowsProportions.Add(new Grid.Proportion());
			RowsProportions.Add(new Grid.Proportion
			{
				Type = Myra.Graphics2D.UI.Grid.ProportionType.Fill,
			});
			Id = "Root";
			Widgets.Add(horizontalMenu1);
			Widgets.Add(_topSplitPane);
		}

		
		public MenuItem _menuFileNew;
		public MenuItem _menuFileOpen;
		public MenuItem _menuFileReload;
		public MenuItem _menuFileSave;
		public MenuItem _menuFileSaveAs;
		public MenuItem _menuFileExportToCS;
		public MenuItem _menuFileLoadStylesheet;
		public MenuItem _menuFileReloadStylesheet;
		public MenuItem _menuFileResetStylesheet;
		public MenuItem _menuFileDebugOptions;
		public MenuItem _menuFileQuit;
		public MenuItem _menuControlsAddButton;
		public MenuItem _menuControlsAddCheckBox;
		public MenuItem _menuControlsAddImageButton;
		public MenuItem _menuControlsAddTextButton;
		public MenuItem _menuControlsAddHorizontalSlider;
		public MenuItem _menuControlsAddVerticalSlider;
		public MenuItem _menuControlsAddHorizontalProgressBar;
		public MenuItem _menuControlsAddVerticalProgressBar;
		public MenuItem _menuControlsAddHorizontalSeparator;
		public MenuItem _menuControlsAddVerticalSeparator;
		public MenuItem _menuControlsAddComboBox;
		public MenuItem _menuControlsAddListBox;
		public MenuItem _menuControlsAddImage;
		public MenuItem _menuControlsAddTextBlock;
		public MenuItem _menuControlsAddTextField;
		public MenuItem _menuControlsAddSpinButton;
		public MenuItem _menuControlsAddPanel;
		public MenuItem _menuControlsAddGrid;
		public MenuItem _menuControlsAddScrollPane;
		public MenuItem _menuControlsAddHorizontalSplitPane;
		public MenuItem _menuControlsAddVerticalSplitPane;
		public MenuItem _menuControlsAddWindow;
		public MenuItem _menuControlsAddDialog;
		public MenuItem _menuControlsAddHorizontalMenu;
		public MenuItem _menuControlsAddVerticalMenu;
		public MenuItem _menuControlsAddMenuItem;
		public MenuItem _menuControlsAddMenuSeparator;
		public MenuItem _menuControls;
		public MenuItem _menuHelpAbout;
		public Panel _projectHolder;
		public Panel _explorerHolder;
		public ScrollPane _propertyGridPane;
		public VerticalSplitPane _rightSplitPane;
		public HorizontalSplitPane _topSplitPane;
	}
}