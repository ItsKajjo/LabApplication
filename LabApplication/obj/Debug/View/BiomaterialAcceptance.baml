   M S B A M L   `   `   `  ����I  ELabApplication, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:LabApplication.ViewLabApplication.View  5      C&clr-namespace:LabApplication.ViewModelLabApplication.ViewModel  5      /    )LabApplication.View.BiomaterialAcceptance   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      3local!clr-namespace:LabApplication.View     5      <	viewmodel&clr-namespace:LabApplication.ViewModel     5        N� Title$  BiomaterialAcceptance��5       N� 
Background
 ����� N� FontSize$ 16(�68    � 	Resources 5         DarkGrayText �� Color  LightGrayText��%V   &	        &	 !     �� 5   
   $ #595959��6/   �� 5   
   $ #828282��60   5      .��5      �  � ColumnDefinitions 5   
   �� 5      $��0.05* �6   �� 5      �� 5      $��0.05* �6    � RowDefinitions 5   
   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      .+�5   
   �� $/��)Принятие биометариала��6   $��24(�61   #��[  6?   $��0��5       $��0��6$   $��3��61   $��10,0,0,0q�6E   ]� 5"   
   $��1��6   $��1��6!   $��0, 20, 0, 20q�61   .+�5#      �� $��Center=�6   $
��Left=�63   �� 5$      $(�"Выберите пациента:��6   #��[  60   �� 5%      �� 5&      $+�%Или создайте нового.��6   #��[ 62   5'      �� 5)      $��Right=�6    �� Orientation$ 
Horizontal=�65   .+�5*      �� $��30��6   $	��190��6'   $��Right=�63   $ �� IsSynchronizedWithCurrentItem$
 TrueY�5+   8   	 �� DisplayMemberPath$	 FullName��5,      ��5+      �� *
Patients+
 �� SelectedItem
 5,   4   �� *SelectedPatient+�� 5.      $��30��6   $��10,0,0,0q�6%   
����� �.��5/      �� $��\Resources\AddUser.png��6    50       �� 
TargetType �� Property �� Value��%^   '��       �� 51      " ��6    .�52      ��  �@��CornerRadius$ 5��6=   53      54      55      56      57      ]� 59   
   $��1��6   $��2��6$   $��0, 20, 0, 20q�61   .+�5:      �� $��Center=�6   $
��Left=�63   �� 5;      $G�AВведите код пробирки (номер заказа):��6   #��[  6B   �� 5<      �� 5=      $v�pИспользуйте предложенный (рекомендуется), или создайте новый��6   #��[ 5>      5?      �� 5A        TextBoxRoundCorners#��[ 6   $��30��6F   $	��230��6R   $��Right=�6^   5B      �� 5D   
   $��1��6   $��3��6%   $ Vertical=�62   $��0, 20, 0, 20q�6I   .+�5E      ]� .+�5F      �� $��Center=�6   $
��Left=�67   �� 5G      $C�=Выберите предоставляемые услуги:��6   #��[  6>   �� 5H      �� 5I      $n�hДля формирования заказа необходимо выбрать хотя бы одну.��6   #��[ 6V   5J      �� 5L      $��Right=�6   $ 
Horizontal=�69   .+�5M      �� $��30��6   $	��190��6+   $��Right=�67   $
 TrueY�5N   :   $	 Service��5O      ��5N      �� *Bloods+
 5O   7   �� *SelectedService+�� 5Q      $��30��6   $��10,0,0,0q�6)   
����� ���5R      �� *AddServiceCommand+.��5S      �� $��\Resources\Add.png��6     5T      ��%^   '��       �� 5U      " ��6$   .�5V   "   ��  �@��CornerRadius$ 5��6A   5W      5X      5Y      5Z      5[      �� 5\      $��90��6   $��
0, 5, 0, 5q�6#   ��5]      �� *AddedServices+ �� UpdateSourceTrigger$ PropertyChanged=� 5^      ��%^   '��       �� 5_      " ��6   .�5`      ��  �@��CornerRadius$ 6��69   5a      5b      ��5c      �� 5d      .R�5e      �  � Orientation$ Vertical=�6$   $
��Left=�6;   5f      ��5h      �� 5i      .R�5j      � .+�5k      �� $��12(�6(   �� 5l   "   �6&   �� *Code+ �� StringFormat$ Код: {0}�� �� 5m   "   �6&   �� *	Service+$ Название: {0}�� �� 5n   "   �6&   �� *Price+$ Цена: {0}��5o      5p      5q      5s      5t      �� 5v   
   $��4��6   $��1��6!   $��СУММА ЗАКАЗА:��5w      #��[  6)   �� 5x   
   $��4��6   $��1��6!   $��Right=�5y      $	��Top=�60   ��5z      �� *Price+�� 5{   
   $��4��6   $��1��6   $��Right=�5|      $��Bottom=�6-   $��10q�6H   $)��#Сформировать заказ��5}      $��10, 5, 10, 5q�6.   ���#ecf0f1���#3498db��5~      �� *CreateOrderCommand+ 5      ��%^   '��       �� 5�      " ��6   .�5�      ��  �@��CornerRadius$ 7��65   5�      5�      5�      5�      5�      