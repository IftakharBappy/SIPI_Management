   M S B A M L   `   `   `  ����   SIPI_SL/    )SIPI_SL.UI.InventoryManagement.StockOutUI   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35n jSAPBusinessObjects.WPF.ViewerShared, Version=13.0.3500.0, Culture=neutral, PublicKeyToken=692fbea5521e1304R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml       � Title$  Purchase Entry UI��$��536.483��$��1070.428�� � WindowStartupLocation$ CenterScreen=�   	GrayWhite#��[   � ShowInTaskbar .  .��� .+��� $��Product Collection��$
��Left=�$��	10,10,0,0q�$	��Top=�$	��469��$	��471��.��� $��	0,0,-2,-2q�.+��� $
��Left=�$��30��$��9,6,0,0q� �� TextWrapping$
 Wrap=�$	��Top=�$	��234���� -   $ ��productMasterEntryListView��$
��Left=�$	��402��$��9,37,0,0q�$	��Top=�$	��234�� �� View �� .P��� $��ID�� �� Width$ 0�� �� DisplayMemberBinding ��  �� Path$ Id��� $��Product Name��$
 Auto�� �� $ Product_Name��� $��
Brand Name��$
 Auto�� �� $ 	BrabdName��� $��Category Name��$
 Auto�� �� $ CategoryName��� $��CategoryName��$
 Auto�� �� $ CategoryName��� $��	Unit Type��$
 Auto�� �� $ UnitTypeName��� $��Stock In Hand��$
 Auto�� �� $ Stock_InHand��� $��Product��$
��Left=�$��
251,10,0,0q�$	��Top=�$	��116���� -   $��productNameTextBox��$
��Left=�$��30��$��	322,7,0,0q�$
 Wrap=�$	��Top=�$	��134��{�.  �� -   $��productIdTextBox��$y�Hidden=�$
��Left=�$��30��$��	587,9,0,0q�$
 Wrap=�$	��Top=�$��48��{�.  �� $��Category��$
��Left=�$��
250,37,0,0q�$	��Top=�$	��116���� -   $��categoryNameTextBox��$
��Left=�$��30��$��
322,38,0,0q�$
 Wrap=�$	��Top=�$	��134��{�.  �� -   $��categoryIdTextBox��$
��Left=�$y�Hidden=�$��30��$��
587,40,0,0q�$
 Wrap=�$	��Top=�$��48��{�.  �� $��Brand��$
��Left=�$��
251,75,0,0q�$	��Top=�$	��116���� -   $��brandNameTextbox��$
��Left=�$��30��$��
322,69,0,0q�$
 Wrap=�$	��Top=�$	��134��{�.  �� -   $��brandIdTextbox��$y�Hidden=�$
��Left=�$��30��$��
587,71,0,0q�$
 Wrap=�$	��Top=�$��48��{�.  �� -    ��Name$ unitTypeNameTextbox��$
��Left=�$��30��$��322,100,0,0q�$
 Wrap=�$	��Top=�$	��134��{�.  �� -	   $ unitTypeIdTextbox��$y�Hidden=�$
��Left=�$��30��$��587,102,0,0q�$
 Wrap=�$	��Top=�$��48��{�.  �� $��Quantity��$
��Left=�$��251,132,0,0q�$	��Top=�$	��116���� -
   $��productQuantityTextBox��$
��Left=�$��30��$��322,132,0,0q�$
 Wrap=�$	��Top=�$	��134���� $��
Item Price��$
��Left=�$��251,162,0,0q�$	��Top=�$	��102���� -   $��itemPriceTextBox��$
��Left=�$��30��$��322,163,0,0q�$
 Wrap=�$	��Top=�$	��134��{�.  �� $��Total Price��$
��Left=�$��251,193,0,0q�$	��Top=�$	��102���� -   $��totalPriceTextBox��$
��Left=�$��30��$��322,195,0,0q�$
 Wrap=�$	��Top=�$	��134���� $��	Unit Type��$
��Left=�$��251,103,0,0q�$	��Top=�$	��116���� -   	 ��Name$	 	addButton��$��6q�$��ADD >>>��$
��Left=�$��378,409,0,0q�$	��Top=�$��78���� -   $��clearButtonAllTextBox��$��6q�$��Clear��$
��Left=�$	��Top=�$��78��$��300,409,0,0q��� $��	Stock Out��$
��Left=�$��
486,10,0,0q�$	��Top=�$	��469��$	��312��.��� $��0,0,-2,0q�.+��� $��
Invoice No��$��
23,4,252,0q�$	��Top=��� -   $��invoiceNoTextbox��$
��Left=�$��29��$��	118,3,0,0q�$
 Wrap=�$	��Top=�$	��180��{�.  �� $
��Date��$
��Left=�$��	23,30,0,0q�$	��Top=�$	��102��(  "System.Windows.Controls.DatePicker  -   $��StockOutDate��$
��Left=�$��
118,34,0,0q�$	��Top=�$	��180��$��24���� $��Stock Out Info��$
��Left=�$��	23,61,0,0q�$	��Top=�$	��102���� -   $��StockOutInfoTextBox��$
��Left=�$��30��$��
118,59,0,0q�$
 Wrap=�$	��Top=�$	��180���� -   $��stockOutListview��$
��Left=�$	��279��$��	10,92,0,0q�$	��Top=�$	��288��
 � ContextMenu
 �� -   $��purchageInformationList�� �� 	StaysOpen . 
������� J� BitmapEffect �� .@�m� -   $#��RemoveSelectedItemContextMenu��$��Remove�� �� .P��� $��ID��$ 0�� �� *Id+�� $��Product Name��$
 Auto�� �� *ProductName+�� $��
Product ID��$ 0�� �� *	ProductId+�� $��Number Of Product��$
 Auto�� �� *
Quantity+�� $��
Item Price��$
 Auto�� �� *	ItemPrice+�� $��Total��$
 Auto�� �� *
TotalPrice+�� -   $��totalAmountTextBox��$
��Left=�$��25��$��183,378,0,0q�$
 Wrap=�$	��Top=�$	��111��{�.  �� $��Total Amount��$
��Left=�$��
91,376,0,0q�$	��Top=�$��87���� -   $��stckOutButton��$��6q�$
��Save��$��Right=�$	��Top=�$��78��$��
0,407,10,0q��� -   $��clearButton��$��6q�$��Clear��$��Right=�$	��Top=�$��78��$��
0,407,88,0q��� $��	Stock Out��$
��Left=�$��
803,10,0,0q�$	��Top=�$	��469��$	��249��.���� -   $��stockOutListDetailsList��$
��Left=�$	��432��$��	10,10,0,0q�$	��Top=�$	��218��
 �� -   $��stockOutSlip�� . 
������� �� .@�m� -   $��SlipContextMenu��$
��Slip�� �� .P��� $��
Invoice No��$
 Auto�� �� $ 	InvoiceNo��� $
��Date��$
 Auto�� �� $ StockOutDate� �� StringFormat$ 
dd-mm-yyyy���� $��StockOut Info��$ 0�� �� $ StockOutInfo