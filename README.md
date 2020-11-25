# GPS1
m9-1 easy
SqlConnectionStringBuilder不能幫助開發者管理資料庫連接字串
A:正確，SqlConnectionStringBuilder不能用來管理連接字串
B:錯誤，SqlConnectionStringBuilder可以幫助開發者輕鬆管理儲存在應用程式組態檔內的連接字串(V)
C:以上皆是
D:以上皆否

m9-1 mid
SqlConnectionStringBuilder建立的連接字串是儲存在資料庫嗎？
A:正確，連接字串是儲存在資料庫
B:錯誤，SqlConnectionStringBuilder可以讀取組態檔內的(V)
C:錯誤，連接字串是儲存在應用程式中
D:以上皆否

m9-1 hard
SqlConnectionStringBuilder使用前不需要加入任何命名空間
A:正確，使用SqlConnectionStringBuilder不需加入命名空間
B:錯誤，使用SqlConnectionStringBuilder前，須在程式中加入命名空間(V)
C:錯誤，命名空間為：System.StringBuilder;
D:錯誤，命名空間為：System.Data.StringBuilder;

m9-3 easy
請依照上述資料夾架構寫出 test1.exe讀取banana.png的絕對路徑
A:/../Second
B:Desktop/Second/banana
C:Desktop/Second/banana.png (V)
D:以上皆可

m9-3 mid
撰寫test3.exe 讀取 apple.png的相對路徑
A:../First/file2
B:../file2/apple.png
C:../First/file2/Apple.png
D:../../First/file2/Apple.png(V)

m9-3 hard
A:using System.IO;(V)
B:using FileStream;
C:using System.File;
D:using ReadFile.IO;

m10-1 hard
A:三種，分別是；Broken、Closed、Connecting
B:四種，分別是；Connecting、Executing、Fetching、Open
C:五種，分別是；Broken、Closed、Connecting、Executing、Fetching
D:六種，分別是；Broken、Closed、Connecting、Executing、Fetching、Open(V)

m10-3 easy
A:Status Change Enevt
B:StateChange Event(V)
C:以上皆是
D:以上皆否

m10-3 mid
A:CurrentState(V)
B:NowStatus
C:OnState
D:Stating

m10-3 hard
A:MessageBox.Show("This is first element {0}",textBox1.Text);
B:MessageBox.Show(("This is first element {0}",textBox1.Text));
C:MessageBox.OfString.Form("This is first element {0}",textBox1.Text));
D:MessageBox.Show(String.Form("This is first element {0}",textBox1.Text));(V)

m11-1 mid
A:正確，Connection Pool用來維護資料庫連接的快取，因此重新發出連線需求時，可以馬上使用已建立過的通訊。(V)
B:錯誤，Connection Pool是用來加速資料交換過程的技術，與建立連線的作業沒有關係。
C:以上皆是
D:以上皆否

m11-1 hard
A:正確，連結集區可以讓多個不同的字串共用。
B:正確，連結集區具有辨識不同字串的能力，因此共用時，不會影響連接作業。
C:錯誤，連結集區對每一組連接字串都會建立唯一的連接資訊，因此無法共用。(V)
D:錯誤，連接集區若共用不同的字串，會覆蓋掉原本的連接資訊。

m12-1 easy
A:正確，即使沒有try..catch..區塊來捕捉錯誤訊息，當出錯時，程式仍可以正常執行
B:錯誤，當沒有使用try..catch區塊來偵錯時，當初錯時，程式會中斷運作。(V)
C:以上皆是
D:以上皆否

m12-1 mid
A:正確，在一個try..catch..架構中可以重複出現許多try的區塊
B:錯誤，每個try..catch..架構，try至少對到一個catch(V)
C:以上皆是
D:以上皆否

m12-1 hard
A:正確，每個try..catch..架構，try至少對到一個catch區塊
B:正確，可以在偵錯作業中，針對特殊的例外狀況寫出獨立的catch區塊
C:正確，一個try..catch..架構中，可以對到多個catch區塊
D:以上皆是(V)

