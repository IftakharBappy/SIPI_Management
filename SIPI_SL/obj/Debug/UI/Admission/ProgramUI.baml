   M S B A M L   `   `   `  ����  SIPI_SL$    SIPI_SL.UI.Admission.ProgramUI   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35n jSAPBusinessObjects.WPF.ViewerShared, Version=13.0.3500.0, Culture=neutral, PublicKeyToken=692fbea5521e1304R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  	ProgramUI��5   	   $��456.865��6   $��726.867��6,      	GrayWhite#��[  6<    � ShowInTaskbar .   � WindowStartupLocation$ CenterScreen=�6z   .��5      � $��0,6,2,4q�6   .+�5   
   �� $��Department Name��6   $
��Left=�6*   $��
195,62,0,0q�6E   $	��Top=�6Y   �� 5   
   $��Program Name��6   $
��Left=�6'   $��195,100,0,0q�6B   $	��Top=�6W   �� 5   
   -   5         ��Name$ programNameTextBox��5   �   $
��Left=�6   $��23��6-   $��318,100,0,0q�69    �� TextWrapping$
 Wrap=�6N   $�� ��6b   $	��Top=�6j   $	��120��6�   6�   �� 5
   
   $��Program Code��6   $
��Left=�6'   $��195,129,0,0q�6B   $	��Top=�6W   �� 5   
   -   5        $ programCodeTextBox��5   �   $
��Left=�6   $��23��6-   $��318,131,0,0q�69   $
 Wrap=�6N   $�� ��6b   $	��Top=�6j   $	��120��6�   6�   �� 5   
   $��Program In Bangla��6   $
��Left=�6,   $��195,164,0,0q�6G   $	��Top=�6\   �� 5   
   -   5        $ banglaProgramTextBox��5   �   $
��Left=�6   $��23��6-   $��318,166,0,0q�69   $
 Wrap=�6N   $�� ��6b   $	��Top=�6j   $	��120��6�   6�   �� 5   
   $��GroupBox��6   $��
51,208,0,0q�6%   $	��Top=�69   $	��188��6Q   $
��Left=�6^   $	��643��6y   .��5      � $	��117��6   $	��Top=�6    $��	10,48,0,0q�68   $
��Left=�6K   $	��621��6f   .+�5      �� -   5        $��programlistView��5      $	��156��5      $
��Left=�5      $��
10,-39,0,0q�5      $	��Top=�5      $	��600��5         alternatingListViewItemStyle#��[ 5       �� AlternationCount$ 2��6^    � ContextMenu 5      �� 5      -   5        $��
proramList��5   &    �� 	StaysOpen . 
������� J� BitmapEffect 5      �� 5   "   .@�5      m� -   5        $��EditProgramContextMenu��5   5   $
��Edit��6'   6T   m� 5       -   5        $��RemoveProgramContextMenu��5    7   $��Remove��6'   6X   5!      	 �� View	 5#      �� 5$      
 �� AllowsColumnReorder
 . .P�5%      �� $�� ��6V    �� Width$ 0��6`    �� DisplayMemberBinding 6-   ��  �� Path$ Id�6`   �� 5&      $��Department Name��6b   $	 200��6{    6-   �� $ DeparimentName�6{   �� 5'      $��Program Name��6_   $	 200��6u    6-   �� $ ProgramName�6u   �� 5(      $��Program Code��6_   $	 200��6u    6-   �� $ ProgramCode�6u   �� 5)      $��Bangla Program��6a   $	 100��6y    6-   �� $ BanglaProgram�6y   5+      5-      5.      5/      �� 50   
   -   5        $��
saveButton��50   s   $
��Save��6   $
��Left=�6    $��489,150,0,0q�6;   $	��Top=�6P   $��99��6h    J� RenderTransformOrigin$ 
0.382,2.52&�6�   $��40��6�   �� 51   
   -	   5        $��departmentCombobax��54      $
��Left=�51      $��
318,62,0,0q�6.   $	��Top=�6B   $	��120��6Z     ComboBoxBGYellowGreen#��[ 53      ��55      �� 56      .R�57      ��  �� Orientation$ 
Horizontal=�6!   .+�59      �� $��60��6D   ��6$   �� *DepartmentCode+6D   �� 5:      $��|��6$   �� 5;      $��60��6D   ��6$   �� *DepartmentName+6D   5=      5>      5@      5C      5D      