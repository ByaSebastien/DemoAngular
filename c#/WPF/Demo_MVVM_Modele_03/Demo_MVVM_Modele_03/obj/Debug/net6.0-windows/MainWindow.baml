   M S B A M L   `   `   `  ????N  JDemo_MVVM_Modele_03, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:Demo_MVVM_Modele_03Demo_MVVM_Modele_03  5   	   $    Demo_MVVM_Modele_03.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   3local!clr-namespace:Demo_MVVM_Modele_03     5   	     ? Title$  Demo 03??5	   	   $	??450??6   $	??800??6&    ? DataContext 5   	   ??  
  MainVM ?? Source# [  .??5
      ?  ? RowDefinitions 5   
   ?? 5      $
??auto ?6   ?? 5      $??* ?6   .+?5   
   ?? $??0??6   $??0??6!   $??Vente de voiture 🚗??5      $??42(?5      $??Comic sans MS)?6"   
????? ? ?? TextAlignment$ Center=?5      &   System.Windows.Controls.DataGrid  5   
   $??1??6   $??0??6       AutoGenerateColumns$ False??5      $??20(?5      ??5      ?? *Items+   Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Marque??6%      
IsReadOnly$
 True??5   %   	   Width5  /System.Windows.Controls.DataGridLengthConverter$
	 auto 67   1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 5   5   ?? *Brand+5   7     5      $ Modèle??6%   $
 True??5   %   $
	 auto 67   
 5   5   ?? *Model+5   7     5      $
 Etat??6%   $
 True??5!   %   $
	 auto 67   
 5    %   ?? *	Condition+  ConditionCarToString ?? 	Converter# [ 5!   7   4  .System.Windows.Controls.DataGridTemplateColumn  5"      $ Kilométrage??6)      CellTemplate 5#      ?? 5$      .R?5%      ?? ??6(   ?? *
Kilometers+ ?? StringFormat$  {0} Km??5&         CellEditingTemplate 5(      ?? 5)      .R?5*      ?? {?6&   ?? *
HasStock+??6E   ?? *
Kilometers+5+      5-      4  .System.Windows.Controls.DataGridCheckBoxColumn  5.      $ Fonctionnel??6)   
 6>   ?? *IsFunctional+  5/      $
 Prix??6)    50      ?? 51      .R?52      ?? ??6(   ?? *Price+$  {0} €??53       55      ?? 56      .R?57      ?? {?6&   ?? *
HasStock+??6E   ?? *Price+58      5:        5;      $
 True??6%   $	 * 67     5<      $
	 auto 6)    5=      ?? 5>      .R?5?      ??  ?? Orientation$ 
Horizontal=?6)   .+?5@   "   ?? $??Vendu??6)   $??0,0,10,0q?6Y   ??69   ?? *SoldCommand+6Y   ?? 5A   "   $??	Supprimer??6)   ??6=   ?? *DeleteCommand+5B      5C      5E      5G      5H      5I      