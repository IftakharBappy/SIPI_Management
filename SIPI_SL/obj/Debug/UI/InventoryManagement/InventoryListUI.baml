   M S B A M L   `   `   `  ����  SIPI_SL4    .SIPI_SL.UI.InventoryManagement.InventoryListUI   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35n jSAPBusinessObjects.WPF.ViewerShared, Version=13.0.3500.0, Culture=neutral, PublicKeyToken=692fbea5521e1304R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  InventoryListUI��5   	   $��528.823��6!   $��754.294��62    � WindowStartupLocation$ CenterScreen=�6B      	GrayWhite#��[  6g    � ShowInTaskbar .  .��5      � .+�5   
   � .+�5      �� $��Search Inventory��6   $
��Left=�6/   $��	10,17,0,0q�6J   $	��Top=�6]   $	��102��6u   �� 5      $
��Left=�6   $��39��61   $��
132,10,0,0q�6=    �� TextWrapping$
 Wrap=�6Q   $	��Top=�6g   $	��475��6   �� 5	      $��Search��6   $
��Left=�6&   $��
612,10,0,0q�6A   $	��124��6U   $��39��6a   $	��Top=�6m   �� 5      $��Search��6   $
��Left=�6'   $��
10,110,0,0q�6B   $	��Top=�6V   $	��117��6n   $	��726��6{   .��5      � $��-1,0,1,0q�6   .+�5      �� $��Date Search��6   $
��Left=�62   $��	10,31,0,0q�6M   $	��Top=�6`   $	��102��6x   (  "System.Windows.Controls.DatePicker  5      -   5        $��startDateDatepicker��5      $
��Left=�6!   $��
132,30,0,0q�6<   $	��Top=�6P   $��31��6h   $��96��6t   6   �� 5      $��To��6   $
��Left=�6)   $��
242,35,0,0q�6D   $	��Top=�6X   $��32��6p     5      -   5        $��endDateDatepicker��5      $
��Left=�6!   $��
282,30,0,0q�6<   $	��Top=�6P   $��31��6h   $��96��6t   6   �� 5      -   5        $��typeCombobox��5   ~   $
��Left=�6   $��
401,27,0,0q�6:   $	��Top=�6N   $	��206��6f   $��37��6r   6~   �� 5      -   5        $��searchButton��5   �   $��Search��6   $
��Left=�6.   $��
612,24,0,0q�6I   $��92��6]   $��39��6h   $	��Top=�6t   6�   5      5      5      �� 5   
   $
��Left=�6   $	��124��6.   $��
90,283,0,0q�6;   $	��Top=�6O   $	��510��6g    �� View 5      �� 5      .P�5      �� $��Inventory Type��6U    �� Width$
 Auto��6m    �� DisplayMemberBinding 6%   ��  �� Path$ 	StudentID�6m   �� 5      $��Sector��6Y   $
 Auto��6i    6%   �� $ ApplicantName�6i   �� 5      $��Price��6Z   $
 Auto��6i    6%   �� $ DepartmentName�6i   �� 5      $��Quantity��6Z   $
 Auto��6l    6%   �� $ DepartmentName�6l   �� 5      $��Details��6V   $
 Auto��6g    6%   �� $ 
CampusName�6g   5      5!      5#      5$      