   M S B A M L   `   `   `  ????G  CDemo_MVVM_01, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:Demo_MVVM_01Demo_MVVM_01  5   	       Demo_MVVM_01.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:Demo_MVVM_01     5   	     ? Title$  
MainWindow??5   	   $	??200??6   $	??200??6)   $??20(?5	   @    ? DataContext 6	   ??  
  MainVM ?? Source# [  .??5
      ?  ? RowDefinitions 5   
   ?? 5      $
??auto ?6   ?? 5      $
??auto ?6   ?? 5      $
??auto ?6   ?? 5      $??* ?6    ? ColumnDefinitions 5   
   ?? 5      $??* ?6   ?? 5      $??* ?6   .+?5   
   ?? $??0??6   $??0??5      
????ح???5      ?? *	Message+ ?? UpdateSourceTrigger$ PropertyChanged=??? 5   
   $??1??6   $??0??5      
?????????5      ?? *
Message2+?? 5   
   $??0??6   $??2??5       $??2??5!      $??25(?5"      
??????? ?? TextAlignment$ Center=?5%      ??5$      ?? *	Counter+5%      ?? 5'   
   $??2??6   $??0??5(      $??2??5)      $ Center=?5+      
????? ???5*      ?? *MessageFinish+5,      ?? 5.   
   $??3??6   $??2??5/      $??	Kawabunga??50      $??Center=?51      $??Center=?52      $
??Bold"?53      $??Comic Sans MS)?54      
??????? J? Effect 56      3  -System.Windows.Media.Effects.DropShadowEffect  57         Color$ HotPink??6#   	   ShadowDepth$	 5Q?58   #   
   Opacity$	
 0.7Q?59   #      	Direction$	 315Q?5:   #      
BlurRadius$ 5Q?5;   #   5=      ?? 5>   
   $??3??6   $??2??5?      $??	Kawabunga??5@      $??Center=?5A      $??Center=?5B      $
??Bold"?5C      $??Comic Sans MS)?5D      
??????? 5F        5G      $ 
Chartreuse??6#   $	 5Q?5H   #   $	
 0.7Q?5I   #   $	 225Q?5J   #   $ 5Q?5K   #   5M      ?? 5N   
   $??3??6   $??2??5O      $??	Kawabunga??5P      $??Center=?5Q      $??Center=?5R      $
??Bold"?5S      $??Comic Sans MS)?5T      
??????? 5V        5W      $ Yellow??6#   $	 5Q?5X   #   $	
 0.7Q?5Y   #   $ 45Q?5Z   #   $ 5Q?5[   #   5]      ?? 5^   
   $??3??6   $??2??5_      $??	Kawabunga??5`      $??Center=?5a      $??Center=?5b      $
??Bold"?5c      $??Comic Sans MS)?5d      
??????? 5f        5g      $ 
BlueViolet??6#   $	 5Q?5h   #   $	
 0.7Q?5i   #   $	 135Q?5j   #   $ 5Q?5k   #   5m      5n      5o      