m12-2 mid
C:以上皆是
D:以上皆否

13-1 easy
A:正確，ExecuteReader可以一次讀取全部的資料
B:錯誤，ExecuteReader是逐行讀取資料(V)
C:以上皆是
D:以上皆否

13-1 mid
A:正確，未達成條件才會執行
B:錯誤，未達成條件才會執行(V)
C:以上皆是
D:以上皆否

※把 easy跟hard兩個交換
13-1 hard
A:正確
B:錯誤(V)
C:以上皆是
D:以上皆否

14-1中 顏色
A:
B:
C:
D:

14-3 easy
A:where(V)
B:and
C:condition
D:by

14-3 mid color
A:
B:
C:
D:

14-3 hard color
A:
B:
C:
D:

15-1 mid
A:正確，為了預防SQL注射，我們可以針對欄位限制，當偵測到符號，做出相對應的作業(V)
B:錯誤，針對符號或字串進行攔截，並無法預防SQL注射
C:正確，只要針對符號進行預防，就完全不用擔心SQL注射的問題
D:錯誤，只要針對關鍵字進行預防及可，不需要特別針對符號

15-1 hard
A:正確，可以對符號進行基本的SQL注射預防(V)
B:正確，只要針對符號進行預防，就完全不用擔心SQL注射的問題
C:錯誤，針對符號或字串進行攔截，並無法預防SQL注射
D:錯誤，只要針對關鍵字進行預防及可，不需要特別針對符號

15-3 easy color
A:
B:
C:
D:

15-3 hard color
A:
B:
C:
D:

16-2 easy 可能小改成 以上皆是
A:
B:
C:
D:

17-1 easy
A:正確，有權限可以查看資料庫的人都可以看見
B:錯誤，密碼不需要經過加密，就可以直接儲存在資料庫
C:錯誤，因為資料庫很安全，因此存放在資料庫時，沒有資安問題
D:以上皆否(V)

17-1 mid
A:正確，密碼加密後儲存在資料庫，並沒有任何安全性問題
B:正確，密碼加密後儲存在資料庫，相較未加密，會比較安全(V)
C:錯誤，密碼不需加密即可儲存在資料庫
D:錯誤，資料庫並不安全，不應將密碼儲存在資料庫

17-1 hard
A:正確，相同的値透過相同的雜湊函數，所產生出來的加密結果會相同(V)
B:正確，相同的值透過不同的雜湊函數，所產生出來的加密結果會相同
C:錯誤，相同的値透過相同的雜湊函數，所產生出來的加密結果會不同
D:錯誤，相同的值透過不同的雜湊函數，所產生出來的加密結果會相同

17-3 easy
A:1
B:2
C:3(V)
D:4

18-1 mid
A:正確，DataReader可以一次顯示讀取到的資料
B:錯誤，DataReader讀取資料的方式是一行一行讀取(V)
C:以上皆是
D:以上皆否

20-1 mid
A:正確，圖片檔案會直接以圖片檔的格式儲存在資料庫
B:錯誤，以二位元的方式儲存圖片檔，資料庫中會顯示二位元資料(V)
C:以上皆是
D:以上皆否

20-3 mid 的複選
A:MemoryStream、DataSet(V)
B:StringBuilder
C:
D:

21-1 easy 
A:正確，不需要特別開發就可以拖曳檔案到程式中
B:錯誤，若無開發特定功能，拖曳檔案到程式時，並不會有任何作業執行(V)
C:以上皆是。
D:以上皆否。

21-1 mid
A:正確，僅需啟用DragEnter，就能有將檔案拖曳控制項內的作業。
B:錯誤，僅啟用DragEnter時，尚不能將檔案丟到控制項內(V)
C:以上皆是。
D:以上皆否。

21-1 hard
A:正確，撰寫DragDrop事件，就可以拖曳檔案到控制項上。
B:錯誤，除了撰寫DragDrop事件，還要啟用控制項的AllowDrop屬性，才能偵測到控制項上方有拖曳的檔案(V)
C:以上皆是。
D:以上皆否。

