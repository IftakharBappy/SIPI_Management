   M S B A M L   `   `   `  ����  SIPI_SL#    SIPI_SL.UI.Admission.CampusUI   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35n jSAPBusinessObjects.WPF.ViewerShared, Version=13.0.3500.0, Culture=neutral, PublicKeyToken=692fbea5521e1304R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  Campus��5   	   $��412.561��6   $��660.473��6)      	GrayWhite#��[  69    � ShowInTaskbar .   � WindowStartupLocation$ CenterScreen=�6w   .��5      � .+�5   
   �� $��Campus Name��6   $
��Left=�6&   $��	96,23,0,0q�6A   $	��Top=�6T   $
��Bold"�6l   �� 5   
   -   5         ��Name$ campusNameTextBox��5   �   $
��Left=�6   $��23��6-   $��
220,28,0,0q�69    �� TextWrapping$
 Wrap=�6M   $�� ��6a   $	��Top=�6i   $	��204��6�    J� RenderTransformOrigin$ 0.477,-1.148&�6�   �� 5	   
   $
��Bold"�6   $��Campus Address��6"   $
��Left=�6;   $��	96,53,0,0q�6V   $	��Top=�6i   �� 5
   
   -   5        $ campusAddressTextBox��5
   �   $
��Left=�6   $��23��6-   $��
219,55,0,0q�69   $
 Wrap=�6M   $�� ��6a   $	��Top=�6i   $	��205��6�   6�   �� 5   
   $
��Bold"�6   $��Contact Person��6"   $
��Left=�6;   $��	95,78,0,0q�6V   $	��Top=�6i   �� 5   
   -   5        $ contactPersonTextBox��5   �   $
��Bold"�6   $
��Left=�6$   $��23��6?   $��
218,80,0,0q�6K   $
 Wrap=�6_   $�� ��6s   $	��Top=�6{   $	��205��6�   6�   �� 5   
   $
��Bold"�6   $��Mobile Number��6#   $
��Left=�6;   $��
95,106,0,0q�6V   $	��Top=�6j   �� 5   
   -   5        $ mobileNumberTextBox��5   �   $
��Left=�6   $��23��6-   $��218,108,0,0q�69   $
 Wrap=�6N   $�� ��6b   $	��Top=�6j   $	��205��6�   6�   �� 5   
   $
��Bold"�6   $��Campus In Bangla��6"   $
��Left=�6=   $��
96,134,0,0q�6X   $	��Top=�6l   �� 5   
   -   5        $ banglaCampusTextbox��5   �   $
��Left=�6   $��23��6-   $��219,136,0,0q�69   $
 Wrap=�6N   $�� ��6b   $	��Top=�6j   $	��204��6�   6�   �� 5   
   -   5         ��Name$ 
saveButton��5   �   $
��Bold"�6   $
��save��6#   $
��Left=�62   $��500,134,0,0q�6M   $	��Top=�6b   $��75��6z   6�   �� 5   
   $��Campus Information��6   $��
25,160,0,0q�6/   $	��Top=�6C   $	��198��6[   $
��Left=�6h   $	��595��6�   .��5      � $
��Left=�6   $	��162��6.   $	��Top=�6;   $	��563��6S   .+�5      �� -   5        $��campusListView��5      $	��156��5      $��
6,5,-130,0q�5         alternatingListViewItemStyle#��[ 5       �� AlternationCount$ 2��6\   $	��Top=�5      $
��Left=�61   $	��559��6L    � ContextMenu 5      �� 5       -   5        $��campusformationList��5    &   	 �� 	StaysOpen	 . 
�������
 J� BitmapEffect
 5!      �� 5"   "   .@�5$      m� -	   5        $��EditCampusContextMenu��5$   5   $
��Edit��6'   6R   m� 5%      -
   5        $��RemoveCampusContextMenu��5%   7   $��Remove��6'   6V   5&       �� View 5(      �� 5)       �� AllowsColumnReorder . .P�5*      �� $�� ��6V    �� Width$ 0��6`    �� DisplayMemberBinding 6-   ��  �� Path$ Id�6`   �� 5+      $��Campus Name��6^   $	 100��6s    6-   �� $ 
CampusName�6s   �� 5,      $��Campus Address��6a   $	 200��6y    6-   �� $ CampusAddress�6y   �� 5-      $��Contact Person��6a   $	 150��6y    6-   �� $ ContactPerson�6y   �� 5.      $��Mobile Number��6`   $	 100��6w    6-   �� $ MobileNumber�6w   �� 5/      $��Campus in Bangla��6`   $	 100��6z    6-   �� $ BanglaCampus�6z   52      54      5B      5C      5E      5F      