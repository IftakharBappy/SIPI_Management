   M S B A M L   `   `   `  ����   SIPI_SL,    &SIPI_SL.UI.LibraryManagement.BookIssue   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35n jSAPBusinessObjects.WPF.ViewerShared, Version=13.0.3500.0, Culture=neutral, PublicKeyToken=692fbea5521e1304R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml       � Title$  Book Issue ��$	��547��$	��964�� � ShowInTaskbar .     	GrayWhite#��[   � WindowStartupLocation$ CenterScreen=�.��� .+��� $�� ��$��Center=�$��10,3,0,0q�$	��Top=�$	��936��$	��231��.��� .+��� $��ID��$
��Left=�$��	15,43,0,0q�$	��Top=�$	��100���� $��	Unique ID��$
��Left=�$��	15,69,0,0q�$	��Top=�$	��100���� $��Srudent Name��$
��Left=�$��	15,95,0,0q�$	��Top=�$	��100���� $��
Department��$
��Left=�$��
15,121,0,0q�$	��Top=�$	��100���� $��Semester��$
��Left=�$��
15,147,0,0q�$	��Top=�$	��100���� $��Session��$
��Left=�$��
15,173,0,0q�$	��Top=�$	��100���� -    ��Name$ pkIdTextBox��$
��Left=�$��26��$��
124,40,0,0q� �� TextWrapping$
 Wrap=�$	��Top=�{�.  $	��251���� -   $ uniqueIdTextBox��$
��Left=�$��26��$��
124,68,0,0q�$
 Wrap=�$	��Top=�{�.  $	��251���� -   $ nametextbox��$
��Left=�$��26��$��
124,96,0,0q�$
 Wrap=�$	��Top=�{�.  $	��251���� -   $ departmentStudentTextBox��$
��Left=�$��26��$��124,123,0,0q�$
 Wrap=�$	��Top=�{�.  $	��251���� -   $ semesterTextBox��$
��Left=�$��26��$��124,150,0,0q�$
 Wrap=�$	��Top=�{�.  $	��251���� -   $ sessionTextBox��$
��Left=�$��26��$��124,178,0,0q�$
 Wrap=�$	��Top=�{�.  $	��251���� -    ��Name$ listStudentButton��$��6q�$��List Of Student >>>��$
��Left=�$��10,6,0,0q�$	��Top=�$	��135��&   System.Windows.Controls.DataGrid  -     Name$ bookReceiveHistryDataGrid��   AutoGenerateColumns .  $	��164��$
��Left=�$��
380,40,0,0q�$	��Top=�$	��534��   CanUserAddRows .  	   Columns	 0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn
   
IsReadOnly
 .    Header$ 	Book Name��   Width5  /System.Windows.Controls.DataGridLengthConverter$
 Auto 1  +System.Windows.Controls.DataGridBoundColumn   Binding �� *
BookName+  
 . $ Book Id��$
 Auto  �� *BookId+  
 . $ Semester��$
 Auto  �� *
Semester+  
 . $ Book Quantity��$
 Auto  �� *
Quantity+  
 . $ Receive Date��$
 Auto  �� *ReceiveDate+  
 . $ Return Date��$
 Auto  �� *
ReturnDate+  
 . $ Book Return Satatus��$
 Auto  �� *BookReturnStatus+�� $��Center=�$��Book Viewer ��$��10,237,10,0q�$	��Top=�$	��238��.��� $��	0,10,-2,3q�$��Right=�$	��926��.+��� -	   $ 
bookPicker��$��6q�$��Book Picker >>>��$
��Left=�$��10,6,0,0q�$	��Top=�$	��135���� $��Program��$
��Left=�$��	47,42,0,0q�$	��Top=�$	��100���� $��
Department��$
��Left=�$��	47,68,0,0q�$	��Top=�$	��100���� $��	Book Name��$
��Left=�$��	47,94,0,0q�$	��Top=�$	��100���� $��Book Author��$
��Left=�$��
47,120,0,0q�$	��Top=�$	��100���� $��Book Edition��$
��Left=�$��
47,146,0,0q�$	��Top=�$	��100���� $��Published Year��$
��Left=�$��
47,172,0,0q�$	��Top=�$	��100���� $��Quantity��$
��Left=�$��
412,39,0,0q�$	��Top=�$��86���� $��Self No��$
��Left=�$��
412,67,0,0q�$	��Top=�$��86���� $��Book ID��$
��Left=�$��
412,94,0,0q�$	��Top=�$��86���� -
   $ programTextBox��$
��Left=�$��26��$��
156,39,0,0q�$
 Wrap=�$	��Top=�{�.  $	��251���� -   $ departmentTextBox��$
��Left=�$��26��$��
156,67,0,0q�$
 Wrap=�$	��Top=�{�.  $	��251���� -   $ bookNametextbox��$
��Left=�$��26��$��
156,95,0,0q�$
 Wrap=�$	��Top=�{�.  $	��251���� -   $ bookAuthorTextBox��$
��Left=�$��26��$��156,122,0,0q�$
 Wrap=�$	��Top=�{�.  $	��251���� -   $ bookEditionTextBox��$
��Left=�$��26��$��156,149,0,0q�$
 Wrap=�$	��Top=�{�.  $	��251���� -   $ bookPublishedYearTextBox��$
��Left=�$��26��$��156,177,0,0q�$
 Wrap=�$	��Top=�{�.  $	��251���� -   $ quantityTextbox��$
��Left=�$��26��$��
472,39,0,0q�$
 Wrap=�$	��Top=�{�.  $	��125���� -   $ selfNoTextbox��$
��Left=�$��26��$��
472,67,0,0q�$
 Wrap=�$	��Top=�{�.  $	��125���� -   $ bookPkIdTextbox��$
��Left=�$��26��$��
472,95,0,0q�$
 Wrap=�$	��Top=�{�.  $	��125���� -   $��addBooklistView��$	��156��$
��Left=�$��
609,42,0,0q�$	��Top=�$	��307�� � ContextMenu �� -   $��ZoneIformationList�� �� 	StaysOpen . 
������� J� BitmapEffect �� .@�m� -   $��RemoveContextMenu��$��Remove�� �� View ��  �� AllowsColumnReorder . .P��� $��Book Id�� �� Width$
 Auto�� �� DisplayMemberBinding ��  �� Path$ Id��� $��	Book Name��$
 Auto�� �� $ BookName��� $��Book Quantity��$
 Auto�� �� $ Quantity��� -   $��bookAddDataGrid��$��3q�$��ADD >>>��$
��Left=�$��507,177,0,0q�$	��Top=�$��90��$��25���� -   $ bookRemoveDataGrid��$��3q�$��REMOVE��$
��Left=�$��417,177,0,0q�$	��Top=�$��90��$��25���� $��Receive Date��$��419,9,429,0q�$	��Top=�(  "System.Windows.Controls.DatePicker  -   $��receiveDatePicker��$��507,12,317,0q�$	��Top=��� $��Return Date��$��609,9,244,0q�$	��Top=�  -   $��returnDateDatePicker��$��687,12,137,0q�$	��Top=��� -   $��quentatyMessageLable��$�� ��$
��Left=�$��
156,10,0,0q�$	��Top=�$	��251���� -   $��bookIssueButton��$��4q�$
��Bold"�$��BOOK  ISSUE��$
��Left=�$��835,480,0,0q�$	��Top=�$��90��$��26��