22-1 hard
A:正確，在程式碼中加入命名空間就可以使用元件。
B:錯誤，不需要在程式碼中加入命名空間，但是必須加入參考。
C:錯誤，除了加入命名空間，還要加入參考(V)。
D:以上皆否

22-2 easy
A:正確，無法手動啟用自動異動的功能
B:錯誤，開發者可以手動啟用自動異動功能(V)
C:以上皆是
D:以上皆否

22-3 mid color
A:
B:
C:
D:

22-3 hard multuple
A:
B:
C:
D:

23-1 easy
A:正確，若交易無法100%完成，仍可繼續執行
B:錯誤，若交易無法100%完成，則整項交易都會取消(V)
C:以上皆是
D:以上皆否

23-1 mid
A:正確，TransactionScpoe類別所執行的交易，要手動呼叫RollBack
B:錯誤，TransactionScpoe類別所執行的交易，不需要主動呼叫RollBack(V)
C:正確，所有類別執行的交易，都要手動呼叫RollBack
D:錯誤，所有類別執行的交易，都不需要主動呼叫RollBack

23-1 hard
A:正確，CommittableTransaction類別所執行的交易，要手動呼叫RollBack(V)
B:正確，所有類別執行的交易，都要手動呼叫RollBack
C:錯誤，CommittableTransaction類別所執行的交易，不需要主動呼叫RollBack
D:錯誤，所有類別執行的交易，都不需要主動呼叫RollBack

23-3 color
A:
B:
C:
D:

24-1 easy 
A:正確，加入交易隔離機制，可以避免交易受到干擾(V)
B:錯誤，進行資料更新時，會自動有優先順序的保留
C:以上皆是
D:以上皆否

24-1 mid
A:正確，增加交易隔離機制，仍有可能有 non repeatable read、dirty read等例外狀況(V)
B:錯誤，加入了交易隔離機制，就不會有交易上的例外狀況
C:以上皆是
D:以上皆否

24-1 hard
A:錯誤，READ UNCOMMITTED是最嚴謹的交易隔離層級
B:錯誤，READ COMMITTED是最嚴謹的交易隔離層級
C:錯誤，SERIALIZABLE是最嚴謹的交易隔離層級(V)
D:以上皆否

24-3 mid color
A:
B:
C:
D:

24-3 hard color
A:
B:
C:
D:

25-1 easy
A:正確，我們無法利用撰寫程式碼的方式定義元件的屬性。
B:錯誤，我們可以透過撰寫程式碼來定義元件的屬性。(V)
C:以上皆是
D:以上皆否

25-1 mid
A:正確，我們可以透過DataGridView來對資料列進行屬性設定(V)
B:錯誤，DataGridView控制項，僅有提供顯示資料的功能
C:以上皆是
D:以上皆否

25-3 hard color
A:
B:
C:
D:

26-1 easy
A:正確，透過事件的撰寫，我們可以透過DataGridView來編輯資料(V)
B:錯誤，DataGridView控制項，僅有提供顯示資料的功能
C:以上皆是
D:以上皆否

26-1 mid
A:正確，我們要在Form設計界面中從工具箱拖曳出DataGridView到畫面中。
B:正確，若熟悉Form介面的定義方式，我們也能透過程式碼撰寫出DataGridView元件
C:正確，在Form介面中建立DataGridView後，我們能透過這項元件顯示資料
D:以上皆是(V)

26-1 hard
A:正確，我們不能更改DataGridView中欄位的順序
B:正確，載入到DataGridView的資料都是固定的，故無法改變順序
C:錯誤，我們可以手動調整DataGridView的欄位順序(V)
D:以上皆否

26-3 easy複選?
A:DataGridView、BindingNavigator(V)
B:DataRecevier
C:
D:

26-3 mid color (把ABCD改成1234)
A: 1 > 2 > 3 > 4 (V)
B: 2 > 3 > 4 > 1
C: 3 > 1 > 2 > 4
D: 4 > 2 > 1 > 3

