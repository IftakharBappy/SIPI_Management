   M S B A M L   `   `   `  ����   SIPI_SL,    &SIPI_SL.UI.LibraryManagement.BookEntry   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35n jSAPBusinessObjects.WPF.ViewerShared, Version=13.0.3500.0, Culture=neutral, PublicKeyToken=692fbea5521e1304R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml       � Title$  
Book Entry��$	��547��$	��964�� � ShowInTaskbar .     	GrayWhite#��[   � WindowStartupLocation$ CenterScreen=�.��� .+�� $��
45,10,71,0q�$	��210��$	��Top=�$��Center=�$	��840��.+��� $��Program��$
��Left=�$��	55,26,0,0q�$	��Top=�$	��100���� $��
Department��$
��Left=�$��	55,54,0,0q�$	��Top=�$	��100���� $��	Book Name��$
��Left=�$��	55,87,0,0q�$	��Top=�$	��100���� $��Book Author��$
��Left=�$��
55,113,0,0q�$	��Top=�$	��100���� $��Book Edition��$
��Left=�$��
55,139,0,0q�$	��Top=�$	��100���� $��Published Year��$
��Left=�$��
55,165,0,0q�$	��Top=�$	��100���� $��Quantity��$
��Left=�$��
469,26,0,0q�$	��Top=�$��86���� $��Self No��$
��Left=�$��
469,54,0,0q�$	��Top=�$��86���� $
��Date��$
��Left=�$��
469,85,0,0q�$	��Top=�$��86���� -   $��programCombobox��$
��Left=�$��
164,18,0,0q�$	��Top=�$	��251��  ComboBoxBGYellowGreen#��[ �� -   $��departmentCombobox��$
��Left=�$��
164,53,0,0q�$	��Top=�$	��251��#��[ ���� .R���  �� Orientation$ 
Horizontal=�.+��� $	��210������ *SIPI_DepartmentName+�� $��||���� $��27������ *
Regulation+�� -   $��bookNametextbox��$
��Left=�$��26��$��
164,88,0,0q� �� TextWrapping$
 Wrap=�$	��Top=�$	��251���� -   $��bookAuthorTextBox��$
��Left=�$��26��$��164,115,0,0q�$
 Wrap=�$	��Top=�$	��251���� -   $��bookEditionTextBox��$
��Left=�$��26��$��164,142,0,0q�$
 Wrap=�$	��Top=�$	��251���� -   $��bookPublishedYearTextBox��$
��Left=�$��26��$��164,169,0,0q�$
 Wrap=�$	��Top=�$	��251���� -   $��quantityTextbox��$
��Left=�$��26��$��
560,26,0,0q�$
 Wrap=�$	��Top=�$	��125���� -   $��selfNoTextbox��$
��Left=�$��26��$��
560,54,0,0q�$
 Wrap=�$	��Top=�$	��125��(  "System.Windows.Controls.DatePicker  -	   $��entrydateDatePicker��$
��Left=�$��
555,85,0,0q�$	��Top=�$	��125��$��26���� -
   $��newBookSaveButton��$��5q�$
��SAVE��$
��Bold"�$��755,165,0,0q�$	��Top=�$��75��$��31�����	#FFA8A8A8$
��Left=��� -   $��ClearButton��$��5q�$��CLEAR��$
��Bold"�$��675,165,0,0q�$	��Top=�$��75��$��31�����	#FFA8A8A8$
��Left=�� $��25,225,21,21q�.+��� -   $��bookListView��$	��264��$
��Left=�$��2,6,0,0q�$	��Top=�$	��908�� � ContextMenu �� -   $��ZoneIformationList�� �� 	StaysOpen . 
������� J� BitmapEffect �� .@�m� -   $��RemoveThanaContextMenu��$��Remove�� �� View �� 	 �� AllowsColumnReorder	 . .P��� $�� ��
 �� Width$
 0�� �� DisplayMemberBinding ��  �� Path$ Id��� $��	Book Name��$	
 200�� �� $ BookName��� $��Book Author ��$	
 200�� �� $ 
BookAuthor��� $��Quantity��$	
 200�� �� $ Quantity