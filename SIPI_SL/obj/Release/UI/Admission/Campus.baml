   M S B A M L   `   `   `  ����   SIPI_SL#    SIPI_SL.UI.Admission.CampusUI   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35n jSAPBusinessObjects.WPF.ViewerShared, Version=13.0.3500.0, Culture=neutral, PublicKeyToken=692fbea5521e1304R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml       � Title$  Campus��$��412.561��$��660.473��   	GrayWhite#��[   � ShowInTaskbar .   � WindowStartupLocation$ CenterScreen=�.��� .+��� $��Campus Name��$
��Left=�$��	96,23,0,0q�$	��Top=�$
��Bold"��� -    ��Name$ campusNameTextBox��$
��Left=�$��23��$��
220,28,0,0q� �� TextWrapping$
 Wrap=�$�� ��$	��Top=�$	��204�� J� RenderTransformOrigin$ 0.477,-1.148&��� $
��Bold"�$��Campus Address��$
��Left=�$��	96,53,0,0q�$	��Top=��� -   $ campusAddressTextBox��$
��Left=�$��23��$��
219,55,0,0q�$
 Wrap=�$�� ��$	��Top=�$	��205���� $
��Bold"�$��Contact Person��$
��Left=�$��	95,78,0,0q�$	��Top=��� -   $ contactPersonTextBox��$
��Bold"�$
��Left=�$��23��$��
218,80,0,0q�$
 Wrap=�$�� ��$	��Top=�$	��205���� $
��Bold"�$��Mobile Number��$
��Left=�$��
95,106,0,0q�$	��Top=��� -   $ mobileNumberTextBox��$
��Left=�$��23��$��218,108,0,0q�$
 Wrap=�$�� ��$	��Top=�$	��205���� $
��Bold"�$��Campus In Bangla��$
��Left=�$��
96,134,0,0q�$	��Top=��� -   $ banglaCampusTextbox��$
��Left=�$��23��$��219,136,0,0q�$
 Wrap=�$�� ��$	��Top=�$	��204���� -    ��Name$ 
saveButton��$
��Bold"�$
��save��$
��Left=�$��500,134,0,0q�$	��Top=�$��75���� $��Campus Information��$��
25,160,0,0q�$	��Top=�$	��198��$
��Left=�$	��595��.��� $
��Left=�$	��162��$	��Top=�$	��563��.+��� -   $��campusListView��$	��156��$��
6,5,-130,0q�   alternatingListViewItemStyle#��[  �� AlternationCount$ 2��$	��Top=�$
��Left=�$	��559�� � ContextMenu �� -   $��campusformationList��	 �� 	StaysOpen	 . 
�������
 J� BitmapEffect
 �� .@�m� -	   $��EditCampusContextMenu��$
��Edit��m� -
   $��RemoveCampusContextMenu��$��Remove�� �� View ��  �� AllowsColumnReorder . .P��� $�� �� �� Width$ 0�� �� DisplayMemberBinding ��  �� Path$ Id��� $��Campus Name��$	 100�� �� $ 
CampusName��� $��Campus Address��$	 200�� �� $ CampusAddress��� $��Contact Person��$	 150�� �� $ ContactPerson��� $��Mobile Number��$	 100�� �� $ MobileNumber��� $��Campus in Bangla��$	 100�� �� $ BanglaCampus