26-3 hard color (把ABCD改成1234)
A: 1 > 2 > 3 > 4 (V)
B: 2 > 3 > 4 > 1
C: 3 > 1 > 2 > 4
D: 4 > 2 > 1 > 3

27-1 hard
A:16777216 (V)
B:17666216
C:16216777
D:17776216

28-1 easy
A:正確，DataTable無法建立具有運算功能的欄位
B:正確，DataTable僅能顯示資料
C:錯誤，DataTable可以建立有運算功能的欄位(V)
D:以上皆否

28-1 mid
A:正確，要撰寫序列化物件時，要加入命名空間即可使用
B:錯誤，僅加入參考，就可以使用序列化物件
C:錯誤，除了加入命名空間，還要加入參考，才能使用序列化物件(V)
D:以上皆否

30-1 easy
A:正確，DataView可以用來呈現DataTable物件(V)
B:錯誤，DataView無法呈現DataTable物件
C:錯誤，DataView僅能呈現DataSet物件
D:以上皆否

30-1 mid
A:正確，DataView可以排序，獲得不同的資料呈現方式(V)
B:錯誤，DataView不具有排序功能
C:錯誤，僅能在SQL命令中先執行排序
D:以上皆是

30-1 hard
DataView 與 DataTable 的 Select  方法顯示資料的方式是相同的？
A:正確，兩者Select顯示資料的方式是相同的
B:正確，DataView和DataTable顯示資料的方法沒有不相同
C:錯誤，DataView是基於特定的篩選、排序條件從資料回傳DataRow陣列(V)
D:以上皆否

31-1 easy
A:正確
B:錯誤
C:以上皆是
D:以上皆否

31-1 hard
A:正確，ListBox是下拉式選單物件
B:正確，ListBox與ComboBox相同，都是選單物件
C:錯誤，ListBox是清單物件(V)
D:錯誤，ListBox是文字欄位物件

31-2 easy
A:(V)
B:
C:DisplayMember"s"
D:

32-1 easy
A:正確
B:錯誤(V)
C:以上皆是
D:以上皆否

32-1 mid
A:正確
B:錯誤(V)
C:以上皆是
D:以上皆否

32-1 hard
A:正確，資料庫中不允許資料表之間有關聯
B:錯誤，資料庫中可以讓資料表之間互相有關聯(V)
C:以上皆是
D:以上皆否

33-1 easy
A:正確
B:錯誤(V)
C:以上皆是
D:以上皆否

33-1 hard
A:正確，TableAdapter可以使用Fill方法將資料存放到DataSet(V)
B:正確，TableAdapter可以使用Make方法將資料存放到DataSet
C:錯誤，TableAdapter可以使用Save方法將資料存放到DataSet
D:錯誤，TableAdapter可以使用Full方法將資料存放到DataSet

33-3 hard color
A:
B:
C:
D:

34-1 mid
A:正確，使用Crystal Report套件測試程式需要付費
B:正確，因為這是ASP公司所開發的套件，使用者付費
C:錯誤，這是ASP公司提供的免費開發套件，用於任何用途都免費
D:錯誤，這是ASP公司提供的免費開發套件，用於商業行為則需要付費(V)

34-1 hard 這個根 easy 換題目好了
A:正確(V)
B:錯誤
C:以上皆是
D:以上皆否

34-2 hard color
A:
B:
C:
D:

35-1 easy
A:正確(V)
B:錯誤
C:以上皆是
D:以上皆否

35-1 mid
A:正確(V)
B:錯誤
C:以上皆是
D:以上皆否

35-1 hard
A:正確(V)
B:錯誤
C:以上皆是
D:以上皆否

35-1 三題用大風吹到其他題的easy

36-1 easy
A:正確
B:錯誤(V)
C:以上皆是
D:以上皆否

36-1 mid
A:正確(V)
B:錯誤
C:以上皆是
D:以上皆否

36-1 hard
A:正確
B:錯誤(V)
C:以上皆是
D:以上皆否

36-2 mid color
A:
B:
C:
D:

