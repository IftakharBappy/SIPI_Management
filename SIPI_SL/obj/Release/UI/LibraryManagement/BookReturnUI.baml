   M S B A M L   `   `   `  ����   SIPI_SL/    )SIPI_SL.UI.LibraryManagement.BookReturnUI   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35n jSAPBusinessObjects.WPF.ViewerShared, Version=13.0.3500.0, Culture=neutral, PublicKeyToken=692fbea5521e1304R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml       � Title$  BookReturnUI��$	��547��$	��964�� � ShowInTaskbar .     	GrayWhite#��[   � WindowStartupLocation$ CenterScreen=�.��� .+��� $�� ��$��Center=�$��10,3,0,0q�$	��Top=�$	��936��$	��231��.��� .+��� $��ID��$
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
 Auto  �� *BookReturnStatus+�� $��Center=�$��Books Returned ��$��10,237,10,0q�$	��Top=�$	��238��.��� $��	0,10,-2,3q�$��Right=�$	��926��.+��� -	   $��bookListCombobox��$
��Left=�$��	156,5,0,0q�$	��Top=�$	��251��  ComboBoxBGYellowGreen#��[ ���� .R���  �� Orientation$ 
Horizontal=�.+��� $	��120������ *
BookName+�� $��Returnable Books��$
��Left=�$��47,9,0,0q�$	��Top=�$	��104���� $��	Book Name��$
��Left=�$��	47,43,0,0q�$	��Top=�$	��104���� $��Quantity��$
��Left=�$��
409,43,0,0q�$	��Top=�$��86���� $��Book ID��$
��Left=�$��
409,69,0,0q�$	��Top=�$��86���� -
   $ bookNametextbox��$
��Left=�$��26��$��
156,44,0,0q�$
 Wrap=�$	��Top=�{�.  $	��251���� -   $ quantityTextbox��$
��Left=�$��26��$��
477,43,0,0q�$
 Wrap=�$	��Top=�{�.  $	��125���� -   $ bookPkIdTextbox��$
��Left=�$��26��$��
477,70,0,0q�$
 Wrap=�$	��Top=�{�.  $	��125���� -   $��addBooklistView��$	��189��$
��Left=�$��	609,9,0,0q�$	��Top=�$	��307�� � ContextMenu �� -   $��ZoneIformationList�� �� 	StaysOpen . 
������� J� BitmapEffect �� .@�m� -   $��RemoveContextMenu��$��Remove�� �� View ��  �� AllowsColumnReorder . .P��� $��Book Id�� �� Width$
 Auto�� �� DisplayMemberBinding ��  �� Path$ Id��� $��	Book Name��$
 Auto�� �� $ BookName��� $��Book Quantity��$
 Auto�� �� $ Quantity��� $��
Entry Date��$
 Auto�� �� $ 	EntryDate��� $��
Delay Time��$
 Auto�� �� $ 	DelayTime��� -   $��bookAddDataGrid��$��3q�$��ADD >>>��$
��Left=�$��507,177,0,0q�$	��Top=�$��90��$��25���� -   $ bookRemoveDataGrid��$��3q�$��REMOVE��$
��Left=�$��417,177,0,0q�$	��Top=�$��90��$��25���� $��Receive Date��$��47,70,775,0q�$	��Top=�(  "System.Windows.Controls.DatePicker  -   $��receiveDatePicker��$��156,72,519,0q�$	��Top=�{�.  �� $��Return Date��$��47,96,775,0q�$	��Top=�  -   $��returnDateDatePicker��$��156,98,519,0q�$	��Top=�{�.  �� $��Today��$��409,8,444,0q�$	��Top=�  -     Name$ returnTodayDateDatePicker��$��477,9,324,0q�$	��Top=�$��25���� $��
Delay Time��$
��Left=�$��
409,97,0,0q�$	��Top=�$��86���� -   $ delayTextbox��$
��Left=�$��26��$��
477,97,0,0q�$
 Wrap=�$	��Top=�{�.  $	��125���� $��Issue ID��$
��Left=�$��409,123,0,0q�$	��Top=�$��63���� -   $ bookIssueIdTextBox��$
��Left=�$��26��$��477,123,0,0q�$
 Wrap=�$	��Top=�{�.  $	��125���� -   $��bookReturnButton��$��4q�$
��Bold"�$��BOOK RETURNED��$
��Left=�$��810,480,0,0q�$	��Top=�$	��115��$��26��