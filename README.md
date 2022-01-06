
<HEAD>

<META content="text/html; charset=utf-8" http-equiv=Content-Type>
<LINK HREF="IBEHTMLDoc.css" type=text/css rel=STYLESHEET>
 

 
</HEAD>
<div id="top"></div>
<!--
*** Thanks for checking out the Best-README-Template. If you have a suggestion
*** that would make this better, please fork the repo and create a pull request
*** or simply open an issue with the tag "enhancement".
*** Don't forget to give the project a star!
*** Thanks again! Now go create something AMAZING! :D
-->



<!-- PROJECT SHIELDS -->
<!--
*** I'm using markdown "reference style" links for readability.
*** Reference links are enclosed in brackets [ ] instead of parentheses ( ).
*** See the bottom of this document for the declaration of the reference variables
*** for contributors-url, forks-url, etc. This is an optional, concise syntax you may use.
*** https://www.markdownguide.org/basic-syntax/#reference-style-links
-->




<!-- PROJECT LOGO -->
<br />
<div align="center">
  <a href="https://github.com/MaximTelyatnick/TechnicalProcessControlg">
    <img src="Screenshots/TPC.png" alt="Logo" width="80" height="80">
  </a>

<h3 align="center">TechnicalProcessControl</h3>
<br/>
  <p align="center">
    The program allows you to simplify the process of creating technical processes.
    </p>
  <div align="center">

   [About The Project](#about-the-project) •
   <a href="https://www.youtube.com/watch?v=hffeZHG6lZE">View Demo •</a>
   [Installation](#installation) •
   [Configuration](#configuration) •
   
   </div>
 [About The Project](#about-the-project) •
 </div>

[Getting started](#getting-started) •
[Installation](#installation) •
[Configuration](#configuration) •
[Integrations](#third-party-integrations)
  


<!-- ABOUT THE PROJECT -->
## About The Project
<p align="left">The main application form includes the structural number of the product, the drawing of the part, the technical process of creating the product, the materials spent on manufacturing. Using the buttons "Add", "Edit", "Delete", the user can edit the structure element, which consists of the drawing number, the number of blanks, physical parameters of the product, and the type of material.</p>
 <br />
<a href="https://github.com/MaximTelyatnick/TechnicalProcessControlg">
    <img src="Screenshots/MainForm.jpg" alt="Main window" width="1000" height="480">
  </a>
  <h4 align="center">Main Form Structure</h4>
The program supports five types of technical processes.
  The structure editing form allows you to specify the parent links of the structural element, the parent drawing, the current drawing (or call the form for creating a drawing, editing, creating a revision), workflows (and editing operations for workflows).
</p>
  <a href="https://github.com/MaximTelyatnick/TechnicalProcessControlg">
    <img src="Screenshots/StructuraEditForm.jpg" alt="Main window" width="1372" height="500">
  </a>
  <h4 align="center">Structure editing form</h4>
<p align="left">  The program supports five types of technical processes. </p>
  <div align="center">
  <a href="https://github.com/MaximTelyatnick/TechnicalProcessControlg">
    <img src="Screenshots/TechnicallProcessesType.jpg" alt="Types of technical processes" width="1000" height="400">
  </a>
  <h4 align="center">Types of technical processes</h4>
 </div>
  
  
  
  The form for editing the technical process allows you to specify the size of the drawing of the product, revision of the technical process, parameters of the workpiece, date of creation of the technical process, consumables. A universal template of the .xls format has been developed to simplify the creation of technical processes; it is also possible to use a ready-made technical process (automatic change of parameters within the technical process file does not work in this case).
</p>
<div align="center">
  <a href="https://github.com/MaximTelyatnick/TechnicalProcessControlg">
    <img src="Screenshots/EditTechnicalProcess.jpg" alt="Process editing form" width="541" height="437">
  </a>
  <h4 align="center">Process editing form</h4>
 </div>



<p align="right">(<a href="#top">back to top</a>)</p>



### Built With

* [Entity Framework](https://docs.microsoft.com/en-us/ef/?ranMID=46131&ranEAID=a1LgFw09t88&ranSiteID=a1LgFw09t88-hlluP1_OXfxgOwFLJlEmrQ&epi=a1LgFw09t88-hlluP1_OXfxgOwFLJlEmrQ&irgwc=1&OCID=AID2200057_aff_7806_1243925&tduid=%28ir__69bg1pxcickf6zoxfl9yvpgsmf2xoyl6stjahgn300%29%287806%29%281243925%29%28a1LgFw09t88-hlluP1_OXfxgOwFLJlEmrQ%29%28%29&irclickid=_69bg1pxcickf6zoxfl9yvpgsmf2xoyl6stjahgn300)
* [Firebird](http://www.firebirdsql.org/)
* [Visual Studio Code](https://code.visualstudio.com/)
* [DevExpress](https://www.devexpress.com/)



## How to use

<details>
  <summary>Database settings</summary>


<p align="right">(<a href="#top">back to top</a>)</p>

<P CLASS="Base">&nbsp;</P>
<P CLASS="Base">Database: F:\Soft\DataBase\ib\TECHDATABASEDB</P>
<P CLASS="Base">&nbsp;</P>
<P CLASS="Base">Domains&nbsp(0)</P>
<P CLASS="Base"><A HREF="#_TABLES">Tables</A>&nbsp(19)</P>
<P CLASS="Base">Views&nbsp(0)</P>
<P CLASS="Base"><A HREF="#_PROCEDURES">Procedures</A>&nbsp(2)</P>
<P CLASS="Base"><A HREF="#_TRIGGERS">Triggers</A>&nbsp(19)</P>
<P CLASS="Base"><A HREF="#_GENERATORS">Generators</A>&nbsp(21)</P>
<P CLASS="Base">Exceptions&nbsp(0)</P>
<P CLASS="Base">UDFs&nbsp(0)</P>
<P CLASS="Base"><A HREF="#_INDICES">Indices</A>&nbsp(64)</P>
<P CLASS="Base"><A HREF="#_FOREIGN_KEYS">Foreign Keys</A>&nbsp(45)</P>
<P CLASS="Base">Checks&nbsp(0)</P>
<P CLASS="Base">Roles&nbsp(0)</P>
<HR><A NAME="_DOMAINS"><P CLASS="Header0">Domains</P></A>
<P CLASS="Base">&nbsp;</P>
<TABLE CLASS="dtArg" CELLSPACING="0">
  <TH WIDTH="1%"><P CLASS="Base2"><B>Domain</B></P>
  <TH WIDTH="1%"><P CLASS="Base2"><B>Type</B></P>
  <TH WIDTH="1%" ALIGN="middle"><P CLASS="Base2"><B>NN</B></P>
  <TH WIDTH="1%"><P CLASS="Base2"><B>Default</B></P>
  <TH WIDTH="50%"><P CLASS="Base2"><B>Description</B></P>
</TABLE>

<HR>
<A NAME="_TABLES"><P CLASS="Header0">Tables</P></A>
<P CLASS="Base">&nbsp;</P>
<TABLE CLASS="dtArg" CELLSPACING="0">
  <TH WIDTH="1%"><P CLASS="Base2"><B>Table</B></P>
  <TH><P CLASS="Base2"><B>Description</B></P>
  <TR>
    <TD><P CLASS="Base2"><A HREF="#TBL_Colors"><NOBR>Colors</NOBR></A></TD>
    <TD><P CLASS="Base2">&nbsp</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2"><A HREF="#TBL_Details"><NOBR>Details</NOBR></A></TD>
    <TD><P CLASS="Base2">&nbsp</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2"><A HREF="#TBL_Drawing"><NOBR>Drawing</NOBR></A></TD>
    <TD><P CLASS="Base2">&nbsp</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2"><A HREF="#TBL_DrawingScan"><NOBR>DrawingScan</NOBR></A></TD>
    <TD><P CLASS="Base2">&nbsp</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2"><A HREF="#TBL_Drawings"><NOBR>Drawings</NOBR></A></TD>
    <TD><P CLASS="Base2">&nbsp</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2"><A HREF="#TBL_Materials"><NOBR>Materials</NOBR></A></TD>
    <TD><P CLASS="Base2">&nbsp</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2"><A HREF="#TBL_OperationName"><NOBR>OperationName</NOBR></A></TD>
    <TD><P CLASS="Base2">&nbsp</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2"><A HREF="#TBL_OperationNumber"><NOBR>OperationNumber</NOBR></A></TD>
    <TD><P CLASS="Base2">&nbsp</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2"><A HREF="#TBL_OperationPaintMaterial"><NOBR>OperationPaintMaterial</NOBR></A></TD>
    <TD><P CLASS="Base2">&nbsp</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2"><A HREF="#TBL_RevisionType"><NOBR>RevisionType</NOBR></A></TD>
    <TD><P CLASS="Base2">&nbsp</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2"><A HREF="#TBL_Revisions"><NOBR>Revisions</NOBR></A></TD>
    <TD><P CLASS="Base2">&nbsp</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2"><A HREF="#TBL_TechProcess001"><NOBR>TechProcess001</NOBR></A></TD>
    <TD><P CLASS="Base2">&nbsp</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2"><A HREF="#TBL_TechProcess002"><NOBR>TechProcess002</NOBR></A></TD>
    <TD><P CLASS="Base2">&nbsp</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2"><A HREF="#TBL_TechProcess003"><NOBR>TechProcess003</NOBR></A></TD>
    <TD><P CLASS="Base2">&nbsp</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2"><A HREF="#TBL_TechProcess004"><NOBR>TechProcess004</NOBR></A></TD>
    <TD><P CLASS="Base2">&nbsp</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2"><A HREF="#TBL_TechProcess005"><NOBR>TechProcess005</NOBR></A></TD>
    <TD><P CLASS="Base2">&nbsp</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2"><A HREF="#TBL_Type"><NOBR>Type</NOBR></A></TD>
    <TD><P CLASS="Base2">&nbsp</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2"><A HREF="#TBL_UserRole"><NOBR>UserRole</NOBR></A></TD>
    <TD><P CLASS="Base2">&nbsp</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2"><A HREF="#TBL_Users"><NOBR>Users</NOBR></A></TD>
    <TD><P CLASS="Base2">&nbsp</TD>
  </TR>
</TABLE>

<HR>
<A NAME="TBL_Colors"><P CLASS="Header0">Table: Colors</P><P CLASS="Base">&nbsp;</P>
<P CLASS="Header1">Description</P>
<P CLASS="Base"><I>(There is no description for table Colors)</I></P>
<P CLASS="Base">&nbsp;</P>
<P CLASS="Header1">Fields</P>
<TABLE CLASS="dtArg" CELLSPACING="0">
  <TH WIDTH="1%" ALIGN="middle"><P CLASS="Base2"><B>PK</B></P>
  <TH WIDTH="1%" ALIGN="middle"><P CLASS="Base2"><B>FK</B></P>
  <TH WIDTH="1%"><P CLASS="Base2"><B>Field</B></P>
  <TH WIDTH="1%"><P CLASS="Base2"><B>Domain</B></P>
  <TH WIDTH="20%"><P CLASS="Base2"><B>Type</B></P>
  <TH WIDTH="1%" ALIGN="middle"><P CLASS="Base2"><B>NN</B></P>
  <TH WIDTH="1%"><P CLASS="Base2"><B>Default</B></P>
  <TH WIDTH="40%"><P CLASS="Base2"><B>Description</B></P>
  <TR>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/PK1.gif" BORDER="0"></P></TD>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD><A NAME="Colors.Id"><P CLASS="Base2">Id</P></A></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">INTEGER</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/Yes.gif" BORDER="0"></P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
  </TR>
  <TR>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD><A NAME="Colors.NameRus"><P CLASS="Base2">NameRus</P></A></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">VARCHAR(40)</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
  </TR>
  <TR>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD><A NAME="Colors.Code"><P CLASS="Base2">Code</P></A></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">CHAR(7)</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
  </TR>
  <TR>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD><A NAME="Colors.NameEng"><P CLASS="Base2">NameEng</P></A></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">VARCHAR(40)</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
  </TR>
  <TR>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD><A NAME="Colors.NameAr"><P CLASS="Base2">NameAr</P></A></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">VARCHAR(40)</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
  </TR>
</TABLE>
<P CLASS="Base">&nbsp;</P>
<P CLASS="Header1">Triggers</P>
<TABLE CLASS="dtArg" CELLSPACING="0">
  <TH WIDTH="1%"><P CLASS="Base2"><B>Trigger</B></P>
  <TH WIDTH="1%"><P CLASS="Base2"><B>Type</B></P>
  <TH WIDTH="1%"><P CLASS="Base2"><B>Activity</B></P>
  <TH WIDTH="1%"><P CLASS="Base2"><B>Order</B></P>
  <TH WIDTH="50%"><P CLASS="Base2"><B>Description</B></P>
  <TR>
    <TD><P CLASS="Base2"><A HREF="#TRG_Tr_Colors">Tr_Colors</A></TD>
    <TD><P CLASS="Base2">BEFORE&nbsp;INSERT</TD>
    <TD><P CLASS="Base2">Yes</TD>
    <TD ALIGN="right"><P CLASS="Base2">0</TD>
    <TD><P CLASS="Base2">&nbsp</TD>
  </TR>
</TABLE>
<P CLASS="Base">&nbsp;</P>
<P CLASS="Header1">Indices</P>
<TABLE CLASS="dtArg" CELLSPACING="0">
  <TH><P CLASS="Base2"><B>Index</B></P>
  <TH><P CLASS="Base2"><B>Fields</B></P>
  <TH ALIGN="middle"><P CLASS="Base2"><B>Active</B></P>
  <TH ALIGN="middle"><P CLASS="Base2"><B>Unique</B></P>
  <TH ALIGN="middle"><P CLASS="Base2"><B>Order</B></P>
  <TR>
    <TD><P CLASS="Base2"><A HREF="#IND_PK_ColorsId">PK_ColorsId</A></TD>
    <TD><P CLASS="Base2">"Id"</TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/Yes.gif" BORDER="0"></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/Yes.gif" BORDER="0"></TD>
    <TD ALIGN="middle"><P CLASS="Base2">ASC</TD>
  </TR>
</TABLE>
<P CLASS="Base">&nbsp;</P>
<P CLASS="Header1">References</P>
<P CLASS="Base"><I>(There are no references for table Colors)</I></P>
<P CLASS="Base">&nbsp;</P>
<P CLASS="Header1">Referenced By</P>
<TABLE CLASS="dtArg" CELLSPACING="0">
  <TH><P CLASS="Base2"><B>Table</B></P>
  <TH><P CLASS="Base2"><B>Foreign Key</B></P>
  <TH><P CLASS="Base2"><B>Fields</B></P>
  <TH><P CLASS="Base2"><B>FK Field</B></P>
  <TH><P CLASS="Base2"><B>Delete Rule</B></P>
  <TH><P CLASS="Base2"><B>Update Rule</B></P>
  <TR>
    <TD><P CLASS="Base2"><A HREF="#TBL_Drawings">Drawings</A></TD>
    <TD><P CLASS="Base2"><A HREF="#FKEY_FK_ColorId_CurrentLevelMenuId">FK_ColorId_CurrentLevelMenuId</A></TD>
    <TD><P CLASS="Base2">CurrentLevelMenuColorId</TD>
    <TD><P CLASS="Base2">Id</TD>
    <TD><P CLASS="Base2">SET NULL</TD>
    <TD><P CLASS="Base2">NO ACTION</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2"><A HREF="#TBL_Drawings">Drawings</A></TD>
    <TD><P CLASS="Base2"><A HREF="#FKEY_FK_ColorId_DrawingId">FK_ColorId_DrawingId</A></TD>
    <TD><P CLASS="Base2">DrawingColorId</TD>
    <TD><P CLASS="Base2">Id</TD>
    <TD><P CLASS="Base2">SET NULL</TD>
    <TD><P CLASS="Base2">NO ACTION</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2"><A HREF="#TBL_Drawings">Drawings</A></TD>
    <TD><P CLASS="Base2"><A HREF="#FKEY_FK_ColorId_MaterialId">FK_ColorId_MaterialId</A></TD>
    <TD><P CLASS="Base2">MaterialColorId</TD>
    <TD><P CLASS="Base2">Id</TD>
    <TD><P CLASS="Base2">SET NULL</TD>
    <TD><P CLASS="Base2">NO ACTION</TD>
  </TR>
</TABLE>
<P CLASS="Base">&nbsp;</P>
<P CLASS="Header1">Definition</P>
<P CLASS="Base"><span class="DDLCode">
<code><pre>
<b>CREATE</b><b> </b><b>TABLE</b><b> </b><font color="# 080 0"><u>&quot;Colors&quot;</u></font><b> </b><b>(</b>
<b>    </b>&quot;Id&quot;<b>       </b><b>INTEGER</b><b> </b><b>NOT</b><b> </b><b>NULL</b><b>,</b>
<b>    </b>&quot;NameRus&quot;<b>  </b><b>VARCHAR</b><b>(</b>40<b>)</b><b>,</b>
<b>    </b>&quot;Code&quot;<b>     </b><b>CHAR</b><b>(</b>7<b>)</b><b>,</b>
<b>    </b>&quot;NameEng&quot;<b>  </b><b>VARCHAR</b><b>(</b>40<b>)</b><b>,</b>
<b>    </b>&quot;NameAr&quot;<b>   </b><b>VARCHAR</b><b>(</b>40<b>)</b>
<b>)</b><b>;</b>


<b>ALTER</b><b> </b><b>TABLE</b><b> </b><font color="# 080 0"><u>&quot;Colors&quot;</u></font><b> </b><b>ADD</b><b> </b><b>CONSTRAINT</b><b> </b>&quot;PK_ColorsId&quot;<b> </b><b>PRIMARY</b><b> </b><b>KEY</b><b> </b><b>(</b>&quot;Id&quot;<b>)</b><b>;</b>

</pre></code>
</span></P>
<P CLASS="Base">&nbsp;</P>

<HR>
<A NAME="TBL_Details"><P CLASS="Header0">Table: Details</P><P CLASS="Base">&nbsp;</P>
<P CLASS="Header1">Description</P>
<P CLASS="Base"><I>(There is no description for table Details)</I></P>
<P CLASS="Base">&nbsp;</P>
<P CLASS="Header1">Fields</P>
<TABLE CLASS="dtArg" CELLSPACING="0">
  <TH WIDTH="1%" ALIGN="middle"><P CLASS="Base2"><B>PK</B></P>
  <TH WIDTH="1%" ALIGN="middle"><P CLASS="Base2"><B>FK</B></P>
  <TH WIDTH="1%"><P CLASS="Base2"><B>Field</B></P>
  <TH WIDTH="1%"><P CLASS="Base2"><B>Domain</B></P>
  <TH WIDTH="20%"><P CLASS="Base2"><B>Type</B></P>
  <TH WIDTH="1%" ALIGN="middle"><P CLASS="Base2"><B>NN</B></P>
  <TH WIDTH="1%"><P CLASS="Base2"><B>Default</B></P>
  <TH WIDTH="40%"><P CLASS="Base2"><B>Description</B></P>
  <TR>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/PK1.gif" BORDER="0"></P></TD>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD><A NAME="Details.Id"><P CLASS="Base2">Id</P></A></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">INTEGER</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/Yes.gif" BORDER="0"></P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
  </TR>
  <TR>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD><A NAME="Details.DetailName"><P CLASS="Base2">DetailName</P></A></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">VARCHAR(100)</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
  </TR>
</TABLE>
<P CLASS="Base">&nbsp;</P>
<P CLASS="Header1">Triggers</P>
<TABLE CLASS="dtArg" CELLSPACING="0">
  <TH WIDTH="1%"><P CLASS="Base2"><B>Trigger</B></P>
  <TH WIDTH="1%"><P CLASS="Base2"><B>Type</B></P>
  <TH WIDTH="1%"><P CLASS="Base2"><B>Activity</B></P>
  <TH WIDTH="1%"><P CLASS="Base2"><B>Order</B></P>
  <TH WIDTH="50%"><P CLASS="Base2"><B>Description</B></P>
  <TR>
    <TD><P CLASS="Base2"><A HREF="#TRG_Tr_Details">Tr_Details</A></TD>
    <TD><P CLASS="Base2">BEFORE&nbsp;INSERT</TD>
    <TD><P CLASS="Base2">Yes</TD>
    <TD ALIGN="right"><P CLASS="Base2">0</TD>
    <TD><P CLASS="Base2">&nbsp</TD>
  </TR>
</TABLE>
<P CLASS="Base">&nbsp;</P>
<P CLASS="Header1">Indices</P>
<TABLE CLASS="dtArg" CELLSPACING="0">
  <TH><P CLASS="Base2"><B>Index</B></P>
  <TH><P CLASS="Base2"><B>Fields</B></P>
  <TH ALIGN="middle"><P CLASS="Base2"><B>Active</B></P>
  <TH ALIGN="middle"><P CLASS="Base2"><B>Unique</B></P>
  <TH ALIGN="middle"><P CLASS="Base2"><B>Order</B></P>
  <TR>
    <TD><P CLASS="Base2"><A HREF="#IND_PK_DetailsId">PK_DetailsId</A></TD>
    <TD><P CLASS="Base2">"Id"</TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/Yes.gif" BORDER="0"></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/Yes.gif" BORDER="0"></TD>
    <TD ALIGN="middle"><P CLASS="Base2">ASC</TD>
  </TR>
</TABLE>
<P CLASS="Base">&nbsp;</P>
<P CLASS="Header1">References</P>
<P CLASS="Base"><I>(There are no references for table Details)</I></P>
<P CLASS="Base">&nbsp;</P>
<P CLASS="Header1">Referenced By</P>
<TABLE CLASS="dtArg" CELLSPACING="0">
  <TH><P CLASS="Base2"><B>Table</B></P>
  <TH><P CLASS="Base2"><B>Foreign Key</B></P>
  <TH><P CLASS="Base2"><B>Fields</B></P>
  <TH><P CLASS="Base2"><B>FK Field</B></P>
  <TH><P CLASS="Base2"><B>Delete Rule</B></P>
  <TH><P CLASS="Base2"><B>Update Rule</B></P>
  <TR>
    <TD><P CLASS="Base2"><A HREF="#TBL_Drawing">Drawing</A></TD>
    <TD><P CLASS="Base2"><A HREF="#FKEY_FK_Drawing_DetId">FK_Drawing_DetId</A></TD>
    <TD><P CLASS="Base2">DetailId</TD>
    <TD><P CLASS="Base2">Id</TD>
    <TD><P CLASS="Base2">SET NULL</TD>
    <TD><P CLASS="Base2">NO ACTION</TD>
  </TR>
</TABLE>
<P CLASS="Base">&nbsp;</P>
<P CLASS="Header1">Definition</P>
<P CLASS="Base"><span class="DDLCode">
<code><pre>
<b>CREATE</b><b> </b><b>TABLE</b><b> </b><font color="# 080 0"><u>&quot;Details&quot;</u></font><b> </b><b>(</b>
<b>    </b>&quot;Id&quot;<b>          </b><b>INTEGER</b><b> </b><b>NOT</b><b> </b><b>NULL</b><b>,</b>
<b>    </b>&quot;DetailName&quot;<b>  </b><b>VARCHAR</b><b>(</b>100<b>)</b><b> </b><b>CHARACTER</b><b> </b><b>SET</b><b> </b>WIN1251
<b>)</b><b>;</b>


<b>ALTER</b><b> </b><b>TABLE</b><b> </b><font color="# 080 0"><u>&quot;Details&quot;</u></font><b> </b><b>ADD</b><b> </b><b>CONSTRAINT</b><b> </b>&quot;PK_DetailsId&quot;<b> </b><b>PRIMARY</b><b> </b><b>KEY</b><b> </b><b>(</b>&quot;Id&quot;<b>)</b><b>;</b>

</pre></code>
</span></P>
<P CLASS="Base">&nbsp;</P>

<HR>
<A NAME="TBL_Drawing"><P CLASS="Header0">Table: Drawing</P><P CLASS="Base">&nbsp;</P>
<P CLASS="Header1">Description</P>
<P CLASS="Base"><I>(There is no description for table Drawing)</I></P>
<P CLASS="Base">&nbsp;</P>
<P CLASS="Header1">Fields</P>
<TABLE CLASS="dtArg" CELLSPACING="0">
  <TH WIDTH="1%" ALIGN="middle"><P CLASS="Base2"><B>PK</B></P>
  <TH WIDTH="1%" ALIGN="middle"><P CLASS="Base2"><B>FK</B></P>
  <TH WIDTH="1%"><P CLASS="Base2"><B>Field</B></P>
  <TH WIDTH="1%"><P CLASS="Base2"><B>Domain</B></P>
  <TH WIDTH="20%"><P CLASS="Base2"><B>Type</B></P>
  <TH WIDTH="1%" ALIGN="middle"><P CLASS="Base2"><B>NN</B></P>
  <TH WIDTH="1%"><P CLASS="Base2"><B>Default</B></P>
  <TH WIDTH="40%"><P CLASS="Base2"><B>Description</B></P>
  <TR>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/PK1.gif" BORDER="0"></P></TD>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD><A NAME="Drawing.Id"><P CLASS="Base2">Id</P></A></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">INTEGER</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/Yes.gif" BORDER="0"></P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
  </TR>
  <TR>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD><A NAME="Drawing.Number"><P CLASS="Base2">Number</P></A></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">VARCHAR(100)</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
  </TR>
  <TR>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/FK.gif" BORDER="0"></P></TD>
    <TD><A NAME="Drawing.MaterialId"><P CLASS="Base2">MaterialId</P></A></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">INTEGER</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
  </TR>
  <TR>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/FK.gif" BORDER="0"></P></TD>
    <TD><A NAME="Drawing.TypeId"><P CLASS="Base2">TypeId</P></A></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">INTEGER</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
  </TR>
  <TR>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/FK.gif" BORDER="0"></P></TD>
    <TD><A NAME="Drawing.DetailId"><P CLASS="Base2">DetailId</P></A></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">INTEGER</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
  </TR>
  <TR>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/FK.gif" BORDER="0"></P></TD>
    <TD><A NAME="Drawing.RevisionId"><P CLASS="Base2">RevisionId</P></A></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">INTEGER</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
  </TR>
  <TR>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD><A NAME="Drawing.DetailWeight"><P CLASS="Base2">DetailWeight</P></A></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">NUMERIC(10,2)</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></P></TD>
    <TD><P CLASS="Base2">0</P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
  </TR>
  <TR>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD><A NAME="Drawing.TH"><P CLASS="Base2">TH</P></A></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">VARCHAR(100)</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
  </TR>
  <TR>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD><A NAME="Drawing.W"><P CLASS="Base2">W</P></A></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">VARCHAR(100)</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
  </TR>
  <TR>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD><A NAME="Drawing.W2"><P CLASS="Base2">W2</P></A></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">VARCHAR(100)</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
  </TR>
  <TR>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD><A NAME="Drawing.L"><P CLASS="Base2">L</P></A></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">VARCHAR(100)</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
  </TR>
  <TR>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD><A NAME="Drawing.CreateDate"><P CLASS="Base2">CreateDate</P></A></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">DATE</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></P></TD>
    <TD><P CLASS="Base2">CURRENT_DATE</P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
  </TR>
  <TR>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/FK.gif" BORDER="0"></P></TD>
    <TD><A NAME="Drawing.ParentId"><P CLASS="Base2">ParentId</P></A></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">INTEGER</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
  </TR>
  <TR>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD><A NAME="Drawing.Note"><P CLASS="Base2">Note</P></A></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">VARCHAR(200)</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
  </TR>
  <TR>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD><A NAME="Drawing.Assembly"><P CLASS="Base2">Assembly</P></A></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">SMALLINT</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></P></TD>
    <TD><P CLASS="Base2">0</P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
  </TR>
  <TR>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/FK.gif" BORDER="0"></P></TD>
    <TD><A NAME="Drawing.UserId"><P CLASS="Base2">UserId</P></A></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">SMALLINT</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
  </TR>
  <TR>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD><A NAME="Drawing.NumberForParse"><P CLASS="Base2">NumberForParse</P></A></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">VARCHAR(100)</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
  </TR>
</TABLE>
<P CLASS="Base">&nbsp;</P>
<P CLASS="Header1">Triggers</P>
<TABLE CLASS="dtArg" CELLSPACING="0">
  <TH WIDTH="1%"><P CLASS="Base2"><B>Trigger</B></P>
  <TH WIDTH="1%"><P CLASS="Base2"><B>Type</B></P>
  <TH WIDTH="1%"><P CLASS="Base2"><B>Activity</B></P>
  <TH WIDTH="1%"><P CLASS="Base2"><B>Order</B></P>
  <TH WIDTH="50%"><P CLASS="Base2"><B>Description</B></P>
  <TR>
    <TD><P CLASS="Base2"><A HREF="#TRG_Tr_Drawing">Tr_Drawing</A></TD>
    <TD><P CLASS="Base2">BEFORE&nbsp;INSERT</TD>
    <TD><P CLASS="Base2">Yes</TD>
    <TD ALIGN="right"><P CLASS="Base2">0</TD>
    <TD><P CLASS="Base2">&nbsp</TD>
  </TR>
</TABLE>
<P CLASS="Base">&nbsp;</P>
<P CLASS="Header1">Indices</P>
<TABLE CLASS="dtArg" CELLSPACING="0">
  <TH><P CLASS="Base2"><B>Index</B></P>
  <TH><P CLASS="Base2"><B>Fields</B></P>
  <TH ALIGN="middle"><P CLASS="Base2"><B>Active</B></P>
  <TH ALIGN="middle"><P CLASS="Base2"><B>Unique</B></P>
  <TH ALIGN="middle"><P CLASS="Base2"><B>Order</B></P>
  <TR>
    <TD><P CLASS="Base2"><A HREF="#IND_FK_Drawing_DetId">FK_Drawing_DetId</A></TD>
    <TD><P CLASS="Base2">"DetailId"</TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/Yes.gif" BORDER="0"></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></TD>
    <TD ALIGN="middle"><P CLASS="Base2">ASC</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2"><A HREF="#IND_FK_Drawing_MatId">FK_Drawing_MatId</A></TD>
    <TD><P CLASS="Base2">"MaterialId"</TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/Yes.gif" BORDER="0"></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></TD>
    <TD ALIGN="middle"><P CLASS="Base2">ASC</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2"><A HREF="#IND_FK_Drawing_ParentId">FK_Drawing_ParentId</A></TD>
    <TD><P CLASS="Base2">"ParentId"</TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/Yes.gif" BORDER="0"></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></TD>
    <TD ALIGN="middle"><P CLASS="Base2">ASC</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2"><A HREF="#IND_FK_Drawing_RevId">FK_Drawing_RevId</A></TD>
    <TD><P CLASS="Base2">"RevisionId"</TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/Yes.gif" BORDER="0"></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></TD>
    <TD ALIGN="middle"><P CLASS="Base2">ASC</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2"><A HREF="#IND_FK_Drawing_TypeId">FK_Drawing_TypeId</A></TD>
    <TD><P CLASS="Base2">"TypeId"</TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/Yes.gif" BORDER="0"></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></TD>
    <TD ALIGN="middle"><P CLASS="Base2">ASC</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2"><A HREF="#IND_FK_Drawing_UserId">FK_Drawing_UserId</A></TD>
    <TD><P CLASS="Base2">"UserId"</TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/Yes.gif" BORDER="0"></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></TD>
    <TD ALIGN="middle"><P CLASS="Base2">ASC</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2"><A HREF="#IND_PK_DrawingId">PK_DrawingId</A></TD>
    <TD><P CLASS="Base2">"Id"</TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/Yes.gif" BORDER="0"></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/Yes.gif" BORDER="0"></TD>
    <TD ALIGN="middle"><P CLASS="Base2">ASC</TD>
  </TR>
</TABLE>
<P CLASS="Base">&nbsp;</P>
<P CLASS="Header1">References</P>
<TABLE CLASS="dtArg" CELLSPACING="0">
  <TH><P CLASS="Base2"><B>Table</B></P>
  <TH><P CLASS="Base2"><B>Foreign Key</B></P>
  <TH><P CLASS="Base2"><B>Fields</B></P>
  <TH><P CLASS="Base2"><B>FK Field</B></P>
  <TH><P CLASS="Base2"><B>Delete Rule</B></P>
  <TH><P CLASS="Base2"><B>Update Rule</B></P>
  <TR>
    <TD><P CLASS="Base2"><A HREF="#TBL_Details">Details</A></TD>
    <TD><P CLASS="Base2"><A HREF="#FKEY_FK_Drawing_DetId">FK_Drawing_DetId</A></TD>
    <TD><P CLASS="Base2">DetailId</TD>
    <TD><P CLASS="Base2">Id</TD>
    <TD><P CLASS="Base2">SET NULL</TD>
    <TD><P CLASS="Base2">NO ACTION</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2"><A HREF="#TBL_Materials">Materials</A></TD>
    <TD><P CLASS="Base2"><A HREF="#FKEY_FK_Drawing_MatId">FK_Drawing_MatId</A></TD>
    <TD><P CLASS="Base2">MaterialId</TD>
    <TD><P CLASS="Base2">Id</TD>
    <TD><P CLASS="Base2">SET NULL</TD>
    <TD><P CLASS="Base2">NO ACTION</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2"><A HREF="#TBL_Drawing">Drawing</A></TD>
    <TD><P CLASS="Base2"><A HREF="#FKEY_FK_Drawing_ParentId">FK_Drawing_ParentId</A></TD>
    <TD><P CLASS="Base2">ParentId</TD>
    <TD><P CLASS="Base2">Id</TD>
    <TD><P CLASS="Base2">SET NULL</TD>
    <TD><P CLASS="Base2">NO ACTION</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2"><A HREF="#TBL_Revisions">Revisions</A></TD>
    <TD><P CLASS="Base2"><A HREF="#FKEY_FK_Drawing_RevId">FK_Drawing_RevId</A></TD>
    <TD><P CLASS="Base2">RevisionId</TD>
    <TD><P CLASS="Base2">Id</TD>
    <TD><P CLASS="Base2">NO ACTION</TD>
    <TD><P CLASS="Base2">NO ACTION</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2"><A HREF="#TBL_Type">Type</A></TD>
    <TD><P CLASS="Base2"><A HREF="#FKEY_FK_Drawing_TypeId">FK_Drawing_TypeId</A></TD>
    <TD><P CLASS="Base2">TypeId</TD>
    <TD><P CLASS="Base2">Id</TD>
    <TD><P CLASS="Base2">SET NULL</TD>
    <TD><P CLASS="Base2">NO ACTION</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2"><A HREF="#TBL_Users">Users</A></TD>
    <TD><P CLASS="Base2"><A HREF="#FKEY_FK_Drawing_UserId">FK_Drawing_UserId</A></TD>
    <TD><P CLASS="Base2">UserId</TD>
    <TD><P CLASS="Base2">Id</TD>
    <TD><P CLASS="Base2">NO ACTION</TD>
    <TD><P CLASS="Base2">NO ACTION</TD>
  </TR>
</TABLE>
<P CLASS="Base">&nbsp;</P>
<P CLASS="Header1">Referenced By</P>
<TABLE CLASS="dtArg" CELLSPACING="0">
  <TH><P CLASS="Base2"><B>Table</B></P>
  <TH><P CLASS="Base2"><B>Foreign Key</B></P>
  <TH><P CLASS="Base2"><B>Fields</B></P>
  <TH><P CLASS="Base2"><B>FK Field</B></P>
  <TH><P CLASS="Base2"><B>Delete Rule</B></P>
  <TH><P CLASS="Base2"><B>Update Rule</B></P>
  <TR>
    <TD><P CLASS="Base2"><A HREF="#TBL_Drawing">Drawing</A></TD>
    <TD><P CLASS="Base2"><A HREF="#FKEY_FK_Drawing_ParentId">FK_Drawing_ParentId</A></TD>
    <TD><P CLASS="Base2">ParentId</TD>
    <TD><P CLASS="Base2">Id</TD>
    <TD><P CLASS="Base2">SET NULL</TD>
    <TD><P CLASS="Base2">NO ACTION</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2"><A HREF="#TBL_Drawings">Drawings</A></TD>
    <TD><P CLASS="Base2"><A HREF="#FKEY_FK_Drawings_DrawingId">FK_Drawings_DrawingId</A></TD>
    <TD><P CLASS="Base2">DrawingId</TD>
    <TD><P CLASS="Base2">Id</TD>
    <TD><P CLASS="Base2">SET NULL</TD>
    <TD><P CLASS="Base2">NO ACTION</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2"><A HREF="#TBL_Drawings">Drawings</A></TD>
    <TD><P CLASS="Base2"><A HREF="#FKEY_FK_Drawings_OccurrenceId">FK_Drawings_OccurrenceId</A></TD>
    <TD><P CLASS="Base2">OccurrenceId</TD>
    <TD><P CLASS="Base2">Id</TD>
    <TD><P CLASS="Base2">SET NULL</TD>
    <TD><P CLASS="Base2">NO ACTION</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2"><A HREF="#TBL_Drawings">Drawings</A></TD>
    <TD><P CLASS="Base2"><A HREF="#FKEY_FK_Drawings_ReplaceDrawingId">FK_Drawings_ReplaceDrawingId</A></TD>
    <TD><P CLASS="Base2">ReplaceDrawingId</TD>
    <TD><P CLASS="Base2">Id</TD>
    <TD><P CLASS="Base2">SET NULL</TD>
    <TD><P CLASS="Base2">NO ACTION</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2"><A HREF="#TBL_DrawingScan">DrawingScan</A></TD>
    <TD><P CLASS="Base2"><A HREF="#FKEY_FK_DrawingScan_Drawing">FK_DrawingScan_Drawing</A></TD>
    <TD><P CLASS="Base2">DrawingId</TD>
    <TD><P CLASS="Base2">Id</TD>
    <TD><P CLASS="Base2">CASCADE</TD>
    <TD><P CLASS="Base2">NO ACTION</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2"><A HREF="#TBL_TechProcess001">TechProcess001</A></TD>
    <TD><P CLASS="Base2"><A HREF="#FKEY_FK_TechProcess001_CopyDrawingId">FK_TechProcess001_CopyDrawingId</A></TD>
    <TD><P CLASS="Base2">CopyDrawingId</TD>
    <TD><P CLASS="Base2">Id</TD>
    <TD><P CLASS="Base2">SET NULL</TD>
    <TD><P CLASS="Base2">NO ACTION</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2"><A HREF="#TBL_TechProcess001">TechProcess001</A></TD>
    <TD><P CLASS="Base2"><A HREF="#FKEY_FK_TechProcess001_DrawingId">FK_TechProcess001_DrawingId</A></TD>
    <TD><P CLASS="Base2">DrawingId</TD>
    <TD><P CLASS="Base2">Id</TD>
    <TD><P CLASS="Base2">SET NULL</TD>
    <TD><P CLASS="Base2">NO ACTION</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2"><A HREF="#TBL_TechProcess002">TechProcess002</A></TD>
    <TD><P CLASS="Base2"><A HREF="#FKEY_FK_TechProcess002_CopyDrawingId">FK_TechProcess002_CopyDrawingId</A></TD>
    <TD><P CLASS="Base2">CopyDrawingId</TD>
    <TD><P CLASS="Base2">Id</TD>
    <TD><P CLASS="Base2">SET NULL</TD>
    <TD><P CLASS="Base2">NO ACTION</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2"><A HREF="#TBL_TechProcess002">TechProcess002</A></TD>
    <TD><P CLASS="Base2"><A HREF="#FKEY_FK_TechProcess002_DrawingId">FK_TechProcess002_DrawingId</A></TD>
    <TD><P CLASS="Base2">DrawingId</TD>
    <TD><P CLASS="Base2">Id</TD>
    <TD><P CLASS="Base2">SET NULL</TD>
    <TD><P CLASS="Base2">NO ACTION</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2"><A HREF="#TBL_TechProcess003">TechProcess003</A></TD>
    <TD><P CLASS="Base2"><A HREF="#FKEY_FK_TechProcess003_CopyDrawingId">FK_TechProcess003_CopyDrawingId</A></TD>
    <TD><P CLASS="Base2">CopyDrawingId</TD>
    <TD><P CLASS="Base2">Id</TD>
    <TD><P CLASS="Base2">SET NULL</TD>
    <TD><P CLASS="Base2">NO ACTION</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2"><A HREF="#TBL_TechProcess003">TechProcess003</A></TD>
    <TD><P CLASS="Base2"><A HREF="#FKEY_FK_TechProcess003_DrawingId">FK_TechProcess003_DrawingId</A></TD>
    <TD><P CLASS="Base2">DrawingId</TD>
    <TD><P CLASS="Base2">Id</TD>
    <TD><P CLASS="Base2">SET NULL</TD>
    <TD><P CLASS="Base2">NO ACTION</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2"><A HREF="#TBL_TechProcess004">TechProcess004</A></TD>
    <TD><P CLASS="Base2"><A HREF="#FKEY_FK_TechProcess004_CopyDrawingId">FK_TechProcess004_CopyDrawingId</A></TD>
    <TD><P CLASS="Base2">CopyDrawingId</TD>
    <TD><P CLASS="Base2">Id</TD>
    <TD><P CLASS="Base2">SET NULL</TD>
    <TD><P CLASS="Base2">NO ACTION</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2"><A HREF="#TBL_TechProcess004">TechProcess004</A></TD>
    <TD><P CLASS="Base2"><A HREF="#FKEY_FK_TechProcess004_DrawingId">FK_TechProcess004_DrawingId</A></TD>
    <TD><P CLASS="Base2">DrawingId</TD>
    <TD><P CLASS="Base2">Id</TD>
    <TD><P CLASS="Base2">SET NULL</TD>
    <TD><P CLASS="Base2">NO ACTION</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2"><A HREF="#TBL_TechProcess005">TechProcess005</A></TD>
    <TD><P CLASS="Base2"><A HREF="#FKEY_FK_TechProcess005_CopyDrawingId">FK_TechProcess005_CopyDrawingId</A></TD>
    <TD><P CLASS="Base2">CopyDrawingId</TD>
    <TD><P CLASS="Base2">Id</TD>
    <TD><P CLASS="Base2">SET NULL</TD>
    <TD><P CLASS="Base2">NO ACTION</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2"><A HREF="#TBL_TechProcess005">TechProcess005</A></TD>
    <TD><P CLASS="Base2"><A HREF="#FKEY_FK_TechProcess005_DrawingId">FK_TechProcess005_DrawingId</A></TD>
    <TD><P CLASS="Base2">DrawingId</TD>
    <TD><P CLASS="Base2">Id</TD>
    <TD><P CLASS="Base2">SET NULL</TD>
    <TD><P CLASS="Base2">NO ACTION</TD>
  </TR>
</TABLE>
<P CLASS="Base">&nbsp;</P>
<P CLASS="Header1">Definition</P>
<P CLASS="Base"><span class="DDLCode">
<code><pre>
<b>CREATE</b><b> </b><b>TABLE</b><b> </b><font color="# 080 0"><u>&quot;Drawing&quot;</u></font><b> </b><b>(</b>
<b>    </b>&quot;Id&quot;<b>              </b><b>INTEGER</b><b> </b><b>NOT</b><b> </b><b>NULL</b><b>,</b>
<b>    </b>&quot;Number&quot;<b>          </b><b>VARCHAR</b><b>(</b>100<b>)</b><b> </b><b>CHARACTER</b><b> </b><b>SET</b><b> </b>WIN1251<b>,</b>
<b>    </b>&quot;MaterialId&quot;<b>      </b><b>INTEGER</b><b>,</b>
<b>    </b>&quot;TypeId&quot;<b>          </b><b>INTEGER</b><b>,</b>
<b>    </b>&quot;DetailId&quot;<b>        </b><b>INTEGER</b><b>,</b>
<b>    </b>&quot;RevisionId&quot;<b>      </b><b>INTEGER</b><b>,</b>
<b>    </b>&quot;DetailWeight&quot;<b>    </b><b>NUMERIC</b><b>(</b>10<b>,</b>2<b>)</b><b> </b><b>DEFAULT</b><b> </b>0<b>,</b>
<b>    </b>TH<b>                </b><b>VARCHAR</b><b>(</b>100<b>)</b><b>,</b>
<b>    </b>W<b>                 </b><b>VARCHAR</b><b>(</b>100<b>)</b><b>,</b>
<b>    </b>W2<b>                </b><b>VARCHAR</b><b>(</b>100<b>)</b><b>,</b>
<b>    </b>L<b>                 </b><b>VARCHAR</b><b>(</b>100<b>)</b><b>,</b>
<b>    </b>&quot;CreateDate&quot;<b>      </b><b>DATE</b><b> </b><b>DEFAULT</b><b> </b><b>CURRENT_DATE</b><b>,</b>
<b>    </b>&quot;ParentId&quot;<b>        </b><b>INTEGER</b><b>,</b>
<b>    </b>&quot;Note&quot;<b>            </b><b>VARCHAR</b><b>(</b>200<b>)</b><b> </b><b>CHARACTER</b><b> </b><b>SET</b><b> </b>WIN1251<b>,</b>
<b>    </b>&quot;Assembly&quot;<b>        </b><b>SMALLINT</b><b> </b><b>DEFAULT</b><b> </b>0<b>,</b>
<b>    </b>&quot;UserId&quot;<b>          </b><b>SMALLINT</b><b>,</b>
<b>    </b>&quot;NumberForParse&quot;<b>  </b><b>VARCHAR</b><b>(</b>100<b>)</b>
<b>)</b><b>;</b>


<b>ALTER</b><b> </b><b>TABLE</b><b> </b><font color="# 080 0"><u>&quot;Drawing&quot;</u></font><b> </b><b>ADD</b><b> </b><b>CONSTRAINT</b><b> </b>&quot;PK_DrawingId&quot;<b> </b><b>PRIMARY</b><b> </b><b>KEY</b><b> </b><b>(</b>&quot;Id&quot;<b>)</b><b>;</b>
<b>ALTER</b><b> </b><b>TABLE</b><b> </b><font color="# 080 0"><u>&quot;Drawing&quot;</u></font><b> </b><b>ADD</b><b> </b><b>CONSTRAINT</b><b> </b>&quot;FK_Drawing_DetId&quot;<b> </b><b>FOREIGN</b><b> </b><b>KEY</b><b> </b><b>(</b>&quot;DetailId&quot;<b>)</b><b> </b><b>REFERENCES</b><b> </b><font color="# 080 0"><u>&quot;Details&quot;</u></font><b> </b><b>(</b>&quot;Id&quot;<b>)</b><b> </b><b>ON</b><b> </b><b>DELETE</b><b> </b><b>SET</b><b> </b><b>NULL</b><b>;</b>
<b>ALTER</b><b> </b><b>TABLE</b><b> </b><font color="# 080 0"><u>&quot;Drawing&quot;</u></font><b> </b><b>ADD</b><b> </b><b>CONSTRAINT</b><b> </b>&quot;FK_Drawing_MatId&quot;<b> </b><b>FOREIGN</b><b> </b><b>KEY</b><b> </b><b>(</b>&quot;MaterialId&quot;<b>)</b><b> </b><b>REFERENCES</b><b> </b><font color="# 080 0"><u>&quot;Materials&quot;</u></font><b> </b><b>(</b>&quot;Id&quot;<b>)</b><b> </b><b>ON</b><b> </b><b>DELETE</b><b> </b><b>SET</b><b> </b><b>NULL</b><b>;</b>
<b>ALTER</b><b> </b><b>TABLE</b><b> </b><font color="# 080 0"><u>&quot;Drawing&quot;</u></font><b> </b><b>ADD</b><b> </b><b>CONSTRAINT</b><b> </b>&quot;FK_Drawing_ParentId&quot;<b> </b><b>FOREIGN</b><b> </b><b>KEY</b><b> </b><b>(</b>&quot;ParentId&quot;<b>)</b><b> </b><b>REFERENCES</b><b> </b><font color="# 080 0"><u>&quot;Drawing&quot;</u></font><b> </b><b>(</b>&quot;Id&quot;<b>)</b><b> </b><b>ON</b><b> </b><b>DELETE</b><b> </b><b>SET</b><b> </b><b>NULL</b><b>;</b>
<b>ALTER</b><b> </b><b>TABLE</b><b> </b><font color="# 080 0"><u>&quot;Drawing&quot;</u></font><b> </b><b>ADD</b><b> </b><b>CONSTRAINT</b><b> </b>&quot;FK_Drawing_RevId&quot;<b> </b><b>FOREIGN</b><b> </b><b>KEY</b><b> </b><b>(</b>&quot;RevisionId&quot;<b>)</b><b> </b><b>REFERENCES</b><b> </b><font color="# 080 0"><u>&quot;Revisions&quot;</u></font><b> </b><b>(</b>&quot;Id&quot;<b>)</b><b>;</b>
<b>ALTER</b><b> </b><b>TABLE</b><b> </b><font color="# 080 0"><u>&quot;Drawing&quot;</u></font><b> </b><b>ADD</b><b> </b><b>CONSTRAINT</b><b> </b>&quot;FK_Drawing_TypeId&quot;<b> </b><b>FOREIGN</b><b> </b><b>KEY</b><b> </b><b>(</b>&quot;TypeId&quot;<b>)</b><b> </b><b>REFERENCES</b><b> </b><font color="# 080 0"><u>&quot;Type&quot;</u></font><b> </b><b>(</b>&quot;Id&quot;<b>)</b><b> </b><b>ON</b><b> </b><b>DELETE</b><b> </b><b>SET</b><b> </b><b>NULL</b><b>;</b>
<b>ALTER</b><b> </b><b>TABLE</b><b> </b><font color="# 080 0"><u>&quot;Drawing&quot;</u></font><b> </b><b>ADD</b><b> </b><b>CONSTRAINT</b><b> </b>&quot;FK_Drawing_UserId&quot;<b> </b><b>FOREIGN</b><b> </b><b>KEY</b><b> </b><b>(</b>&quot;UserId&quot;<b>)</b><b> </b><b>REFERENCES</b><b> </b><font color="# 080 0"><u>&quot;Users&quot;</u></font><b> </b><b>(</b>&quot;Id&quot;<b>)</b><b>;</b>

</pre></code>
</span></P>
<P CLASS="Base">&nbsp;</P>

<HR>
<A NAME="TBL_DrawingScan"><P CLASS="Header0">Table: DrawingScan</P><P CLASS="Base">&nbsp;</P>
<P CLASS="Header1">Description</P>
<P CLASS="Base"><I>(There is no description for table DrawingScan)</I></P>
<P CLASS="Base">&nbsp;</P>
<P CLASS="Header1">Fields</P>
<TABLE CLASS="dtArg" CELLSPACING="0">
  <TH WIDTH="1%" ALIGN="middle"><P CLASS="Base2"><B>PK</B></P>
  <TH WIDTH="1%" ALIGN="middle"><P CLASS="Base2"><B>FK</B></P>
  <TH WIDTH="1%"><P CLASS="Base2"><B>Field</B></P>
  <TH WIDTH="1%"><P CLASS="Base2"><B>Domain</B></P>
  <TH WIDTH="20%"><P CLASS="Base2"><B>Type</B></P>
  <TH WIDTH="1%" ALIGN="middle"><P CLASS="Base2"><B>NN</B></P>
  <TH WIDTH="1%"><P CLASS="Base2"><B>Default</B></P>
  <TH WIDTH="40%"><P CLASS="Base2"><B>Description</B></P>
  <TR>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/PK1.gif" BORDER="0"></P></TD>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD><A NAME="DrawingScan.Id"><P CLASS="Base2">Id</P></A></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">INTEGER</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/Yes.gif" BORDER="0"></P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
  </TR>
  <TR>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/FK.gif" BORDER="0"></P></TD>
    <TD><A NAME="DrawingScan.DrawingId"><P CLASS="Base2">DrawingId</P></A></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">INTEGER</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
  </TR>
  <TR>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD><A NAME="DrawingScan.Scan"><P CLASS="Base2">Scan</P></A></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">BLOB SUB_TYPE 0 SEGMENT SIZE 4098</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
  </TR>
  <TR>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD><A NAME="DrawingScan.FileName"><P CLASS="Base2">FileName</P></A></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">VARCHAR(100)</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
  </TR>
  <TR>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD><A NAME="DrawingScan.Status"><P CLASS="Base2">Status</P></A></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">SMALLINT</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
  </TR>
</TABLE>
<P CLASS="Base">&nbsp;</P>
<P CLASS="Header1">Triggers</P>
<TABLE CLASS="dtArg" CELLSPACING="0">
  <TH WIDTH="1%"><P CLASS="Base2"><B>Trigger</B></P>
  <TH WIDTH="1%"><P CLASS="Base2"><B>Type</B></P>
  <TH WIDTH="1%"><P CLASS="Base2"><B>Activity</B></P>
  <TH WIDTH="1%"><P CLASS="Base2"><B>Order</B></P>
  <TH WIDTH="50%"><P CLASS="Base2"><B>Description</B></P>
  <TR>
    <TD><P CLASS="Base2"><A HREF="#TRG_Tr_BIO_DrawingScan">Tr_BIO_DrawingScan</A></TD>
    <TD><P CLASS="Base2">BEFORE&nbsp;INSERT</TD>
    <TD><P CLASS="Base2">Yes</TD>
    <TD ALIGN="right"><P CLASS="Base2">0</TD>
    <TD><P CLASS="Base2">&nbsp</TD>
  </TR>
</TABLE>
<P CLASS="Base">&nbsp;</P>
<P CLASS="Header1">Indices</P>
<TABLE CLASS="dtArg" CELLSPACING="0">
  <TH><P CLASS="Base2"><B>Index</B></P>
  <TH><P CLASS="Base2"><B>Fields</B></P>
  <TH ALIGN="middle"><P CLASS="Base2"><B>Active</B></P>
  <TH ALIGN="middle"><P CLASS="Base2"><B>Unique</B></P>
  <TH ALIGN="middle"><P CLASS="Base2"><B>Order</B></P>
  <TR>
    <TD><P CLASS="Base2"><A HREF="#IND_FK_DrawingScan_Drawing">FK_DrawingScan_Drawing</A></TD>
    <TD><P CLASS="Base2">"DrawingId"</TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/Yes.gif" BORDER="0"></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></TD>
    <TD ALIGN="middle"><P CLASS="Base2">ASC</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2"><A HREF="#IND_PK_DrawingScanId">PK_DrawingScanId</A></TD>
    <TD><P CLASS="Base2">"Id"</TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/Yes.gif" BORDER="0"></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/Yes.gif" BORDER="0"></TD>
    <TD ALIGN="middle"><P CLASS="Base2">ASC</TD>
  </TR>
</TABLE>
<P CLASS="Base">&nbsp;</P>
<P CLASS="Header1">References</P>
<TABLE CLASS="dtArg" CELLSPACING="0">
  <TH><P CLASS="Base2"><B>Table</B></P>
  <TH><P CLASS="Base2"><B>Foreign Key</B></P>
  <TH><P CLASS="Base2"><B>Fields</B></P>
  <TH><P CLASS="Base2"><B>FK Field</B></P>
  <TH><P CLASS="Base2"><B>Delete Rule</B></P>
  <TH><P CLASS="Base2"><B>Update Rule</B></P>
  <TR>
    <TD><P CLASS="Base2"><A HREF="#TBL_Drawing">Drawing</A></TD>
    <TD><P CLASS="Base2"><A HREF="#FKEY_FK_DrawingScan_Drawing">FK_DrawingScan_Drawing</A></TD>
    <TD><P CLASS="Base2">DrawingId</TD>
    <TD><P CLASS="Base2">Id</TD>
    <TD><P CLASS="Base2">CASCADE</TD>
    <TD><P CLASS="Base2">NO ACTION</TD>
  </TR>
</TABLE>
<P CLASS="Base">&nbsp;</P>
<P CLASS="Header1">Referenced By</P>
<P CLASS="Base"><I>(There are no tables referenced by table DrawingScan)</I></P>
<P CLASS="Base">&nbsp;</P>
<P CLASS="Header1">Definition</P>
<P CLASS="Base"><span class="DDLCode">
<code><pre>
<b>CREATE</b><b> </b><b>TABLE</b><b> </b><font color="# 080 0"><u>&quot;DrawingScan&quot;</u></font><b> </b><b>(</b>
<b>    </b>&quot;Id&quot;<b>         </b><b>INTEGER</b><b> </b><b>NOT</b><b> </b><b>NULL</b><b>,</b>
<b>    </b>&quot;DrawingId&quot;<b>  </b><b>INTEGER</b><b>,</b>
<b>    </b>&quot;Scan&quot;<b>       </b><b>BLOB</b><b> </b><b>SUB_TYPE</b><b> </b>0<b> </b><b>SEGMENT</b><b> </b><b>SIZE</b><b> </b>4098<b>,</b>
<b>    </b>&quot;FileName&quot;<b>   </b><b>VARCHAR</b><b>(</b>100<b>)</b><b>,</b>
<b>    </b>&quot;Status&quot;<b>     </b><b>SMALLINT</b>
<b>)</b><b>;</b>


<b>ALTER</b><b> </b><b>TABLE</b><b> </b><font color="# 080 0"><u>&quot;DrawingScan&quot;</u></font><b> </b><b>ADD</b><b> </b><b>CONSTRAINT</b><b> </b>&quot;PK_DrawingScanId&quot;<b> </b><b>PRIMARY</b><b> </b><b>KEY</b><b> </b><b>(</b>&quot;Id&quot;<b>)</b><b>;</b>
<b>ALTER</b><b> </b><b>TABLE</b><b> </b><font color="# 080 0"><u>&quot;DrawingScan&quot;</u></font><b> </b><b>ADD</b><b> </b><b>CONSTRAINT</b><b> </b>&quot;FK_DrawingScan_Drawing&quot;<b> </b><b>FOREIGN</b><b> </b><b>KEY</b><b> </b><b>(</b>&quot;DrawingId&quot;<b>)</b><b> </b><b>REFERENCES</b><b> </b><font color="# 080 0"><u>&quot;Drawing&quot;</u></font><b> </b><b>(</b>&quot;Id&quot;<b>)</b><b> </b><b>ON</b><b> </b><b>DELETE</b><b> </b><b>CASCADE</b><b>;</b>

</pre></code>
</span></P>
<P CLASS="Base">&nbsp;</P>

<HR>
<A NAME="TBL_Drawings"><P CLASS="Header0">Table: Drawings</P><P CLASS="Base">&nbsp;</P>
<P CLASS="Header1">Description</P>
<P CLASS="Base"><I>(There is no description for table Drawings)</I></P>
<P CLASS="Base">&nbsp;</P>
<P CLASS="Header1">Fields</P>
<TABLE CLASS="dtArg" CELLSPACING="0">
  <TH WIDTH="1%" ALIGN="middle"><P CLASS="Base2"><B>PK</B></P>
  <TH WIDTH="1%" ALIGN="middle"><P CLASS="Base2"><B>FK</B></P>
  <TH WIDTH="1%"><P CLASS="Base2"><B>Field</B></P>
  <TH WIDTH="1%"><P CLASS="Base2"><B>Domain</B></P>
  <TH WIDTH="20%"><P CLASS="Base2"><B>Type</B></P>
  <TH WIDTH="1%" ALIGN="middle"><P CLASS="Base2"><B>NN</B></P>
  <TH WIDTH="1%"><P CLASS="Base2"><B>Default</B></P>
  <TH WIDTH="40%"><P CLASS="Base2"><B>Description</B></P>
  <TR>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/PK1.gif" BORDER="0"></P></TD>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD><A NAME="Drawings.Id"><P CLASS="Base2">Id</P></A></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">INTEGER</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/Yes.gif" BORDER="0"></P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
  </TR>
  <TR>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/FK.gif" BORDER="0"></P></TD>
    <TD><A NAME="Drawings.ParentId"><P CLASS="Base2">ParentId</P></A></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">INTEGER</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
  </TR>
  <TR>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD><A NAME="Drawings.CurrentLevelMenu"><P CLASS="Base2">CurrentLevelMenu</P></A></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">VARCHAR(100)</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
  </TR>
  <TR>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/FK.gif" BORDER="0"></P></TD>
    <TD><A NAME="Drawings.DrawingId"><P CLASS="Base2">DrawingId</P></A></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">SMALLINT</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
  </TR>
  <TR>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/FK.gif" BORDER="0"></P></TD>
    <TD><A NAME="Drawings.ReplaceDrawingId"><P CLASS="Base2">ReplaceDrawingId</P></A></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">SMALLINT</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
  </TR>
  <TR>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/FK.gif" BORDER="0"></P></TD>
    <TD><A NAME="Drawings.OccurrenceId"><P CLASS="Base2">OccurrenceId</P></A></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">SMALLINT</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
  </TR>
  <TR>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD><A NAME="Drawings.Quantity"><P CLASS="Base2">Quantity</P></A></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">NUMERIC(5,2)</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></P></TD>
    <TD><P CLASS="Base2">0</P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
  </TR>
  <TR>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD><A NAME="Drawings.QuantityL"><P CLASS="Base2">QuantityL</P></A></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">NUMERIC(5,2)</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></P></TD>
    <TD><P CLASS="Base2">0</P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
  </TR>
  <TR>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD><A NAME="Drawings.QuantityR"><P CLASS="Base2">QuantityR</P></A></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">NUMERIC(5,2)</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></P></TD>
    <TD><P CLASS="Base2">0</P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
  </TR>
  <TR>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD><A NAME="Drawings.StructuraDisable"><P CLASS="Base2">StructuraDisable</P></A></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">SMALLINT</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></P></TD>
    <TD><P CLASS="Base2">0</P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
  </TR>
  <TR>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/FK.gif" BORDER="0"></P></TD>
    <TD><A NAME="Drawings.CurrentLevelMenuColorId"><P CLASS="Base2">CurrentLevelMenuColorId</P></A></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">SMALLINT</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
  </TR>
  <TR>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/FK.gif" BORDER="0"></P></TD>
    <TD><A NAME="Drawings.DrawingColorId"><P CLASS="Base2">DrawingColorId</P></A></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">SMALLINT</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
  </TR>
  <TR>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/FK.gif" BORDER="0"></P></TD>
    <TD><A NAME="Drawings.MaterialColorId"><P CLASS="Base2">MaterialColorId</P></A></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">SMALLINT</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
  </TR>
</TABLE>
<P CLASS="Base">&nbsp;</P>
<P CLASS="Header1">Triggers</P>
<TABLE CLASS="dtArg" CELLSPACING="0">
  <TH WIDTH="1%"><P CLASS="Base2"><B>Trigger</B></P>
  <TH WIDTH="1%"><P CLASS="Base2"><B>Type</B></P>
  <TH WIDTH="1%"><P CLASS="Base2"><B>Activity</B></P>
  <TH WIDTH="1%"><P CLASS="Base2"><B>Order</B></P>
  <TH WIDTH="50%"><P CLASS="Base2"><B>Description</B></P>
  <TR>
    <TD><P CLASS="Base2"><A HREF="#TRG_Tr_Drawings">Tr_Drawings</A></TD>
    <TD><P CLASS="Base2">BEFORE&nbsp;INSERT</TD>
    <TD><P CLASS="Base2">Yes</TD>
    <TD ALIGN="right"><P CLASS="Base2">0</TD>
    <TD><P CLASS="Base2">&nbsp</TD>
  </TR>
</TABLE>
<P CLASS="Base">&nbsp;</P>
<P CLASS="Header1">Indices</P>
<TABLE CLASS="dtArg" CELLSPACING="0">
  <TH><P CLASS="Base2"><B>Index</B></P>
  <TH><P CLASS="Base2"><B>Fields</B></P>
  <TH ALIGN="middle"><P CLASS="Base2"><B>Active</B></P>
  <TH ALIGN="middle"><P CLASS="Base2"><B>Unique</B></P>
  <TH ALIGN="middle"><P CLASS="Base2"><B>Order</B></P>
  <TR>
    <TD><P CLASS="Base2"><A HREF="#IND_FK_ColorId_CurrentLevelMenuId">FK_ColorId_CurrentLevelMenuId</A></TD>
    <TD><P CLASS="Base2">"CurrentLevelMenuColorId"</TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/Yes.gif" BORDER="0"></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></TD>
    <TD ALIGN="middle"><P CLASS="Base2">ASC</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2"><A HREF="#IND_FK_ColorId_DrawingId">FK_ColorId_DrawingId</A></TD>
    <TD><P CLASS="Base2">"DrawingColorId"</TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/Yes.gif" BORDER="0"></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></TD>
    <TD ALIGN="middle"><P CLASS="Base2">ASC</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2"><A HREF="#IND_FK_ColorId_MaterialId">FK_ColorId_MaterialId</A></TD>
    <TD><P CLASS="Base2">"MaterialColorId"</TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/Yes.gif" BORDER="0"></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></TD>
    <TD ALIGN="middle"><P CLASS="Base2">ASC</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2"><A HREF="#IND_FK_Drawings_DrawingId">FK_Drawings_DrawingId</A></TD>
    <TD><P CLASS="Base2">"DrawingId"</TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/Yes.gif" BORDER="0"></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></TD>
    <TD ALIGN="middle"><P CLASS="Base2">ASC</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2"><A HREF="#IND_FK_Drawings_Id">FK_Drawings_Id</A></TD>
    <TD><P CLASS="Base2">"ParentId"</TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/Yes.gif" BORDER="0"></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></TD>
    <TD ALIGN="middle"><P CLASS="Base2">ASC</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2"><A HREF="#IND_FK_Drawings_OccurrenceId">FK_Drawings_OccurrenceId</A></TD>
    <TD><P CLASS="Base2">"OccurrenceId"</TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/Yes.gif" BORDER="0"></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></TD>
    <TD ALIGN="middle"><P CLASS="Base2">ASC</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2"><A HREF="#IND_FK_Drawings_ReplaceDrawingId">FK_Drawings_ReplaceDrawingId</A></TD>
    <TD><P CLASS="Base2">"ReplaceDrawingId"</TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/Yes.gif" BORDER="0"></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></TD>
    <TD ALIGN="middle"><P CLASS="Base2">ASC</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2"><A HREF="#IND_PK_DrawingsId">PK_DrawingsId</A></TD>
    <TD><P CLASS="Base2">"Id"</TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/Yes.gif" BORDER="0"></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/Yes.gif" BORDER="0"></TD>
    <TD ALIGN="middle"><P CLASS="Base2">ASC</TD>
  </TR>
</TABLE>
<P CLASS="Base">&nbsp;</P>
<P CLASS="Header1">References</P>
<TABLE CLASS="dtArg" CELLSPACING="0">
  <TH><P CLASS="Base2"><B>Table</B></P>
  <TH><P CLASS="Base2"><B>Foreign Key</B></P>
  <TH><P CLASS="Base2"><B>Fields</B></P>
  <TH><P CLASS="Base2"><B>FK Field</B></P>
  <TH><P CLASS="Base2"><B>Delete Rule</B></P>
  <TH><P CLASS="Base2"><B>Update Rule</B></P>
  <TR>
    <TD><P CLASS="Base2"><A HREF="#TBL_Colors">Colors</A></TD>
    <TD><P CLASS="Base2"><A HREF="#FKEY_FK_ColorId_CurrentLevelMenuId">FK_ColorId_CurrentLevelMenuId</A></TD>
    <TD><P CLASS="Base2">CurrentLevelMenuColorId</TD>
    <TD><P CLASS="Base2">Id</TD>
    <TD><P CLASS="Base2">SET NULL</TD>
    <TD><P CLASS="Base2">NO ACTION</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2"><A HREF="#TBL_Colors">Colors</A></TD>
    <TD><P CLASS="Base2"><A HREF="#FKEY_FK_ColorId_DrawingId">FK_ColorId_DrawingId</A></TD>
    <TD><P CLASS="Base2">DrawingColorId</TD>
    <TD><P CLASS="Base2">Id</TD>
    <TD><P CLASS="Base2">SET NULL</TD>
    <TD><P CLASS="Base2">NO ACTION</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2"><A HREF="#TBL_Colors">Colors</A></TD>
    <TD><P CLASS="Base2"><A HREF="#FKEY_FK_ColorId_MaterialId">FK_ColorId_MaterialId</A></TD>
    <TD><P CLASS="Base2">MaterialColorId</TD>
    <TD><P CLASS="Base2">Id</TD>
    <TD><P CLASS="Base2">SET NULL</TD>
    <TD><P CLASS="Base2">NO ACTION</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2"><A HREF="#TBL_Drawing">Drawing</A></TD>
    <TD><P CLASS="Base2"><A HREF="#FKEY_FK_Drawings_DrawingId">FK_Drawings_DrawingId</A></TD>
    <TD><P CLASS="Base2">DrawingId</TD>
    <TD><P CLASS="Base2">Id</TD>
    <TD><P CLASS="Base2">SET NULL</TD>
    <TD><P CLASS="Base2">NO ACTION</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2"><A HREF="#TBL_Drawings">Drawings</A></TD>
    <TD><P CLASS="Base2"><A HREF="#FKEY_FK_Drawings_Id">FK_Drawings_Id</A></TD>
    <TD><P CLASS="Base2">ParentId</TD>
    <TD><P CLASS="Base2">Id</TD>
    <TD><P CLASS="Base2">CASCADE</TD>
    <TD><P CLASS="Base2">NO ACTION</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2"><A HREF="#TBL_Drawing">Drawing</A></TD>
    <TD><P CLASS="Base2"><A HREF="#FKEY_FK_Drawings_OccurrenceId">FK_Drawings_OccurrenceId</A></TD>
    <TD><P CLASS="Base2">OccurrenceId</TD>
    <TD><P CLASS="Base2">Id</TD>
    <TD><P CLASS="Base2">SET NULL</TD>
    <TD><P CLASS="Base2">NO ACTION</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2"><A HREF="#TBL_Drawing">Drawing</A></TD>
    <TD><P CLASS="Base2"><A HREF="#FKEY_FK_Drawings_ReplaceDrawingId">FK_Drawings_ReplaceDrawingId</A></TD>
    <TD><P CLASS="Base2">ReplaceDrawingId</TD>
    <TD><P CLASS="Base2">Id</TD>
    <TD><P CLASS="Base2">SET NULL</TD>
    <TD><P CLASS="Base2">NO ACTION</TD>
  </TR>
</TABLE>
<P CLASS="Base">&nbsp;</P>
<P CLASS="Header1">Referenced By</P>
<TABLE CLASS="dtArg" CELLSPACING="0">
  <TH><P CLASS="Base2"><B>Table</B></P>
  <TH><P CLASS="Base2"><B>Foreign Key</B></P>
  <TH><P CLASS="Base2"><B>Fields</B></P>
  <TH><P CLASS="Base2"><B>FK Field</B></P>
  <TH><P CLASS="Base2"><B>Delete Rule</B></P>
  <TH><P CLASS="Base2"><B>Update Rule</B></P>
  <TR>
    <TD><P CLASS="Base2"><A HREF="#TBL_Drawings">Drawings</A></TD>
    <TD><P CLASS="Base2"><A HREF="#FKEY_FK_Drawings_Id">FK_Drawings_Id</A></TD>
    <TD><P CLASS="Base2">ParentId</TD>
    <TD><P CLASS="Base2">Id</TD>
    <TD><P CLASS="Base2">CASCADE</TD>
    <TD><P CLASS="Base2">NO ACTION</TD>
  </TR>
</TABLE>
<P CLASS="Base">&nbsp;</P>
<P CLASS="Header1">Definition</P>
<P CLASS="Base"><span class="DDLCode">
<code><pre>
<b>CREATE</b><b> </b><b>TABLE</b><b> </b><font color="# 080 0"><u>&quot;Drawings&quot;</u></font><b> </b><b>(</b>
<b>    </b>&quot;Id&quot;<b>                       </b><b>INTEGER</b><b> </b><b>NOT</b><b> </b><b>NULL</b><b>,</b>
<b>    </b>&quot;ParentId&quot;<b>                 </b><b>INTEGER</b><b>,</b>
<b>    </b>&quot;CurrentLevelMenu&quot;<b>         </b><b>VARCHAR</b><b>(</b>100<b>)</b><b>,</b>
<b>    </b>&quot;DrawingId&quot;<b>                </b><b>SMALLINT</b><b>,</b>
<b>    </b>&quot;ReplaceDrawingId&quot;<b>         </b><b>SMALLINT</b><b>,</b>
<b>    </b>&quot;OccurrenceId&quot;<b>             </b><b>SMALLINT</b><b>,</b>
<b>    </b>&quot;Quantity&quot;<b>                 </b><b>NUMERIC</b><b>(</b>5<b>,</b>2<b>)</b><b> </b><b>DEFAULT</b><b> </b>0<b>,</b>
<b>    </b>&quot;QuantityL&quot;<b>                </b><b>NUMERIC</b><b>(</b>5<b>,</b>2<b>)</b><b> </b><b>DEFAULT</b><b> </b>0<b>,</b>
<b>    </b>&quot;QuantityR&quot;<b>                </b><b>NUMERIC</b><b>(</b>5<b>,</b>2<b>)</b><b> </b><b>DEFAULT</b><b> </b>0<b>,</b>
<b>    </b>&quot;StructuraDisable&quot;<b>         </b><b>SMALLINT</b><b> </b><b>DEFAULT</b><b> </b>0<b>,</b>
<b>    </b>&quot;CurrentLevelMenuColorId&quot;<b>  </b><b>SMALLINT</b><b>,</b>
<b>    </b>&quot;DrawingColorId&quot;<b>           </b><b>SMALLINT</b><b>,</b>
<b>    </b>&quot;MaterialColorId&quot;<b>          </b><b>SMALLINT</b>
<b>)</b><b>;</b>


<b>ALTER</b><b> </b><b>TABLE</b><b> </b><font color="# 080 0"><u>&quot;Drawings&quot;</u></font><b> </b><b>ADD</b><b> </b><b>CONSTRAINT</b><b> </b>&quot;PK_DrawingsId&quot;<b> </b><b>PRIMARY</b><b> </b><b>KEY</b><b> </b><b>(</b>&quot;Id&quot;<b>)</b><b>;</b>
<b>ALTER</b><b> </b><b>TABLE</b><b> </b><font color="# 080 0"><u>&quot;Drawings&quot;</u></font><b> </b><b>ADD</b><b> </b><b>CONSTRAINT</b><b> </b>&quot;FK_ColorId_CurrentLevelMenuId&quot;<b> </b><b>FOREIGN</b><b> </b><b>KEY</b><b> </b><b>(</b>&quot;CurrentLevelMenuColorId&quot;<b>)</b><b> </b><b>REFERENCES</b><b> </b><font color="# 080 0"><u>&quot;Colors&quot;</u></font><b> </b><b>(</b>&quot;Id&quot;<b>)</b><b> </b><b>ON</b><b> </b><b>DELETE</b><b> </b><b>SET</b><b> </b><b>NULL</b><b>;</b>
<b>ALTER</b><b> </b><b>TABLE</b><b> </b><font color="# 080 0"><u>&quot;Drawings&quot;</u></font><b> </b><b>ADD</b><b> </b><b>CONSTRAINT</b><b> </b>&quot;FK_ColorId_DrawingId&quot;<b> </b><b>FOREIGN</b><b> </b><b>KEY</b><b> </b><b>(</b>&quot;DrawingColorId&quot;<b>)</b><b> </b><b>REFERENCES</b><b> </b><font color="# 080 0"><u>&quot;Colors&quot;</u></font><b> </b><b>(</b>&quot;Id&quot;<b>)</b><b> </b><b>ON</b><b> </b><b>DELETE</b><b> </b><b>SET</b><b> </b><b>NULL</b><b>;</b>
<b>ALTER</b><b> </b><b>TABLE</b><b> </b><font color="# 080 0"><u>&quot;Drawings&quot;</u></font><b> </b><b>ADD</b><b> </b><b>CONSTRAINT</b><b> </b>&quot;FK_ColorId_MaterialId&quot;<b> </b><b>FOREIGN</b><b> </b><b>KEY</b><b> </b><b>(</b>&quot;MaterialColorId&quot;<b>)</b><b> </b><b>REFERENCES</b><b> </b><font color="# 080 0"><u>&quot;Colors&quot;</u></font><b> </b><b>(</b>&quot;Id&quot;<b>)</b><b> </b><b>ON</b><b> </b><b>DELETE</b><b> </b><b>SET</b><b> </b><b>NULL</b><b>;</b>
<b>ALTER</b><b> </b><b>TABLE</b><b> </b><font color="# 080 0"><u>&quot;Drawings&quot;</u></font><b> </b><b>ADD</b><b> </b><b>CONSTRAINT</b><b> </b>&quot;FK_Drawings_DrawingId&quot;<b> </b><b>FOREIGN</b><b> </b><b>KEY</b><b> </b><b>(</b>&quot;DrawingId&quot;<b>)</b><b> </b><b>REFERENCES</b><b> </b><font color="# 080 0"><u>&quot;Drawing&quot;</u></font><b> </b><b>(</b>&quot;Id&quot;<b>)</b><b> </b><b>ON</b><b> </b><b>DELETE</b><b> </b><b>SET</b><b> </b><b>NULL</b><b>;</b>
<b>ALTER</b><b> </b><b>TABLE</b><b> </b><font color="# 080 0"><u>&quot;Drawings&quot;</u></font><b> </b><b>ADD</b><b> </b><b>CONSTRAINT</b><b> </b>&quot;FK_Drawings_Id&quot;<b> </b><b>FOREIGN</b><b> </b><b>KEY</b><b> </b><b>(</b>&quot;ParentId&quot;<b>)</b><b> </b><b>REFERENCES</b><b> </b><font color="# 080 0"><u>&quot;Drawings&quot;</u></font><b> </b><b>(</b>&quot;Id&quot;<b>)</b><b> </b><b>ON</b><b> </b><b>DELETE</b><b> </b><b>CASCADE</b><b>;</b>
<b>ALTER</b><b> </b><b>TABLE</b><b> </b><font color="# 080 0"><u>&quot;Drawings&quot;</u></font><b> </b><b>ADD</b><b> </b><b>CONSTRAINT</b><b> </b>&quot;FK_Drawings_OccurrenceId&quot;<b> </b><b>FOREIGN</b><b> </b><b>KEY</b><b> </b><b>(</b>&quot;OccurrenceId&quot;<b>)</b><b> </b><b>REFERENCES</b><b> </b><font color="# 080 0"><u>&quot;Drawing&quot;</u></font><b> </b><b>(</b>&quot;Id&quot;<b>)</b><b> </b><b>ON</b><b> </b><b>DELETE</b><b> </b><b>SET</b><b> </b><b>NULL</b><b>;</b>
<b>ALTER</b><b> </b><b>TABLE</b><b> </b><font color="# 080 0"><u>&quot;Drawings&quot;</u></font><b> </b><b>ADD</b><b> </b><b>CONSTRAINT</b><b> </b>&quot;FK_Drawings_ReplaceDrawingId&quot;<b> </b><b>FOREIGN</b><b> </b><b>KEY</b><b> </b><b>(</b>&quot;ReplaceDrawingId&quot;<b>)</b><b> </b><b>REFERENCES</b><b> </b><font color="# 080 0"><u>&quot;Drawing&quot;</u></font><b> </b><b>(</b>&quot;Id&quot;<b>)</b><b> </b><b>ON</b><b> </b><b>DELETE</b><b> </b><b>SET</b><b> </b><b>NULL</b><b>;</b>

</pre></code>
</span></P>
<P CLASS="Base">&nbsp;</P>

<HR>
<A NAME="TBL_Materials"><P CLASS="Header0">Table: Materials</P><P CLASS="Base">&nbsp;</P>
<P CLASS="Header1">Description</P>
<P CLASS="Base"><I>(There is no description for table Materials)</I></P>
<P CLASS="Base">&nbsp;</P>
<P CLASS="Header1">Fields</P>
<TABLE CLASS="dtArg" CELLSPACING="0">
  <TH WIDTH="1%" ALIGN="middle"><P CLASS="Base2"><B>PK</B></P>
  <TH WIDTH="1%" ALIGN="middle"><P CLASS="Base2"><B>FK</B></P>
  <TH WIDTH="1%"><P CLASS="Base2"><B>Field</B></P>
  <TH WIDTH="1%"><P CLASS="Base2"><B>Domain</B></P>
  <TH WIDTH="20%"><P CLASS="Base2"><B>Type</B></P>
  <TH WIDTH="1%" ALIGN="middle"><P CLASS="Base2"><B>NN</B></P>
  <TH WIDTH="1%"><P CLASS="Base2"><B>Default</B></P>
  <TH WIDTH="40%"><P CLASS="Base2"><B>Description</B></P>
  <TR>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/PK1.gif" BORDER="0"></P></TD>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD><A NAME="Materials.Id"><P CLASS="Base2">Id</P></A></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">INTEGER</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/Yes.gif" BORDER="0"></P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
  </TR>
  <TR>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD><A NAME="Materials.MaterialName"><P CLASS="Base2">MaterialName</P></A></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">VARCHAR(50)</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
  </TR>
</TABLE>
<P CLASS="Base">&nbsp;</P>
<P CLASS="Header1">Triggers</P>
<TABLE CLASS="dtArg" CELLSPACING="0">
  <TH WIDTH="1%"><P CLASS="Base2"><B>Trigger</B></P>
  <TH WIDTH="1%"><P CLASS="Base2"><B>Type</B></P>
  <TH WIDTH="1%"><P CLASS="Base2"><B>Activity</B></P>
  <TH WIDTH="1%"><P CLASS="Base2"><B>Order</B></P>
  <TH WIDTH="50%"><P CLASS="Base2"><B>Description</B></P>
  <TR>
    <TD><P CLASS="Base2"><A HREF="#TRG_Tr_Materials">Tr_Materials</A></TD>
    <TD><P CLASS="Base2">BEFORE&nbsp;INSERT</TD>
    <TD><P CLASS="Base2">Yes</TD>
    <TD ALIGN="right"><P CLASS="Base2">0</TD>
    <TD><P CLASS="Base2">&nbsp</TD>
  </TR>
</TABLE>
<P CLASS="Base">&nbsp;</P>
<P CLASS="Header1">Indices</P>
<TABLE CLASS="dtArg" CELLSPACING="0">
  <TH><P CLASS="Base2"><B>Index</B></P>
  <TH><P CLASS="Base2"><B>Fields</B></P>
  <TH ALIGN="middle"><P CLASS="Base2"><B>Active</B></P>
  <TH ALIGN="middle"><P CLASS="Base2"><B>Unique</B></P>
  <TH ALIGN="middle"><P CLASS="Base2"><B>Order</B></P>
  <TR>
    <TD><P CLASS="Base2"><A HREF="#IND_PK_MaterialsId">PK_MaterialsId</A></TD>
    <TD><P CLASS="Base2">"Id"</TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/Yes.gif" BORDER="0"></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/Yes.gif" BORDER="0"></TD>
    <TD ALIGN="middle"><P CLASS="Base2">ASC</TD>
  </TR>
</TABLE>
<P CLASS="Base">&nbsp;</P>
<P CLASS="Header1">References</P>
<P CLASS="Base"><I>(There are no references for table Materials)</I></P>
<P CLASS="Base">&nbsp;</P>
<P CLASS="Header1">Referenced By</P>
<TABLE CLASS="dtArg" CELLSPACING="0">
  <TH><P CLASS="Base2"><B>Table</B></P>
  <TH><P CLASS="Base2"><B>Foreign Key</B></P>
  <TH><P CLASS="Base2"><B>Fields</B></P>
  <TH><P CLASS="Base2"><B>FK Field</B></P>
  <TH><P CLASS="Base2"><B>Delete Rule</B></P>
  <TH><P CLASS="Base2"><B>Update Rule</B></P>
  <TR>
    <TD><P CLASS="Base2"><A HREF="#TBL_Drawing">Drawing</A></TD>
    <TD><P CLASS="Base2"><A HREF="#FKEY_FK_Drawing_MatId">FK_Drawing_MatId</A></TD>
    <TD><P CLASS="Base2">MaterialId</TD>
    <TD><P CLASS="Base2">Id</TD>
    <TD><P CLASS="Base2">SET NULL</TD>
    <TD><P CLASS="Base2">NO ACTION</TD>
  </TR>
</TABLE>
<P CLASS="Base">&nbsp;</P>
<P CLASS="Header1">Definition</P>
<P CLASS="Base"><span class="DDLCode">
<code><pre>
<b>CREATE</b><b> </b><b>TABLE</b><b> </b><font color="# 080 0"><u>&quot;Materials&quot;</u></font><b> </b><b>(</b>
<b>    </b>&quot;Id&quot;<b>            </b><b>INTEGER</b><b> </b><b>NOT</b><b> </b><b>NULL</b><b>,</b>
<b>    </b>&quot;MaterialName&quot;<b>  </b><b>VARCHAR</b><b>(</b>50<b>)</b>
<b>)</b><b>;</b>


<b>ALTER</b><b> </b><b>TABLE</b><b> </b><font color="# 080 0"><u>&quot;Materials&quot;</u></font><b> </b><b>ADD</b><b> </b><b>CONSTRAINT</b><b> </b>&quot;PK_MaterialsId&quot;<b> </b><b>PRIMARY</b><b> </b><b>KEY</b><b> </b><b>(</b>&quot;Id&quot;<b>)</b><b>;</b>

</pre></code>
</span></P>
<P CLASS="Base">&nbsp;</P>

<HR>
<A NAME="TBL_OperationName"><P CLASS="Header0">Table: OperationName</P><P CLASS="Base">&nbsp;</P>
<P CLASS="Header1">Description</P>
<P CLASS="Base"><I>(There is no description for table OperationName)</I></P>
<P CLASS="Base">&nbsp;</P>
<P CLASS="Header1">Fields</P>
<TABLE CLASS="dtArg" CELLSPACING="0">
  <TH WIDTH="1%" ALIGN="middle"><P CLASS="Base2"><B>PK</B></P>
  <TH WIDTH="1%" ALIGN="middle"><P CLASS="Base2"><B>FK</B></P>
  <TH WIDTH="1%"><P CLASS="Base2"><B>Field</B></P>
  <TH WIDTH="1%"><P CLASS="Base2"><B>Domain</B></P>
  <TH WIDTH="20%"><P CLASS="Base2"><B>Type</B></P>
  <TH WIDTH="1%" ALIGN="middle"><P CLASS="Base2"><B>NN</B></P>
  <TH WIDTH="1%"><P CLASS="Base2"><B>Default</B></P>
  <TH WIDTH="40%"><P CLASS="Base2"><B>Description</B></P>
  <TR>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/PK1.gif" BORDER="0"></P></TD>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD><A NAME="OperationName.Id"><P CLASS="Base2">Id</P></A></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">INTEGER</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/Yes.gif" BORDER="0"></P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
  </TR>
  <TR>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD><A NAME="OperationName.TableId"><P CLASS="Base2">TableId</P></A></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">VARCHAR(5)</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
  </TR>
  <TR>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD><A NAME="OperationName.Code"><P CLASS="Base2">Code</P></A></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">VARCHAR(20)</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
  </TR>
  <TR>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD><A NAME="OperationName.NameRus"><P CLASS="Base2">NameRus</P></A></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">VARCHAR(100)</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
  </TR>
  <TR>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD><A NAME="OperationName.NameEng"><P CLASS="Base2">NameEng</P></A></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">VARCHAR(100)</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
  </TR>
  <TR>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD><A NAME="OperationName.NameAr"><P CLASS="Base2">NameAr</P></A></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">VARCHAR(100)</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
  </TR>
</TABLE>
<P CLASS="Base">&nbsp;</P>
<P CLASS="Header1">Triggers</P>
<TABLE CLASS="dtArg" CELLSPACING="0">
  <TH WIDTH="1%"><P CLASS="Base2"><B>Trigger</B></P>
  <TH WIDTH="1%"><P CLASS="Base2"><B>Type</B></P>
  <TH WIDTH="1%"><P CLASS="Base2"><B>Activity</B></P>
  <TH WIDTH="1%"><P CLASS="Base2"><B>Order</B></P>
  <TH WIDTH="50%"><P CLASS="Base2"><B>Description</B></P>
  <TR>
    <TD><P CLASS="Base2"><A HREF="#TRG_Tr_OperationName">Tr_OperationName</A></TD>
    <TD><P CLASS="Base2">BEFORE&nbsp;INSERT</TD>
    <TD><P CLASS="Base2">Yes</TD>
    <TD ALIGN="right"><P CLASS="Base2">0</TD>
    <TD><P CLASS="Base2">&nbsp</TD>
  </TR>
</TABLE>
<P CLASS="Base">&nbsp;</P>
<P CLASS="Header1">Indices</P>
<TABLE CLASS="dtArg" CELLSPACING="0">
  <TH><P CLASS="Base2"><B>Index</B></P>
  <TH><P CLASS="Base2"><B>Fields</B></P>
  <TH ALIGN="middle"><P CLASS="Base2"><B>Active</B></P>
  <TH ALIGN="middle"><P CLASS="Base2"><B>Unique</B></P>
  <TH ALIGN="middle"><P CLASS="Base2"><B>Order</B></P>
  <TR>
    <TD><P CLASS="Base2"><A HREF="#IND_PK_OperationNameId">PK_OperationNameId</A></TD>
    <TD><P CLASS="Base2">"Id"</TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/Yes.gif" BORDER="0"></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/Yes.gif" BORDER="0"></TD>
    <TD ALIGN="middle"><P CLASS="Base2">ASC</TD>
  </TR>
</TABLE>
<P CLASS="Base">&nbsp;</P>
<P CLASS="Header1">References</P>
<P CLASS="Base"><I>(There are no references for table OperationName)</I></P>
<P CLASS="Base">&nbsp;</P>
<P CLASS="Header1">Referenced By</P>
<P CLASS="Base"><I>(There are no tables referenced by table OperationName)</I></P>
<P CLASS="Base">&nbsp;</P>
<P CLASS="Header1">Definition</P>
<P CLASS="Base"><span class="DDLCode">
<code><pre>
<b>CREATE</b><b> </b><b>TABLE</b><b> </b><font color="# 080 0"><u>&quot;OperationName&quot;</u></font><b> </b><b>(</b>
<b>    </b>&quot;Id&quot;<b>       </b><b>INTEGER</b><b> </b><b>NOT</b><b> </b><b>NULL</b><b>,</b>
<b>    </b>&quot;TableId&quot;<b>  </b><b>VARCHAR</b><b>(</b>5<b>)</b><b>,</b>
<b>    </b>&quot;Code&quot;<b>     </b><b>VARCHAR</b><b>(</b>20<b>)</b><b>,</b>
<b>    </b>&quot;NameRus&quot;<b>  </b><b>VARCHAR</b><b>(</b>100<b>)</b><b> </b><b>CHARACTER</b><b> </b><b>SET</b><b> </b>WIN1251<b>,</b>
<b>    </b>&quot;NameEng&quot;<b>  </b><b>VARCHAR</b><b>(</b>100<b>)</b><b> </b><b>CHARACTER</b><b> </b><b>SET</b><b> </b>WIN1251<b>,</b>
<b>    </b>&quot;NameAr&quot;<b>   </b><b>VARCHAR</b><b>(</b>100<b>)</b><b> </b><b>CHARACTER</b><b> </b><b>SET</b><b> </b>WIN1256
<b>)</b><b>;</b>


<b>ALTER</b><b> </b><b>TABLE</b><b> </b><font color="# 080 0"><u>&quot;OperationName&quot;</u></font><b> </b><b>ADD</b><b> </b><b>CONSTRAINT</b><b> </b>&quot;PK_OperationNameId&quot;<b> </b><b>PRIMARY</b><b> </b><b>KEY</b><b> </b><b>(</b>&quot;Id&quot;<b>)</b><b>;</b>

</pre></code>
</span></P>
<P CLASS="Base">&nbsp;</P>

<HR>
<A NAME="TBL_OperationNumber"><P CLASS="Header0">Table: OperationNumber</P><P CLASS="Base">&nbsp;</P>
<P CLASS="Header1">Description</P>
<P CLASS="Base"><I>(There is no description for table OperationNumber)</I></P>
<P CLASS="Base">&nbsp;</P>
<P CLASS="Header1">Fields</P>
<TABLE CLASS="dtArg" CELLSPACING="0">
  <TH WIDTH="1%" ALIGN="middle"><P CLASS="Base2"><B>PK</B></P>
  <TH WIDTH="1%" ALIGN="middle"><P CLASS="Base2"><B>FK</B></P>
  <TH WIDTH="1%"><P CLASS="Base2"><B>Field</B></P>
  <TH WIDTH="1%"><P CLASS="Base2"><B>Domain</B></P>
  <TH WIDTH="20%"><P CLASS="Base2"><B>Type</B></P>
  <TH WIDTH="1%" ALIGN="middle"><P CLASS="Base2"><B>NN</B></P>
  <TH WIDTH="1%"><P CLASS="Base2"><B>Default</B></P>
  <TH WIDTH="40%"><P CLASS="Base2"><B>Description</B></P>
  <TR>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/PK1.gif" BORDER="0"></P></TD>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD><A NAME="OperationNumber.Id"><P CLASS="Base2">Id</P></A></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">INTEGER</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/Yes.gif" BORDER="0"></P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
  </TR>
  <TR>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD><A NAME="OperationNumber.TableId"><P CLASS="Base2">TableId</P></A></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">VARCHAR(5)</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
  </TR>
  <TR>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD><A NAME="OperationNumber.OperationNumberName"><P CLASS="Base2">OperationNumberName</P></A></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">VARCHAR(15)</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
  </TR>
</TABLE>
<P CLASS="Base">&nbsp;</P>
<P CLASS="Header1">Triggers</P>
<TABLE CLASS="dtArg" CELLSPACING="0">
  <TH WIDTH="1%"><P CLASS="Base2"><B>Trigger</B></P>
  <TH WIDTH="1%"><P CLASS="Base2"><B>Type</B></P>
  <TH WIDTH="1%"><P CLASS="Base2"><B>Activity</B></P>
  <TH WIDTH="1%"><P CLASS="Base2"><B>Order</B></P>
  <TH WIDTH="50%"><P CLASS="Base2"><B>Description</B></P>
  <TR>
    <TD><P CLASS="Base2"><A HREF="#TRG_Tr_OperationNumber">Tr_OperationNumber</A></TD>
    <TD><P CLASS="Base2">BEFORE&nbsp;INSERT</TD>
    <TD><P CLASS="Base2">Yes</TD>
    <TD ALIGN="right"><P CLASS="Base2">0</TD>
    <TD><P CLASS="Base2">&nbsp</TD>
  </TR>
</TABLE>
<P CLASS="Base">&nbsp;</P>
<P CLASS="Header1">Indices</P>
<TABLE CLASS="dtArg" CELLSPACING="0">
  <TH><P CLASS="Base2"><B>Index</B></P>
  <TH><P CLASS="Base2"><B>Fields</B></P>
  <TH ALIGN="middle"><P CLASS="Base2"><B>Active</B></P>
  <TH ALIGN="middle"><P CLASS="Base2"><B>Unique</B></P>
  <TH ALIGN="middle"><P CLASS="Base2"><B>Order</B></P>
  <TR>
    <TD><P CLASS="Base2"><A HREF="#IND_PK_OperationNumberId">PK_OperationNumberId</A></TD>
    <TD><P CLASS="Base2">"Id"</TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/Yes.gif" BORDER="0"></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/Yes.gif" BORDER="0"></TD>
    <TD ALIGN="middle"><P CLASS="Base2">ASC</TD>
  </TR>
</TABLE>
<P CLASS="Base">&nbsp;</P>
<P CLASS="Header1">References</P>
<P CLASS="Base"><I>(There are no references for table OperationNumber)</I></P>
<P CLASS="Base">&nbsp;</P>
<P CLASS="Header1">Referenced By</P>
<P CLASS="Base"><I>(There are no tables referenced by table OperationNumber)</I></P>
<P CLASS="Base">&nbsp;</P>
<P CLASS="Header1">Definition</P>
<P CLASS="Base"><span class="DDLCode">
<code><pre>
<b>CREATE</b><b> </b><b>TABLE</b><b> </b><font color="# 080 0"><u>&quot;OperationNumber&quot;</u></font><b> </b><b>(</b>
<b>    </b>&quot;Id&quot;<b>                   </b><b>INTEGER</b><b> </b><b>NOT</b><b> </b><b>NULL</b><b>,</b>
<b>    </b>&quot;TableId&quot;<b>              </b><b>VARCHAR</b><b>(</b>5<b>)</b><b>,</b>
<b>    </b>&quot;OperationNumberName&quot;<b>  </b><b>VARCHAR</b><b>(</b>15<b>)</b>
<b>)</b><b>;</b>


<b>ALTER</b><b> </b><b>TABLE</b><b> </b><font color="# 080 0"><u>&quot;OperationNumber&quot;</u></font><b> </b><b>ADD</b><b> </b><b>CONSTRAINT</b><b> </b>&quot;PK_OperationNumberId&quot;<b> </b><b>PRIMARY</b><b> </b><b>KEY</b><b> </b><b>(</b>&quot;Id&quot;<b>)</b><b>;</b>

</pre></code>
</span></P>
<P CLASS="Base">&nbsp;</P>

<HR>
<A NAME="TBL_OperationPaintMaterial"><P CLASS="Header0">Table: OperationPaintMaterial</P><P CLASS="Base">&nbsp;</P>
<P CLASS="Header1">Description</P>
<P CLASS="Base"><I>(There is no description for table OperationPaintMaterial)</I></P>
<P CLASS="Base">&nbsp;</P>
<P CLASS="Header1">Fields</P>
<TABLE CLASS="dtArg" CELLSPACING="0">
  <TH WIDTH="1%" ALIGN="middle"><P CLASS="Base2"><B>PK</B></P>
  <TH WIDTH="1%" ALIGN="middle"><P CLASS="Base2"><B>FK</B></P>
  <TH WIDTH="1%"><P CLASS="Base2"><B>Field</B></P>
  <TH WIDTH="1%"><P CLASS="Base2"><B>Domain</B></P>
  <TH WIDTH="20%"><P CLASS="Base2"><B>Type</B></P>
  <TH WIDTH="1%" ALIGN="middle"><P CLASS="Base2"><B>NN</B></P>
  <TH WIDTH="1%"><P CLASS="Base2"><B>Default</B></P>
  <TH WIDTH="40%"><P CLASS="Base2"><B>Description</B></P>
  <TR>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/PK1.gif" BORDER="0"></P></TD>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD><A NAME="OperationPaintMaterial.Id"><P CLASS="Base2">Id</P></A></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">INTEGER</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/Yes.gif" BORDER="0"></P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
  </TR>
  <TR>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD><A NAME="OperationPaintMaterial.Code"><P CLASS="Base2">Code</P></A></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">VARCHAR(10)</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
  </TR>
  <TR>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD><A NAME="OperationPaintMaterial.Type"><P CLASS="Base2">Type</P></A></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">VARCHAR(100)</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
  </TR>
  <TR>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD><A NAME="OperationPaintMaterial.NameRus"><P CLASS="Base2">NameRus</P></A></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">VARCHAR(100)</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
  </TR>
  <TR>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD><A NAME="OperationPaintMaterial.NameEng"><P CLASS="Base2">NameEng</P></A></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">VARCHAR(100)</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
  </TR>
</TABLE>
<P CLASS="Base">&nbsp;</P>
<P CLASS="Header1">Triggers</P>
<TABLE CLASS="dtArg" CELLSPACING="0">
  <TH WIDTH="1%"><P CLASS="Base2"><B>Trigger</B></P>
  <TH WIDTH="1%"><P CLASS="Base2"><B>Type</B></P>
  <TH WIDTH="1%"><P CLASS="Base2"><B>Activity</B></P>
  <TH WIDTH="1%"><P CLASS="Base2"><B>Order</B></P>
  <TH WIDTH="50%"><P CLASS="Base2"><B>Description</B></P>
  <TR>
    <TD><P CLASS="Base2"><A HREF="#TRG_Tr_OperationPaintMaterial">Tr_OperationPaintMaterial</A></TD>
    <TD><P CLASS="Base2">BEFORE&nbsp;INSERT</TD>
    <TD><P CLASS="Base2">Yes</TD>
    <TD ALIGN="right"><P CLASS="Base2">0</TD>
    <TD><P CLASS="Base2">&nbsp</TD>
  </TR>
</TABLE>
<P CLASS="Base">&nbsp;</P>
<P CLASS="Header1">Indices</P>
<TABLE CLASS="dtArg" CELLSPACING="0">
  <TH><P CLASS="Base2"><B>Index</B></P>
  <TH><P CLASS="Base2"><B>Fields</B></P>
  <TH ALIGN="middle"><P CLASS="Base2"><B>Active</B></P>
  <TH ALIGN="middle"><P CLASS="Base2"><B>Unique</B></P>
  <TH ALIGN="middle"><P CLASS="Base2"><B>Order</B></P>
  <TR>
    <TD><P CLASS="Base2"><A HREF="#IND_PK_OperationPaintMaterialId">PK_OperationPaintMaterialId</A></TD>
    <TD><P CLASS="Base2">"Id"</TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/Yes.gif" BORDER="0"></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/Yes.gif" BORDER="0"></TD>
    <TD ALIGN="middle"><P CLASS="Base2">ASC</TD>
  </TR>
</TABLE>
<P CLASS="Base">&nbsp;</P>
<P CLASS="Header1">References</P>
<P CLASS="Base"><I>(There are no references for table OperationPaintMaterial)</I></P>
<P CLASS="Base">&nbsp;</P>
<P CLASS="Header1">Referenced By</P>
<P CLASS="Base"><I>(There are no tables referenced by table OperationPaintMaterial)</I></P>
<P CLASS="Base">&nbsp;</P>
<P CLASS="Header1">Definition</P>
<P CLASS="Base"><span class="DDLCode">
<code><pre>
<b>CREATE</b><b> </b><b>TABLE</b><b> </b><font color="# 080 0"><u>&quot;OperationPaintMaterial&quot;</u></font><b> </b><b>(</b>
<b>    </b>&quot;Id&quot;<b>       </b><b>INTEGER</b><b> </b><b>NOT</b><b> </b><b>NULL</b><b>,</b>
<b>    </b>&quot;Code&quot;<b>     </b><b>VARCHAR</b><b>(</b>10<b>)</b><b> </b><b>CHARACTER</b><b> </b><b>SET</b><b> </b>WIN1251<b>,</b>
<b>    </b><font color="# 080 0"><u>&quot;Type&quot;</u></font><b>     </b><b>VARCHAR</b><b>(</b>100<b>)</b><b> </b><b>CHARACTER</b><b> </b><b>SET</b><b> </b>WIN1251<b>,</b>
<b>    </b>&quot;NameRus&quot;<b>  </b><b>VARCHAR</b><b>(</b>100<b>)</b><b> </b><b>CHARACTER</b><b> </b><b>SET</b><b> </b>WIN1251<b>,</b>
<b>    </b>&quot;NameEng&quot;<b>  </b><b>VARCHAR</b><b>(</b>100<b>)</b><b> </b><b>CHARACTER</b><b> </b><b>SET</b><b> </b>WIN1251
<b>)</b><b>;</b>


<b>ALTER</b><b> </b><b>TABLE</b><b> </b><font color="# 080 0"><u>&quot;OperationPaintMaterial&quot;</u></font><b> </b><b>ADD</b><b> </b><b>CONSTRAINT</b><b> </b>&quot;PK_OperationPaintMaterialId&quot;<b> </b><b>PRIMARY</b><b> </b><b>KEY</b><b> </b><b>(</b>&quot;Id&quot;<b>)</b><b>;</b>

</pre></code>
</span></P>
<P CLASS="Base">&nbsp;</P>

<HR>
<A NAME="TBL_RevisionType"><P CLASS="Header0">Table: RevisionType</P><P CLASS="Base">&nbsp;</P>
<P CLASS="Header1">Description</P>
<P CLASS="Base"><I>(There is no description for table RevisionType)</I></P>
<P CLASS="Base">&nbsp;</P>
<P CLASS="Header1">Fields</P>
<TABLE CLASS="dtArg" CELLSPACING="0">
  <TH WIDTH="1%" ALIGN="middle"><P CLASS="Base2"><B>PK</B></P>
  <TH WIDTH="1%" ALIGN="middle"><P CLASS="Base2"><B>FK</B></P>
  <TH WIDTH="1%"><P CLASS="Base2"><B>Field</B></P>
  <TH WIDTH="1%"><P CLASS="Base2"><B>Domain</B></P>
  <TH WIDTH="20%"><P CLASS="Base2"><B>Type</B></P>
  <TH WIDTH="1%" ALIGN="middle"><P CLASS="Base2"><B>NN</B></P>
  <TH WIDTH="1%"><P CLASS="Base2"><B>Default</B></P>
  <TH WIDTH="40%"><P CLASS="Base2"><B>Description</B></P>
  <TR>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/PK1.gif" BORDER="0"></P></TD>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD><A NAME="RevisionType.Id"><P CLASS="Base2">Id</P></A></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">INTEGER</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/Yes.gif" BORDER="0"></P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
  </TR>
  <TR>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD><A NAME="RevisionType.Name"><P CLASS="Base2">Name</P></A></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">VARCHAR(20)</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
  </TR>
</TABLE>
<P CLASS="Base">&nbsp;</P>
<P CLASS="Header1">Triggers</P>
<TABLE CLASS="dtArg" CELLSPACING="0">
  <TH WIDTH="1%"><P CLASS="Base2"><B>Trigger</B></P>
  <TH WIDTH="1%"><P CLASS="Base2"><B>Type</B></P>
  <TH WIDTH="1%"><P CLASS="Base2"><B>Activity</B></P>
  <TH WIDTH="1%"><P CLASS="Base2"><B>Order</B></P>
  <TH WIDTH="50%"><P CLASS="Base2"><B>Description</B></P>
  <TR>
    <TD><P CLASS="Base2"><A HREF="#TRG_Tr_RevisionType">Tr_RevisionType</A></TD>
    <TD><P CLASS="Base2">BEFORE&nbsp;INSERT</TD>
    <TD><P CLASS="Base2">Yes</TD>
    <TD ALIGN="right"><P CLASS="Base2">0</TD>
    <TD><P CLASS="Base2">&nbsp</TD>
  </TR>
</TABLE>
<P CLASS="Base">&nbsp;</P>
<P CLASS="Header1">Indices</P>
<TABLE CLASS="dtArg" CELLSPACING="0">
  <TH><P CLASS="Base2"><B>Index</B></P>
  <TH><P CLASS="Base2"><B>Fields</B></P>
  <TH ALIGN="middle"><P CLASS="Base2"><B>Active</B></P>
  <TH ALIGN="middle"><P CLASS="Base2"><B>Unique</B></P>
  <TH ALIGN="middle"><P CLASS="Base2"><B>Order</B></P>
  <TR>
    <TD><P CLASS="Base2"><A HREF="#IND_PK_RevisionTypeId">PK_RevisionTypeId</A></TD>
    <TD><P CLASS="Base2">"Id"</TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/Yes.gif" BORDER="0"></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/Yes.gif" BORDER="0"></TD>
    <TD ALIGN="middle"><P CLASS="Base2">ASC</TD>
  </TR>
</TABLE>
<P CLASS="Base">&nbsp;</P>
<P CLASS="Header1">References</P>
<P CLASS="Base"><I>(There are no references for table RevisionType)</I></P>
<P CLASS="Base">&nbsp;</P>
<P CLASS="Header1">Referenced By</P>
<TABLE CLASS="dtArg" CELLSPACING="0">
  <TH><P CLASS="Base2"><B>Table</B></P>
  <TH><P CLASS="Base2"><B>Foreign Key</B></P>
  <TH><P CLASS="Base2"><B>Fields</B></P>
  <TH><P CLASS="Base2"><B>FK Field</B></P>
  <TH><P CLASS="Base2"><B>Delete Rule</B></P>
  <TH><P CLASS="Base2"><B>Update Rule</B></P>
  <TR>
    <TD><P CLASS="Base2"><A HREF="#TBL_TechProcess001">TechProcess001</A></TD>
    <TD><P CLASS="Base2"><A HREF="#FKEY_FK_TechProcess001_TypeId">FK_TechProcess001_TypeId</A></TD>
    <TD><P CLASS="Base2">TypeId</TD>
    <TD><P CLASS="Base2">Id</TD>
    <TD><P CLASS="Base2">NO ACTION</TD>
    <TD><P CLASS="Base2">NO ACTION</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2"><A HREF="#TBL_TechProcess002">TechProcess002</A></TD>
    <TD><P CLASS="Base2"><A HREF="#FKEY_FK_TechProcess002_TypeId">FK_TechProcess002_TypeId</A></TD>
    <TD><P CLASS="Base2">TypeId</TD>
    <TD><P CLASS="Base2">Id</TD>
    <TD><P CLASS="Base2">NO ACTION</TD>
    <TD><P CLASS="Base2">NO ACTION</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2"><A HREF="#TBL_TechProcess003">TechProcess003</A></TD>
    <TD><P CLASS="Base2"><A HREF="#FKEY_FK_TechProcess003_TypeId">FK_TechProcess003_TypeId</A></TD>
    <TD><P CLASS="Base2">TypeId</TD>
    <TD><P CLASS="Base2">Id</TD>
    <TD><P CLASS="Base2">NO ACTION</TD>
    <TD><P CLASS="Base2">NO ACTION</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2"><A HREF="#TBL_TechProcess004">TechProcess004</A></TD>
    <TD><P CLASS="Base2"><A HREF="#FKEY_FK_TechProcess004_TypeId">FK_TechProcess004_TypeId</A></TD>
    <TD><P CLASS="Base2">TypeId</TD>
    <TD><P CLASS="Base2">Id</TD>
    <TD><P CLASS="Base2">NO ACTION</TD>
    <TD><P CLASS="Base2">NO ACTION</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2"><A HREF="#TBL_TechProcess005">TechProcess005</A></TD>
    <TD><P CLASS="Base2"><A HREF="#FKEY_FK_TechProcess005_TypeId">FK_TechProcess005_TypeId</A></TD>
    <TD><P CLASS="Base2">TypeId</TD>
    <TD><P CLASS="Base2">Id</TD>
    <TD><P CLASS="Base2">NO ACTION</TD>
    <TD><P CLASS="Base2">NO ACTION</TD>
  </TR>
</TABLE>
<P CLASS="Base">&nbsp;</P>
<P CLASS="Header1">Definition</P>
<P CLASS="Base"><span class="DDLCode">
<code><pre>
<b>CREATE</b><b> </b><b>TABLE</b><b> </b><font color="# 080 0"><u>&quot;RevisionType&quot;</u></font><b> </b><b>(</b>
<b>    </b>&quot;Id&quot;<b>    </b><b>INTEGER</b><b> </b><b>NOT</b><b> </b><b>NULL</b><b>,</b>
<b>    </b>&quot;Name&quot;<b>  </b><b>VARCHAR</b><b>(</b>20<b>)</b>
<b>)</b><b>;</b>


<b>ALTER</b><b> </b><b>TABLE</b><b> </b><font color="# 080 0"><u>&quot;RevisionType&quot;</u></font><b> </b><b>ADD</b><b> </b><b>CONSTRAINT</b><b> </b>&quot;PK_RevisionTypeId&quot;<b> </b><b>PRIMARY</b><b> </b><b>KEY</b><b> </b><b>(</b>&quot;Id&quot;<b>)</b><b>;</b>

</pre></code>
</span></P>
<P CLASS="Base">&nbsp;</P>

<HR>
<A NAME="TBL_Revisions"><P CLASS="Header0">Table: Revisions</P><P CLASS="Base">&nbsp;</P>
<P CLASS="Header1">Description</P>
<P CLASS="Base"><I>(There is no description for table Revisions)</I></P>
<P CLASS="Base">&nbsp;</P>
<P CLASS="Header1">Fields</P>
<TABLE CLASS="dtArg" CELLSPACING="0">
  <TH WIDTH="1%" ALIGN="middle"><P CLASS="Base2"><B>PK</B></P>
  <TH WIDTH="1%" ALIGN="middle"><P CLASS="Base2"><B>FK</B></P>
  <TH WIDTH="1%"><P CLASS="Base2"><B>Field</B></P>
  <TH WIDTH="1%"><P CLASS="Base2"><B>Domain</B></P>
  <TH WIDTH="20%"><P CLASS="Base2"><B>Type</B></P>
  <TH WIDTH="1%" ALIGN="middle"><P CLASS="Base2"><B>NN</B></P>
  <TH WIDTH="1%"><P CLASS="Base2"><B>Default</B></P>
  <TH WIDTH="40%"><P CLASS="Base2"><B>Description</B></P>
  <TR>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/PK1.gif" BORDER="0"></P></TD>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD><A NAME="Revisions.Id"><P CLASS="Base2">Id</P></A></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">INTEGER</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/Yes.gif" BORDER="0"></P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
  </TR>
  <TR>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD><A NAME="Revisions.Symbol"><P CLASS="Base2">Symbol</P></A></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">VARCHAR(2)</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
  </TR>
</TABLE>
<P CLASS="Base">&nbsp;</P>
<P CLASS="Header1">Triggers</P>
<TABLE CLASS="dtArg" CELLSPACING="0">
  <TH WIDTH="1%"><P CLASS="Base2"><B>Trigger</B></P>
  <TH WIDTH="1%"><P CLASS="Base2"><B>Type</B></P>
  <TH WIDTH="1%"><P CLASS="Base2"><B>Activity</B></P>
  <TH WIDTH="1%"><P CLASS="Base2"><B>Order</B></P>
  <TH WIDTH="50%"><P CLASS="Base2"><B>Description</B></P>
  <TR>
    <TD><P CLASS="Base2"><A HREF="#TRG_Tr_Revisions">Tr_Revisions</A></TD>
    <TD><P CLASS="Base2">BEFORE&nbsp;INSERT</TD>
    <TD><P CLASS="Base2">Yes</TD>
    <TD ALIGN="right"><P CLASS="Base2">0</TD>
    <TD><P CLASS="Base2">&nbsp</TD>
  </TR>
</TABLE>
<P CLASS="Base">&nbsp;</P>
<P CLASS="Header1">Indices</P>
<TABLE CLASS="dtArg" CELLSPACING="0">
  <TH><P CLASS="Base2"><B>Index</B></P>
  <TH><P CLASS="Base2"><B>Fields</B></P>
  <TH ALIGN="middle"><P CLASS="Base2"><B>Active</B></P>
  <TH ALIGN="middle"><P CLASS="Base2"><B>Unique</B></P>
  <TH ALIGN="middle"><P CLASS="Base2"><B>Order</B></P>
  <TR>
    <TD><P CLASS="Base2"><A HREF="#IND_PK_RevisionsId">PK_RevisionsId</A></TD>
    <TD><P CLASS="Base2">"Id"</TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/Yes.gif" BORDER="0"></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/Yes.gif" BORDER="0"></TD>
    <TD ALIGN="middle"><P CLASS="Base2">ASC</TD>
  </TR>
</TABLE>
<P CLASS="Base">&nbsp;</P>
<P CLASS="Header1">References</P>
<P CLASS="Base"><I>(There are no references for table Revisions)</I></P>
<P CLASS="Base">&nbsp;</P>
<P CLASS="Header1">Referenced By</P>
<TABLE CLASS="dtArg" CELLSPACING="0">
  <TH><P CLASS="Base2"><B>Table</B></P>
  <TH><P CLASS="Base2"><B>Foreign Key</B></P>
  <TH><P CLASS="Base2"><B>Fields</B></P>
  <TH><P CLASS="Base2"><B>FK Field</B></P>
  <TH><P CLASS="Base2"><B>Delete Rule</B></P>
  <TH><P CLASS="Base2"><B>Update Rule</B></P>
  <TR>
    <TD><P CLASS="Base2"><A HREF="#TBL_Drawing">Drawing</A></TD>
    <TD><P CLASS="Base2"><A HREF="#FKEY_FK_Drawing_RevId">FK_Drawing_RevId</A></TD>
    <TD><P CLASS="Base2">RevisionId</TD>
    <TD><P CLASS="Base2">Id</TD>
    <TD><P CLASS="Base2">NO ACTION</TD>
    <TD><P CLASS="Base2">NO ACTION</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2"><A HREF="#TBL_TechProcess001">TechProcess001</A></TD>
    <TD><P CLASS="Base2"><A HREF="#FKEY_FK_TechProcess001_RevisionId">FK_TechProcess001_RevisionId</A></TD>
    <TD><P CLASS="Base2">RevisionId</TD>
    <TD><P CLASS="Base2">Id</TD>
    <TD><P CLASS="Base2">NO ACTION</TD>
    <TD><P CLASS="Base2">NO ACTION</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2"><A HREF="#TBL_TechProcess002">TechProcess002</A></TD>
    <TD><P CLASS="Base2"><A HREF="#FKEY_FK_TechProcess002_RevisionId">FK_TechProcess002_RevisionId</A></TD>
    <TD><P CLASS="Base2">RevisionId</TD>
    <TD><P CLASS="Base2">Id</TD>
    <TD><P CLASS="Base2">NO ACTION</TD>
    <TD><P CLASS="Base2">NO ACTION</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2"><A HREF="#TBL_TechProcess003">TechProcess003</A></TD>
    <TD><P CLASS="Base2"><A HREF="#FKEY_FK_TechProcess003_RevisionId">FK_TechProcess003_RevisionId</A></TD>
    <TD><P CLASS="Base2">RevisionId</TD>
    <TD><P CLASS="Base2">Id</TD>
    <TD><P CLASS="Base2">NO ACTION</TD>
    <TD><P CLASS="Base2">NO ACTION</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2"><A HREF="#TBL_TechProcess004">TechProcess004</A></TD>
    <TD><P CLASS="Base2"><A HREF="#FKEY_FK_TechProcess004_RevisionId">FK_TechProcess004_RevisionId</A></TD>
    <TD><P CLASS="Base2">RevisionId</TD>
    <TD><P CLASS="Base2">Id</TD>
    <TD><P CLASS="Base2">NO ACTION</TD>
    <TD><P CLASS="Base2">NO ACTION</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2"><A HREF="#TBL_TechProcess005">TechProcess005</A></TD>
    <TD><P CLASS="Base2"><A HREF="#FKEY_FK_TechProcess005_RevisionId">FK_TechProcess005_RevisionId</A></TD>
    <TD><P CLASS="Base2">RevisionId</TD>
    <TD><P CLASS="Base2">Id</TD>
    <TD><P CLASS="Base2">NO ACTION</TD>
    <TD><P CLASS="Base2">NO ACTION</TD>
  </TR>
</TABLE>
<P CLASS="Base">&nbsp;</P>
<P CLASS="Header1">Definition</P>
<P CLASS="Base"><span class="DDLCode">
<code><pre>
<b>CREATE</b><b> </b><b>TABLE</b><b> </b><font color="# 080 0"><u>&quot;Revisions&quot;</u></font><b> </b><b>(</b>
<b>    </b>&quot;Id&quot;<b>      </b><b>INTEGER</b><b> </b><b>NOT</b><b> </b><b>NULL</b><b>,</b>
<b>    </b>&quot;Symbol&quot;<b>  </b><b>VARCHAR</b><b>(</b>2<b>)</b><b> </b><b>CHARACTER</b><b> </b><b>SET</b><b> </b>WIN1251
<b>)</b><b>;</b>


<b>ALTER</b><b> </b><b>TABLE</b><b> </b><font color="# 080 0"><u>&quot;Revisions&quot;</u></font><b> </b><b>ADD</b><b> </b><b>CONSTRAINT</b><b> </b>&quot;PK_RevisionsId&quot;<b> </b><b>PRIMARY</b><b> </b><b>KEY</b><b> </b><b>(</b>&quot;Id&quot;<b>)</b><b>;</b>

</pre></code>
</span></P>
<P CLASS="Base">&nbsp;</P>

<HR>
<A NAME="TBL_TechProcess001"><P CLASS="Header0">Table: TechProcess001</P><P CLASS="Base">&nbsp;</P>
<P CLASS="Header1">Description</P>
<P CLASS="Base"><I>(There is no description for table TechProcess001)</I></P>
<P CLASS="Base">&nbsp;</P>
<P CLASS="Header1">Fields</P>
<TABLE CLASS="dtArg" CELLSPACING="0">
  <TH WIDTH="1%" ALIGN="middle"><P CLASS="Base2"><B>PK</B></P>
  <TH WIDTH="1%" ALIGN="middle"><P CLASS="Base2"><B>FK</B></P>
  <TH WIDTH="1%"><P CLASS="Base2"><B>Field</B></P>
  <TH WIDTH="1%"><P CLASS="Base2"><B>Domain</B></P>
  <TH WIDTH="20%"><P CLASS="Base2"><B>Type</B></P>
  <TH WIDTH="1%" ALIGN="middle"><P CLASS="Base2"><B>NN</B></P>
  <TH WIDTH="1%"><P CLASS="Base2"><B>Default</B></P>
  <TH WIDTH="40%"><P CLASS="Base2"><B>Description</B></P>
  <TR>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/PK1.gif" BORDER="0"></P></TD>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD><A NAME="TechProcess001.Id"><P CLASS="Base2">Id</P></A></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">INTEGER</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/Yes.gif" BORDER="0"></P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
  </TR>
  <TR>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD><A NAME="TechProcess001.TechProcessName"><P CLASS="Base2">TechProcessName</P></A></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">BIGINT</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
  </TR>
  <TR>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD><A NAME="TechProcess001.TechProcessPath"><P CLASS="Base2">TechProcessPath</P></A></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">VARCHAR(200)</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
  </TR>
  <TR>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD><A NAME="TechProcess001.TechProcessFullName"><P CLASS="Base2">TechProcessFullName</P></A></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">VARCHAR(50)</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
  </TR>
  <TR>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/FK.gif" BORDER="0"></P></TD>
    <TD><A NAME="TechProcess001.RevisionId"><P CLASS="Base2">RevisionId</P></A></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">SMALLINT</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
  </TR>
  <TR>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/FK.gif" BORDER="0"></P></TD>
    <TD><A NAME="TechProcess001.DrawingId"><P CLASS="Base2">DrawingId</P></A></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">SMALLINT</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
  </TR>
  <TR>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/FK.gif" BORDER="0"></P></TD>
    <TD><A NAME="TechProcess001.CopyDrawingId"><P CLASS="Base2">CopyDrawingId</P></A></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">SMALLINT</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
  </TR>
  <TR>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/FK.gif" BORDER="0"></P></TD>
    <TD><A NAME="TechProcess001.ParentId"><P CLASS="Base2">ParentId</P></A></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">SMALLINT</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
  </TR>
  <TR>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD><A NAME="TechProcess001.CreateDate"><P CLASS="Base2">CreateDate</P></A></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">DATE</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></P></TD>
    <TD><P CLASS="Base2">CURRENT_DATE</P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
  </TR>
  <TR>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/FK.gif" BORDER="0"></P></TD>
    <TD><A NAME="TechProcess001.TypeId"><P CLASS="Base2">TypeId</P></A></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">SMALLINT</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></P></TD>
    <TD><P CLASS="Base2">1</P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
  </TR>
  <TR>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD><A NAME="TechProcess001.OldTechProcess"><P CLASS="Base2">OldTechProcess</P></A></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">SMALLINT</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></P></TD>
    <TD><P CLASS="Base2">0</P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
  </TR>
  <TR>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD><A NAME="TechProcess001.TH"><P CLASS="Base2">TH</P></A></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">VARCHAR(10)</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></P></TD>
    <TD><P CLASS="Base2">0</P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
  </TR>
  <TR>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD><A NAME="TechProcess001.W"><P CLASS="Base2">W</P></A></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">VARCHAR(10)</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></P></TD>
    <TD><P CLASS="Base2">0</P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
  </TR>
  <TR>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD><A NAME="TechProcess001.W2"><P CLASS="Base2">W2</P></A></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">VARCHAR(10)</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></P></TD>
    <TD><P CLASS="Base2">0</P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
  </TR>
  <TR>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD><A NAME="TechProcess001.L"><P CLASS="Base2">L</P></A></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">VARCHAR(10)</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></P></TD>
    <TD><P CLASS="Base2">0</P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
  </TR>
  <TR>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD><A NAME="TechProcess001.Weight"><P CLASS="Base2">Weight</P></A></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">NUMERIC(10,2)</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></P></TD>
    <TD><P CLASS="Base2">0</P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
  </TR>
  <TR>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/FK.gif" BORDER="0"></P></TD>
    <TD><A NAME="TechProcess001.UserId"><P CLASS="Base2">UserId</P></A></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">SMALLINT</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
  </TR>
  <TR>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD><A NAME="TechProcess001.RevisionDocumentName"><P CLASS="Base2">RevisionDocumentName</P></A></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">VARCHAR(20)</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
  </TR>
  <TR>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD><A NAME="TechProcess001.Welding20Steel"><P CLASS="Base2">Welding20Steel</P></A></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">NUMERIC(6,2)</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></P></TD>
    <TD><P CLASS="Base2">0</P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
  </TR>
  <TR>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD><A NAME="TechProcess001.Welding10"><P CLASS="Base2">Welding10</P></A></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">NUMERIC(6,2)</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></P></TD>
    <TD><P CLASS="Base2">0</P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
  </TR>
  <TR>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD><A NAME="TechProcess001.Welding12"><P CLASS="Base2">Welding12</P></A></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">NUMERIC(6,2)</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></P></TD>
    <TD><P CLASS="Base2">0</P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
  </TR>
  <TR>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD><A NAME="TechProcess001.Welding16"><P CLASS="Base2">Welding16</P></A></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">NUMERIC(6,2)</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></P></TD>
    <TD><P CLASS="Base2">0</P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
  </TR>
  <TR>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD><A NAME="TechProcess001.Welding20"><P CLASS="Base2">Welding20</P></A></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">NUMERIC(6,2)</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></P></TD>
    <TD><P CLASS="Base2">0</P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
  </TR>
  <TR>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD><A NAME="TechProcess001.GasArCO2"><P CLASS="Base2">GasArCO2</P></A></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">NUMERIC(6,2)</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></P></TD>
    <TD><P CLASS="Base2">0</P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
  </TR>
  <TR>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD><A NAME="TechProcess001.GasCO3"><P CLASS="Base2">GasCO3</P></A></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">NUMERIC(6,2)</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></P></TD>
    <TD><P CLASS="Base2">0</P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
  </TR>
  <TR>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD><A NAME="TechProcess001.GasAr"><P CLASS="Base2">GasAr</P></A></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">NUMERIC(6,2)</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></P></TD>
    <TD><P CLASS="Base2">0</P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
  </TR>
  <TR>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD><A NAME="TechProcess001.WeldingElektrod"><P CLASS="Base2">WeldingElektrod</P></A></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">NUMERIC(6,2)</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></P></TD>
    <TD><P CLASS="Base2">0</P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
  </TR>
  <TR>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD><A NAME="TechProcess001.GasO2"><P CLASS="Base2">GasO2</P></A></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">NUMERIC(6,2)</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></P></TD>
    <TD><P CLASS="Base2">0</P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
  </TR>
  <TR>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD><A NAME="TechProcess001.GasNature"><P CLASS="Base2">GasNature</P></A></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">NUMERIC(6,2)</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></P></TD>
    <TD><P CLASS="Base2">0</P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
  </TR>
  <TR>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD><A NAME="TechProcess001.GasN2"><P CLASS="Base2">GasN2</P></A></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">NUMERIC(6,2)</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></P></TD>
    <TD><P CLASS="Base2">0</P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
  </TR>
  <TR>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD><A NAME="TechProcess001.HardKapci881"><P CLASS="Base2">HardKapci881</P></A></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">NUMERIC(6,2)</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></P></TD>
    <TD><P CLASS="Base2">0</P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
  </TR>
  <TR>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD><A NAME="TechProcess001.HardKapciHs6055"><P CLASS="Base2">HardKapciHs6055</P></A></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">NUMERIC(6,2)</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></P></TD>
    <TD><P CLASS="Base2">0</P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
  </TR>
  <TR>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD><A NAME="TechProcess001.HardKapci126"><P CLASS="Base2">HardKapci126</P></A></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">NUMERIC(6,2)</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></P></TD>
    <TD><P CLASS="Base2">0</P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
  </TR>
  <TR>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD><A NAME="TechProcess001.HardKapciPEPutty"><P CLASS="Base2">HardKapciPEPutty</P></A></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">NUMERIC(6,2)</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></P></TD>
    <TD><P CLASS="Base2">0</P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
  </TR>
  <TR>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD><A NAME="TechProcess001.HardKapci2KMS651"><P CLASS="Base2">HardKapci2KMS651</P></A></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">NUMERIC(6,2)</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></P></TD>
    <TD><P CLASS="Base2">0</P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
  </TR>
  <TR>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD><A NAME="TechProcess001.DilKapci881"><P CLASS="Base2">DilKapci881</P></A></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">NUMERIC(6,2)</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></P></TD>
    <TD><P CLASS="Base2">0</P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
  </TR>
  <TR>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD><A NAME="TechProcess001.DilKapci2K"><P CLASS="Base2">DilKapci2K</P></A></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">NUMERIC(6,2)</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></P></TD>
    <TD><P CLASS="Base2">0</P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
  </TR>
  <TR>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD><A NAME="TechProcess001.DilKapci880"><P CLASS="Base2">DilKapci880</P></A></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">NUMERIC(6,2)</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></P></TD>
    <TD><P CLASS="Base2">0</P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
  </TR>
  <TR>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD><A NAME="TechProcess001.PrimerKapci125"><P CLASS="Base2">PrimerKapci125</P></A></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">NUMERIC(6,2)</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></P></TD>
    <TD><P CLASS="Base2">0</P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
  </TR>
  <TR>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD><A NAME="TechProcess001.PrimerKapci633"><P CLASS="Base2">PrimerKapci633</P></A></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">NUMERIC(6,2)</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></P></TD>
    <TD><P CLASS="Base2">0</P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
  </TR>
  <TR>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD><A NAME="TechProcess001.EnamelKapci641"><P CLASS="Base2">EnamelKapci641</P></A></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">NUMERIC(6,2)</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></P></TD>
    <TD><P CLASS="Base2">0</P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
  </TR>
  <TR>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD><A NAME="TechProcess001.EnamelKapci670"><P CLASS="Base2">EnamelKapci670</P></A></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">NUMERIC(6,2)</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></P></TD>
    <TD><P CLASS="Base2">0</P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
  </TR>
  <TR>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD><A NAME="TechProcess001.EnamelKapci6030"><P CLASS="Base2">EnamelKapci6030</P></A></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">NUMERIC(6,2)</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></P></TD>
    <TD><P CLASS="Base2">0</P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
  </TR>
  <TR>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD><A NAME="TechProcess001.UniversalSikaflex527"><P CLASS="Base2">UniversalSikaflex527</P></A></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">NUMERIC(6,2)</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></P></TD>
    <TD><P CLASS="Base2">0</P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
  </TR>
  <TR>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD><A NAME="TechProcess001.PuttyKapci350"><P CLASS="Base2">PuttyKapci350</P></A></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">NUMERIC(6,2)</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></P></TD>
    <TD><P CLASS="Base2">0</P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
  </TR>
  <TR>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD><A NAME="TechProcess001.LaborIntensity001"><P CLASS="Base2">LaborIntensity001</P></A></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">NUMERIC(6,2)</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></P></TD>
    <TD><P CLASS="Base2">0</P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
  </TR>
  <TR>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD><A NAME="TechProcess001.LaborIntensity002"><P CLASS="Base2">LaborIntensity002</P></A></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">NUMERIC(6,2)</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></P></TD>
    <TD><P CLASS="Base2">0</P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
  </TR>
  <TR>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD><A NAME="TechProcess001.LaborIntensity003"><P CLASS="Base2">LaborIntensity003</P></A></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">NUMERIC(6,2)</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></P></TD>
    <TD><P CLASS="Base2">0</P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
  </TR>
  <TR>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD><A NAME="TechProcess001.LaborIntensity004"><P CLASS="Base2">LaborIntensity004</P></A></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">NUMERIC(6,2)</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></P></TD>
    <TD><P CLASS="Base2">0</P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
  </TR>
  <TR>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD><A NAME="TechProcess001.LaborIntensity005"><P CLASS="Base2">LaborIntensity005</P></A></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">NUMERIC(6,2)</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></P></TD>
    <TD><P CLASS="Base2">0</P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
  </TR>
</TABLE>
<P CLASS="Base">&nbsp;</P>
<P CLASS="Header1">Triggers</P>
<TABLE CLASS="dtArg" CELLSPACING="0">
  <TH WIDTH="1%"><P CLASS="Base2"><B>Trigger</B></P>
  <TH WIDTH="1%"><P CLASS="Base2"><B>Type</B></P>
  <TH WIDTH="1%"><P CLASS="Base2"><B>Activity</B></P>
  <TH WIDTH="1%"><P CLASS="Base2"><B>Order</B></P>
  <TH WIDTH="50%"><P CLASS="Base2"><B>Description</B></P>
  <TR>
    <TD><P CLASS="Base2"><A HREF="#TRG_Tr_TechProcess001">Tr_TechProcess001</A></TD>
    <TD><P CLASS="Base2">BEFORE&nbsp;INSERT</TD>
    <TD><P CLASS="Base2">Yes</TD>
    <TD ALIGN="right"><P CLASS="Base2">0</TD>
    <TD><P CLASS="Base2">&nbsp</TD>
  </TR>
</TABLE>
<P CLASS="Base">&nbsp;</P>
<P CLASS="Header1">Indices</P>
<TABLE CLASS="dtArg" CELLSPACING="0">
  <TH><P CLASS="Base2"><B>Index</B></P>
  <TH><P CLASS="Base2"><B>Fields</B></P>
  <TH ALIGN="middle"><P CLASS="Base2"><B>Active</B></P>
  <TH ALIGN="middle"><P CLASS="Base2"><B>Unique</B></P>
  <TH ALIGN="middle"><P CLASS="Base2"><B>Order</B></P>
  <TR>
    <TD><P CLASS="Base2"><A HREF="#IND_FK_TechProcess001_CopyDrawingId">FK_TechProcess001_CopyDrawingId</A></TD>
    <TD><P CLASS="Base2">"CopyDrawingId"</TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/Yes.gif" BORDER="0"></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></TD>
    <TD ALIGN="middle"><P CLASS="Base2">ASC</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2"><A HREF="#IND_FK_TechProcess001_DrawingId">FK_TechProcess001_DrawingId</A></TD>
    <TD><P CLASS="Base2">"DrawingId"</TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/Yes.gif" BORDER="0"></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></TD>
    <TD ALIGN="middle"><P CLASS="Base2">ASC</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2"><A HREF="#IND_FK_TechProcess001_ParentId">FK_TechProcess001_ParentId</A></TD>
    <TD><P CLASS="Base2">"ParentId"</TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/Yes.gif" BORDER="0"></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></TD>
    <TD ALIGN="middle"><P CLASS="Base2">ASC</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2"><A HREF="#IND_FK_TechProcess001_RevisionId">FK_TechProcess001_RevisionId</A></TD>
    <TD><P CLASS="Base2">"RevisionId"</TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/Yes.gif" BORDER="0"></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></TD>
    <TD ALIGN="middle"><P CLASS="Base2">ASC</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2"><A HREF="#IND_FK_TechProcess001_TypeId">FK_TechProcess001_TypeId</A></TD>
    <TD><P CLASS="Base2">"TypeId"</TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/Yes.gif" BORDER="0"></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></TD>
    <TD ALIGN="middle"><P CLASS="Base2">ASC</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2"><A HREF="#IND_FK_TechProcess001_UserId">FK_TechProcess001_UserId</A></TD>
    <TD><P CLASS="Base2">"UserId"</TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/Yes.gif" BORDER="0"></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></TD>
    <TD ALIGN="middle"><P CLASS="Base2">ASC</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2"><A HREF="#IND_PK_TechProcess001Id">PK_TechProcess001Id</A></TD>
    <TD><P CLASS="Base2">"Id"</TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/Yes.gif" BORDER="0"></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/Yes.gif" BORDER="0"></TD>
    <TD ALIGN="middle"><P CLASS="Base2">ASC</TD>
  </TR>
</TABLE>
<P CLASS="Base">&nbsp;</P>
<P CLASS="Header1">References</P>
<TABLE CLASS="dtArg" CELLSPACING="0">
  <TH><P CLASS="Base2"><B>Table</B></P>
  <TH><P CLASS="Base2"><B>Foreign Key</B></P>
  <TH><P CLASS="Base2"><B>Fields</B></P>
  <TH><P CLASS="Base2"><B>FK Field</B></P>
  <TH><P CLASS="Base2"><B>Delete Rule</B></P>
  <TH><P CLASS="Base2"><B>Update Rule</B></P>
  <TR>
    <TD><P CLASS="Base2"><A HREF="#TBL_Drawing">Drawing</A></TD>
    <TD><P CLASS="Base2"><A HREF="#FKEY_FK_TechProcess001_CopyDrawingId">FK_TechProcess001_CopyDrawingId</A></TD>
    <TD><P CLASS="Base2">CopyDrawingId</TD>
    <TD><P CLASS="Base2">Id</TD>
    <TD><P CLASS="Base2">SET NULL</TD>
    <TD><P CLASS="Base2">NO ACTION</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2"><A HREF="#TBL_Drawing">Drawing</A></TD>
    <TD><P CLASS="Base2"><A HREF="#FKEY_FK_TechProcess001_DrawingId">FK_TechProcess001_DrawingId</A></TD>
    <TD><P CLASS="Base2">DrawingId</TD>
    <TD><P CLASS="Base2">Id</TD>
    <TD><P CLASS="Base2">SET NULL</TD>
    <TD><P CLASS="Base2">NO ACTION</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2"><A HREF="#TBL_TechProcess001">TechProcess001</A></TD>
    <TD><P CLASS="Base2"><A HREF="#FKEY_FK_TechProcess001_ParentId">FK_TechProcess001_ParentId</A></TD>
    <TD><P CLASS="Base2">ParentId</TD>
    <TD><P CLASS="Base2">Id</TD>
    <TD><P CLASS="Base2">SET NULL</TD>
    <TD><P CLASS="Base2">NO ACTION</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2"><A HREF="#TBL_Revisions">Revisions</A></TD>
    <TD><P CLASS="Base2"><A HREF="#FKEY_FK_TechProcess001_RevisionId">FK_TechProcess001_RevisionId</A></TD>
    <TD><P CLASS="Base2">RevisionId</TD>
    <TD><P CLASS="Base2">Id</TD>
    <TD><P CLASS="Base2">NO ACTION</TD>
    <TD><P CLASS="Base2">NO ACTION</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2"><A HREF="#TBL_RevisionType">RevisionType</A></TD>
    <TD><P CLASS="Base2"><A HREF="#FKEY_FK_TechProcess001_TypeId">FK_TechProcess001_TypeId</A></TD>
    <TD><P CLASS="Base2">TypeId</TD>
    <TD><P CLASS="Base2">Id</TD>
    <TD><P CLASS="Base2">NO ACTION</TD>
    <TD><P CLASS="Base2">NO ACTION</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2"><A HREF="#TBL_Users">Users</A></TD>
    <TD><P CLASS="Base2"><A HREF="#FKEY_FK_TechProcess001_UserId">FK_TechProcess001_UserId</A></TD>
    <TD><P CLASS="Base2">UserId</TD>
    <TD><P CLASS="Base2">Id</TD>
    <TD><P CLASS="Base2">NO ACTION</TD>
    <TD><P CLASS="Base2">NO ACTION</TD>
  </TR>
</TABLE>
<P CLASS="Base">&nbsp;</P>
<P CLASS="Header1">Referenced By</P>
<TABLE CLASS="dtArg" CELLSPACING="0">
  <TH><P CLASS="Base2"><B>Table</B></P>
  <TH><P CLASS="Base2"><B>Foreign Key</B></P>
  <TH><P CLASS="Base2"><B>Fields</B></P>
  <TH><P CLASS="Base2"><B>FK Field</B></P>
  <TH><P CLASS="Base2"><B>Delete Rule</B></P>
  <TH><P CLASS="Base2"><B>Update Rule</B></P>
  <TR>
    <TD><P CLASS="Base2"><A HREF="#TBL_TechProcess001">TechProcess001</A></TD>
    <TD><P CLASS="Base2"><A HREF="#FKEY_FK_TechProcess001_ParentId">FK_TechProcess001_ParentId</A></TD>
    <TD><P CLASS="Base2">ParentId</TD>
    <TD><P CLASS="Base2">Id</TD>
    <TD><P CLASS="Base2">SET NULL</TD>
    <TD><P CLASS="Base2">NO ACTION</TD>
  </TR>
</TABLE>
<P CLASS="Base">&nbsp;</P>
<P CLASS="Header1">Definition</P>
<P CLASS="Base"><span class="DDLCode">
<code><pre>
<b>CREATE</b><b> </b><b>TABLE</b><b> </b><font color="# 080 0"><u>&quot;TechProcess001&quot;</u></font><b> </b><b>(</b>
<b>    </b>&quot;Id&quot;<b>                    </b><b>INTEGER</b><b> </b><b>NOT</b><b> </b><b>NULL</b><b>,</b>
<b>    </b>&quot;TechProcessName&quot;<b>       </b><b>BIGINT</b><b>,</b>
<b>    </b>&quot;TechProcessPath&quot;<b>       </b><b>VARCHAR</b><b>(</b>200<b>)</b><b>,</b>
<b>    </b>&quot;TechProcessFullName&quot;<b>   </b><b>VARCHAR</b><b>(</b>50<b>)</b><b>,</b>
<b>    </b>&quot;RevisionId&quot;<b>            </b><b>SMALLINT</b><b>,</b>
<b>    </b>&quot;DrawingId&quot;<b>             </b><b>SMALLINT</b><b>,</b>
<b>    </b>&quot;CopyDrawingId&quot;<b>         </b><b>SMALLINT</b><b>,</b>
<b>    </b>&quot;ParentId&quot;<b>              </b><b>SMALLINT</b><b>,</b>
<b>    </b>&quot;CreateDate&quot;<b>            </b><b>DATE</b><b> </b><b>DEFAULT</b><b> </b><b>CURRENT_DATE</b><b>,</b>
<b>    </b>&quot;TypeId&quot;<b>                </b><b>SMALLINT</b><b> </b><b>DEFAULT</b><b> </b>1<b>,</b>
<b>    </b>&quot;OldTechProcess&quot;<b>        </b><b>SMALLINT</b><b> </b><b>DEFAULT</b><b> </b>0<b>,</b>
<b>    </b>TH<b>                      </b><b>VARCHAR</b><b>(</b>10<b>)</b><b> </b><b>CHARACTER</b><b> </b><b>SET</b><b> </b>WIN1251<b> </b><b>DEFAULT</b><b> </b>0<b>,</b>
<b>    </b>W<b>                       </b><b>VARCHAR</b><b>(</b>10<b>)</b><b> </b><b>CHARACTER</b><b> </b><b>SET</b><b> </b>WIN1251<b> </b><b>DEFAULT</b><b> </b>0<b>,</b>
<b>    </b>W2<b>                      </b><b>VARCHAR</b><b>(</b>10<b>)</b><b> </b><b>CHARACTER</b><b> </b><b>SET</b><b> </b>WIN1251<b> </b><b>DEFAULT</b><b> </b>0<b>,</b>
<b>    </b>L<b>                       </b><b>VARCHAR</b><b>(</b>10<b>)</b><b> </b><b>CHARACTER</b><b> </b><b>SET</b><b> </b>WIN1251<b> </b><b>DEFAULT</b><b> </b>0<b>,</b>
<b>    </b>&quot;Weight&quot;<b>                </b><b>NUMERIC</b><b>(</b>10<b>,</b>2<b>)</b><b> </b><b>DEFAULT</b><b> </b>0<b>,</b>
<b>    </b>&quot;UserId&quot;<b>                </b><b>SMALLINT</b><b>,</b>
<b>    </b>&quot;RevisionDocumentName&quot;<b>  </b><b>VARCHAR</b><b>(</b>20<b>)</b><b>,</b>
<b>    </b>&quot;Welding20Steel&quot;<b>        </b><b>NUMERIC</b><b>(</b>6<b>,</b>2<b>)</b><b> </b><b>DEFAULT</b><b> </b>0<b>,</b>
<b>    </b>&quot;Welding10&quot;<b>             </b><b>NUMERIC</b><b>(</b>6<b>,</b>2<b>)</b><b> </b><b>DEFAULT</b><b> </b>0<b>,</b>
<b>    </b>&quot;Welding12&quot;<b>             </b><b>NUMERIC</b><b>(</b>6<b>,</b>2<b>)</b><b> </b><b>DEFAULT</b><b> </b>0<b>,</b>
<b>    </b>&quot;Welding16&quot;<b>             </b><b>NUMERIC</b><b>(</b>6<b>,</b>2<b>)</b><b> </b><b>DEFAULT</b><b> </b>0<b>,</b>
<b>    </b>&quot;Welding20&quot;<b>             </b><b>NUMERIC</b><b>(</b>6<b>,</b>2<b>)</b><b> </b><b>DEFAULT</b><b> </b>0<b>,</b>
<b>    </b>&quot;GasArCO2&quot;<b>              </b><b>NUMERIC</b><b>(</b>6<b>,</b>2<b>)</b><b> </b><b>DEFAULT</b><b> </b>0<b>,</b>
<b>    </b>&quot;GasCO3&quot;<b>                </b><b>NUMERIC</b><b>(</b>6<b>,</b>2<b>)</b><b> </b><b>DEFAULT</b><b> </b>0<b>,</b>
<b>    </b>&quot;GasAr&quot;<b>                 </b><b>NUMERIC</b><b>(</b>6<b>,</b>2<b>)</b><b> </b><b>DEFAULT</b><b> </b>0<b>,</b>
<b>    </b>&quot;WeldingElektrod&quot;<b>       </b><b>NUMERIC</b><b>(</b>6<b>,</b>2<b>)</b><b> </b><b>DEFAULT</b><b> </b>0<b>,</b>
<b>    </b>&quot;GasO2&quot;<b>                 </b><b>NUMERIC</b><b>(</b>6<b>,</b>2<b>)</b><b> </b><b>DEFAULT</b><b> </b>0<b>,</b>
<b>    </b>&quot;GasNature&quot;<b>             </b><b>NUMERIC</b><b>(</b>6<b>,</b>2<b>)</b><b> </b><b>DEFAULT</b><b> </b>0<b>,</b>
<b>    </b>&quot;GasN2&quot;<b>                 </b><b>NUMERIC</b><b>(</b>6<b>,</b>2<b>)</b><b> </b><b>DEFAULT</b><b> </b>0<b>,</b>
<b>    </b>&quot;HardKapci881&quot;<b>          </b><b>NUMERIC</b><b>(</b>6<b>,</b>2<b>)</b><b> </b><b>DEFAULT</b><b> </b>0<b>,</b>
<b>    </b>&quot;HardKapciHs6055&quot;<b>       </b><b>NUMERIC</b><b>(</b>6<b>,</b>2<b>)</b><b> </b><b>DEFAULT</b><b> </b>0<b>,</b>
<b>    </b>&quot;HardKapci126&quot;<b>          </b><b>NUMERIC</b><b>(</b>6<b>,</b>2<b>)</b><b> </b><b>DEFAULT</b><b> </b>0<b>,</b>
<b>    </b>&quot;HardKapciPEPutty&quot;<b>      </b><b>NUMERIC</b><b>(</b>6<b>,</b>2<b>)</b><b> </b><b>DEFAULT</b><b> </b>0<b>,</b>
<b>    </b>&quot;HardKapci2KMS651&quot;<b>      </b><b>NUMERIC</b><b>(</b>6<b>,</b>2<b>)</b><b> </b><b>DEFAULT</b><b> </b>0<b>,</b>
<b>    </b>&quot;DilKapci881&quot;<b>           </b><b>NUMERIC</b><b>(</b>6<b>,</b>2<b>)</b><b> </b><b>DEFAULT</b><b> </b>0<b>,</b>
<b>    </b>&quot;DilKapci2K&quot;<b>            </b><b>NUMERIC</b><b>(</b>6<b>,</b>2<b>)</b><b> </b><b>DEFAULT</b><b> </b>0<b>,</b>
<b>    </b>&quot;DilKapci880&quot;<b>           </b><b>NUMERIC</b><b>(</b>6<b>,</b>2<b>)</b><b> </b><b>DEFAULT</b><b> </b>0<b>,</b>
<b>    </b>&quot;PrimerKapci125&quot;<b>        </b><b>NUMERIC</b><b>(</b>6<b>,</b>2<b>)</b><b> </b><b>DEFAULT</b><b> </b>0<b>,</b>
<b>    </b>&quot;PrimerKapci633&quot;<b>        </b><b>NUMERIC</b><b>(</b>6<b>,</b>2<b>)</b><b> </b><b>DEFAULT</b><b> </b>0<b>,</b>
<b>    </b>&quot;EnamelKapci641&quot;<b>        </b><b>NUMERIC</b><b>(</b>6<b>,</b>2<b>)</b><b> </b><b>DEFAULT</b><b> </b>0<b>,</b>
<b>    </b>&quot;EnamelKapci670&quot;<b>        </b><b>NUMERIC</b><b>(</b>6<b>,</b>2<b>)</b><b> </b><b>DEFAULT</b><b> </b>0<b>,</b>
<b>    </b>&quot;EnamelKapci6030&quot;<b>       </b><b>NUMERIC</b><b>(</b>6<b>,</b>2<b>)</b><b> </b><b>DEFAULT</b><b> </b>0<b>,</b>
<b>    </b>&quot;UniversalSikaflex527&quot;<b>  </b><b>NUMERIC</b><b>(</b>6<b>,</b>2<b>)</b><b> </b><b>DEFAULT</b><b> </b>0<b>,</b>
<b>    </b>&quot;PuttyKapci350&quot;<b>         </b><b>NUMERIC</b><b>(</b>6<b>,</b>2<b>)</b><b> </b><b>DEFAULT</b><b> </b>0<b>,</b>
<b>    </b>&quot;LaborIntensity001&quot;<b>     </b><b>NUMERIC</b><b>(</b>6<b>,</b>2<b>)</b><b> </b><b>DEFAULT</b><b> </b>0<b>,</b>
<b>    </b>&quot;LaborIntensity002&quot;<b>     </b><b>NUMERIC</b><b>(</b>6<b>,</b>2<b>)</b><b> </b><b>DEFAULT</b><b> </b>0<b>,</b>
<b>    </b>&quot;LaborIntensity003&quot;<b>     </b><b>NUMERIC</b><b>(</b>6<b>,</b>2<b>)</b><b> </b><b>DEFAULT</b><b> </b>0<b>,</b>
<b>    </b>&quot;LaborIntensity004&quot;<b>     </b><b>NUMERIC</b><b>(</b>6<b>,</b>2<b>)</b><b> </b><b>DEFAULT</b><b> </b>0<b>,</b>
<b>    </b>&quot;LaborIntensity005&quot;<b>     </b><b>NUMERIC</b><b>(</b>6<b>,</b>2<b>)</b><b> </b><b>DEFAULT</b><b> </b>0
<b>)</b><b>;</b>


<b>ALTER</b><b> </b><b>TABLE</b><b> </b><font color="# 080 0"><u>&quot;TechProcess001&quot;</u></font><b> </b><b>ADD</b><b> </b><b>CONSTRAINT</b><b> </b>&quot;PK_TechProcess001Id&quot;<b> </b><b>PRIMARY</b><b> </b><b>KEY</b><b> </b><b>(</b>&quot;Id&quot;<b>)</b><b>;</b>
<b>ALTER</b><b> </b><b>TABLE</b><b> </b><font color="# 080 0"><u>&quot;TechProcess001&quot;</u></font><b> </b><b>ADD</b><b> </b><b>CONSTRAINT</b><b> </b>&quot;FK_TechProcess001_CopyDrawingId&quot;<b> </b><b>FOREIGN</b><b> </b><b>KEY</b><b> </b><b>(</b>&quot;CopyDrawingId&quot;<b>)</b><b> </b><b>REFERENCES</b><b> </b><font color="# 080 0"><u>&quot;Drawing&quot;</u></font><b> </b><b>(</b>&quot;Id&quot;<b>)</b><b> </b><b>ON</b><b> </b><b>DELETE</b><b> </b><b>SET</b><b> </b><b>NULL</b><b>;</b>
<b>ALTER</b><b> </b><b>TABLE</b><b> </b><font color="# 080 0"><u>&quot;TechProcess001&quot;</u></font><b> </b><b>ADD</b><b> </b><b>CONSTRAINT</b><b> </b>&quot;FK_TechProcess001_DrawingId&quot;<b> </b><b>FOREIGN</b><b> </b><b>KEY</b><b> </b><b>(</b>&quot;DrawingId&quot;<b>)</b><b> </b><b>REFERENCES</b><b> </b><font color="# 080 0"><u>&quot;Drawing&quot;</u></font><b> </b><b>(</b>&quot;Id&quot;<b>)</b><b> </b><b>ON</b><b> </b><b>DELETE</b><b> </b><b>SET</b><b> </b><b>NULL</b><b>;</b>
<b>ALTER</b><b> </b><b>TABLE</b><b> </b><font color="# 080 0"><u>&quot;TechProcess001&quot;</u></font><b> </b><b>ADD</b><b> </b><b>CONSTRAINT</b><b> </b>&quot;FK_TechProcess001_ParentId&quot;<b> </b><b>FOREIGN</b><b> </b><b>KEY</b><b> </b><b>(</b>&quot;ParentId&quot;<b>)</b><b> </b><b>REFERENCES</b><b> </b><font color="# 080 0"><u>&quot;TechProcess001&quot;</u></font><b> </b><b>(</b>&quot;Id&quot;<b>)</b><b> </b><b>ON</b><b> </b><b>DELETE</b><b> </b><b>SET</b><b> </b><b>NULL</b><b>;</b>
<b>ALTER</b><b> </b><b>TABLE</b><b> </b><font color="# 080 0"><u>&quot;TechProcess001&quot;</u></font><b> </b><b>ADD</b><b> </b><b>CONSTRAINT</b><b> </b>&quot;FK_TechProcess001_RevisionId&quot;<b> </b><b>FOREIGN</b><b> </b><b>KEY</b><b> </b><b>(</b>&quot;RevisionId&quot;<b>)</b><b> </b><b>REFERENCES</b><b> </b><font color="# 080 0"><u>&quot;Revisions&quot;</u></font><b> </b><b>(</b>&quot;Id&quot;<b>)</b><b>;</b>
<b>ALTER</b><b> </b><b>TABLE</b><b> </b><font color="# 080 0"><u>&quot;TechProcess001&quot;</u></font><b> </b><b>ADD</b><b> </b><b>CONSTRAINT</b><b> </b>&quot;FK_TechProcess001_TypeId&quot;<b> </b><b>FOREIGN</b><b> </b><b>KEY</b><b> </b><b>(</b>&quot;TypeId&quot;<b>)</b><b> </b><b>REFERENCES</b><b> </b><font color="# 080 0"><u>&quot;RevisionType&quot;</u></font><b> </b><b>(</b>&quot;Id&quot;<b>)</b><b>;</b>
<b>ALTER</b><b> </b><b>TABLE</b><b> </b><font color="# 080 0"><u>&quot;TechProcess001&quot;</u></font><b> </b><b>ADD</b><b> </b><b>CONSTRAINT</b><b> </b>&quot;FK_TechProcess001_UserId&quot;<b> </b><b>FOREIGN</b><b> </b><b>KEY</b><b> </b><b>(</b>&quot;UserId&quot;<b>)</b><b> </b><b>REFERENCES</b><b> </b><font color="# 080 0"><u>&quot;Users&quot;</u></font><b> </b><b>(</b>&quot;Id&quot;<b>)</b><b>;</b>

</pre></code>
</span></P>
<P CLASS="Base">&nbsp;</P>

<HR>
<A NAME="TBL_TechProcess002"><P CLASS="Header0">Table: TechProcess002</P><P CLASS="Base">&nbsp;</P>
<P CLASS="Header1">Description</P>
<P CLASS="Base"><I>(There is no description for table TechProcess002)</I></P>
<P CLASS="Base">&nbsp;</P>
<P CLASS="Header1">Fields</P>
<TABLE CLASS="dtArg" CELLSPACING="0">
  <TH WIDTH="1%" ALIGN="middle"><P CLASS="Base2"><B>PK</B></P>
  <TH WIDTH="1%" ALIGN="middle"><P CLASS="Base2"><B>FK</B></P>
  <TH WIDTH="1%"><P CLASS="Base2"><B>Field</B></P>
  <TH WIDTH="1%"><P CLASS="Base2"><B>Domain</B></P>
  <TH WIDTH="20%"><P CLASS="Base2"><B>Type</B></P>
  <TH WIDTH="1%" ALIGN="middle"><P CLASS="Base2"><B>NN</B></P>
  <TH WIDTH="1%"><P CLASS="Base2"><B>Default</B></P>
  <TH WIDTH="40%"><P CLASS="Base2"><B>Description</B></P>
  <TR>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/PK1.gif" BORDER="0"></P></TD>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD><A NAME="TechProcess002.Id"><P CLASS="Base2">Id</P></A></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">INTEGER</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/Yes.gif" BORDER="0"></P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
  </TR>
  <TR>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD><A NAME="TechProcess002.TechProcessName"><P CLASS="Base2">TechProcessName</P></A></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">BIGINT</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
  </TR>
  <TR>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD><A NAME="TechProcess002.TechProcessPath"><P CLASS="Base2">TechProcessPath</P></A></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">VARCHAR(200)</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
  </TR>
  <TR>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD><A NAME="TechProcess002.TechProcessFullName"><P CLASS="Base2">TechProcessFullName</P></A></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">VARCHAR(50)</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
  </TR>
  <TR>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/FK.gif" BORDER="0"></P></TD>
    <TD><A NAME="TechProcess002.RevisionId"><P CLASS="Base2">RevisionId</P></A></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">SMALLINT</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
  </TR>
  <TR>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/FK.gif" BORDER="0"></P></TD>
    <TD><A NAME="TechProcess002.DrawingId"><P CLASS="Base2">DrawingId</P></A></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">SMALLINT</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
  </TR>
  <TR>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/FK.gif" BORDER="0"></P></TD>
    <TD><A NAME="TechProcess002.CopyDrawingId"><P CLASS="Base2">CopyDrawingId</P></A></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">SMALLINT</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
  </TR>
  <TR>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/FK.gif" BORDER="0"></P></TD>
    <TD><A NAME="TechProcess002.ParentId"><P CLASS="Base2">ParentId</P></A></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">SMALLINT</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
  </TR>
  <TR>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD><A NAME="TechProcess002.CreateDate"><P CLASS="Base2">CreateDate</P></A></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">DATE</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></P></TD>
    <TD><P CLASS="Base2">CURRENT_DATE</P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
  </TR>
  <TR>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/FK.gif" BORDER="0"></P></TD>
    <TD><A NAME="TechProcess002.TypeId"><P CLASS="Base2">TypeId</P></A></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">SMALLINT</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></P></TD>
    <TD><P CLASS="Base2">1</P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
  </TR>
  <TR>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD><A NAME="TechProcess002.OldTechProcess"><P CLASS="Base2">OldTechProcess</P></A></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">SMALLINT</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></P></TD>
    <TD><P CLASS="Base2">0</P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
  </TR>
  <TR>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD><A NAME="TechProcess002.TH"><P CLASS="Base2">TH</P></A></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">VARCHAR(10)</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></P></TD>
    <TD><P CLASS="Base2">0</P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
  </TR>
  <TR>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD><A NAME="TechProcess002.W"><P CLASS="Base2">W</P></A></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">VARCHAR(10)</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></P></TD>
    <TD><P CLASS="Base2">0</P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
  </TR>
  <TR>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD><A NAME="TechProcess002.W2"><P CLASS="Base2">W2</P></A></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">VARCHAR(10)</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></P></TD>
    <TD><P CLASS="Base2">0</P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
  </TR>
  <TR>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD><A NAME="TechProcess002.L"><P CLASS="Base2">L</P></A></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">VARCHAR(10)</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></P></TD>
    <TD><P CLASS="Base2">0</P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
  </TR>
  <TR>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD><A NAME="TechProcess002.Weight"><P CLASS="Base2">Weight</P></A></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">NUMERIC(10,2)</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></P></TD>
    <TD><P CLASS="Base2">0</P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
  </TR>
  <TR>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/FK.gif" BORDER="0"></P></TD>
    <TD><A NAME="TechProcess002.UserId"><P CLASS="Base2">UserId</P></A></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">SMALLINT</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
  </TR>
  <TR>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD><A NAME="TechProcess002.RevisionDocumentName"><P CLASS="Base2">RevisionDocumentName</P></A></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">VARCHAR(20)</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
  </TR>
  <TR>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD><A NAME="TechProcess002.Welding20Steel"><P CLASS="Base2">Welding20Steel</P></A></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">NUMERIC(6,2)</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></P></TD>
    <TD><P CLASS="Base2">0</P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
  </TR>
  <TR>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD><A NAME="TechProcess002.Welding10"><P CLASS="Base2">Welding10</P></A></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">NUMERIC(6,2)</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></P></TD>
    <TD><P CLASS="Base2">0</P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
  </TR>
  <TR>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD><A NAME="TechProcess002.Welding12"><P CLASS="Base2">Welding12</P></A></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">NUMERIC(6,2)</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></P></TD>
    <TD><P CLASS="Base2">0</P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
  </TR>
  <TR>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD><A NAME="TechProcess002.Welding16"><P CLASS="Base2">Welding16</P></A></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">NUMERIC(6,2)</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></P></TD>
    <TD><P CLASS="Base2">0</P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
  </TR>
  <TR>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD><A NAME="TechProcess002.Welding20"><P CLASS="Base2">Welding20</P></A></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">NUMERIC(6,2)</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></P></TD>
    <TD><P CLASS="Base2">0</P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
  </TR>
  <TR>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD><A NAME="TechProcess002.GasArCO2"><P CLASS="Base2">GasArCO2</P></A></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">NUMERIC(6,2)</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></P></TD>
    <TD><P CLASS="Base2">0</P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
  </TR>
  <TR>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD><A NAME="TechProcess002.GasCO3"><P CLASS="Base2">GasCO3</P></A></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">NUMERIC(6,2)</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></P></TD>
    <TD><P CLASS="Base2">0</P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
  </TR>
  <TR>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD><A NAME="TechProcess002.GasAr"><P CLASS="Base2">GasAr</P></A></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">NUMERIC(6,2)</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></P></TD>
    <TD><P CLASS="Base2">0</P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
  </TR>
  <TR>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD><A NAME="TechProcess002.WeldingElektrod"><P CLASS="Base2">WeldingElektrod</P></A></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">NUMERIC(6,2)</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></P></TD>
    <TD><P CLASS="Base2">0</P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
  </TR>
  <TR>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD><A NAME="TechProcess002.GasO2"><P CLASS="Base2">GasO2</P></A></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">NUMERIC(6,2)</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></P></TD>
    <TD><P CLASS="Base2">0</P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
  </TR>
  <TR>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD><A NAME="TechProcess002.GasNature"><P CLASS="Base2">GasNature</P></A></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">NUMERIC(6,2)</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></P></TD>
    <TD><P CLASS="Base2">0</P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
  </TR>
  <TR>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD><A NAME="TechProcess002.GasN2"><P CLASS="Base2">GasN2</P></A></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">NUMERIC(6,2)</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></P></TD>
    <TD><P CLASS="Base2">0</P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
  </TR>
  <TR>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD><A NAME="TechProcess002.HardKapci881"><P CLASS="Base2">HardKapci881</P></A></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">NUMERIC(6,2)</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></P></TD>
    <TD><P CLASS="Base2">0</P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
  </TR>
  <TR>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD><A NAME="TechProcess002.HardKapciHs6055"><P CLASS="Base2">HardKapciHs6055</P></A></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">NUMERIC(6,2)</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></P></TD>
    <TD><P CLASS="Base2">0</P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
  </TR>
  <TR>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD><A NAME="TechProcess002.HardKapci126"><P CLASS="Base2">HardKapci126</P></A></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">NUMERIC(6,2)</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></P></TD>
    <TD><P CLASS="Base2">0</P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
  </TR>
  <TR>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD><A NAME="TechProcess002.HardKapciPEPutty"><P CLASS="Base2">HardKapciPEPutty</P></A></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">NUMERIC(6,2)</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></P></TD>
    <TD><P CLASS="Base2">0</P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
  </TR>
  <TR>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD><A NAME="TechProcess002.HardKapci2KMS651"><P CLASS="Base2">HardKapci2KMS651</P></A></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">NUMERIC(6,2)</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></P></TD>
    <TD><P CLASS="Base2">0</P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
  </TR>
  <TR>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD><A NAME="TechProcess002.DilKapci881"><P CLASS="Base2">DilKapci881</P></A></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">NUMERIC(6,2)</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></P></TD>
    <TD><P CLASS="Base2">0</P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
  </TR>
  <TR>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD><A NAME="TechProcess002.DilKapci2K"><P CLASS="Base2">DilKapci2K</P></A></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">NUMERIC(6,2)</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></P></TD>
    <TD><P CLASS="Base2">0</P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
  </TR>
  <TR>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD><A NAME="TechProcess002.DilKapci880"><P CLASS="Base2">DilKapci880</P></A></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">NUMERIC(6,2)</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></P></TD>
    <TD><P CLASS="Base2">0</P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
  </TR>
  <TR>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD><A NAME="TechProcess002.PrimerKapci125"><P CLASS="Base2">PrimerKapci125</P></A></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">NUMERIC(6,2)</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></P></TD>
    <TD><P CLASS="Base2">0</P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
  </TR>
  <TR>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD><A NAME="TechProcess002.PrimerKapci633"><P CLASS="Base2">PrimerKapci633</P></A></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">NUMERIC(6,2)</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></P></TD>
    <TD><P CLASS="Base2">0</P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
  </TR>
  <TR>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD><A NAME="TechProcess002.EnamelKapci641"><P CLASS="Base2">EnamelKapci641</P></A></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">NUMERIC(6,2)</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></P></TD>
    <TD><P CLASS="Base2">0</P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
  </TR>
  <TR>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD><A NAME="TechProcess002.EnamelKapci670"><P CLASS="Base2">EnamelKapci670</P></A></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">NUMERIC(6,2)</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></P></TD>
    <TD><P CLASS="Base2">0</P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
  </TR>
  <TR>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD><A NAME="TechProcess002.EnamelKapci6030"><P CLASS="Base2">EnamelKapci6030</P></A></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">NUMERIC(6,2)</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></P></TD>
    <TD><P CLASS="Base2">0</P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
  </TR>
  <TR>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD><A NAME="TechProcess002.UniversalSikaflex527"><P CLASS="Base2">UniversalSikaflex527</P></A></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">NUMERIC(6,2)</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></P></TD>
    <TD><P CLASS="Base2">0</P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
  </TR>
  <TR>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD><A NAME="TechProcess002.PuttyKapci350"><P CLASS="Base2">PuttyKapci350</P></A></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">NUMERIC(6,2)</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></P></TD>
    <TD><P CLASS="Base2">0</P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
  </TR>
  <TR>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD><A NAME="TechProcess002.LaborIntensity001"><P CLASS="Base2">LaborIntensity001</P></A></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">NUMERIC(6,2)</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></P></TD>
    <TD><P CLASS="Base2">0</P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
  </TR>
  <TR>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD><A NAME="TechProcess002.LaborIntensity002"><P CLASS="Base2">LaborIntensity002</P></A></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">NUMERIC(6,2)</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></P></TD>
    <TD><P CLASS="Base2">0</P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
  </TR>
  <TR>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD><A NAME="TechProcess002.LaborIntensity003"><P CLASS="Base2">LaborIntensity003</P></A></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">NUMERIC(6,2)</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></P></TD>
    <TD><P CLASS="Base2">0</P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
  </TR>
  <TR>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD><A NAME="TechProcess002.LaborIntensity004"><P CLASS="Base2">LaborIntensity004</P></A></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">NUMERIC(6,2)</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></P></TD>
    <TD><P CLASS="Base2">0</P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
  </TR>
  <TR>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD><A NAME="TechProcess002.LaborIntensity005"><P CLASS="Base2">LaborIntensity005</P></A></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">NUMERIC(6,2)</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></P></TD>
    <TD><P CLASS="Base2">0</P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
  </TR>
</TABLE>
<P CLASS="Base">&nbsp;</P>
<P CLASS="Header1">Triggers</P>
<TABLE CLASS="dtArg" CELLSPACING="0">
  <TH WIDTH="1%"><P CLASS="Base2"><B>Trigger</B></P>
  <TH WIDTH="1%"><P CLASS="Base2"><B>Type</B></P>
  <TH WIDTH="1%"><P CLASS="Base2"><B>Activity</B></P>
  <TH WIDTH="1%"><P CLASS="Base2"><B>Order</B></P>
  <TH WIDTH="50%"><P CLASS="Base2"><B>Description</B></P>
  <TR>
    <TD><P CLASS="Base2"><A HREF="#TRG_Tr_TechProcess002">Tr_TechProcess002</A></TD>
    <TD><P CLASS="Base2">BEFORE&nbsp;INSERT</TD>
    <TD><P CLASS="Base2">Yes</TD>
    <TD ALIGN="right"><P CLASS="Base2">0</TD>
    <TD><P CLASS="Base2">&nbsp</TD>
  </TR>
</TABLE>
<P CLASS="Base">&nbsp;</P>
<P CLASS="Header1">Indices</P>
<TABLE CLASS="dtArg" CELLSPACING="0">
  <TH><P CLASS="Base2"><B>Index</B></P>
  <TH><P CLASS="Base2"><B>Fields</B></P>
  <TH ALIGN="middle"><P CLASS="Base2"><B>Active</B></P>
  <TH ALIGN="middle"><P CLASS="Base2"><B>Unique</B></P>
  <TH ALIGN="middle"><P CLASS="Base2"><B>Order</B></P>
  <TR>
    <TD><P CLASS="Base2"><A HREF="#IND_FK_TechProcess002_CopyDrawingId">FK_TechProcess002_CopyDrawingId</A></TD>
    <TD><P CLASS="Base2">"CopyDrawingId"</TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/Yes.gif" BORDER="0"></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></TD>
    <TD ALIGN="middle"><P CLASS="Base2">ASC</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2"><A HREF="#IND_FK_TechProcess002_DrawingId">FK_TechProcess002_DrawingId</A></TD>
    <TD><P CLASS="Base2">"DrawingId"</TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/Yes.gif" BORDER="0"></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></TD>
    <TD ALIGN="middle"><P CLASS="Base2">ASC</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2"><A HREF="#IND_FK_TechProcess002_ParentId">FK_TechProcess002_ParentId</A></TD>
    <TD><P CLASS="Base2">"ParentId"</TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/Yes.gif" BORDER="0"></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></TD>
    <TD ALIGN="middle"><P CLASS="Base2">ASC</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2"><A HREF="#IND_FK_TechProcess002_RevisionId">FK_TechProcess002_RevisionId</A></TD>
    <TD><P CLASS="Base2">"RevisionId"</TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/Yes.gif" BORDER="0"></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></TD>
    <TD ALIGN="middle"><P CLASS="Base2">ASC</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2"><A HREF="#IND_FK_TechProcess002_TypeId">FK_TechProcess002_TypeId</A></TD>
    <TD><P CLASS="Base2">"TypeId"</TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/Yes.gif" BORDER="0"></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></TD>
    <TD ALIGN="middle"><P CLASS="Base2">ASC</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2"><A HREF="#IND_FK_TechProcess002_UserId">FK_TechProcess002_UserId</A></TD>
    <TD><P CLASS="Base2">"UserId"</TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/Yes.gif" BORDER="0"></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></TD>
    <TD ALIGN="middle"><P CLASS="Base2">ASC</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2"><A HREF="#IND_PK_TechProcess002Id">PK_TechProcess002Id</A></TD>
    <TD><P CLASS="Base2">"Id"</TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/Yes.gif" BORDER="0"></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/Yes.gif" BORDER="0"></TD>
    <TD ALIGN="middle"><P CLASS="Base2">ASC</TD>
  </TR>
</TABLE>
<P CLASS="Base">&nbsp;</P>
<P CLASS="Header1">References</P>
<TABLE CLASS="dtArg" CELLSPACING="0">
  <TH><P CLASS="Base2"><B>Table</B></P>
  <TH><P CLASS="Base2"><B>Foreign Key</B></P>
  <TH><P CLASS="Base2"><B>Fields</B></P>
  <TH><P CLASS="Base2"><B>FK Field</B></P>
  <TH><P CLASS="Base2"><B>Delete Rule</B></P>
  <TH><P CLASS="Base2"><B>Update Rule</B></P>
  <TR>
    <TD><P CLASS="Base2"><A HREF="#TBL_Drawing">Drawing</A></TD>
    <TD><P CLASS="Base2"><A HREF="#FKEY_FK_TechProcess002_CopyDrawingId">FK_TechProcess002_CopyDrawingId</A></TD>
    <TD><P CLASS="Base2">CopyDrawingId</TD>
    <TD><P CLASS="Base2">Id</TD>
    <TD><P CLASS="Base2">SET NULL</TD>
    <TD><P CLASS="Base2">NO ACTION</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2"><A HREF="#TBL_Drawing">Drawing</A></TD>
    <TD><P CLASS="Base2"><A HREF="#FKEY_FK_TechProcess002_DrawingId">FK_TechProcess002_DrawingId</A></TD>
    <TD><P CLASS="Base2">DrawingId</TD>
    <TD><P CLASS="Base2">Id</TD>
    <TD><P CLASS="Base2">SET NULL</TD>
    <TD><P CLASS="Base2">NO ACTION</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2"><A HREF="#TBL_TechProcess002">TechProcess002</A></TD>
    <TD><P CLASS="Base2"><A HREF="#FKEY_FK_TechProcess002_ParentId">FK_TechProcess002_ParentId</A></TD>
    <TD><P CLASS="Base2">ParentId</TD>
    <TD><P CLASS="Base2">Id</TD>
    <TD><P CLASS="Base2">SET NULL</TD>
    <TD><P CLASS="Base2">NO ACTION</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2"><A HREF="#TBL_Revisions">Revisions</A></TD>
    <TD><P CLASS="Base2"><A HREF="#FKEY_FK_TechProcess002_RevisionId">FK_TechProcess002_RevisionId</A></TD>
    <TD><P CLASS="Base2">RevisionId</TD>
    <TD><P CLASS="Base2">Id</TD>
    <TD><P CLASS="Base2">NO ACTION</TD>
    <TD><P CLASS="Base2">NO ACTION</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2"><A HREF="#TBL_RevisionType">RevisionType</A></TD>
    <TD><P CLASS="Base2"><A HREF="#FKEY_FK_TechProcess002_TypeId">FK_TechProcess002_TypeId</A></TD>
    <TD><P CLASS="Base2">TypeId</TD>
    <TD><P CLASS="Base2">Id</TD>
    <TD><P CLASS="Base2">NO ACTION</TD>
    <TD><P CLASS="Base2">NO ACTION</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2"><A HREF="#TBL_Users">Users</A></TD>
    <TD><P CLASS="Base2"><A HREF="#FKEY_FK_TechProcess002_UserId">FK_TechProcess002_UserId</A></TD>
    <TD><P CLASS="Base2">UserId</TD>
    <TD><P CLASS="Base2">Id</TD>
    <TD><P CLASS="Base2">NO ACTION</TD>
    <TD><P CLASS="Base2">NO ACTION</TD>
  </TR>
</TABLE>
<P CLASS="Base">&nbsp;</P>
<P CLASS="Header1">Referenced By</P>
<TABLE CLASS="dtArg" CELLSPACING="0">
  <TH><P CLASS="Base2"><B>Table</B></P>
  <TH><P CLASS="Base2"><B>Foreign Key</B></P>
  <TH><P CLASS="Base2"><B>Fields</B></P>
  <TH><P CLASS="Base2"><B>FK Field</B></P>
  <TH><P CLASS="Base2"><B>Delete Rule</B></P>
  <TH><P CLASS="Base2"><B>Update Rule</B></P>
  <TR>
    <TD><P CLASS="Base2"><A HREF="#TBL_TechProcess002">TechProcess002</A></TD>
    <TD><P CLASS="Base2"><A HREF="#FKEY_FK_TechProcess002_ParentId">FK_TechProcess002_ParentId</A></TD>
    <TD><P CLASS="Base2">ParentId</TD>
    <TD><P CLASS="Base2">Id</TD>
    <TD><P CLASS="Base2">SET NULL</TD>
    <TD><P CLASS="Base2">NO ACTION</TD>
  </TR>
</TABLE>
<P CLASS="Base">&nbsp;</P>
<P CLASS="Header1">Definition</P>
<P CLASS="Base"><span class="DDLCode">
<code><pre>
<b>CREATE</b><b> </b><b>TABLE</b><b> </b><font color="# 080 0"><u>&quot;TechProcess002&quot;</u></font><b> </b><b>(</b>
<b>    </b>&quot;Id&quot;<b>                    </b><b>INTEGER</b><b> </b><b>NOT</b><b> </b><b>NULL</b><b>,</b>
<b>    </b>&quot;TechProcessName&quot;<b>       </b><b>BIGINT</b><b>,</b>
<b>    </b>&quot;TechProcessPath&quot;<b>       </b><b>VARCHAR</b><b>(</b>200<b>)</b><b>,</b>
<b>    </b>&quot;TechProcessFullName&quot;<b>   </b><b>VARCHAR</b><b>(</b>50<b>)</b><b>,</b>
<b>    </b>&quot;RevisionId&quot;<b>            </b><b>SMALLINT</b><b>,</b>
<b>    </b>&quot;DrawingId&quot;<b>             </b><b>SMALLINT</b><b>,</b>
<b>    </b>&quot;CopyDrawingId&quot;<b>         </b><b>SMALLINT</b><b>,</b>
<b>    </b>&quot;ParentId&quot;<b>              </b><b>SMALLINT</b><b>,</b>
<b>    </b>&quot;CreateDate&quot;<b>            </b><b>DATE</b><b> </b><b>DEFAULT</b><b> </b><b>CURRENT_DATE</b><b>,</b>
<b>    </b>&quot;TypeId&quot;<b>                </b><b>SMALLINT</b><b> </b><b>DEFAULT</b><b> </b>1<b>,</b>
<b>    </b>&quot;OldTechProcess&quot;<b>        </b><b>SMALLINT</b><b> </b><b>DEFAULT</b><b> </b>0<b>,</b>
<b>    </b>TH<b>                      </b><b>VARCHAR</b><b>(</b>10<b>)</b><b> </b><b>CHARACTER</b><b> </b><b>SET</b><b> </b>WIN1251<b> </b><b>DEFAULT</b><b> </b>0<b>,</b>
<b>    </b>W<b>                       </b><b>VARCHAR</b><b>(</b>10<b>)</b><b> </b><b>CHARACTER</b><b> </b><b>SET</b><b> </b>WIN1251<b> </b><b>DEFAULT</b><b> </b>0<b>,</b>
<b>    </b>W2<b>                      </b><b>VARCHAR</b><b>(</b>10<b>)</b><b> </b><b>CHARACTER</b><b> </b><b>SET</b><b> </b>WIN1251<b> </b><b>DEFAULT</b><b> </b>0<b>,</b>
<b>    </b>L<b>                       </b><b>VARCHAR</b><b>(</b>10<b>)</b><b> </b><b>CHARACTER</b><b> </b><b>SET</b><b> </b>WIN1251<b> </b><b>DEFAULT</b><b> </b>0<b>,</b>
<b>    </b>&quot;Weight&quot;<b>                </b><b>NUMERIC</b><b>(</b>10<b>,</b>2<b>)</b><b> </b><b>DEFAULT</b><b> </b>0<b>,</b>
<b>    </b>&quot;UserId&quot;<b>                </b><b>SMALLINT</b><b>,</b>
<b>    </b>&quot;RevisionDocumentName&quot;<b>  </b><b>VARCHAR</b><b>(</b>20<b>)</b><b>,</b>
<b>    </b>&quot;Welding20Steel&quot;<b>        </b><b>NUMERIC</b><b>(</b>6<b>,</b>2<b>)</b><b> </b><b>DEFAULT</b><b> </b>0<b>,</b>
<b>    </b>&quot;Welding10&quot;<b>             </b><b>NUMERIC</b><b>(</b>6<b>,</b>2<b>)</b><b> </b><b>DEFAULT</b><b> </b>0<b>,</b>
<b>    </b>&quot;Welding12&quot;<b>             </b><b>NUMERIC</b><b>(</b>6<b>,</b>2<b>)</b><b> </b><b>DEFAULT</b><b> </b>0<b>,</b>
<b>    </b>&quot;Welding16&quot;<b>             </b><b>NUMERIC</b><b>(</b>6<b>,</b>2<b>)</b><b> </b><b>DEFAULT</b><b> </b>0<b>,</b>
<b>    </b>&quot;Welding20&quot;<b>             </b><b>NUMERIC</b><b>(</b>6<b>,</b>2<b>)</b><b> </b><b>DEFAULT</b><b> </b>0<b>,</b>
<b>    </b>&quot;GasArCO2&quot;<b>              </b><b>NUMERIC</b><b>(</b>6<b>,</b>2<b>)</b><b> </b><b>DEFAULT</b><b> </b>0<b>,</b>
<b>    </b>&quot;GasCO3&quot;<b>                </b><b>NUMERIC</b><b>(</b>6<b>,</b>2<b>)</b><b> </b><b>DEFAULT</b><b> </b>0<b>,</b>
<b>    </b>&quot;GasAr&quot;<b>                 </b><b>NUMERIC</b><b>(</b>6<b>,</b>2<b>)</b><b> </b><b>DEFAULT</b><b> </b>0<b>,</b>
<b>    </b>&quot;WeldingElektrod&quot;<b>       </b><b>NUMERIC</b><b>(</b>6<b>,</b>2<b>)</b><b> </b><b>DEFAULT</b><b> </b>0<b>,</b>
<b>    </b>&quot;GasO2&quot;<b>                 </b><b>NUMERIC</b><b>(</b>6<b>,</b>2<b>)</b><b> </b><b>DEFAULT</b><b> </b>0<b>,</b>
<b>    </b>&quot;GasNature&quot;<b>             </b><b>NUMERIC</b><b>(</b>6<b>,</b>2<b>)</b><b> </b><b>DEFAULT</b><b> </b>0<b>,</b>
<b>    </b>&quot;GasN2&quot;<b>                 </b><b>NUMERIC</b><b>(</b>6<b>,</b>2<b>)</b><b> </b><b>DEFAULT</b><b> </b>0<b>,</b>
<b>    </b>&quot;HardKapci881&quot;<b>          </b><b>NUMERIC</b><b>(</b>6<b>,</b>2<b>)</b><b> </b><b>DEFAULT</b><b> </b>0<b>,</b>
<b>    </b>&quot;HardKapciHs6055&quot;<b>       </b><b>NUMERIC</b><b>(</b>6<b>,</b>2<b>)</b><b> </b><b>DEFAULT</b><b> </b>0<b>,</b>
<b>    </b>&quot;HardKapci126&quot;<b>          </b><b>NUMERIC</b><b>(</b>6<b>,</b>2<b>)</b><b> </b><b>DEFAULT</b><b> </b>0<b>,</b>
<b>    </b>&quot;HardKapciPEPutty&quot;<b>      </b><b>NUMERIC</b><b>(</b>6<b>,</b>2<b>)</b><b> </b><b>DEFAULT</b><b> </b>0<b>,</b>
<b>    </b>&quot;HardKapci2KMS651&quot;<b>      </b><b>NUMERIC</b><b>(</b>6<b>,</b>2<b>)</b><b> </b><b>DEFAULT</b><b> </b>0<b>,</b>
<b>    </b>&quot;DilKapci881&quot;<b>           </b><b>NUMERIC</b><b>(</b>6<b>,</b>2<b>)</b><b> </b><b>DEFAULT</b><b> </b>0<b>,</b>
<b>    </b>&quot;DilKapci2K&quot;<b>            </b><b>NUMERIC</b><b>(</b>6<b>,</b>2<b>)</b><b> </b><b>DEFAULT</b><b> </b>0<b>,</b>
<b>    </b>&quot;DilKapci880&quot;<b>           </b><b>NUMERIC</b><b>(</b>6<b>,</b>2<b>)</b><b> </b><b>DEFAULT</b><b> </b>0<b>,</b>
<b>    </b>&quot;PrimerKapci125&quot;<b>        </b><b>NUMERIC</b><b>(</b>6<b>,</b>2<b>)</b><b> </b><b>DEFAULT</b><b> </b>0<b>,</b>
<b>    </b>&quot;PrimerKapci633&quot;<b>        </b><b>NUMERIC</b><b>(</b>6<b>,</b>2<b>)</b><b> </b><b>DEFAULT</b><b> </b>0<b>,</b>
<b>    </b>&quot;EnamelKapci641&quot;<b>        </b><b>NUMERIC</b><b>(</b>6<b>,</b>2<b>)</b><b> </b><b>DEFAULT</b><b> </b>0<b>,</b>
<b>    </b>&quot;EnamelKapci670&quot;<b>        </b><b>NUMERIC</b><b>(</b>6<b>,</b>2<b>)</b><b> </b><b>DEFAULT</b><b> </b>0<b>,</b>
<b>    </b>&quot;EnamelKapci6030&quot;<b>       </b><b>NUMERIC</b><b>(</b>6<b>,</b>2<b>)</b><b> </b><b>DEFAULT</b><b> </b>0<b>,</b>
<b>    </b>&quot;UniversalSikaflex527&quot;<b>  </b><b>NUMERIC</b><b>(</b>6<b>,</b>2<b>)</b><b> </b><b>DEFAULT</b><b> </b>0<b>,</b>
<b>    </b>&quot;PuttyKapci350&quot;<b>         </b><b>NUMERIC</b><b>(</b>6<b>,</b>2<b>)</b><b> </b><b>DEFAULT</b><b> </b>0<b>,</b>
<b>    </b>&quot;LaborIntensity001&quot;<b>     </b><b>NUMERIC</b><b>(</b>6<b>,</b>2<b>)</b><b> </b><b>DEFAULT</b><b> </b>0<b>,</b>
<b>    </b>&quot;LaborIntensity002&quot;<b>     </b><b>NUMERIC</b><b>(</b>6<b>,</b>2<b>)</b><b> </b><b>DEFAULT</b><b> </b>0<b>,</b>
<b>    </b>&quot;LaborIntensity003&quot;<b>     </b><b>NUMERIC</b><b>(</b>6<b>,</b>2<b>)</b><b> </b><b>DEFAULT</b><b> </b>0<b>,</b>
<b>    </b>&quot;LaborIntensity004&quot;<b>     </b><b>NUMERIC</b><b>(</b>6<b>,</b>2<b>)</b><b> </b><b>DEFAULT</b><b> </b>0<b>,</b>
<b>    </b>&quot;LaborIntensity005&quot;<b>     </b><b>NUMERIC</b><b>(</b>6<b>,</b>2<b>)</b><b> </b><b>DEFAULT</b><b> </b>0
<b>)</b><b>;</b>


<b>ALTER</b><b> </b><b>TABLE</b><b> </b><font color="# 080 0"><u>&quot;TechProcess002&quot;</u></font><b> </b><b>ADD</b><b> </b><b>CONSTRAINT</b><b> </b>&quot;PK_TechProcess002Id&quot;<b> </b><b>PRIMARY</b><b> </b><b>KEY</b><b> </b><b>(</b>&quot;Id&quot;<b>)</b><b>;</b>
<b>ALTER</b><b> </b><b>TABLE</b><b> </b><font color="# 080 0"><u>&quot;TechProcess002&quot;</u></font><b> </b><b>ADD</b><b> </b><b>CONSTRAINT</b><b> </b>&quot;FK_TechProcess002_CopyDrawingId&quot;<b> </b><b>FOREIGN</b><b> </b><b>KEY</b><b> </b><b>(</b>&quot;CopyDrawingId&quot;<b>)</b><b> </b><b>REFERENCES</b><b> </b><font color="# 080 0"><u>&quot;Drawing&quot;</u></font><b> </b><b>(</b>&quot;Id&quot;<b>)</b><b> </b><b>ON</b><b> </b><b>DELETE</b><b> </b><b>SET</b><b> </b><b>NULL</b><b>;</b>
<b>ALTER</b><b> </b><b>TABLE</b><b> </b><font color="# 080 0"><u>&quot;TechProcess002&quot;</u></font><b> </b><b>ADD</b><b> </b><b>CONSTRAINT</b><b> </b>&quot;FK_TechProcess002_DrawingId&quot;<b> </b><b>FOREIGN</b><b> </b><b>KEY</b><b> </b><b>(</b>&quot;DrawingId&quot;<b>)</b><b> </b><b>REFERENCES</b><b> </b><font color="# 080 0"><u>&quot;Drawing&quot;</u></font><b> </b><b>(</b>&quot;Id&quot;<b>)</b><b> </b><b>ON</b><b> </b><b>DELETE</b><b> </b><b>SET</b><b> </b><b>NULL</b><b>;</b>
<b>ALTER</b><b> </b><b>TABLE</b><b> </b><font color="# 080 0"><u>&quot;TechProcess002&quot;</u></font><b> </b><b>ADD</b><b> </b><b>CONSTRAINT</b><b> </b>&quot;FK_TechProcess002_ParentId&quot;<b> </b><b>FOREIGN</b><b> </b><b>KEY</b><b> </b><b>(</b>&quot;ParentId&quot;<b>)</b><b> </b><b>REFERENCES</b><b> </b><font color="# 080 0"><u>&quot;TechProcess002&quot;</u></font><b> </b><b>(</b>&quot;Id&quot;<b>)</b><b> </b><b>ON</b><b> </b><b>DELETE</b><b> </b><b>SET</b><b> </b><b>NULL</b><b>;</b>
<b>ALTER</b><b> </b><b>TABLE</b><b> </b><font color="# 080 0"><u>&quot;TechProcess002&quot;</u></font><b> </b><b>ADD</b><b> </b><b>CONSTRAINT</b><b> </b>&quot;FK_TechProcess002_RevisionId&quot;<b> </b><b>FOREIGN</b><b> </b><b>KEY</b><b> </b><b>(</b>&quot;RevisionId&quot;<b>)</b><b> </b><b>REFERENCES</b><b> </b><font color="# 080 0"><u>&quot;Revisions&quot;</u></font><b> </b><b>(</b>&quot;Id&quot;<b>)</b><b>;</b>
<b>ALTER</b><b> </b><b>TABLE</b><b> </b><font color="# 080 0"><u>&quot;TechProcess002&quot;</u></font><b> </b><b>ADD</b><b> </b><b>CONSTRAINT</b><b> </b>&quot;FK_TechProcess002_TypeId&quot;<b> </b><b>FOREIGN</b><b> </b><b>KEY</b><b> </b><b>(</b>&quot;TypeId&quot;<b>)</b><b> </b><b>REFERENCES</b><b> </b><font color="# 080 0"><u>&quot;RevisionType&quot;</u></font><b> </b><b>(</b>&quot;Id&quot;<b>)</b><b>;</b>
<b>ALTER</b><b> </b><b>TABLE</b><b> </b><font color="# 080 0"><u>&quot;TechProcess002&quot;</u></font><b> </b><b>ADD</b><b> </b><b>CONSTRAINT</b><b> </b>&quot;FK_TechProcess002_UserId&quot;<b> </b><b>FOREIGN</b><b> </b><b>KEY</b><b> </b><b>(</b>&quot;UserId&quot;<b>)</b><b> </b><b>REFERENCES</b><b> </b><font color="# 080 0"><u>&quot;Users&quot;</u></font><b> </b><b>(</b>&quot;Id&quot;<b>)</b><b>;</b>

</pre></code>
</span></P>
<P CLASS="Base">&nbsp;</P>

<HR>
<A NAME="TBL_TechProcess003"><P CLASS="Header0">Table: TechProcess003</P><P CLASS="Base">&nbsp;</P>
<P CLASS="Header1">Description</P>
<P CLASS="Base"><I>(There is no description for table TechProcess003)</I></P>
<P CLASS="Base">&nbsp;</P>
<P CLASS="Header1">Fields</P>
<TABLE CLASS="dtArg" CELLSPACING="0">
  <TH WIDTH="1%" ALIGN="middle"><P CLASS="Base2"><B>PK</B></P>
  <TH WIDTH="1%" ALIGN="middle"><P CLASS="Base2"><B>FK</B></P>
  <TH WIDTH="1%"><P CLASS="Base2"><B>Field</B></P>
  <TH WIDTH="1%"><P CLASS="Base2"><B>Domain</B></P>
  <TH WIDTH="20%"><P CLASS="Base2"><B>Type</B></P>
  <TH WIDTH="1%" ALIGN="middle"><P CLASS="Base2"><B>NN</B></P>
  <TH WIDTH="1%"><P CLASS="Base2"><B>Default</B></P>
  <TH WIDTH="40%"><P CLASS="Base2"><B>Description</B></P>
  <TR>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/PK1.gif" BORDER="0"></P></TD>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD><A NAME="TechProcess003.Id"><P CLASS="Base2">Id</P></A></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">INTEGER</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/Yes.gif" BORDER="0"></P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
  </TR>
  <TR>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD><A NAME="TechProcess003.TechProcessName"><P CLASS="Base2">TechProcessName</P></A></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">BIGINT</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
  </TR>
  <TR>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD><A NAME="TechProcess003.TechProcessPath"><P CLASS="Base2">TechProcessPath</P></A></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">VARCHAR(200)</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
  </TR>
  <TR>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD><A NAME="TechProcess003.TechProcessFullName"><P CLASS="Base2">TechProcessFullName</P></A></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">VARCHAR(50)</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
  </TR>
  <TR>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/FK.gif" BORDER="0"></P></TD>
    <TD><A NAME="TechProcess003.RevisionId"><P CLASS="Base2">RevisionId</P></A></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">SMALLINT</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
  </TR>
  <TR>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/FK.gif" BORDER="0"></P></TD>
    <TD><A NAME="TechProcess003.DrawingId"><P CLASS="Base2">DrawingId</P></A></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">SMALLINT</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
  </TR>
  <TR>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/FK.gif" BORDER="0"></P></TD>
    <TD><A NAME="TechProcess003.CopyDrawingId"><P CLASS="Base2">CopyDrawingId</P></A></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">SMALLINT</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
  </TR>
  <TR>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/FK.gif" BORDER="0"></P></TD>
    <TD><A NAME="TechProcess003.ParentId"><P CLASS="Base2">ParentId</P></A></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">SMALLINT</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
  </TR>
  <TR>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD><A NAME="TechProcess003.CreateDate"><P CLASS="Base2">CreateDate</P></A></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">DATE</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></P></TD>
    <TD><P CLASS="Base2">CURRENT_DATE</P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
  </TR>
  <TR>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/FK.gif" BORDER="0"></P></TD>
    <TD><A NAME="TechProcess003.TypeId"><P CLASS="Base2">TypeId</P></A></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">SMALLINT</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></P></TD>
    <TD><P CLASS="Base2">1</P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
  </TR>
  <TR>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD><A NAME="TechProcess003.OldTechProcess"><P CLASS="Base2">OldTechProcess</P></A></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">SMALLINT</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></P></TD>
    <TD><P CLASS="Base2">0</P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
  </TR>
  <TR>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD><A NAME="TechProcess003.TH"><P CLASS="Base2">TH</P></A></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">VARCHAR(10)</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></P></TD>
    <TD><P CLASS="Base2">0</P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
  </TR>
  <TR>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD><A NAME="TechProcess003.W"><P CLASS="Base2">W</P></A></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">VARCHAR(10)</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></P></TD>
    <TD><P CLASS="Base2">0</P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
  </TR>
  <TR>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD><A NAME="TechProcess003.W2"><P CLASS="Base2">W2</P></A></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">VARCHAR(10)</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></P></TD>
    <TD><P CLASS="Base2">0</P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
  </TR>
  <TR>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD><A NAME="TechProcess003.L"><P CLASS="Base2">L</P></A></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">VARCHAR(10)</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></P></TD>
    <TD><P CLASS="Base2">0</P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
  </TR>
  <TR>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD><A NAME="TechProcess003.Weight"><P CLASS="Base2">Weight</P></A></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">NUMERIC(10,2)</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></P></TD>
    <TD><P CLASS="Base2">0</P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
  </TR>
  <TR>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/FK.gif" BORDER="0"></P></TD>
    <TD><A NAME="TechProcess003.UserId"><P CLASS="Base2">UserId</P></A></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">SMALLINT</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
  </TR>
  <TR>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD><A NAME="TechProcess003.RevisionDocumentName"><P CLASS="Base2">RevisionDocumentName</P></A></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">VARCHAR(20)</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
  </TR>
  <TR>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD><A NAME="TechProcess003.Welding20Steel"><P CLASS="Base2">Welding20Steel</P></A></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">NUMERIC(6,2)</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></P></TD>
    <TD><P CLASS="Base2">0</P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
  </TR>
  <TR>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD><A NAME="TechProcess003.Welding10"><P CLASS="Base2">Welding10</P></A></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">NUMERIC(6,2)</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></P></TD>
    <TD><P CLASS="Base2">0</P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
  </TR>
  <TR>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD><A NAME="TechProcess003.Welding12"><P CLASS="Base2">Welding12</P></A></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">NUMERIC(6,2)</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></P></TD>
    <TD><P CLASS="Base2">0</P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
  </TR>
  <TR>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD><A NAME="TechProcess003.Welding16"><P CLASS="Base2">Welding16</P></A></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">NUMERIC(6,2)</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></P></TD>
    <TD><P CLASS="Base2">0</P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
  </TR>
  <TR>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD><A NAME="TechProcess003.Welding20"><P CLASS="Base2">Welding20</P></A></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">NUMERIC(6,2)</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></P></TD>
    <TD><P CLASS="Base2">0</P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
  </TR>
  <TR>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD><A NAME="TechProcess003.GasArCO2"><P CLASS="Base2">GasArCO2</P></A></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">NUMERIC(6,2)</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></P></TD>
    <TD><P CLASS="Base2">0</P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
  </TR>
  <TR>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD><A NAME="TechProcess003.GasCO3"><P CLASS="Base2">GasCO3</P></A></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">NUMERIC(6,2)</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></P></TD>
    <TD><P CLASS="Base2">0</P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
  </TR>
  <TR>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD><A NAME="TechProcess003.GasAr"><P CLASS="Base2">GasAr</P></A></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">NUMERIC(6,2)</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></P></TD>
    <TD><P CLASS="Base2">0</P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
  </TR>
  <TR>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD><A NAME="TechProcess003.WeldingElektrod"><P CLASS="Base2">WeldingElektrod</P></A></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">NUMERIC(6,2)</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></P></TD>
    <TD><P CLASS="Base2">0</P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
  </TR>
  <TR>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD><A NAME="TechProcess003.GasO2"><P CLASS="Base2">GasO2</P></A></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">NUMERIC(6,2)</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></P></TD>
    <TD><P CLASS="Base2">0</P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
  </TR>
  <TR>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD><A NAME="TechProcess003.GasNature"><P CLASS="Base2">GasNature</P></A></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">NUMERIC(6,2)</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></P></TD>
    <TD><P CLASS="Base2">0</P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
  </TR>
  <TR>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD><A NAME="TechProcess003.GasN2"><P CLASS="Base2">GasN2</P></A></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">NUMERIC(6,2)</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></P></TD>
    <TD><P CLASS="Base2">0</P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
  </TR>
  <TR>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD><A NAME="TechProcess003.HardKapci881"><P CLASS="Base2">HardKapci881</P></A></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">NUMERIC(6,2)</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></P></TD>
    <TD><P CLASS="Base2">0</P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
  </TR>
  <TR>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD><A NAME="TechProcess003.HardKapciHs6055"><P CLASS="Base2">HardKapciHs6055</P></A></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">NUMERIC(6,2)</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></P></TD>
    <TD><P CLASS="Base2">0</P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
  </TR>
  <TR>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD><A NAME="TechProcess003.HardKapci126"><P CLASS="Base2">HardKapci126</P></A></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">NUMERIC(6,2)</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></P></TD>
    <TD><P CLASS="Base2">0</P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
  </TR>
  <TR>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD><A NAME="TechProcess003.HardKapciPEPutty"><P CLASS="Base2">HardKapciPEPutty</P></A></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">NUMERIC(6,2)</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></P></TD>
    <TD><P CLASS="Base2">0</P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
  </TR>
  <TR>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD><A NAME="TechProcess003.HardKapci2KMS651"><P CLASS="Base2">HardKapci2KMS651</P></A></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">NUMERIC(6,2)</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></P></TD>
    <TD><P CLASS="Base2">0</P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
  </TR>
  <TR>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD><A NAME="TechProcess003.DilKapci881"><P CLASS="Base2">DilKapci881</P></A></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">NUMERIC(6,2)</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></P></TD>
    <TD><P CLASS="Base2">0</P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
  </TR>
  <TR>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD><A NAME="TechProcess003.DilKapci2K"><P CLASS="Base2">DilKapci2K</P></A></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">NUMERIC(6,2)</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></P></TD>
    <TD><P CLASS="Base2">0</P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
  </TR>
  <TR>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD><A NAME="TechProcess003.DilKapci880"><P CLASS="Base2">DilKapci880</P></A></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">NUMERIC(6,2)</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></P></TD>
    <TD><P CLASS="Base2">0</P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
  </TR>
  <TR>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD><A NAME="TechProcess003.PrimerKapci125"><P CLASS="Base2">PrimerKapci125</P></A></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">NUMERIC(6,2)</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></P></TD>
    <TD><P CLASS="Base2">0</P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
  </TR>
  <TR>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD><A NAME="TechProcess003.PrimerKapci633"><P CLASS="Base2">PrimerKapci633</P></A></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">NUMERIC(6,2)</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></P></TD>
    <TD><P CLASS="Base2">0</P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
  </TR>
  <TR>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD><A NAME="TechProcess003.EnamelKapci641"><P CLASS="Base2">EnamelKapci641</P></A></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">NUMERIC(6,2)</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></P></TD>
    <TD><P CLASS="Base2">0</P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
  </TR>
  <TR>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD><A NAME="TechProcess003.EnamelKapci670"><P CLASS="Base2">EnamelKapci670</P></A></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">NUMERIC(6,2)</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></P></TD>
    <TD><P CLASS="Base2">0</P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
  </TR>
  <TR>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD><A NAME="TechProcess003.EnamelKapci6030"><P CLASS="Base2">EnamelKapci6030</P></A></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">NUMERIC(6,2)</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></P></TD>
    <TD><P CLASS="Base2">0</P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
  </TR>
  <TR>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD><A NAME="TechProcess003.UniversalSikaflex527"><P CLASS="Base2">UniversalSikaflex527</P></A></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">NUMERIC(6,2)</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></P></TD>
    <TD><P CLASS="Base2">0</P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
  </TR>
  <TR>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD><A NAME="TechProcess003.PuttyKapci350"><P CLASS="Base2">PuttyKapci350</P></A></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">NUMERIC(6,2)</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></P></TD>
    <TD><P CLASS="Base2">0</P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
  </TR>
  <TR>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD><A NAME="TechProcess003.LaborIntensity001"><P CLASS="Base2">LaborIntensity001</P></A></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">NUMERIC(6,2)</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></P></TD>
    <TD><P CLASS="Base2">0</P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
  </TR>
  <TR>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD><A NAME="TechProcess003.LaborIntensity002"><P CLASS="Base2">LaborIntensity002</P></A></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">NUMERIC(6,2)</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></P></TD>
    <TD><P CLASS="Base2">0</P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
  </TR>
  <TR>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD><A NAME="TechProcess003.LaborIntensity003"><P CLASS="Base2">LaborIntensity003</P></A></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">NUMERIC(6,2)</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></P></TD>
    <TD><P CLASS="Base2">0</P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
  </TR>
  <TR>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD><A NAME="TechProcess003.LaborIntensity004"><P CLASS="Base2">LaborIntensity004</P></A></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">NUMERIC(6,2)</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></P></TD>
    <TD><P CLASS="Base2">0</P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
  </TR>
  <TR>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD><A NAME="TechProcess003.LaborIntensity005"><P CLASS="Base2">LaborIntensity005</P></A></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">NUMERIC(6,2)</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></P></TD>
    <TD><P CLASS="Base2">0</P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
  </TR>
</TABLE>
<P CLASS="Base">&nbsp;</P>
<P CLASS="Header1">Triggers</P>
<TABLE CLASS="dtArg" CELLSPACING="0">
  <TH WIDTH="1%"><P CLASS="Base2"><B>Trigger</B></P>
  <TH WIDTH="1%"><P CLASS="Base2"><B>Type</B></P>
  <TH WIDTH="1%"><P CLASS="Base2"><B>Activity</B></P>
  <TH WIDTH="1%"><P CLASS="Base2"><B>Order</B></P>
  <TH WIDTH="50%"><P CLASS="Base2"><B>Description</B></P>
  <TR>
    <TD><P CLASS="Base2"><A HREF="#TRG_Tr_TechProcess003">Tr_TechProcess003</A></TD>
    <TD><P CLASS="Base2">BEFORE&nbsp;INSERT</TD>
    <TD><P CLASS="Base2">Yes</TD>
    <TD ALIGN="right"><P CLASS="Base2">0</TD>
    <TD><P CLASS="Base2">&nbsp</TD>
  </TR>
</TABLE>
<P CLASS="Base">&nbsp;</P>
<P CLASS="Header1">Indices</P>
<TABLE CLASS="dtArg" CELLSPACING="0">
  <TH><P CLASS="Base2"><B>Index</B></P>
  <TH><P CLASS="Base2"><B>Fields</B></P>
  <TH ALIGN="middle"><P CLASS="Base2"><B>Active</B></P>
  <TH ALIGN="middle"><P CLASS="Base2"><B>Unique</B></P>
  <TH ALIGN="middle"><P CLASS="Base2"><B>Order</B></P>
  <TR>
    <TD><P CLASS="Base2"><A HREF="#IND_FK_TechProcess003_CopyDrawingId">FK_TechProcess003_CopyDrawingId</A></TD>
    <TD><P CLASS="Base2">"CopyDrawingId"</TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/Yes.gif" BORDER="0"></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></TD>
    <TD ALIGN="middle"><P CLASS="Base2">ASC</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2"><A HREF="#IND_FK_TechProcess003_DrawingId">FK_TechProcess003_DrawingId</A></TD>
    <TD><P CLASS="Base2">"DrawingId"</TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/Yes.gif" BORDER="0"></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></TD>
    <TD ALIGN="middle"><P CLASS="Base2">ASC</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2"><A HREF="#IND_FK_TechProcess003_ParentId">FK_TechProcess003_ParentId</A></TD>
    <TD><P CLASS="Base2">"ParentId"</TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/Yes.gif" BORDER="0"></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></TD>
    <TD ALIGN="middle"><P CLASS="Base2">ASC</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2"><A HREF="#IND_FK_TechProcess003_RevisionId">FK_TechProcess003_RevisionId</A></TD>
    <TD><P CLASS="Base2">"RevisionId"</TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/Yes.gif" BORDER="0"></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></TD>
    <TD ALIGN="middle"><P CLASS="Base2">ASC</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2"><A HREF="#IND_FK_TechProcess003_TypeId">FK_TechProcess003_TypeId</A></TD>
    <TD><P CLASS="Base2">"TypeId"</TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/Yes.gif" BORDER="0"></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></TD>
    <TD ALIGN="middle"><P CLASS="Base2">ASC</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2"><A HREF="#IND_FK_TechProcess003_UserId">FK_TechProcess003_UserId</A></TD>
    <TD><P CLASS="Base2">"UserId"</TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/Yes.gif" BORDER="0"></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></TD>
    <TD ALIGN="middle"><P CLASS="Base2">ASC</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2"><A HREF="#IND_PK_TechProcess003Id">PK_TechProcess003Id</A></TD>
    <TD><P CLASS="Base2">"Id"</TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/Yes.gif" BORDER="0"></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/Yes.gif" BORDER="0"></TD>
    <TD ALIGN="middle"><P CLASS="Base2">ASC</TD>
  </TR>
</TABLE>
<P CLASS="Base">&nbsp;</P>
<P CLASS="Header1">References</P>
<TABLE CLASS="dtArg" CELLSPACING="0">
  <TH><P CLASS="Base2"><B>Table</B></P>
  <TH><P CLASS="Base2"><B>Foreign Key</B></P>
  <TH><P CLASS="Base2"><B>Fields</B></P>
  <TH><P CLASS="Base2"><B>FK Field</B></P>
  <TH><P CLASS="Base2"><B>Delete Rule</B></P>
  <TH><P CLASS="Base2"><B>Update Rule</B></P>
  <TR>
    <TD><P CLASS="Base2"><A HREF="#TBL_Drawing">Drawing</A></TD>
    <TD><P CLASS="Base2"><A HREF="#FKEY_FK_TechProcess003_CopyDrawingId">FK_TechProcess003_CopyDrawingId</A></TD>
    <TD><P CLASS="Base2">CopyDrawingId</TD>
    <TD><P CLASS="Base2">Id</TD>
    <TD><P CLASS="Base2">SET NULL</TD>
    <TD><P CLASS="Base2">NO ACTION</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2"><A HREF="#TBL_Drawing">Drawing</A></TD>
    <TD><P CLASS="Base2"><A HREF="#FKEY_FK_TechProcess003_DrawingId">FK_TechProcess003_DrawingId</A></TD>
    <TD><P CLASS="Base2">DrawingId</TD>
    <TD><P CLASS="Base2">Id</TD>
    <TD><P CLASS="Base2">SET NULL</TD>
    <TD><P CLASS="Base2">NO ACTION</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2"><A HREF="#TBL_TechProcess003">TechProcess003</A></TD>
    <TD><P CLASS="Base2"><A HREF="#FKEY_FK_TechProcess003_ParentId">FK_TechProcess003_ParentId</A></TD>
    <TD><P CLASS="Base2">ParentId</TD>
    <TD><P CLASS="Base2">Id</TD>
    <TD><P CLASS="Base2">SET NULL</TD>
    <TD><P CLASS="Base2">NO ACTION</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2"><A HREF="#TBL_Revisions">Revisions</A></TD>
    <TD><P CLASS="Base2"><A HREF="#FKEY_FK_TechProcess003_RevisionId">FK_TechProcess003_RevisionId</A></TD>
    <TD><P CLASS="Base2">RevisionId</TD>
    <TD><P CLASS="Base2">Id</TD>
    <TD><P CLASS="Base2">NO ACTION</TD>
    <TD><P CLASS="Base2">NO ACTION</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2"><A HREF="#TBL_RevisionType">RevisionType</A></TD>
    <TD><P CLASS="Base2"><A HREF="#FKEY_FK_TechProcess003_TypeId">FK_TechProcess003_TypeId</A></TD>
    <TD><P CLASS="Base2">TypeId</TD>
    <TD><P CLASS="Base2">Id</TD>
    <TD><P CLASS="Base2">NO ACTION</TD>
    <TD><P CLASS="Base2">NO ACTION</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2"><A HREF="#TBL_Users">Users</A></TD>
    <TD><P CLASS="Base2"><A HREF="#FKEY_FK_TechProcess003_UserId">FK_TechProcess003_UserId</A></TD>
    <TD><P CLASS="Base2">UserId</TD>
    <TD><P CLASS="Base2">Id</TD>
    <TD><P CLASS="Base2">NO ACTION</TD>
    <TD><P CLASS="Base2">NO ACTION</TD>
  </TR>
</TABLE>
<P CLASS="Base">&nbsp;</P>
<P CLASS="Header1">Referenced By</P>
<TABLE CLASS="dtArg" CELLSPACING="0">
  <TH><P CLASS="Base2"><B>Table</B></P>
  <TH><P CLASS="Base2"><B>Foreign Key</B></P>
  <TH><P CLASS="Base2"><B>Fields</B></P>
  <TH><P CLASS="Base2"><B>FK Field</B></P>
  <TH><P CLASS="Base2"><B>Delete Rule</B></P>
  <TH><P CLASS="Base2"><B>Update Rule</B></P>
  <TR>
    <TD><P CLASS="Base2"><A HREF="#TBL_TechProcess003">TechProcess003</A></TD>
    <TD><P CLASS="Base2"><A HREF="#FKEY_FK_TechProcess003_ParentId">FK_TechProcess003_ParentId</A></TD>
    <TD><P CLASS="Base2">ParentId</TD>
    <TD><P CLASS="Base2">Id</TD>
    <TD><P CLASS="Base2">SET NULL</TD>
    <TD><P CLASS="Base2">NO ACTION</TD>
  </TR>
</TABLE>
<P CLASS="Base">&nbsp;</P>
<P CLASS="Header1">Definition</P>
<P CLASS="Base"><span class="DDLCode">
<code><pre>
<b>CREATE</b><b> </b><b>TABLE</b><b> </b><font color="# 080 0"><u>&quot;TechProcess003&quot;</u></font><b> </b><b>(</b>
<b>    </b>&quot;Id&quot;<b>                    </b><b>INTEGER</b><b> </b><b>NOT</b><b> </b><b>NULL</b><b>,</b>
<b>    </b>&quot;TechProcessName&quot;<b>       </b><b>BIGINT</b><b>,</b>
<b>    </b>&quot;TechProcessPath&quot;<b>       </b><b>VARCHAR</b><b>(</b>200<b>)</b><b>,</b>
<b>    </b>&quot;TechProcessFullName&quot;<b>   </b><b>VARCHAR</b><b>(</b>50<b>)</b><b>,</b>
<b>    </b>&quot;RevisionId&quot;<b>            </b><b>SMALLINT</b><b>,</b>
<b>    </b>&quot;DrawingId&quot;<b>             </b><b>SMALLINT</b><b>,</b>
<b>    </b>&quot;CopyDrawingId&quot;<b>         </b><b>SMALLINT</b><b>,</b>
<b>    </b>&quot;ParentId&quot;<b>              </b><b>SMALLINT</b><b>,</b>
<b>    </b>&quot;CreateDate&quot;<b>            </b><b>DATE</b><b> </b><b>DEFAULT</b><b> </b><b>CURRENT_DATE</b><b>,</b>
<b>    </b>&quot;TypeId&quot;<b>                </b><b>SMALLINT</b><b> </b><b>DEFAULT</b><b> </b>1<b>,</b>
<b>    </b>&quot;OldTechProcess&quot;<b>        </b><b>SMALLINT</b><b> </b><b>DEFAULT</b><b> </b>0<b>,</b>
<b>    </b>TH<b>                      </b><b>VARCHAR</b><b>(</b>10<b>)</b><b> </b><b>CHARACTER</b><b> </b><b>SET</b><b> </b>WIN1251<b> </b><b>DEFAULT</b><b> </b>0<b>,</b>
<b>    </b>W<b>                       </b><b>VARCHAR</b><b>(</b>10<b>)</b><b> </b><b>CHARACTER</b><b> </b><b>SET</b><b> </b>WIN1251<b> </b><b>DEFAULT</b><b> </b>0<b>,</b>
<b>    </b>W2<b>                      </b><b>VARCHAR</b><b>(</b>10<b>)</b><b> </b><b>CHARACTER</b><b> </b><b>SET</b><b> </b>WIN1251<b> </b><b>DEFAULT</b><b> </b>0<b>,</b>
<b>    </b>L<b>                       </b><b>VARCHAR</b><b>(</b>10<b>)</b><b> </b><b>CHARACTER</b><b> </b><b>SET</b><b> </b>WIN1251<b> </b><b>DEFAULT</b><b> </b>0<b>,</b>
<b>    </b>&quot;Weight&quot;<b>                </b><b>NUMERIC</b><b>(</b>10<b>,</b>2<b>)</b><b> </b><b>DEFAULT</b><b> </b>0<b>,</b>
<b>    </b>&quot;UserId&quot;<b>                </b><b>SMALLINT</b><b>,</b>
<b>    </b>&quot;RevisionDocumentName&quot;<b>  </b><b>VARCHAR</b><b>(</b>20<b>)</b><b>,</b>
<b>    </b>&quot;Welding20Steel&quot;<b>        </b><b>NUMERIC</b><b>(</b>6<b>,</b>2<b>)</b><b> </b><b>DEFAULT</b><b> </b>0<b>,</b>
<b>    </b>&quot;Welding10&quot;<b>             </b><b>NUMERIC</b><b>(</b>6<b>,</b>2<b>)</b><b> </b><b>DEFAULT</b><b> </b>0<b>,</b>
<b>    </b>&quot;Welding12&quot;<b>             </b><b>NUMERIC</b><b>(</b>6<b>,</b>2<b>)</b><b> </b><b>DEFAULT</b><b> </b>0<b>,</b>
<b>    </b>&quot;Welding16&quot;<b>             </b><b>NUMERIC</b><b>(</b>6<b>,</b>2<b>)</b><b> </b><b>DEFAULT</b><b> </b>0<b>,</b>
<b>    </b>&quot;Welding20&quot;<b>             </b><b>NUMERIC</b><b>(</b>6<b>,</b>2<b>)</b><b> </b><b>DEFAULT</b><b> </b>0<b>,</b>
<b>    </b>&quot;GasArCO2&quot;<b>              </b><b>NUMERIC</b><b>(</b>6<b>,</b>2<b>)</b><b> </b><b>DEFAULT</b><b> </b>0<b>,</b>
<b>    </b>&quot;GasCO3&quot;<b>                </b><b>NUMERIC</b><b>(</b>6<b>,</b>2<b>)</b><b> </b><b>DEFAULT</b><b> </b>0<b>,</b>
<b>    </b>&quot;GasAr&quot;<b>                 </b><b>NUMERIC</b><b>(</b>6<b>,</b>2<b>)</b><b> </b><b>DEFAULT</b><b> </b>0<b>,</b>
<b>    </b>&quot;WeldingElektrod&quot;<b>       </b><b>NUMERIC</b><b>(</b>6<b>,</b>2<b>)</b><b> </b><b>DEFAULT</b><b> </b>0<b>,</b>
<b>    </b>&quot;GasO2&quot;<b>                 </b><b>NUMERIC</b><b>(</b>6<b>,</b>2<b>)</b><b> </b><b>DEFAULT</b><b> </b>0<b>,</b>
<b>    </b>&quot;GasNature&quot;<b>             </b><b>NUMERIC</b><b>(</b>6<b>,</b>2<b>)</b><b> </b><b>DEFAULT</b><b> </b>0<b>,</b>
<b>    </b>&quot;GasN2&quot;<b>                 </b><b>NUMERIC</b><b>(</b>6<b>,</b>2<b>)</b><b> </b><b>DEFAULT</b><b> </b>0<b>,</b>
<b>    </b>&quot;HardKapci881&quot;<b>          </b><b>NUMERIC</b><b>(</b>6<b>,</b>2<b>)</b><b> </b><b>DEFAULT</b><b> </b>0<b>,</b>
<b>    </b>&quot;HardKapciHs6055&quot;<b>       </b><b>NUMERIC</b><b>(</b>6<b>,</b>2<b>)</b><b> </b><b>DEFAULT</b><b> </b>0<b>,</b>
<b>    </b>&quot;HardKapci126&quot;<b>          </b><b>NUMERIC</b><b>(</b>6<b>,</b>2<b>)</b><b> </b><b>DEFAULT</b><b> </b>0<b>,</b>
<b>    </b>&quot;HardKapciPEPutty&quot;<b>      </b><b>NUMERIC</b><b>(</b>6<b>,</b>2<b>)</b><b> </b><b>DEFAULT</b><b> </b>0<b>,</b>
<b>    </b>&quot;HardKapci2KMS651&quot;<b>      </b><b>NUMERIC</b><b>(</b>6<b>,</b>2<b>)</b><b> </b><b>DEFAULT</b><b> </b>0<b>,</b>
<b>    </b>&quot;DilKapci881&quot;<b>           </b><b>NUMERIC</b><b>(</b>6<b>,</b>2<b>)</b><b> </b><b>DEFAULT</b><b> </b>0<b>,</b>
<b>    </b>&quot;DilKapci2K&quot;<b>            </b><b>NUMERIC</b><b>(</b>6<b>,</b>2<b>)</b><b> </b><b>DEFAULT</b><b> </b>0<b>,</b>
<b>    </b>&quot;DilKapci880&quot;<b>           </b><b>NUMERIC</b><b>(</b>6<b>,</b>2<b>)</b><b> </b><b>DEFAULT</b><b> </b>0<b>,</b>
<b>    </b>&quot;PrimerKapci125&quot;<b>        </b><b>NUMERIC</b><b>(</b>6<b>,</b>2<b>)</b><b> </b><b>DEFAULT</b><b> </b>0<b>,</b>
<b>    </b>&quot;PrimerKapci633&quot;<b>        </b><b>NUMERIC</b><b>(</b>6<b>,</b>2<b>)</b><b> </b><b>DEFAULT</b><b> </b>0<b>,</b>
<b>    </b>&quot;EnamelKapci641&quot;<b>        </b><b>NUMERIC</b><b>(</b>6<b>,</b>2<b>)</b><b> </b><b>DEFAULT</b><b> </b>0<b>,</b>
<b>    </b>&quot;EnamelKapci670&quot;<b>        </b><b>NUMERIC</b><b>(</b>6<b>,</b>2<b>)</b><b> </b><b>DEFAULT</b><b> </b>0<b>,</b>
<b>    </b>&quot;EnamelKapci6030&quot;<b>       </b><b>NUMERIC</b><b>(</b>6<b>,</b>2<b>)</b><b> </b><b>DEFAULT</b><b> </b>0<b>,</b>
<b>    </b>&quot;UniversalSikaflex527&quot;<b>  </b><b>NUMERIC</b><b>(</b>6<b>,</b>2<b>)</b><b> </b><b>DEFAULT</b><b> </b>0<b>,</b>
<b>    </b>&quot;PuttyKapci350&quot;<b>         </b><b>NUMERIC</b><b>(</b>6<b>,</b>2<b>)</b><b> </b><b>DEFAULT</b><b> </b>0<b>,</b>
<b>    </b>&quot;LaborIntensity001&quot;<b>     </b><b>NUMERIC</b><b>(</b>6<b>,</b>2<b>)</b><b> </b><b>DEFAULT</b><b> </b>0<b>,</b>
<b>    </b>&quot;LaborIntensity002&quot;<b>     </b><b>NUMERIC</b><b>(</b>6<b>,</b>2<b>)</b><b> </b><b>DEFAULT</b><b> </b>0<b>,</b>
<b>    </b>&quot;LaborIntensity003&quot;<b>     </b><b>NUMERIC</b><b>(</b>6<b>,</b>2<b>)</b><b> </b><b>DEFAULT</b><b> </b>0<b>,</b>
<b>    </b>&quot;LaborIntensity004&quot;<b>     </b><b>NUMERIC</b><b>(</b>6<b>,</b>2<b>)</b><b> </b><b>DEFAULT</b><b> </b>0<b>,</b>
<b>    </b>&quot;LaborIntensity005&quot;<b>     </b><b>NUMERIC</b><b>(</b>6<b>,</b>2<b>)</b><b> </b><b>DEFAULT</b><b> </b>0
<b>)</b><b>;</b>


<b>ALTER</b><b> </b><b>TABLE</b><b> </b><font color="# 080 0"><u>&quot;TechProcess003&quot;</u></font><b> </b><b>ADD</b><b> </b><b>CONSTRAINT</b><b> </b>&quot;PK_TechProcess003Id&quot;<b> </b><b>PRIMARY</b><b> </b><b>KEY</b><b> </b><b>(</b>&quot;Id&quot;<b>)</b><b>;</b>
<b>ALTER</b><b> </b><b>TABLE</b><b> </b><font color="# 080 0"><u>&quot;TechProcess003&quot;</u></font><b> </b><b>ADD</b><b> </b><b>CONSTRAINT</b><b> </b>&quot;FK_TechProcess003_CopyDrawingId&quot;<b> </b><b>FOREIGN</b><b> </b><b>KEY</b><b> </b><b>(</b>&quot;CopyDrawingId&quot;<b>)</b><b> </b><b>REFERENCES</b><b> </b><font color="# 080 0"><u>&quot;Drawing&quot;</u></font><b> </b><b>(</b>&quot;Id&quot;<b>)</b><b> </b><b>ON</b><b> </b><b>DELETE</b><b> </b><b>SET</b><b> </b><b>NULL</b><b>;</b>
<b>ALTER</b><b> </b><b>TABLE</b><b> </b><font color="# 080 0"><u>&quot;TechProcess003&quot;</u></font><b> </b><b>ADD</b><b> </b><b>CONSTRAINT</b><b> </b>&quot;FK_TechProcess003_DrawingId&quot;<b> </b><b>FOREIGN</b><b> </b><b>KEY</b><b> </b><b>(</b>&quot;DrawingId&quot;<b>)</b><b> </b><b>REFERENCES</b><b> </b><font color="# 080 0"><u>&quot;Drawing&quot;</u></font><b> </b><b>(</b>&quot;Id&quot;<b>)</b><b> </b><b>ON</b><b> </b><b>DELETE</b><b> </b><b>SET</b><b> </b><b>NULL</b><b>;</b>
<b>ALTER</b><b> </b><b>TABLE</b><b> </b><font color="# 080 0"><u>&quot;TechProcess003&quot;</u></font><b> </b><b>ADD</b><b> </b><b>CONSTRAINT</b><b> </b>&quot;FK_TechProcess003_ParentId&quot;<b> </b><b>FOREIGN</b><b> </b><b>KEY</b><b> </b><b>(</b>&quot;ParentId&quot;<b>)</b><b> </b><b>REFERENCES</b><b> </b><font color="# 080 0"><u>&quot;TechProcess003&quot;</u></font><b> </b><b>(</b>&quot;Id&quot;<b>)</b><b> </b><b>ON</b><b> </b><b>DELETE</b><b> </b><b>SET</b><b> </b><b>NULL</b><b>;</b>
<b>ALTER</b><b> </b><b>TABLE</b><b> </b><font color="# 080 0"><u>&quot;TechProcess003&quot;</u></font><b> </b><b>ADD</b><b> </b><b>CONSTRAINT</b><b> </b>&quot;FK_TechProcess003_RevisionId&quot;<b> </b><b>FOREIGN</b><b> </b><b>KEY</b><b> </b><b>(</b>&quot;RevisionId&quot;<b>)</b><b> </b><b>REFERENCES</b><b> </b><font color="# 080 0"><u>&quot;Revisions&quot;</u></font><b> </b><b>(</b>&quot;Id&quot;<b>)</b><b>;</b>
<b>ALTER</b><b> </b><b>TABLE</b><b> </b><font color="# 080 0"><u>&quot;TechProcess003&quot;</u></font><b> </b><b>ADD</b><b> </b><b>CONSTRAINT</b><b> </b>&quot;FK_TechProcess003_TypeId&quot;<b> </b><b>FOREIGN</b><b> </b><b>KEY</b><b> </b><b>(</b>&quot;TypeId&quot;<b>)</b><b> </b><b>REFERENCES</b><b> </b><font color="# 080 0"><u>&quot;RevisionType&quot;</u></font><b> </b><b>(</b>&quot;Id&quot;<b>)</b><b>;</b>
<b>ALTER</b><b> </b><b>TABLE</b><b> </b><font color="# 080 0"><u>&quot;TechProcess003&quot;</u></font><b> </b><b>ADD</b><b> </b><b>CONSTRAINT</b><b> </b>&quot;FK_TechProcess003_UserId&quot;<b> </b><b>FOREIGN</b><b> </b><b>KEY</b><b> </b><b>(</b>&quot;UserId&quot;<b>)</b><b> </b><b>REFERENCES</b><b> </b><font color="# 080 0"><u>&quot;Users&quot;</u></font><b> </b><b>(</b>&quot;Id&quot;<b>)</b><b>;</b>

</pre></code>
</span></P>
<P CLASS="Base">&nbsp;</P>

<HR>
<A NAME="TBL_TechProcess004"><P CLASS="Header0">Table: TechProcess004</P><P CLASS="Base">&nbsp;</P>
<P CLASS="Header1">Description</P>
<P CLASS="Base"><I>(There is no description for table TechProcess004)</I></P>
<P CLASS="Base">&nbsp;</P>
<P CLASS="Header1">Fields</P>
<TABLE CLASS="dtArg" CELLSPACING="0">
  <TH WIDTH="1%" ALIGN="middle"><P CLASS="Base2"><B>PK</B></P>
  <TH WIDTH="1%" ALIGN="middle"><P CLASS="Base2"><B>FK</B></P>
  <TH WIDTH="1%"><P CLASS="Base2"><B>Field</B></P>
  <TH WIDTH="1%"><P CLASS="Base2"><B>Domain</B></P>
  <TH WIDTH="20%"><P CLASS="Base2"><B>Type</B></P>
  <TH WIDTH="1%" ALIGN="middle"><P CLASS="Base2"><B>NN</B></P>
  <TH WIDTH="1%"><P CLASS="Base2"><B>Default</B></P>
  <TH WIDTH="40%"><P CLASS="Base2"><B>Description</B></P>
  <TR>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/PK1.gif" BORDER="0"></P></TD>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD><A NAME="TechProcess004.Id"><P CLASS="Base2">Id</P></A></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">INTEGER</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/Yes.gif" BORDER="0"></P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
  </TR>
  <TR>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD><A NAME="TechProcess004.TechProcessName"><P CLASS="Base2">TechProcessName</P></A></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">BIGINT</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
  </TR>
  <TR>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD><A NAME="TechProcess004.TechProcessPath"><P CLASS="Base2">TechProcessPath</P></A></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">VARCHAR(200)</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
  </TR>
  <TR>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD><A NAME="TechProcess004.TechProcessFullName"><P CLASS="Base2">TechProcessFullName</P></A></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">VARCHAR(50)</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
  </TR>
  <TR>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/FK.gif" BORDER="0"></P></TD>
    <TD><A NAME="TechProcess004.RevisionId"><P CLASS="Base2">RevisionId</P></A></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">SMALLINT</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
  </TR>
  <TR>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/FK.gif" BORDER="0"></P></TD>
    <TD><A NAME="TechProcess004.DrawingId"><P CLASS="Base2">DrawingId</P></A></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">SMALLINT</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
  </TR>
  <TR>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/FK.gif" BORDER="0"></P></TD>
    <TD><A NAME="TechProcess004.CopyDrawingId"><P CLASS="Base2">CopyDrawingId</P></A></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">SMALLINT</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
  </TR>
  <TR>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/FK.gif" BORDER="0"></P></TD>
    <TD><A NAME="TechProcess004.ParentId"><P CLASS="Base2">ParentId</P></A></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">SMALLINT</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
  </TR>
  <TR>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD><A NAME="TechProcess004.CreateDate"><P CLASS="Base2">CreateDate</P></A></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">DATE</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></P></TD>
    <TD><P CLASS="Base2">CURRENT_DATE</P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
  </TR>
  <TR>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/FK.gif" BORDER="0"></P></TD>
    <TD><A NAME="TechProcess004.TypeId"><P CLASS="Base2">TypeId</P></A></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">SMALLINT</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></P></TD>
    <TD><P CLASS="Base2">1</P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
  </TR>
  <TR>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD><A NAME="TechProcess004.OldTechProcess"><P CLASS="Base2">OldTechProcess</P></A></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">SMALLINT</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></P></TD>
    <TD><P CLASS="Base2">0</P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
  </TR>
  <TR>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD><A NAME="TechProcess004.TH"><P CLASS="Base2">TH</P></A></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">VARCHAR(10)</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></P></TD>
    <TD><P CLASS="Base2">0</P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
  </TR>
  <TR>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD><A NAME="TechProcess004.W"><P CLASS="Base2">W</P></A></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">VARCHAR(10)</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></P></TD>
    <TD><P CLASS="Base2">0</P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
  </TR>
  <TR>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD><A NAME="TechProcess004.W2"><P CLASS="Base2">W2</P></A></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">VARCHAR(10)</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></P></TD>
    <TD><P CLASS="Base2">0</P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
  </TR>
  <TR>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD><A NAME="TechProcess004.L"><P CLASS="Base2">L</P></A></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">VARCHAR(10)</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></P></TD>
    <TD><P CLASS="Base2">0</P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
  </TR>
  <TR>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD><A NAME="TechProcess004.Weight"><P CLASS="Base2">Weight</P></A></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">NUMERIC(10,2)</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></P></TD>
    <TD><P CLASS="Base2">0</P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
  </TR>
  <TR>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/FK.gif" BORDER="0"></P></TD>
    <TD><A NAME="TechProcess004.UserId"><P CLASS="Base2">UserId</P></A></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">SMALLINT</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
  </TR>
  <TR>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD><A NAME="TechProcess004.RevisionDocumentName"><P CLASS="Base2">RevisionDocumentName</P></A></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">VARCHAR(20)</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
  </TR>
  <TR>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD><A NAME="TechProcess004.Welding20Steel"><P CLASS="Base2">Welding20Steel</P></A></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">NUMERIC(6,2)</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></P></TD>
    <TD><P CLASS="Base2">0</P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
  </TR>
  <TR>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD><A NAME="TechProcess004.Welding10"><P CLASS="Base2">Welding10</P></A></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">NUMERIC(6,2)</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></P></TD>
    <TD><P CLASS="Base2">0</P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
  </TR>
  <TR>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD><A NAME="TechProcess004.Welding12"><P CLASS="Base2">Welding12</P></A></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">NUMERIC(6,2)</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></P></TD>
    <TD><P CLASS="Base2">0</P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
  </TR>
  <TR>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD><A NAME="TechProcess004.Welding16"><P CLASS="Base2">Welding16</P></A></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">NUMERIC(6,2)</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></P></TD>
    <TD><P CLASS="Base2">0</P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
  </TR>
  <TR>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD><A NAME="TechProcess004.Welding20"><P CLASS="Base2">Welding20</P></A></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">NUMERIC(6,2)</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></P></TD>
    <TD><P CLASS="Base2">0</P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
  </TR>
  <TR>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD><A NAME="TechProcess004.GasArCO2"><P CLASS="Base2">GasArCO2</P></A></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">NUMERIC(6,2)</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></P></TD>
    <TD><P CLASS="Base2">0</P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
  </TR>
  <TR>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD><A NAME="TechProcess004.GasCO3"><P CLASS="Base2">GasCO3</P></A></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">NUMERIC(6,2)</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></P></TD>
    <TD><P CLASS="Base2">0</P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
  </TR>
  <TR>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD><A NAME="TechProcess004.GasAr"><P CLASS="Base2">GasAr</P></A></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">NUMERIC(6,2)</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></P></TD>
    <TD><P CLASS="Base2">0</P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
  </TR>
  <TR>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD><A NAME="TechProcess004.WeldingElektrod"><P CLASS="Base2">WeldingElektrod</P></A></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">NUMERIC(6,2)</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></P></TD>
    <TD><P CLASS="Base2">0</P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
  </TR>
  <TR>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD><A NAME="TechProcess004.GasO2"><P CLASS="Base2">GasO2</P></A></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">NUMERIC(6,2)</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></P></TD>
    <TD><P CLASS="Base2">0</P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
  </TR>
  <TR>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD><A NAME="TechProcess004.GasNature"><P CLASS="Base2">GasNature</P></A></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">NUMERIC(6,2)</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></P></TD>
    <TD><P CLASS="Base2">0</P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
  </TR>
  <TR>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD><A NAME="TechProcess004.GasN2"><P CLASS="Base2">GasN2</P></A></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">NUMERIC(6,2)</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></P></TD>
    <TD><P CLASS="Base2">0</P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
  </TR>
  <TR>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD><A NAME="TechProcess004.HardKapci881"><P CLASS="Base2">HardKapci881</P></A></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">NUMERIC(6,2)</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></P></TD>
    <TD><P CLASS="Base2">0</P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
  </TR>
  <TR>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD><A NAME="TechProcess004.HardKapciHs6055"><P CLASS="Base2">HardKapciHs6055</P></A></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">NUMERIC(6,2)</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></P></TD>
    <TD><P CLASS="Base2">0</P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
  </TR>
  <TR>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD><A NAME="TechProcess004.HardKapci126"><P CLASS="Base2">HardKapci126</P></A></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">NUMERIC(6,2)</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></P></TD>
    <TD><P CLASS="Base2">0</P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
  </TR>
  <TR>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD><A NAME="TechProcess004.HardKapciPEPutty"><P CLASS="Base2">HardKapciPEPutty</P></A></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">NUMERIC(6,2)</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></P></TD>
    <TD><P CLASS="Base2">0</P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
  </TR>
  <TR>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD><A NAME="TechProcess004.HardKapci2KMS651"><P CLASS="Base2">HardKapci2KMS651</P></A></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">NUMERIC(6,2)</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></P></TD>
    <TD><P CLASS="Base2">0</P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
  </TR>
  <TR>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD><A NAME="TechProcess004.DilKapci881"><P CLASS="Base2">DilKapci881</P></A></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">NUMERIC(6,2)</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></P></TD>
    <TD><P CLASS="Base2">0</P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
  </TR>
  <TR>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD><A NAME="TechProcess004.DilKapci2K"><P CLASS="Base2">DilKapci2K</P></A></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">NUMERIC(6,2)</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></P></TD>
    <TD><P CLASS="Base2">0</P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
  </TR>
  <TR>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD><A NAME="TechProcess004.DilKapci880"><P CLASS="Base2">DilKapci880</P></A></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">NUMERIC(6,2)</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></P></TD>
    <TD><P CLASS="Base2">0</P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
  </TR>
  <TR>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD><A NAME="TechProcess004.PrimerKapci125"><P CLASS="Base2">PrimerKapci125</P></A></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">NUMERIC(6,2)</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></P></TD>
    <TD><P CLASS="Base2">0</P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
  </TR>
  <TR>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD><A NAME="TechProcess004.PrimerKapci633"><P CLASS="Base2">PrimerKapci633</P></A></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">NUMERIC(6,2)</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></P></TD>
    <TD><P CLASS="Base2">0</P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
  </TR>
  <TR>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD><A NAME="TechProcess004.EnamelKapci641"><P CLASS="Base2">EnamelKapci641</P></A></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">NUMERIC(6,2)</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></P></TD>
    <TD><P CLASS="Base2">0</P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
  </TR>
  <TR>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD><A NAME="TechProcess004.EnamelKapci670"><P CLASS="Base2">EnamelKapci670</P></A></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">NUMERIC(6,2)</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></P></TD>
    <TD><P CLASS="Base2">0</P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
  </TR>
  <TR>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD><A NAME="TechProcess004.EnamelKapci6030"><P CLASS="Base2">EnamelKapci6030</P></A></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">NUMERIC(6,2)</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></P></TD>
    <TD><P CLASS="Base2">0</P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
  </TR>
  <TR>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD><A NAME="TechProcess004.UniversalSikaflex527"><P CLASS="Base2">UniversalSikaflex527</P></A></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">NUMERIC(6,2)</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></P></TD>
    <TD><P CLASS="Base2">0</P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
  </TR>
  <TR>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD><A NAME="TechProcess004.PuttyKapci350"><P CLASS="Base2">PuttyKapci350</P></A></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">NUMERIC(6,2)</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></P></TD>
    <TD><P CLASS="Base2">0</P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
  </TR>
  <TR>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD><A NAME="TechProcess004.LaborIntensity001"><P CLASS="Base2">LaborIntensity001</P></A></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">NUMERIC(6,2)</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></P></TD>
    <TD><P CLASS="Base2">0</P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
  </TR>
  <TR>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD><A NAME="TechProcess004.LaborIntensity002"><P CLASS="Base2">LaborIntensity002</P></A></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">NUMERIC(6,2)</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></P></TD>
    <TD><P CLASS="Base2">0</P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
  </TR>
  <TR>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD><A NAME="TechProcess004.LaborIntensity003"><P CLASS="Base2">LaborIntensity003</P></A></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">NUMERIC(6,2)</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></P></TD>
    <TD><P CLASS="Base2">0</P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
  </TR>
  <TR>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD><A NAME="TechProcess004.LaborIntensity004"><P CLASS="Base2">LaborIntensity004</P></A></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">NUMERIC(6,2)</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></P></TD>
    <TD><P CLASS="Base2">0</P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
  </TR>
  <TR>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD><A NAME="TechProcess004.LaborIntensity005"><P CLASS="Base2">LaborIntensity005</P></A></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">NUMERIC(6,2)</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></P></TD>
    <TD><P CLASS="Base2">0</P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
  </TR>
</TABLE>
<P CLASS="Base">&nbsp;</P>
<P CLASS="Header1">Triggers</P>
<TABLE CLASS="dtArg" CELLSPACING="0">
  <TH WIDTH="1%"><P CLASS="Base2"><B>Trigger</B></P>
  <TH WIDTH="1%"><P CLASS="Base2"><B>Type</B></P>
  <TH WIDTH="1%"><P CLASS="Base2"><B>Activity</B></P>
  <TH WIDTH="1%"><P CLASS="Base2"><B>Order</B></P>
  <TH WIDTH="50%"><P CLASS="Base2"><B>Description</B></P>
  <TR>
    <TD><P CLASS="Base2"><A HREF="#TRG_Tr_TechProcess004">Tr_TechProcess004</A></TD>
    <TD><P CLASS="Base2">BEFORE&nbsp;INSERT</TD>
    <TD><P CLASS="Base2">Yes</TD>
    <TD ALIGN="right"><P CLASS="Base2">0</TD>
    <TD><P CLASS="Base2">&nbsp</TD>
  </TR>
</TABLE>
<P CLASS="Base">&nbsp;</P>
<P CLASS="Header1">Indices</P>
<TABLE CLASS="dtArg" CELLSPACING="0">
  <TH><P CLASS="Base2"><B>Index</B></P>
  <TH><P CLASS="Base2"><B>Fields</B></P>
  <TH ALIGN="middle"><P CLASS="Base2"><B>Active</B></P>
  <TH ALIGN="middle"><P CLASS="Base2"><B>Unique</B></P>
  <TH ALIGN="middle"><P CLASS="Base2"><B>Order</B></P>
  <TR>
    <TD><P CLASS="Base2"><A HREF="#IND_FK_TechProcess004_CopyDrawingId">FK_TechProcess004_CopyDrawingId</A></TD>
    <TD><P CLASS="Base2">"CopyDrawingId"</TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/Yes.gif" BORDER="0"></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></TD>
    <TD ALIGN="middle"><P CLASS="Base2">ASC</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2"><A HREF="#IND_FK_TechProcess004_DrawingId">FK_TechProcess004_DrawingId</A></TD>
    <TD><P CLASS="Base2">"DrawingId"</TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/Yes.gif" BORDER="0"></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></TD>
    <TD ALIGN="middle"><P CLASS="Base2">ASC</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2"><A HREF="#IND_FK_TechProcess004_ParentId">FK_TechProcess004_ParentId</A></TD>
    <TD><P CLASS="Base2">"ParentId"</TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/Yes.gif" BORDER="0"></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></TD>
    <TD ALIGN="middle"><P CLASS="Base2">ASC</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2"><A HREF="#IND_FK_TechProcess004_RevisionId">FK_TechProcess004_RevisionId</A></TD>
    <TD><P CLASS="Base2">"RevisionId"</TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/Yes.gif" BORDER="0"></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></TD>
    <TD ALIGN="middle"><P CLASS="Base2">ASC</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2"><A HREF="#IND_FK_TechProcess004_TypeId">FK_TechProcess004_TypeId</A></TD>
    <TD><P CLASS="Base2">"TypeId"</TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/Yes.gif" BORDER="0"></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></TD>
    <TD ALIGN="middle"><P CLASS="Base2">ASC</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2"><A HREF="#IND_FK_TechProcess004_UserId">FK_TechProcess004_UserId</A></TD>
    <TD><P CLASS="Base2">"UserId"</TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/Yes.gif" BORDER="0"></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></TD>
    <TD ALIGN="middle"><P CLASS="Base2">ASC</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2"><A HREF="#IND_PK_TechProcess004Id">PK_TechProcess004Id</A></TD>
    <TD><P CLASS="Base2">"Id"</TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/Yes.gif" BORDER="0"></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/Yes.gif" BORDER="0"></TD>
    <TD ALIGN="middle"><P CLASS="Base2">ASC</TD>
  </TR>
</TABLE>
<P CLASS="Base">&nbsp;</P>
<P CLASS="Header1">References</P>
<TABLE CLASS="dtArg" CELLSPACING="0">
  <TH><P CLASS="Base2"><B>Table</B></P>
  <TH><P CLASS="Base2"><B>Foreign Key</B></P>
  <TH><P CLASS="Base2"><B>Fields</B></P>
  <TH><P CLASS="Base2"><B>FK Field</B></P>
  <TH><P CLASS="Base2"><B>Delete Rule</B></P>
  <TH><P CLASS="Base2"><B>Update Rule</B></P>
  <TR>
    <TD><P CLASS="Base2"><A HREF="#TBL_Drawing">Drawing</A></TD>
    <TD><P CLASS="Base2"><A HREF="#FKEY_FK_TechProcess004_CopyDrawingId">FK_TechProcess004_CopyDrawingId</A></TD>
    <TD><P CLASS="Base2">CopyDrawingId</TD>
    <TD><P CLASS="Base2">Id</TD>
    <TD><P CLASS="Base2">SET NULL</TD>
    <TD><P CLASS="Base2">NO ACTION</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2"><A HREF="#TBL_Drawing">Drawing</A></TD>
    <TD><P CLASS="Base2"><A HREF="#FKEY_FK_TechProcess004_DrawingId">FK_TechProcess004_DrawingId</A></TD>
    <TD><P CLASS="Base2">DrawingId</TD>
    <TD><P CLASS="Base2">Id</TD>
    <TD><P CLASS="Base2">SET NULL</TD>
    <TD><P CLASS="Base2">NO ACTION</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2"><A HREF="#TBL_TechProcess004">TechProcess004</A></TD>
    <TD><P CLASS="Base2"><A HREF="#FKEY_FK_TechProcess004_ParentId">FK_TechProcess004_ParentId</A></TD>
    <TD><P CLASS="Base2">ParentId</TD>
    <TD><P CLASS="Base2">Id</TD>
    <TD><P CLASS="Base2">SET NULL</TD>
    <TD><P CLASS="Base2">NO ACTION</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2"><A HREF="#TBL_Revisions">Revisions</A></TD>
    <TD><P CLASS="Base2"><A HREF="#FKEY_FK_TechProcess004_RevisionId">FK_TechProcess004_RevisionId</A></TD>
    <TD><P CLASS="Base2">RevisionId</TD>
    <TD><P CLASS="Base2">Id</TD>
    <TD><P CLASS="Base2">NO ACTION</TD>
    <TD><P CLASS="Base2">NO ACTION</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2"><A HREF="#TBL_RevisionType">RevisionType</A></TD>
    <TD><P CLASS="Base2"><A HREF="#FKEY_FK_TechProcess004_TypeId">FK_TechProcess004_TypeId</A></TD>
    <TD><P CLASS="Base2">TypeId</TD>
    <TD><P CLASS="Base2">Id</TD>
    <TD><P CLASS="Base2">NO ACTION</TD>
    <TD><P CLASS="Base2">NO ACTION</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2"><A HREF="#TBL_Users">Users</A></TD>
    <TD><P CLASS="Base2"><A HREF="#FKEY_FK_TechProcess004_UserId">FK_TechProcess004_UserId</A></TD>
    <TD><P CLASS="Base2">UserId</TD>
    <TD><P CLASS="Base2">Id</TD>
    <TD><P CLASS="Base2">NO ACTION</TD>
    <TD><P CLASS="Base2">NO ACTION</TD>
  </TR>
</TABLE>
<P CLASS="Base">&nbsp;</P>
<P CLASS="Header1">Referenced By</P>
<TABLE CLASS="dtArg" CELLSPACING="0">
  <TH><P CLASS="Base2"><B>Table</B></P>
  <TH><P CLASS="Base2"><B>Foreign Key</B></P>
  <TH><P CLASS="Base2"><B>Fields</B></P>
  <TH><P CLASS="Base2"><B>FK Field</B></P>
  <TH><P CLASS="Base2"><B>Delete Rule</B></P>
  <TH><P CLASS="Base2"><B>Update Rule</B></P>
  <TR>
    <TD><P CLASS="Base2"><A HREF="#TBL_TechProcess004">TechProcess004</A></TD>
    <TD><P CLASS="Base2"><A HREF="#FKEY_FK_TechProcess004_ParentId">FK_TechProcess004_ParentId</A></TD>
    <TD><P CLASS="Base2">ParentId</TD>
    <TD><P CLASS="Base2">Id</TD>
    <TD><P CLASS="Base2">SET NULL</TD>
    <TD><P CLASS="Base2">NO ACTION</TD>
  </TR>
</TABLE>
<P CLASS="Base">&nbsp;</P>
<P CLASS="Header1">Definition</P>
<P CLASS="Base"><span class="DDLCode">
<code><pre>
<b>CREATE</b><b> </b><b>TABLE</b><b> </b><font color="# 080 0"><u>&quot;TechProcess004&quot;</u></font><b> </b><b>(</b>
<b>    </b>&quot;Id&quot;<b>                    </b><b>INTEGER</b><b> </b><b>NOT</b><b> </b><b>NULL</b><b>,</b>
<b>    </b>&quot;TechProcessName&quot;<b>       </b><b>BIGINT</b><b>,</b>
<b>    </b>&quot;TechProcessPath&quot;<b>       </b><b>VARCHAR</b><b>(</b>200<b>)</b><b>,</b>
<b>    </b>&quot;TechProcessFullName&quot;<b>   </b><b>VARCHAR</b><b>(</b>50<b>)</b><b>,</b>
<b>    </b>&quot;RevisionId&quot;<b>            </b><b>SMALLINT</b><b>,</b>
<b>    </b>&quot;DrawingId&quot;<b>             </b><b>SMALLINT</b><b>,</b>
<b>    </b>&quot;CopyDrawingId&quot;<b>         </b><b>SMALLINT</b><b>,</b>
<b>    </b>&quot;ParentId&quot;<b>              </b><b>SMALLINT</b><b>,</b>
<b>    </b>&quot;CreateDate&quot;<b>            </b><b>DATE</b><b> </b><b>DEFAULT</b><b> </b><b>CURRENT_DATE</b><b>,</b>
<b>    </b>&quot;TypeId&quot;<b>                </b><b>SMALLINT</b><b> </b><b>DEFAULT</b><b> </b>1<b>,</b>
<b>    </b>&quot;OldTechProcess&quot;<b>        </b><b>SMALLINT</b><b> </b><b>DEFAULT</b><b> </b>0<b>,</b>
<b>    </b>TH<b>                      </b><b>VARCHAR</b><b>(</b>10<b>)</b><b> </b><b>CHARACTER</b><b> </b><b>SET</b><b> </b>WIN1251<b> </b><b>DEFAULT</b><b> </b>0<b>,</b>
<b>    </b>W<b>                       </b><b>VARCHAR</b><b>(</b>10<b>)</b><b> </b><b>CHARACTER</b><b> </b><b>SET</b><b> </b>WIN1251<b> </b><b>DEFAULT</b><b> </b>0<b>,</b>
<b>    </b>W2<b>                      </b><b>VARCHAR</b><b>(</b>10<b>)</b><b> </b><b>CHARACTER</b><b> </b><b>SET</b><b> </b>WIN1251<b> </b><b>DEFAULT</b><b> </b>0<b>,</b>
<b>    </b>L<b>                       </b><b>VARCHAR</b><b>(</b>10<b>)</b><b> </b><b>CHARACTER</b><b> </b><b>SET</b><b> </b>WIN1251<b> </b><b>DEFAULT</b><b> </b>0<b>,</b>
<b>    </b>&quot;Weight&quot;<b>                </b><b>NUMERIC</b><b>(</b>10<b>,</b>2<b>)</b><b> </b><b>DEFAULT</b><b> </b>0<b>,</b>
<b>    </b>&quot;UserId&quot;<b>                </b><b>SMALLINT</b><b>,</b>
<b>    </b>&quot;RevisionDocumentName&quot;<b>  </b><b>VARCHAR</b><b>(</b>20<b>)</b><b>,</b>
<b>    </b>&quot;Welding20Steel&quot;<b>        </b><b>NUMERIC</b><b>(</b>6<b>,</b>2<b>)</b><b> </b><b>DEFAULT</b><b> </b>0<b>,</b>
<b>    </b>&quot;Welding10&quot;<b>             </b><b>NUMERIC</b><b>(</b>6<b>,</b>2<b>)</b><b> </b><b>DEFAULT</b><b> </b>0<b>,</b>
<b>    </b>&quot;Welding12&quot;<b>             </b><b>NUMERIC</b><b>(</b>6<b>,</b>2<b>)</b><b> </b><b>DEFAULT</b><b> </b>0<b>,</b>
<b>    </b>&quot;Welding16&quot;<b>             </b><b>NUMERIC</b><b>(</b>6<b>,</b>2<b>)</b><b> </b><b>DEFAULT</b><b> </b>0<b>,</b>
<b>    </b>&quot;Welding20&quot;<b>             </b><b>NUMERIC</b><b>(</b>6<b>,</b>2<b>)</b><b> </b><b>DEFAULT</b><b> </b>0<b>,</b>
<b>    </b>&quot;GasArCO2&quot;<b>              </b><b>NUMERIC</b><b>(</b>6<b>,</b>2<b>)</b><b> </b><b>DEFAULT</b><b> </b>0<b>,</b>
<b>    </b>&quot;GasCO3&quot;<b>                </b><b>NUMERIC</b><b>(</b>6<b>,</b>2<b>)</b><b> </b><b>DEFAULT</b><b> </b>0<b>,</b>
<b>    </b>&quot;GasAr&quot;<b>                 </b><b>NUMERIC</b><b>(</b>6<b>,</b>2<b>)</b><b> </b><b>DEFAULT</b><b> </b>0<b>,</b>
<b>    </b>&quot;WeldingElektrod&quot;<b>       </b><b>NUMERIC</b><b>(</b>6<b>,</b>2<b>)</b><b> </b><b>DEFAULT</b><b> </b>0<b>,</b>
<b>    </b>&quot;GasO2&quot;<b>                 </b><b>NUMERIC</b><b>(</b>6<b>,</b>2<b>)</b><b> </b><b>DEFAULT</b><b> </b>0<b>,</b>
<b>    </b>&quot;GasNature&quot;<b>             </b><b>NUMERIC</b><b>(</b>6<b>,</b>2<b>)</b><b> </b><b>DEFAULT</b><b> </b>0<b>,</b>
<b>    </b>&quot;GasN2&quot;<b>                 </b><b>NUMERIC</b><b>(</b>6<b>,</b>2<b>)</b><b> </b><b>DEFAULT</b><b> </b>0<b>,</b>
<b>    </b>&quot;HardKapci881&quot;<b>          </b><b>NUMERIC</b><b>(</b>6<b>,</b>2<b>)</b><b> </b><b>DEFAULT</b><b> </b>0<b>,</b>
<b>    </b>&quot;HardKapciHs6055&quot;<b>       </b><b>NUMERIC</b><b>(</b>6<b>,</b>2<b>)</b><b> </b><b>DEFAULT</b><b> </b>0<b>,</b>
<b>    </b>&quot;HardKapci126&quot;<b>          </b><b>NUMERIC</b><b>(</b>6<b>,</b>2<b>)</b><b> </b><b>DEFAULT</b><b> </b>0<b>,</b>
<b>    </b>&quot;HardKapciPEPutty&quot;<b>      </b><b>NUMERIC</b><b>(</b>6<b>,</b>2<b>)</b><b> </b><b>DEFAULT</b><b> </b>0<b>,</b>
<b>    </b>&quot;HardKapci2KMS651&quot;<b>      </b><b>NUMERIC</b><b>(</b>6<b>,</b>2<b>)</b><b> </b><b>DEFAULT</b><b> </b>0<b>,</b>
<b>    </b>&quot;DilKapci881&quot;<b>           </b><b>NUMERIC</b><b>(</b>6<b>,</b>2<b>)</b><b> </b><b>DEFAULT</b><b> </b>0<b>,</b>
<b>    </b>&quot;DilKapci2K&quot;<b>            </b><b>NUMERIC</b><b>(</b>6<b>,</b>2<b>)</b><b> </b><b>DEFAULT</b><b> </b>0<b>,</b>
<b>    </b>&quot;DilKapci880&quot;<b>           </b><b>NUMERIC</b><b>(</b>6<b>,</b>2<b>)</b><b> </b><b>DEFAULT</b><b> </b>0<b>,</b>
<b>    </b>&quot;PrimerKapci125&quot;<b>        </b><b>NUMERIC</b><b>(</b>6<b>,</b>2<b>)</b><b> </b><b>DEFAULT</b><b> </b>0<b>,</b>
<b>    </b>&quot;PrimerKapci633&quot;<b>        </b><b>NUMERIC</b><b>(</b>6<b>,</b>2<b>)</b><b> </b><b>DEFAULT</b><b> </b>0<b>,</b>
<b>    </b>&quot;EnamelKapci641&quot;<b>        </b><b>NUMERIC</b><b>(</b>6<b>,</b>2<b>)</b><b> </b><b>DEFAULT</b><b> </b>0<b>,</b>
<b>    </b>&quot;EnamelKapci670&quot;<b>        </b><b>NUMERIC</b><b>(</b>6<b>,</b>2<b>)</b><b> </b><b>DEFAULT</b><b> </b>0<b>,</b>
<b>    </b>&quot;EnamelKapci6030&quot;<b>       </b><b>NUMERIC</b><b>(</b>6<b>,</b>2<b>)</b><b> </b><b>DEFAULT</b><b> </b>0<b>,</b>
<b>    </b>&quot;UniversalSikaflex527&quot;<b>  </b><b>NUMERIC</b><b>(</b>6<b>,</b>2<b>)</b><b> </b><b>DEFAULT</b><b> </b>0<b>,</b>
<b>    </b>&quot;PuttyKapci350&quot;<b>         </b><b>NUMERIC</b><b>(</b>6<b>,</b>2<b>)</b><b> </b><b>DEFAULT</b><b> </b>0<b>,</b>
<b>    </b>&quot;LaborIntensity001&quot;<b>     </b><b>NUMERIC</b><b>(</b>6<b>,</b>2<b>)</b><b> </b><b>DEFAULT</b><b> </b>0<b>,</b>
<b>    </b>&quot;LaborIntensity002&quot;<b>     </b><b>NUMERIC</b><b>(</b>6<b>,</b>2<b>)</b><b> </b><b>DEFAULT</b><b> </b>0<b>,</b>
<b>    </b>&quot;LaborIntensity003&quot;<b>     </b><b>NUMERIC</b><b>(</b>6<b>,</b>2<b>)</b><b> </b><b>DEFAULT</b><b> </b>0<b>,</b>
<b>    </b>&quot;LaborIntensity004&quot;<b>     </b><b>NUMERIC</b><b>(</b>6<b>,</b>2<b>)</b><b> </b><b>DEFAULT</b><b> </b>0<b>,</b>
<b>    </b>&quot;LaborIntensity005&quot;<b>     </b><b>NUMERIC</b><b>(</b>6<b>,</b>2<b>)</b><b> </b><b>DEFAULT</b><b> </b>0
<b>)</b><b>;</b>


<b>ALTER</b><b> </b><b>TABLE</b><b> </b><font color="# 080 0"><u>&quot;TechProcess004&quot;</u></font><b> </b><b>ADD</b><b> </b><b>CONSTRAINT</b><b> </b>&quot;PK_TechProcess004Id&quot;<b> </b><b>PRIMARY</b><b> </b><b>KEY</b><b> </b><b>(</b>&quot;Id&quot;<b>)</b><b>;</b>
<b>ALTER</b><b> </b><b>TABLE</b><b> </b><font color="# 080 0"><u>&quot;TechProcess004&quot;</u></font><b> </b><b>ADD</b><b> </b><b>CONSTRAINT</b><b> </b>&quot;FK_TechProcess004_CopyDrawingId&quot;<b> </b><b>FOREIGN</b><b> </b><b>KEY</b><b> </b><b>(</b>&quot;CopyDrawingId&quot;<b>)</b><b> </b><b>REFERENCES</b><b> </b><font color="# 080 0"><u>&quot;Drawing&quot;</u></font><b> </b><b>(</b>&quot;Id&quot;<b>)</b><b> </b><b>ON</b><b> </b><b>DELETE</b><b> </b><b>SET</b><b> </b><b>NULL</b><b>;</b>
<b>ALTER</b><b> </b><b>TABLE</b><b> </b><font color="# 080 0"><u>&quot;TechProcess004&quot;</u></font><b> </b><b>ADD</b><b> </b><b>CONSTRAINT</b><b> </b>&quot;FK_TechProcess004_DrawingId&quot;<b> </b><b>FOREIGN</b><b> </b><b>KEY</b><b> </b><b>(</b>&quot;DrawingId&quot;<b>)</b><b> </b><b>REFERENCES</b><b> </b><font color="# 080 0"><u>&quot;Drawing&quot;</u></font><b> </b><b>(</b>&quot;Id&quot;<b>)</b><b> </b><b>ON</b><b> </b><b>DELETE</b><b> </b><b>SET</b><b> </b><b>NULL</b><b>;</b>
<b>ALTER</b><b> </b><b>TABLE</b><b> </b><font color="# 080 0"><u>&quot;TechProcess004&quot;</u></font><b> </b><b>ADD</b><b> </b><b>CONSTRAINT</b><b> </b>&quot;FK_TechProcess004_ParentId&quot;<b> </b><b>FOREIGN</b><b> </b><b>KEY</b><b> </b><b>(</b>&quot;ParentId&quot;<b>)</b><b> </b><b>REFERENCES</b><b> </b><font color="# 080 0"><u>&quot;TechProcess004&quot;</u></font><b> </b><b>(</b>&quot;Id&quot;<b>)</b><b> </b><b>ON</b><b> </b><b>DELETE</b><b> </b><b>SET</b><b> </b><b>NULL</b><b>;</b>
<b>ALTER</b><b> </b><b>TABLE</b><b> </b><font color="# 080 0"><u>&quot;TechProcess004&quot;</u></font><b> </b><b>ADD</b><b> </b><b>CONSTRAINT</b><b> </b>&quot;FK_TechProcess004_RevisionId&quot;<b> </b><b>FOREIGN</b><b> </b><b>KEY</b><b> </b><b>(</b>&quot;RevisionId&quot;<b>)</b><b> </b><b>REFERENCES</b><b> </b><font color="# 080 0"><u>&quot;Revisions&quot;</u></font><b> </b><b>(</b>&quot;Id&quot;<b>)</b><b>;</b>
<b>ALTER</b><b> </b><b>TABLE</b><b> </b><font color="# 080 0"><u>&quot;TechProcess004&quot;</u></font><b> </b><b>ADD</b><b> </b><b>CONSTRAINT</b><b> </b>&quot;FK_TechProcess004_TypeId&quot;<b> </b><b>FOREIGN</b><b> </b><b>KEY</b><b> </b><b>(</b>&quot;TypeId&quot;<b>)</b><b> </b><b>REFERENCES</b><b> </b><font color="# 080 0"><u>&quot;RevisionType&quot;</u></font><b> </b><b>(</b>&quot;Id&quot;<b>)</b><b>;</b>
<b>ALTER</b><b> </b><b>TABLE</b><b> </b><font color="# 080 0"><u>&quot;TechProcess004&quot;</u></font><b> </b><b>ADD</b><b> </b><b>CONSTRAINT</b><b> </b>&quot;FK_TechProcess004_UserId&quot;<b> </b><b>FOREIGN</b><b> </b><b>KEY</b><b> </b><b>(</b>&quot;UserId&quot;<b>)</b><b> </b><b>REFERENCES</b><b> </b><font color="# 080 0"><u>&quot;Users&quot;</u></font><b> </b><b>(</b>&quot;Id&quot;<b>)</b><b>;</b>

</pre></code>
</span></P>
<P CLASS="Base">&nbsp;</P>

<HR>
<A NAME="TBL_TechProcess005"><P CLASS="Header0">Table: TechProcess005</P><P CLASS="Base">&nbsp;</P>
<P CLASS="Header1">Description</P>
<P CLASS="Base"><I>(There is no description for table TechProcess005)</I></P>
<P CLASS="Base">&nbsp;</P>
<P CLASS="Header1">Fields</P>
<TABLE CLASS="dtArg" CELLSPACING="0">
  <TH WIDTH="1%" ALIGN="middle"><P CLASS="Base2"><B>PK</B></P>
  <TH WIDTH="1%" ALIGN="middle"><P CLASS="Base2"><B>FK</B></P>
  <TH WIDTH="1%"><P CLASS="Base2"><B>Field</B></P>
  <TH WIDTH="1%"><P CLASS="Base2"><B>Domain</B></P>
  <TH WIDTH="20%"><P CLASS="Base2"><B>Type</B></P>
  <TH WIDTH="1%" ALIGN="middle"><P CLASS="Base2"><B>NN</B></P>
  <TH WIDTH="1%"><P CLASS="Base2"><B>Default</B></P>
  <TH WIDTH="40%"><P CLASS="Base2"><B>Description</B></P>
  <TR>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/PK1.gif" BORDER="0"></P></TD>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD><A NAME="TechProcess005.Id"><P CLASS="Base2">Id</P></A></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">INTEGER</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/Yes.gif" BORDER="0"></P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
  </TR>
  <TR>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD><A NAME="TechProcess005.TechProcessName"><P CLASS="Base2">TechProcessName</P></A></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">BIGINT</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
  </TR>
  <TR>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD><A NAME="TechProcess005.TechProcessPath"><P CLASS="Base2">TechProcessPath</P></A></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">VARCHAR(200)</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
  </TR>
  <TR>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD><A NAME="TechProcess005.TechProcessFullName"><P CLASS="Base2">TechProcessFullName</P></A></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">VARCHAR(50)</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
  </TR>
  <TR>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/FK.gif" BORDER="0"></P></TD>
    <TD><A NAME="TechProcess005.RevisionId"><P CLASS="Base2">RevisionId</P></A></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">SMALLINT</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
  </TR>
  <TR>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/FK.gif" BORDER="0"></P></TD>
    <TD><A NAME="TechProcess005.DrawingId"><P CLASS="Base2">DrawingId</P></A></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">SMALLINT</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
  </TR>
  <TR>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/FK.gif" BORDER="0"></P></TD>
    <TD><A NAME="TechProcess005.CopyDrawingId"><P CLASS="Base2">CopyDrawingId</P></A></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">SMALLINT</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
  </TR>
  <TR>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/FK.gif" BORDER="0"></P></TD>
    <TD><A NAME="TechProcess005.ParentId"><P CLASS="Base2">ParentId</P></A></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">SMALLINT</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
  </TR>
  <TR>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD><A NAME="TechProcess005.CreateDate"><P CLASS="Base2">CreateDate</P></A></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">DATE</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></P></TD>
    <TD><P CLASS="Base2">CURRENT_DATE</P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
  </TR>
  <TR>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/FK.gif" BORDER="0"></P></TD>
    <TD><A NAME="TechProcess005.TypeId"><P CLASS="Base2">TypeId</P></A></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">SMALLINT</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></P></TD>
    <TD><P CLASS="Base2">1</P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
  </TR>
  <TR>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD><A NAME="TechProcess005.OldTechProcess"><P CLASS="Base2">OldTechProcess</P></A></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">SMALLINT</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></P></TD>
    <TD><P CLASS="Base2">0</P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
  </TR>
  <TR>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD><A NAME="TechProcess005.TH"><P CLASS="Base2">TH</P></A></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">VARCHAR(10)</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></P></TD>
    <TD><P CLASS="Base2">0</P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
  </TR>
  <TR>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD><A NAME="TechProcess005.W"><P CLASS="Base2">W</P></A></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">VARCHAR(10)</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></P></TD>
    <TD><P CLASS="Base2">0</P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
  </TR>
  <TR>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD><A NAME="TechProcess005.W2"><P CLASS="Base2">W2</P></A></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">VARCHAR(10)</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></P></TD>
    <TD><P CLASS="Base2">0</P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
  </TR>
  <TR>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD><A NAME="TechProcess005.L"><P CLASS="Base2">L</P></A></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">VARCHAR(10)</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></P></TD>
    <TD><P CLASS="Base2">0</P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
  </TR>
  <TR>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD><A NAME="TechProcess005.Weight"><P CLASS="Base2">Weight</P></A></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">NUMERIC(10,2)</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></P></TD>
    <TD><P CLASS="Base2">0</P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
  </TR>
  <TR>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/FK.gif" BORDER="0"></P></TD>
    <TD><A NAME="TechProcess005.UserId"><P CLASS="Base2">UserId</P></A></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">SMALLINT</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
  </TR>
  <TR>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD><A NAME="TechProcess005.RevisionDocumentName"><P CLASS="Base2">RevisionDocumentName</P></A></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">VARCHAR(20)</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
  </TR>
  <TR>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD><A NAME="TechProcess005.Welding20Steel"><P CLASS="Base2">Welding20Steel</P></A></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">NUMERIC(6,2)</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></P></TD>
    <TD><P CLASS="Base2">0</P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
  </TR>
  <TR>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD><A NAME="TechProcess005.Welding10"><P CLASS="Base2">Welding10</P></A></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">NUMERIC(6,2)</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></P></TD>
    <TD><P CLASS="Base2">0</P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
  </TR>
  <TR>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD><A NAME="TechProcess005.Welding12"><P CLASS="Base2">Welding12</P></A></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">NUMERIC(6,2)</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></P></TD>
    <TD><P CLASS="Base2">0</P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
  </TR>
  <TR>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD><A NAME="TechProcess005.Welding16"><P CLASS="Base2">Welding16</P></A></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">NUMERIC(6,2)</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></P></TD>
    <TD><P CLASS="Base2">0</P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
  </TR>
  <TR>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD><A NAME="TechProcess005.Welding20"><P CLASS="Base2">Welding20</P></A></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">NUMERIC(6,2)</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></P></TD>
    <TD><P CLASS="Base2">0</P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
  </TR>
  <TR>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD><A NAME="TechProcess005.GasArCO2"><P CLASS="Base2">GasArCO2</P></A></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">NUMERIC(6,2)</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></P></TD>
    <TD><P CLASS="Base2">0</P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
  </TR>
  <TR>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD><A NAME="TechProcess005.GasCO3"><P CLASS="Base2">GasCO3</P></A></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">NUMERIC(6,2)</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></P></TD>
    <TD><P CLASS="Base2">0</P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
  </TR>
  <TR>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD><A NAME="TechProcess005.GasAr"><P CLASS="Base2">GasAr</P></A></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">NUMERIC(6,2)</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></P></TD>
    <TD><P CLASS="Base2">0</P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
  </TR>
  <TR>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD><A NAME="TechProcess005.WeldingElektrod"><P CLASS="Base2">WeldingElektrod</P></A></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">NUMERIC(6,2)</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></P></TD>
    <TD><P CLASS="Base2">0</P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
  </TR>
  <TR>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD><A NAME="TechProcess005.GasO2"><P CLASS="Base2">GasO2</P></A></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">NUMERIC(6,2)</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></P></TD>
    <TD><P CLASS="Base2">0</P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
  </TR>
  <TR>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD><A NAME="TechProcess005.GasNature"><P CLASS="Base2">GasNature</P></A></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">NUMERIC(6,2)</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></P></TD>
    <TD><P CLASS="Base2">0</P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
  </TR>
  <TR>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD><A NAME="TechProcess005.GasN2"><P CLASS="Base2">GasN2</P></A></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">NUMERIC(6,2)</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></P></TD>
    <TD><P CLASS="Base2">0</P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
  </TR>
  <TR>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD><A NAME="TechProcess005.HardKapci881"><P CLASS="Base2">HardKapci881</P></A></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">NUMERIC(6,2)</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></P></TD>
    <TD><P CLASS="Base2">0</P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
  </TR>
  <TR>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD><A NAME="TechProcess005.HardKapciHs6055"><P CLASS="Base2">HardKapciHs6055</P></A></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">NUMERIC(6,2)</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></P></TD>
    <TD><P CLASS="Base2">0</P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
  </TR>
  <TR>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD><A NAME="TechProcess005.HardKapci126"><P CLASS="Base2">HardKapci126</P></A></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">NUMERIC(6,2)</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></P></TD>
    <TD><P CLASS="Base2">0</P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
  </TR>
  <TR>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD><A NAME="TechProcess005.HardKapciPEPutty"><P CLASS="Base2">HardKapciPEPutty</P></A></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">NUMERIC(6,2)</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></P></TD>
    <TD><P CLASS="Base2">0</P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
  </TR>
  <TR>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD><A NAME="TechProcess005.HardKapci2KMS651"><P CLASS="Base2">HardKapci2KMS651</P></A></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">NUMERIC(6,2)</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></P></TD>
    <TD><P CLASS="Base2">0</P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
  </TR>
  <TR>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD><A NAME="TechProcess005.DilKapci881"><P CLASS="Base2">DilKapci881</P></A></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">NUMERIC(6,2)</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></P></TD>
    <TD><P CLASS="Base2">0</P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
  </TR>
  <TR>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD><A NAME="TechProcess005.DilKapci2K"><P CLASS="Base2">DilKapci2K</P></A></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">NUMERIC(6,2)</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></P></TD>
    <TD><P CLASS="Base2">0</P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
  </TR>
  <TR>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD><A NAME="TechProcess005.DilKapci880"><P CLASS="Base2">DilKapci880</P></A></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">NUMERIC(6,2)</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></P></TD>
    <TD><P CLASS="Base2">0</P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
  </TR>
  <TR>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD><A NAME="TechProcess005.PrimerKapci125"><P CLASS="Base2">PrimerKapci125</P></A></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">NUMERIC(6,2)</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></P></TD>
    <TD><P CLASS="Base2">0</P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
  </TR>
  <TR>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD><A NAME="TechProcess005.PrimerKapci633"><P CLASS="Base2">PrimerKapci633</P></A></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">NUMERIC(6,2)</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></P></TD>
    <TD><P CLASS="Base2">0</P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
  </TR>
  <TR>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD><A NAME="TechProcess005.EnamelKapci641"><P CLASS="Base2">EnamelKapci641</P></A></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">NUMERIC(6,2)</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></P></TD>
    <TD><P CLASS="Base2">0</P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
  </TR>
  <TR>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD><A NAME="TechProcess005.EnamelKapci670"><P CLASS="Base2">EnamelKapci670</P></A></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">NUMERIC(6,2)</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></P></TD>
    <TD><P CLASS="Base2">0</P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
  </TR>
  <TR>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD><A NAME="TechProcess005.EnamelKapci6030"><P CLASS="Base2">EnamelKapci6030</P></A></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">NUMERIC(6,2)</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></P></TD>
    <TD><P CLASS="Base2">0</P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
  </TR>
  <TR>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD><A NAME="TechProcess005.UniversalSikaflex527"><P CLASS="Base2">UniversalSikaflex527</P></A></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">NUMERIC(6,2)</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></P></TD>
    <TD><P CLASS="Base2">0</P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
  </TR>
  <TR>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD><A NAME="TechProcess005.PuttyKapci350"><P CLASS="Base2">PuttyKapci350</P></A></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">NUMERIC(6,2)</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></P></TD>
    <TD><P CLASS="Base2">0</P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
  </TR>
  <TR>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD><A NAME="TechProcess005.LaborIntensity001"><P CLASS="Base2">LaborIntensity001</P></A></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">NUMERIC(6,2)</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></P></TD>
    <TD><P CLASS="Base2">0</P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
  </TR>
  <TR>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD><A NAME="TechProcess005.LaborIntensity002"><P CLASS="Base2">LaborIntensity002</P></A></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">NUMERIC(6,2)</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></P></TD>
    <TD><P CLASS="Base2">0</P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
  </TR>
  <TR>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD><A NAME="TechProcess005.LaborIntensity003"><P CLASS="Base2">LaborIntensity003</P></A></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">NUMERIC(6,2)</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></P></TD>
    <TD><P CLASS="Base2">0</P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
  </TR>
  <TR>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD><A NAME="TechProcess005.LaborIntensity004"><P CLASS="Base2">LaborIntensity004</P></A></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">NUMERIC(6,2)</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></P></TD>
    <TD><P CLASS="Base2">0</P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
  </TR>
  <TR>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD><A NAME="TechProcess005.LaborIntensity005"><P CLASS="Base2">LaborIntensity005</P></A></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">NUMERIC(6,2)</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></P></TD>
    <TD><P CLASS="Base2">0</P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
  </TR>
</TABLE>
<P CLASS="Base">&nbsp;</P>
<P CLASS="Header1">Triggers</P>
<TABLE CLASS="dtArg" CELLSPACING="0">
  <TH WIDTH="1%"><P CLASS="Base2"><B>Trigger</B></P>
  <TH WIDTH="1%"><P CLASS="Base2"><B>Type</B></P>
  <TH WIDTH="1%"><P CLASS="Base2"><B>Activity</B></P>
  <TH WIDTH="1%"><P CLASS="Base2"><B>Order</B></P>
  <TH WIDTH="50%"><P CLASS="Base2"><B>Description</B></P>
  <TR>
    <TD><P CLASS="Base2"><A HREF="#TRG_Tr_TechProcess005">Tr_TechProcess005</A></TD>
    <TD><P CLASS="Base2">BEFORE&nbsp;INSERT</TD>
    <TD><P CLASS="Base2">Yes</TD>
    <TD ALIGN="right"><P CLASS="Base2">0</TD>
    <TD><P CLASS="Base2">&nbsp</TD>
  </TR>
</TABLE>
<P CLASS="Base">&nbsp;</P>
<P CLASS="Header1">Indices</P>
<TABLE CLASS="dtArg" CELLSPACING="0">
  <TH><P CLASS="Base2"><B>Index</B></P>
  <TH><P CLASS="Base2"><B>Fields</B></P>
  <TH ALIGN="middle"><P CLASS="Base2"><B>Active</B></P>
  <TH ALIGN="middle"><P CLASS="Base2"><B>Unique</B></P>
  <TH ALIGN="middle"><P CLASS="Base2"><B>Order</B></P>
  <TR>
    <TD><P CLASS="Base2"><A HREF="#IND_FK_TechProcess005_CopyDrawingId">FK_TechProcess005_CopyDrawingId</A></TD>
    <TD><P CLASS="Base2">"CopyDrawingId"</TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/Yes.gif" BORDER="0"></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></TD>
    <TD ALIGN="middle"><P CLASS="Base2">ASC</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2"><A HREF="#IND_FK_TechProcess005_DrawingId">FK_TechProcess005_DrawingId</A></TD>
    <TD><P CLASS="Base2">"DrawingId"</TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/Yes.gif" BORDER="0"></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></TD>
    <TD ALIGN="middle"><P CLASS="Base2">ASC</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2"><A HREF="#IND_FK_TechProcess005_ParentId">FK_TechProcess005_ParentId</A></TD>
    <TD><P CLASS="Base2">"ParentId"</TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/Yes.gif" BORDER="0"></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></TD>
    <TD ALIGN="middle"><P CLASS="Base2">ASC</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2"><A HREF="#IND_FK_TechProcess005_RevisionId">FK_TechProcess005_RevisionId</A></TD>
    <TD><P CLASS="Base2">"RevisionId"</TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/Yes.gif" BORDER="0"></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></TD>
    <TD ALIGN="middle"><P CLASS="Base2">ASC</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2"><A HREF="#IND_FK_TechProcess005_TypeId">FK_TechProcess005_TypeId</A></TD>
    <TD><P CLASS="Base2">"TypeId"</TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/Yes.gif" BORDER="0"></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></TD>
    <TD ALIGN="middle"><P CLASS="Base2">ASC</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2"><A HREF="#IND_FK_TechProcess005_UserId">FK_TechProcess005_UserId</A></TD>
    <TD><P CLASS="Base2">"UserId"</TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/Yes.gif" BORDER="0"></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></TD>
    <TD ALIGN="middle"><P CLASS="Base2">ASC</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2"><A HREF="#IND_PK_TechProcess005Id">PK_TechProcess005Id</A></TD>
    <TD><P CLASS="Base2">"Id"</TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/Yes.gif" BORDER="0"></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/Yes.gif" BORDER="0"></TD>
    <TD ALIGN="middle"><P CLASS="Base2">ASC</TD>
  </TR>
</TABLE>
<P CLASS="Base">&nbsp;</P>
<P CLASS="Header1">References</P>
<TABLE CLASS="dtArg" CELLSPACING="0">
  <TH><P CLASS="Base2"><B>Table</B></P>
  <TH><P CLASS="Base2"><B>Foreign Key</B></P>
  <TH><P CLASS="Base2"><B>Fields</B></P>
  <TH><P CLASS="Base2"><B>FK Field</B></P>
  <TH><P CLASS="Base2"><B>Delete Rule</B></P>
  <TH><P CLASS="Base2"><B>Update Rule</B></P>
  <TR>
    <TD><P CLASS="Base2"><A HREF="#TBL_Drawing">Drawing</A></TD>
    <TD><P CLASS="Base2"><A HREF="#FKEY_FK_TechProcess005_CopyDrawingId">FK_TechProcess005_CopyDrawingId</A></TD>
    <TD><P CLASS="Base2">CopyDrawingId</TD>
    <TD><P CLASS="Base2">Id</TD>
    <TD><P CLASS="Base2">SET NULL</TD>
    <TD><P CLASS="Base2">NO ACTION</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2"><A HREF="#TBL_Drawing">Drawing</A></TD>
    <TD><P CLASS="Base2"><A HREF="#FKEY_FK_TechProcess005_DrawingId">FK_TechProcess005_DrawingId</A></TD>
    <TD><P CLASS="Base2">DrawingId</TD>
    <TD><P CLASS="Base2">Id</TD>
    <TD><P CLASS="Base2">SET NULL</TD>
    <TD><P CLASS="Base2">NO ACTION</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2"><A HREF="#TBL_TechProcess005">TechProcess005</A></TD>
    <TD><P CLASS="Base2"><A HREF="#FKEY_FK_TechProcess005_ParentId">FK_TechProcess005_ParentId</A></TD>
    <TD><P CLASS="Base2">ParentId</TD>
    <TD><P CLASS="Base2">Id</TD>
    <TD><P CLASS="Base2">SET NULL</TD>
    <TD><P CLASS="Base2">NO ACTION</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2"><A HREF="#TBL_Revisions">Revisions</A></TD>
    <TD><P CLASS="Base2"><A HREF="#FKEY_FK_TechProcess005_RevisionId">FK_TechProcess005_RevisionId</A></TD>
    <TD><P CLASS="Base2">RevisionId</TD>
    <TD><P CLASS="Base2">Id</TD>
    <TD><P CLASS="Base2">NO ACTION</TD>
    <TD><P CLASS="Base2">NO ACTION</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2"><A HREF="#TBL_RevisionType">RevisionType</A></TD>
    <TD><P CLASS="Base2"><A HREF="#FKEY_FK_TechProcess005_TypeId">FK_TechProcess005_TypeId</A></TD>
    <TD><P CLASS="Base2">TypeId</TD>
    <TD><P CLASS="Base2">Id</TD>
    <TD><P CLASS="Base2">NO ACTION</TD>
    <TD><P CLASS="Base2">NO ACTION</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2"><A HREF="#TBL_Users">Users</A></TD>
    <TD><P CLASS="Base2"><A HREF="#FKEY_FK_TechProcess005_UserId">FK_TechProcess005_UserId</A></TD>
    <TD><P CLASS="Base2">UserId</TD>
    <TD><P CLASS="Base2">Id</TD>
    <TD><P CLASS="Base2">NO ACTION</TD>
    <TD><P CLASS="Base2">NO ACTION</TD>
  </TR>
</TABLE>
<P CLASS="Base">&nbsp;</P>
<P CLASS="Header1">Referenced By</P>
<TABLE CLASS="dtArg" CELLSPACING="0">
  <TH><P CLASS="Base2"><B>Table</B></P>
  <TH><P CLASS="Base2"><B>Foreign Key</B></P>
  <TH><P CLASS="Base2"><B>Fields</B></P>
  <TH><P CLASS="Base2"><B>FK Field</B></P>
  <TH><P CLASS="Base2"><B>Delete Rule</B></P>
  <TH><P CLASS="Base2"><B>Update Rule</B></P>
  <TR>
    <TD><P CLASS="Base2"><A HREF="#TBL_TechProcess005">TechProcess005</A></TD>
    <TD><P CLASS="Base2"><A HREF="#FKEY_FK_TechProcess005_ParentId">FK_TechProcess005_ParentId</A></TD>
    <TD><P CLASS="Base2">ParentId</TD>
    <TD><P CLASS="Base2">Id</TD>
    <TD><P CLASS="Base2">SET NULL</TD>
    <TD><P CLASS="Base2">NO ACTION</TD>
  </TR>
</TABLE>
<P CLASS="Base">&nbsp;</P>
<P CLASS="Header1">Definition</P>
<P CLASS="Base"><span class="DDLCode">
<code><pre>
<b>CREATE</b><b> </b><b>TABLE</b><b> </b><font color="# 080 0"><u>&quot;TechProcess005&quot;</u></font><b> </b><b>(</b>
<b>    </b>&quot;Id&quot;<b>                    </b><b>INTEGER</b><b> </b><b>NOT</b><b> </b><b>NULL</b><b>,</b>
<b>    </b>&quot;TechProcessName&quot;<b>       </b><b>BIGINT</b><b>,</b>
<b>    </b>&quot;TechProcessPath&quot;<b>       </b><b>VARCHAR</b><b>(</b>200<b>)</b><b>,</b>
<b>    </b>&quot;TechProcessFullName&quot;<b>   </b><b>VARCHAR</b><b>(</b>50<b>)</b><b>,</b>
<b>    </b>&quot;RevisionId&quot;<b>            </b><b>SMALLINT</b><b>,</b>
<b>    </b>&quot;DrawingId&quot;<b>             </b><b>SMALLINT</b><b>,</b>
<b>    </b>&quot;CopyDrawingId&quot;<b>         </b><b>SMALLINT</b><b>,</b>
<b>    </b>&quot;ParentId&quot;<b>              </b><b>SMALLINT</b><b>,</b>
<b>    </b>&quot;CreateDate&quot;<b>            </b><b>DATE</b><b> </b><b>DEFAULT</b><b> </b><b>CURRENT_DATE</b><b>,</b>
<b>    </b>&quot;TypeId&quot;<b>                </b><b>SMALLINT</b><b> </b><b>DEFAULT</b><b> </b>1<b>,</b>
<b>    </b>&quot;OldTechProcess&quot;<b>        </b><b>SMALLINT</b><b> </b><b>DEFAULT</b><b> </b>0<b>,</b>
<b>    </b>TH<b>                      </b><b>VARCHAR</b><b>(</b>10<b>)</b><b> </b><b>CHARACTER</b><b> </b><b>SET</b><b> </b>WIN1251<b> </b><b>DEFAULT</b><b> </b>0<b>,</b>
<b>    </b>W<b>                       </b><b>VARCHAR</b><b>(</b>10<b>)</b><b> </b><b>CHARACTER</b><b> </b><b>SET</b><b> </b>WIN1251<b> </b><b>DEFAULT</b><b> </b>0<b>,</b>
<b>    </b>W2<b>                      </b><b>VARCHAR</b><b>(</b>10<b>)</b><b> </b><b>CHARACTER</b><b> </b><b>SET</b><b> </b>WIN1251<b> </b><b>DEFAULT</b><b> </b>0<b>,</b>
<b>    </b>L<b>                       </b><b>VARCHAR</b><b>(</b>10<b>)</b><b> </b><b>CHARACTER</b><b> </b><b>SET</b><b> </b>WIN1251<b> </b><b>DEFAULT</b><b> </b>0<b>,</b>
<b>    </b>&quot;Weight&quot;<b>                </b><b>NUMERIC</b><b>(</b>10<b>,</b>2<b>)</b><b> </b><b>DEFAULT</b><b> </b>0<b>,</b>
<b>    </b>&quot;UserId&quot;<b>                </b><b>SMALLINT</b><b>,</b>
<b>    </b>&quot;RevisionDocumentName&quot;<b>  </b><b>VARCHAR</b><b>(</b>20<b>)</b><b>,</b>
<b>    </b>&quot;Welding20Steel&quot;<b>        </b><b>NUMERIC</b><b>(</b>6<b>,</b>2<b>)</b><b> </b><b>DEFAULT</b><b> </b>0<b>,</b>
<b>    </b>&quot;Welding10&quot;<b>             </b><b>NUMERIC</b><b>(</b>6<b>,</b>2<b>)</b><b> </b><b>DEFAULT</b><b> </b>0<b>,</b>
<b>    </b>&quot;Welding12&quot;<b>             </b><b>NUMERIC</b><b>(</b>6<b>,</b>2<b>)</b><b> </b><b>DEFAULT</b><b> </b>0<b>,</b>
<b>    </b>&quot;Welding16&quot;<b>             </b><b>NUMERIC</b><b>(</b>6<b>,</b>2<b>)</b><b> </b><b>DEFAULT</b><b> </b>0<b>,</b>
<b>    </b>&quot;Welding20&quot;<b>             </b><b>NUMERIC</b><b>(</b>6<b>,</b>2<b>)</b><b> </b><b>DEFAULT</b><b> </b>0<b>,</b>
<b>    </b>&quot;GasArCO2&quot;<b>              </b><b>NUMERIC</b><b>(</b>6<b>,</b>2<b>)</b><b> </b><b>DEFAULT</b><b> </b>0<b>,</b>
<b>    </b>&quot;GasCO3&quot;<b>                </b><b>NUMERIC</b><b>(</b>6<b>,</b>2<b>)</b><b> </b><b>DEFAULT</b><b> </b>0<b>,</b>
<b>    </b>&quot;GasAr&quot;<b>                 </b><b>NUMERIC</b><b>(</b>6<b>,</b>2<b>)</b><b> </b><b>DEFAULT</b><b> </b>0<b>,</b>
<b>    </b>&quot;WeldingElektrod&quot;<b>       </b><b>NUMERIC</b><b>(</b>6<b>,</b>2<b>)</b><b> </b><b>DEFAULT</b><b> </b>0<b>,</b>
<b>    </b>&quot;GasO2&quot;<b>                 </b><b>NUMERIC</b><b>(</b>6<b>,</b>2<b>)</b><b> </b><b>DEFAULT</b><b> </b>0<b>,</b>
<b>    </b>&quot;GasNature&quot;<b>             </b><b>NUMERIC</b><b>(</b>6<b>,</b>2<b>)</b><b> </b><b>DEFAULT</b><b> </b>0<b>,</b>
<b>    </b>&quot;GasN2&quot;<b>                 </b><b>NUMERIC</b><b>(</b>6<b>,</b>2<b>)</b><b> </b><b>DEFAULT</b><b> </b>0<b>,</b>
<b>    </b>&quot;HardKapci881&quot;<b>          </b><b>NUMERIC</b><b>(</b>6<b>,</b>2<b>)</b><b> </b><b>DEFAULT</b><b> </b>0<b>,</b>
<b>    </b>&quot;HardKapciHs6055&quot;<b>       </b><b>NUMERIC</b><b>(</b>6<b>,</b>2<b>)</b><b> </b><b>DEFAULT</b><b> </b>0<b>,</b>
<b>    </b>&quot;HardKapci126&quot;<b>          </b><b>NUMERIC</b><b>(</b>6<b>,</b>2<b>)</b><b> </b><b>DEFAULT</b><b> </b>0<b>,</b>
<b>    </b>&quot;HardKapciPEPutty&quot;<b>      </b><b>NUMERIC</b><b>(</b>6<b>,</b>2<b>)</b><b> </b><b>DEFAULT</b><b> </b>0<b>,</b>
<b>    </b>&quot;HardKapci2KMS651&quot;<b>      </b><b>NUMERIC</b><b>(</b>6<b>,</b>2<b>)</b><b> </b><b>DEFAULT</b><b> </b>0<b>,</b>
<b>    </b>&quot;DilKapci881&quot;<b>           </b><b>NUMERIC</b><b>(</b>6<b>,</b>2<b>)</b><b> </b><b>DEFAULT</b><b> </b>0<b>,</b>
<b>    </b>&quot;DilKapci2K&quot;<b>            </b><b>NUMERIC</b><b>(</b>6<b>,</b>2<b>)</b><b> </b><b>DEFAULT</b><b> </b>0<b>,</b>
<b>    </b>&quot;DilKapci880&quot;<b>           </b><b>NUMERIC</b><b>(</b>6<b>,</b>2<b>)</b><b> </b><b>DEFAULT</b><b> </b>0<b>,</b>
<b>    </b>&quot;PrimerKapci125&quot;<b>        </b><b>NUMERIC</b><b>(</b>6<b>,</b>2<b>)</b><b> </b><b>DEFAULT</b><b> </b>0<b>,</b>
<b>    </b>&quot;PrimerKapci633&quot;<b>        </b><b>NUMERIC</b><b>(</b>6<b>,</b>2<b>)</b><b> </b><b>DEFAULT</b><b> </b>0<b>,</b>
<b>    </b>&quot;EnamelKapci641&quot;<b>        </b><b>NUMERIC</b><b>(</b>6<b>,</b>2<b>)</b><b> </b><b>DEFAULT</b><b> </b>0<b>,</b>
<b>    </b>&quot;EnamelKapci670&quot;<b>        </b><b>NUMERIC</b><b>(</b>6<b>,</b>2<b>)</b><b> </b><b>DEFAULT</b><b> </b>0<b>,</b>
<b>    </b>&quot;EnamelKapci6030&quot;<b>       </b><b>NUMERIC</b><b>(</b>6<b>,</b>2<b>)</b><b> </b><b>DEFAULT</b><b> </b>0<b>,</b>
<b>    </b>&quot;UniversalSikaflex527&quot;<b>  </b><b>NUMERIC</b><b>(</b>6<b>,</b>2<b>)</b><b> </b><b>DEFAULT</b><b> </b>0<b>,</b>
<b>    </b>&quot;PuttyKapci350&quot;<b>         </b><b>NUMERIC</b><b>(</b>6<b>,</b>2<b>)</b><b> </b><b>DEFAULT</b><b> </b>0<b>,</b>
<b>    </b>&quot;LaborIntensity001&quot;<b>     </b><b>NUMERIC</b><b>(</b>6<b>,</b>2<b>)</b><b> </b><b>DEFAULT</b><b> </b>0<b>,</b>
<b>    </b>&quot;LaborIntensity002&quot;<b>     </b><b>NUMERIC</b><b>(</b>6<b>,</b>2<b>)</b><b> </b><b>DEFAULT</b><b> </b>0<b>,</b>
<b>    </b>&quot;LaborIntensity003&quot;<b>     </b><b>NUMERIC</b><b>(</b>6<b>,</b>2<b>)</b><b> </b><b>DEFAULT</b><b> </b>0<b>,</b>
<b>    </b>&quot;LaborIntensity004&quot;<b>     </b><b>NUMERIC</b><b>(</b>6<b>,</b>2<b>)</b><b> </b><b>DEFAULT</b><b> </b>0<b>,</b>
<b>    </b>&quot;LaborIntensity005&quot;<b>     </b><b>NUMERIC</b><b>(</b>6<b>,</b>2<b>)</b><b> </b><b>DEFAULT</b><b> </b>0
<b>)</b><b>;</b>


<b>ALTER</b><b> </b><b>TABLE</b><b> </b><font color="# 080 0"><u>&quot;TechProcess005&quot;</u></font><b> </b><b>ADD</b><b> </b><b>CONSTRAINT</b><b> </b>&quot;PK_TechProcess005Id&quot;<b> </b><b>PRIMARY</b><b> </b><b>KEY</b><b> </b><b>(</b>&quot;Id&quot;<b>)</b><b>;</b>
<b>ALTER</b><b> </b><b>TABLE</b><b> </b><font color="# 080 0"><u>&quot;TechProcess005&quot;</u></font><b> </b><b>ADD</b><b> </b><b>CONSTRAINT</b><b> </b>&quot;FK_TechProcess005_CopyDrawingId&quot;<b> </b><b>FOREIGN</b><b> </b><b>KEY</b><b> </b><b>(</b>&quot;CopyDrawingId&quot;<b>)</b><b> </b><b>REFERENCES</b><b> </b><font color="# 080 0"><u>&quot;Drawing&quot;</u></font><b> </b><b>(</b>&quot;Id&quot;<b>)</b><b> </b><b>ON</b><b> </b><b>DELETE</b><b> </b><b>SET</b><b> </b><b>NULL</b><b>;</b>
<b>ALTER</b><b> </b><b>TABLE</b><b> </b><font color="# 080 0"><u>&quot;TechProcess005&quot;</u></font><b> </b><b>ADD</b><b> </b><b>CONSTRAINT</b><b> </b>&quot;FK_TechProcess005_DrawingId&quot;<b> </b><b>FOREIGN</b><b> </b><b>KEY</b><b> </b><b>(</b>&quot;DrawingId&quot;<b>)</b><b> </b><b>REFERENCES</b><b> </b><font color="# 080 0"><u>&quot;Drawing&quot;</u></font><b> </b><b>(</b>&quot;Id&quot;<b>)</b><b> </b><b>ON</b><b> </b><b>DELETE</b><b> </b><b>SET</b><b> </b><b>NULL</b><b>;</b>
<b>ALTER</b><b> </b><b>TABLE</b><b> </b><font color="# 080 0"><u>&quot;TechProcess005&quot;</u></font><b> </b><b>ADD</b><b> </b><b>CONSTRAINT</b><b> </b>&quot;FK_TechProcess005_ParentId&quot;<b> </b><b>FOREIGN</b><b> </b><b>KEY</b><b> </b><b>(</b>&quot;ParentId&quot;<b>)</b><b> </b><b>REFERENCES</b><b> </b><font color="# 080 0"><u>&quot;TechProcess005&quot;</u></font><b> </b><b>(</b>&quot;Id&quot;<b>)</b><b> </b><b>ON</b><b> </b><b>DELETE</b><b> </b><b>SET</b><b> </b><b>NULL</b><b>;</b>
<b>ALTER</b><b> </b><b>TABLE</b><b> </b><font color="# 080 0"><u>&quot;TechProcess005&quot;</u></font><b> </b><b>ADD</b><b> </b><b>CONSTRAINT</b><b> </b>&quot;FK_TechProcess005_RevisionId&quot;<b> </b><b>FOREIGN</b><b> </b><b>KEY</b><b> </b><b>(</b>&quot;RevisionId&quot;<b>)</b><b> </b><b>REFERENCES</b><b> </b><font color="# 080 0"><u>&quot;Revisions&quot;</u></font><b> </b><b>(</b>&quot;Id&quot;<b>)</b><b>;</b>
<b>ALTER</b><b> </b><b>TABLE</b><b> </b><font color="# 080 0"><u>&quot;TechProcess005&quot;</u></font><b> </b><b>ADD</b><b> </b><b>CONSTRAINT</b><b> </b>&quot;FK_TechProcess005_TypeId&quot;<b> </b><b>FOREIGN</b><b> </b><b>KEY</b><b> </b><b>(</b>&quot;TypeId&quot;<b>)</b><b> </b><b>REFERENCES</b><b> </b><font color="# 080 0"><u>&quot;RevisionType&quot;</u></font><b> </b><b>(</b>&quot;Id&quot;<b>)</b><b>;</b>
<b>ALTER</b><b> </b><b>TABLE</b><b> </b><font color="# 080 0"><u>&quot;TechProcess005&quot;</u></font><b> </b><b>ADD</b><b> </b><b>CONSTRAINT</b><b> </b>&quot;FK_TechProcess005_UserId&quot;<b> </b><b>FOREIGN</b><b> </b><b>KEY</b><b> </b><b>(</b>&quot;UserId&quot;<b>)</b><b> </b><b>REFERENCES</b><b> </b><font color="# 080 0"><u>&quot;Users&quot;</u></font><b> </b><b>(</b>&quot;Id&quot;<b>)</b><b>;</b>

</pre></code>
</span></P>
<P CLASS="Base">&nbsp;</P>

<HR>
<A NAME="TBL_Type"><P CLASS="Header0">Table: Type</P><P CLASS="Base">&nbsp;</P>
<P CLASS="Header1">Description</P>
<P CLASS="Base"><I>(There is no description for table Type)</I></P>
<P CLASS="Base">&nbsp;</P>
<P CLASS="Header1">Fields</P>
<TABLE CLASS="dtArg" CELLSPACING="0">
  <TH WIDTH="1%" ALIGN="middle"><P CLASS="Base2"><B>PK</B></P>
  <TH WIDTH="1%" ALIGN="middle"><P CLASS="Base2"><B>FK</B></P>
  <TH WIDTH="1%"><P CLASS="Base2"><B>Field</B></P>
  <TH WIDTH="1%"><P CLASS="Base2"><B>Domain</B></P>
  <TH WIDTH="20%"><P CLASS="Base2"><B>Type</B></P>
  <TH WIDTH="1%" ALIGN="middle"><P CLASS="Base2"><B>NN</B></P>
  <TH WIDTH="1%"><P CLASS="Base2"><B>Default</B></P>
  <TH WIDTH="40%"><P CLASS="Base2"><B>Description</B></P>
  <TR>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/PK1.gif" BORDER="0"></P></TD>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD><A NAME="Type.Id"><P CLASS="Base2">Id</P></A></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">INTEGER</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/Yes.gif" BORDER="0"></P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
  </TR>
  <TR>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD><A NAME="Type.TypeName"><P CLASS="Base2">TypeName</P></A></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">VARCHAR(30)</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
  </TR>
</TABLE>
<P CLASS="Base">&nbsp;</P>
<P CLASS="Header1">Triggers</P>
<TABLE CLASS="dtArg" CELLSPACING="0">
  <TH WIDTH="1%"><P CLASS="Base2"><B>Trigger</B></P>
  <TH WIDTH="1%"><P CLASS="Base2"><B>Type</B></P>
  <TH WIDTH="1%"><P CLASS="Base2"><B>Activity</B></P>
  <TH WIDTH="1%"><P CLASS="Base2"><B>Order</B></P>
  <TH WIDTH="50%"><P CLASS="Base2"><B>Description</B></P>
  <TR>
    <TD><P CLASS="Base2"><A HREF="#TRG_Tr_Type">Tr_Type</A></TD>
    <TD><P CLASS="Base2">BEFORE&nbsp;INSERT</TD>
    <TD><P CLASS="Base2">Yes</TD>
    <TD ALIGN="right"><P CLASS="Base2">0</TD>
    <TD><P CLASS="Base2">&nbsp</TD>
  </TR>
</TABLE>
<P CLASS="Base">&nbsp;</P>
<P CLASS="Header1">Indices</P>
<TABLE CLASS="dtArg" CELLSPACING="0">
  <TH><P CLASS="Base2"><B>Index</B></P>
  <TH><P CLASS="Base2"><B>Fields</B></P>
  <TH ALIGN="middle"><P CLASS="Base2"><B>Active</B></P>
  <TH ALIGN="middle"><P CLASS="Base2"><B>Unique</B></P>
  <TH ALIGN="middle"><P CLASS="Base2"><B>Order</B></P>
  <TR>
    <TD><P CLASS="Base2"><A HREF="#IND_PK_TypeId">PK_TypeId</A></TD>
    <TD><P CLASS="Base2">"Id"</TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/Yes.gif" BORDER="0"></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/Yes.gif" BORDER="0"></TD>
    <TD ALIGN="middle"><P CLASS="Base2">ASC</TD>
  </TR>
</TABLE>
<P CLASS="Base">&nbsp;</P>
<P CLASS="Header1">References</P>
<P CLASS="Base"><I>(There are no references for table Type)</I></P>
<P CLASS="Base">&nbsp;</P>
<P CLASS="Header1">Referenced By</P>
<TABLE CLASS="dtArg" CELLSPACING="0">
  <TH><P CLASS="Base2"><B>Table</B></P>
  <TH><P CLASS="Base2"><B>Foreign Key</B></P>
  <TH><P CLASS="Base2"><B>Fields</B></P>
  <TH><P CLASS="Base2"><B>FK Field</B></P>
  <TH><P CLASS="Base2"><B>Delete Rule</B></P>
  <TH><P CLASS="Base2"><B>Update Rule</B></P>
  <TR>
    <TD><P CLASS="Base2"><A HREF="#TBL_Drawing">Drawing</A></TD>
    <TD><P CLASS="Base2"><A HREF="#FKEY_FK_Drawing_TypeId">FK_Drawing_TypeId</A></TD>
    <TD><P CLASS="Base2">TypeId</TD>
    <TD><P CLASS="Base2">Id</TD>
    <TD><P CLASS="Base2">SET NULL</TD>
    <TD><P CLASS="Base2">NO ACTION</TD>
  </TR>
</TABLE>
<P CLASS="Base">&nbsp;</P>
<P CLASS="Header1">Definition</P>
<P CLASS="Base"><span class="DDLCode">
<code><pre>
<b>CREATE</b><b> </b><b>TABLE</b><b> </b><font color="# 080 0"><u>&quot;Type&quot;</u></font><b> </b><b>(</b>
<b>    </b>&quot;Id&quot;<b>        </b><b>INTEGER</b><b> </b><b>NOT</b><b> </b><b>NULL</b><b>,</b>
<b>    </b>&quot;TypeName&quot;<b>  </b><b>VARCHAR</b><b>(</b>30<b>)</b>
<b>)</b><b>;</b>


<b>ALTER</b><b> </b><b>TABLE</b><b> </b><font color="# 080 0"><u>&quot;Type&quot;</u></font><b> </b><b>ADD</b><b> </b><b>CONSTRAINT</b><b> </b>&quot;PK_TypeId&quot;<b> </b><b>PRIMARY</b><b> </b><b>KEY</b><b> </b><b>(</b>&quot;Id&quot;<b>)</b><b>;</b>

</pre></code>
</span></P>
<P CLASS="Base">&nbsp;</P>

<HR>
<A NAME="TBL_UserRole"><P CLASS="Header0">Table: UserRole</P><P CLASS="Base">&nbsp;</P>
<P CLASS="Header1">Description</P>
<P CLASS="Base"><I>(There is no description for table UserRole)</I></P>
<P CLASS="Base">&nbsp;</P>
<P CLASS="Header1">Fields</P>
<TABLE CLASS="dtArg" CELLSPACING="0">
  <TH WIDTH="1%" ALIGN="middle"><P CLASS="Base2"><B>PK</B></P>
  <TH WIDTH="1%" ALIGN="middle"><P CLASS="Base2"><B>FK</B></P>
  <TH WIDTH="1%"><P CLASS="Base2"><B>Field</B></P>
  <TH WIDTH="1%"><P CLASS="Base2"><B>Domain</B></P>
  <TH WIDTH="20%"><P CLASS="Base2"><B>Type</B></P>
  <TH WIDTH="1%" ALIGN="middle"><P CLASS="Base2"><B>NN</B></P>
  <TH WIDTH="1%"><P CLASS="Base2"><B>Default</B></P>
  <TH WIDTH="40%"><P CLASS="Base2"><B>Description</B></P>
  <TR>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/PK1.gif" BORDER="0"></P></TD>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD><A NAME="UserRole.Id"><P CLASS="Base2">Id</P></A></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">INTEGER</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/Yes.gif" BORDER="0"></P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
  </TR>
  <TR>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD><A NAME="UserRole.RoleName"><P CLASS="Base2">RoleName</P></A></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">VARCHAR(20)</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
  </TR>
</TABLE>
<P CLASS="Base">&nbsp;</P>
<P CLASS="Header1">Triggers</P>
<TABLE CLASS="dtArg" CELLSPACING="0">
  <TH WIDTH="1%"><P CLASS="Base2"><B>Trigger</B></P>
  <TH WIDTH="1%"><P CLASS="Base2"><B>Type</B></P>
  <TH WIDTH="1%"><P CLASS="Base2"><B>Activity</B></P>
  <TH WIDTH="1%"><P CLASS="Base2"><B>Order</B></P>
  <TH WIDTH="50%"><P CLASS="Base2"><B>Description</B></P>
  <TR>
    <TD><P CLASS="Base2"><A HREF="#TRG_Tr_UserRole">Tr_UserRole</A></TD>
    <TD><P CLASS="Base2">BEFORE&nbsp;INSERT</TD>
    <TD><P CLASS="Base2">Yes</TD>
    <TD ALIGN="right"><P CLASS="Base2">0</TD>
    <TD><P CLASS="Base2">&nbsp</TD>
  </TR>
</TABLE>
<P CLASS="Base">&nbsp;</P>
<P CLASS="Header1">Indices</P>
<TABLE CLASS="dtArg" CELLSPACING="0">
  <TH><P CLASS="Base2"><B>Index</B></P>
  <TH><P CLASS="Base2"><B>Fields</B></P>
  <TH ALIGN="middle"><P CLASS="Base2"><B>Active</B></P>
  <TH ALIGN="middle"><P CLASS="Base2"><B>Unique</B></P>
  <TH ALIGN="middle"><P CLASS="Base2"><B>Order</B></P>
  <TR>
    <TD><P CLASS="Base2"><A HREF="#IND_PK_UserRoleId">PK_UserRoleId</A></TD>
    <TD><P CLASS="Base2">"Id"</TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/Yes.gif" BORDER="0"></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/Yes.gif" BORDER="0"></TD>
    <TD ALIGN="middle"><P CLASS="Base2">ASC</TD>
  </TR>
</TABLE>
<P CLASS="Base">&nbsp;</P>
<P CLASS="Header1">References</P>
<P CLASS="Base"><I>(There are no references for table UserRole)</I></P>
<P CLASS="Base">&nbsp;</P>
<P CLASS="Header1">Referenced By</P>
<TABLE CLASS="dtArg" CELLSPACING="0">
  <TH><P CLASS="Base2"><B>Table</B></P>
  <TH><P CLASS="Base2"><B>Foreign Key</B></P>
  <TH><P CLASS="Base2"><B>Fields</B></P>
  <TH><P CLASS="Base2"><B>FK Field</B></P>
  <TH><P CLASS="Base2"><B>Delete Rule</B></P>
  <TH><P CLASS="Base2"><B>Update Rule</B></P>
  <TR>
    <TD><P CLASS="Base2"><A HREF="#TBL_Users">Users</A></TD>
    <TD><P CLASS="Base2"><A HREF="#FKEY_FK_Users_RoleId">FK_Users_RoleId</A></TD>
    <TD><P CLASS="Base2">RoleId</TD>
    <TD><P CLASS="Base2">Id</TD>
    <TD><P CLASS="Base2">NO ACTION</TD>
    <TD><P CLASS="Base2">NO ACTION</TD>
  </TR>
</TABLE>
<P CLASS="Base">&nbsp;</P>
<P CLASS="Header1">Definition</P>
<P CLASS="Base"><span class="DDLCode">
<code><pre>
<b>CREATE</b><b> </b><b>TABLE</b><b> </b><font color="# 080 0"><u>&quot;UserRole&quot;</u></font><b> </b><b>(</b>
<b>    </b>&quot;Id&quot;<b>        </b><b>INTEGER</b><b> </b><b>NOT</b><b> </b><b>NULL</b><b>,</b>
<b>    </b>&quot;RoleName&quot;<b>  </b><b>VARCHAR</b><b>(</b>20<b>)</b>
<b>)</b><b>;</b>


<b>ALTER</b><b> </b><b>TABLE</b><b> </b><font color="# 080 0"><u>&quot;UserRole&quot;</u></font><b> </b><b>ADD</b><b> </b><b>CONSTRAINT</b><b> </b>&quot;PK_UserRoleId&quot;<b> </b><b>PRIMARY</b><b> </b><b>KEY</b><b> </b><b>(</b>&quot;Id&quot;<b>)</b><b>;</b>

</pre></code>
</span></P>
<P CLASS="Base">&nbsp;</P>

<HR>
<A NAME="TBL_Users"><P CLASS="Header0">Table: Users</P><P CLASS="Base">&nbsp;</P>
<P CLASS="Header1">Description</P>
<P CLASS="Base"><I>(There is no description for table Users)</I></P>
<P CLASS="Base">&nbsp;</P>
<P CLASS="Header1">Fields</P>
<TABLE CLASS="dtArg" CELLSPACING="0">
  <TH WIDTH="1%" ALIGN="middle"><P CLASS="Base2"><B>PK</B></P>
  <TH WIDTH="1%" ALIGN="middle"><P CLASS="Base2"><B>FK</B></P>
  <TH WIDTH="1%"><P CLASS="Base2"><B>Field</B></P>
  <TH WIDTH="1%"><P CLASS="Base2"><B>Domain</B></P>
  <TH WIDTH="20%"><P CLASS="Base2"><B>Type</B></P>
  <TH WIDTH="1%" ALIGN="middle"><P CLASS="Base2"><B>NN</B></P>
  <TH WIDTH="1%"><P CLASS="Base2"><B>Default</B></P>
  <TH WIDTH="40%"><P CLASS="Base2"><B>Description</B></P>
  <TR>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/PK1.gif" BORDER="0"></P></TD>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD><A NAME="Users.Id"><P CLASS="Base2">Id</P></A></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">INTEGER</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/Yes.gif" BORDER="0"></P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
  </TR>
  <TR>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD><A NAME="Users.Login"><P CLASS="Base2">Login</P></A></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">VARCHAR(20)</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
  </TR>
  <TR>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD><A NAME="Users.Pass"><P CLASS="Base2">Pass</P></A></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">VARCHAR(10)</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
  </TR>
  <TR>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD><A NAME="Users.Name"><P CLASS="Base2">Name</P></A></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">VARCHAR(50)</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
  </TR>
  <TR>
    <TD ALIGN="middle"><P CLASS="Base2">&nbsp;</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/FK.gif" BORDER="0"></P></TD>
    <TD><A NAME="Users.RoleId"><P CLASS="Base2">RoleId</P></A></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">SMALLINT</P></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
    <TD><P CLASS="Base2">&nbsp;</P></TD>
  </TR>
</TABLE>
<P CLASS="Base">&nbsp;</P>
<P CLASS="Header1">Triggers</P>
<TABLE CLASS="dtArg" CELLSPACING="0">
  <TH WIDTH="1%"><P CLASS="Base2"><B>Trigger</B></P>
  <TH WIDTH="1%"><P CLASS="Base2"><B>Type</B></P>
  <TH WIDTH="1%"><P CLASS="Base2"><B>Activity</B></P>
  <TH WIDTH="1%"><P CLASS="Base2"><B>Order</B></P>
  <TH WIDTH="50%"><P CLASS="Base2"><B>Description</B></P>
  <TR>
    <TD><P CLASS="Base2"><A HREF="#TRG_Tr_Users">Tr_Users</A></TD>
    <TD><P CLASS="Base2">BEFORE&nbsp;INSERT</TD>
    <TD><P CLASS="Base2">Yes</TD>
    <TD ALIGN="right"><P CLASS="Base2">0</TD>
    <TD><P CLASS="Base2">&nbsp</TD>
  </TR>
</TABLE>
<P CLASS="Base">&nbsp;</P>
<P CLASS="Header1">Indices</P>
<TABLE CLASS="dtArg" CELLSPACING="0">
  <TH><P CLASS="Base2"><B>Index</B></P>
  <TH><P CLASS="Base2"><B>Fields</B></P>
  <TH ALIGN="middle"><P CLASS="Base2"><B>Active</B></P>
  <TH ALIGN="middle"><P CLASS="Base2"><B>Unique</B></P>
  <TH ALIGN="middle"><P CLASS="Base2"><B>Order</B></P>
  <TR>
    <TD><P CLASS="Base2"><A HREF="#IND_FK_Users_RoleId">FK_Users_RoleId</A></TD>
    <TD><P CLASS="Base2">"RoleId"</TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/Yes.gif" BORDER="0"></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></TD>
    <TD ALIGN="middle"><P CLASS="Base2">ASC</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2"><A HREF="#IND_PK_UserId">PK_UserId</A></TD>
    <TD><P CLASS="Base2">"Id"</TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/Yes.gif" BORDER="0"></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/Yes.gif" BORDER="0"></TD>
    <TD ALIGN="middle"><P CLASS="Base2">ASC</TD>
  </TR>
</TABLE>
<P CLASS="Base">&nbsp;</P>
<P CLASS="Header1">References</P>
<TABLE CLASS="dtArg" CELLSPACING="0">
  <TH><P CLASS="Base2"><B>Table</B></P>
  <TH><P CLASS="Base2"><B>Foreign Key</B></P>
  <TH><P CLASS="Base2"><B>Fields</B></P>
  <TH><P CLASS="Base2"><B>FK Field</B></P>
  <TH><P CLASS="Base2"><B>Delete Rule</B></P>
  <TH><P CLASS="Base2"><B>Update Rule</B></P>
  <TR>
    <TD><P CLASS="Base2"><A HREF="#TBL_UserRole">UserRole</A></TD>
    <TD><P CLASS="Base2"><A HREF="#FKEY_FK_Users_RoleId">FK_Users_RoleId</A></TD>
    <TD><P CLASS="Base2">RoleId</TD>
    <TD><P CLASS="Base2">Id</TD>
    <TD><P CLASS="Base2">NO ACTION</TD>
    <TD><P CLASS="Base2">NO ACTION</TD>
  </TR>
</TABLE>
<P CLASS="Base">&nbsp;</P>
<P CLASS="Header1">Referenced By</P>
<TABLE CLASS="dtArg" CELLSPACING="0">
  <TH><P CLASS="Base2"><B>Table</B></P>
  <TH><P CLASS="Base2"><B>Foreign Key</B></P>
  <TH><P CLASS="Base2"><B>Fields</B></P>
  <TH><P CLASS="Base2"><B>FK Field</B></P>
  <TH><P CLASS="Base2"><B>Delete Rule</B></P>
  <TH><P CLASS="Base2"><B>Update Rule</B></P>
  <TR>
    <TD><P CLASS="Base2"><A HREF="#TBL_Drawing">Drawing</A></TD>
    <TD><P CLASS="Base2"><A HREF="#FKEY_FK_Drawing_UserId">FK_Drawing_UserId</A></TD>
    <TD><P CLASS="Base2">UserId</TD>
    <TD><P CLASS="Base2">Id</TD>
    <TD><P CLASS="Base2">NO ACTION</TD>
    <TD><P CLASS="Base2">NO ACTION</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2"><A HREF="#TBL_TechProcess001">TechProcess001</A></TD>
    <TD><P CLASS="Base2"><A HREF="#FKEY_FK_TechProcess001_UserId">FK_TechProcess001_UserId</A></TD>
    <TD><P CLASS="Base2">UserId</TD>
    <TD><P CLASS="Base2">Id</TD>
    <TD><P CLASS="Base2">NO ACTION</TD>
    <TD><P CLASS="Base2">NO ACTION</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2"><A HREF="#TBL_TechProcess002">TechProcess002</A></TD>
    <TD><P CLASS="Base2"><A HREF="#FKEY_FK_TechProcess002_UserId">FK_TechProcess002_UserId</A></TD>
    <TD><P CLASS="Base2">UserId</TD>
    <TD><P CLASS="Base2">Id</TD>
    <TD><P CLASS="Base2">NO ACTION</TD>
    <TD><P CLASS="Base2">NO ACTION</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2"><A HREF="#TBL_TechProcess003">TechProcess003</A></TD>
    <TD><P CLASS="Base2"><A HREF="#FKEY_FK_TechProcess003_UserId">FK_TechProcess003_UserId</A></TD>
    <TD><P CLASS="Base2">UserId</TD>
    <TD><P CLASS="Base2">Id</TD>
    <TD><P CLASS="Base2">NO ACTION</TD>
    <TD><P CLASS="Base2">NO ACTION</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2"><A HREF="#TBL_TechProcess004">TechProcess004</A></TD>
    <TD><P CLASS="Base2"><A HREF="#FKEY_FK_TechProcess004_UserId">FK_TechProcess004_UserId</A></TD>
    <TD><P CLASS="Base2">UserId</TD>
    <TD><P CLASS="Base2">Id</TD>
    <TD><P CLASS="Base2">NO ACTION</TD>
    <TD><P CLASS="Base2">NO ACTION</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2"><A HREF="#TBL_TechProcess005">TechProcess005</A></TD>
    <TD><P CLASS="Base2"><A HREF="#FKEY_FK_TechProcess005_UserId">FK_TechProcess005_UserId</A></TD>
    <TD><P CLASS="Base2">UserId</TD>
    <TD><P CLASS="Base2">Id</TD>
    <TD><P CLASS="Base2">NO ACTION</TD>
    <TD><P CLASS="Base2">NO ACTION</TD>
  </TR>
</TABLE>
<P CLASS="Base">&nbsp;</P>
<P CLASS="Header1">Definition</P>
<P CLASS="Base"><span class="DDLCode">
<code><pre>
<b>CREATE</b><b> </b><b>TABLE</b><b> </b><font color="# 080 0"><u>&quot;Users&quot;</u></font><b> </b><b>(</b>
<b>    </b>&quot;Id&quot;<b>      </b><b>INTEGER</b><b> </b><b>NOT</b><b> </b><b>NULL</b><b>,</b>
<b>    </b>&quot;Login&quot;<b>   </b><b>VARCHAR</b><b>(</b>20<b>)</b><b>,</b>
<b>    </b>&quot;Pass&quot;<b>    </b><b>VARCHAR</b><b>(</b>10<b>)</b><b>,</b>
<b>    </b>&quot;Name&quot;<b>    </b><b>VARCHAR</b><b>(</b>50<b>)</b><b> </b><b>CHARACTER</b><b> </b><b>SET</b><b> </b>WIN1251<b>,</b>
<b>    </b>&quot;RoleId&quot;<b>  </b><b>SMALLINT</b>
<b>)</b><b>;</b>


<b>ALTER</b><b> </b><b>TABLE</b><b> </b><font color="# 080 0"><u>&quot;Users&quot;</u></font><b> </b><b>ADD</b><b> </b><b>CONSTRAINT</b><b> </b>&quot;PK_UserId&quot;<b> </b><b>PRIMARY</b><b> </b><b>KEY</b><b> </b><b>(</b>&quot;Id&quot;<b>)</b><b>;</b>
<b>ALTER</b><b> </b><b>TABLE</b><b> </b><font color="# 080 0"><u>&quot;Users&quot;</u></font><b> </b><b>ADD</b><b> </b><b>CONSTRAINT</b><b> </b>&quot;FK_Users_RoleId&quot;<b> </b><b>FOREIGN</b><b> </b><b>KEY</b><b> </b><b>(</b>&quot;RoleId&quot;<b>)</b><b> </b><b>REFERENCES</b><b> </b><font color="# 080 0"><u>&quot;UserRole&quot;</u></font><b> </b><b>(</b>&quot;Id&quot;<b>)</b><b>;</b>

</pre></code>
</span></P>
<P CLASS="Base">&nbsp;</P>

<HR>
<A NAME="_VIEWS"><P CLASS="Header0">Views</P></A>
<P CLASS="Base">&nbsp;</P>
<TABLE CLASS="dtArg" CELLSPACING="0">
  <TH WIDTH="1%"><P CLASS="Base2"><B>View</B></P>
  <TH><P CLASS="Base2"><B>Description</B></P>
</TABLE>

<HR>
<A NAME="_TRIGGERS"><P CLASS="Header0">Triggers</P></A>
<P CLASS="Base">&nbsp;</P>
<TABLE CLASS="dtArg" CELLSPACING="0">
  <TH WIDTH="1%"><P CLASS="Base2"><B>Trigger</B></P>
  <TH WIDTH="1%"><P CLASS="Base2"><B>Table</B></P>
  <TH WIDTH="1%"><P CLASS="Base2"><B>Type</B></P>
  <TH WIDTH="1%"><P CLASS="Base2"><B>Active</B></P>
  <TH WIDTH="1%"><P CLASS="Base2"><B>Position</B></P>
  <TH WIDTH="40%"><P CLASS="Base2"><B>Description</B></P>
  <TR>
    <TD><P CLASS="Base2"><A HREF="#TRG_Tr_BIO_DrawingScan">Tr_BIO_DrawingScan</A></TD>
    <TD><P CLASS="Base2"><A HREF="#TBL_DrawingScan">DrawingScan</A></TD>
    <TD><P CLASS="Base2">BEFORE&nbsp;INSERT</TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/Yes.gif" BORDER="0"></TD>
    <TD ALIGN="right"><P CLASS="Base2">0</TD>
    <TD><P CLASS="Base2">&nbsp</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2"><A HREF="#TRG_Tr_Colors">Tr_Colors</A></TD>
    <TD><P CLASS="Base2"><A HREF="#TBL_Colors">Colors</A></TD>
    <TD><P CLASS="Base2">BEFORE&nbsp;INSERT</TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/Yes.gif" BORDER="0"></TD>
    <TD ALIGN="right"><P CLASS="Base2">0</TD>
    <TD><P CLASS="Base2">&nbsp</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2"><A HREF="#TRG_Tr_Details">Tr_Details</A></TD>
    <TD><P CLASS="Base2"><A HREF="#TBL_Details">Details</A></TD>
    <TD><P CLASS="Base2">BEFORE&nbsp;INSERT</TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/Yes.gif" BORDER="0"></TD>
    <TD ALIGN="right"><P CLASS="Base2">0</TD>
    <TD><P CLASS="Base2">&nbsp</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2"><A HREF="#TRG_Tr_Drawing">Tr_Drawing</A></TD>
    <TD><P CLASS="Base2"><A HREF="#TBL_Drawing">Drawing</A></TD>
    <TD><P CLASS="Base2">BEFORE&nbsp;INSERT</TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/Yes.gif" BORDER="0"></TD>
    <TD ALIGN="right"><P CLASS="Base2">0</TD>
    <TD><P CLASS="Base2">&nbsp</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2"><A HREF="#TRG_Tr_Drawings">Tr_Drawings</A></TD>
    <TD><P CLASS="Base2"><A HREF="#TBL_Drawings">Drawings</A></TD>
    <TD><P CLASS="Base2">BEFORE&nbsp;INSERT</TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/Yes.gif" BORDER="0"></TD>
    <TD ALIGN="right"><P CLASS="Base2">0</TD>
    <TD><P CLASS="Base2">&nbsp</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2"><A HREF="#TRG_Tr_Materials">Tr_Materials</A></TD>
    <TD><P CLASS="Base2"><A HREF="#TBL_Materials">Materials</A></TD>
    <TD><P CLASS="Base2">BEFORE&nbsp;INSERT</TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/Yes.gif" BORDER="0"></TD>
    <TD ALIGN="right"><P CLASS="Base2">0</TD>
    <TD><P CLASS="Base2">&nbsp</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2"><A HREF="#TRG_Tr_OperationName">Tr_OperationName</A></TD>
    <TD><P CLASS="Base2"><A HREF="#TBL_OperationName">OperationName</A></TD>
    <TD><P CLASS="Base2">BEFORE&nbsp;INSERT</TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/Yes.gif" BORDER="0"></TD>
    <TD ALIGN="right"><P CLASS="Base2">0</TD>
    <TD><P CLASS="Base2">&nbsp</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2"><A HREF="#TRG_Tr_OperationNumber">Tr_OperationNumber</A></TD>
    <TD><P CLASS="Base2"><A HREF="#TBL_OperationNumber">OperationNumber</A></TD>
    <TD><P CLASS="Base2">BEFORE&nbsp;INSERT</TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/Yes.gif" BORDER="0"></TD>
    <TD ALIGN="right"><P CLASS="Base2">0</TD>
    <TD><P CLASS="Base2">&nbsp</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2"><A HREF="#TRG_Tr_OperationPaintMaterial">Tr_OperationPaintMaterial</A></TD>
    <TD><P CLASS="Base2"><A HREF="#TBL_OperationPaintMaterial">OperationPaintMaterial</A></TD>
    <TD><P CLASS="Base2">BEFORE&nbsp;INSERT</TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/Yes.gif" BORDER="0"></TD>
    <TD ALIGN="right"><P CLASS="Base2">0</TD>
    <TD><P CLASS="Base2">&nbsp</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2"><A HREF="#TRG_Tr_RevisionType">Tr_RevisionType</A></TD>
    <TD><P CLASS="Base2"><A HREF="#TBL_RevisionType">RevisionType</A></TD>
    <TD><P CLASS="Base2">BEFORE&nbsp;INSERT</TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/Yes.gif" BORDER="0"></TD>
    <TD ALIGN="right"><P CLASS="Base2">0</TD>
    <TD><P CLASS="Base2">&nbsp</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2"><A HREF="#TRG_Tr_Revisions">Tr_Revisions</A></TD>
    <TD><P CLASS="Base2"><A HREF="#TBL_Revisions">Revisions</A></TD>
    <TD><P CLASS="Base2">BEFORE&nbsp;INSERT</TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/Yes.gif" BORDER="0"></TD>
    <TD ALIGN="right"><P CLASS="Base2">0</TD>
    <TD><P CLASS="Base2">&nbsp</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2"><A HREF="#TRG_Tr_TechProcess001">Tr_TechProcess001</A></TD>
    <TD><P CLASS="Base2"><A HREF="#TBL_TechProcess001">TechProcess001</A></TD>
    <TD><P CLASS="Base2">BEFORE&nbsp;INSERT</TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/Yes.gif" BORDER="0"></TD>
    <TD ALIGN="right"><P CLASS="Base2">0</TD>
    <TD><P CLASS="Base2">&nbsp</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2"><A HREF="#TRG_Tr_TechProcess002">Tr_TechProcess002</A></TD>
    <TD><P CLASS="Base2"><A HREF="#TBL_TechProcess002">TechProcess002</A></TD>
    <TD><P CLASS="Base2">BEFORE&nbsp;INSERT</TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/Yes.gif" BORDER="0"></TD>
    <TD ALIGN="right"><P CLASS="Base2">0</TD>
    <TD><P CLASS="Base2">&nbsp</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2"><A HREF="#TRG_Tr_TechProcess003">Tr_TechProcess003</A></TD>
    <TD><P CLASS="Base2"><A HREF="#TBL_TechProcess003">TechProcess003</A></TD>
    <TD><P CLASS="Base2">BEFORE&nbsp;INSERT</TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/Yes.gif" BORDER="0"></TD>
    <TD ALIGN="right"><P CLASS="Base2">0</TD>
    <TD><P CLASS="Base2">&nbsp</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2"><A HREF="#TRG_Tr_TechProcess004">Tr_TechProcess004</A></TD>
    <TD><P CLASS="Base2"><A HREF="#TBL_TechProcess004">TechProcess004</A></TD>
    <TD><P CLASS="Base2">BEFORE&nbsp;INSERT</TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/Yes.gif" BORDER="0"></TD>
    <TD ALIGN="right"><P CLASS="Base2">0</TD>
    <TD><P CLASS="Base2">&nbsp</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2"><A HREF="#TRG_Tr_TechProcess005">Tr_TechProcess005</A></TD>
    <TD><P CLASS="Base2"><A HREF="#TBL_TechProcess005">TechProcess005</A></TD>
    <TD><P CLASS="Base2">BEFORE&nbsp;INSERT</TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/Yes.gif" BORDER="0"></TD>
    <TD ALIGN="right"><P CLASS="Base2">0</TD>
    <TD><P CLASS="Base2">&nbsp</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2"><A HREF="#TRG_Tr_Type">Tr_Type</A></TD>
    <TD><P CLASS="Base2"><A HREF="#TBL_Type">Type</A></TD>
    <TD><P CLASS="Base2">BEFORE&nbsp;INSERT</TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/Yes.gif" BORDER="0"></TD>
    <TD ALIGN="right"><P CLASS="Base2">0</TD>
    <TD><P CLASS="Base2">&nbsp</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2"><A HREF="#TRG_Tr_UserRole">Tr_UserRole</A></TD>
    <TD><P CLASS="Base2"><A HREF="#TBL_UserRole">UserRole</A></TD>
    <TD><P CLASS="Base2">BEFORE&nbsp;INSERT</TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/Yes.gif" BORDER="0"></TD>
    <TD ALIGN="right"><P CLASS="Base2">0</TD>
    <TD><P CLASS="Base2">&nbsp</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2"><A HREF="#TRG_Tr_Users">Tr_Users</A></TD>
    <TD><P CLASS="Base2"><A HREF="#TBL_Users">Users</A></TD>
    <TD><P CLASS="Base2">BEFORE&nbsp;INSERT</TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/Yes.gif" BORDER="0"></TD>
    <TD ALIGN="right"><P CLASS="Base2">0</TD>
    <TD><P CLASS="Base2">&nbsp</TD>
  </TR>
</TABLE>

<HR><A NAME="TRG_Tr_BIO_DrawingScan"><P CLASS="Header0">Trigger: Tr_BIO_DrawingScan</P><P CLASS="Base">&nbsp;</P>
<P CLASS="Header1">Description</P>
<P CLASS="Base"><I>(There is no description for trigger Tr_BIO_DrawingScan)</I></P>
<P CLASS="Base">&nbsp;</P>
<P CLASS="Header1">Definition</P>
<P CLASS="Base"><span class="DDLCode">
<code><pre>
<b>CREATE</b><b> </b><b>TRIGGER</b><b> </b><font color="# 080 0"><u>&quot;Tr_BIO_DrawingScan&quot;</u></font><b> </b><b>FOR</b><b> </b><font color="# 080 0"><u>&quot;DrawingScan&quot;</u></font>
<b>ACTIVE</b><b> </b><b>BEFORE</b><b> </b><b>INSERT</b><b> </b><b>POSITION</b><b> </b>0
<b>AS</b>
<b>begin</b>
<b>    </b><b>NEW</b><b>.</b>&quot;Id&quot;<b> </b><b>=</b><b> </b><b>NEXT</b><b> </b><b>VALUE</b><b> </b><b>FOR</b><b> </b><font color="# 080 0"><u>&quot;Seq_DrawingScanId&quot;</u></font><b>;</b>
<b>end</b>

</pre></code>
</span></P>
<P CLASS="Base">&nbsp;</P>

<HR><A NAME="TRG_Tr_Colors"><P CLASS="Header0">Trigger: Tr_Colors</P><P CLASS="Base">&nbsp;</P>
<P CLASS="Header1">Description</P>
<P CLASS="Base"><I>(There is no description for trigger Tr_Colors)</I></P>
<P CLASS="Base">&nbsp;</P>
<P CLASS="Header1">Definition</P>
<P CLASS="Base"><span class="DDLCode">
<code><pre>
<b>CREATE</b><b> </b><b>TRIGGER</b><b> </b><font color="# 080 0"><u>&quot;Tr_Colors&quot;</u></font><b> </b><b>FOR</b><b> </b><font color="# 080 0"><u>&quot;Colors&quot;</u></font>
<b>ACTIVE</b><b> </b><b>BEFORE</b><b> </b><b>INSERT</b><b> </b><b>POSITION</b><b> </b>0
<b>AS</b>
<b>begin</b>
<b>    </b><b>NEW</b><b>.</b>&quot;Id&quot;<b> </b><b>=</b><b> </b><b>NEXT</b><b> </b><b>VALUE</b><b> </b><b>FOR</b><b> </b><font color="# 080 0"><u>&quot;Seq_ColorsId&quot;</u></font><b>;</b>
<b>end</b>

</pre></code>
</span></P>
<P CLASS="Base">&nbsp;</P>

<HR><A NAME="TRG_Tr_Details"><P CLASS="Header0">Trigger: Tr_Details</P><P CLASS="Base">&nbsp;</P>
<P CLASS="Header1">Description</P>
<P CLASS="Base"><I>(There is no description for trigger Tr_Details)</I></P>
<P CLASS="Base">&nbsp;</P>
<P CLASS="Header1">Definition</P>
<P CLASS="Base"><span class="DDLCode">
<code><pre>
<b>CREATE</b><b> </b><b>TRIGGER</b><b> </b><font color="# 080 0"><u>&quot;Tr_Details&quot;</u></font><b> </b><b>FOR</b><b> </b><font color="# 080 0"><u>&quot;Details&quot;</u></font>
<b>ACTIVE</b><b> </b><b>BEFORE</b><b> </b><b>INSERT</b><b> </b><b>POSITION</b><b> </b>0
<b>AS</b>
<b>begin</b>
<b>    </b><b>NEW</b><b>.</b>&quot;Id&quot;<b> </b><b>=</b><b> </b><b>NEXT</b><b> </b><b>VALUE</b><b> </b><b>FOR</b><b> </b><font color="# 080 0"><u>&quot;Seq_DetailsId&quot;</u></font><b>;</b>
<b>end</b>

</pre></code>
</span></P>
<P CLASS="Base">&nbsp;</P>

<HR><A NAME="TRG_Tr_Drawing"><P CLASS="Header0">Trigger: Tr_Drawing</P><P CLASS="Base">&nbsp;</P>
<P CLASS="Header1">Description</P>
<P CLASS="Base"><I>(There is no description for trigger Tr_Drawing)</I></P>
<P CLASS="Base">&nbsp;</P>
<P CLASS="Header1">Definition</P>
<P CLASS="Base"><span class="DDLCode">
<code><pre>
<b>CREATE</b><b> </b><b>TRIGGER</b><b> </b><font color="# 080 0"><u>&quot;Tr_Drawing&quot;</u></font><b> </b><b>FOR</b><b> </b><font color="# 080 0"><u>&quot;Drawing&quot;</u></font>
<b>ACTIVE</b><b> </b><b>BEFORE</b><b> </b><b>INSERT</b><b> </b><b>POSITION</b><b> </b>0
<b>AS</b>
<b>begin</b>
<b>    </b><b>NEW</b><b>.</b>&quot;Id&quot;<b> </b><b>=</b><b> </b><b>NEXT</b><b> </b><b>VALUE</b><b> </b><b>FOR</b><b> </b><font color="# 080 0"><u>&quot;Seq_DrawingId&quot;</u></font><b>;</b>
<b>end</b>

</pre></code>
</span></P>
<P CLASS="Base">&nbsp;</P>

<HR><A NAME="TRG_Tr_Drawings"><P CLASS="Header0">Trigger: Tr_Drawings</P><P CLASS="Base">&nbsp;</P>
<P CLASS="Header1">Description</P>
<P CLASS="Base"><I>(There is no description for trigger Tr_Drawings)</I></P>
<P CLASS="Base">&nbsp;</P>
<P CLASS="Header1">Definition</P>
<P CLASS="Base"><span class="DDLCode">
<code><pre>
<b>CREATE</b><b> </b><b>TRIGGER</b><b> </b><font color="# 080 0"><u>&quot;Tr_Drawings&quot;</u></font><b> </b><b>FOR</b><b> </b><font color="# 080 0"><u>&quot;Drawings&quot;</u></font>
<b>ACTIVE</b><b> </b><b>BEFORE</b><b> </b><b>INSERT</b><b> </b><b>POSITION</b><b> </b>0
<b>AS</b>
<b>begin</b>
<b>    </b><b>NEW</b><b>.</b>&quot;Id&quot;<b> </b><b>=</b><b> </b><b>NEXT</b><b> </b><b>VALUE</b><b> </b><b>FOR</b><b> </b><font color="# 080 0"><u>&quot;Seq_DrawingsId&quot;</u></font><b>;</b>
<b>end</b>

</pre></code>
</span></P>
<P CLASS="Base">&nbsp;</P>

<HR><A NAME="TRG_Tr_Materials"><P CLASS="Header0">Trigger: Tr_Materials</P><P CLASS="Base">&nbsp;</P>
<P CLASS="Header1">Description</P>
<P CLASS="Base"><I>(There is no description for trigger Tr_Materials)</I></P>
<P CLASS="Base">&nbsp;</P>
<P CLASS="Header1">Definition</P>
<P CLASS="Base"><span class="DDLCode">
<code><pre>
<b>CREATE</b><b> </b><b>TRIGGER</b><b> </b><font color="# 080 0"><u>&quot;Tr_Materials&quot;</u></font><b> </b><b>FOR</b><b> </b><font color="# 080 0"><u>&quot;Materials&quot;</u></font>
<b>ACTIVE</b><b> </b><b>BEFORE</b><b> </b><b>INSERT</b><b> </b><b>POSITION</b><b> </b>0
<b>AS</b>
<b>begin</b>
<b>    </b><b>NEW</b><b>.</b>&quot;Id&quot;<b> </b><b>=</b><b> </b><b>NEXT</b><b> </b><b>VALUE</b><b> </b><b>FOR</b><b> </b><font color="# 080 0"><u>&quot;Seq_MaterialsId&quot;</u></font><b>;</b>
<b>end</b>

</pre></code>
</span></P>
<P CLASS="Base">&nbsp;</P>

<HR><A NAME="TRG_Tr_OperationName"><P CLASS="Header0">Trigger: Tr_OperationName</P><P CLASS="Base">&nbsp;</P>
<P CLASS="Header1">Description</P>
<P CLASS="Base"><I>(There is no description for trigger Tr_OperationName)</I></P>
<P CLASS="Base">&nbsp;</P>
<P CLASS="Header1">Definition</P>
<P CLASS="Base"><span class="DDLCode">
<code><pre>
<b>CREATE</b><b> </b><b>TRIGGER</b><b> </b><font color="# 080 0"><u>&quot;Tr_OperationName&quot;</u></font><b> </b><b>FOR</b><b> </b><font color="# 080 0"><u>&quot;OperationName&quot;</u></font>
<b>ACTIVE</b><b> </b><b>BEFORE</b><b> </b><b>INSERT</b><b> </b><b>POSITION</b><b> </b>0
<b>AS</b>
<b>begin</b>
<b>    </b><b>NEW</b><b>.</b>&quot;Id&quot;<b> </b><b>=</b><b> </b><b>NEXT</b><b> </b><b>VALUE</b><b> </b><b>FOR</b><b> </b><font color="# 080 0"><u>&quot;Seq_OperationNameId&quot;</u></font><b>;</b>
<b>end</b>

</pre></code>
</span></P>
<P CLASS="Base">&nbsp;</P>

<HR><A NAME="TRG_Tr_OperationNumber"><P CLASS="Header0">Trigger: Tr_OperationNumber</P><P CLASS="Base">&nbsp;</P>
<P CLASS="Header1">Description</P>
<P CLASS="Base"><I>(There is no description for trigger Tr_OperationNumber)</I></P>
<P CLASS="Base">&nbsp;</P>
<P CLASS="Header1">Definition</P>
<P CLASS="Base"><span class="DDLCode">
<code><pre>
<b>CREATE</b><b> </b><b>TRIGGER</b><b> </b><font color="# 080 0"><u>&quot;Tr_OperationNumber&quot;</u></font><b> </b><b>FOR</b><b> </b><font color="# 080 0"><u>&quot;OperationNumber&quot;</u></font>
<b>ACTIVE</b><b> </b><b>BEFORE</b><b> </b><b>INSERT</b><b> </b><b>POSITION</b><b> </b>0
<b>AS</b>
<b>begin</b>
<b>    </b><b>NEW</b><b>.</b>&quot;Id&quot;<b> </b><b>=</b><b> </b><b>NEXT</b><b> </b><b>VALUE</b><b> </b><b>FOR</b><b> </b><font color="# 080 0"><u>&quot;Seq_OperatioNumberId&quot;</u></font><b>;</b>
<b>end</b>

</pre></code>
</span></P>
<P CLASS="Base">&nbsp;</P>

<HR><A NAME="TRG_Tr_OperationPaintMaterial"><P CLASS="Header0">Trigger: Tr_OperationPaintMaterial</P><P CLASS="Base">&nbsp;</P>
<P CLASS="Header1">Description</P>
<P CLASS="Base"><I>(There is no description for trigger Tr_OperationPaintMaterial)</I></P>
<P CLASS="Base">&nbsp;</P>
<P CLASS="Header1">Definition</P>
<P CLASS="Base"><span class="DDLCode">
<code><pre>
<b>CREATE</b><b> </b><b>TRIGGER</b><b> </b><font color="# 080 0"><u>&quot;Tr_OperationPaintMaterial&quot;</u></font><b> </b><b>FOR</b><b> </b><font color="# 080 0"><u>&quot;OperationPaintMaterial&quot;</u></font>
<b>ACTIVE</b><b> </b><b>BEFORE</b><b> </b><b>INSERT</b><b> </b><b>POSITION</b><b> </b>0
<b>AS</b>
<b>begin</b>
<b>    </b><b>NEW</b><b>.</b>&quot;Id&quot;<b> </b><b>=</b><b> </b><b>NEXT</b><b> </b><b>VALUE</b><b> </b><b>FOR</b><b> </b><font color="# 080 0"><u>&quot;Seq_OperationPaintMaterialId&quot;</u></font><b>;</b>
<b>end</b>

</pre></code>
</span></P>
<P CLASS="Base">&nbsp;</P>

<HR><A NAME="TRG_Tr_RevisionType"><P CLASS="Header0">Trigger: Tr_RevisionType</P><P CLASS="Base">&nbsp;</P>
<P CLASS="Header1">Description</P>
<P CLASS="Base"><I>(There is no description for trigger Tr_RevisionType)</I></P>
<P CLASS="Base">&nbsp;</P>
<P CLASS="Header1">Definition</P>
<P CLASS="Base"><span class="DDLCode">
<code><pre>
<b>CREATE</b><b> </b><b>TRIGGER</b><b> </b><font color="# 080 0"><u>&quot;Tr_RevisionType&quot;</u></font><b> </b><b>FOR</b><b> </b><font color="# 080 0"><u>&quot;RevisionType&quot;</u></font>
<b>ACTIVE</b><b> </b><b>BEFORE</b><b> </b><b>INSERT</b><b> </b><b>POSITION</b><b> </b>0
<b>AS</b>
<b>begin</b>
<b>    </b><b>NEW</b><b>.</b>&quot;Id&quot;<b> </b><b>=</b><b> </b><b>NEXT</b><b> </b><b>VALUE</b><b> </b><b>FOR</b><b> </b><font color="# 080 0"><u>&quot;Seq_RevisionTypeId&quot;</u></font><b>;</b>
<b>end</b>

</pre></code>
</span></P>
<P CLASS="Base">&nbsp;</P>

<HR><A NAME="TRG_Tr_Revisions"><P CLASS="Header0">Trigger: Tr_Revisions</P><P CLASS="Base">&nbsp;</P>
<P CLASS="Header1">Description</P>
<P CLASS="Base"><I>(There is no description for trigger Tr_Revisions)</I></P>
<P CLASS="Base">&nbsp;</P>
<P CLASS="Header1">Definition</P>
<P CLASS="Base"><span class="DDLCode">
<code><pre>
<b>CREATE</b><b> </b><b>TRIGGER</b><b> </b><font color="# 080 0"><u>&quot;Tr_Revisions&quot;</u></font><b> </b><b>FOR</b><b> </b><font color="# 080 0"><u>&quot;Revisions&quot;</u></font>
<b>ACTIVE</b><b> </b><b>BEFORE</b><b> </b><b>INSERT</b><b> </b><b>POSITION</b><b> </b>0
<b>AS</b>
<b>begin</b>
<b>    </b><b>NEW</b><b>.</b>&quot;Id&quot;<b> </b><b>=</b><b> </b><b>NEXT</b><b> </b><b>VALUE</b><b> </b><b>FOR</b><b> </b><font color="# 080 0"><u>&quot;Seq_RevisionsId&quot;</u></font><b>;</b>
<b>end</b>

</pre></code>
</span></P>
<P CLASS="Base">&nbsp;</P>

<HR><A NAME="TRG_Tr_TechProcess001"><P CLASS="Header0">Trigger: Tr_TechProcess001</P><P CLASS="Base">&nbsp;</P>
<P CLASS="Header1">Description</P>
<P CLASS="Base"><I>(There is no description for trigger Tr_TechProcess001)</I></P>
<P CLASS="Base">&nbsp;</P>
<P CLASS="Header1">Definition</P>
<P CLASS="Base"><span class="DDLCode">
<code><pre>
<b>CREATE</b><b> </b><b>TRIGGER</b><b> </b><font color="# 080 0"><u>&quot;Tr_TechProcess001&quot;</u></font><b> </b><b>FOR</b><b> </b><font color="# 080 0"><u>&quot;TechProcess001&quot;</u></font>
<b>ACTIVE</b><b> </b><b>BEFORE</b><b> </b><b>INSERT</b><b> </b><b>POSITION</b><b> </b>0
<b>AS</b>
<b>begin</b>
<b>    </b><b>NEW</b><b>.</b>&quot;Id&quot;<b> </b><b>=</b><b> </b><b>NEXT</b><b> </b><b>VALUE</b><b> </b><b>FOR</b><b> </b><font color="# 080 0"><u>&quot;Seq_TechProcess001Id&quot;</u></font><b>;</b>
<b>end</b>

</pre></code>
</span></P>
<P CLASS="Base">&nbsp;</P>

<HR><A NAME="TRG_Tr_TechProcess002"><P CLASS="Header0">Trigger: Tr_TechProcess002</P><P CLASS="Base">&nbsp;</P>
<P CLASS="Header1">Description</P>
<P CLASS="Base"><I>(There is no description for trigger Tr_TechProcess002)</I></P>
<P CLASS="Base">&nbsp;</P>
<P CLASS="Header1">Definition</P>
<P CLASS="Base"><span class="DDLCode">
<code><pre>
<b>CREATE</b><b> </b><b>TRIGGER</b><b> </b><font color="# 080 0"><u>&quot;Tr_TechProcess002&quot;</u></font><b> </b><b>FOR</b><b> </b><font color="# 080 0"><u>&quot;TechProcess002&quot;</u></font>
<b>ACTIVE</b><b> </b><b>BEFORE</b><b> </b><b>INSERT</b><b> </b><b>POSITION</b><b> </b>0
<b>AS</b>
<b>begin</b>
<b>    </b><b>NEW</b><b>.</b>&quot;Id&quot;<b> </b><b>=</b><b> </b><b>NEXT</b><b> </b><b>VALUE</b><b> </b><b>FOR</b><b> </b><font color="# 080 0"><u>&quot;Seq_TechProcess002Id&quot;</u></font><b>;</b>
<b>end</b>

</pre></code>
</span></P>
<P CLASS="Base">&nbsp;</P>

<HR><A NAME="TRG_Tr_TechProcess003"><P CLASS="Header0">Trigger: Tr_TechProcess003</P><P CLASS="Base">&nbsp;</P>
<P CLASS="Header1">Description</P>
<P CLASS="Base"><I>(There is no description for trigger Tr_TechProcess003)</I></P>
<P CLASS="Base">&nbsp;</P>
<P CLASS="Header1">Definition</P>
<P CLASS="Base"><span class="DDLCode">
<code><pre>
<b>CREATE</b><b> </b><b>TRIGGER</b><b> </b><font color="# 080 0"><u>&quot;Tr_TechProcess003&quot;</u></font><b> </b><b>FOR</b><b> </b><font color="# 080 0"><u>&quot;TechProcess003&quot;</u></font>
<b>ACTIVE</b><b> </b><b>BEFORE</b><b> </b><b>INSERT</b><b> </b><b>POSITION</b><b> </b>0
<b>AS</b>
<b>begin</b>
<b>    </b><b>NEW</b><b>.</b>&quot;Id&quot;<b> </b><b>=</b><b> </b><b>NEXT</b><b> </b><b>VALUE</b><b> </b><b>FOR</b><b> </b><font color="# 080 0"><u>&quot;Seq_TechProcess003Id&quot;</u></font><b>;</b>
<b>end</b>

</pre></code>
</span></P>
<P CLASS="Base">&nbsp;</P>

<HR><A NAME="TRG_Tr_TechProcess004"><P CLASS="Header0">Trigger: Tr_TechProcess004</P><P CLASS="Base">&nbsp;</P>
<P CLASS="Header1">Description</P>
<P CLASS="Base"><I>(There is no description for trigger Tr_TechProcess004)</I></P>
<P CLASS="Base">&nbsp;</P>
<P CLASS="Header1">Definition</P>
<P CLASS="Base"><span class="DDLCode">
<code><pre>
<b>CREATE</b><b> </b><b>TRIGGER</b><b> </b><font color="# 080 0"><u>&quot;Tr_TechProcess004&quot;</u></font><b> </b><b>FOR</b><b> </b><font color="# 080 0"><u>&quot;TechProcess004&quot;</u></font>
<b>ACTIVE</b><b> </b><b>BEFORE</b><b> </b><b>INSERT</b><b> </b><b>POSITION</b><b> </b>0
<b>AS</b>
<b>begin</b>
<b>    </b><b>NEW</b><b>.</b>&quot;Id&quot;<b> </b><b>=</b><b> </b><b>NEXT</b><b> </b><b>VALUE</b><b> </b><b>FOR</b><b> </b><font color="# 080 0"><u>&quot;Seq_TechProcess004Id&quot;</u></font><b>;</b>
<b>end</b>

</pre></code>
</span></P>
<P CLASS="Base">&nbsp;</P>

<HR><A NAME="TRG_Tr_TechProcess005"><P CLASS="Header0">Trigger: Tr_TechProcess005</P><P CLASS="Base">&nbsp;</P>
<P CLASS="Header1">Description</P>
<P CLASS="Base"><I>(There is no description for trigger Tr_TechProcess005)</I></P>
<P CLASS="Base">&nbsp;</P>
<P CLASS="Header1">Definition</P>
<P CLASS="Base"><span class="DDLCode">
<code><pre>
<b>CREATE</b><b> </b><b>TRIGGER</b><b> </b><font color="# 080 0"><u>&quot;Tr_TechProcess005&quot;</u></font><b> </b><b>FOR</b><b> </b><font color="# 080 0"><u>&quot;TechProcess005&quot;</u></font>
<b>ACTIVE</b><b> </b><b>BEFORE</b><b> </b><b>INSERT</b><b> </b><b>POSITION</b><b> </b>0
<b>AS</b>
<b>begin</b>
<b>    </b><b>NEW</b><b>.</b>&quot;Id&quot;<b> </b><b>=</b><b> </b><b>NEXT</b><b> </b><b>VALUE</b><b> </b><b>FOR</b><b> </b><font color="# 080 0"><u>&quot;Seq_TechProcess005Id&quot;</u></font><b>;</b>
<b>end</b>

</pre></code>
</span></P>
<P CLASS="Base">&nbsp;</P>

<HR><A NAME="TRG_Tr_Type"><P CLASS="Header0">Trigger: Tr_Type</P><P CLASS="Base">&nbsp;</P>
<P CLASS="Header1">Description</P>
<P CLASS="Base"><I>(There is no description for trigger Tr_Type)</I></P>
<P CLASS="Base">&nbsp;</P>
<P CLASS="Header1">Definition</P>
<P CLASS="Base"><span class="DDLCode">
<code><pre>
<b>CREATE</b><b> </b><b>TRIGGER</b><b> </b><font color="# 080 0"><u>&quot;Tr_Type&quot;</u></font><b> </b><b>FOR</b><b> </b><font color="# 080 0"><u>&quot;Type&quot;</u></font>
<b>ACTIVE</b><b> </b><b>BEFORE</b><b> </b><b>INSERT</b><b> </b><b>POSITION</b><b> </b>0
<b>AS</b>
<b>begin</b>
<b>    </b><b>NEW</b><b>.</b>&quot;Id&quot;<b> </b><b>=</b><b> </b><b>NEXT</b><b> </b><b>VALUE</b><b> </b><b>FOR</b><b> </b><font color="# 080 0"><u>&quot;Seq_DrawingTypeId&quot;</u></font><b>;</b>
<b>end</b>

</pre></code>
</span></P>
<P CLASS="Base">&nbsp;</P>

<HR><A NAME="TRG_Tr_UserRole"><P CLASS="Header0">Trigger: Tr_UserRole</P><P CLASS="Base">&nbsp;</P>
<P CLASS="Header1">Description</P>
<P CLASS="Base"><I>(There is no description for trigger Tr_UserRole)</I></P>
<P CLASS="Base">&nbsp;</P>
<P CLASS="Header1">Definition</P>
<P CLASS="Base"><span class="DDLCode">
<code><pre>
<b>CREATE</b><b> </b><b>TRIGGER</b><b> </b><font color="# 080 0"><u>&quot;Tr_UserRole&quot;</u></font><b> </b><b>FOR</b><b> </b><font color="# 080 0"><u>&quot;UserRole&quot;</u></font>
<b>ACTIVE</b><b> </b><b>BEFORE</b><b> </b><b>INSERT</b><b> </b><b>POSITION</b><b> </b>0
<b>AS</b>
<b>begin</b>
<b>    </b><b>NEW</b><b>.</b>&quot;Id&quot;<b> </b><b>=</b><b> </b><b>NEXT</b><b> </b><b>VALUE</b><b> </b><b>FOR</b><b> </b><font color="# 080 0"><u>&quot;Seq_UserRoleId&quot;</u></font><b>;</b>
<b>end</b>

</pre></code>
</span></P>
<P CLASS="Base">&nbsp;</P>

<HR><A NAME="TRG_Tr_Users"><P CLASS="Header0">Trigger: Tr_Users</P><P CLASS="Base">&nbsp;</P>
<P CLASS="Header1">Description</P>
<P CLASS="Base"><I>(There is no description for trigger Tr_Users)</I></P>
<P CLASS="Base">&nbsp;</P>
<P CLASS="Header1">Definition</P>
<P CLASS="Base"><span class="DDLCode">
<code><pre>
<b>CREATE</b><b> </b><b>TRIGGER</b><b> </b><font color="# 080 0"><u>&quot;Tr_Users&quot;</u></font><b> </b><b>FOR</b><b> </b><font color="# 080 0"><u>&quot;Users&quot;</u></font>
<b>ACTIVE</b><b> </b><b>BEFORE</b><b> </b><b>INSERT</b><b> </b><b>POSITION</b><b> </b>0
<b>AS</b>
<b>begin</b>
<b>    </b><b>NEW</b><b>.</b>&quot;Id&quot;<b> </b><b>=</b><b> </b><b>NEXT</b><b> </b><b>VALUE</b><b> </b><b>FOR</b><b> </b><font color="# 080 0"><u>&quot;Seq_UserId&quot;</u></font><b>;</b>
<b>end</b>

</pre></code>
</span></P>
<P CLASS="Base">&nbsp;</P>

<HR>
<A NAME="_PROCEDURES"><P CLASS="Header0">Procedures</P></A>
<P CLASS="Base">&nbsp;</P>
<TABLE CLASS="dtArg" CELLSPACING="0">
  <TH WIDTH="1%"><P CLASS="Base2"><B>Procedure</B></P>
  <TH WIDTH="50%"><P CLASS="Base2"><B>Description</B></P>
  <TR>
    <TD><P CLASS="Base2"><A HREF="#PROC_GetDrawings">GetDrawings</A></TD>
    <TD><P CLASS="Base2">&nbsp</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2"><A HREF="#PROC_TestProc">TestProc</A></TD>
    <TD><P CLASS="Base2">&nbsp</TD>
  </TR>
</TABLE>

<HR>
<A NAME="PROC_GetDrawings"><P CLASS="Header0">Procedure: GetDrawings</P><P CLASS="Base">&nbsp;</P>
<P CLASS="Header1">Input Parameters</P>
<TABLE CLASS="dtArg" CELLSPACING="0">
  <TH WIDTH="1%"><P CLASS="Base2"><B>Parameter</B></P>
  <TH WIDTH="20%"><P CLASS="Base2"><B>Type</B></P>
  <TH WIDTH="50%"><P CLASS="Base2"><B>Description</B></P>
  <TR>
    <TD><P CLASS="Base2">DateNow</TD>
    <TD><P CLASS="Base2">DATE</TD>
    <TD><P CLASS="Base2">&nbsp;</TD>
  </TR>
</TABLE>
<P CLASS="Base">&nbsp;</P>
<P CLASS="Header1">Output Parameters</P>
<TABLE CLASS="dtArg" CELLSPACING="0">
  <TH WIDTH="1%"><P CLASS="Base2"><B>Parameter</B></P>
  <TH WIDTH="20%"><P CLASS="Base2"><B>Type</B></P>
  <TH WIDTH="50%"><P CLASS="Base2"><B>Description</B></P>
  <TR>
    <TD><P CLASS="Base2">Id</TD>
    <TD><P CLASS="Base2">INTEGER</TD>
    <TD><P CLASS="Base2">&nbsp;</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2">ParentId</TD>
    <TD><P CLASS="Base2">INTEGER</TD>
    <TD><P CLASS="Base2">&nbsp;</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2">CurrentLevelMenu</TD>
    <TD><P CLASS="Base2">VARCHAR(100)</TD>
    <TD><P CLASS="Base2">&nbsp;</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2">DrawingId</TD>
    <TD><P CLASS="Base2">INTEGER</TD>
    <TD><P CLASS="Base2">&nbsp;</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2">ReplaceDrawingId</TD>
    <TD><P CLASS="Base2">SMALLINT</TD>
    <TD><P CLASS="Base2">&nbsp;</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2">OccurrenceId</TD>
    <TD><P CLASS="Base2">SMALLINT</TD>
    <TD><P CLASS="Base2">&nbsp;</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2">ScanId</TD>
    <TD><P CLASS="Base2">INTEGER</TD>
    <TD><P CLASS="Base2">&nbsp;</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2">Quantity</TD>
    <TD><P CLASS="Base2">NUMERIC(9,2)</TD>
    <TD><P CLASS="Base2">&nbsp;</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2">QuantityR</TD>
    <TD><P CLASS="Base2">NUMERIC(9,2)</TD>
    <TD><P CLASS="Base2">&nbsp;</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2">QuantityL</TD>
    <TD><P CLASS="Base2">NUMERIC(9,2)</TD>
    <TD><P CLASS="Base2">&nbsp;</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2">StructuraDisable</TD>
    <TD><P CLASS="Base2">SMALLINT</TD>
    <TD><P CLASS="Base2">&nbsp;</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2">Number</TD>
    <TD><P CLASS="Base2">VARCHAR(120)</TD>
    <TD><P CLASS="Base2">&nbsp;</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2">RevisionName</TD>
    <TD><P CLASS="Base2">VARCHAR(8)</TD>
    <TD><P CLASS="Base2">&nbsp;</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2">NumberWithRevisionName</TD>
    <TD><P CLASS="Base2">VARCHAR(132)</TD>
    <TD><P CLASS="Base2">&nbsp;</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2">DetailWeight</TD>
    <TD><P CLASS="Base2">NUMERIC(18,2)</TD>
    <TD><P CLASS="Base2">&nbsp;</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2">TH</TD>
    <TD><P CLASS="Base2">VARCHAR(100)</TD>
    <TD><P CLASS="Base2">&nbsp;</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2">W</TD>
    <TD><P CLASS="Base2">VARCHAR(100)</TD>
    <TD><P CLASS="Base2">&nbsp;</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2">W2</TD>
    <TD><P CLASS="Base2">VARCHAR(100)</TD>
    <TD><P CLASS="Base2">&nbsp;</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2">L</TD>
    <TD><P CLASS="Base2">VARCHAR(100)</TD>
    <TD><P CLASS="Base2">&nbsp;</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2">DetailName</TD>
    <TD><P CLASS="Base2">VARCHAR(160)</TD>
    <TD><P CLASS="Base2">&nbsp;</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2">TypeName</TD>
    <TD><P CLASS="Base2">VARCHAR(20)</TD>
    <TD><P CLASS="Base2">&nbsp;</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2">ParentName</TD>
    <TD><P CLASS="Base2">VARCHAR(120)</TD>
    <TD><P CLASS="Base2">&nbsp;</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2">MaterialName</TD>
    <TD><P CLASS="Base2">VARCHAR(100)</TD>
    <TD><P CLASS="Base2">&nbsp;</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2">NoteName</TD>
    <TD><P CLASS="Base2">VARCHAR(800)</TD>
    <TD><P CLASS="Base2">&nbsp;</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2">CreateDate</TD>
    <TD><P CLASS="Base2">DATE</TD>
    <TD><P CLASS="Base2">&nbsp;</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2">TechProcess001Id</TD>
    <TD><P CLASS="Base2">INTEGER</TD>
    <TD><P CLASS="Base2">&nbsp;</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2">TechProcess002Id</TD>
    <TD><P CLASS="Base2">INTEGER</TD>
    <TD><P CLASS="Base2">&nbsp;</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2">TechProcess003Id</TD>
    <TD><P CLASS="Base2">INTEGER</TD>
    <TD><P CLASS="Base2">&nbsp;</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2">TechProcess004Id</TD>
    <TD><P CLASS="Base2">INTEGER</TD>
    <TD><P CLASS="Base2">&nbsp;</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2">TechProcess005Id</TD>
    <TD><P CLASS="Base2">INTEGER</TD>
    <TD><P CLASS="Base2">&nbsp;</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2">TechProcess001Name</TD>
    <TD><P CLASS="Base2">BIGINT</TD>
    <TD><P CLASS="Base2">&nbsp;</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2">TechProcess002Name</TD>
    <TD><P CLASS="Base2">BIGINT</TD>
    <TD><P CLASS="Base2">&nbsp;</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2">TechProcess003Name</TD>
    <TD><P CLASS="Base2">BIGINT</TD>
    <TD><P CLASS="Base2">&nbsp;</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2">TechProcess004Name</TD>
    <TD><P CLASS="Base2">BIGINT</TD>
    <TD><P CLASS="Base2">&nbsp;</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2">TechProcess005Name</TD>
    <TD><P CLASS="Base2">BIGINT</TD>
    <TD><P CLASS="Base2">&nbsp;</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2">TechProcess001NameString</TD>
    <TD><P CLASS="Base2">VARCHAR(20)</TD>
    <TD><P CLASS="Base2">&nbsp;</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2">TechProcess002NameString</TD>
    <TD><P CLASS="Base2">VARCHAR(20)</TD>
    <TD><P CLASS="Base2">&nbsp;</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2">TechProcess003NameString</TD>
    <TD><P CLASS="Base2">VARCHAR(20)</TD>
    <TD><P CLASS="Base2">&nbsp;</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2">TechProcess004NameString</TD>
    <TD><P CLASS="Base2">VARCHAR(20)</TD>
    <TD><P CLASS="Base2">&nbsp;</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2">TechProcess005NameString</TD>
    <TD><P CLASS="Base2">VARCHAR(20)</TD>
    <TD><P CLASS="Base2">&nbsp;</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2">Revision001</TD>
    <TD><P CLASS="Base2">VARCHAR(8)</TD>
    <TD><P CLASS="Base2">&nbsp;</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2">Revision002</TD>
    <TD><P CLASS="Base2">VARCHAR(8)</TD>
    <TD><P CLASS="Base2">&nbsp;</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2">Revision003</TD>
    <TD><P CLASS="Base2">VARCHAR(8)</TD>
    <TD><P CLASS="Base2">&nbsp;</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2">Revision004</TD>
    <TD><P CLASS="Base2">VARCHAR(8)</TD>
    <TD><P CLASS="Base2">&nbsp;</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2">Revision005</TD>
    <TD><P CLASS="Base2">VARCHAR(8)</TD>
    <TD><P CLASS="Base2">&nbsp;</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2">TechProcess001Path</TD>
    <TD><P CLASS="Base2">VARCHAR(200)</TD>
    <TD><P CLASS="Base2">&nbsp;</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2">TechProcess002Path</TD>
    <TD><P CLASS="Base2">VARCHAR(200)</TD>
    <TD><P CLASS="Base2">&nbsp;</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2">TechProcess003Path</TD>
    <TD><P CLASS="Base2">VARCHAR(200)</TD>
    <TD><P CLASS="Base2">&nbsp;</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2">TechProcess004Path</TD>
    <TD><P CLASS="Base2">VARCHAR(200)</TD>
    <TD><P CLASS="Base2">&nbsp;</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2">TechProcess005Path</TD>
    <TD><P CLASS="Base2">VARCHAR(200)</TD>
    <TD><P CLASS="Base2">&nbsp;</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2">TechProcess001Old</TD>
    <TD><P CLASS="Base2">SMALLINT</TD>
    <TD><P CLASS="Base2">&nbsp;</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2">TechProcess002Old</TD>
    <TD><P CLASS="Base2">SMALLINT</TD>
    <TD><P CLASS="Base2">&nbsp;</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2">TechProcess003Old</TD>
    <TD><P CLASS="Base2">SMALLINT</TD>
    <TD><P CLASS="Base2">&nbsp;</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2">TechProcess004Old</TD>
    <TD><P CLASS="Base2">SMALLINT</TD>
    <TD><P CLASS="Base2">&nbsp;</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2">TechProcess005Old</TD>
    <TD><P CLASS="Base2">SMALLINT</TD>
    <TD><P CLASS="Base2">&nbsp;</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2">TechProcess001Type</TD>
    <TD><P CLASS="Base2">SMALLINT</TD>
    <TD><P CLASS="Base2">&nbsp;</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2">TechProcess002Type</TD>
    <TD><P CLASS="Base2">SMALLINT</TD>
    <TD><P CLASS="Base2">&nbsp;</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2">TechProcess003Type</TD>
    <TD><P CLASS="Base2">SMALLINT</TD>
    <TD><P CLASS="Base2">&nbsp;</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2">TechProcess004Type</TD>
    <TD><P CLASS="Base2">SMALLINT</TD>
    <TD><P CLASS="Base2">&nbsp;</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2">TechProcess005Type</TD>
    <TD><P CLASS="Base2">SMALLINT</TD>
    <TD><P CLASS="Base2">&nbsp;</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2">CurrentLevelMenuColorId</TD>
    <TD><P CLASS="Base2">INTEGER</TD>
    <TD><P CLASS="Base2">&nbsp;</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2">CurrentLevelMenuColorName</TD>
    <TD><P CLASS="Base2">VARCHAR(40)</TD>
    <TD><P CLASS="Base2">&nbsp;</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2">DrawingColorId</TD>
    <TD><P CLASS="Base2">INTEGER</TD>
    <TD><P CLASS="Base2">&nbsp;</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2">DrawingColorName</TD>
    <TD><P CLASS="Base2">VARCHAR(40)</TD>
    <TD><P CLASS="Base2">&nbsp;</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2">MaterialColorId</TD>
    <TD><P CLASS="Base2">INTEGER</TD>
    <TD><P CLASS="Base2">&nbsp;</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2">MaterialColorName</TD>
    <TD><P CLASS="Base2">VARCHAR(40)</TD>
    <TD><P CLASS="Base2">&nbsp;</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2">Welding20Steel</TD>
    <TD><P CLASS="Base2">NUMERIC(18,2)</TD>
    <TD><P CLASS="Base2">&nbsp;</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2">Welding20SteelTotal</TD>
    <TD><P CLASS="Base2">NUMERIC(18,4)</TD>
    <TD><P CLASS="Base2">&nbsp;</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2">Welding10</TD>
    <TD><P CLASS="Base2">NUMERIC(18,2)</TD>
    <TD><P CLASS="Base2">&nbsp;</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2">Welding10Total</TD>
    <TD><P CLASS="Base2">NUMERIC(18,4)</TD>
    <TD><P CLASS="Base2">&nbsp;</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2">Welding12</TD>
    <TD><P CLASS="Base2">NUMERIC(18,2)</TD>
    <TD><P CLASS="Base2">&nbsp;</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2">Welding12Total</TD>
    <TD><P CLASS="Base2">NUMERIC(18,4)</TD>
    <TD><P CLASS="Base2">&nbsp;</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2">Welding16</TD>
    <TD><P CLASS="Base2">NUMERIC(18,2)</TD>
    <TD><P CLASS="Base2">&nbsp;</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2">Welding16Total</TD>
    <TD><P CLASS="Base2">NUMERIC(18,4)</TD>
    <TD><P CLASS="Base2">&nbsp;</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2">Welding20</TD>
    <TD><P CLASS="Base2">NUMERIC(18,2)</TD>
    <TD><P CLASS="Base2">&nbsp;</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2">Welding20Total</TD>
    <TD><P CLASS="Base2">NUMERIC(18,4)</TD>
    <TD><P CLASS="Base2">&nbsp;</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2">GasArCO2</TD>
    <TD><P CLASS="Base2">NUMERIC(18,2)</TD>
    <TD><P CLASS="Base2">&nbsp;</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2">GasArCO2Total</TD>
    <TD><P CLASS="Base2">NUMERIC(18,4)</TD>
    <TD><P CLASS="Base2">&nbsp;</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2">GasCO3</TD>
    <TD><P CLASS="Base2">NUMERIC(18,2)</TD>
    <TD><P CLASS="Base2">&nbsp;</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2">GasCO3Total</TD>
    <TD><P CLASS="Base2">NUMERIC(18,4)</TD>
    <TD><P CLASS="Base2">&nbsp;</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2">GasAr</TD>
    <TD><P CLASS="Base2">NUMERIC(18,2)</TD>
    <TD><P CLASS="Base2">&nbsp;</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2">GasArTotal</TD>
    <TD><P CLASS="Base2">NUMERIC(18,4)</TD>
    <TD><P CLASS="Base2">&nbsp;</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2">WeldingElektrod</TD>
    <TD><P CLASS="Base2">NUMERIC(18,2)</TD>
    <TD><P CLASS="Base2">&nbsp;</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2">WeldingElektrodTotal</TD>
    <TD><P CLASS="Base2">NUMERIC(18,4)</TD>
    <TD><P CLASS="Base2">&nbsp;</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2">GasO2</TD>
    <TD><P CLASS="Base2">NUMERIC(18,2)</TD>
    <TD><P CLASS="Base2">&nbsp;</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2">GasO2Total</TD>
    <TD><P CLASS="Base2">NUMERIC(18,4)</TD>
    <TD><P CLASS="Base2">&nbsp;</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2">GasNature</TD>
    <TD><P CLASS="Base2">NUMERIC(18,2)</TD>
    <TD><P CLASS="Base2">&nbsp;</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2">GasNatureTotal</TD>
    <TD><P CLASS="Base2">NUMERIC(18,4)</TD>
    <TD><P CLASS="Base2">&nbsp;</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2">GasN2</TD>
    <TD><P CLASS="Base2">NUMERIC(18,2)</TD>
    <TD><P CLASS="Base2">&nbsp;</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2">GasN2Total</TD>
    <TD><P CLASS="Base2">NUMERIC(18,4)</TD>
    <TD><P CLASS="Base2">&nbsp;</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2">HardKapci881</TD>
    <TD><P CLASS="Base2">NUMERIC(18,2)</TD>
    <TD><P CLASS="Base2">&nbsp;</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2">HardKapci881Total</TD>
    <TD><P CLASS="Base2">NUMERIC(18,4)</TD>
    <TD><P CLASS="Base2">&nbsp;</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2">HardKapciHs6055</TD>
    <TD><P CLASS="Base2">NUMERIC(18,2)</TD>
    <TD><P CLASS="Base2">&nbsp;</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2">HardKapciHs6055Total</TD>
    <TD><P CLASS="Base2">NUMERIC(18,4)</TD>
    <TD><P CLASS="Base2">&nbsp;</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2">HardKapci126</TD>
    <TD><P CLASS="Base2">NUMERIC(18,2)</TD>
    <TD><P CLASS="Base2">&nbsp;</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2">HardKapci126Total</TD>
    <TD><P CLASS="Base2">NUMERIC(18,4)</TD>
    <TD><P CLASS="Base2">&nbsp;</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2">HardKapciPEPutty</TD>
    <TD><P CLASS="Base2">NUMERIC(18,2)</TD>
    <TD><P CLASS="Base2">&nbsp;</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2">HardKapciPEPuttyTotal</TD>
    <TD><P CLASS="Base2">NUMERIC(18,4)</TD>
    <TD><P CLASS="Base2">&nbsp;</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2">HardKapci2KMS651</TD>
    <TD><P CLASS="Base2">NUMERIC(18,2)</TD>
    <TD><P CLASS="Base2">&nbsp;</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2">HardKapci2KMS651Total</TD>
    <TD><P CLASS="Base2">NUMERIC(18,4)</TD>
    <TD><P CLASS="Base2">&nbsp;</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2">DilKapci881</TD>
    <TD><P CLASS="Base2">NUMERIC(18,2)</TD>
    <TD><P CLASS="Base2">&nbsp;</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2">DilKapci881Total</TD>
    <TD><P CLASS="Base2">NUMERIC(18,4)</TD>
    <TD><P CLASS="Base2">&nbsp;</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2">DilKapci2K</TD>
    <TD><P CLASS="Base2">NUMERIC(18,2)</TD>
    <TD><P CLASS="Base2">&nbsp;</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2">DilKapci2KTotal</TD>
    <TD><P CLASS="Base2">NUMERIC(18,4)</TD>
    <TD><P CLASS="Base2">&nbsp;</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2">DilKapci880</TD>
    <TD><P CLASS="Base2">NUMERIC(18,2)</TD>
    <TD><P CLASS="Base2">&nbsp;</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2">DilKapci880Total</TD>
    <TD><P CLASS="Base2">NUMERIC(18,4)</TD>
    <TD><P CLASS="Base2">&nbsp;</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2">PrimerKapci125</TD>
    <TD><P CLASS="Base2">NUMERIC(18,2)</TD>
    <TD><P CLASS="Base2">&nbsp;</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2">PrimerKapci125Total</TD>
    <TD><P CLASS="Base2">NUMERIC(18,4)</TD>
    <TD><P CLASS="Base2">&nbsp;</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2">PrimerKapci633</TD>
    <TD><P CLASS="Base2">NUMERIC(18,2)</TD>
    <TD><P CLASS="Base2">&nbsp;</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2">PrimerKapci633Total</TD>
    <TD><P CLASS="Base2">NUMERIC(18,4)</TD>
    <TD><P CLASS="Base2">&nbsp;</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2">EnamelKapci641</TD>
    <TD><P CLASS="Base2">NUMERIC(18,2)</TD>
    <TD><P CLASS="Base2">&nbsp;</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2">EnamelKapci641Total</TD>
    <TD><P CLASS="Base2">NUMERIC(18,4)</TD>
    <TD><P CLASS="Base2">&nbsp;</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2">EnamelKapci670</TD>
    <TD><P CLASS="Base2">NUMERIC(18,2)</TD>
    <TD><P CLASS="Base2">&nbsp;</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2">EnamelKapci670Total</TD>
    <TD><P CLASS="Base2">NUMERIC(18,4)</TD>
    <TD><P CLASS="Base2">&nbsp;</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2">EnamelKapci6030</TD>
    <TD><P CLASS="Base2">NUMERIC(18,2)</TD>
    <TD><P CLASS="Base2">&nbsp;</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2">EnamelKapci6030Total</TD>
    <TD><P CLASS="Base2">NUMERIC(18,4)</TD>
    <TD><P CLASS="Base2">&nbsp;</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2">UniversalSikaflex527</TD>
    <TD><P CLASS="Base2">NUMERIC(18,2)</TD>
    <TD><P CLASS="Base2">&nbsp;</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2">UniversalSikaflex527Total</TD>
    <TD><P CLASS="Base2">NUMERIC(18,4)</TD>
    <TD><P CLASS="Base2">&nbsp;</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2">PuttyKapci350</TD>
    <TD><P CLASS="Base2">NUMERIC(18,2)</TD>
    <TD><P CLASS="Base2">&nbsp;</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2">PuttyKapci350Total</TD>
    <TD><P CLASS="Base2">NUMERIC(18,4)</TD>
    <TD><P CLASS="Base2">&nbsp;</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2">LaborIntensity001</TD>
    <TD><P CLASS="Base2">NUMERIC(18,2)</TD>
    <TD><P CLASS="Base2">&nbsp;</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2">LaborIntensity001Total</TD>
    <TD><P CLASS="Base2">NUMERIC(18,4)</TD>
    <TD><P CLASS="Base2">&nbsp;</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2">LaborIntensity002</TD>
    <TD><P CLASS="Base2">NUMERIC(18,2)</TD>
    <TD><P CLASS="Base2">&nbsp;</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2">LaborIntensity002Total</TD>
    <TD><P CLASS="Base2">NUMERIC(18,4)</TD>
    <TD><P CLASS="Base2">&nbsp;</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2">LaborIntensity003</TD>
    <TD><P CLASS="Base2">NUMERIC(18,2)</TD>
    <TD><P CLASS="Base2">&nbsp;</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2">LaborIntensity003Total</TD>
    <TD><P CLASS="Base2">NUMERIC(18,4)</TD>
    <TD><P CLASS="Base2">&nbsp;</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2">LaborIntensity004</TD>
    <TD><P CLASS="Base2">NUMERIC(18,2)</TD>
    <TD><P CLASS="Base2">&nbsp;</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2">LaborIntensity004Total</TD>
    <TD><P CLASS="Base2">NUMERIC(18,4)</TD>
    <TD><P CLASS="Base2">&nbsp;</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2">LaborIntensity005</TD>
    <TD><P CLASS="Base2">NUMERIC(18,2)</TD>
    <TD><P CLASS="Base2">&nbsp;</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2">LaborIntensity005Total</TD>
    <TD><P CLASS="Base2">NUMERIC(18,4)</TD>
    <TD><P CLASS="Base2">&nbsp;</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2">LaborIntensityGeneral</TD>
    <TD><P CLASS="Base2">NUMERIC(18,2)</TD>
    <TD><P CLASS="Base2">&nbsp;</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2">LaborIntensityGeneralTotal</TD>
    <TD><P CLASS="Base2">NUMERIC(18,4)</TD>
    <TD><P CLASS="Base2">&nbsp;</TD>
  </TR>
</TABLE>
<P CLASS="Base">&nbsp;</P>
<P CLASS="Header1">Description</P>
<P CLASS="Base"><I>(There is no description for procedure GetDrawings)</I></P>
<P CLASS="Base">&nbsp;</P>
<P CLASS="Header1">Definition</P>
<P CLASS="Base"><span class="DDLCode">
<code><pre>
<b>CREATE</b><b> </b><b>PROCEDURE</b><b> </b><font color="# 080 0"><u>&quot;GetDrawings&quot;</u></font><b>(</b>
<b>    </b>&quot;DateNow&quot;<b> </b><b>DATE</b><b>)</b>
<b>RETURNS</b><b> </b><b>(</b>
<b>    </b>&quot;Id&quot;<b> </b><b>INTEGER</b><b>,</b>
<b>    </b>&quot;ParentId&quot;<b> </b><b>INTEGER</b><b>,</b>
<b>    </b>&quot;CurrentLevelMenu&quot;<b> </b><b>VARCHAR</b><b>(</b>100<b>)</b><b>,</b>
<b>    </b>&quot;DrawingId&quot;<b> </b><b>INTEGER</b><b>,</b>
<b>    </b>&quot;ReplaceDrawingId&quot;<b> </b><b>SMALLINT</b><b>,</b>
<b>    </b>&quot;OccurrenceId&quot;<b> </b><b>SMALLINT</b><b>,</b>
<b>    </b>&quot;ScanId&quot;<b> </b><b>INTEGER</b><b>,</b>
<b>    </b>&quot;Quantity&quot;<b> </b><b>NUMERIC</b><b>(</b>9<b>,</b>2<b>)</b><b>,</b>
<b>    </b>&quot;QuantityR&quot;<b> </b><b>NUMERIC</b><b>(</b>9<b>,</b>2<b>)</b><b>,</b>
<b>    </b>&quot;QuantityL&quot;<b> </b><b>NUMERIC</b><b>(</b>9<b>,</b>2<b>)</b><b>,</b>
<b>    </b>&quot;StructuraDisable&quot;<b> </b><b>SMALLINT</b><b>,</b>
<b>    </b>&quot;Number&quot;<b> </b><b>VARCHAR</b><b>(</b>120<b>)</b><b>,</b>
<b>    </b>&quot;RevisionName&quot;<b> </b><b>VARCHAR</b><b>(</b>8<b>)</b><b>,</b>
<b>    </b>&quot;NumberWithRevisionName&quot;<b> </b><b>VARCHAR</b><b>(</b>132<b>)</b><b>,</b>
<b>    </b>&quot;DetailWeight&quot;<b> </b><b>NUMERIC</b><b>(</b>18<b>,</b>2<b>)</b><b>,</b>
<b>    </b>TH<b> </b><b>VARCHAR</b><b>(</b>100<b>)</b><b>,</b>
<b>    </b>W<b> </b><b>VARCHAR</b><b>(</b>100<b>)</b><b>,</b>
<b>    </b>W2<b> </b><b>VARCHAR</b><b>(</b>100<b>)</b><b>,</b>
<b>    </b>L<b> </b><b>VARCHAR</b><b>(</b>100<b>)</b><b>,</b>
<b>    </b>&quot;DetailName&quot;<b> </b><b>VARCHAR</b><b>(</b>160<b>)</b><b>,</b>
<b>    </b>&quot;TypeName&quot;<b> </b><b>VARCHAR</b><b>(</b>20<b>)</b><b>,</b>
<b>    </b>&quot;ParentName&quot;<b> </b><b>VARCHAR</b><b>(</b>120<b>)</b><b>,</b>
<b>    </b>&quot;MaterialName&quot;<b> </b><b>VARCHAR</b><b>(</b>100<b>)</b><b>,</b>
<b>    </b>&quot;NoteName&quot;<b> </b><b>VARCHAR</b><b>(</b>800<b>)</b><b>,</b>
<b>    </b>&quot;CreateDate&quot;<b> </b><b>DATE</b><b>,</b>
<b>    </b>&quot;TechProcess001Id&quot;<b> </b><b>INTEGER</b><b>,</b>
<b>    </b>&quot;TechProcess002Id&quot;<b> </b><b>INTEGER</b><b>,</b>
<b>    </b>&quot;TechProcess003Id&quot;<b> </b><b>INTEGER</b><b>,</b>
<b>    </b>&quot;TechProcess004Id&quot;<b> </b><b>INTEGER</b><b>,</b>
<b>    </b>&quot;TechProcess005Id&quot;<b> </b><b>INTEGER</b><b>,</b>
<b>    </b>&quot;TechProcess001Name&quot;<b> </b><b>BIGINT</b><b>,</b>
<b>    </b>&quot;TechProcess002Name&quot;<b> </b><b>BIGINT</b><b>,</b>
<b>    </b>&quot;TechProcess003Name&quot;<b> </b><b>BIGINT</b><b>,</b>
<b>    </b>&quot;TechProcess004Name&quot;<b> </b><b>BIGINT</b><b>,</b>
<b>    </b>&quot;TechProcess005Name&quot;<b> </b><b>BIGINT</b><b>,</b>
<b>    </b>&quot;TechProcess001NameString&quot;<b> </b><b>VARCHAR</b><b>(</b>20<b>)</b><b>,</b>
<b>    </b>&quot;TechProcess002NameString&quot;<b> </b><b>VARCHAR</b><b>(</b>20<b>)</b><b>,</b>
<b>    </b>&quot;TechProcess003NameString&quot;<b> </b><b>VARCHAR</b><b>(</b>20<b>)</b><b>,</b>
<b>    </b>&quot;TechProcess004NameString&quot;<b> </b><b>VARCHAR</b><b>(</b>20<b>)</b><b>,</b>
<b>    </b>&quot;TechProcess005NameString&quot;<b> </b><b>VARCHAR</b><b>(</b>20<b>)</b><b>,</b>
<b>    </b>&quot;Revision001&quot;<b> </b><b>VARCHAR</b><b>(</b>8<b>)</b><b>,</b>
<b>    </b>&quot;Revision002&quot;<b> </b><b>VARCHAR</b><b>(</b>8<b>)</b><b>,</b>
<b>    </b>&quot;Revision003&quot;<b> </b><b>VARCHAR</b><b>(</b>8<b>)</b><b>,</b>
<b>    </b>&quot;Revision004&quot;<b> </b><b>VARCHAR</b><b>(</b>8<b>)</b><b>,</b>
<b>    </b>&quot;Revision005&quot;<b> </b><b>VARCHAR</b><b>(</b>8<b>)</b><b>,</b>
<b>    </b>&quot;TechProcess001Path&quot;<b> </b><b>VARCHAR</b><b>(</b>200<b>)</b><b>,</b>
<b>    </b>&quot;TechProcess002Path&quot;<b> </b><b>VARCHAR</b><b>(</b>200<b>)</b><b>,</b>
<b>    </b>&quot;TechProcess003Path&quot;<b> </b><b>VARCHAR</b><b>(</b>200<b>)</b><b>,</b>
<b>    </b>&quot;TechProcess004Path&quot;<b> </b><b>VARCHAR</b><b>(</b>200<b>)</b><b>,</b>
<b>    </b>&quot;TechProcess005Path&quot;<b> </b><b>VARCHAR</b><b>(</b>200<b>)</b><b>,</b>
<b>    </b>&quot;TechProcess001Old&quot;<b> </b><b>SMALLINT</b><b>,</b>
<b>    </b>&quot;TechProcess002Old&quot;<b> </b><b>SMALLINT</b><b>,</b>
<b>    </b>&quot;TechProcess003Old&quot;<b> </b><b>SMALLINT</b><b>,</b>
<b>    </b>&quot;TechProcess004Old&quot;<b> </b><b>SMALLINT</b><b>,</b>
<b>    </b>&quot;TechProcess005Old&quot;<b> </b><b>SMALLINT</b><b>,</b>
<b>    </b>&quot;TechProcess001Type&quot;<b> </b><b>SMALLINT</b><b>,</b>
<b>    </b>&quot;TechProcess002Type&quot;<b> </b><b>SMALLINT</b><b>,</b>
<b>    </b>&quot;TechProcess003Type&quot;<b> </b><b>SMALLINT</b><b>,</b>
<b>    </b>&quot;TechProcess004Type&quot;<b> </b><b>SMALLINT</b><b>,</b>
<b>    </b>&quot;TechProcess005Type&quot;<b> </b><b>SMALLINT</b><b>,</b>
<b>    </b>&quot;CurrentLevelMenuColorId&quot;<b> </b><b>INTEGER</b><b>,</b>
<b>    </b>&quot;CurrentLevelMenuColorName&quot;<b> </b><b>VARCHAR</b><b>(</b>40<b>)</b><b>,</b>
<b>    </b>&quot;DrawingColorId&quot;<b> </b><b>INTEGER</b><b>,</b>
<b>    </b>&quot;DrawingColorName&quot;<b> </b><b>VARCHAR</b><b>(</b>40<b>)</b><b>,</b>
<b>    </b>&quot;MaterialColorId&quot;<b> </b><b>INTEGER</b><b>,</b>
<b>    </b>&quot;MaterialColorName&quot;<b> </b><b>VARCHAR</b><b>(</b>40<b>)</b><b>,</b>
<b>    </b>&quot;Welding20Steel&quot;<b> </b><b>NUMERIC</b><b>(</b>18<b>,</b>2<b>)</b><b>,</b>
<b>    </b>&quot;Welding20SteelTotal&quot;<b> </b><b>NUMERIC</b><b>(</b>18<b>,</b>4<b>)</b><b>,</b>
<b>    </b>&quot;Welding10&quot;<b> </b><b>NUMERIC</b><b>(</b>18<b>,</b>2<b>)</b><b>,</b>
<b>    </b>&quot;Welding10Total&quot;<b> </b><b>NUMERIC</b><b>(</b>18<b>,</b>4<b>)</b><b>,</b>
<b>    </b>&quot;Welding12&quot;<b> </b><b>NUMERIC</b><b>(</b>18<b>,</b>2<b>)</b><b>,</b>
<b>    </b>&quot;Welding12Total&quot;<b> </b><b>NUMERIC</b><b>(</b>18<b>,</b>4<b>)</b><b>,</b>
<b>    </b>&quot;Welding16&quot;<b> </b><b>NUMERIC</b><b>(</b>18<b>,</b>2<b>)</b><b>,</b>
<b>    </b>&quot;Welding16Total&quot;<b> </b><b>NUMERIC</b><b>(</b>18<b>,</b>4<b>)</b><b>,</b>
<b>    </b>&quot;Welding20&quot;<b> </b><b>NUMERIC</b><b>(</b>18<b>,</b>2<b>)</b><b>,</b>
<b>    </b>&quot;Welding20Total&quot;<b> </b><b>NUMERIC</b><b>(</b>18<b>,</b>4<b>)</b><b>,</b>
<b>    </b>&quot;GasArCO2&quot;<b> </b><b>NUMERIC</b><b>(</b>18<b>,</b>2<b>)</b><b>,</b>
<b>    </b>&quot;GasArCO2Total&quot;<b> </b><b>NUMERIC</b><b>(</b>18<b>,</b>4<b>)</b><b>,</b>
<b>    </b>&quot;GasCO3&quot;<b> </b><b>NUMERIC</b><b>(</b>18<b>,</b>2<b>)</b><b>,</b>
<b>    </b>&quot;GasCO3Total&quot;<b> </b><b>NUMERIC</b><b>(</b>18<b>,</b>4<b>)</b><b>,</b>
<b>    </b>&quot;GasAr&quot;<b> </b><b>NUMERIC</b><b>(</b>18<b>,</b>2<b>)</b><b>,</b>
<b>    </b>&quot;GasArTotal&quot;<b> </b><b>NUMERIC</b><b>(</b>18<b>,</b>4<b>)</b><b>,</b>
<b>    </b>&quot;WeldingElektrod&quot;<b> </b><b>NUMERIC</b><b>(</b>18<b>,</b>2<b>)</b><b>,</b>
<b>    </b>&quot;WeldingElektrodTotal&quot;<b> </b><b>NUMERIC</b><b>(</b>18<b>,</b>4<b>)</b><b>,</b>
<b>    </b>&quot;GasO2&quot;<b> </b><b>NUMERIC</b><b>(</b>18<b>,</b>2<b>)</b><b>,</b>
<b>    </b>&quot;GasO2Total&quot;<b> </b><b>NUMERIC</b><b>(</b>18<b>,</b>4<b>)</b><b>,</b>
<b>    </b>&quot;GasNature&quot;<b> </b><b>NUMERIC</b><b>(</b>18<b>,</b>2<b>)</b><b>,</b>
<b>    </b>&quot;GasNatureTotal&quot;<b> </b><b>NUMERIC</b><b>(</b>18<b>,</b>4<b>)</b><b>,</b>
<b>    </b>&quot;GasN2&quot;<b> </b><b>NUMERIC</b><b>(</b>18<b>,</b>2<b>)</b><b>,</b>
<b>    </b>&quot;GasN2Total&quot;<b> </b><b>NUMERIC</b><b>(</b>18<b>,</b>4<b>)</b><b>,</b>
<b>    </b>&quot;HardKapci881&quot;<b> </b><b>NUMERIC</b><b>(</b>18<b>,</b>2<b>)</b><b>,</b>
<b>    </b>&quot;HardKapci881Total&quot;<b> </b><b>NUMERIC</b><b>(</b>18<b>,</b>4<b>)</b><b>,</b>
<b>    </b>&quot;HardKapciHs6055&quot;<b> </b><b>NUMERIC</b><b>(</b>18<b>,</b>2<b>)</b><b>,</b>
<b>    </b>&quot;HardKapciHs6055Total&quot;<b> </b><b>NUMERIC</b><b>(</b>18<b>,</b>4<b>)</b><b>,</b>
<b>    </b>&quot;HardKapci126&quot;<b> </b><b>NUMERIC</b><b>(</b>18<b>,</b>2<b>)</b><b>,</b>
<b>    </b>&quot;HardKapci126Total&quot;<b> </b><b>NUMERIC</b><b>(</b>18<b>,</b>4<b>)</b><b>,</b>
<b>    </b>&quot;HardKapciPEPutty&quot;<b> </b><b>NUMERIC</b><b>(</b>18<b>,</b>2<b>)</b><b>,</b>
<b>    </b>&quot;HardKapciPEPuttyTotal&quot;<b> </b><b>NUMERIC</b><b>(</b>18<b>,</b>4<b>)</b><b>,</b>
<b>    </b>&quot;HardKapci2KMS651&quot;<b> </b><b>NUMERIC</b><b>(</b>18<b>,</b>2<b>)</b><b>,</b>
<b>    </b>&quot;HardKapci2KMS651Total&quot;<b> </b><b>NUMERIC</b><b>(</b>18<b>,</b>4<b>)</b><b>,</b>
<b>    </b>&quot;DilKapci881&quot;<b> </b><b>NUMERIC</b><b>(</b>18<b>,</b>2<b>)</b><b>,</b>
<b>    </b>&quot;DilKapci881Total&quot;<b> </b><b>NUMERIC</b><b>(</b>18<b>,</b>4<b>)</b><b>,</b>
<b>    </b>&quot;DilKapci2K&quot;<b> </b><b>NUMERIC</b><b>(</b>18<b>,</b>2<b>)</b><b>,</b>
<b>    </b>&quot;DilKapci2KTotal&quot;<b> </b><b>NUMERIC</b><b>(</b>18<b>,</b>4<b>)</b><b>,</b>
<b>    </b>&quot;DilKapci880&quot;<b> </b><b>NUMERIC</b><b>(</b>18<b>,</b>2<b>)</b><b>,</b>
<b>    </b>&quot;DilKapci880Total&quot;<b> </b><b>NUMERIC</b><b>(</b>18<b>,</b>4<b>)</b><b>,</b>
<b>    </b>&quot;PrimerKapci125&quot;<b> </b><b>NUMERIC</b><b>(</b>18<b>,</b>2<b>)</b><b>,</b>
<b>    </b>&quot;PrimerKapci125Total&quot;<b> </b><b>NUMERIC</b><b>(</b>18<b>,</b>4<b>)</b><b>,</b>
<b>    </b>&quot;PrimerKapci633&quot;<b> </b><b>NUMERIC</b><b>(</b>18<b>,</b>2<b>)</b><b>,</b>
<b>    </b>&quot;PrimerKapci633Total&quot;<b> </b><b>NUMERIC</b><b>(</b>18<b>,</b>4<b>)</b><b>,</b>
<b>    </b>&quot;EnamelKapci641&quot;<b> </b><b>NUMERIC</b><b>(</b>18<b>,</b>2<b>)</b><b>,</b>
<b>    </b>&quot;EnamelKapci641Total&quot;<b> </b><b>NUMERIC</b><b>(</b>18<b>,</b>4<b>)</b><b>,</b>
<b>    </b>&quot;EnamelKapci670&quot;<b> </b><b>NUMERIC</b><b>(</b>18<b>,</b>2<b>)</b><b>,</b>
<b>    </b>&quot;EnamelKapci670Total&quot;<b> </b><b>NUMERIC</b><b>(</b>18<b>,</b>4<b>)</b><b>,</b>
<b>    </b>&quot;EnamelKapci6030&quot;<b> </b><b>NUMERIC</b><b>(</b>18<b>,</b>2<b>)</b><b>,</b>
<b>    </b>&quot;EnamelKapci6030Total&quot;<b> </b><b>NUMERIC</b><b>(</b>18<b>,</b>4<b>)</b><b>,</b>
<b>    </b>&quot;UniversalSikaflex527&quot;<b> </b><b>NUMERIC</b><b>(</b>18<b>,</b>2<b>)</b><b>,</b>
<b>    </b>&quot;UniversalSikaflex527Total&quot;<b> </b><b>NUMERIC</b><b>(</b>18<b>,</b>4<b>)</b><b>,</b>
<b>    </b>&quot;PuttyKapci350&quot;<b> </b><b>NUMERIC</b><b>(</b>18<b>,</b>2<b>)</b><b>,</b>
<b>    </b>&quot;PuttyKapci350Total&quot;<b> </b><b>NUMERIC</b><b>(</b>18<b>,</b>4<b>)</b><b>,</b>
<b>    </b>&quot;LaborIntensity001&quot;<b> </b><b>NUMERIC</b><b>(</b>18<b>,</b>2<b>)</b><b>,</b>
<b>    </b>&quot;LaborIntensity001Total&quot;<b> </b><b>NUMERIC</b><b>(</b>18<b>,</b>4<b>)</b><b>,</b>
<b>    </b>&quot;LaborIntensity002&quot;<b> </b><b>NUMERIC</b><b>(</b>18<b>,</b>2<b>)</b><b>,</b>
<b>    </b>&quot;LaborIntensity002Total&quot;<b> </b><b>NUMERIC</b><b>(</b>18<b>,</b>4<b>)</b><b>,</b>
<b>    </b>&quot;LaborIntensity003&quot;<b> </b><b>NUMERIC</b><b>(</b>18<b>,</b>2<b>)</b><b>,</b>
<b>    </b>&quot;LaborIntensity003Total&quot;<b> </b><b>NUMERIC</b><b>(</b>18<b>,</b>4<b>)</b><b>,</b>
<b>    </b>&quot;LaborIntensity004&quot;<b> </b><b>NUMERIC</b><b>(</b>18<b>,</b>2<b>)</b><b>,</b>
<b>    </b>&quot;LaborIntensity004Total&quot;<b> </b><b>NUMERIC</b><b>(</b>18<b>,</b>4<b>)</b><b>,</b>
<b>    </b>&quot;LaborIntensity005&quot;<b> </b><b>NUMERIC</b><b>(</b>18<b>,</b>2<b>)</b><b>,</b>
<b>    </b>&quot;LaborIntensity005Total&quot;<b> </b><b>NUMERIC</b><b>(</b>18<b>,</b>4<b>)</b><b>,</b>
<b>    </b>&quot;LaborIntensityGeneral&quot;<b> </b><b>NUMERIC</b><b>(</b>18<b>,</b>2<b>)</b><b>,</b>
<b>    </b>&quot;LaborIntensityGeneralTotal&quot;<b> </b><b>NUMERIC</b><b>(</b>18<b>,</b>4<b>)</b><b>)</b>
<b>AS</b>
<b>BEGIN</b>
<b>  </b><b>FOR</b>
<b>    </b><b>SELECT</b>
<b>        </b>drw<b>.</b>&quot;Id&quot;<b> </b><b>as</b><b> </b>&quot;Id&quot;<b>,</b>
<b>        </b>drw<b>.</b>&quot;ParentId&quot;<b>,</b>
<b>        </b>drw<b>.</b>&quot;CurrentLevelMenu&quot;<b>,</b>
<b>        </b>dr<b>.</b>&quot;Id&quot;<b> </b><b>as</b><b> </b>&quot;DrawingId&quot;<b>,</b>
<b>        </b>drw<b>.</b>&quot;ReplaceDrawingId&quot;<b>,</b>
<b>        </b>drw<b>.</b>&quot;OccurrenceId&quot;<b>,</b>
<b>        </b><b>IIF</b><b>(</b><b>count</b><b>(</b>drScan<b>.</b>&quot;DrawingId&quot;<b>)</b><b> </b><b>&gt;</b><b> </b>0<b>,</b><b> </b>1<b> </b><b>,</b><b> </b>0<b>)</b><b> </b><b>as</b><b>  </b>&quot;ScanId&quot;<b>,</b>
<b>        </b>drw<b>.</b>&quot;Quantity&quot;<b>,</b>
<b>        </b>drw<b>.</b>&quot;QuantityR&quot;<b>,</b>
<b>        </b>drw<b>.</b>&quot;QuantityL&quot;<b>,</b>
<b>        </b>drw<b>.</b>&quot;StructuraDisable&quot;<b>,</b>
<b>    </b>
<b>        </b>dr<b>.</b>&quot;Number&quot;<b>,</b>
<b>        </b>rev<b>.</b>&quot;Symbol&quot;<b> </b><b>as</b><b> </b>&quot;RevisionName&quot;<b>,</b>
<b>        </b><b>iif</b><b>(</b>dr<b>.</b>&quot;RevisionId&quot;<b> </b><b>is</b><b> </b><b>null</b><b>,</b><b> </b>dr<b>.</b>&quot;Number&quot;<b>,</b><b> </b>dr<b>.</b>&quot;Number&quot;<b>|</b><b>|</b>' '<b>|</b><b>|</b>rev<b>.</b>&quot;Symbol&quot;<b>)</b><b> </b><b>as</b><b>  </b>&quot;NumberWithRevisionName&quot;<b>,</b>
<b>        </b>dr<b>.</b>&quot;DetailWeight&quot;<b>,</b>
<b>        </b>dr<b>.</b>&quot;TH&quot;<b>,</b>
<b>        </b>dr<b>.</b>&quot;W&quot;<b>,</b>
<b>        </b>dr<b>.</b>&quot;W2&quot;<b>,</b>
<b>        </b>dr<b>.</b>&quot;L&quot;<b>,</b>
<b>        </b>det<b>.</b>&quot;DetailName&quot;<b>,</b>
<b>        </b>typ<b>.</b>&quot;TypeName&quot;<b>,</b>
<b>        </b><b>IIF</b><b>(</b>drp<b>.</b>&quot;Number&quot;<b> </b><b>is</b><b> </b><b>null</b><b>,</b><b> </b>dr<b>.</b>&quot;Number&quot;<b>,</b><b> </b>drp<b>.</b>&quot;Number&quot;<b>)</b><b> </b><b>as</b><b> </b>&quot;ParentName&quot;<b>,</b>
<b>        </b>mat<b>.</b>&quot;MaterialName&quot;<b>,</b>
<b>        </b>dr<b>.</b>&quot;Note&quot;<b> </b><b>as</b><b> </b>&quot;NoteName&quot;<b>,</b>
<b>        </b>dr<b>.</b>&quot;CreateDate&quot;<b>,</b>
<b>         </b>tcp001<b>.</b>&quot;Id&quot;<b> </b><b>as</b><b> </b>&quot;TechProcess001Id&quot;<b>,</b>
<b>        </b>tcp002<b>.</b>&quot;Id&quot;<b> </b><b>as</b><b> </b>&quot;TechProcess002Id&quot;<b>,</b>
<b>        </b>tcp003<b>.</b>&quot;Id&quot;<b> </b><b>as</b><b> </b>&quot;TechProcess003Id&quot;<b>,</b>
<b>        </b>tcp004<b>.</b>&quot;Id&quot;<b> </b><b>as</b><b> </b>&quot;TechProcess004Id&quot;<b>,</b>
<b>        </b>tcp005<b>.</b>&quot;Id&quot;<b> </b><b>as</b><b> </b>&quot;TechProcess005Id&quot;<b>,</b>
<b>        </b>tcp001<b>.</b>&quot;TechProcessName&quot;<b> </b><b>as</b><b> </b>&quot;TechProcess001Name&quot;<b>,</b>
<b>        </b>tcp002<b>.</b>&quot;TechProcessName&quot;<b> </b><b>as</b><b> </b>&quot;TechProcess002Name&quot;<b>,</b>
<b>        </b>tcp003<b>.</b>&quot;TechProcessName&quot;<b> </b><b>as</b><b> </b>&quot;TechProcess003Name&quot;<b>,</b>
<b>        </b>tcp004<b>.</b>&quot;TechProcessName&quot;<b> </b><b>as</b><b> </b>&quot;TechProcess004Name&quot;<b>,</b>
<b>        </b>tcp005<b>.</b>&quot;TechProcessName&quot;<b> </b><b>as</b><b> </b>&quot;TechProcess005Name&quot;<b>,</b>
<b>        </b><b>CAST</b><b>(</b>tcp001<b>.</b>&quot;TechProcessName&quot;<b> </b><b>AS</b><b> </b><b>INTEGER</b><b>)</b><b> </b><b>as</b><b> </b>&quot;TechProcess001NameString&quot;<b>,</b>
<b>        </b><b>CAST</b><b>(</b>tcp002<b>.</b>&quot;TechProcessName&quot;<b> </b><b>AS</b><b> </b><b>INTEGER</b><b>)</b><b> </b><b>as</b><b> </b>&quot;TechProcess002NameString&quot;<b>,</b>
<b>        </b><b>CAST</b><b>(</b>tcp003<b>.</b>&quot;TechProcessName&quot;<b> </b><b>AS</b><b> </b><b>INTEGER</b><b>)</b><b> </b><b>as</b><b> </b>&quot;TechProcess003NameString&quot;<b>,</b>
<b>        </b><b>CAST</b><b>(</b>tcp004<b>.</b>&quot;TechProcessName&quot;<b> </b><b>AS</b><b> </b><b>INTEGER</b><b>)</b><b> </b><b>as</b><b> </b>&quot;TechProcess004NameString&quot;<b>,</b>
<b>        </b><b>CAST</b><b>(</b>tcp005<b>.</b>&quot;TechProcessName&quot;<b> </b><b>AS</b><b> </b><b>INTEGER</b><b>)</b><b> </b><b>as</b><b> </b>&quot;TechProcess005NameString&quot;<b>,</b>
<b>        </b>tcp001rev<b>.</b>&quot;Symbol&quot;<b> </b><b>as</b><b> </b>&quot;Revision001&quot;<b>,</b>
<b>        </b>tcp002rev<b>.</b>&quot;Symbol&quot;<b> </b><b>as</b><b> </b>&quot;Revision002&quot;<b>,</b>
<b>        </b>tcp003rev<b>.</b>&quot;Symbol&quot;<b> </b><b>as</b><b> </b>&quot;Revision003&quot;<b>,</b>
<b>        </b>tcp004rev<b>.</b>&quot;Symbol&quot;<b> </b><b>as</b><b> </b>&quot;Revision004&quot;<b>,</b>
<b>        </b>tcp005rev<b>.</b>&quot;Symbol&quot;<b> </b><b>as</b><b> </b>&quot;Revision005&quot;<b>,</b>
<b>        </b>tcp001<b>.</b>&quot;TechProcessPath&quot;<b> </b><b>as</b><b> </b>&quot;TechProcess001Path&quot;<b>,</b>
<b>        </b>tcp002<b>.</b>&quot;TechProcessPath&quot;<b> </b><b>as</b><b> </b>&quot;TechProcess002Path&quot;<b>,</b>
<b>        </b>tcp003<b>.</b>&quot;TechProcessPath&quot;<b> </b><b>as</b><b> </b>&quot;TechProcess003Path&quot;<b>,</b>
<b>        </b>tcp004<b>.</b>&quot;TechProcessPath&quot;<b> </b><b>as</b><b> </b>&quot;TechProcess004Path&quot;<b>,</b>
<b>        </b>tcp005<b>.</b>&quot;TechProcessPath&quot;<b> </b><b>as</b><b> </b>&quot;TechProcess005Path&quot;<b>,</b>
<b>        </b>tcp001<b>.</b>&quot;OldTechProcess&quot;<b> </b><b>as</b><b> </b>&quot;TechProcess001Old&quot;<b>,</b>
<b>        </b>tcp002<b>.</b>&quot;OldTechProcess&quot;<b> </b><b>as</b><b> </b>&quot;TechProcess002Old&quot;<b>,</b>
<b>        </b>tcp003<b>.</b>&quot;OldTechProcess&quot;<b> </b><b>as</b><b> </b>&quot;TechProcess003Old&quot;<b>,</b>
<b>        </b>tcp004<b>.</b>&quot;OldTechProcess&quot;<b> </b><b>as</b><b> </b>&quot;TechProcess004Old&quot;<b>,</b>
<b>        </b>tcp005<b>.</b>&quot;OldTechProcess&quot;<b> </b><b>as</b><b> </b>&quot;TechProcess005Old&quot;<b>,</b>
<b>        </b>tcp001<b>.</b>&quot;TypeId&quot;<b> </b><b>as</b><b> </b>&quot;TechProcess001Type&quot;<b>,</b>
<b>        </b>tcp002<b>.</b>&quot;TypeId&quot;<b> </b><b>as</b><b> </b>&quot;TechProcess002Type&quot;<b>,</b>
<b>        </b>tcp003<b>.</b>&quot;TypeId&quot;<b> </b><b>as</b><b> </b>&quot;TechProcess003Type&quot;<b>,</b>
<b>        </b>tcp004<b>.</b>&quot;TypeId&quot;<b> </b><b>as</b><b> </b>&quot;TechProcess004Type&quot;<b>,</b>
<b>        </b>tcp005<b>.</b>&quot;TypeId&quot;<b> </b><b>as</b><b> </b>&quot;TechProcess005Type&quot;<b>,</b>
<b>    </b>
<b>        </b>colm<b>.</b>&quot;Id&quot;<b> </b><b>as</b><b> </b>&quot;CurrentLevelMenuColorId&quot;<b>,</b>
<b>        </b>colm<b>.</b>&quot;NameEng&quot;<b> </b><b>as</b><b> </b>&quot;CurrentLevelMenuColorName&quot;<b>,</b>
<b>        </b>cold<b>.</b>&quot;Id&quot;<b> </b><b>as</b><b> </b>&quot;DrawingColorId&quot;<b>,</b>
<b>        </b>cold<b>.</b>&quot;NameEng&quot;<b> </b><b>as</b><b> </b>&quot;DrawingColorName&quot;<b>,</b>
<b>        </b>coldet<b>.</b>&quot;Id&quot;<b> </b><b>as</b><b> </b>&quot;MaterialColorId&quot;<b>,</b>
<b>        </b>coldet<b>.</b>&quot;NameEng&quot;<b> </b><b>as</b><b> </b>&quot;MaterialColorName&quot;<b>,</b>
<b>    </b>
<b>        </b><b>sum</b><b>(</b><b>COALESCE</b><b>(</b>tcp001<b>.</b>&quot;Welding20Steel&quot;<b>,</b><b> </b>0<b>)</b><b>+</b><b>COALESCE</b><b>(</b>tcp002<b>.</b>&quot;Welding20Steel&quot;<b>,</b><b> </b>0<b>)</b><b>+</b><b>COALESCE</b><b>(</b>tcp003<b>.</b>&quot;Welding20Steel&quot;<b>,</b><b> </b>0<b>)</b><b>+</b><b> </b><b>COALESCE</b><b>(</b>tcp004<b>.</b>&quot;Welding20Steel&quot;<b>,</b><b> </b>0<b>)</b><b> </b><b>+</b><b>COALESCE</b><b>(</b>tcp005<b>.</b>&quot;Welding20Steel&quot;<b>,</b><b> </b>0<b>)</b><b>)</b><b> </b><b>As</b><b> </b>&quot;Welding20Steel&quot;<b>,</b>
<b>        </b><b>sum</b><b>(</b><b>COALESCE</b><b>(</b>tcp001<b>.</b>&quot;Welding20Steel&quot;<b>,</b><b> </b>0<b>)</b><b>+</b><b>COALESCE</b><b>(</b>tcp002<b>.</b>&quot;Welding20Steel&quot;<b>,</b><b> </b>0<b>)</b><b>+</b><b>COALESCE</b><b>(</b>tcp003<b>.</b>&quot;Welding20Steel&quot;<b>,</b><b> </b>0<b>)</b><b>+</b><b> </b><b>COALESCE</b><b>(</b>tcp004<b>.</b>&quot;Welding20Steel&quot;<b>,</b><b> </b>0<b>)</b><b> </b><b>+</b><b>COALESCE</b><b>(</b>tcp005<b>.</b>&quot;Welding20Steel&quot;<b>,</b><b> </b>0<b>)</b><b>)</b><b>*</b>
<b>         </b><b>iif</b><b>(</b><b>COALESCE</b><b>(</b>drw<b>.</b>&quot;Quantity&quot;<b>,</b><b> </b>0<b>)</b><b>&gt;</b>0<b>,</b>drw<b>.</b>&quot;Quantity&quot;<b>,</b><b>COALESCE</b><b>(</b>drw<b>.</b>&quot;QuantityR&quot;<b>,</b><b> </b>0<b>)</b><b>+</b><b>COALESCE</b><b>(</b>drw<b>.</b>&quot;QuantityL&quot;<b>,</b><b> </b>0<b>)</b><b>)</b><b> </b><b>As</b><b> </b>&quot;Welding20SteelTotal&quot;<b>,</b>
<b>        </b><b>sum</b><b>(</b><b>COALESCE</b><b>(</b>tcp001<b>.</b>&quot;Welding10&quot;<b>,</b><b> </b>0<b>)</b><b>+</b><b>COALESCE</b><b>(</b>tcp002<b>.</b>&quot;Welding10&quot;<b>,</b><b> </b>0<b>)</b><b>+</b><b>COALESCE</b><b>(</b>tcp003<b>.</b>&quot;Welding10&quot;<b>,</b><b> </b>0<b>)</b><b>+</b><b> </b><b>COALESCE</b><b>(</b>tcp004<b>.</b>&quot;Welding10&quot;<b>,</b><b> </b>0<b>)</b><b> </b><b>+</b><b>COALESCE</b><b>(</b>tcp005<b>.</b>&quot;Welding10&quot;<b>,</b><b> </b>0<b>)</b><b>)</b><b> </b><b>As</b><b> </b>&quot;Welding10&quot;<b>,</b>
<b>        </b><b>sum</b><b>(</b><b>COALESCE</b><b>(</b>tcp001<b>.</b>&quot;Welding10&quot;<b>,</b><b> </b>0<b>)</b><b>+</b><b>COALESCE</b><b>(</b>tcp002<b>.</b>&quot;Welding10&quot;<b>,</b><b> </b>0<b>)</b><b>+</b><b>COALESCE</b><b>(</b>tcp003<b>.</b>&quot;Welding10&quot;<b>,</b><b> </b>0<b>)</b><b>+</b><b> </b><b>COALESCE</b><b>(</b>tcp004<b>.</b>&quot;Welding10&quot;<b>,</b><b> </b>0<b>)</b><b> </b><b>+</b><b>COALESCE</b><b>(</b>tcp005<b>.</b>&quot;Welding10&quot;<b>,</b><b> </b>0<b>)</b><b>)</b><b>*</b>
<b>         </b><b>iif</b><b>(</b><b>COALESCE</b><b>(</b>drw<b>.</b>&quot;Quantity&quot;<b>,</b><b> </b>0<b>)</b><b>&gt;</b>0<b>,</b>drw<b>.</b>&quot;Quantity&quot;<b>,</b><b>COALESCE</b><b>(</b>drw<b>.</b>&quot;QuantityR&quot;<b>,</b><b> </b>0<b>)</b><b>+</b><b>COALESCE</b><b>(</b>drw<b>.</b>&quot;QuantityL&quot;<b>,</b><b> </b>0<b>)</b><b>)</b><b> </b><b>As</b><b> </b>&quot;Welding10Total&quot;<b>,</b>
<b>        </b><b>sum</b><b>(</b><b>COALESCE</b><b>(</b>tcp001<b>.</b>&quot;Welding12&quot;<b>,</b><b> </b>0<b>)</b><b>+</b><b>COALESCE</b><b>(</b>tcp002<b>.</b>&quot;Welding12&quot;<b>,</b><b> </b>0<b>)</b><b>+</b><b>COALESCE</b><b>(</b>tcp003<b>.</b>&quot;Welding12&quot;<b>,</b><b> </b>0<b>)</b><b>+</b><b> </b><b>COALESCE</b><b>(</b>tcp004<b>.</b>&quot;Welding12&quot;<b>,</b><b> </b>0<b>)</b><b> </b><b>+</b><b>COALESCE</b><b>(</b>tcp005<b>.</b>&quot;Welding12&quot;<b>,</b><b> </b>0<b>)</b><b>)</b><b> </b><b>As</b><b> </b>&quot;Welding12&quot;<b>,</b>
<b>        </b><b>sum</b><b>(</b><b>COALESCE</b><b>(</b>tcp001<b>.</b>&quot;Welding12&quot;<b>,</b><b> </b>0<b>)</b><b>+</b><b>COALESCE</b><b>(</b>tcp002<b>.</b>&quot;Welding12&quot;<b>,</b><b> </b>0<b>)</b><b>+</b><b>COALESCE</b><b>(</b>tcp003<b>.</b>&quot;Welding12&quot;<b>,</b><b> </b>0<b>)</b><b>+</b><b> </b><b>COALESCE</b><b>(</b>tcp004<b>.</b>&quot;Welding12&quot;<b>,</b><b> </b>0<b>)</b><b> </b><b>+</b><b>COALESCE</b><b>(</b>tcp005<b>.</b>&quot;Welding12&quot;<b>,</b><b> </b>0<b>)</b><b>)</b><b>*</b>
<b>         </b><b>iif</b><b>(</b><b>COALESCE</b><b>(</b>drw<b>.</b>&quot;Quantity&quot;<b>,</b><b> </b>0<b>)</b><b>&gt;</b>0<b>,</b>drw<b>.</b>&quot;Quantity&quot;<b>,</b><b>COALESCE</b><b>(</b>drw<b>.</b>&quot;QuantityR&quot;<b>,</b><b> </b>0<b>)</b><b>+</b><b>COALESCE</b><b>(</b>drw<b>.</b>&quot;QuantityL&quot;<b>,</b><b> </b>0<b>)</b><b>)</b><b> </b><b>As</b><b> </b>&quot;Welding12Total&quot;<b>,</b>
<b>        </b><b>sum</b><b>(</b><b>COALESCE</b><b>(</b>tcp001<b>.</b>&quot;Welding16&quot;<b>,</b><b> </b>0<b>)</b><b>+</b><b>COALESCE</b><b>(</b>tcp002<b>.</b>&quot;Welding16&quot;<b>,</b><b> </b>0<b>)</b><b>+</b><b>COALESCE</b><b>(</b>tcp003<b>.</b>&quot;Welding16&quot;<b>,</b><b> </b>0<b>)</b><b>+</b><b> </b><b>COALESCE</b><b>(</b>tcp004<b>.</b>&quot;Welding16&quot;<b>,</b><b> </b>0<b>)</b><b> </b><b>+</b><b>COALESCE</b><b>(</b>tcp005<b>.</b>&quot;Welding16&quot;<b>,</b><b> </b>0<b>)</b><b>)</b><b> </b><b>As</b><b> </b>&quot;Welding16&quot;<b>,</b>
<b>        </b><b>sum</b><b>(</b><b>COALESCE</b><b>(</b>tcp001<b>.</b>&quot;Welding16&quot;<b>,</b><b> </b>0<b>)</b><b>+</b><b>COALESCE</b><b>(</b>tcp002<b>.</b>&quot;Welding16&quot;<b>,</b><b> </b>0<b>)</b><b>+</b><b>COALESCE</b><b>(</b>tcp003<b>.</b>&quot;Welding16&quot;<b>,</b><b> </b>0<b>)</b><b>+</b><b> </b><b>COALESCE</b><b>(</b>tcp004<b>.</b>&quot;Welding16&quot;<b>,</b><b> </b>0<b>)</b><b> </b><b>+</b><b>COALESCE</b><b>(</b>tcp005<b>.</b>&quot;Welding16&quot;<b>,</b><b> </b>0<b>)</b><b>)</b><b>*</b>
<b>         </b><b>iif</b><b>(</b><b>COALESCE</b><b>(</b>drw<b>.</b>&quot;Quantity&quot;<b>,</b><b> </b>0<b>)</b><b>&gt;</b>0<b>,</b>drw<b>.</b>&quot;Quantity&quot;<b>,</b><b>COALESCE</b><b>(</b>drw<b>.</b>&quot;QuantityR&quot;<b>,</b><b> </b>0<b>)</b><b>+</b><b>COALESCE</b><b>(</b>drw<b>.</b>&quot;QuantityL&quot;<b>,</b><b> </b>0<b>)</b><b>)</b><b> </b><b>As</b><b> </b>&quot;Welding16Total&quot;<b>,</b>
<b>        </b><b>sum</b><b>(</b><b>COALESCE</b><b>(</b>tcp001<b>.</b>&quot;Welding20&quot;<b>,</b><b> </b>0<b>)</b><b>+</b><b>COALESCE</b><b>(</b>tcp002<b>.</b>&quot;Welding20&quot;<b>,</b><b> </b>0<b>)</b><b>+</b><b>COALESCE</b><b>(</b>tcp003<b>.</b>&quot;Welding20&quot;<b>,</b><b> </b>0<b>)</b><b>+</b><b> </b><b>COALESCE</b><b>(</b>tcp004<b>.</b>&quot;Welding20&quot;<b>,</b><b> </b>0<b>)</b><b> </b><b>+</b><b>COALESCE</b><b>(</b>tcp005<b>.</b>&quot;Welding20&quot;<b>,</b><b> </b>0<b>)</b><b>)</b><b> </b><b>As</b><b> </b>&quot;Welding20&quot;<b>,</b>
<b>        </b><b>sum</b><b>(</b><b>COALESCE</b><b>(</b>tcp001<b>.</b>&quot;Welding20&quot;<b>,</b><b> </b>0<b>)</b><b>+</b><b>COALESCE</b><b>(</b>tcp002<b>.</b>&quot;Welding20&quot;<b>,</b><b> </b>0<b>)</b><b>+</b><b>COALESCE</b><b>(</b>tcp003<b>.</b>&quot;Welding20&quot;<b>,</b><b> </b>0<b>)</b><b>+</b><b> </b><b>COALESCE</b><b>(</b>tcp004<b>.</b>&quot;Welding20&quot;<b>,</b><b> </b>0<b>)</b><b> </b><b>+</b><b>COALESCE</b><b>(</b>tcp005<b>.</b>&quot;Welding20&quot;<b>,</b><b> </b>0<b>)</b><b>)</b><b>*</b>
<b>         </b><b>iif</b><b>(</b><b>COALESCE</b><b>(</b>drw<b>.</b>&quot;Quantity&quot;<b>,</b><b> </b>0<b>)</b><b>&gt;</b>0<b>,</b>drw<b>.</b>&quot;Quantity&quot;<b>,</b><b>COALESCE</b><b>(</b>drw<b>.</b>&quot;QuantityR&quot;<b>,</b><b> </b>0<b>)</b><b>+</b><b>COALESCE</b><b>(</b>drw<b>.</b>&quot;QuantityL&quot;<b>,</b><b> </b>0<b>)</b><b>)</b><b> </b><b>As</b><b> </b>&quot;Welding20Total&quot;<b>,</b>
<b>        </b><b>sum</b><b>(</b><b>COALESCE</b><b>(</b>tcp001<b>.</b>&quot;GasArCO2&quot;<b>,</b><b> </b>0<b>)</b><b>+</b><b>COALESCE</b><b>(</b>tcp002<b>.</b>&quot;GasArCO2&quot;<b>,</b><b> </b>0<b>)</b><b>+</b><b>COALESCE</b><b>(</b>tcp003<b>.</b>&quot;GasArCO2&quot;<b>,</b><b> </b>0<b>)</b><b>+</b><b> </b><b>COALESCE</b><b>(</b>tcp004<b>.</b>&quot;GasArCO2&quot;<b>,</b><b> </b>0<b>)</b><b> </b><b>+</b><b>COALESCE</b><b>(</b>tcp005<b>.</b>&quot;GasArCO2&quot;<b>,</b><b> </b>0<b>)</b><b>)</b><b> </b><b>As</b><b> </b>&quot;GasArCO2&quot;<b>,</b>
<b>        </b><b>sum</b><b>(</b><b>COALESCE</b><b>(</b>tcp001<b>.</b>&quot;GasArCO2&quot;<b>,</b><b> </b>0<b>)</b><b>+</b><b>COALESCE</b><b>(</b>tcp002<b>.</b>&quot;GasArCO2&quot;<b>,</b><b> </b>0<b>)</b><b>+</b><b>COALESCE</b><b>(</b>tcp003<b>.</b>&quot;GasArCO2&quot;<b>,</b><b> </b>0<b>)</b><b>+</b><b> </b><b>COALESCE</b><b>(</b>tcp004<b>.</b>&quot;GasArCO2&quot;<b>,</b><b> </b>0<b>)</b><b> </b><b>+</b><b>COALESCE</b><b>(</b>tcp005<b>.</b>&quot;GasArCO2&quot;<b>,</b><b> </b>0<b>)</b><b>)</b><b>*</b>
<b>         </b><b>iif</b><b>(</b><b>COALESCE</b><b>(</b>drw<b>.</b>&quot;Quantity&quot;<b>,</b><b> </b>0<b>)</b><b>&gt;</b>0<b>,</b>drw<b>.</b>&quot;Quantity&quot;<b>,</b><b>COALESCE</b><b>(</b>drw<b>.</b>&quot;QuantityR&quot;<b>,</b><b> </b>0<b>)</b><b>+</b><b>COALESCE</b><b>(</b>drw<b>.</b>&quot;QuantityL&quot;<b>,</b><b> </b>0<b>)</b><b>)</b><b> </b><b>As</b><b> </b>&quot;GasArCO2Total&quot;<b>,</b>
<b>        </b><b>sum</b><b>(</b><b>COALESCE</b><b>(</b>tcp001<b>.</b>&quot;GasCO3&quot;<b>,</b><b> </b>0<b>)</b><b>+</b><b>COALESCE</b><b>(</b>tcp002<b>.</b>&quot;GasCO3&quot;<b>,</b><b> </b>0<b>)</b><b>+</b><b>COALESCE</b><b>(</b>tcp003<b>.</b>&quot;GasCO3&quot;<b>,</b><b> </b>0<b>)</b><b>+</b><b> </b><b>COALESCE</b><b>(</b>tcp004<b>.</b>&quot;GasCO3&quot;<b>,</b><b> </b>0<b>)</b><b> </b><b>+</b><b>COALESCE</b><b>(</b>tcp005<b>.</b>&quot;GasCO3&quot;<b>,</b><b> </b>0<b>)</b><b>)</b><b> </b><b>As</b><b> </b>&quot;GasCO3&quot;<b>,</b>
<b>        </b><b>sum</b><b>(</b><b>COALESCE</b><b>(</b>tcp001<b>.</b>&quot;GasCO3&quot;<b>,</b><b> </b>0<b>)</b><b>+</b><b>COALESCE</b><b>(</b>tcp002<b>.</b>&quot;GasCO3&quot;<b>,</b><b> </b>0<b>)</b><b>+</b><b>COALESCE</b><b>(</b>tcp003<b>.</b>&quot;GasCO3&quot;<b>,</b><b> </b>0<b>)</b><b>+</b><b> </b><b>COALESCE</b><b>(</b>tcp004<b>.</b>&quot;GasCO3&quot;<b>,</b><b> </b>0<b>)</b><b> </b><b>+</b><b>COALESCE</b><b>(</b>tcp005<b>.</b>&quot;GasCO3&quot;<b>,</b><b> </b>0<b>)</b><b>)</b><b>*</b>
<b>         </b><b>iif</b><b>(</b><b>COALESCE</b><b>(</b>drw<b>.</b>&quot;Quantity&quot;<b>,</b><b> </b>0<b>)</b><b>&gt;</b>0<b>,</b>drw<b>.</b>&quot;Quantity&quot;<b>,</b><b>COALESCE</b><b>(</b>drw<b>.</b>&quot;QuantityR&quot;<b>,</b><b> </b>0<b>)</b><b>+</b><b>COALESCE</b><b>(</b>drw<b>.</b>&quot;QuantityL&quot;<b>,</b><b> </b>0<b>)</b><b>)</b><b> </b><b>As</b><b> </b>&quot;GasCO3Total&quot;<b>,</b>
<b>        </b><b>sum</b><b>(</b><b>COALESCE</b><b>(</b>tcp001<b>.</b>&quot;GasAr&quot;<b>,</b><b> </b>0<b>)</b><b>+</b><b>COALESCE</b><b>(</b>tcp002<b>.</b>&quot;GasAr&quot;<b>,</b><b> </b>0<b>)</b><b>+</b><b>COALESCE</b><b>(</b>tcp003<b>.</b>&quot;GasAr&quot;<b>,</b><b> </b>0<b>)</b><b>+</b><b> </b><b>COALESCE</b><b>(</b>tcp004<b>.</b>&quot;GasAr&quot;<b>,</b><b> </b>0<b>)</b><b> </b><b>+</b><b>COALESCE</b><b>(</b>tcp005<b>.</b>&quot;GasAr&quot;<b>,</b><b> </b>0<b>)</b><b>)</b><b> </b><b>As</b><b> </b>&quot;GasAr&quot;<b>,</b>
<b>        </b><b>sum</b><b>(</b><b>COALESCE</b><b>(</b>tcp001<b>.</b>&quot;GasAr&quot;<b>,</b><b> </b>0<b>)</b><b>+</b><b>COALESCE</b><b>(</b>tcp002<b>.</b>&quot;GasAr&quot;<b>,</b><b> </b>0<b>)</b><b>+</b><b>COALESCE</b><b>(</b>tcp003<b>.</b>&quot;GasAr&quot;<b>,</b><b> </b>0<b>)</b><b>+</b><b> </b><b>COALESCE</b><b>(</b>tcp004<b>.</b>&quot;GasAr&quot;<b>,</b><b> </b>0<b>)</b><b> </b><b>+</b><b>COALESCE</b><b>(</b>tcp005<b>.</b>&quot;GasAr&quot;<b>,</b><b> </b>0<b>)</b><b>)</b><b>*</b>
<b>         </b><b>iif</b><b>(</b><b>COALESCE</b><b>(</b>drw<b>.</b>&quot;Quantity&quot;<b>,</b><b> </b>0<b>)</b><b>&gt;</b>0<b>,</b>drw<b>.</b>&quot;Quantity&quot;<b>,</b><b>COALESCE</b><b>(</b>drw<b>.</b>&quot;QuantityR&quot;<b>,</b><b> </b>0<b>)</b><b>+</b><b>COALESCE</b><b>(</b>drw<b>.</b>&quot;QuantityL&quot;<b>,</b><b> </b>0<b>)</b><b>)</b><b> </b><b>As</b><b> </b>&quot;GasArTotal&quot;<b>,</b>
<b>        </b><b>sum</b><b>(</b><b>COALESCE</b><b>(</b>tcp001<b>.</b>&quot;WeldingElektrod&quot;<b>,</b><b> </b>0<b>)</b><b>+</b><b>COALESCE</b><b>(</b>tcp002<b>.</b>&quot;WeldingElektrod&quot;<b>,</b><b> </b>0<b>)</b><b>+</b><b>COALESCE</b><b>(</b>tcp003<b>.</b>&quot;WeldingElektrod&quot;<b>,</b><b> </b>0<b>)</b><b>+</b><b> </b><b>COALESCE</b><b>(</b>tcp004<b>.</b>&quot;WeldingElektrod&quot;<b>,</b><b> </b>0<b>)</b><b> </b><b>+</b><b>COALESCE</b><b>(</b>tcp005<b>.</b>&quot;WeldingElektrod&quot;<b>,</b><b> </b>0<b>)</b><b>)</b><b> </b><b>As</b><b> </b>&quot;WeldingElektrod&quot;<b>,</b>
<b>        </b><b>sum</b><b>(</b><b>COALESCE</b><b>(</b>tcp001<b>.</b>&quot;WeldingElektrod&quot;<b>,</b><b> </b>0<b>)</b><b>+</b><b>COALESCE</b><b>(</b>tcp002<b>.</b>&quot;WeldingElektrod&quot;<b>,</b><b> </b>0<b>)</b><b>+</b><b>COALESCE</b><b>(</b>tcp003<b>.</b>&quot;WeldingElektrod&quot;<b>,</b><b> </b>0<b>)</b><b>+</b><b> </b><b>COALESCE</b><b>(</b>tcp004<b>.</b>&quot;WeldingElektrod&quot;<b>,</b><b> </b>0<b>)</b><b> </b><b>+</b><b>COALESCE</b><b>(</b>tcp005<b>.</b>&quot;WeldingElektrod&quot;<b>,</b><b> </b>0<b>)</b><b>)</b><b>*</b>
<b>         </b><b>iif</b><b>(</b><b>COALESCE</b><b>(</b>drw<b>.</b>&quot;Quantity&quot;<b>,</b><b> </b>0<b>)</b><b>&gt;</b>0<b>,</b>drw<b>.</b>&quot;Quantity&quot;<b>,</b><b>COALESCE</b><b>(</b>drw<b>.</b>&quot;QuantityR&quot;<b>,</b><b> </b>0<b>)</b><b>+</b><b>COALESCE</b><b>(</b>drw<b>.</b>&quot;QuantityL&quot;<b>,</b><b> </b>0<b>)</b><b>)</b><b> </b><b>As</b><b> </b>&quot;WeldingElektrodTotal&quot;<b>,</b>
<b>        </b><b>sum</b><b>(</b><b>COALESCE</b><b>(</b>tcp001<b>.</b>&quot;GasO2&quot;<b>,</b><b> </b>0<b>)</b><b>+</b><b>COALESCE</b><b>(</b>tcp002<b>.</b>&quot;GasO2&quot;<b>,</b><b> </b>0<b>)</b><b>+</b><b>COALESCE</b><b>(</b>tcp003<b>.</b>&quot;GasO2&quot;<b>,</b><b> </b>0<b>)</b><b>+</b><b> </b><b>COALESCE</b><b>(</b>tcp004<b>.</b>&quot;GasO2&quot;<b>,</b><b> </b>0<b>)</b><b> </b><b>+</b><b>COALESCE</b><b>(</b>tcp005<b>.</b>&quot;GasO2&quot;<b>,</b><b> </b>0<b>)</b><b>)</b><b> </b><b>As</b><b> </b>&quot;GasO2&quot;<b>,</b>
<b>        </b><b>sum</b><b>(</b><b>COALESCE</b><b>(</b>tcp001<b>.</b>&quot;GasO2&quot;<b>,</b><b> </b>0<b>)</b><b>+</b><b>COALESCE</b><b>(</b>tcp002<b>.</b>&quot;GasO2&quot;<b>,</b><b> </b>0<b>)</b><b>+</b><b>COALESCE</b><b>(</b>tcp003<b>.</b>&quot;GasO2&quot;<b>,</b><b> </b>0<b>)</b><b>+</b><b> </b><b>COALESCE</b><b>(</b>tcp004<b>.</b>&quot;GasO2&quot;<b>,</b><b> </b>0<b>)</b><b> </b><b>+</b><b>COALESCE</b><b>(</b>tcp005<b>.</b>&quot;GasO2&quot;<b>,</b><b> </b>0<b>)</b><b>)</b><b>*</b>
<b>         </b><b>iif</b><b>(</b><b>COALESCE</b><b>(</b>drw<b>.</b>&quot;Quantity&quot;<b>,</b><b> </b>0<b>)</b><b>&gt;</b>0<b>,</b>drw<b>.</b>&quot;Quantity&quot;<b>,</b><b>COALESCE</b><b>(</b>drw<b>.</b>&quot;QuantityR&quot;<b>,</b><b> </b>0<b>)</b><b>+</b><b>COALESCE</b><b>(</b>drw<b>.</b>&quot;QuantityL&quot;<b>,</b><b> </b>0<b>)</b><b>)</b><b> </b><b>As</b><b> </b>&quot;GasO2Total&quot;<b>,</b>
<b>        </b><b>sum</b><b>(</b><b>COALESCE</b><b>(</b>tcp001<b>.</b>&quot;GasNature&quot;<b>,</b><b> </b>0<b>)</b><b>+</b><b>COALESCE</b><b>(</b>tcp002<b>.</b>&quot;GasNature&quot;<b>,</b><b> </b>0<b>)</b><b>+</b><b>COALESCE</b><b>(</b>tcp003<b>.</b>&quot;GasNature&quot;<b>,</b><b> </b>0<b>)</b><b>+</b><b> </b><b>COALESCE</b><b>(</b>tcp004<b>.</b>&quot;GasNature&quot;<b>,</b><b> </b>0<b>)</b><b> </b><b>+</b><b>COALESCE</b><b>(</b>tcp005<b>.</b>&quot;GasNature&quot;<b>,</b><b> </b>0<b>)</b><b>)</b><b> </b><b>As</b><b> </b>&quot;GasNature&quot;<b>,</b>
<b>        </b><b>sum</b><b>(</b><b>COALESCE</b><b>(</b>tcp001<b>.</b>&quot;GasNature&quot;<b>,</b><b> </b>0<b>)</b><b>+</b><b>COALESCE</b><b>(</b>tcp002<b>.</b>&quot;GasNature&quot;<b>,</b><b> </b>0<b>)</b><b>+</b><b>COALESCE</b><b>(</b>tcp003<b>.</b>&quot;GasNature&quot;<b>,</b><b> </b>0<b>)</b><b>+</b><b> </b><b>COALESCE</b><b>(</b>tcp004<b>.</b>&quot;GasNature&quot;<b>,</b><b> </b>0<b>)</b><b> </b><b>+</b><b>COALESCE</b><b>(</b>tcp005<b>.</b>&quot;GasNature&quot;<b>,</b><b> </b>0<b>)</b><b>)</b><b>*</b>
<b>         </b><b>iif</b><b>(</b><b>COALESCE</b><b>(</b>drw<b>.</b>&quot;Quantity&quot;<b>,</b><b> </b>0<b>)</b><b>&gt;</b>0<b>,</b>drw<b>.</b>&quot;Quantity&quot;<b>,</b><b>COALESCE</b><b>(</b>drw<b>.</b>&quot;QuantityR&quot;<b>,</b><b> </b>0<b>)</b><b>+</b><b>COALESCE</b><b>(</b>drw<b>.</b>&quot;QuantityL&quot;<b>,</b><b> </b>0<b>)</b><b>)</b><b> </b><b>As</b><b> </b>&quot;GasNatureTotal&quot;<b>,</b>
<b>        </b><b>sum</b><b>(</b><b>COALESCE</b><b>(</b>tcp001<b>.</b>&quot;GasN2&quot;<b>,</b><b> </b>0<b>)</b><b>+</b><b>COALESCE</b><b>(</b>tcp002<b>.</b>&quot;GasN2&quot;<b>,</b><b> </b>0<b>)</b><b>+</b><b>COALESCE</b><b>(</b>tcp003<b>.</b>&quot;GasN2&quot;<b>,</b><b> </b>0<b>)</b><b>+</b><b> </b><b>COALESCE</b><b>(</b>tcp004<b>.</b>&quot;GasN2&quot;<b>,</b><b> </b>0<b>)</b><b> </b><b>+</b><b>COALESCE</b><b>(</b>tcp005<b>.</b>&quot;GasN2&quot;<b>,</b><b> </b>0<b>)</b><b>)</b><b> </b><b>As</b><b> </b>&quot;GasN2&quot;<b>,</b>
<b>        </b><b>sum</b><b>(</b><b>COALESCE</b><b>(</b>tcp001<b>.</b>&quot;GasN2&quot;<b>,</b><b> </b>0<b>)</b><b>+</b><b>COALESCE</b><b>(</b>tcp002<b>.</b>&quot;GasN2&quot;<b>,</b><b> </b>0<b>)</b><b>+</b><b>COALESCE</b><b>(</b>tcp003<b>.</b>&quot;GasN2&quot;<b>,</b><b> </b>0<b>)</b><b>+</b><b> </b><b>COALESCE</b><b>(</b>tcp004<b>.</b>&quot;GasN2&quot;<b>,</b><b> </b>0<b>)</b><b> </b><b>+</b><b>COALESCE</b><b>(</b>tcp005<b>.</b>&quot;GasN2&quot;<b>,</b><b> </b>0<b>)</b><b>)</b><b>*</b>
<b>         </b><b>iif</b><b>(</b><b>COALESCE</b><b>(</b>drw<b>.</b>&quot;Quantity&quot;<b>,</b><b> </b>0<b>)</b><b>&gt;</b>0<b>,</b>drw<b>.</b>&quot;Quantity&quot;<b>,</b><b>COALESCE</b><b>(</b>drw<b>.</b>&quot;QuantityR&quot;<b>,</b><b> </b>0<b>)</b><b>+</b><b>COALESCE</b><b>(</b>drw<b>.</b>&quot;QuantityL&quot;<b>,</b><b> </b>0<b>)</b><b>)</b><b> </b><b>As</b><b> </b>&quot;GasN2Total&quot;<b>,</b>
<b>        </b><b>sum</b><b>(</b><b>COALESCE</b><b>(</b>tcp001<b>.</b>&quot;HardKapci881&quot;<b>,</b><b> </b>0<b>)</b><b>+</b><b>COALESCE</b><b>(</b>tcp002<b>.</b>&quot;HardKapci881&quot;<b>,</b><b> </b>0<b>)</b><b>+</b><b>COALESCE</b><b>(</b>tcp003<b>.</b>&quot;HardKapci881&quot;<b>,</b><b> </b>0<b>)</b><b>+</b><b> </b><b>COALESCE</b><b>(</b>tcp004<b>.</b>&quot;HardKapci881&quot;<b>,</b><b> </b>0<b>)</b><b> </b><b>+</b><b>COALESCE</b><b>(</b>tcp005<b>.</b>&quot;HardKapci881&quot;<b>,</b><b> </b>0<b>)</b><b>)</b><b> </b><b>As</b><b> </b>&quot;HardKapci881&quot;<b>,</b>
<b>        </b><b>sum</b><b>(</b><b>COALESCE</b><b>(</b>tcp001<b>.</b>&quot;HardKapci881&quot;<b>,</b><b> </b>0<b>)</b><b>+</b><b>COALESCE</b><b>(</b>tcp002<b>.</b>&quot;HardKapci881&quot;<b>,</b><b> </b>0<b>)</b><b>+</b><b>COALESCE</b><b>(</b>tcp003<b>.</b>&quot;HardKapci881&quot;<b>,</b><b> </b>0<b>)</b><b>+</b><b> </b><b>COALESCE</b><b>(</b>tcp004<b>.</b>&quot;HardKapci881&quot;<b>,</b><b> </b>0<b>)</b><b> </b><b>+</b><b>COALESCE</b><b>(</b>tcp005<b>.</b>&quot;HardKapci881&quot;<b>,</b><b> </b>0<b>)</b><b>)</b><b>*</b>
<b>         </b><b>iif</b><b>(</b><b>COALESCE</b><b>(</b>drw<b>.</b>&quot;Quantity&quot;<b>,</b><b> </b>0<b>)</b><b>&gt;</b>0<b>,</b>drw<b>.</b>&quot;Quantity&quot;<b>,</b><b>COALESCE</b><b>(</b>drw<b>.</b>&quot;QuantityR&quot;<b>,</b><b> </b>0<b>)</b><b>+</b><b>COALESCE</b><b>(</b>drw<b>.</b>&quot;QuantityL&quot;<b>,</b><b> </b>0<b>)</b><b>)</b><b> </b><b>As</b><b> </b>&quot;HardKapci881Total&quot;<b>,</b>
<b>        </b><b>sum</b><b>(</b><b>COALESCE</b><b>(</b>tcp001<b>.</b>&quot;HardKapciHs6055&quot;<b>,</b><b> </b>0<b>)</b><b>+</b><b>COALESCE</b><b>(</b>tcp002<b>.</b>&quot;HardKapciHs6055&quot;<b>,</b><b> </b>0<b>)</b><b>+</b><b>COALESCE</b><b>(</b>tcp003<b>.</b>&quot;HardKapciHs6055&quot;<b>,</b><b> </b>0<b>)</b><b>+</b><b> </b><b>COALESCE</b><b>(</b>tcp004<b>.</b>&quot;HardKapciHs6055&quot;<b>,</b><b> </b>0<b>)</b><b> </b><b>+</b><b>COALESCE</b><b>(</b>tcp005<b>.</b>&quot;HardKapciHs6055&quot;<b>,</b><b> </b>0<b>)</b><b>)</b><b> </b><b>As</b><b> </b>&quot;HardKapciHs6055&quot;<b>,</b>
<b>        </b><b>sum</b><b>(</b><b>COALESCE</b><b>(</b>tcp001<b>.</b>&quot;HardKapciHs6055&quot;<b>,</b><b> </b>0<b>)</b><b>+</b><b>COALESCE</b><b>(</b>tcp002<b>.</b>&quot;HardKapciHs6055&quot;<b>,</b><b> </b>0<b>)</b><b>+</b><b>COALESCE</b><b>(</b>tcp003<b>.</b>&quot;HardKapciHs6055&quot;<b>,</b><b> </b>0<b>)</b><b>+</b><b> </b><b>COALESCE</b><b>(</b>tcp004<b>.</b>&quot;HardKapciHs6055&quot;<b>,</b><b> </b>0<b>)</b><b> </b><b>+</b><b>COALESCE</b><b>(</b>tcp005<b>.</b>&quot;HardKapciHs6055&quot;<b>,</b><b> </b>0<b>)</b><b>)</b><b>*</b>
<b>         </b><b>iif</b><b>(</b><b>COALESCE</b><b>(</b>drw<b>.</b>&quot;Quantity&quot;<b>,</b><b> </b>0<b>)</b><b>&gt;</b>0<b>,</b>drw<b>.</b>&quot;Quantity&quot;<b>,</b><b>COALESCE</b><b>(</b>drw<b>.</b>&quot;QuantityR&quot;<b>,</b><b> </b>0<b>)</b><b>+</b><b>COALESCE</b><b>(</b>drw<b>.</b>&quot;QuantityL&quot;<b>,</b><b> </b>0<b>)</b><b>)</b><b> </b><b>As</b><b> </b>&quot;HardKapciHs6055Total&quot;<b>,</b>
<b>        </b><b>sum</b><b>(</b><b>COALESCE</b><b>(</b>tcp001<b>.</b>&quot;HardKapci126&quot;<b>,</b><b> </b>0<b>)</b><b>+</b><b>COALESCE</b><b>(</b>tcp002<b>.</b>&quot;HardKapci126&quot;<b>,</b><b> </b>0<b>)</b><b>+</b><b>COALESCE</b><b>(</b>tcp003<b>.</b>&quot;HardKapci126&quot;<b>,</b><b> </b>0<b>)</b><b>+</b><b> </b><b>COALESCE</b><b>(</b>tcp004<b>.</b>&quot;HardKapci126&quot;<b>,</b><b> </b>0<b>)</b><b> </b><b>+</b><b>COALESCE</b><b>(</b>tcp005<b>.</b>&quot;HardKapci126&quot;<b>,</b><b> </b>0<b>)</b><b>)</b><b> </b><b>As</b><b> </b>&quot;HardKapci126&quot;<b>,</b>
<b>        </b><b>sum</b><b>(</b><b>COALESCE</b><b>(</b>tcp001<b>.</b>&quot;HardKapci126&quot;<b>,</b><b> </b>0<b>)</b><b>+</b><b>COALESCE</b><b>(</b>tcp002<b>.</b>&quot;HardKapci126&quot;<b>,</b><b> </b>0<b>)</b><b>+</b><b>COALESCE</b><b>(</b>tcp003<b>.</b>&quot;HardKapci126&quot;<b>,</b><b> </b>0<b>)</b><b>+</b><b> </b><b>COALESCE</b><b>(</b>tcp004<b>.</b>&quot;HardKapci126&quot;<b>,</b><b> </b>0<b>)</b><b> </b><b>+</b><b>COALESCE</b><b>(</b>tcp005<b>.</b>&quot;HardKapci126&quot;<b>,</b><b> </b>0<b>)</b><b>)</b><b>*</b>
<b>         </b><b>iif</b><b>(</b><b>COALESCE</b><b>(</b>drw<b>.</b>&quot;Quantity&quot;<b>,</b><b> </b>0<b>)</b><b>&gt;</b>0<b>,</b>drw<b>.</b>&quot;Quantity&quot;<b>,</b><b>COALESCE</b><b>(</b>drw<b>.</b>&quot;QuantityR&quot;<b>,</b><b> </b>0<b>)</b><b>+</b><b>COALESCE</b><b>(</b>drw<b>.</b>&quot;QuantityL&quot;<b>,</b><b> </b>0<b>)</b><b>)</b><b> </b><b>As</b><b> </b>&quot;HardKapci126Total&quot;<b>,</b>
<b>        </b><b>sum</b><b>(</b><b>COALESCE</b><b>(</b>tcp001<b>.</b>&quot;HardKapciPEPutty&quot;<b>,</b><b> </b>0<b>)</b><b>+</b><b>COALESCE</b><b>(</b>tcp002<b>.</b>&quot;HardKapciPEPutty&quot;<b>,</b><b> </b>0<b>)</b><b>+</b><b>COALESCE</b><b>(</b>tcp003<b>.</b>&quot;HardKapciPEPutty&quot;<b>,</b><b> </b>0<b>)</b><b>+</b><b> </b><b>COALESCE</b><b>(</b>tcp004<b>.</b>&quot;HardKapciPEPutty&quot;<b>,</b><b> </b>0<b>)</b><b> </b><b>+</b><b>COALESCE</b><b>(</b>tcp005<b>.</b>&quot;HardKapciPEPutty&quot;<b>,</b><b> </b>0<b>)</b><b>)</b><b> </b><b>As</b><b> </b>&quot;HardKapciPEPutty&quot;<b>,</b>
<b>        </b><b>sum</b><b>(</b><b>COALESCE</b><b>(</b>tcp001<b>.</b>&quot;HardKapciPEPutty&quot;<b>,</b><b> </b>0<b>)</b><b>+</b><b>COALESCE</b><b>(</b>tcp002<b>.</b>&quot;HardKapciPEPutty&quot;<b>,</b><b> </b>0<b>)</b><b>+</b><b>COALESCE</b><b>(</b>tcp003<b>.</b>&quot;HardKapciPEPutty&quot;<b>,</b><b> </b>0<b>)</b><b>+</b><b> </b><b>COALESCE</b><b>(</b>tcp004<b>.</b>&quot;HardKapciPEPutty&quot;<b>,</b><b> </b>0<b>)</b><b> </b><b>+</b><b>COALESCE</b><b>(</b>tcp005<b>.</b>&quot;HardKapciPEPutty&quot;<b>,</b><b> </b>0<b>)</b><b>)</b><b>*</b>
<b>         </b><b>iif</b><b>(</b><b>COALESCE</b><b>(</b>drw<b>.</b>&quot;Quantity&quot;<b>,</b><b> </b>0<b>)</b><b>&gt;</b>0<b>,</b>drw<b>.</b>&quot;Quantity&quot;<b>,</b><b>COALESCE</b><b>(</b>drw<b>.</b>&quot;QuantityR&quot;<b>,</b><b> </b>0<b>)</b><b>+</b><b>COALESCE</b><b>(</b>drw<b>.</b>&quot;QuantityL&quot;<b>,</b><b> </b>0<b>)</b><b>)</b><b> </b><b>As</b><b> </b>&quot;HardKapciPEPuttyTotal&quot;<b>,</b>
<b>        </b><b>sum</b><b>(</b><b>COALESCE</b><b>(</b>tcp001<b>.</b>&quot;HardKapci2KMS651&quot;<b>,</b><b> </b>0<b>)</b><b>+</b><b>COALESCE</b><b>(</b>tcp002<b>.</b>&quot;HardKapci2KMS651&quot;<b>,</b><b> </b>0<b>)</b><b>+</b><b>COALESCE</b><b>(</b>tcp003<b>.</b>&quot;HardKapci2KMS651&quot;<b>,</b><b> </b>0<b>)</b><b>+</b><b> </b><b>COALESCE</b><b>(</b>tcp004<b>.</b>&quot;HardKapci2KMS651&quot;<b>,</b><b> </b>0<b>)</b><b> </b><b>+</b><b>COALESCE</b><b>(</b>tcp005<b>.</b>&quot;HardKapci2KMS651&quot;<b>,</b><b> </b>0<b>)</b><b>)</b><b> </b><b>As</b><b> </b>&quot;HardKapci2KMS651&quot;<b>,</b>
<b>        </b><b>sum</b><b>(</b><b>COALESCE</b><b>(</b>tcp001<b>.</b>&quot;HardKapci2KMS651&quot;<b>,</b><b> </b>0<b>)</b><b>+</b><b>COALESCE</b><b>(</b>tcp002<b>.</b>&quot;HardKapci2KMS651&quot;<b>,</b><b> </b>0<b>)</b><b>+</b><b>COALESCE</b><b>(</b>tcp003<b>.</b>&quot;HardKapci2KMS651&quot;<b>,</b><b> </b>0<b>)</b><b>+</b><b> </b><b>COALESCE</b><b>(</b>tcp004<b>.</b>&quot;HardKapci2KMS651&quot;<b>,</b><b> </b>0<b>)</b><b> </b><b>+</b><b>COALESCE</b><b>(</b>tcp005<b>.</b>&quot;HardKapci2KMS651&quot;<b>,</b><b> </b>0<b>)</b><b>)</b><b>*</b>
<b>         </b><b>iif</b><b>(</b><b>COALESCE</b><b>(</b>drw<b>.</b>&quot;Quantity&quot;<b>,</b><b> </b>0<b>)</b><b>&gt;</b>0<b>,</b>drw<b>.</b>&quot;Quantity&quot;<b>,</b><b>COALESCE</b><b>(</b>drw<b>.</b>&quot;QuantityR&quot;<b>,</b><b> </b>0<b>)</b><b>+</b><b>COALESCE</b><b>(</b>drw<b>.</b>&quot;QuantityL&quot;<b>,</b><b> </b>0<b>)</b><b>)</b><b> </b><b>As</b><b> </b>&quot;HardKapci2KMS651Total&quot;<b>,</b>
<b>        </b><b>sum</b><b>(</b><b>COALESCE</b><b>(</b>tcp001<b>.</b>&quot;DilKapci881&quot;<b>,</b><b> </b>0<b>)</b><b>+</b><b>COALESCE</b><b>(</b>tcp002<b>.</b>&quot;DilKapci881&quot;<b>,</b><b> </b>0<b>)</b><b>+</b><b>COALESCE</b><b>(</b>tcp003<b>.</b>&quot;DilKapci881&quot;<b>,</b><b> </b>0<b>)</b><b>+</b><b> </b><b>COALESCE</b><b>(</b>tcp004<b>.</b>&quot;DilKapci881&quot;<b>,</b><b> </b>0<b>)</b><b> </b><b>+</b><b>COALESCE</b><b>(</b>tcp005<b>.</b>&quot;DilKapci881&quot;<b>,</b><b> </b>0<b>)</b><b>)</b><b> </b><b>As</b><b> </b>&quot;DilKapci881&quot;<b>,</b>
<b>        </b><b>sum</b><b>(</b><b>COALESCE</b><b>(</b>tcp001<b>.</b>&quot;DilKapci881&quot;<b>,</b><b> </b>0<b>)</b><b>+</b><b>COALESCE</b><b>(</b>tcp002<b>.</b>&quot;DilKapci881&quot;<b>,</b><b> </b>0<b>)</b><b>+</b><b>COALESCE</b><b>(</b>tcp003<b>.</b>&quot;DilKapci881&quot;<b>,</b><b> </b>0<b>)</b><b>+</b><b> </b><b>COALESCE</b><b>(</b>tcp004<b>.</b>&quot;DilKapci881&quot;<b>,</b><b> </b>0<b>)</b><b> </b><b>+</b><b>COALESCE</b><b>(</b>tcp005<b>.</b>&quot;DilKapci881&quot;<b>,</b><b> </b>0<b>)</b><b>)</b><b>*</b>
<b>         </b><b>iif</b><b>(</b><b>COALESCE</b><b>(</b>drw<b>.</b>&quot;Quantity&quot;<b>,</b><b> </b>0<b>)</b><b>&gt;</b>0<b>,</b>drw<b>.</b>&quot;Quantity&quot;<b>,</b><b>COALESCE</b><b>(</b>drw<b>.</b>&quot;QuantityR&quot;<b>,</b><b> </b>0<b>)</b><b>+</b><b>COALESCE</b><b>(</b>drw<b>.</b>&quot;QuantityL&quot;<b>,</b><b> </b>0<b>)</b><b>)</b><b> </b><b>As</b><b> </b>&quot;DilKapci881Total&quot;<b>,</b>
<b>        </b><b>sum</b><b>(</b><b>COALESCE</b><b>(</b>tcp001<b>.</b>&quot;DilKapci2K&quot;<b>,</b><b> </b>0<b>)</b><b>+</b><b>COALESCE</b><b>(</b>tcp002<b>.</b>&quot;DilKapci2K&quot;<b>,</b><b> </b>0<b>)</b><b>+</b><b>COALESCE</b><b>(</b>tcp003<b>.</b>&quot;DilKapci2K&quot;<b>,</b><b> </b>0<b>)</b><b>+</b><b> </b><b>COALESCE</b><b>(</b>tcp004<b>.</b>&quot;DilKapci2K&quot;<b>,</b><b> </b>0<b>)</b><b> </b><b>+</b><b>COALESCE</b><b>(</b>tcp005<b>.</b>&quot;DilKapci2K&quot;<b>,</b><b> </b>0<b>)</b><b>)</b><b> </b><b>As</b><b> </b>&quot;DilKapci2K&quot;<b>,</b>
<b>        </b><b>sum</b><b>(</b><b>COALESCE</b><b>(</b>tcp001<b>.</b>&quot;DilKapci2K&quot;<b>,</b><b> </b>0<b>)</b><b>+</b><b>COALESCE</b><b>(</b>tcp002<b>.</b>&quot;DilKapci2K&quot;<b>,</b><b> </b>0<b>)</b><b>+</b><b>COALESCE</b><b>(</b>tcp003<b>.</b>&quot;DilKapci2K&quot;<b>,</b><b> </b>0<b>)</b><b>+</b><b> </b><b>COALESCE</b><b>(</b>tcp004<b>.</b>&quot;DilKapci2K&quot;<b>,</b><b> </b>0<b>)</b><b> </b><b>+</b><b>COALESCE</b><b>(</b>tcp005<b>.</b>&quot;DilKapci2K&quot;<b>,</b><b> </b>0<b>)</b><b>)</b><b>*</b>
<b>         </b><b>iif</b><b>(</b><b>COALESCE</b><b>(</b>drw<b>.</b>&quot;Quantity&quot;<b>,</b><b> </b>0<b>)</b><b>&gt;</b>0<b>,</b>drw<b>.</b>&quot;Quantity&quot;<b>,</b><b>COALESCE</b><b>(</b>drw<b>.</b>&quot;QuantityR&quot;<b>,</b><b> </b>0<b>)</b><b>+</b><b>COALESCE</b><b>(</b>drw<b>.</b>&quot;QuantityL&quot;<b>,</b><b> </b>0<b>)</b><b>)</b><b> </b><b>As</b><b> </b>&quot;DilKapci2KTotal&quot;<b>,</b>
<b>        </b><b>sum</b><b>(</b><b>COALESCE</b><b>(</b>tcp001<b>.</b>&quot;DilKapci880&quot;<b>,</b><b> </b>0<b>)</b><b>+</b><b>COALESCE</b><b>(</b>tcp002<b>.</b>&quot;DilKapci880&quot;<b>,</b><b> </b>0<b>)</b><b>+</b><b>COALESCE</b><b>(</b>tcp003<b>.</b>&quot;DilKapci880&quot;<b>,</b><b> </b>0<b>)</b><b>+</b><b> </b><b>COALESCE</b><b>(</b>tcp004<b>.</b>&quot;DilKapci880&quot;<b>,</b><b> </b>0<b>)</b><b> </b><b>+</b><b>COALESCE</b><b>(</b>tcp005<b>.</b>&quot;DilKapci880&quot;<b>,</b><b> </b>0<b>)</b><b>)</b><b> </b><b>As</b><b> </b>&quot;DilKapci880&quot;<b>,</b>
<b>        </b><b>sum</b><b>(</b><b>COALESCE</b><b>(</b>tcp001<b>.</b>&quot;DilKapci880&quot;<b>,</b><b> </b>0<b>)</b><b>+</b><b>COALESCE</b><b>(</b>tcp002<b>.</b>&quot;DilKapci880&quot;<b>,</b><b> </b>0<b>)</b><b>+</b><b>COALESCE</b><b>(</b>tcp003<b>.</b>&quot;DilKapci880&quot;<b>,</b><b> </b>0<b>)</b><b>+</b><b> </b><b>COALESCE</b><b>(</b>tcp004<b>.</b>&quot;DilKapci880&quot;<b>,</b><b> </b>0<b>)</b><b> </b><b>+</b><b>COALESCE</b><b>(</b>tcp005<b>.</b>&quot;DilKapci880&quot;<b>,</b><b> </b>0<b>)</b><b>)</b><b>*</b>
<b>         </b><b>iif</b><b>(</b><b>COALESCE</b><b>(</b>drw<b>.</b>&quot;Quantity&quot;<b>,</b><b> </b>0<b>)</b><b>&gt;</b>0<b>,</b>drw<b>.</b>&quot;Quantity&quot;<b>,</b><b>COALESCE</b><b>(</b>drw<b>.</b>&quot;QuantityR&quot;<b>,</b><b> </b>0<b>)</b><b>+</b><b>COALESCE</b><b>(</b>drw<b>.</b>&quot;QuantityL&quot;<b>,</b><b> </b>0<b>)</b><b>)</b><b> </b><b>As</b><b> </b>&quot;DilKapci880Total&quot;<b>,</b>
<b>        </b><b>sum</b><b>(</b><b>COALESCE</b><b>(</b>tcp001<b>.</b>&quot;PrimerKapci125&quot;<b>,</b><b> </b>0<b>)</b><b>+</b><b>COALESCE</b><b>(</b>tcp002<b>.</b>&quot;PrimerKapci125&quot;<b>,</b><b> </b>0<b>)</b><b>+</b><b>COALESCE</b><b>(</b>tcp003<b>.</b>&quot;PrimerKapci125&quot;<b>,</b><b> </b>0<b>)</b><b>+</b><b> </b><b>COALESCE</b><b>(</b>tcp004<b>.</b>&quot;PrimerKapci125&quot;<b>,</b><b> </b>0<b>)</b><b> </b><b>+</b><b>COALESCE</b><b>(</b>tcp005<b>.</b>&quot;PrimerKapci125&quot;<b>,</b><b> </b>0<b>)</b><b>)</b><b> </b><b>As</b><b> </b>&quot;PrimerKapci125&quot;<b>,</b>
<b>        </b><b>sum</b><b>(</b><b>COALESCE</b><b>(</b>tcp001<b>.</b>&quot;PrimerKapci125&quot;<b>,</b><b> </b>0<b>)</b><b>+</b><b>COALESCE</b><b>(</b>tcp002<b>.</b>&quot;PrimerKapci125&quot;<b>,</b><b> </b>0<b>)</b><b>+</b><b>COALESCE</b><b>(</b>tcp003<b>.</b>&quot;PrimerKapci125&quot;<b>,</b><b> </b>0<b>)</b><b>+</b><b> </b><b>COALESCE</b><b>(</b>tcp004<b>.</b>&quot;PrimerKapci125&quot;<b>,</b><b> </b>0<b>)</b><b> </b><b>+</b><b>COALESCE</b><b>(</b>tcp005<b>.</b>&quot;PrimerKapci125&quot;<b>,</b><b> </b>0<b>)</b><b>)</b><b>*</b>
<b>         </b><b>iif</b><b>(</b><b>COALESCE</b><b>(</b>drw<b>.</b>&quot;Quantity&quot;<b>,</b><b> </b>0<b>)</b><b>&gt;</b>0<b>,</b>drw<b>.</b>&quot;Quantity&quot;<b>,</b><b>COALESCE</b><b>(</b>drw<b>.</b>&quot;QuantityR&quot;<b>,</b><b> </b>0<b>)</b><b>+</b><b>COALESCE</b><b>(</b>drw<b>.</b>&quot;QuantityL&quot;<b>,</b><b> </b>0<b>)</b><b>)</b><b> </b><b>As</b><b> </b>&quot;PrimerKapci125Total&quot;<b>,</b>
<b>        </b><b>sum</b><b>(</b><b>COALESCE</b><b>(</b>tcp001<b>.</b>&quot;PrimerKapci633&quot;<b>,</b><b> </b>0<b>)</b><b>+</b><b>COALESCE</b><b>(</b>tcp002<b>.</b>&quot;PrimerKapci633&quot;<b>,</b><b> </b>0<b>)</b><b>+</b><b>COALESCE</b><b>(</b>tcp003<b>.</b>&quot;PrimerKapci633&quot;<b>,</b><b> </b>0<b>)</b><b>+</b><b> </b><b>COALESCE</b><b>(</b>tcp004<b>.</b>&quot;PrimerKapci633&quot;<b>,</b><b> </b>0<b>)</b><b> </b><b>+</b><b>COALESCE</b><b>(</b>tcp005<b>.</b>&quot;PrimerKapci633&quot;<b>,</b><b> </b>0<b>)</b><b>)</b><b> </b><b>As</b><b> </b>&quot;PrimerKapci633&quot;<b>,</b>
<b>        </b><b>sum</b><b>(</b><b>COALESCE</b><b>(</b>tcp001<b>.</b>&quot;PrimerKapci633&quot;<b>,</b><b> </b>0<b>)</b><b>+</b><b>COALESCE</b><b>(</b>tcp002<b>.</b>&quot;PrimerKapci633&quot;<b>,</b><b> </b>0<b>)</b><b>+</b><b>COALESCE</b><b>(</b>tcp003<b>.</b>&quot;PrimerKapci633&quot;<b>,</b><b> </b>0<b>)</b><b>+</b><b> </b><b>COALESCE</b><b>(</b>tcp004<b>.</b>&quot;PrimerKapci633&quot;<b>,</b><b> </b>0<b>)</b><b> </b><b>+</b><b>COALESCE</b><b>(</b>tcp005<b>.</b>&quot;PrimerKapci633&quot;<b>,</b><b> </b>0<b>)</b><b>)</b><b>*</b>
<b>         </b><b>iif</b><b>(</b><b>COALESCE</b><b>(</b>drw<b>.</b>&quot;Quantity&quot;<b>,</b><b> </b>0<b>)</b><b>&gt;</b>0<b>,</b>drw<b>.</b>&quot;Quantity&quot;<b>,</b><b>COALESCE</b><b>(</b>drw<b>.</b>&quot;QuantityR&quot;<b>,</b><b> </b>0<b>)</b><b>+</b><b>COALESCE</b><b>(</b>drw<b>.</b>&quot;QuantityL&quot;<b>,</b><b> </b>0<b>)</b><b>)</b><b> </b><b>As</b><b> </b>&quot;PrimerKapci633Total&quot;<b>,</b>
<b>        </b><b>sum</b><b>(</b><b>COALESCE</b><b>(</b>tcp001<b>.</b>&quot;EnamelKapci641&quot;<b>,</b><b> </b>0<b>)</b><b>+</b><b>COALESCE</b><b>(</b>tcp002<b>.</b>&quot;EnamelKapci641&quot;<b>,</b><b> </b>0<b>)</b><b>+</b><b>COALESCE</b><b>(</b>tcp003<b>.</b>&quot;EnamelKapci641&quot;<b>,</b><b> </b>0<b>)</b><b>+</b><b> </b><b>COALESCE</b><b>(</b>tcp004<b>.</b>&quot;EnamelKapci641&quot;<b>,</b><b> </b>0<b>)</b><b> </b><b>+</b><b>COALESCE</b><b>(</b>tcp005<b>.</b>&quot;EnamelKapci641&quot;<b>,</b><b> </b>0<b>)</b><b>)</b><b> </b><b>As</b><b> </b>&quot;EnamelKapci641&quot;<b>,</b>
<b>        </b><b>sum</b><b>(</b><b>COALESCE</b><b>(</b>tcp001<b>.</b>&quot;EnamelKapci641&quot;<b>,</b><b> </b>0<b>)</b><b>+</b><b>COALESCE</b><b>(</b>tcp002<b>.</b>&quot;EnamelKapci641&quot;<b>,</b><b> </b>0<b>)</b><b>+</b><b>COALESCE</b><b>(</b>tcp003<b>.</b>&quot;EnamelKapci641&quot;<b>,</b><b> </b>0<b>)</b><b>+</b><b> </b><b>COALESCE</b><b>(</b>tcp004<b>.</b>&quot;EnamelKapci641&quot;<b>,</b><b> </b>0<b>)</b><b> </b><b>+</b><b>COALESCE</b><b>(</b>tcp005<b>.</b>&quot;EnamelKapci641&quot;<b>,</b><b> </b>0<b>)</b><b>)</b><b>*</b>
<b>         </b><b>iif</b><b>(</b><b>COALESCE</b><b>(</b>drw<b>.</b>&quot;Quantity&quot;<b>,</b><b> </b>0<b>)</b><b>&gt;</b>0<b>,</b>drw<b>.</b>&quot;Quantity&quot;<b>,</b><b>COALESCE</b><b>(</b>drw<b>.</b>&quot;QuantityR&quot;<b>,</b><b> </b>0<b>)</b><b>+</b><b>COALESCE</b><b>(</b>drw<b>.</b>&quot;QuantityL&quot;<b>,</b><b> </b>0<b>)</b><b>)</b><b> </b><b>As</b><b> </b>&quot;EnamelKapci641Total&quot;<b>,</b>
<b>        </b><b>sum</b><b>(</b><b>COALESCE</b><b>(</b>tcp001<b>.</b>&quot;EnamelKapci670&quot;<b>,</b><b> </b>0<b>)</b><b>+</b><b>COALESCE</b><b>(</b>tcp002<b>.</b>&quot;EnamelKapci670&quot;<b>,</b><b> </b>0<b>)</b><b>+</b><b>COALESCE</b><b>(</b>tcp003<b>.</b>&quot;EnamelKapci670&quot;<b>,</b><b> </b>0<b>)</b><b>+</b><b> </b><b>COALESCE</b><b>(</b>tcp004<b>.</b>&quot;EnamelKapci670&quot;<b>,</b><b> </b>0<b>)</b><b> </b><b>+</b><b>COALESCE</b><b>(</b>tcp005<b>.</b>&quot;EnamelKapci670&quot;<b>,</b><b> </b>0<b>)</b><b>)</b><b> </b><b>As</b><b> </b>&quot;EnamelKapci670&quot;<b>,</b>
<b>        </b><b>sum</b><b>(</b><b>COALESCE</b><b>(</b>tcp001<b>.</b>&quot;EnamelKapci670&quot;<b>,</b><b> </b>0<b>)</b><b>+</b><b>COALESCE</b><b>(</b>tcp002<b>.</b>&quot;EnamelKapci670&quot;<b>,</b><b> </b>0<b>)</b><b>+</b><b>COALESCE</b><b>(</b>tcp003<b>.</b>&quot;EnamelKapci670&quot;<b>,</b><b> </b>0<b>)</b><b>+</b><b> </b><b>COALESCE</b><b>(</b>tcp004<b>.</b>&quot;EnamelKapci670&quot;<b>,</b><b> </b>0<b>)</b><b> </b><b>+</b><b>COALESCE</b><b>(</b>tcp005<b>.</b>&quot;EnamelKapci670&quot;<b>,</b><b> </b>0<b>)</b><b>)</b><b>*</b>
<b>         </b><b>iif</b><b>(</b><b>COALESCE</b><b>(</b>drw<b>.</b>&quot;Quantity&quot;<b>,</b><b> </b>0<b>)</b><b>&gt;</b>0<b>,</b>drw<b>.</b>&quot;Quantity&quot;<b>,</b><b>COALESCE</b><b>(</b>drw<b>.</b>&quot;QuantityR&quot;<b>,</b><b> </b>0<b>)</b><b>+</b><b>COALESCE</b><b>(</b>drw<b>.</b>&quot;QuantityL&quot;<b>,</b><b> </b>0<b>)</b><b>)</b><b> </b><b>As</b><b> </b>&quot;EnamelKapci670Total&quot;<b>,</b>
<b>        </b><b>sum</b><b>(</b><b>COALESCE</b><b>(</b>tcp001<b>.</b>&quot;EnamelKapci6030&quot;<b>,</b><b> </b>0<b>)</b><b>+</b><b>COALESCE</b><b>(</b>tcp002<b>.</b>&quot;EnamelKapci6030&quot;<b>,</b><b> </b>0<b>)</b><b>+</b><b>COALESCE</b><b>(</b>tcp003<b>.</b>&quot;EnamelKapci6030&quot;<b>,</b><b> </b>0<b>)</b><b>+</b><b> </b><b>COALESCE</b><b>(</b>tcp004<b>.</b>&quot;EnamelKapci6030&quot;<b>,</b><b> </b>0<b>)</b><b> </b><b>+</b><b>COALESCE</b><b>(</b>tcp005<b>.</b>&quot;EnamelKapci6030&quot;<b>,</b><b> </b>0<b>)</b><b>)</b><b> </b><b>As</b><b> </b>&quot;EnamelKapci6030&quot;<b>,</b>
<b>        </b><b>sum</b><b>(</b><b>COALESCE</b><b>(</b>tcp001<b>.</b>&quot;EnamelKapci6030&quot;<b>,</b><b> </b>0<b>)</b><b>+</b><b>COALESCE</b><b>(</b>tcp002<b>.</b>&quot;EnamelKapci6030&quot;<b>,</b><b> </b>0<b>)</b><b>+</b><b>COALESCE</b><b>(</b>tcp003<b>.</b>&quot;EnamelKapci6030&quot;<b>,</b><b> </b>0<b>)</b><b>+</b><b> </b><b>COALESCE</b><b>(</b>tcp004<b>.</b>&quot;EnamelKapci6030&quot;<b>,</b><b> </b>0<b>)</b><b> </b><b>+</b><b>COALESCE</b><b>(</b>tcp005<b>.</b>&quot;EnamelKapci6030&quot;<b>,</b><b> </b>0<b>)</b><b>)</b><b>*</b>
<b>         </b><b>iif</b><b>(</b><b>COALESCE</b><b>(</b>drw<b>.</b>&quot;Quantity&quot;<b>,</b><b> </b>0<b>)</b><b>&gt;</b>0<b>,</b>drw<b>.</b>&quot;Quantity&quot;<b>,</b><b>COALESCE</b><b>(</b>drw<b>.</b>&quot;QuantityR&quot;<b>,</b><b> </b>0<b>)</b><b>+</b><b>COALESCE</b><b>(</b>drw<b>.</b>&quot;QuantityL&quot;<b>,</b><b> </b>0<b>)</b><b>)</b><b> </b><b>As</b><b> </b>&quot;EnamelKapci6030Total&quot;<b>,</b>
<b>        </b><b>sum</b><b>(</b><b>COALESCE</b><b>(</b>tcp001<b>.</b>&quot;UniversalSikaflex527&quot;<b>,</b><b> </b>0<b>)</b><b>+</b><b>COALESCE</b><b>(</b>tcp002<b>.</b>&quot;UniversalSikaflex527&quot;<b>,</b><b> </b>0<b>)</b><b>+</b><b>COALESCE</b><b>(</b>tcp003<b>.</b>&quot;UniversalSikaflex527&quot;<b>,</b><b> </b>0<b>)</b><b>+</b><b> </b><b>COALESCE</b><b>(</b>tcp004<b>.</b>&quot;UniversalSikaflex527&quot;<b>,</b><b> </b>0<b>)</b><b> </b><b>+</b><b>COALESCE</b><b>(</b>tcp005<b>.</b>&quot;UniversalSikaflex527&quot;<b>,</b><b> </b>0<b>)</b><b>)</b><b> </b><b>As</b><b> </b>&quot;UniversalSikaflex527&quot;<b>,</b>
<b>        </b><b>sum</b><b>(</b><b>COALESCE</b><b>(</b>tcp001<b>.</b>&quot;UniversalSikaflex527&quot;<b>,</b><b> </b>0<b>)</b><b>+</b><b>COALESCE</b><b>(</b>tcp002<b>.</b>&quot;UniversalSikaflex527&quot;<b>,</b><b> </b>0<b>)</b><b>+</b><b>COALESCE</b><b>(</b>tcp003<b>.</b>&quot;UniversalSikaflex527&quot;<b>,</b><b> </b>0<b>)</b><b>+</b><b> </b><b>COALESCE</b><b>(</b>tcp004<b>.</b>&quot;UniversalSikaflex527&quot;<b>,</b><b> </b>0<b>)</b><b> </b><b>+</b><b>COALESCE</b><b>(</b>tcp005<b>.</b>&quot;UniversalSikaflex527&quot;<b>,</b><b> </b>0<b>)</b><b>)</b><b>*</b>
<b>         </b><b>iif</b><b>(</b><b>COALESCE</b><b>(</b>drw<b>.</b>&quot;Quantity&quot;<b>,</b><b> </b>0<b>)</b><b>&gt;</b>0<b>,</b>drw<b>.</b>&quot;Quantity&quot;<b>,</b><b>COALESCE</b><b>(</b>drw<b>.</b>&quot;QuantityR&quot;<b>,</b><b> </b>0<b>)</b><b>+</b><b>COALESCE</b><b>(</b>drw<b>.</b>&quot;QuantityL&quot;<b>,</b><b> </b>0<b>)</b><b>)</b><b> </b><b>As</b><b> </b>&quot;UniversalSikaflex527Total&quot;<b>,</b>
<b>        </b><b>sum</b><b>(</b><b>COALESCE</b><b>(</b>tcp001<b>.</b>&quot;PuttyKapci350&quot;<b>,</b><b> </b>0<b>)</b><b>+</b><b>COALESCE</b><b>(</b>tcp002<b>.</b>&quot;PuttyKapci350&quot;<b>,</b><b> </b>0<b>)</b><b>+</b><b>COALESCE</b><b>(</b>tcp003<b>.</b>&quot;PuttyKapci350&quot;<b>,</b><b> </b>0<b>)</b><b>+</b><b> </b><b>COALESCE</b><b>(</b>tcp004<b>.</b>&quot;PuttyKapci350&quot;<b>,</b><b> </b>0<b>)</b><b> </b><b>+</b><b>COALESCE</b><b>(</b>tcp005<b>.</b>&quot;PuttyKapci350&quot;<b>,</b><b> </b>0<b>)</b><b>)</b><b> </b><b>As</b><b> </b>&quot;PuttyKapci350&quot;<b>,</b>
<b>        </b><b>sum</b><b>(</b><b>COALESCE</b><b>(</b>tcp001<b>.</b>&quot;PuttyKapci350&quot;<b>,</b><b> </b>0<b>)</b><b>+</b><b>COALESCE</b><b>(</b>tcp002<b>.</b>&quot;PuttyKapci350&quot;<b>,</b><b> </b>0<b>)</b><b>+</b><b>COALESCE</b><b>(</b>tcp003<b>.</b>&quot;PuttyKapci350&quot;<b>,</b><b> </b>0<b>)</b><b>+</b><b> </b><b>COALESCE</b><b>(</b>tcp004<b>.</b>&quot;PuttyKapci350&quot;<b>,</b><b> </b>0<b>)</b><b> </b><b>+</b><b>COALESCE</b><b>(</b>tcp005<b>.</b>&quot;PuttyKapci350&quot;<b>,</b><b> </b>0<b>)</b><b>)</b><b>*</b>
<b>         </b><b>iif</b><b>(</b><b>COALESCE</b><b>(</b>drw<b>.</b>&quot;Quantity&quot;<b>,</b><b> </b>0<b>)</b><b>&gt;</b>0<b>,</b>drw<b>.</b>&quot;Quantity&quot;<b>,</b><b>COALESCE</b><b>(</b>drw<b>.</b>&quot;QuantityR&quot;<b>,</b><b> </b>0<b>)</b><b>+</b><b>COALESCE</b><b>(</b>drw<b>.</b>&quot;QuantityL&quot;<b>,</b><b> </b>0<b>)</b><b>)</b><b> </b><b>As</b><b> </b>&quot;PuttyKapci350Total&quot;<b>,</b>
<b>        </b><b>sum</b><b>(</b><b>COALESCE</b><b>(</b>tcp001<b>.</b>&quot;LaborIntensity001&quot;<b>,</b><b> </b>0<b>)</b><b>+</b><b>COALESCE</b><b>(</b>tcp002<b>.</b>&quot;LaborIntensity001&quot;<b>,</b><b> </b>0<b>)</b><b>+</b><b>COALESCE</b><b>(</b>tcp003<b>.</b>&quot;LaborIntensity001&quot;<b>,</b><b> </b>0<b>)</b><b>+</b><b> </b><b>COALESCE</b><b>(</b>tcp004<b>.</b>&quot;LaborIntensity001&quot;<b>,</b><b> </b>0<b>)</b><b> </b><b>+</b><b>COALESCE</b><b>(</b>tcp005<b>.</b>&quot;LaborIntensity001&quot;<b>,</b><b> </b>0<b>)</b><b>)</b><b> </b><b>As</b><b> </b>&quot;LaborIntensity001&quot;<b>,</b>
<b>        </b><b>sum</b><b>(</b><b>COALESCE</b><b>(</b>tcp001<b>.</b>&quot;LaborIntensity001&quot;<b>,</b><b> </b>0<b>)</b><b>+</b><b>COALESCE</b><b>(</b>tcp002<b>.</b>&quot;LaborIntensity001&quot;<b>,</b><b> </b>0<b>)</b><b>+</b><b>COALESCE</b><b>(</b>tcp003<b>.</b>&quot;LaborIntensity001&quot;<b>,</b><b> </b>0<b>)</b><b>+</b><b> </b><b>COALESCE</b><b>(</b>tcp004<b>.</b>&quot;LaborIntensity001&quot;<b>,</b><b> </b>0<b>)</b><b> </b><b>+</b><b>COALESCE</b><b>(</b>tcp005<b>.</b>&quot;LaborIntensity001&quot;<b>,</b><b> </b>0<b>)</b><b>)</b><b>*</b>
<b>         </b><b>iif</b><b>(</b><b>COALESCE</b><b>(</b>drw<b>.</b>&quot;Quantity&quot;<b>,</b><b> </b>0<b>)</b><b>&gt;</b>0<b>,</b>drw<b>.</b>&quot;Quantity&quot;<b>,</b><b>COALESCE</b><b>(</b>drw<b>.</b>&quot;QuantityR&quot;<b>,</b><b> </b>0<b>)</b><b>+</b><b>COALESCE</b><b>(</b>drw<b>.</b>&quot;QuantityL&quot;<b>,</b><b> </b>0<b>)</b><b>)</b><b> </b><b>As</b><b> </b>&quot;LaborIntensity001Total&quot;<b>,</b>
<b>        </b><b>sum</b><b>(</b><b>COALESCE</b><b>(</b>tcp001<b>.</b>&quot;LaborIntensity002&quot;<b>,</b><b> </b>0<b>)</b><b>+</b><b>COALESCE</b><b>(</b>tcp002<b>.</b>&quot;LaborIntensity002&quot;<b>,</b><b> </b>0<b>)</b><b>+</b><b>COALESCE</b><b>(</b>tcp003<b>.</b>&quot;LaborIntensity002&quot;<b>,</b><b> </b>0<b>)</b><b>+</b><b> </b><b>COALESCE</b><b>(</b>tcp004<b>.</b>&quot;LaborIntensity002&quot;<b>,</b><b> </b>0<b>)</b><b> </b><b>+</b><b>COALESCE</b><b>(</b>tcp005<b>.</b>&quot;LaborIntensity002&quot;<b>,</b><b> </b>0<b>)</b><b>)</b><b> </b><b>As</b><b> </b>&quot;LaborIntensity002&quot;<b>,</b>
<b>        </b><b>sum</b><b>(</b><b>COALESCE</b><b>(</b>tcp001<b>.</b>&quot;LaborIntensity002&quot;<b>,</b><b> </b>0<b>)</b><b>+</b><b>COALESCE</b><b>(</b>tcp002<b>.</b>&quot;LaborIntensity002&quot;<b>,</b><b> </b>0<b>)</b><b>+</b><b>COALESCE</b><b>(</b>tcp003<b>.</b>&quot;LaborIntensity002&quot;<b>,</b><b> </b>0<b>)</b><b>+</b><b> </b><b>COALESCE</b><b>(</b>tcp004<b>.</b>&quot;LaborIntensity002&quot;<b>,</b><b> </b>0<b>)</b><b> </b><b>+</b><b>COALESCE</b><b>(</b>tcp005<b>.</b>&quot;LaborIntensity002&quot;<b>,</b><b> </b>0<b>)</b><b>)</b><b>*</b>
<b>         </b><b>iif</b><b>(</b><b>COALESCE</b><b>(</b>drw<b>.</b>&quot;Quantity&quot;<b>,</b><b> </b>0<b>)</b><b>&gt;</b>0<b>,</b>drw<b>.</b>&quot;Quantity&quot;<b>,</b><b>COALESCE</b><b>(</b>drw<b>.</b>&quot;QuantityR&quot;<b>,</b><b> </b>0<b>)</b><b>+</b><b>COALESCE</b><b>(</b>drw<b>.</b>&quot;QuantityL&quot;<b>,</b><b> </b>0<b>)</b><b>)</b><b> </b><b>As</b><b> </b>&quot;LaborIntensity002Total&quot;<b>,</b>
<b>        </b><b>sum</b><b>(</b><b>COALESCE</b><b>(</b>tcp001<b>.</b>&quot;LaborIntensity003&quot;<b>,</b><b> </b>0<b>)</b><b>+</b><b>COALESCE</b><b>(</b>tcp002<b>.</b>&quot;LaborIntensity003&quot;<b>,</b><b> </b>0<b>)</b><b>+</b><b>COALESCE</b><b>(</b>tcp003<b>.</b>&quot;LaborIntensity003&quot;<b>,</b><b> </b>0<b>)</b><b>+</b><b> </b><b>COALESCE</b><b>(</b>tcp004<b>.</b>&quot;LaborIntensity003&quot;<b>,</b><b> </b>0<b>)</b><b> </b><b>+</b><b>COALESCE</b><b>(</b>tcp005<b>.</b>&quot;LaborIntensity003&quot;<b>,</b><b> </b>0<b>)</b><b>)</b><b> </b><b>As</b><b> </b>&quot;LaborIntensity003&quot;<b>,</b>
<b>        </b><b>sum</b><b>(</b><b>COALESCE</b><b>(</b>tcp001<b>.</b>&quot;LaborIntensity003&quot;<b>,</b><b> </b>0<b>)</b><b>+</b><b>COALESCE</b><b>(</b>tcp002<b>.</b>&quot;LaborIntensity003&quot;<b>,</b><b> </b>0<b>)</b><b>+</b><b>COALESCE</b><b>(</b>tcp003<b>.</b>&quot;LaborIntensity003&quot;<b>,</b><b> </b>0<b>)</b><b>+</b><b> </b><b>COALESCE</b><b>(</b>tcp004<b>.</b>&quot;LaborIntensity003&quot;<b>,</b><b> </b>0<b>)</b><b> </b><b>+</b><b>COALESCE</b><b>(</b>tcp005<b>.</b>&quot;LaborIntensity003&quot;<b>,</b><b> </b>0<b>)</b><b>)</b><b>*</b>
<b>         </b><b>iif</b><b>(</b><b>COALESCE</b><b>(</b>drw<b>.</b>&quot;Quantity&quot;<b>,</b><b> </b>0<b>)</b><b>&gt;</b>0<b>,</b>drw<b>.</b>&quot;Quantity&quot;<b>,</b><b>COALESCE</b><b>(</b>drw<b>.</b>&quot;QuantityR&quot;<b>,</b><b> </b>0<b>)</b><b>+</b><b>COALESCE</b><b>(</b>drw<b>.</b>&quot;QuantityL&quot;<b>,</b><b> </b>0<b>)</b><b>)</b><b> </b><b>As</b><b> </b>&quot;LaborIntensity003Total&quot;<b>,</b>
<b>        </b><b>sum</b><b>(</b><b>COALESCE</b><b>(</b>tcp001<b>.</b>&quot;LaborIntensity004&quot;<b>,</b><b> </b>0<b>)</b><b>+</b><b>COALESCE</b><b>(</b>tcp002<b>.</b>&quot;LaborIntensity004&quot;<b>,</b><b> </b>0<b>)</b><b>+</b><b>COALESCE</b><b>(</b>tcp003<b>.</b>&quot;LaborIntensity004&quot;<b>,</b><b> </b>0<b>)</b><b>+</b><b> </b><b>COALESCE</b><b>(</b>tcp004<b>.</b>&quot;LaborIntensity004&quot;<b>,</b><b> </b>0<b>)</b><b> </b><b>+</b><b>COALESCE</b><b>(</b>tcp005<b>.</b>&quot;LaborIntensity004&quot;<b>,</b><b> </b>0<b>)</b><b>)</b><b> </b><b>As</b><b> </b>&quot;LaborIntensity004&quot;<b>,</b>
<b>        </b><b>sum</b><b>(</b><b>COALESCE</b><b>(</b>tcp001<b>.</b>&quot;LaborIntensity004&quot;<b>,</b><b> </b>0<b>)</b><b>+</b><b>COALESCE</b><b>(</b>tcp002<b>.</b>&quot;LaborIntensity004&quot;<b>,</b><b> </b>0<b>)</b><b>+</b><b>COALESCE</b><b>(</b>tcp003<b>.</b>&quot;LaborIntensity004&quot;<b>,</b><b> </b>0<b>)</b><b>+</b><b> </b><b>COALESCE</b><b>(</b>tcp004<b>.</b>&quot;LaborIntensity004&quot;<b>,</b><b> </b>0<b>)</b><b> </b><b>+</b><b>COALESCE</b><b>(</b>tcp005<b>.</b>&quot;LaborIntensity004&quot;<b>,</b><b> </b>0<b>)</b><b>)</b><b>*</b>
<b>         </b><b>iif</b><b>(</b><b>COALESCE</b><b>(</b>drw<b>.</b>&quot;Quantity&quot;<b>,</b><b> </b>0<b>)</b><b>&gt;</b>0<b>,</b>drw<b>.</b>&quot;Quantity&quot;<b>,</b><b>COALESCE</b><b>(</b>drw<b>.</b>&quot;QuantityR&quot;<b>,</b><b> </b>0<b>)</b><b>+</b><b>COALESCE</b><b>(</b>drw<b>.</b>&quot;QuantityL&quot;<b>,</b><b> </b>0<b>)</b><b>)</b><b> </b><b>As</b><b> </b>&quot;LaborIntensity004Total&quot;<b>,</b>
<b>        </b><b>sum</b><b>(</b><b>COALESCE</b><b>(</b>tcp001<b>.</b>&quot;LaborIntensity005&quot;<b>,</b><b> </b>0<b>)</b><b>+</b><b>COALESCE</b><b>(</b>tcp002<b>.</b>&quot;LaborIntensity005&quot;<b>,</b><b> </b>0<b>)</b><b>+</b><b>COALESCE</b><b>(</b>tcp003<b>.</b>&quot;LaborIntensity005&quot;<b>,</b><b> </b>0<b>)</b><b>+</b><b> </b><b>COALESCE</b><b>(</b>tcp004<b>.</b>&quot;LaborIntensity005&quot;<b>,</b><b> </b>0<b>)</b><b> </b><b>+</b><b>COALESCE</b><b>(</b>tcp005<b>.</b>&quot;LaborIntensity005&quot;<b>,</b><b> </b>0<b>)</b><b>)</b><b> </b><b>As</b><b> </b>&quot;LaborIntensity005&quot;<b>,</b>
<b>        </b><b>sum</b><b>(</b><b>COALESCE</b><b>(</b>tcp001<b>.</b>&quot;LaborIntensity005&quot;<b>,</b><b> </b>0<b>)</b><b>+</b><b>COALESCE</b><b>(</b>tcp002<b>.</b>&quot;LaborIntensity005&quot;<b>,</b><b> </b>0<b>)</b><b>+</b><b>COALESCE</b><b>(</b>tcp003<b>.</b>&quot;LaborIntensity005&quot;<b>,</b><b> </b>0<b>)</b><b>+</b><b> </b><b>COALESCE</b><b>(</b>tcp004<b>.</b>&quot;LaborIntensity005&quot;<b>,</b><b> </b>0<b>)</b><b> </b><b>+</b><b>COALESCE</b><b>(</b>tcp005<b>.</b>&quot;LaborIntensity005&quot;<b>,</b><b> </b>0<b>)</b><b>)</b><b>*</b>
<b>         </b><b>iif</b><b>(</b><b>COALESCE</b><b>(</b>drw<b>.</b>&quot;Quantity&quot;<b>,</b><b> </b>0<b>)</b><b>&gt;</b>0<b>,</b>drw<b>.</b>&quot;Quantity&quot;<b>,</b><b>COALESCE</b><b>(</b>drw<b>.</b>&quot;QuantityR&quot;<b>,</b><b> </b>0<b>)</b><b>+</b><b>COALESCE</b><b>(</b>drw<b>.</b>&quot;QuantityL&quot;<b>,</b><b> </b>0<b>)</b><b>)</b><b> </b><b>As</b><b> </b>&quot;LaborIntensity005Total&quot;<b>,</b>
<b>         </b><b>(</b><b>sum</b><b>(</b><b>COALESCE</b><b>(</b>tcp001<b>.</b>&quot;LaborIntensity001&quot;<b>,</b><b> </b>0<b>)</b><b>+</b><b>COALESCE</b><b>(</b>tcp002<b>.</b>&quot;LaborIntensity001&quot;<b>,</b><b> </b>0<b>)</b><b>+</b><b>COALESCE</b><b>(</b>tcp003<b>.</b>&quot;LaborIntensity001&quot;<b>,</b><b> </b>0<b>)</b><b>+</b><b> </b><b>COALESCE</b><b>(</b>tcp004<b>.</b>&quot;LaborIntensity001&quot;<b>,</b><b> </b>0<b>)</b><b> </b><b>+</b><b>COALESCE</b><b>(</b>tcp005<b>.</b>&quot;LaborIntensity001&quot;<b>,</b><b> </b>0<b>)</b><b>)</b><b>+</b>
<b>         </b><b>sum</b><b>(</b><b>COALESCE</b><b>(</b>tcp001<b>.</b>&quot;LaborIntensity002&quot;<b>,</b><b> </b>0<b>)</b><b>+</b><b>COALESCE</b><b>(</b>tcp002<b>.</b>&quot;LaborIntensity002&quot;<b>,</b><b> </b>0<b>)</b><b>+</b><b>COALESCE</b><b>(</b>tcp003<b>.</b>&quot;LaborIntensity002&quot;<b>,</b><b> </b>0<b>)</b><b>+</b><b> </b><b>COALESCE</b><b>(</b>tcp004<b>.</b>&quot;LaborIntensity002&quot;<b>,</b><b> </b>0<b>)</b><b> </b><b>+</b><b>COALESCE</b><b>(</b>tcp005<b>.</b>&quot;LaborIntensity002&quot;<b>,</b><b> </b>0<b>)</b><b>)</b><b>+</b>
<b>         </b><b>sum</b><b>(</b><b>COALESCE</b><b>(</b>tcp001<b>.</b>&quot;LaborIntensity003&quot;<b>,</b><b> </b>0<b>)</b><b>+</b><b>COALESCE</b><b>(</b>tcp002<b>.</b>&quot;LaborIntensity003&quot;<b>,</b><b> </b>0<b>)</b><b>+</b><b>COALESCE</b><b>(</b>tcp003<b>.</b>&quot;LaborIntensity003&quot;<b>,</b><b> </b>0<b>)</b><b>+</b><b> </b><b>COALESCE</b><b>(</b>tcp004<b>.</b>&quot;LaborIntensity003&quot;<b>,</b><b> </b>0<b>)</b><b> </b><b>+</b><b>COALESCE</b><b>(</b>tcp005<b>.</b>&quot;LaborIntensity003&quot;<b>,</b><b> </b>0<b>)</b><b>)</b><b>+</b>
<b>         </b><b>sum</b><b>(</b><b>COALESCE</b><b>(</b>tcp001<b>.</b>&quot;LaborIntensity004&quot;<b>,</b><b> </b>0<b>)</b><b>+</b><b>COALESCE</b><b>(</b>tcp002<b>.</b>&quot;LaborIntensity004&quot;<b>,</b><b> </b>0<b>)</b><b>+</b><b>COALESCE</b><b>(</b>tcp003<b>.</b>&quot;LaborIntensity004&quot;<b>,</b><b> </b>0<b>)</b><b>+</b><b> </b><b>COALESCE</b><b>(</b>tcp004<b>.</b>&quot;LaborIntensity004&quot;<b>,</b><b> </b>0<b>)</b><b> </b><b>+</b><b>COALESCE</b><b>(</b>tcp005<b>.</b>&quot;LaborIntensity004&quot;<b>,</b><b> </b>0<b>)</b><b>)</b><b>+</b>
<b>         </b><b>sum</b><b>(</b><b>COALESCE</b><b>(</b>tcp001<b>.</b>&quot;LaborIntensity005&quot;<b>,</b><b> </b>0<b>)</b><b>+</b><b>COALESCE</b><b>(</b>tcp002<b>.</b>&quot;LaborIntensity005&quot;<b>,</b><b> </b>0<b>)</b><b>+</b><b>COALESCE</b><b>(</b>tcp003<b>.</b>&quot;LaborIntensity005&quot;<b>,</b><b> </b>0<b>)</b><b>+</b><b> </b><b>COALESCE</b><b>(</b>tcp004<b>.</b>&quot;LaborIntensity005&quot;<b>,</b><b> </b>0<b>)</b><b> </b><b>+</b><b>COALESCE</b><b>(</b>tcp005<b>.</b>&quot;LaborIntensity005&quot;<b>,</b><b> </b>0<b>)</b><b>)</b><b>)</b><b> </b><b>as</b><b> </b>&quot;LaborIntensityGeneral&quot;<b>,</b>
<b>         </b><b>(</b><b>sum</b><b>(</b><b>COALESCE</b><b>(</b>tcp001<b>.</b>&quot;LaborIntensity001&quot;<b>,</b><b> </b>0<b>)</b><b>+</b><b>COALESCE</b><b>(</b>tcp002<b>.</b>&quot;LaborIntensity001&quot;<b>,</b><b> </b>0<b>)</b><b>+</b><b>COALESCE</b><b>(</b>tcp003<b>.</b>&quot;LaborIntensity001&quot;<b>,</b><b> </b>0<b>)</b><b>+</b><b> </b><b>COALESCE</b><b>(</b>tcp004<b>.</b>&quot;LaborIntensity001&quot;<b>,</b><b> </b>0<b>)</b><b> </b><b>+</b><b>COALESCE</b><b>(</b>tcp005<b>.</b>&quot;LaborIntensity001&quot;<b>,</b><b> </b>0<b>)</b><b>)</b><b>*</b>
<b>         </b><b>iif</b><b>(</b><b>COALESCE</b><b>(</b>drw<b>.</b>&quot;Quantity&quot;<b>,</b><b> </b>0<b>)</b><b>&gt;</b>0<b>,</b>drw<b>.</b>&quot;Quantity&quot;<b>,</b><b>COALESCE</b><b>(</b>drw<b>.</b>&quot;QuantityR&quot;<b>,</b><b> </b>0<b>)</b><b>+</b><b>COALESCE</b><b>(</b>drw<b>.</b>&quot;QuantityL&quot;<b>,</b><b> </b>0<b>)</b><b>)</b><b>+</b>
<b>         </b><b>sum</b><b>(</b><b>COALESCE</b><b>(</b>tcp001<b>.</b>&quot;LaborIntensity002&quot;<b>,</b><b> </b>0<b>)</b><b>+</b><b>COALESCE</b><b>(</b>tcp002<b>.</b>&quot;LaborIntensity002&quot;<b>,</b><b> </b>0<b>)</b><b>+</b><b>COALESCE</b><b>(</b>tcp003<b>.</b>&quot;LaborIntensity002&quot;<b>,</b><b> </b>0<b>)</b><b>+</b><b> </b><b>COALESCE</b><b>(</b>tcp004<b>.</b>&quot;LaborIntensity002&quot;<b>,</b><b> </b>0<b>)</b><b> </b><b>+</b><b>COALESCE</b><b>(</b>tcp005<b>.</b>&quot;LaborIntensity002&quot;<b>,</b><b> </b>0<b>)</b><b>)</b><b>*</b>
<b>         </b><b>iif</b><b>(</b><b>COALESCE</b><b>(</b>drw<b>.</b>&quot;Quantity&quot;<b>,</b><b> </b>0<b>)</b><b>&gt;</b>0<b>,</b>drw<b>.</b>&quot;Quantity&quot;<b>,</b><b>COALESCE</b><b>(</b>drw<b>.</b>&quot;QuantityR&quot;<b>,</b><b> </b>0<b>)</b><b>+</b><b>COALESCE</b><b>(</b>drw<b>.</b>&quot;QuantityL&quot;<b>,</b><b> </b>0<b>)</b><b>)</b><b>+</b>
<b>         </b><b>sum</b><b>(</b><b>COALESCE</b><b>(</b>tcp001<b>.</b>&quot;LaborIntensity003&quot;<b>,</b><b> </b>0<b>)</b><b>+</b><b>COALESCE</b><b>(</b>tcp002<b>.</b>&quot;LaborIntensity003&quot;<b>,</b><b> </b>0<b>)</b><b>+</b><b>COALESCE</b><b>(</b>tcp003<b>.</b>&quot;LaborIntensity003&quot;<b>,</b><b> </b>0<b>)</b><b>+</b><b> </b><b>COALESCE</b><b>(</b>tcp004<b>.</b>&quot;LaborIntensity003&quot;<b>,</b><b> </b>0<b>)</b><b> </b><b>+</b><b>COALESCE</b><b>(</b>tcp005<b>.</b>&quot;LaborIntensity003&quot;<b>,</b><b> </b>0<b>)</b><b>)</b><b>*</b>
<b>         </b><b>iif</b><b>(</b><b>COALESCE</b><b>(</b>drw<b>.</b>&quot;Quantity&quot;<b>,</b><b> </b>0<b>)</b><b>&gt;</b>0<b>,</b>drw<b>.</b>&quot;Quantity&quot;<b>,</b><b>COALESCE</b><b>(</b>drw<b>.</b>&quot;QuantityR&quot;<b>,</b><b> </b>0<b>)</b><b>+</b><b>COALESCE</b><b>(</b>drw<b>.</b>&quot;QuantityL&quot;<b>,</b><b> </b>0<b>)</b><b>)</b><b>+</b>
<b>         </b><b>sum</b><b>(</b><b>COALESCE</b><b>(</b>tcp001<b>.</b>&quot;LaborIntensity004&quot;<b>,</b><b> </b>0<b>)</b><b>+</b><b>COALESCE</b><b>(</b>tcp002<b>.</b>&quot;LaborIntensity004&quot;<b>,</b><b> </b>0<b>)</b><b>+</b><b>COALESCE</b><b>(</b>tcp003<b>.</b>&quot;LaborIntensity004&quot;<b>,</b><b> </b>0<b>)</b><b>+</b><b> </b><b>COALESCE</b><b>(</b>tcp004<b>.</b>&quot;LaborIntensity004&quot;<b>,</b><b> </b>0<b>)</b><b> </b><b>+</b><b>COALESCE</b><b>(</b>tcp005<b>.</b>&quot;LaborIntensity004&quot;<b>,</b><b> </b>0<b>)</b><b>)</b><b>*</b>
<b>         </b><b>iif</b><b>(</b><b>COALESCE</b><b>(</b>drw<b>.</b>&quot;Quantity&quot;<b>,</b><b> </b>0<b>)</b><b>&gt;</b>0<b>,</b>drw<b>.</b>&quot;Quantity&quot;<b>,</b><b>COALESCE</b><b>(</b>drw<b>.</b>&quot;QuantityR&quot;<b>,</b><b> </b>0<b>)</b><b>+</b><b>COALESCE</b><b>(</b>drw<b>.</b>&quot;QuantityL&quot;<b>,</b><b> </b>0<b>)</b><b>)</b><b>+</b>
<b>         </b><b>sum</b><b>(</b><b>COALESCE</b><b>(</b>tcp001<b>.</b>&quot;LaborIntensity005&quot;<b>,</b><b> </b>0<b>)</b><b>+</b><b>COALESCE</b><b>(</b>tcp002<b>.</b>&quot;LaborIntensity005&quot;<b>,</b><b> </b>0<b>)</b><b>+</b><b>COALESCE</b><b>(</b>tcp003<b>.</b>&quot;LaborIntensity005&quot;<b>,</b><b> </b>0<b>)</b><b>+</b><b> </b><b>COALESCE</b><b>(</b>tcp004<b>.</b>&quot;LaborIntensity005&quot;<b>,</b><b> </b>0<b>)</b><b> </b><b>+</b><b>COALESCE</b><b>(</b>tcp005<b>.</b>&quot;LaborIntensity005&quot;<b>,</b><b> </b>0<b>)</b><b>)</b><b>*</b>
<b>         </b><b>iif</b><b>(</b><b>COALESCE</b><b>(</b>drw<b>.</b>&quot;Quantity&quot;<b>,</b><b> </b>0<b>)</b><b>&gt;</b>0<b>,</b>drw<b>.</b>&quot;Quantity&quot;<b>,</b><b>COALESCE</b><b>(</b>drw<b>.</b>&quot;QuantityR&quot;<b>,</b><b> </b>0<b>)</b><b>+</b><b>COALESCE</b><b>(</b>drw<b>.</b>&quot;QuantityL&quot;<b>,</b><b> </b>0<b>)</b><b>)</b><b>)</b><b> </b><b>as</b><b> </b>&quot;LaborIntensityGeneralTotal&quot;
<b>    </b>
<b>        </b><b>From</b>
<b>            </b><font color="# 080 0"><u>&quot;Drawings&quot;</u></font><b> </b>drw
<b>        </b><b>Left</b><b> </b><b>Join</b>
<b>            </b><font color="# 080 0"><u>&quot;Drawing&quot;</u></font><b> </b>dr<b> </b><b>ON</b><b>  </b>drw<b>.</b>&quot;DrawingId&quot;<b>=</b>dr<b>.</b>&quot;Id&quot;
<b>        </b><b>Left</b><b> </b><b>Join</b>
<b>            </b><font color="# 080 0"><u>&quot;Revisions&quot;</u></font><b> </b>rev<b> </b><b>ON</b><b>  </b>dr<b>.</b>&quot;RevisionId&quot;<b>=</b>rev<b>.</b>&quot;Id&quot;
<b>        </b><b>Left</b><b> </b><b>Join</b>
<b>            </b><font color="# 080 0"><u>&quot;Drawing&quot;</u></font><b> </b>repdr<b> </b><b>ON</b><b>  </b>drw<b>.</b>&quot;ReplaceDrawingId&quot;<b>=</b>repdr<b>.</b>&quot;Id&quot;
<b>        </b><b>Left</b><b> </b><b>Join</b>
<b>            </b><font color="# 080 0"><u>&quot;Drawing&quot;</u></font><b> </b>frsdr<b> </b><b>ON</b><b>  </b>drw<b>.</b>&quot;OccurrenceId&quot;<b>=</b>frsdr<b>.</b>&quot;Id&quot;
<b>        </b><b>Left</b><b> </b><b>Join</b>
<b>            </b><font color="# 080 0"><u>&quot;Type&quot;</u></font><b> </b>typ<b> </b><b>ON</b><b>  </b>dr<b>.</b>&quot;TypeId&quot;<b>=</b>typ<b>.</b>&quot;Id&quot;
<b>        </b><b>Left</b><b> </b><b>Join</b>
<b>            </b><font color="# 080 0"><u>&quot;Details&quot;</u></font><b> </b>det<b> </b><b>ON</b><b>  </b>dr<b>.</b>&quot;DetailId&quot;<b>=</b>det<b>.</b>&quot;Id&quot;
<b>        </b><b>Left</b><b> </b><b>Join</b>
<b>            </b><font color="# 080 0"><u>&quot;Materials&quot;</u></font><b> </b>mat<b> </b><b>ON</b><b>  </b>dr<b>.</b>&quot;MaterialId&quot;<b>=</b>mat<b>.</b>&quot;Id&quot;
<b>        </b><b>Left</b><b> </b><b>Join</b>
<b>            </b><font color="# 080 0"><u>&quot;TechProcess001&quot;</u></font><b> </b>tcp001<b> </b><b>ON</b><b>  </b>dr<b>.</b>&quot;Id&quot;<b>=</b>tcp001<b>.</b>&quot;DrawingId&quot;
<b>        </b><b>Left</b><b> </b><b>Join</b>
<b>            </b><font color="# 080 0"><u>&quot;Revisions&quot;</u></font><b> </b>tcp001rev<b> </b><b>ON</b><b>  </b>tcp001<b>.</b>&quot;RevisionId&quot;<b>=</b>tcp001rev<b>.</b>&quot;Id&quot;
<b>        </b><b>Left</b><b> </b><b>Join</b>
<b>            </b><font color="# 080 0"><u>&quot;TechProcess002&quot;</u></font><b> </b>tcp002<b> </b><b>ON</b><b>  </b>dr<b>.</b>&quot;Id&quot;<b>=</b>tcp002<b>.</b>&quot;DrawingId&quot;
<b>        </b><b>Left</b><b> </b><b>Join</b>
<b>            </b><font color="# 080 0"><u>&quot;Revisions&quot;</u></font><b> </b>tcp002rev<b> </b><b>ON</b><b>  </b>tcp002<b>.</b>&quot;RevisionId&quot;<b>=</b>tcp002rev<b>.</b>&quot;Id&quot;
<b>        </b><b>Left</b><b> </b><b>Join</b>
<b>            </b><font color="# 080 0"><u>&quot;TechProcess003&quot;</u></font><b> </b>tcp003<b> </b><b>ON</b><b>  </b>dr<b>.</b>&quot;Id&quot;<b>=</b>tcp003<b>.</b>&quot;DrawingId&quot;
<b>        </b><b>Left</b><b> </b><b>Join</b>
<b>            </b><font color="# 080 0"><u>&quot;Revisions&quot;</u></font><b> </b>tcp003rev<b> </b><b>ON</b><b>  </b>tcp003<b>.</b>&quot;RevisionId&quot;<b>=</b>tcp003rev<b>.</b>&quot;Id&quot;
<b>        </b><b>Left</b><b> </b><b>Join</b>
<b>            </b><font color="# 080 0"><u>&quot;TechProcess004&quot;</u></font><b> </b>tcp004<b> </b><b>ON</b><b>  </b>dr<b>.</b>&quot;Id&quot;<b>=</b>tcp004<b>.</b>&quot;DrawingId&quot;
<b>        </b><b>Left</b><b> </b><b>Join</b>
<b>            </b><font color="# 080 0"><u>&quot;Revisions&quot;</u></font><b> </b>tcp004rev<b> </b><b>ON</b><b>  </b>tcp004<b>.</b>&quot;RevisionId&quot;<b>=</b>tcp004rev<b>.</b>&quot;Id&quot;
<b>        </b><b>Left</b><b> </b><b>Join</b>
<b>            </b><font color="# 080 0"><u>&quot;TechProcess005&quot;</u></font><b> </b>tcp005<b> </b><b>ON</b><b>  </b>dr<b>.</b>&quot;Id&quot;<b>=</b>tcp005<b>.</b>&quot;DrawingId&quot;
<b>        </b><b>Left</b><b> </b><b>Join</b>
<b>            </b><font color="# 080 0"><u>&quot;Revisions&quot;</u></font><b> </b>tcp005rev<b> </b><b>ON</b><b>  </b>tcp005<b>.</b>&quot;RevisionId&quot;<b>=</b>tcp005rev<b>.</b>&quot;Id&quot;
<b>        </b><b>Left</b><b> </b><b>Join</b>
<b>            </b><font color="# 080 0"><u>&quot;DrawingScan&quot;</u></font><b> </b>drScan<b> </b><b>ON</b><b>  </b>dr<b>.</b>&quot;Id&quot;<b>=</b>drScan<b>.</b>&quot;DrawingId&quot;
<b>        </b><b>Left</b><b> </b><b>Join</b>
<b>            </b><font color="# 080 0"><u>&quot;Drawings&quot;</u></font><b> </b>pdrw<b> </b><b>ON</b><b>  </b>drw<b>.</b>&quot;ParentId&quot;<b>=</b>pdrw<b>.</b>&quot;Id&quot;
<b>        </b><b>Left</b><b> </b><b>Join</b>
<b>            </b><font color="# 080 0"><u>&quot;Drawing&quot;</u></font><b> </b>drp<b> </b><b>ON</b><b>  </b>pdrw<b>.</b>&quot;DrawingId&quot;<b>=</b>drp<b>.</b>&quot;Id&quot;
<b>        </b><b>Left</b><b> </b><b>Join</b>
<b>            </b><font color="# 080 0"><u>&quot;Colors&quot;</u></font><b> </b>colm<b> </b><b>ON</b><b>  </b>drw<b>.</b>&quot;CurrentLevelMenuColorId&quot;<b>=</b>colm<b>.</b>&quot;Id&quot;
<b>        </b><b>Left</b><b> </b><b>Join</b>
<b>            </b><font color="# 080 0"><u>&quot;Colors&quot;</u></font><b> </b>cold<b> </b><b>ON</b><b>  </b>drw<b>.</b>&quot;DrawingColorId&quot;<b>=</b>cold<b>.</b>&quot;Id&quot;
<b>        </b><b>Left</b><b> </b><b>Join</b>
<b>            </b><font color="# 080 0"><u>&quot;Colors&quot;</u></font><b> </b>coldet<b> </b><b>ON</b><b>  </b>drw<b>.</b>&quot;MaterialColorId&quot;<b>=</b>coldet<b>.</b>&quot;Id&quot;
<b>        </b>
<b>        </b><b>where</b>
<b>            </b><b>(</b>tcp001<b>.</b>&quot;ParentId&quot;<b> </b><b>is</b><b> </b><b>null</b><b> </b><b>and</b><b> </b>tcp002<b>.</b>&quot;ParentId&quot;<b> </b><b>is</b><b> </b><b>null</b><b> </b><b>and</b><b> </b>tcp003<b>.</b>&quot;ParentId&quot;<b>is</b><b> </b><b>null</b><b> </b><b>and</b><b> </b>tcp004<b>.</b>&quot;ParentId&quot;<b>is</b><b> </b><b>null</b><b> </b><b>and</b><b> </b>tcp005<b>.</b>&quot;ParentId&quot;<b>is</b><b> </b><b>null</b><b>)</b>
<b>        </b><b>GROUP</b><b> </b><b>BY</b>
<b>            </b>drw<b>.</b>&quot;Id&quot;<b>,</b>
<b>            </b>drw<b>.</b>&quot;ParentId&quot;<b>,</b>
<b>            </b>drw<b>.</b>&quot;Quantity&quot;<b>,</b>
<b>            </b>drw<b>.</b>&quot;QuantityL&quot;<b>,</b>
<b>            </b>drw<b>.</b>&quot;QuantityR&quot;<b>,</b>
<b>            </b>drw<b>.</b>&quot;CurrentLevelMenu&quot;<b>,</b>
<b>            </b>drw<b>.</b>&quot;StructuraDisable&quot;<b>,</b>
<b>            </b>drw<b>.</b>&quot;OccurrenceId&quot;<b>,</b>
<b>            </b>drw<b>.</b>&quot;ReplaceDrawingId&quot;<b>,</b>
<b>            </b>colm<b>.</b>&quot;Id&quot;<b>,</b>
<b>            </b>colm<b>.</b>&quot;NameEng&quot;<b>,</b>
<b>            </b>cold<b>.</b>&quot;Id&quot;<b>,</b>
<b>            </b>cold<b>.</b>&quot;NameEng&quot;<b>,</b>
<b>            </b>coldet<b>.</b>&quot;Id&quot;<b>,</b>
<b>            </b>coldet<b>.</b>&quot;NameEng&quot;<b>,</b>
<b>            </b>dr<b>.</b>&quot;Id&quot;<b>,</b>
<b>            </b>dr<b>.</b>&quot;Number&quot;<b>,</b>
<b>            </b>typ<b>.</b>&quot;TypeName&quot;<b>,</b>
<b>            </b>det<b>.</b>&quot;DetailName&quot;<b>,</b>
<b>            </b>&quot;NumberWithRevisionName&quot;<b>,</b>
<b>            </b>rev<b>.</b>&quot;Symbol&quot;<b>,</b>
<b>            </b>dr<b>.</b>&quot;TH&quot;<b>,</b>
<b>            </b>dr<b>.</b>&quot;L&quot;<b>,</b>
<b>            </b>dr<b>.</b>&quot;W&quot;<b>,</b>
<b>            </b>dr<b>.</b>&quot;W2&quot;<b>,</b>
<b>            </b>dr<b>.</b>&quot;DetailWeight&quot;<b>,</b>
<b>            </b>mat<b>.</b>&quot;MaterialName&quot;<b>,</b>
<b>            </b>dr<b>.</b>&quot;CreateDate&quot;<b>,</b>
<b>            </b>dr<b>.</b>&quot;Note&quot;<b>,</b>
<b>            </b>tcp001<b>.</b>&quot;Id&quot;<b>,</b>
<b>            </b>tcp002<b>.</b>&quot;Id&quot;<b>,</b>
<b>            </b>tcp003<b>.</b>&quot;Id&quot;<b>,</b>
<b>            </b>tcp004<b>.</b>&quot;Id&quot;<b>,</b>
<b>            </b>tcp005<b>.</b>&quot;Id&quot;<b>,</b>
<b>            </b>tcp001<b>.</b>&quot;TechProcessName&quot;<b>,</b>
<b>            </b>tcp002<b>.</b>&quot;TechProcessName&quot;<b>,</b>
<b>            </b>tcp003<b>.</b>&quot;TechProcessName&quot;<b>,</b>
<b>            </b>tcp004<b>.</b>&quot;TechProcessName&quot;<b>,</b>
<b>            </b>tcp005<b>.</b>&quot;TechProcessName&quot;<b>,</b>
<b>            </b>tcp001<b>.</b>&quot;TechProcessPath&quot;<b>,</b>
<b>            </b>tcp002<b>.</b>&quot;TechProcessPath&quot;<b>,</b>
<b>            </b>tcp003<b>.</b>&quot;TechProcessPath&quot;<b>,</b>
<b>            </b>tcp004<b>.</b>&quot;TechProcessPath&quot;<b>,</b>
<b>            </b>tcp005<b>.</b>&quot;TechProcessPath&quot;<b>,</b>
<b>            </b>tcp001<b>.</b>&quot;OldTechProcess&quot;<b>,</b>
<b>            </b>tcp002<b>.</b>&quot;OldTechProcess&quot;<b>,</b>
<b>            </b>tcp003<b>.</b>&quot;OldTechProcess&quot;<b>,</b>
<b>            </b>tcp004<b>.</b>&quot;OldTechProcess&quot;<b>,</b>
<b>            </b>tcp005<b>.</b>&quot;OldTechProcess&quot;<b>,</b>
<b>            </b>&quot;ParentName&quot;<b>,</b>
<b>            </b>tcp001rev<b>.</b>&quot;Symbol&quot;<b>,</b>
<b>            </b>tcp002rev<b>.</b>&quot;Symbol&quot;<b>,</b>
<b>            </b>tcp003rev<b>.</b>&quot;Symbol&quot;<b>,</b>
<b>            </b>tcp004rev<b>.</b>&quot;Symbol&quot;<b>,</b>
<b>            </b>tcp005rev<b>.</b>&quot;Symbol&quot;<b>,</b>
<b>            </b>tcp001<b>.</b>&quot;TypeId&quot;<b>,</b>
<b>            </b>tcp002<b>.</b>&quot;TypeId&quot;<b>,</b>
<b>            </b>tcp003<b>.</b>&quot;TypeId&quot;<b>,</b>
<b>            </b>tcp004<b>.</b>&quot;TypeId&quot;<b>,</b>
<b>            </b>tcp005<b>.</b>&quot;TypeId&quot;
<b>    </b><b>INTO</b><b> </b>:&quot;Id&quot;<b>,</b>
<b>         </b>:&quot;ParentId&quot;<b>,</b>
<b>         </b>:&quot;CurrentLevelMenu&quot;<b>,</b>
<b>         </b>:&quot;DrawingId&quot;<b>,</b>
<b>         </b>:&quot;ReplaceDrawingId&quot;<b>,</b>
<b>         </b>:&quot;OccurrenceId&quot;<b>,</b>
<b>         </b>:&quot;ScanId&quot;<b>,</b>
<b>         </b>:&quot;Quantity&quot;<b>,</b>
<b>         </b>:&quot;QuantityR&quot;<b>,</b>
<b>         </b>:&quot;QuantityL&quot;<b>,</b>
<b>         </b>:&quot;StructuraDisable&quot;<b>,</b>
<b>         </b>:&quot;Number&quot;<b>,</b>
<b>         </b>:&quot;RevisionName&quot;<b>,</b>
<b>         </b>:&quot;NumberWithRevisionName&quot;<b>,</b>
<b>         </b>:&quot;DetailWeight&quot;<b>,</b>
<b>         </b>:TH<b>,</b>
<b>         </b>:W<b>,</b>
<b>         </b>:W2<b>,</b>
<b>         </b>:L<b>,</b>
<b>         </b>:&quot;DetailName&quot;<b>,</b>
<b>         </b>:&quot;TypeName&quot;<b>,</b>
<b>         </b>:&quot;ParentName&quot;<b>,</b>
<b>         </b>:&quot;MaterialName&quot;<b>,</b>
<b>         </b>:&quot;NoteName&quot;<b>,</b>
<b>         </b>:&quot;CreateDate&quot;<b>,</b>
<b>         </b>:&quot;TechProcess001Id&quot;<b>,</b>
<b>         </b>:&quot;TechProcess002Id&quot;<b>,</b>
<b>         </b>:&quot;TechProcess003Id&quot;<b>,</b>
<b>         </b>:&quot;TechProcess004Id&quot;<b>,</b>
<b>         </b>:&quot;TechProcess005Id&quot;<b>,</b>
<b>         </b>:&quot;TechProcess001Name&quot;<b>,</b>
<b>         </b>:&quot;TechProcess002Name&quot;<b>,</b>
<b>         </b>:&quot;TechProcess003Name&quot;<b>,</b>
<b>         </b>:&quot;TechProcess004Name&quot;<b>,</b>
<b>         </b>:&quot;TechProcess005Name&quot;<b>,</b>
<b>         </b>:&quot;TechProcess001NameString&quot;<b>,</b>
<b>         </b>:&quot;TechProcess002NameString&quot;<b>,</b>
<b>         </b>:&quot;TechProcess003NameString&quot;<b>,</b>
<b>         </b>:&quot;TechProcess004NameString&quot;<b>,</b>
<b>         </b>:&quot;TechProcess005NameString&quot;<b>,</b>
<b>         </b>:&quot;Revision001&quot;<b>,</b>
<b>         </b>:&quot;Revision002&quot;<b>,</b>
<b>         </b>:&quot;Revision003&quot;<b>,</b>
<b>         </b>:&quot;Revision004&quot;<b>,</b>
<b>         </b>:&quot;Revision005&quot;<b>,</b>
<b>         </b>:&quot;TechProcess001Path&quot;<b>,</b>
<b>         </b>:&quot;TechProcess002Path&quot;<b>,</b>
<b>         </b>:&quot;TechProcess003Path&quot;<b>,</b>
<b>         </b>:&quot;TechProcess004Path&quot;<b>,</b>
<b>         </b>:&quot;TechProcess005Path&quot;<b>,</b>
<b>         </b>:&quot;TechProcess001Old&quot;<b>,</b>
<b>         </b>:&quot;TechProcess002Old&quot;<b>,</b>
<b>         </b>:&quot;TechProcess003Old&quot;<b>,</b>
<b>         </b>:&quot;TechProcess004Old&quot;<b>,</b>
<b>         </b>:&quot;TechProcess005Old&quot;<b>,</b>
<b>         </b>:&quot;TechProcess001Type&quot;<b>,</b>
<b>         </b>:&quot;TechProcess002Type&quot;<b>,</b>
<b>         </b>:&quot;TechProcess003Type&quot;<b>,</b>
<b>         </b>:&quot;TechProcess004Type&quot;<b>,</b>
<b>         </b>:&quot;TechProcess005Type&quot;<b>,</b>
<b>         </b>:&quot;CurrentLevelMenuColorId&quot;<b>,</b>
<b>         </b>:&quot;CurrentLevelMenuColorName&quot;<b>,</b>
<b>         </b>:&quot;DrawingColorId&quot;<b>,</b>
<b>         </b>:&quot;DrawingColorName&quot;<b>,</b>
<b>         </b>:&quot;MaterialColorId&quot;<b>,</b>
<b>         </b>:&quot;MaterialColorName&quot;<b>,</b>
<b>         </b>:&quot;Welding20Steel&quot;<b>,</b>
<b>         </b>:&quot;Welding20SteelTotal&quot;<b>,</b>
<b>         </b>:&quot;Welding10&quot;<b>,</b>
<b>         </b>:&quot;Welding10Total&quot;<b>,</b>
<b>         </b>:&quot;Welding12&quot;<b>,</b>
<b>         </b>:&quot;Welding12Total&quot;<b>,</b>
<b>         </b>:&quot;Welding16&quot;<b>,</b>
<b>         </b>:&quot;Welding16Total&quot;<b>,</b>
<b>         </b>:&quot;Welding20&quot;<b>,</b>
<b>         </b>:&quot;Welding20Total&quot;<b>,</b>
<b>         </b>:&quot;GasArCO2&quot;<b>,</b>
<b>         </b>:&quot;GasArCO2Total&quot;<b>,</b>
<b>         </b>:&quot;GasCO3&quot;<b>,</b>
<b>         </b>:&quot;GasCO3Total&quot;<b>,</b>
<b>         </b>:&quot;GasAr&quot;<b>,</b>
<b>         </b>:&quot;GasArTotal&quot;<b>,</b>
<b>         </b>:&quot;WeldingElektrod&quot;<b>,</b>
<b>         </b>:&quot;WeldingElektrodTotal&quot;<b>,</b>
<b>         </b>:&quot;GasO2&quot;<b>,</b>
<b>         </b>:&quot;GasO2Total&quot;<b>,</b>
<b>         </b>:&quot;GasNature&quot;<b>,</b>
<b>         </b>:&quot;GasNatureTotal&quot;<b>,</b>
<b>         </b>:&quot;GasN2&quot;<b>,</b>
<b>         </b>:&quot;GasN2Total&quot;<b>,</b>
<b>         </b>:&quot;HardKapci881&quot;<b>,</b>
<b>         </b>:&quot;HardKapci881Total&quot;<b>,</b>
<b>         </b>:&quot;HardKapciHs6055&quot;<b>,</b>
<b>         </b>:&quot;HardKapciHs6055Total&quot;<b>,</b>
<b>         </b>:&quot;HardKapci126&quot;<b>,</b>
<b>         </b>:&quot;HardKapci126Total&quot;<b>,</b>
<b>         </b>:&quot;HardKapciPEPutty&quot;<b>,</b>
<b>         </b>:&quot;HardKapciPEPuttyTotal&quot;<b>,</b>
<b>         </b>:&quot;HardKapci2KMS651&quot;<b>,</b>
<b>         </b>:&quot;HardKapci2KMS651Total&quot;<b>,</b>
<b>         </b>:&quot;DilKapci881&quot;<b>,</b>
<b>         </b>:&quot;DilKapci881Total&quot;<b>,</b>
<b>         </b>:&quot;DilKapci2K&quot;<b>,</b>
<b>         </b>:&quot;DilKapci2KTotal&quot;<b>,</b>
<b>         </b>:&quot;DilKapci880&quot;<b>,</b>
<b>         </b>:&quot;DilKapci880Total&quot;<b>,</b>
<b>         </b>:&quot;PrimerKapci125&quot;<b>,</b>
<b>         </b>:&quot;PrimerKapci125Total&quot;<b>,</b>
<b>         </b>:&quot;PrimerKapci633&quot;<b>,</b>
<b>         </b>:&quot;PrimerKapci633Total&quot;<b>,</b>
<b>         </b>:&quot;EnamelKapci641&quot;<b>,</b>
<b>         </b>:&quot;EnamelKapci641Total&quot;<b>,</b>
<b>         </b>:&quot;EnamelKapci670&quot;<b>,</b>
<b>         </b>:&quot;EnamelKapci670Total&quot;<b>,</b>
<b>         </b>:&quot;EnamelKapci6030&quot;<b>,</b>
<b>         </b>:&quot;EnamelKapci6030Total&quot;<b>,</b>
<b>         </b>:&quot;UniversalSikaflex527&quot;<b>,</b>
<b>         </b>:&quot;UniversalSikaflex527Total&quot;<b>,</b>
<b>         </b>:&quot;PuttyKapci350&quot;<b>,</b>
<b>         </b>:&quot;PuttyKapci350Total&quot;<b>,</b>
<b>         </b>:&quot;LaborIntensity001&quot;<b>,</b>
<b>         </b>:&quot;LaborIntensity001Total&quot;<b>,</b>
<b>         </b>:&quot;LaborIntensity002&quot;<b>,</b>
<b>         </b>:&quot;LaborIntensity002Total&quot;<b>,</b>
<b>         </b>:&quot;LaborIntensity003&quot;<b>,</b>
<b>         </b>:&quot;LaborIntensity003Total&quot;<b>,</b>
<b>         </b>:&quot;LaborIntensity004&quot;<b>,</b>
<b>         </b>:&quot;LaborIntensity004Total&quot;<b>,</b>
<b>         </b>:&quot;LaborIntensity005&quot;<b>,</b>
<b>         </b>:&quot;LaborIntensity005Total&quot;<b>,</b>
<b>         </b>:&quot;LaborIntensityGeneral&quot;<b>,</b>
<b>         </b>:&quot;LaborIntensityGeneralTotal&quot;
<b>  </b><b>DO</b>
<b>  </b><b>BEGIN</b>
<b>    </b><b>SUSPEND</b><b>;</b>
<b>  </b><b>END</b>
<b>END</b>

</pre></code>
</span></P>
<P CLASS="Base">&nbsp;</P>

<HR>
<A NAME="PROC_TestProc"><P CLASS="Header0">Procedure: TestProc</P><P CLASS="Base">&nbsp;</P>
<P CLASS="Header1">Input Parameters</P>
<TABLE CLASS="dtArg" CELLSPACING="0">
  <TH WIDTH="1%"><P CLASS="Base2"><B>Parameter</B></P>
  <TH WIDTH="20%"><P CLASS="Base2"><B>Type</B></P>
  <TH WIDTH="50%"><P CLASS="Base2"><B>Description</B></P>
  <TR>
    <TD><P CLASS="Base2">DateNow</TD>
    <TD><P CLASS="Base2">DATE</TD>
    <TD><P CLASS="Base2">&nbsp;</TD>
  </TR>
</TABLE>
<P CLASS="Base">&nbsp;</P>
<P CLASS="Header1">Output Parameters</P>
<TABLE CLASS="dtArg" CELLSPACING="0">
  <TH WIDTH="1%"><P CLASS="Base2"><B>Parameter</B></P>
  <TH WIDTH="20%"><P CLASS="Base2"><B>Type</B></P>
  <TH WIDTH="50%"><P CLASS="Base2"><B>Description</B></P>
  <TR>
    <TD><P CLASS="Base2">Id</TD>
    <TD><P CLASS="Base2">INTEGER</TD>
    <TD><P CLASS="Base2">&nbsp;</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2">ParentId</TD>
    <TD><P CLASS="Base2">INTEGER</TD>
    <TD><P CLASS="Base2">&nbsp;</TD>
  </TR>
</TABLE>
<P CLASS="Base">&nbsp;</P>
<P CLASS="Header1">Description</P>
<P CLASS="Base"><I>(There is no description for procedure TestProc)</I></P>
<P CLASS="Base">&nbsp;</P>
<P CLASS="Header1">Definition</P>
<P CLASS="Base"><span class="DDLCode">
<code><pre>
<b>CREATE</b><b> </b><b>PROCEDURE</b><b> </b><font color="# 080 0"><u>&quot;TestProc&quot;</u></font><b>(</b>
<b>    </b>&quot;DateNow&quot;<b> </b><b>DATE</b><b>)</b>
<b>RETURNS</b><b> </b><b>(</b>
<b>    </b>&quot;Id&quot;<b> </b><b>INTEGER</b><b>,</b>
<b>    </b>&quot;ParentId&quot;<b> </b><b>INTEGER</b><b>)</b>
<b>AS</b>
<b>BEGIN</b>
<b>  </b><b>FOR</b>
<b>    </b><b>SELECT</b>
<b>    </b>
<b>    </b>drw<b>.</b>&quot;Id&quot;<b> </b><b>as</b><b> </b>&quot;Id&quot;<b>,</b>
<b>    </b>drw<b>.</b>&quot;ParentId&quot;
<b>    </b><b>from</b>
<b>        </b><font color="# 080 0"><u>&quot;Drawings&quot;</u></font><b> </b>drw
<b>    </b><b>LEFT</b><b> </b><b>join</b>
<b>        </b><font color="# 080 0"><u>&quot;Drawing&quot;</u></font><b> </b>dr<b> </b><b>on</b><b> </b>drw<b>.</b>&quot;DrawingId&quot;<b> </b><b>=</b><b> </b>dr<b>.</b>&quot;Id&quot;
<b>    </b><b>where</b><b> </b>dr<b>.</b>&quot;CreateDate&quot;<b>&lt;</b><b>=</b>:&quot;DateNow&quot;
<b>    </b><b>INTO</b><b> </b>:&quot;Id&quot;<b>,</b>
<b>         </b>:&quot;ParentId&quot;
<b>  </b><b>DO</b>
<b>  </b><b>BEGIN</b>
<b>    </b><b>SUSPEND</b><b>;</b>
<b>  </b><b>END</b>
<b>END</b>

</pre></code>
</span></P>
<P CLASS="Base">&nbsp;</P>

<HR>
<A NAME="_GENERATORS"><P CLASS="Header0">Generators</P></A>
<P CLASS="Base">&nbsp;</P>
<TABLE CLASS="dtArg" CELLSPACING="0">
  <TH><P CLASS="Base2"><B>Generator</B></P>
  <TH><P CLASS="Base2"><B>Value</B></P>
  <TR>
    <TD><P CLASS="Base2"><A HREF="#GEN_IBE$LOG_TABLES_GEN">IBE$LOG_TABLES_GEN</A></TD>
    <TD ALIGN="right"><P CLASS="Base2">0</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2"><A HREF="#GEN_IBE$TODO_ITEM_ID_GEN">IBE$TODO_ITEM_ID_GEN</A></TD>
    <TD ALIGN="right"><P CLASS="Base2">0</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2"><A HREF="#GEN_Seq_ColorsId">Seq_ColorsId</A></TD>
    <TD ALIGN="right"><P CLASS="Base2">17</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2"><A HREF="#GEN_Seq_DetailsId">Seq_DetailsId</A></TD>
    <TD ALIGN="right"><P CLASS="Base2">1149</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2"><A HREF="#GEN_Seq_DrawingId">Seq_DrawingId</A></TD>
    <TD ALIGN="right"><P CLASS="Base2">14733</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2"><A HREF="#GEN_Seq_DrawingScanId">Seq_DrawingScanId</A></TD>
    <TD ALIGN="right"><P CLASS="Base2">11631</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2"><A HREF="#GEN_Seq_DrawingTypeId">Seq_DrawingTypeId</A></TD>
    <TD ALIGN="right"><P CLASS="Base2">8</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2"><A HREF="#GEN_Seq_DrawingsId">Seq_DrawingsId</A></TD>
    <TD ALIGN="right"><P CLASS="Base2">63046</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2"><A HREF="#GEN_Seq_MaterialsId">Seq_MaterialsId</A></TD>
    <TD ALIGN="right"><P CLASS="Base2">291</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2"><A HREF="#GEN_Seq_OperatioNumberId">Seq_OperatioNumberId</A></TD>
    <TD ALIGN="right"><P CLASS="Base2">20</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2"><A HREF="#GEN_Seq_OperationNameId">Seq_OperationNameId</A></TD>
    <TD ALIGN="right"><P CLASS="Base2">9</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2"><A HREF="#GEN_Seq_OperationPaintMaterialId">Seq_OperationPaintMaterialId</A></TD>
    <TD ALIGN="right"><P CLASS="Base2">32</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2"><A HREF="#GEN_Seq_RevisionTypeId">Seq_RevisionTypeId</A></TD>
    <TD ALIGN="right"><P CLASS="Base2">5</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2"><A HREF="#GEN_Seq_RevisionsId">Seq_RevisionsId</A></TD>
    <TD ALIGN="right"><P CLASS="Base2">51</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2"><A HREF="#GEN_Seq_TechProcess001Id">Seq_TechProcess001Id</A></TD>
    <TD ALIGN="right"><P CLASS="Base2">5467</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2"><A HREF="#GEN_Seq_TechProcess002Id">Seq_TechProcess002Id</A></TD>
    <TD ALIGN="right"><P CLASS="Base2">949</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2"><A HREF="#GEN_Seq_TechProcess003Id">Seq_TechProcess003Id</A></TD>
    <TD ALIGN="right"><P CLASS="Base2">680</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2"><A HREF="#GEN_Seq_TechProcess004Id">Seq_TechProcess004Id</A></TD>
    <TD ALIGN="right"><P CLASS="Base2">42</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2"><A HREF="#GEN_Seq_TechProcess005Id">Seq_TechProcess005Id</A></TD>
    <TD ALIGN="right"><P CLASS="Base2">58</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2"><A HREF="#GEN_Seq_UserId">Seq_UserId</A></TD>
    <TD ALIGN="right"><P CLASS="Base2">5</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2"><A HREF="#GEN_Seq_UserRoleId">Seq_UserRoleId</A></TD>
    <TD ALIGN="right"><P CLASS="Base2">4</TD>
  </TR>
</TABLE>

<HR>
<A NAME="GEN_IBE$LOG_TABLES_GEN"><P CLASS="Header0">Generator: IBE$LOG_TABLES_GEN</P><P CLASS="Base">&nbsp;</P>
<P CLASS="Header1">Definition</P>
<P CLASS="Base"><span class="DDLCode">
<code><pre>
<b>CREATE</b><b> </b><b>GENERATOR</b><b> </b><font color="# 080 0"><u>IBE$LOG_TABLES_GEN</u></font>

</pre></code>
</span></P>
<P CLASS="Base">&nbsp;</P>

<HR>
<A NAME="GEN_IBE$TODO_ITEM_ID_GEN"><P CLASS="Header0">Generator: IBE$TODO_ITEM_ID_GEN</P><P CLASS="Base">&nbsp;</P>
<P CLASS="Header1">Definition</P>
<P CLASS="Base"><span class="DDLCode">
<code><pre>
<b>CREATE</b><b> </b><b>GENERATOR</b><b> </b><font color="# 080 0"><u>IBE$TODO_ITEM_ID_GEN</u></font>

</pre></code>
</span></P>
<P CLASS="Base">&nbsp;</P>

<HR>
<A NAME="GEN_Seq_ColorsId"><P CLASS="Header0">Generator: Seq_ColorsId</P><P CLASS="Base">&nbsp;</P>
<P CLASS="Header1">Definition</P>
<P CLASS="Base"><span class="DDLCode">
<code><pre>
<b>CREATE</b><b> </b><b>GENERATOR</b><b> </b><font color="# 080 0"><u>&quot;Seq_ColorsId&quot;</u></font>

</pre></code>
</span></P>
<P CLASS="Base">&nbsp;</P>

<HR>
<A NAME="GEN_Seq_DetailsId"><P CLASS="Header0">Generator: Seq_DetailsId</P><P CLASS="Base">&nbsp;</P>
<P CLASS="Header1">Definition</P>
<P CLASS="Base"><span class="DDLCode">
<code><pre>
<b>CREATE</b><b> </b><b>GENERATOR</b><b> </b><font color="# 080 0"><u>&quot;Seq_DetailsId&quot;</u></font>

</pre></code>
</span></P>
<P CLASS="Base">&nbsp;</P>

<HR>
<A NAME="GEN_Seq_DrawingId"><P CLASS="Header0">Generator: Seq_DrawingId</P><P CLASS="Base">&nbsp;</P>
<P CLASS="Header1">Definition</P>
<P CLASS="Base"><span class="DDLCode">
<code><pre>
<b>CREATE</b><b> </b><b>GENERATOR</b><b> </b><font color="# 080 0"><u>&quot;Seq_DrawingId&quot;</u></font>

</pre></code>
</span></P>
<P CLASS="Base">&nbsp;</P>

<HR>
<A NAME="GEN_Seq_DrawingScanId"><P CLASS="Header0">Generator: Seq_DrawingScanId</P><P CLASS="Base">&nbsp;</P>
<P CLASS="Header1">Definition</P>
<P CLASS="Base"><span class="DDLCode">
<code><pre>
<b>CREATE</b><b> </b><b>GENERATOR</b><b> </b><font color="# 080 0"><u>&quot;Seq_DrawingScanId&quot;</u></font>

</pre></code>
</span></P>
<P CLASS="Base">&nbsp;</P>

<HR>
<A NAME="GEN_Seq_DrawingTypeId"><P CLASS="Header0">Generator: Seq_DrawingTypeId</P><P CLASS="Base">&nbsp;</P>
<P CLASS="Header1">Definition</P>
<P CLASS="Base"><span class="DDLCode">
<code><pre>
<b>CREATE</b><b> </b><b>GENERATOR</b><b> </b><font color="# 080 0"><u>&quot;Seq_DrawingTypeId&quot;</u></font>

</pre></code>
</span></P>
<P CLASS="Base">&nbsp;</P>

<HR>
<A NAME="GEN_Seq_DrawingsId"><P CLASS="Header0">Generator: Seq_DrawingsId</P><P CLASS="Base">&nbsp;</P>
<P CLASS="Header1">Definition</P>
<P CLASS="Base"><span class="DDLCode">
<code><pre>
<b>CREATE</b><b> </b><b>GENERATOR</b><b> </b><font color="# 080 0"><u>&quot;Seq_DrawingsId&quot;</u></font>

</pre></code>
</span></P>
<P CLASS="Base">&nbsp;</P>

<HR>
<A NAME="GEN_Seq_MaterialsId"><P CLASS="Header0">Generator: Seq_MaterialsId</P><P CLASS="Base">&nbsp;</P>
<P CLASS="Header1">Definition</P>
<P CLASS="Base"><span class="DDLCode">
<code><pre>
<b>CREATE</b><b> </b><b>GENERATOR</b><b> </b><font color="# 080 0"><u>&quot;Seq_MaterialsId&quot;</u></font>

</pre></code>
</span></P>
<P CLASS="Base">&nbsp;</P>

<HR>
<A NAME="GEN_Seq_OperatioNumberId"><P CLASS="Header0">Generator: Seq_OperatioNumberId</P><P CLASS="Base">&nbsp;</P>
<P CLASS="Header1">Definition</P>
<P CLASS="Base"><span class="DDLCode">
<code><pre>
<b>CREATE</b><b> </b><b>GENERATOR</b><b> </b><font color="# 080 0"><u>&quot;Seq_OperatioNumberId&quot;</u></font>

</pre></code>
</span></P>
<P CLASS="Base">&nbsp;</P>

<HR>
<A NAME="GEN_Seq_OperationNameId"><P CLASS="Header0">Generator: Seq_OperationNameId</P><P CLASS="Base">&nbsp;</P>
<P CLASS="Header1">Definition</P>
<P CLASS="Base"><span class="DDLCode">
<code><pre>
<b>CREATE</b><b> </b><b>GENERATOR</b><b> </b><font color="# 080 0"><u>&quot;Seq_OperationNameId&quot;</u></font>

</pre></code>
</span></P>
<P CLASS="Base">&nbsp;</P>

<HR>
<A NAME="GEN_Seq_OperationPaintMaterialId"><P CLASS="Header0">Generator: Seq_OperationPaintMaterialId</P><P CLASS="Base">&nbsp;</P>
<P CLASS="Header1">Definition</P>
<P CLASS="Base"><span class="DDLCode">
<code><pre>
<b>CREATE</b><b> </b><b>GENERATOR</b><b> </b><font color="# 080 0"><u>&quot;Seq_OperationPaintMaterialId&quot;</u></font>

</pre></code>
</span></P>
<P CLASS="Base">&nbsp;</P>

<HR>
<A NAME="GEN_Seq_RevisionTypeId"><P CLASS="Header0">Generator: Seq_RevisionTypeId</P><P CLASS="Base">&nbsp;</P>
<P CLASS="Header1">Definition</P>
<P CLASS="Base"><span class="DDLCode">
<code><pre>
<b>CREATE</b><b> </b><b>GENERATOR</b><b> </b><font color="# 080 0"><u>&quot;Seq_RevisionTypeId&quot;</u></font>

</pre></code>
</span></P>
<P CLASS="Base">&nbsp;</P>

<HR>
<A NAME="GEN_Seq_RevisionsId"><P CLASS="Header0">Generator: Seq_RevisionsId</P><P CLASS="Base">&nbsp;</P>
<P CLASS="Header1">Definition</P>
<P CLASS="Base"><span class="DDLCode">
<code><pre>
<b>CREATE</b><b> </b><b>GENERATOR</b><b> </b><font color="# 080 0"><u>&quot;Seq_RevisionsId&quot;</u></font>

</pre></code>
</span></P>
<P CLASS="Base">&nbsp;</P>

<HR>
<A NAME="GEN_Seq_TechProcess001Id"><P CLASS="Header0">Generator: Seq_TechProcess001Id</P><P CLASS="Base">&nbsp;</P>
<P CLASS="Header1">Definition</P>
<P CLASS="Base"><span class="DDLCode">
<code><pre>
<b>CREATE</b><b> </b><b>GENERATOR</b><b> </b><font color="# 080 0"><u>&quot;Seq_TechProcess001Id&quot;</u></font>

</pre></code>
</span></P>
<P CLASS="Base">&nbsp;</P>

<HR>
<A NAME="GEN_Seq_TechProcess002Id"><P CLASS="Header0">Generator: Seq_TechProcess002Id</P><P CLASS="Base">&nbsp;</P>
<P CLASS="Header1">Definition</P>
<P CLASS="Base"><span class="DDLCode">
<code><pre>
<b>CREATE</b><b> </b><b>GENERATOR</b><b> </b><font color="# 080 0"><u>&quot;Seq_TechProcess002Id&quot;</u></font>

</pre></code>
</span></P>
<P CLASS="Base">&nbsp;</P>

<HR>
<A NAME="GEN_Seq_TechProcess003Id"><P CLASS="Header0">Generator: Seq_TechProcess003Id</P><P CLASS="Base">&nbsp;</P>
<P CLASS="Header1">Definition</P>
<P CLASS="Base"><span class="DDLCode">
<code><pre>
<b>CREATE</b><b> </b><b>GENERATOR</b><b> </b><font color="# 080 0"><u>&quot;Seq_TechProcess003Id&quot;</u></font>

</pre></code>
</span></P>
<P CLASS="Base">&nbsp;</P>

<HR>
<A NAME="GEN_Seq_TechProcess004Id"><P CLASS="Header0">Generator: Seq_TechProcess004Id</P><P CLASS="Base">&nbsp;</P>
<P CLASS="Header1">Definition</P>
<P CLASS="Base"><span class="DDLCode">
<code><pre>
<b>CREATE</b><b> </b><b>GENERATOR</b><b> </b><font color="# 080 0"><u>&quot;Seq_TechProcess004Id&quot;</u></font>

</pre></code>
</span></P>
<P CLASS="Base">&nbsp;</P>

<HR>
<A NAME="GEN_Seq_TechProcess005Id"><P CLASS="Header0">Generator: Seq_TechProcess005Id</P><P CLASS="Base">&nbsp;</P>
<P CLASS="Header1">Definition</P>
<P CLASS="Base"><span class="DDLCode">
<code><pre>
<b>CREATE</b><b> </b><b>GENERATOR</b><b> </b><font color="# 080 0"><u>&quot;Seq_TechProcess005Id&quot;</u></font>

</pre></code>
</span></P>
<P CLASS="Base">&nbsp;</P>

<HR>
<A NAME="GEN_Seq_UserId"><P CLASS="Header0">Generator: Seq_UserId</P><P CLASS="Base">&nbsp;</P>
<P CLASS="Header1">Definition</P>
<P CLASS="Base"><span class="DDLCode">
<code><pre>
<b>CREATE</b><b> </b><b>GENERATOR</b><b> </b><font color="# 080 0"><u>&quot;Seq_UserId&quot;</u></font>

</pre></code>
</span></P>
<P CLASS="Base">&nbsp;</P>

<HR>
<A NAME="GEN_Seq_UserRoleId"><P CLASS="Header0">Generator: Seq_UserRoleId</P><P CLASS="Base">&nbsp;</P>
<P CLASS="Header1">Definition</P>
<P CLASS="Base"><span class="DDLCode">
<code><pre>
<b>CREATE</b><b> </b><b>GENERATOR</b><b> </b><font color="# 080 0"><u>&quot;Seq_UserRoleId&quot;</u></font>

</pre></code>
</span></P>
<P CLASS="Base">&nbsp;</P>

<HR>
<A NAME="_EXCEPTIONS"><P CLASS="Header0">Exceptions</P></A>
<P CLASS="Base">&nbsp;</P>
<TABLE CLASS="dtArg" CELLSPACING="0">
  <TH WIDTH="1%"><P CLASS="Base2"><B>Exception</B></P>
  <TH WIDTH="1%"><P CLASS="Base2"><B>ID</B></P>
  <TH WIDTH="45%"><P CLASS="Base2"><B>Exception text</B></P>
  <TH WIDTH="50%"><P CLASS="Base2"><B>Description</B></P>
</TABLE>

<HR>
<A NAME="_UDFS"><P CLASS="Header0">UDFs</P></A>
<P CLASS="Base">&nbsp;</P>
<TABLE CLASS="dtArg" CELLSPACING="0">
  <TH WIDTH="1%"><P CLASS="Base2"><B>UDF</B></P>
  <TH WIDTH="1%"><P CLASS="Base2"><B>Entry Point</B></P>
  <TH WIDTH="1%"><P CLASS="Base2"><B>Library Name</B></P>
  <TH WIDTH="1%"><P CLASS="Base2"><B>Input Parameters</B></P>
  <TH WIDTH="1%"><P CLASS="Base2"><B>Returns</B></P>
  <TH><P CLASS="Base2"><B>Description</B></P>
</TABLE>

<HR>
<A NAME="_INDICES"><P CLASS="Header0">Indices</P></A>
<P CLASS="Base">&nbsp;</P>
<TABLE CLASS="dtArg" CELLSPACING="0">
  <TH WIDTH="1%"><P CLASS="Base2"><B>Index</B></P>
  <TH WIDTH="1%"><P CLASS="Base2"><B>Table</B></P>
  <TH WIDTH="45%"><P CLASS="Base2"><B>Fields</B></P>
  <TH WIDTH="1%" ALIGN="middle"><P CLASS="Base2"><B>Active</B></P>
  <TH WIDTH="1%" ALIGN="middle"><P CLASS="Base2"><B>Unique</B></P>
  <TH WIDTH="1%" ALIGN="middle"><P CLASS="Base2"><B>Order</B></P>
  <TR>
    <TD><P CLASS="Base2"><A HREF="#IND_FK_ColorId_CurrentLevelMenuId">FK_ColorId_CurrentLevelMenuId</A></TD>
    <TD><P CLASS="Base2"><A HREF="#TBL_Drawings">Drawings</A></TD>
    <TD><P CLASS="Base2">"CurrentLevelMenuColorId"</TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/Yes.gif" BORDER="0"></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></TD>
    <TD ALIGN="middle"><P CLASS="Base2">ASC</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2"><A HREF="#IND_FK_ColorId_DrawingId">FK_ColorId_DrawingId</A></TD>
    <TD><P CLASS="Base2"><A HREF="#TBL_Drawings">Drawings</A></TD>
    <TD><P CLASS="Base2">"DrawingColorId"</TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/Yes.gif" BORDER="0"></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></TD>
    <TD ALIGN="middle"><P CLASS="Base2">ASC</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2"><A HREF="#IND_FK_ColorId_MaterialId">FK_ColorId_MaterialId</A></TD>
    <TD><P CLASS="Base2"><A HREF="#TBL_Drawings">Drawings</A></TD>
    <TD><P CLASS="Base2">"MaterialColorId"</TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/Yes.gif" BORDER="0"></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></TD>
    <TD ALIGN="middle"><P CLASS="Base2">ASC</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2"><A HREF="#IND_FK_DrawingScan_Drawing">FK_DrawingScan_Drawing</A></TD>
    <TD><P CLASS="Base2"><A HREF="#TBL_DrawingScan">DrawingScan</A></TD>
    <TD><P CLASS="Base2">"DrawingId"</TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/Yes.gif" BORDER="0"></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></TD>
    <TD ALIGN="middle"><P CLASS="Base2">ASC</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2"><A HREF="#IND_FK_Drawing_DetId">FK_Drawing_DetId</A></TD>
    <TD><P CLASS="Base2"><A HREF="#TBL_Drawing">Drawing</A></TD>
    <TD><P CLASS="Base2">"DetailId"</TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/Yes.gif" BORDER="0"></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></TD>
    <TD ALIGN="middle"><P CLASS="Base2">ASC</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2"><A HREF="#IND_FK_Drawing_MatId">FK_Drawing_MatId</A></TD>
    <TD><P CLASS="Base2"><A HREF="#TBL_Drawing">Drawing</A></TD>
    <TD><P CLASS="Base2">"MaterialId"</TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/Yes.gif" BORDER="0"></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></TD>
    <TD ALIGN="middle"><P CLASS="Base2">ASC</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2"><A HREF="#IND_FK_Drawing_ParentId">FK_Drawing_ParentId</A></TD>
    <TD><P CLASS="Base2"><A HREF="#TBL_Drawing">Drawing</A></TD>
    <TD><P CLASS="Base2">"ParentId"</TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/Yes.gif" BORDER="0"></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></TD>
    <TD ALIGN="middle"><P CLASS="Base2">ASC</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2"><A HREF="#IND_FK_Drawing_RevId">FK_Drawing_RevId</A></TD>
    <TD><P CLASS="Base2"><A HREF="#TBL_Drawing">Drawing</A></TD>
    <TD><P CLASS="Base2">"RevisionId"</TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/Yes.gif" BORDER="0"></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></TD>
    <TD ALIGN="middle"><P CLASS="Base2">ASC</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2"><A HREF="#IND_FK_Drawing_TypeId">FK_Drawing_TypeId</A></TD>
    <TD><P CLASS="Base2"><A HREF="#TBL_Drawing">Drawing</A></TD>
    <TD><P CLASS="Base2">"TypeId"</TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/Yes.gif" BORDER="0"></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></TD>
    <TD ALIGN="middle"><P CLASS="Base2">ASC</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2"><A HREF="#IND_FK_Drawing_UserId">FK_Drawing_UserId</A></TD>
    <TD><P CLASS="Base2"><A HREF="#TBL_Drawing">Drawing</A></TD>
    <TD><P CLASS="Base2">"UserId"</TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/Yes.gif" BORDER="0"></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></TD>
    <TD ALIGN="middle"><P CLASS="Base2">ASC</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2"><A HREF="#IND_FK_Drawings_DrawingId">FK_Drawings_DrawingId</A></TD>
    <TD><P CLASS="Base2"><A HREF="#TBL_Drawings">Drawings</A></TD>
    <TD><P CLASS="Base2">"DrawingId"</TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/Yes.gif" BORDER="0"></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></TD>
    <TD ALIGN="middle"><P CLASS="Base2">ASC</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2"><A HREF="#IND_FK_Drawings_Id">FK_Drawings_Id</A></TD>
    <TD><P CLASS="Base2"><A HREF="#TBL_Drawings">Drawings</A></TD>
    <TD><P CLASS="Base2">"ParentId"</TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/Yes.gif" BORDER="0"></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></TD>
    <TD ALIGN="middle"><P CLASS="Base2">ASC</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2"><A HREF="#IND_FK_Drawings_OccurrenceId">FK_Drawings_OccurrenceId</A></TD>
    <TD><P CLASS="Base2"><A HREF="#TBL_Drawings">Drawings</A></TD>
    <TD><P CLASS="Base2">"OccurrenceId"</TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/Yes.gif" BORDER="0"></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></TD>
    <TD ALIGN="middle"><P CLASS="Base2">ASC</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2"><A HREF="#IND_FK_Drawings_ReplaceDrawingId">FK_Drawings_ReplaceDrawingId</A></TD>
    <TD><P CLASS="Base2"><A HREF="#TBL_Drawings">Drawings</A></TD>
    <TD><P CLASS="Base2">"ReplaceDrawingId"</TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/Yes.gif" BORDER="0"></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></TD>
    <TD ALIGN="middle"><P CLASS="Base2">ASC</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2"><A HREF="#IND_FK_TechProcess001_CopyDrawingId">FK_TechProcess001_CopyDrawingId</A></TD>
    <TD><P CLASS="Base2"><A HREF="#TBL_TechProcess001">TechProcess001</A></TD>
    <TD><P CLASS="Base2">"CopyDrawingId"</TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/Yes.gif" BORDER="0"></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></TD>
    <TD ALIGN="middle"><P CLASS="Base2">ASC</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2"><A HREF="#IND_FK_TechProcess001_DrawingId">FK_TechProcess001_DrawingId</A></TD>
    <TD><P CLASS="Base2"><A HREF="#TBL_TechProcess001">TechProcess001</A></TD>
    <TD><P CLASS="Base2">"DrawingId"</TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/Yes.gif" BORDER="0"></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></TD>
    <TD ALIGN="middle"><P CLASS="Base2">ASC</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2"><A HREF="#IND_FK_TechProcess001_ParentId">FK_TechProcess001_ParentId</A></TD>
    <TD><P CLASS="Base2"><A HREF="#TBL_TechProcess001">TechProcess001</A></TD>
    <TD><P CLASS="Base2">"ParentId"</TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/Yes.gif" BORDER="0"></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></TD>
    <TD ALIGN="middle"><P CLASS="Base2">ASC</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2"><A HREF="#IND_FK_TechProcess001_RevisionId">FK_TechProcess001_RevisionId</A></TD>
    <TD><P CLASS="Base2"><A HREF="#TBL_TechProcess001">TechProcess001</A></TD>
    <TD><P CLASS="Base2">"RevisionId"</TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/Yes.gif" BORDER="0"></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></TD>
    <TD ALIGN="middle"><P CLASS="Base2">ASC</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2"><A HREF="#IND_FK_TechProcess001_TypeId">FK_TechProcess001_TypeId</A></TD>
    <TD><P CLASS="Base2"><A HREF="#TBL_TechProcess001">TechProcess001</A></TD>
    <TD><P CLASS="Base2">"TypeId"</TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/Yes.gif" BORDER="0"></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></TD>
    <TD ALIGN="middle"><P CLASS="Base2">ASC</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2"><A HREF="#IND_FK_TechProcess001_UserId">FK_TechProcess001_UserId</A></TD>
    <TD><P CLASS="Base2"><A HREF="#TBL_TechProcess001">TechProcess001</A></TD>
    <TD><P CLASS="Base2">"UserId"</TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/Yes.gif" BORDER="0"></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></TD>
    <TD ALIGN="middle"><P CLASS="Base2">ASC</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2"><A HREF="#IND_FK_TechProcess002_CopyDrawingId">FK_TechProcess002_CopyDrawingId</A></TD>
    <TD><P CLASS="Base2"><A HREF="#TBL_TechProcess002">TechProcess002</A></TD>
    <TD><P CLASS="Base2">"CopyDrawingId"</TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/Yes.gif" BORDER="0"></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></TD>
    <TD ALIGN="middle"><P CLASS="Base2">ASC</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2"><A HREF="#IND_FK_TechProcess002_DrawingId">FK_TechProcess002_DrawingId</A></TD>
    <TD><P CLASS="Base2"><A HREF="#TBL_TechProcess002">TechProcess002</A></TD>
    <TD><P CLASS="Base2">"DrawingId"</TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/Yes.gif" BORDER="0"></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></TD>
    <TD ALIGN="middle"><P CLASS="Base2">ASC</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2"><A HREF="#IND_FK_TechProcess002_ParentId">FK_TechProcess002_ParentId</A></TD>
    <TD><P CLASS="Base2"><A HREF="#TBL_TechProcess002">TechProcess002</A></TD>
    <TD><P CLASS="Base2">"ParentId"</TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/Yes.gif" BORDER="0"></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></TD>
    <TD ALIGN="middle"><P CLASS="Base2">ASC</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2"><A HREF="#IND_FK_TechProcess002_RevisionId">FK_TechProcess002_RevisionId</A></TD>
    <TD><P CLASS="Base2"><A HREF="#TBL_TechProcess002">TechProcess002</A></TD>
    <TD><P CLASS="Base2">"RevisionId"</TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/Yes.gif" BORDER="0"></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></TD>
    <TD ALIGN="middle"><P CLASS="Base2">ASC</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2"><A HREF="#IND_FK_TechProcess002_TypeId">FK_TechProcess002_TypeId</A></TD>
    <TD><P CLASS="Base2"><A HREF="#TBL_TechProcess002">TechProcess002</A></TD>
    <TD><P CLASS="Base2">"TypeId"</TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/Yes.gif" BORDER="0"></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></TD>
    <TD ALIGN="middle"><P CLASS="Base2">ASC</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2"><A HREF="#IND_FK_TechProcess002_UserId">FK_TechProcess002_UserId</A></TD>
    <TD><P CLASS="Base2"><A HREF="#TBL_TechProcess002">TechProcess002</A></TD>
    <TD><P CLASS="Base2">"UserId"</TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/Yes.gif" BORDER="0"></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></TD>
    <TD ALIGN="middle"><P CLASS="Base2">ASC</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2"><A HREF="#IND_FK_TechProcess003_CopyDrawingId">FK_TechProcess003_CopyDrawingId</A></TD>
    <TD><P CLASS="Base2"><A HREF="#TBL_TechProcess003">TechProcess003</A></TD>
    <TD><P CLASS="Base2">"CopyDrawingId"</TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/Yes.gif" BORDER="0"></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></TD>
    <TD ALIGN="middle"><P CLASS="Base2">ASC</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2"><A HREF="#IND_FK_TechProcess003_DrawingId">FK_TechProcess003_DrawingId</A></TD>
    <TD><P CLASS="Base2"><A HREF="#TBL_TechProcess003">TechProcess003</A></TD>
    <TD><P CLASS="Base2">"DrawingId"</TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/Yes.gif" BORDER="0"></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></TD>
    <TD ALIGN="middle"><P CLASS="Base2">ASC</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2"><A HREF="#IND_FK_TechProcess003_ParentId">FK_TechProcess003_ParentId</A></TD>
    <TD><P CLASS="Base2"><A HREF="#TBL_TechProcess003">TechProcess003</A></TD>
    <TD><P CLASS="Base2">"ParentId"</TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/Yes.gif" BORDER="0"></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></TD>
    <TD ALIGN="middle"><P CLASS="Base2">ASC</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2"><A HREF="#IND_FK_TechProcess003_RevisionId">FK_TechProcess003_RevisionId</A></TD>
    <TD><P CLASS="Base2"><A HREF="#TBL_TechProcess003">TechProcess003</A></TD>
    <TD><P CLASS="Base2">"RevisionId"</TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/Yes.gif" BORDER="0"></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></TD>
    <TD ALIGN="middle"><P CLASS="Base2">ASC</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2"><A HREF="#IND_FK_TechProcess003_TypeId">FK_TechProcess003_TypeId</A></TD>
    <TD><P CLASS="Base2"><A HREF="#TBL_TechProcess003">TechProcess003</A></TD>
    <TD><P CLASS="Base2">"TypeId"</TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/Yes.gif" BORDER="0"></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></TD>
    <TD ALIGN="middle"><P CLASS="Base2">ASC</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2"><A HREF="#IND_FK_TechProcess003_UserId">FK_TechProcess003_UserId</A></TD>
    <TD><P CLASS="Base2"><A HREF="#TBL_TechProcess003">TechProcess003</A></TD>
    <TD><P CLASS="Base2">"UserId"</TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/Yes.gif" BORDER="0"></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></TD>
    <TD ALIGN="middle"><P CLASS="Base2">ASC</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2"><A HREF="#IND_FK_TechProcess004_CopyDrawingId">FK_TechProcess004_CopyDrawingId</A></TD>
    <TD><P CLASS="Base2"><A HREF="#TBL_TechProcess004">TechProcess004</A></TD>
    <TD><P CLASS="Base2">"CopyDrawingId"</TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/Yes.gif" BORDER="0"></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></TD>
    <TD ALIGN="middle"><P CLASS="Base2">ASC</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2"><A HREF="#IND_FK_TechProcess004_DrawingId">FK_TechProcess004_DrawingId</A></TD>
    <TD><P CLASS="Base2"><A HREF="#TBL_TechProcess004">TechProcess004</A></TD>
    <TD><P CLASS="Base2">"DrawingId"</TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/Yes.gif" BORDER="0"></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></TD>
    <TD ALIGN="middle"><P CLASS="Base2">ASC</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2"><A HREF="#IND_FK_TechProcess004_ParentId">FK_TechProcess004_ParentId</A></TD>
    <TD><P CLASS="Base2"><A HREF="#TBL_TechProcess004">TechProcess004</A></TD>
    <TD><P CLASS="Base2">"ParentId"</TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/Yes.gif" BORDER="0"></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></TD>
    <TD ALIGN="middle"><P CLASS="Base2">ASC</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2"><A HREF="#IND_FK_TechProcess004_RevisionId">FK_TechProcess004_RevisionId</A></TD>
    <TD><P CLASS="Base2"><A HREF="#TBL_TechProcess004">TechProcess004</A></TD>
    <TD><P CLASS="Base2">"RevisionId"</TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/Yes.gif" BORDER="0"></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></TD>
    <TD ALIGN="middle"><P CLASS="Base2">ASC</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2"><A HREF="#IND_FK_TechProcess004_TypeId">FK_TechProcess004_TypeId</A></TD>
    <TD><P CLASS="Base2"><A HREF="#TBL_TechProcess004">TechProcess004</A></TD>
    <TD><P CLASS="Base2">"TypeId"</TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/Yes.gif" BORDER="0"></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></TD>
    <TD ALIGN="middle"><P CLASS="Base2">ASC</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2"><A HREF="#IND_FK_TechProcess004_UserId">FK_TechProcess004_UserId</A></TD>
    <TD><P CLASS="Base2"><A HREF="#TBL_TechProcess004">TechProcess004</A></TD>
    <TD><P CLASS="Base2">"UserId"</TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/Yes.gif" BORDER="0"></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></TD>
    <TD ALIGN="middle"><P CLASS="Base2">ASC</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2"><A HREF="#IND_FK_TechProcess005_CopyDrawingId">FK_TechProcess005_CopyDrawingId</A></TD>
    <TD><P CLASS="Base2"><A HREF="#TBL_TechProcess005">TechProcess005</A></TD>
    <TD><P CLASS="Base2">"CopyDrawingId"</TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/Yes.gif" BORDER="0"></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></TD>
    <TD ALIGN="middle"><P CLASS="Base2">ASC</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2"><A HREF="#IND_FK_TechProcess005_DrawingId">FK_TechProcess005_DrawingId</A></TD>
    <TD><P CLASS="Base2"><A HREF="#TBL_TechProcess005">TechProcess005</A></TD>
    <TD><P CLASS="Base2">"DrawingId"</TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/Yes.gif" BORDER="0"></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></TD>
    <TD ALIGN="middle"><P CLASS="Base2">ASC</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2"><A HREF="#IND_FK_TechProcess005_ParentId">FK_TechProcess005_ParentId</A></TD>
    <TD><P CLASS="Base2"><A HREF="#TBL_TechProcess005">TechProcess005</A></TD>
    <TD><P CLASS="Base2">"ParentId"</TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/Yes.gif" BORDER="0"></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></TD>
    <TD ALIGN="middle"><P CLASS="Base2">ASC</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2"><A HREF="#IND_FK_TechProcess005_RevisionId">FK_TechProcess005_RevisionId</A></TD>
    <TD><P CLASS="Base2"><A HREF="#TBL_TechProcess005">TechProcess005</A></TD>
    <TD><P CLASS="Base2">"RevisionId"</TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/Yes.gif" BORDER="0"></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></TD>
    <TD ALIGN="middle"><P CLASS="Base2">ASC</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2"><A HREF="#IND_FK_TechProcess005_TypeId">FK_TechProcess005_TypeId</A></TD>
    <TD><P CLASS="Base2"><A HREF="#TBL_TechProcess005">TechProcess005</A></TD>
    <TD><P CLASS="Base2">"TypeId"</TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/Yes.gif" BORDER="0"></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></TD>
    <TD ALIGN="middle"><P CLASS="Base2">ASC</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2"><A HREF="#IND_FK_TechProcess005_UserId">FK_TechProcess005_UserId</A></TD>
    <TD><P CLASS="Base2"><A HREF="#TBL_TechProcess005">TechProcess005</A></TD>
    <TD><P CLASS="Base2">"UserId"</TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/Yes.gif" BORDER="0"></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></TD>
    <TD ALIGN="middle"><P CLASS="Base2">ASC</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2"><A HREF="#IND_FK_Users_RoleId">FK_Users_RoleId</A></TD>
    <TD><P CLASS="Base2"><A HREF="#TBL_Users">Users</A></TD>
    <TD><P CLASS="Base2">"RoleId"</TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/Yes.gif" BORDER="0"></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/No.gif" BORDER="0"></TD>
    <TD ALIGN="middle"><P CLASS="Base2">ASC</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2"><A HREF="#IND_PK_ColorsId">PK_ColorsId</A></TD>
    <TD><P CLASS="Base2"><A HREF="#TBL_Colors">Colors</A></TD>
    <TD><P CLASS="Base2">"Id"</TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/Yes.gif" BORDER="0"></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/Yes.gif" BORDER="0"></TD>
    <TD ALIGN="middle"><P CLASS="Base2">ASC</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2"><A HREF="#IND_PK_DetailsId">PK_DetailsId</A></TD>
    <TD><P CLASS="Base2"><A HREF="#TBL_Details">Details</A></TD>
    <TD><P CLASS="Base2">"Id"</TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/Yes.gif" BORDER="0"></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/Yes.gif" BORDER="0"></TD>
    <TD ALIGN="middle"><P CLASS="Base2">ASC</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2"><A HREF="#IND_PK_DrawingId">PK_DrawingId</A></TD>
    <TD><P CLASS="Base2"><A HREF="#TBL_Drawing">Drawing</A></TD>
    <TD><P CLASS="Base2">"Id"</TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/Yes.gif" BORDER="0"></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/Yes.gif" BORDER="0"></TD>
    <TD ALIGN="middle"><P CLASS="Base2">ASC</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2"><A HREF="#IND_PK_DrawingScanId">PK_DrawingScanId</A></TD>
    <TD><P CLASS="Base2"><A HREF="#TBL_DrawingScan">DrawingScan</A></TD>
    <TD><P CLASS="Base2">"Id"</TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/Yes.gif" BORDER="0"></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/Yes.gif" BORDER="0"></TD>
    <TD ALIGN="middle"><P CLASS="Base2">ASC</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2"><A HREF="#IND_PK_DrawingsId">PK_DrawingsId</A></TD>
    <TD><P CLASS="Base2"><A HREF="#TBL_Drawings">Drawings</A></TD>
    <TD><P CLASS="Base2">"Id"</TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/Yes.gif" BORDER="0"></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/Yes.gif" BORDER="0"></TD>
    <TD ALIGN="middle"><P CLASS="Base2">ASC</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2"><A HREF="#IND_PK_MaterialsId">PK_MaterialsId</A></TD>
    <TD><P CLASS="Base2"><A HREF="#TBL_Materials">Materials</A></TD>
    <TD><P CLASS="Base2">"Id"</TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/Yes.gif" BORDER="0"></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/Yes.gif" BORDER="0"></TD>
    <TD ALIGN="middle"><P CLASS="Base2">ASC</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2"><A HREF="#IND_PK_OperationNameId">PK_OperationNameId</A></TD>
    <TD><P CLASS="Base2"><A HREF="#TBL_OperationName">OperationName</A></TD>
    <TD><P CLASS="Base2">"Id"</TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/Yes.gif" BORDER="0"></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/Yes.gif" BORDER="0"></TD>
    <TD ALIGN="middle"><P CLASS="Base2">ASC</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2"><A HREF="#IND_PK_OperationNumberId">PK_OperationNumberId</A></TD>
    <TD><P CLASS="Base2"><A HREF="#TBL_OperationNumber">OperationNumber</A></TD>
    <TD><P CLASS="Base2">"Id"</TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/Yes.gif" BORDER="0"></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/Yes.gif" BORDER="0"></TD>
    <TD ALIGN="middle"><P CLASS="Base2">ASC</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2"><A HREF="#IND_PK_OperationPaintMaterialId">PK_OperationPaintMaterialId</A></TD>
    <TD><P CLASS="Base2"><A HREF="#TBL_OperationPaintMaterial">OperationPaintMaterial</A></TD>
    <TD><P CLASS="Base2">"Id"</TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/Yes.gif" BORDER="0"></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/Yes.gif" BORDER="0"></TD>
    <TD ALIGN="middle"><P CLASS="Base2">ASC</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2"><A HREF="#IND_PK_RevisionTypeId">PK_RevisionTypeId</A></TD>
    <TD><P CLASS="Base2"><A HREF="#TBL_RevisionType">RevisionType</A></TD>
    <TD><P CLASS="Base2">"Id"</TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/Yes.gif" BORDER="0"></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/Yes.gif" BORDER="0"></TD>
    <TD ALIGN="middle"><P CLASS="Base2">ASC</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2"><A HREF="#IND_PK_RevisionsId">PK_RevisionsId</A></TD>
    <TD><P CLASS="Base2"><A HREF="#TBL_Revisions">Revisions</A></TD>
    <TD><P CLASS="Base2">"Id"</TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/Yes.gif" BORDER="0"></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/Yes.gif" BORDER="0"></TD>
    <TD ALIGN="middle"><P CLASS="Base2">ASC</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2"><A HREF="#IND_PK_TechProcess001Id">PK_TechProcess001Id</A></TD>
    <TD><P CLASS="Base2"><A HREF="#TBL_TechProcess001">TechProcess001</A></TD>
    <TD><P CLASS="Base2">"Id"</TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/Yes.gif" BORDER="0"></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/Yes.gif" BORDER="0"></TD>
    <TD ALIGN="middle"><P CLASS="Base2">ASC</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2"><A HREF="#IND_PK_TechProcess002Id">PK_TechProcess002Id</A></TD>
    <TD><P CLASS="Base2"><A HREF="#TBL_TechProcess002">TechProcess002</A></TD>
    <TD><P CLASS="Base2">"Id"</TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/Yes.gif" BORDER="0"></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/Yes.gif" BORDER="0"></TD>
    <TD ALIGN="middle"><P CLASS="Base2">ASC</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2"><A HREF="#IND_PK_TechProcess003Id">PK_TechProcess003Id</A></TD>
    <TD><P CLASS="Base2"><A HREF="#TBL_TechProcess003">TechProcess003</A></TD>
    <TD><P CLASS="Base2">"Id"</TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/Yes.gif" BORDER="0"></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/Yes.gif" BORDER="0"></TD>
    <TD ALIGN="middle"><P CLASS="Base2">ASC</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2"><A HREF="#IND_PK_TechProcess004Id">PK_TechProcess004Id</A></TD>
    <TD><P CLASS="Base2"><A HREF="#TBL_TechProcess004">TechProcess004</A></TD>
    <TD><P CLASS="Base2">"Id"</TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/Yes.gif" BORDER="0"></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/Yes.gif" BORDER="0"></TD>
    <TD ALIGN="middle"><P CLASS="Base2">ASC</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2"><A HREF="#IND_PK_TechProcess005Id">PK_TechProcess005Id</A></TD>
    <TD><P CLASS="Base2"><A HREF="#TBL_TechProcess005">TechProcess005</A></TD>
    <TD><P CLASS="Base2">"Id"</TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/Yes.gif" BORDER="0"></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/Yes.gif" BORDER="0"></TD>
    <TD ALIGN="middle"><P CLASS="Base2">ASC</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2"><A HREF="#IND_PK_TypeId">PK_TypeId</A></TD>
    <TD><P CLASS="Base2"><A HREF="#TBL_Type">Type</A></TD>
    <TD><P CLASS="Base2">"Id"</TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/Yes.gif" BORDER="0"></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/Yes.gif" BORDER="0"></TD>
    <TD ALIGN="middle"><P CLASS="Base2">ASC</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2"><A HREF="#IND_PK_UserId">PK_UserId</A></TD>
    <TD><P CLASS="Base2"><A HREF="#TBL_Users">Users</A></TD>
    <TD><P CLASS="Base2">"Id"</TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/Yes.gif" BORDER="0"></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/Yes.gif" BORDER="0"></TD>
    <TD ALIGN="middle"><P CLASS="Base2">ASC</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2"><A HREF="#IND_PK_UserRoleId">PK_UserRoleId</A></TD>
    <TD><P CLASS="Base2"><A HREF="#TBL_UserRole">UserRole</A></TD>
    <TD><P CLASS="Base2">"Id"</TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/Yes.gif" BORDER="0"></TD>
    <TD ALIGN="middle"><P CLASS="Base2"><IMG SRC="Images/Yes.gif" BORDER="0"></TD>
    <TD ALIGN="middle"><P CLASS="Base2">ASC</TD>
  </TR>
</TABLE>

<HR>
<A NAME="IND_FK_ColorId_CurrentLevelMenuId"><P CLASS="Header0">Index: FK_ColorId_CurrentLevelMenuId</P><P CLASS="Base">&nbsp;</P>
<P CLASS="Header1">Definition</P>
<P CLASS="Base"><span class="DDLCode">
<code><pre>
<b>CREATE</b><b> </b><b>INDEX</b><b> </b>&quot;FK_ColorId_CurrentLevelMenuId&quot;<b> </b><b>ON</b><b> </b><font color="# 080 0"><u>&quot;Drawings&quot;</u></font><b> </b><b>(</b>&quot;CurrentLevelMenuColorId&quot;<b>)</b><b>;</b>

</pre></code>
</span></P>

<HR>
<A NAME="IND_FK_ColorId_DrawingId"><P CLASS="Header0">Index: FK_ColorId_DrawingId</P><P CLASS="Base">&nbsp;</P>
<P CLASS="Header1">Definition</P>
<P CLASS="Base"><span class="DDLCode">
<code><pre>
<b>CREATE</b><b> </b><b>INDEX</b><b> </b>&quot;FK_ColorId_DrawingId&quot;<b> </b><b>ON</b><b> </b><font color="# 080 0"><u>&quot;Drawings&quot;</u></font><b> </b><b>(</b>&quot;DrawingColorId&quot;<b>)</b><b>;</b>

</pre></code>
</span></P>

<HR>
<A NAME="IND_FK_ColorId_MaterialId"><P CLASS="Header0">Index: FK_ColorId_MaterialId</P><P CLASS="Base">&nbsp;</P>
<P CLASS="Header1">Definition</P>
<P CLASS="Base"><span class="DDLCode">
<code><pre>
<b>CREATE</b><b> </b><b>INDEX</b><b> </b>&quot;FK_ColorId_MaterialId&quot;<b> </b><b>ON</b><b> </b><font color="# 080 0"><u>&quot;Drawings&quot;</u></font><b> </b><b>(</b>&quot;MaterialColorId&quot;<b>)</b><b>;</b>

</pre></code>
</span></P>

<HR>
<A NAME="IND_FK_DrawingScan_Drawing"><P CLASS="Header0">Index: FK_DrawingScan_Drawing</P><P CLASS="Base">&nbsp;</P>
<P CLASS="Header1">Definition</P>
<P CLASS="Base"><span class="DDLCode">
<code><pre>
<b>CREATE</b><b> </b><b>INDEX</b><b> </b>&quot;FK_DrawingScan_Drawing&quot;<b> </b><b>ON</b><b> </b><font color="# 080 0"><u>&quot;DrawingScan&quot;</u></font><b> </b><b>(</b>&quot;DrawingId&quot;<b>)</b><b>;</b>

</pre></code>
</span></P>

<HR>
<A NAME="IND_FK_Drawing_DetId"><P CLASS="Header0">Index: FK_Drawing_DetId</P><P CLASS="Base">&nbsp;</P>
<P CLASS="Header1">Definition</P>
<P CLASS="Base"><span class="DDLCode">
<code><pre>
<b>CREATE</b><b> </b><b>INDEX</b><b> </b>&quot;FK_Drawing_DetId&quot;<b> </b><b>ON</b><b> </b><font color="# 080 0"><u>&quot;Drawing&quot;</u></font><b> </b><b>(</b>&quot;DetailId&quot;<b>)</b><b>;</b>

</pre></code>
</span></P>

<HR>
<A NAME="IND_FK_Drawing_MatId"><P CLASS="Header0">Index: FK_Drawing_MatId</P><P CLASS="Base">&nbsp;</P>
<P CLASS="Header1">Definition</P>
<P CLASS="Base"><span class="DDLCode">
<code><pre>
<b>CREATE</b><b> </b><b>INDEX</b><b> </b>&quot;FK_Drawing_MatId&quot;<b> </b><b>ON</b><b> </b><font color="# 080 0"><u>&quot;Drawing&quot;</u></font><b> </b><b>(</b>&quot;MaterialId&quot;<b>)</b><b>;</b>

</pre></code>
</span></P>

<HR>
<A NAME="IND_FK_Drawing_ParentId"><P CLASS="Header0">Index: FK_Drawing_ParentId</P><P CLASS="Base">&nbsp;</P>
<P CLASS="Header1">Definition</P>
<P CLASS="Base"><span class="DDLCode">
<code><pre>
<b>CREATE</b><b> </b><b>INDEX</b><b> </b>&quot;FK_Drawing_ParentId&quot;<b> </b><b>ON</b><b> </b><font color="# 080 0"><u>&quot;Drawing&quot;</u></font><b> </b><b>(</b>&quot;ParentId&quot;<b>)</b><b>;</b>

</pre></code>
</span></P>

<HR>
<A NAME="IND_FK_Drawing_RevId"><P CLASS="Header0">Index: FK_Drawing_RevId</P><P CLASS="Base">&nbsp;</P>
<P CLASS="Header1">Definition</P>
<P CLASS="Base"><span class="DDLCode">
<code><pre>
<b>CREATE</b><b> </b><b>INDEX</b><b> </b>&quot;FK_Drawing_RevId&quot;<b> </b><b>ON</b><b> </b><font color="# 080 0"><u>&quot;Drawing&quot;</u></font><b> </b><b>(</b>&quot;RevisionId&quot;<b>)</b><b>;</b>

</pre></code>
</span></P>

<HR>
<A NAME="IND_FK_Drawing_TypeId"><P CLASS="Header0">Index: FK_Drawing_TypeId</P><P CLASS="Base">&nbsp;</P>
<P CLASS="Header1">Definition</P>
<P CLASS="Base"><span class="DDLCode">
<code><pre>
<b>CREATE</b><b> </b><b>INDEX</b><b> </b>&quot;FK_Drawing_TypeId&quot;<b> </b><b>ON</b><b> </b><font color="# 080 0"><u>&quot;Drawing&quot;</u></font><b> </b><b>(</b>&quot;TypeId&quot;<b>)</b><b>;</b>

</pre></code>
</span></P>

<HR>
<A NAME="IND_FK_Drawing_UserId"><P CLASS="Header0">Index: FK_Drawing_UserId</P><P CLASS="Base">&nbsp;</P>
<P CLASS="Header1">Definition</P>
<P CLASS="Base"><span class="DDLCode">
<code><pre>
<b>CREATE</b><b> </b><b>INDEX</b><b> </b>&quot;FK_Drawing_UserId&quot;<b> </b><b>ON</b><b> </b><font color="# 080 0"><u>&quot;Drawing&quot;</u></font><b> </b><b>(</b>&quot;UserId&quot;<b>)</b><b>;</b>

</pre></code>
</span></P>

<HR>
<A NAME="IND_FK_Drawings_DrawingId"><P CLASS="Header0">Index: FK_Drawings_DrawingId</P><P CLASS="Base">&nbsp;</P>
<P CLASS="Header1">Definition</P>
<P CLASS="Base"><span class="DDLCode">
<code><pre>
<b>CREATE</b><b> </b><b>INDEX</b><b> </b>&quot;FK_Drawings_DrawingId&quot;<b> </b><b>ON</b><b> </b><font color="# 080 0"><u>&quot;Drawings&quot;</u></font><b> </b><b>(</b>&quot;DrawingId&quot;<b>)</b><b>;</b>

</pre></code>
</span></P>

<HR>
<A NAME="IND_FK_Drawings_Id"><P CLASS="Header0">Index: FK_Drawings_Id</P><P CLASS="Base">&nbsp;</P>
<P CLASS="Header1">Definition</P>
<P CLASS="Base"><span class="DDLCode">
<code><pre>
<b>CREATE</b><b> </b><b>INDEX</b><b> </b>&quot;FK_Drawings_Id&quot;<b> </b><b>ON</b><b> </b><font color="# 080 0"><u>&quot;Drawings&quot;</u></font><b> </b><b>(</b>&quot;ParentId&quot;<b>)</b><b>;</b>

</pre></code>
</span></P>

<HR>
<A NAME="IND_FK_Drawings_OccurrenceId"><P CLASS="Header0">Index: FK_Drawings_OccurrenceId</P><P CLASS="Base">&nbsp;</P>
<P CLASS="Header1">Definition</P>
<P CLASS="Base"><span class="DDLCode">
<code><pre>
<b>CREATE</b><b> </b><b>INDEX</b><b> </b>&quot;FK_Drawings_OccurrenceId&quot;<b> </b><b>ON</b><b> </b><font color="# 080 0"><u>&quot;Drawings&quot;</u></font><b> </b><b>(</b>&quot;OccurrenceId&quot;<b>)</b><b>;</b>

</pre></code>
</span></P>

<HR>
<A NAME="IND_FK_Drawings_ReplaceDrawingId"><P CLASS="Header0">Index: FK_Drawings_ReplaceDrawingId</P><P CLASS="Base">&nbsp;</P>
<P CLASS="Header1">Definition</P>
<P CLASS="Base"><span class="DDLCode">
<code><pre>
<b>CREATE</b><b> </b><b>INDEX</b><b> </b>&quot;FK_Drawings_ReplaceDrawingId&quot;<b> </b><b>ON</b><b> </b><font color="# 080 0"><u>&quot;Drawings&quot;</u></font><b> </b><b>(</b>&quot;ReplaceDrawingId&quot;<b>)</b><b>;</b>

</pre></code>
</span></P>

<HR>
<A NAME="IND_FK_TechProcess001_CopyDrawingId"><P CLASS="Header0">Index: FK_TechProcess001_CopyDrawingId</P><P CLASS="Base">&nbsp;</P>
<P CLASS="Header1">Definition</P>
<P CLASS="Base"><span class="DDLCode">
<code><pre>
<b>CREATE</b><b> </b><b>INDEX</b><b> </b>&quot;FK_TechProcess001_CopyDrawingId&quot;<b> </b><b>ON</b><b> </b><font color="# 080 0"><u>&quot;TechProcess001&quot;</u></font><b> </b><b>(</b>&quot;CopyDrawingId&quot;<b>)</b><b>;</b>

</pre></code>
</span></P>

<HR>
<A NAME="IND_FK_TechProcess001_DrawingId"><P CLASS="Header0">Index: FK_TechProcess001_DrawingId</P><P CLASS="Base">&nbsp;</P>
<P CLASS="Header1">Definition</P>
<P CLASS="Base"><span class="DDLCode">
<code><pre>
<b>CREATE</b><b> </b><b>INDEX</b><b> </b>&quot;FK_TechProcess001_DrawingId&quot;<b> </b><b>ON</b><b> </b><font color="# 080 0"><u>&quot;TechProcess001&quot;</u></font><b> </b><b>(</b>&quot;DrawingId&quot;<b>)</b><b>;</b>

</pre></code>
</span></P>

<HR>
<A NAME="IND_FK_TechProcess001_ParentId"><P CLASS="Header0">Index: FK_TechProcess001_ParentId</P><P CLASS="Base">&nbsp;</P>
<P CLASS="Header1">Definition</P>
<P CLASS="Base"><span class="DDLCode">
<code><pre>
<b>CREATE</b><b> </b><b>INDEX</b><b> </b>&quot;FK_TechProcess001_ParentId&quot;<b> </b><b>ON</b><b> </b><font color="# 080 0"><u>&quot;TechProcess001&quot;</u></font><b> </b><b>(</b>&quot;ParentId&quot;<b>)</b><b>;</b>

</pre></code>
</span></P>

<HR>
<A NAME="IND_FK_TechProcess001_RevisionId"><P CLASS="Header0">Index: FK_TechProcess001_RevisionId</P><P CLASS="Base">&nbsp;</P>
<P CLASS="Header1">Definition</P>
<P CLASS="Base"><span class="DDLCode">
<code><pre>
<b>CREATE</b><b> </b><b>INDEX</b><b> </b>&quot;FK_TechProcess001_RevisionId&quot;<b> </b><b>ON</b><b> </b><font color="# 080 0"><u>&quot;TechProcess001&quot;</u></font><b> </b><b>(</b>&quot;RevisionId&quot;<b>)</b><b>;</b>

</pre></code>
</span></P>

<HR>
<A NAME="IND_FK_TechProcess001_TypeId"><P CLASS="Header0">Index: FK_TechProcess001_TypeId</P><P CLASS="Base">&nbsp;</P>
<P CLASS="Header1">Definition</P>
<P CLASS="Base"><span class="DDLCode">
<code><pre>
<b>CREATE</b><b> </b><b>INDEX</b><b> </b>&quot;FK_TechProcess001_TypeId&quot;<b> </b><b>ON</b><b> </b><font color="# 080 0"><u>&quot;TechProcess001&quot;</u></font><b> </b><b>(</b>&quot;TypeId&quot;<b>)</b><b>;</b>

</pre></code>
</span></P>

<HR>
<A NAME="IND_FK_TechProcess001_UserId"><P CLASS="Header0">Index: FK_TechProcess001_UserId</P><P CLASS="Base">&nbsp;</P>
<P CLASS="Header1">Definition</P>
<P CLASS="Base"><span class="DDLCode">
<code><pre>
<b>CREATE</b><b> </b><b>INDEX</b><b> </b>&quot;FK_TechProcess001_UserId&quot;<b> </b><b>ON</b><b> </b><font color="# 080 0"><u>&quot;TechProcess001&quot;</u></font><b> </b><b>(</b>&quot;UserId&quot;<b>)</b><b>;</b>

</pre></code>
</span></P>

<HR>
<A NAME="IND_FK_TechProcess002_CopyDrawingId"><P CLASS="Header0">Index: FK_TechProcess002_CopyDrawingId</P><P CLASS="Base">&nbsp;</P>
<P CLASS="Header1">Definition</P>
<P CLASS="Base"><span class="DDLCode">
<code><pre>
<b>CREATE</b><b> </b><b>INDEX</b><b> </b>&quot;FK_TechProcess002_CopyDrawingId&quot;<b> </b><b>ON</b><b> </b><font color="# 080 0"><u>&quot;TechProcess002&quot;</u></font><b> </b><b>(</b>&quot;CopyDrawingId&quot;<b>)</b><b>;</b>

</pre></code>
</span></P>

<HR>
<A NAME="IND_FK_TechProcess002_DrawingId"><P CLASS="Header0">Index: FK_TechProcess002_DrawingId</P><P CLASS="Base">&nbsp;</P>
<P CLASS="Header1">Definition</P>
<P CLASS="Base"><span class="DDLCode">
<code><pre>
<b>CREATE</b><b> </b><b>INDEX</b><b> </b>&quot;FK_TechProcess002_DrawingId&quot;<b> </b><b>ON</b><b> </b><font color="# 080 0"><u>&quot;TechProcess002&quot;</u></font><b> </b><b>(</b>&quot;DrawingId&quot;<b>)</b><b>;</b>

</pre></code>
</span></P>

<HR>
<A NAME="IND_FK_TechProcess002_ParentId"><P CLASS="Header0">Index: FK_TechProcess002_ParentId</P><P CLASS="Base">&nbsp;</P>
<P CLASS="Header1">Definition</P>
<P CLASS="Base"><span class="DDLCode">
<code><pre>
<b>CREATE</b><b> </b><b>INDEX</b><b> </b>&quot;FK_TechProcess002_ParentId&quot;<b> </b><b>ON</b><b> </b><font color="# 080 0"><u>&quot;TechProcess002&quot;</u></font><b> </b><b>(</b>&quot;ParentId&quot;<b>)</b><b>;</b>

</pre></code>
</span></P>

<HR>
<A NAME="IND_FK_TechProcess002_RevisionId"><P CLASS="Header0">Index: FK_TechProcess002_RevisionId</P><P CLASS="Base">&nbsp;</P>
<P CLASS="Header1">Definition</P>
<P CLASS="Base"><span class="DDLCode">
<code><pre>
<b>CREATE</b><b> </b><b>INDEX</b><b> </b>&quot;FK_TechProcess002_RevisionId&quot;<b> </b><b>ON</b><b> </b><font color="# 080 0"><u>&quot;TechProcess002&quot;</u></font><b> </b><b>(</b>&quot;RevisionId&quot;<b>)</b><b>;</b>

</pre></code>
</span></P>

<HR>
<A NAME="IND_FK_TechProcess002_TypeId"><P CLASS="Header0">Index: FK_TechProcess002_TypeId</P><P CLASS="Base">&nbsp;</P>
<P CLASS="Header1">Definition</P>
<P CLASS="Base"><span class="DDLCode">
<code><pre>
<b>CREATE</b><b> </b><b>INDEX</b><b> </b>&quot;FK_TechProcess002_TypeId&quot;<b> </b><b>ON</b><b> </b><font color="# 080 0"><u>&quot;TechProcess002&quot;</u></font><b> </b><b>(</b>&quot;TypeId&quot;<b>)</b><b>;</b>

</pre></code>
</span></P>

<HR>
<A NAME="IND_FK_TechProcess002_UserId"><P CLASS="Header0">Index: FK_TechProcess002_UserId</P><P CLASS="Base">&nbsp;</P>
<P CLASS="Header1">Definition</P>
<P CLASS="Base"><span class="DDLCode">
<code><pre>
<b>CREATE</b><b> </b><b>INDEX</b><b> </b>&quot;FK_TechProcess002_UserId&quot;<b> </b><b>ON</b><b> </b><font color="# 080 0"><u>&quot;TechProcess002&quot;</u></font><b> </b><b>(</b>&quot;UserId&quot;<b>)</b><b>;</b>

</pre></code>
</span></P>

<HR>
<A NAME="IND_FK_TechProcess003_CopyDrawingId"><P CLASS="Header0">Index: FK_TechProcess003_CopyDrawingId</P><P CLASS="Base">&nbsp;</P>
<P CLASS="Header1">Definition</P>
<P CLASS="Base"><span class="DDLCode">
<code><pre>
<b>CREATE</b><b> </b><b>INDEX</b><b> </b>&quot;FK_TechProcess003_CopyDrawingId&quot;<b> </b><b>ON</b><b> </b><font color="# 080 0"><u>&quot;TechProcess003&quot;</u></font><b> </b><b>(</b>&quot;CopyDrawingId&quot;<b>)</b><b>;</b>

</pre></code>
</span></P>

<HR>
<A NAME="IND_FK_TechProcess003_DrawingId"><P CLASS="Header0">Index: FK_TechProcess003_DrawingId</P><P CLASS="Base">&nbsp;</P>
<P CLASS="Header1">Definition</P>
<P CLASS="Base"><span class="DDLCode">
<code><pre>
<b>CREATE</b><b> </b><b>INDEX</b><b> </b>&quot;FK_TechProcess003_DrawingId&quot;<b> </b><b>ON</b><b> </b><font color="# 080 0"><u>&quot;TechProcess003&quot;</u></font><b> </b><b>(</b>&quot;DrawingId&quot;<b>)</b><b>;</b>

</pre></code>
</span></P>

<HR>
<A NAME="IND_FK_TechProcess003_ParentId"><P CLASS="Header0">Index: FK_TechProcess003_ParentId</P><P CLASS="Base">&nbsp;</P>
<P CLASS="Header1">Definition</P>
<P CLASS="Base"><span class="DDLCode">
<code><pre>
<b>CREATE</b><b> </b><b>INDEX</b><b> </b>&quot;FK_TechProcess003_ParentId&quot;<b> </b><b>ON</b><b> </b><font color="# 080 0"><u>&quot;TechProcess003&quot;</u></font><b> </b><b>(</b>&quot;ParentId&quot;<b>)</b><b>;</b>

</pre></code>
</span></P>

<HR>
<A NAME="IND_FK_TechProcess003_RevisionId"><P CLASS="Header0">Index: FK_TechProcess003_RevisionId</P><P CLASS="Base">&nbsp;</P>
<P CLASS="Header1">Definition</P>
<P CLASS="Base"><span class="DDLCode">
<code><pre>
<b>CREATE</b><b> </b><b>INDEX</b><b> </b>&quot;FK_TechProcess003_RevisionId&quot;<b> </b><b>ON</b><b> </b><font color="# 080 0"><u>&quot;TechProcess003&quot;</u></font><b> </b><b>(</b>&quot;RevisionId&quot;<b>)</b><b>;</b>

</pre></code>
</span></P>

<HR>
<A NAME="IND_FK_TechProcess003_TypeId"><P CLASS="Header0">Index: FK_TechProcess003_TypeId</P><P CLASS="Base">&nbsp;</P>
<P CLASS="Header1">Definition</P>
<P CLASS="Base"><span class="DDLCode">
<code><pre>
<b>CREATE</b><b> </b><b>INDEX</b><b> </b>&quot;FK_TechProcess003_TypeId&quot;<b> </b><b>ON</b><b> </b><font color="# 080 0"><u>&quot;TechProcess003&quot;</u></font><b> </b><b>(</b>&quot;TypeId&quot;<b>)</b><b>;</b>

</pre></code>
</span></P>

<HR>
<A NAME="IND_FK_TechProcess003_UserId"><P CLASS="Header0">Index: FK_TechProcess003_UserId</P><P CLASS="Base">&nbsp;</P>
<P CLASS="Header1">Definition</P>
<P CLASS="Base"><span class="DDLCode">
<code><pre>
<b>CREATE</b><b> </b><b>INDEX</b><b> </b>&quot;FK_TechProcess003_UserId&quot;<b> </b><b>ON</b><b> </b><font color="# 080 0"><u>&quot;TechProcess003&quot;</u></font><b> </b><b>(</b>&quot;UserId&quot;<b>)</b><b>;</b>

</pre></code>
</span></P>

<HR>
<A NAME="IND_FK_TechProcess004_CopyDrawingId"><P CLASS="Header0">Index: FK_TechProcess004_CopyDrawingId</P><P CLASS="Base">&nbsp;</P>
<P CLASS="Header1">Definition</P>
<P CLASS="Base"><span class="DDLCode">
<code><pre>
<b>CREATE</b><b> </b><b>INDEX</b><b> </b>&quot;FK_TechProcess004_CopyDrawingId&quot;<b> </b><b>ON</b><b> </b><font color="# 080 0"><u>&quot;TechProcess004&quot;</u></font><b> </b><b>(</b>&quot;CopyDrawingId&quot;<b>)</b><b>;</b>

</pre></code>
</span></P>

<HR>
<A NAME="IND_FK_TechProcess004_DrawingId"><P CLASS="Header0">Index: FK_TechProcess004_DrawingId</P><P CLASS="Base">&nbsp;</P>
<P CLASS="Header1">Definition</P>
<P CLASS="Base"><span class="DDLCode">
<code><pre>
<b>CREATE</b><b> </b><b>INDEX</b><b> </b>&quot;FK_TechProcess004_DrawingId&quot;<b> </b><b>ON</b><b> </b><font color="# 080 0"><u>&quot;TechProcess004&quot;</u></font><b> </b><b>(</b>&quot;DrawingId&quot;<b>)</b><b>;</b>

</pre></code>
</span></P>

<HR>
<A NAME="IND_FK_TechProcess004_ParentId"><P CLASS="Header0">Index: FK_TechProcess004_ParentId</P><P CLASS="Base">&nbsp;</P>
<P CLASS="Header1">Definition</P>
<P CLASS="Base"><span class="DDLCode">
<code><pre>
<b>CREATE</b><b> </b><b>INDEX</b><b> </b>&quot;FK_TechProcess004_ParentId&quot;<b> </b><b>ON</b><b> </b><font color="# 080 0"><u>&quot;TechProcess004&quot;</u></font><b> </b><b>(</b>&quot;ParentId&quot;<b>)</b><b>;</b>

</pre></code>
</span></P>

<HR>
<A NAME="IND_FK_TechProcess004_RevisionId"><P CLASS="Header0">Index: FK_TechProcess004_RevisionId</P><P CLASS="Base">&nbsp;</P>
<P CLASS="Header1">Definition</P>
<P CLASS="Base"><span class="DDLCode">
<code><pre>
<b>CREATE</b><b> </b><b>INDEX</b><b> </b>&quot;FK_TechProcess004_RevisionId&quot;<b> </b><b>ON</b><b> </b><font color="# 080 0"><u>&quot;TechProcess004&quot;</u></font><b> </b><b>(</b>&quot;RevisionId&quot;<b>)</b><b>;</b>

</pre></code>
</span></P>

<HR>
<A NAME="IND_FK_TechProcess004_TypeId"><P CLASS="Header0">Index: FK_TechProcess004_TypeId</P><P CLASS="Base">&nbsp;</P>
<P CLASS="Header1">Definition</P>
<P CLASS="Base"><span class="DDLCode">
<code><pre>
<b>CREATE</b><b> </b><b>INDEX</b><b> </b>&quot;FK_TechProcess004_TypeId&quot;<b> </b><b>ON</b><b> </b><font color="# 080 0"><u>&quot;TechProcess004&quot;</u></font><b> </b><b>(</b>&quot;TypeId&quot;<b>)</b><b>;</b>

</pre></code>
</span></P>

<HR>
<A NAME="IND_FK_TechProcess004_UserId"><P CLASS="Header0">Index: FK_TechProcess004_UserId</P><P CLASS="Base">&nbsp;</P>
<P CLASS="Header1">Definition</P>
<P CLASS="Base"><span class="DDLCode">
<code><pre>
<b>CREATE</b><b> </b><b>INDEX</b><b> </b>&quot;FK_TechProcess004_UserId&quot;<b> </b><b>ON</b><b> </b><font color="# 080 0"><u>&quot;TechProcess004&quot;</u></font><b> </b><b>(</b>&quot;UserId&quot;<b>)</b><b>;</b>

</pre></code>
</span></P>

<HR>
<A NAME="IND_FK_TechProcess005_CopyDrawingId"><P CLASS="Header0">Index: FK_TechProcess005_CopyDrawingId</P><P CLASS="Base">&nbsp;</P>
<P CLASS="Header1">Definition</P>
<P CLASS="Base"><span class="DDLCode">
<code><pre>
<b>CREATE</b><b> </b><b>INDEX</b><b> </b>&quot;FK_TechProcess005_CopyDrawingId&quot;<b> </b><b>ON</b><b> </b><font color="# 080 0"><u>&quot;TechProcess005&quot;</u></font><b> </b><b>(</b>&quot;CopyDrawingId&quot;<b>)</b><b>;</b>

</pre></code>
</span></P>

<HR>
<A NAME="IND_FK_TechProcess005_DrawingId"><P CLASS="Header0">Index: FK_TechProcess005_DrawingId</P><P CLASS="Base">&nbsp;</P>
<P CLASS="Header1">Definition</P>
<P CLASS="Base"><span class="DDLCode">
<code><pre>
<b>CREATE</b><b> </b><b>INDEX</b><b> </b>&quot;FK_TechProcess005_DrawingId&quot;<b> </b><b>ON</b><b> </b><font color="# 080 0"><u>&quot;TechProcess005&quot;</u></font><b> </b><b>(</b>&quot;DrawingId&quot;<b>)</b><b>;</b>

</pre></code>
</span></P>

<HR>
<A NAME="IND_FK_TechProcess005_ParentId"><P CLASS="Header0">Index: FK_TechProcess005_ParentId</P><P CLASS="Base">&nbsp;</P>
<P CLASS="Header1">Definition</P>
<P CLASS="Base"><span class="DDLCode">
<code><pre>
<b>CREATE</b><b> </b><b>INDEX</b><b> </b>&quot;FK_TechProcess005_ParentId&quot;<b> </b><b>ON</b><b> </b><font color="# 080 0"><u>&quot;TechProcess005&quot;</u></font><b> </b><b>(</b>&quot;ParentId&quot;<b>)</b><b>;</b>

</pre></code>
</span></P>

<HR>
<A NAME="IND_FK_TechProcess005_RevisionId"><P CLASS="Header0">Index: FK_TechProcess005_RevisionId</P><P CLASS="Base">&nbsp;</P>
<P CLASS="Header1">Definition</P>
<P CLASS="Base"><span class="DDLCode">
<code><pre>
<b>CREATE</b><b> </b><b>INDEX</b><b> </b>&quot;FK_TechProcess005_RevisionId&quot;<b> </b><b>ON</b><b> </b><font color="# 080 0"><u>&quot;TechProcess005&quot;</u></font><b> </b><b>(</b>&quot;RevisionId&quot;<b>)</b><b>;</b>

</pre></code>
</span></P>

<HR>
<A NAME="IND_FK_TechProcess005_TypeId"><P CLASS="Header0">Index: FK_TechProcess005_TypeId</P><P CLASS="Base">&nbsp;</P>
<P CLASS="Header1">Definition</P>
<P CLASS="Base"><span class="DDLCode">
<code><pre>
<b>CREATE</b><b> </b><b>INDEX</b><b> </b>&quot;FK_TechProcess005_TypeId&quot;<b> </b><b>ON</b><b> </b><font color="# 080 0"><u>&quot;TechProcess005&quot;</u></font><b> </b><b>(</b>&quot;TypeId&quot;<b>)</b><b>;</b>

</pre></code>
</span></P>

<HR>
<A NAME="IND_FK_TechProcess005_UserId"><P CLASS="Header0">Index: FK_TechProcess005_UserId</P><P CLASS="Base">&nbsp;</P>
<P CLASS="Header1">Definition</P>
<P CLASS="Base"><span class="DDLCode">
<code><pre>
<b>CREATE</b><b> </b><b>INDEX</b><b> </b>&quot;FK_TechProcess005_UserId&quot;<b> </b><b>ON</b><b> </b><font color="# 080 0"><u>&quot;TechProcess005&quot;</u></font><b> </b><b>(</b>&quot;UserId&quot;<b>)</b><b>;</b>

</pre></code>
</span></P>

<HR>
<A NAME="IND_FK_Users_RoleId"><P CLASS="Header0">Index: FK_Users_RoleId</P><P CLASS="Base">&nbsp;</P>
<P CLASS="Header1">Definition</P>
<P CLASS="Base"><span class="DDLCode">
<code><pre>
<b>CREATE</b><b> </b><b>INDEX</b><b> </b>&quot;FK_Users_RoleId&quot;<b> </b><b>ON</b><b> </b><font color="# 080 0"><u>&quot;Users&quot;</u></font><b> </b><b>(</b>&quot;RoleId&quot;<b>)</b><b>;</b>

</pre></code>
</span></P>

<HR>
<A NAME="IND_PK_ColorsId"><P CLASS="Header0">Index: PK_ColorsId</P><P CLASS="Base">&nbsp;</P>
<P CLASS="Header1">Definition</P>
<P CLASS="Base"><span class="DDLCode">
<code><pre>
<b>CREATE</b><b> </b><b>UNIQUE</b><b> </b><b>INDEX</b><b> </b>&quot;PK_ColorsId&quot;<b> </b><b>ON</b><b> </b><font color="# 080 0"><u>&quot;Colors&quot;</u></font><b> </b><b>(</b>&quot;Id&quot;<b>)</b><b>;</b>

</pre></code>
</span></P>

<HR>
<A NAME="IND_PK_DetailsId"><P CLASS="Header0">Index: PK_DetailsId</P><P CLASS="Base">&nbsp;</P>
<P CLASS="Header1">Definition</P>
<P CLASS="Base"><span class="DDLCode">
<code><pre>
<b>CREATE</b><b> </b><b>UNIQUE</b><b> </b><b>INDEX</b><b> </b>&quot;PK_DetailsId&quot;<b> </b><b>ON</b><b> </b><font color="# 080 0"><u>&quot;Details&quot;</u></font><b> </b><b>(</b>&quot;Id&quot;<b>)</b><b>;</b>

</pre></code>
</span></P>

<HR>
<A NAME="IND_PK_DrawingId"><P CLASS="Header0">Index: PK_DrawingId</P><P CLASS="Base">&nbsp;</P>
<P CLASS="Header1">Definition</P>
<P CLASS="Base"><span class="DDLCode">
<code><pre>
<b>CREATE</b><b> </b><b>UNIQUE</b><b> </b><b>INDEX</b><b> </b>&quot;PK_DrawingId&quot;<b> </b><b>ON</b><b> </b><font color="# 080 0"><u>&quot;Drawing&quot;</u></font><b> </b><b>(</b>&quot;Id&quot;<b>)</b><b>;</b>

</pre></code>
</span></P>

<HR>
<A NAME="IND_PK_DrawingScanId"><P CLASS="Header0">Index: PK_DrawingScanId</P><P CLASS="Base">&nbsp;</P>
<P CLASS="Header1">Definition</P>
<P CLASS="Base"><span class="DDLCode">
<code><pre>
<b>CREATE</b><b> </b><b>UNIQUE</b><b> </b><b>INDEX</b><b> </b>&quot;PK_DrawingScanId&quot;<b> </b><b>ON</b><b> </b><font color="# 080 0"><u>&quot;DrawingScan&quot;</u></font><b> </b><b>(</b>&quot;Id&quot;<b>)</b><b>;</b>

</pre></code>
</span></P>

<HR>
<A NAME="IND_PK_DrawingsId"><P CLASS="Header0">Index: PK_DrawingsId</P><P CLASS="Base">&nbsp;</P>
<P CLASS="Header1">Definition</P>
<P CLASS="Base"><span class="DDLCode">
<code><pre>
<b>CREATE</b><b> </b><b>UNIQUE</b><b> </b><b>INDEX</b><b> </b>&quot;PK_DrawingsId&quot;<b> </b><b>ON</b><b> </b><font color="# 080 0"><u>&quot;Drawings&quot;</u></font><b> </b><b>(</b>&quot;Id&quot;<b>)</b><b>;</b>

</pre></code>
</span></P>

<HR>
<A NAME="IND_PK_MaterialsId"><P CLASS="Header0">Index: PK_MaterialsId</P><P CLASS="Base">&nbsp;</P>
<P CLASS="Header1">Definition</P>
<P CLASS="Base"><span class="DDLCode">
<code><pre>
<b>CREATE</b><b> </b><b>UNIQUE</b><b> </b><b>INDEX</b><b> </b>&quot;PK_MaterialsId&quot;<b> </b><b>ON</b><b> </b><font color="# 080 0"><u>&quot;Materials&quot;</u></font><b> </b><b>(</b>&quot;Id&quot;<b>)</b><b>;</b>

</pre></code>
</span></P>

<HR>
<A NAME="IND_PK_OperationNameId"><P CLASS="Header0">Index: PK_OperationNameId</P><P CLASS="Base">&nbsp;</P>
<P CLASS="Header1">Definition</P>
<P CLASS="Base"><span class="DDLCode">
<code><pre>
<b>CREATE</b><b> </b><b>UNIQUE</b><b> </b><b>INDEX</b><b> </b>&quot;PK_OperationNameId&quot;<b> </b><b>ON</b><b> </b><font color="# 080 0"><u>&quot;OperationName&quot;</u></font><b> </b><b>(</b>&quot;Id&quot;<b>)</b><b>;</b>

</pre></code>
</span></P>

<HR>
<A NAME="IND_PK_OperationNumberId"><P CLASS="Header0">Index: PK_OperationNumberId</P><P CLASS="Base">&nbsp;</P>
<P CLASS="Header1">Definition</P>
<P CLASS="Base"><span class="DDLCode">
<code><pre>
<b>CREATE</b><b> </b><b>UNIQUE</b><b> </b><b>INDEX</b><b> </b>&quot;PK_OperationNumberId&quot;<b> </b><b>ON</b><b> </b><font color="# 080 0"><u>&quot;OperationNumber&quot;</u></font><b> </b><b>(</b>&quot;Id&quot;<b>)</b><b>;</b>

</pre></code>
</span></P>

<HR>
<A NAME="IND_PK_OperationPaintMaterialId"><P CLASS="Header0">Index: PK_OperationPaintMaterialId</P><P CLASS="Base">&nbsp;</P>
<P CLASS="Header1">Definition</P>
<P CLASS="Base"><span class="DDLCode">
<code><pre>
<b>CREATE</b><b> </b><b>UNIQUE</b><b> </b><b>INDEX</b><b> </b>&quot;PK_OperationPaintMaterialId&quot;<b> </b><b>ON</b><b> </b><font color="# 080 0"><u>&quot;OperationPaintMaterial&quot;</u></font><b> </b><b>(</b>&quot;Id&quot;<b>)</b><b>;</b>

</pre></code>
</span></P>

<HR>
<A NAME="IND_PK_RevisionTypeId"><P CLASS="Header0">Index: PK_RevisionTypeId</P><P CLASS="Base">&nbsp;</P>
<P CLASS="Header1">Definition</P>
<P CLASS="Base"><span class="DDLCode">
<code><pre>
<b>CREATE</b><b> </b><b>UNIQUE</b><b> </b><b>INDEX</b><b> </b>&quot;PK_RevisionTypeId&quot;<b> </b><b>ON</b><b> </b><font color="# 080 0"><u>&quot;RevisionType&quot;</u></font><b> </b><b>(</b>&quot;Id&quot;<b>)</b><b>;</b>

</pre></code>
</span></P>

<HR>
<A NAME="IND_PK_RevisionsId"><P CLASS="Header0">Index: PK_RevisionsId</P><P CLASS="Base">&nbsp;</P>
<P CLASS="Header1">Definition</P>
<P CLASS="Base"><span class="DDLCode">
<code><pre>
<b>CREATE</b><b> </b><b>UNIQUE</b><b> </b><b>INDEX</b><b> </b>&quot;PK_RevisionsId&quot;<b> </b><b>ON</b><b> </b><font color="# 080 0"><u>&quot;Revisions&quot;</u></font><b> </b><b>(</b>&quot;Id&quot;<b>)</b><b>;</b>

</pre></code>
</span></P>

<HR>
<A NAME="IND_PK_TechProcess001Id"><P CLASS="Header0">Index: PK_TechProcess001Id</P><P CLASS="Base">&nbsp;</P>
<P CLASS="Header1">Definition</P>
<P CLASS="Base"><span class="DDLCode">
<code><pre>
<b>CREATE</b><b> </b><b>UNIQUE</b><b> </b><b>INDEX</b><b> </b>&quot;PK_TechProcess001Id&quot;<b> </b><b>ON</b><b> </b><font color="# 080 0"><u>&quot;TechProcess001&quot;</u></font><b> </b><b>(</b>&quot;Id&quot;<b>)</b><b>;</b>

</pre></code>
</span></P>

<HR>
<A NAME="IND_PK_TechProcess002Id"><P CLASS="Header0">Index: PK_TechProcess002Id</P><P CLASS="Base">&nbsp;</P>
<P CLASS="Header1">Definition</P>
<P CLASS="Base"><span class="DDLCode">
<code><pre>
<b>CREATE</b><b> </b><b>UNIQUE</b><b> </b><b>INDEX</b><b> </b>&quot;PK_TechProcess002Id&quot;<b> </b><b>ON</b><b> </b><font color="# 080 0"><u>&quot;TechProcess002&quot;</u></font><b> </b><b>(</b>&quot;Id&quot;<b>)</b><b>;</b>

</pre></code>
</span></P>

<HR>
<A NAME="IND_PK_TechProcess003Id"><P CLASS="Header0">Index: PK_TechProcess003Id</P><P CLASS="Base">&nbsp;</P>
<P CLASS="Header1">Definition</P>
<P CLASS="Base"><span class="DDLCode">
<code><pre>
<b>CREATE</b><b> </b><b>UNIQUE</b><b> </b><b>INDEX</b><b> </b>&quot;PK_TechProcess003Id&quot;<b> </b><b>ON</b><b> </b><font color="# 080 0"><u>&quot;TechProcess003&quot;</u></font><b> </b><b>(</b>&quot;Id&quot;<b>)</b><b>;</b>

</pre></code>
</span></P>

<HR>
<A NAME="IND_PK_TechProcess004Id"><P CLASS="Header0">Index: PK_TechProcess004Id</P><P CLASS="Base">&nbsp;</P>
<P CLASS="Header1">Definition</P>
<P CLASS="Base"><span class="DDLCode">
<code><pre>
<b>CREATE</b><b> </b><b>UNIQUE</b><b> </b><b>INDEX</b><b> </b>&quot;PK_TechProcess004Id&quot;<b> </b><b>ON</b><b> </b><font color="# 080 0"><u>&quot;TechProcess004&quot;</u></font><b> </b><b>(</b>&quot;Id&quot;<b>)</b><b>;</b>

</pre></code>
</span></P>

<HR>
<A NAME="IND_PK_TechProcess005Id"><P CLASS="Header0">Index: PK_TechProcess005Id</P><P CLASS="Base">&nbsp;</P>
<P CLASS="Header1">Definition</P>
<P CLASS="Base"><span class="DDLCode">
<code><pre>
<b>CREATE</b><b> </b><b>UNIQUE</b><b> </b><b>INDEX</b><b> </b>&quot;PK_TechProcess005Id&quot;<b> </b><b>ON</b><b> </b><font color="# 080 0"><u>&quot;TechProcess005&quot;</u></font><b> </b><b>(</b>&quot;Id&quot;<b>)</b><b>;</b>

</pre></code>
</span></P>

<HR>
<A NAME="IND_PK_TypeId"><P CLASS="Header0">Index: PK_TypeId</P><P CLASS="Base">&nbsp;</P>
<P CLASS="Header1">Definition</P>
<P CLASS="Base"><span class="DDLCode">
<code><pre>
<b>CREATE</b><b> </b><b>UNIQUE</b><b> </b><b>INDEX</b><b> </b>&quot;PK_TypeId&quot;<b> </b><b>ON</b><b> </b><font color="# 080 0"><u>&quot;Type&quot;</u></font><b> </b><b>(</b>&quot;Id&quot;<b>)</b><b>;</b>

</pre></code>
</span></P>

<HR>
<A NAME="IND_PK_UserId"><P CLASS="Header0">Index: PK_UserId</P><P CLASS="Base">&nbsp;</P>
<P CLASS="Header1">Definition</P>
<P CLASS="Base"><span class="DDLCode">
<code><pre>
<b>CREATE</b><b> </b><b>UNIQUE</b><b> </b><b>INDEX</b><b> </b>&quot;PK_UserId&quot;<b> </b><b>ON</b><b> </b><font color="# 080 0"><u>&quot;Users&quot;</u></font><b> </b><b>(</b>&quot;Id&quot;<b>)</b><b>;</b>

</pre></code>
</span></P>

<HR>
<A NAME="IND_PK_UserRoleId"><P CLASS="Header0">Index: PK_UserRoleId</P><P CLASS="Base">&nbsp;</P>
<P CLASS="Header1">Definition</P>
<P CLASS="Base"><span class="DDLCode">
<code><pre>
<b>CREATE</b><b> </b><b>UNIQUE</b><b> </b><b>INDEX</b><b> </b>&quot;PK_UserRoleId&quot;<b> </b><b>ON</b><b> </b><font color="# 080 0"><u>&quot;UserRole&quot;</u></font><b> </b><b>(</b>&quot;Id&quot;<b>)</b><b>;</b>

</pre></code>
</span></P>

<HR>
<A NAME="_FOREIGN_KEYS"><P CLASS="Header0">Foreign Keys</P></A>
<P CLASS="Base">&nbsp;</P>
<TABLE CLASS="dtArg" CELLSPACING="0">
  <TH WIDTH="1%"><P CLASS="Base2"><B>Foreign Key</B></P>
  <TH WIDTH="1%"><P CLASS="Base2"><B>Table</B></P>
  <TH WIDTH="1%"><P CLASS="Base2"><B>Fields</B></P>
  <TH WIDTH="1%"><P CLASS="Base2"><B>FK Table</B></P>
  <TH WIDTH="1%"><P CLASS="Base2"><B>FK Field</B></P>
  <TH WIDTH="1%"><P CLASS="Base2"><B>Delete Rule</B></P>
  <TH WIDTH="1%"><P CLASS="Base2"><B>Update Rule</B></P>
  <TR>
    <TD><P CLASS="Base2"><A HREF="#FKEY_FK_ColorId_CurrentLevelMenuId">FK_ColorId_CurrentLevelMenuId</A></TD>
    <TD><P CLASS="Base2"><A HREF="#TBL_Drawings">Drawings</A></TD>
    <TD><P CLASS="Base2">CurrentLevelMenuColorId</TD>
    <TD><P CLASS="Base2"><A HREF="#TBL_Colors">Colors</A></TD>
    <TD><P CLASS="Base2">Id</TD>
    <TD><P CLASS="Base2">SET NULL</TD>
    <TD><P CLASS="Base2">NO ACTION</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2"><A HREF="#FKEY_FK_ColorId_DrawingId">FK_ColorId_DrawingId</A></TD>
    <TD><P CLASS="Base2"><A HREF="#TBL_Drawings">Drawings</A></TD>
    <TD><P CLASS="Base2">DrawingColorId</TD>
    <TD><P CLASS="Base2"><A HREF="#TBL_Colors">Colors</A></TD>
    <TD><P CLASS="Base2">Id</TD>
    <TD><P CLASS="Base2">SET NULL</TD>
    <TD><P CLASS="Base2">NO ACTION</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2"><A HREF="#FKEY_FK_ColorId_MaterialId">FK_ColorId_MaterialId</A></TD>
    <TD><P CLASS="Base2"><A HREF="#TBL_Drawings">Drawings</A></TD>
    <TD><P CLASS="Base2">MaterialColorId</TD>
    <TD><P CLASS="Base2"><A HREF="#TBL_Colors">Colors</A></TD>
    <TD><P CLASS="Base2">Id</TD>
    <TD><P CLASS="Base2">SET NULL</TD>
    <TD><P CLASS="Base2">NO ACTION</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2"><A HREF="#FKEY_FK_Drawing_DetId">FK_Drawing_DetId</A></TD>
    <TD><P CLASS="Base2"><A HREF="#TBL_Drawing">Drawing</A></TD>
    <TD><P CLASS="Base2">DetailId</TD>
    <TD><P CLASS="Base2"><A HREF="#TBL_Details">Details</A></TD>
    <TD><P CLASS="Base2">Id</TD>
    <TD><P CLASS="Base2">SET NULL</TD>
    <TD><P CLASS="Base2">NO ACTION</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2"><A HREF="#FKEY_FK_Drawing_MatId">FK_Drawing_MatId</A></TD>
    <TD><P CLASS="Base2"><A HREF="#TBL_Drawing">Drawing</A></TD>
    <TD><P CLASS="Base2">MaterialId</TD>
    <TD><P CLASS="Base2"><A HREF="#TBL_Materials">Materials</A></TD>
    <TD><P CLASS="Base2">Id</TD>
    <TD><P CLASS="Base2">SET NULL</TD>
    <TD><P CLASS="Base2">NO ACTION</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2"><A HREF="#FKEY_FK_Drawing_ParentId">FK_Drawing_ParentId</A></TD>
    <TD><P CLASS="Base2"><A HREF="#TBL_Drawing">Drawing</A></TD>
    <TD><P CLASS="Base2">ParentId</TD>
    <TD><P CLASS="Base2"><A HREF="#TBL_Drawing">Drawing</A></TD>
    <TD><P CLASS="Base2">Id</TD>
    <TD><P CLASS="Base2">SET NULL</TD>
    <TD><P CLASS="Base2">NO ACTION</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2"><A HREF="#FKEY_FK_Drawing_RevId">FK_Drawing_RevId</A></TD>
    <TD><P CLASS="Base2"><A HREF="#TBL_Drawing">Drawing</A></TD>
    <TD><P CLASS="Base2">RevisionId</TD>
    <TD><P CLASS="Base2"><A HREF="#TBL_Revisions">Revisions</A></TD>
    <TD><P CLASS="Base2">Id</TD>
    <TD><P CLASS="Base2">NO ACTION</TD>
    <TD><P CLASS="Base2">NO ACTION</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2"><A HREF="#FKEY_FK_Drawing_TypeId">FK_Drawing_TypeId</A></TD>
    <TD><P CLASS="Base2"><A HREF="#TBL_Drawing">Drawing</A></TD>
    <TD><P CLASS="Base2">TypeId</TD>
    <TD><P CLASS="Base2"><A HREF="#TBL_Type">Type</A></TD>
    <TD><P CLASS="Base2">Id</TD>
    <TD><P CLASS="Base2">SET NULL</TD>
    <TD><P CLASS="Base2">NO ACTION</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2"><A HREF="#FKEY_FK_Drawing_UserId">FK_Drawing_UserId</A></TD>
    <TD><P CLASS="Base2"><A HREF="#TBL_Drawing">Drawing</A></TD>
    <TD><P CLASS="Base2">UserId</TD>
    <TD><P CLASS="Base2"><A HREF="#TBL_Users">Users</A></TD>
    <TD><P CLASS="Base2">Id</TD>
    <TD><P CLASS="Base2">NO ACTION</TD>
    <TD><P CLASS="Base2">NO ACTION</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2"><A HREF="#FKEY_FK_Drawings_DrawingId">FK_Drawings_DrawingId</A></TD>
    <TD><P CLASS="Base2"><A HREF="#TBL_Drawings">Drawings</A></TD>
    <TD><P CLASS="Base2">DrawingId</TD>
    <TD><P CLASS="Base2"><A HREF="#TBL_Drawing">Drawing</A></TD>
    <TD><P CLASS="Base2">Id</TD>
    <TD><P CLASS="Base2">SET NULL</TD>
    <TD><P CLASS="Base2">NO ACTION</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2"><A HREF="#FKEY_FK_Drawings_Id">FK_Drawings_Id</A></TD>
    <TD><P CLASS="Base2"><A HREF="#TBL_Drawings">Drawings</A></TD>
    <TD><P CLASS="Base2">ParentId</TD>
    <TD><P CLASS="Base2"><A HREF="#TBL_Drawings">Drawings</A></TD>
    <TD><P CLASS="Base2">Id</TD>
    <TD><P CLASS="Base2">CASCADE</TD>
    <TD><P CLASS="Base2">NO ACTION</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2"><A HREF="#FKEY_FK_Drawings_OccurrenceId">FK_Drawings_OccurrenceId</A></TD>
    <TD><P CLASS="Base2"><A HREF="#TBL_Drawings">Drawings</A></TD>
    <TD><P CLASS="Base2">OccurrenceId</TD>
    <TD><P CLASS="Base2"><A HREF="#TBL_Drawing">Drawing</A></TD>
    <TD><P CLASS="Base2">Id</TD>
    <TD><P CLASS="Base2">SET NULL</TD>
    <TD><P CLASS="Base2">NO ACTION</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2"><A HREF="#FKEY_FK_Drawings_ReplaceDrawingId">FK_Drawings_ReplaceDrawingId</A></TD>
    <TD><P CLASS="Base2"><A HREF="#TBL_Drawings">Drawings</A></TD>
    <TD><P CLASS="Base2">ReplaceDrawingId</TD>
    <TD><P CLASS="Base2"><A HREF="#TBL_Drawing">Drawing</A></TD>
    <TD><P CLASS="Base2">Id</TD>
    <TD><P CLASS="Base2">SET NULL</TD>
    <TD><P CLASS="Base2">NO ACTION</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2"><A HREF="#FKEY_FK_DrawingScan_Drawing">FK_DrawingScan_Drawing</A></TD>
    <TD><P CLASS="Base2"><A HREF="#TBL_DrawingScan">DrawingScan</A></TD>
    <TD><P CLASS="Base2">DrawingId</TD>
    <TD><P CLASS="Base2"><A HREF="#TBL_Drawing">Drawing</A></TD>
    <TD><P CLASS="Base2">Id</TD>
    <TD><P CLASS="Base2">CASCADE</TD>
    <TD><P CLASS="Base2">NO ACTION</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2"><A HREF="#FKEY_FK_TechProcess001_CopyDrawingId">FK_TechProcess001_CopyDrawingId</A></TD>
    <TD><P CLASS="Base2"><A HREF="#TBL_TechProcess001">TechProcess001</A></TD>
    <TD><P CLASS="Base2">CopyDrawingId</TD>
    <TD><P CLASS="Base2"><A HREF="#TBL_Drawing">Drawing</A></TD>
    <TD><P CLASS="Base2">Id</TD>
    <TD><P CLASS="Base2">SET NULL</TD>
    <TD><P CLASS="Base2">NO ACTION</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2"><A HREF="#FKEY_FK_TechProcess001_DrawingId">FK_TechProcess001_DrawingId</A></TD>
    <TD><P CLASS="Base2"><A HREF="#TBL_TechProcess001">TechProcess001</A></TD>
    <TD><P CLASS="Base2">DrawingId</TD>
    <TD><P CLASS="Base2"><A HREF="#TBL_Drawing">Drawing</A></TD>
    <TD><P CLASS="Base2">Id</TD>
    <TD><P CLASS="Base2">SET NULL</TD>
    <TD><P CLASS="Base2">NO ACTION</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2"><A HREF="#FKEY_FK_TechProcess001_ParentId">FK_TechProcess001_ParentId</A></TD>
    <TD><P CLASS="Base2"><A HREF="#TBL_TechProcess001">TechProcess001</A></TD>
    <TD><P CLASS="Base2">ParentId</TD>
    <TD><P CLASS="Base2"><A HREF="#TBL_TechProcess001">TechProcess001</A></TD>
    <TD><P CLASS="Base2">Id</TD>
    <TD><P CLASS="Base2">SET NULL</TD>
    <TD><P CLASS="Base2">NO ACTION</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2"><A HREF="#FKEY_FK_TechProcess001_RevisionId">FK_TechProcess001_RevisionId</A></TD>
    <TD><P CLASS="Base2"><A HREF="#TBL_TechProcess001">TechProcess001</A></TD>
    <TD><P CLASS="Base2">RevisionId</TD>
    <TD><P CLASS="Base2"><A HREF="#TBL_Revisions">Revisions</A></TD>
    <TD><P CLASS="Base2">Id</TD>
    <TD><P CLASS="Base2">NO ACTION</TD>
    <TD><P CLASS="Base2">NO ACTION</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2"><A HREF="#FKEY_FK_TechProcess001_TypeId">FK_TechProcess001_TypeId</A></TD>
    <TD><P CLASS="Base2"><A HREF="#TBL_TechProcess001">TechProcess001</A></TD>
    <TD><P CLASS="Base2">TypeId</TD>
    <TD><P CLASS="Base2"><A HREF="#TBL_RevisionType">RevisionType</A></TD>
    <TD><P CLASS="Base2">Id</TD>
    <TD><P CLASS="Base2">NO ACTION</TD>
    <TD><P CLASS="Base2">NO ACTION</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2"><A HREF="#FKEY_FK_TechProcess001_UserId">FK_TechProcess001_UserId</A></TD>
    <TD><P CLASS="Base2"><A HREF="#TBL_TechProcess001">TechProcess001</A></TD>
    <TD><P CLASS="Base2">UserId</TD>
    <TD><P CLASS="Base2"><A HREF="#TBL_Users">Users</A></TD>
    <TD><P CLASS="Base2">Id</TD>
    <TD><P CLASS="Base2">NO ACTION</TD>
    <TD><P CLASS="Base2">NO ACTION</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2"><A HREF="#FKEY_FK_TechProcess002_CopyDrawingId">FK_TechProcess002_CopyDrawingId</A></TD>
    <TD><P CLASS="Base2"><A HREF="#TBL_TechProcess002">TechProcess002</A></TD>
    <TD><P CLASS="Base2">CopyDrawingId</TD>
    <TD><P CLASS="Base2"><A HREF="#TBL_Drawing">Drawing</A></TD>
    <TD><P CLASS="Base2">Id</TD>
    <TD><P CLASS="Base2">SET NULL</TD>
    <TD><P CLASS="Base2">NO ACTION</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2"><A HREF="#FKEY_FK_TechProcess002_DrawingId">FK_TechProcess002_DrawingId</A></TD>
    <TD><P CLASS="Base2"><A HREF="#TBL_TechProcess002">TechProcess002</A></TD>
    <TD><P CLASS="Base2">DrawingId</TD>
    <TD><P CLASS="Base2"><A HREF="#TBL_Drawing">Drawing</A></TD>
    <TD><P CLASS="Base2">Id</TD>
    <TD><P CLASS="Base2">SET NULL</TD>
    <TD><P CLASS="Base2">NO ACTION</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2"><A HREF="#FKEY_FK_TechProcess002_ParentId">FK_TechProcess002_ParentId</A></TD>
    <TD><P CLASS="Base2"><A HREF="#TBL_TechProcess002">TechProcess002</A></TD>
    <TD><P CLASS="Base2">ParentId</TD>
    <TD><P CLASS="Base2"><A HREF="#TBL_TechProcess002">TechProcess002</A></TD>
    <TD><P CLASS="Base2">Id</TD>
    <TD><P CLASS="Base2">SET NULL</TD>
    <TD><P CLASS="Base2">NO ACTION</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2"><A HREF="#FKEY_FK_TechProcess002_RevisionId">FK_TechProcess002_RevisionId</A></TD>
    <TD><P CLASS="Base2"><A HREF="#TBL_TechProcess002">TechProcess002</A></TD>
    <TD><P CLASS="Base2">RevisionId</TD>
    <TD><P CLASS="Base2"><A HREF="#TBL_Revisions">Revisions</A></TD>
    <TD><P CLASS="Base2">Id</TD>
    <TD><P CLASS="Base2">NO ACTION</TD>
    <TD><P CLASS="Base2">NO ACTION</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2"><A HREF="#FKEY_FK_TechProcess002_TypeId">FK_TechProcess002_TypeId</A></TD>
    <TD><P CLASS="Base2"><A HREF="#TBL_TechProcess002">TechProcess002</A></TD>
    <TD><P CLASS="Base2">TypeId</TD>
    <TD><P CLASS="Base2"><A HREF="#TBL_RevisionType">RevisionType</A></TD>
    <TD><P CLASS="Base2">Id</TD>
    <TD><P CLASS="Base2">NO ACTION</TD>
    <TD><P CLASS="Base2">NO ACTION</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2"><A HREF="#FKEY_FK_TechProcess002_UserId">FK_TechProcess002_UserId</A></TD>
    <TD><P CLASS="Base2"><A HREF="#TBL_TechProcess002">TechProcess002</A></TD>
    <TD><P CLASS="Base2">UserId</TD>
    <TD><P CLASS="Base2"><A HREF="#TBL_Users">Users</A></TD>
    <TD><P CLASS="Base2">Id</TD>
    <TD><P CLASS="Base2">NO ACTION</TD>
    <TD><P CLASS="Base2">NO ACTION</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2"><A HREF="#FKEY_FK_TechProcess003_CopyDrawingId">FK_TechProcess003_CopyDrawingId</A></TD>
    <TD><P CLASS="Base2"><A HREF="#TBL_TechProcess003">TechProcess003</A></TD>
    <TD><P CLASS="Base2">CopyDrawingId</TD>
    <TD><P CLASS="Base2"><A HREF="#TBL_Drawing">Drawing</A></TD>
    <TD><P CLASS="Base2">Id</TD>
    <TD><P CLASS="Base2">SET NULL</TD>
    <TD><P CLASS="Base2">NO ACTION</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2"><A HREF="#FKEY_FK_TechProcess003_DrawingId">FK_TechProcess003_DrawingId</A></TD>
    <TD><P CLASS="Base2"><A HREF="#TBL_TechProcess003">TechProcess003</A></TD>
    <TD><P CLASS="Base2">DrawingId</TD>
    <TD><P CLASS="Base2"><A HREF="#TBL_Drawing">Drawing</A></TD>
    <TD><P CLASS="Base2">Id</TD>
    <TD><P CLASS="Base2">SET NULL</TD>
    <TD><P CLASS="Base2">NO ACTION</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2"><A HREF="#FKEY_FK_TechProcess003_ParentId">FK_TechProcess003_ParentId</A></TD>
    <TD><P CLASS="Base2"><A HREF="#TBL_TechProcess003">TechProcess003</A></TD>
    <TD><P CLASS="Base2">ParentId</TD>
    <TD><P CLASS="Base2"><A HREF="#TBL_TechProcess003">TechProcess003</A></TD>
    <TD><P CLASS="Base2">Id</TD>
    <TD><P CLASS="Base2">SET NULL</TD>
    <TD><P CLASS="Base2">NO ACTION</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2"><A HREF="#FKEY_FK_TechProcess003_RevisionId">FK_TechProcess003_RevisionId</A></TD>
    <TD><P CLASS="Base2"><A HREF="#TBL_TechProcess003">TechProcess003</A></TD>
    <TD><P CLASS="Base2">RevisionId</TD>
    <TD><P CLASS="Base2"><A HREF="#TBL_Revisions">Revisions</A></TD>
    <TD><P CLASS="Base2">Id</TD>
    <TD><P CLASS="Base2">NO ACTION</TD>
    <TD><P CLASS="Base2">NO ACTION</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2"><A HREF="#FKEY_FK_TechProcess003_TypeId">FK_TechProcess003_TypeId</A></TD>
    <TD><P CLASS="Base2"><A HREF="#TBL_TechProcess003">TechProcess003</A></TD>
    <TD><P CLASS="Base2">TypeId</TD>
    <TD><P CLASS="Base2"><A HREF="#TBL_RevisionType">RevisionType</A></TD>
    <TD><P CLASS="Base2">Id</TD>
    <TD><P CLASS="Base2">NO ACTION</TD>
    <TD><P CLASS="Base2">NO ACTION</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2"><A HREF="#FKEY_FK_TechProcess003_UserId">FK_TechProcess003_UserId</A></TD>
    <TD><P CLASS="Base2"><A HREF="#TBL_TechProcess003">TechProcess003</A></TD>
    <TD><P CLASS="Base2">UserId</TD>
    <TD><P CLASS="Base2"><A HREF="#TBL_Users">Users</A></TD>
    <TD><P CLASS="Base2">Id</TD>
    <TD><P CLASS="Base2">NO ACTION</TD>
    <TD><P CLASS="Base2">NO ACTION</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2"><A HREF="#FKEY_FK_TechProcess004_CopyDrawingId">FK_TechProcess004_CopyDrawingId</A></TD>
    <TD><P CLASS="Base2"><A HREF="#TBL_TechProcess004">TechProcess004</A></TD>
    <TD><P CLASS="Base2">CopyDrawingId</TD>
    <TD><P CLASS="Base2"><A HREF="#TBL_Drawing">Drawing</A></TD>
    <TD><P CLASS="Base2">Id</TD>
    <TD><P CLASS="Base2">SET NULL</TD>
    <TD><P CLASS="Base2">NO ACTION</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2"><A HREF="#FKEY_FK_TechProcess004_DrawingId">FK_TechProcess004_DrawingId</A></TD>
    <TD><P CLASS="Base2"><A HREF="#TBL_TechProcess004">TechProcess004</A></TD>
    <TD><P CLASS="Base2">DrawingId</TD>
    <TD><P CLASS="Base2"><A HREF="#TBL_Drawing">Drawing</A></TD>
    <TD><P CLASS="Base2">Id</TD>
    <TD><P CLASS="Base2">SET NULL</TD>
    <TD><P CLASS="Base2">NO ACTION</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2"><A HREF="#FKEY_FK_TechProcess004_ParentId">FK_TechProcess004_ParentId</A></TD>
    <TD><P CLASS="Base2"><A HREF="#TBL_TechProcess004">TechProcess004</A></TD>
    <TD><P CLASS="Base2">ParentId</TD>
    <TD><P CLASS="Base2"><A HREF="#TBL_TechProcess004">TechProcess004</A></TD>
    <TD><P CLASS="Base2">Id</TD>
    <TD><P CLASS="Base2">SET NULL</TD>
    <TD><P CLASS="Base2">NO ACTION</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2"><A HREF="#FKEY_FK_TechProcess004_RevisionId">FK_TechProcess004_RevisionId</A></TD>
    <TD><P CLASS="Base2"><A HREF="#TBL_TechProcess004">TechProcess004</A></TD>
    <TD><P CLASS="Base2">RevisionId</TD>
    <TD><P CLASS="Base2"><A HREF="#TBL_Revisions">Revisions</A></TD>
    <TD><P CLASS="Base2">Id</TD>
    <TD><P CLASS="Base2">NO ACTION</TD>
    <TD><P CLASS="Base2">NO ACTION</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2"><A HREF="#FKEY_FK_TechProcess004_TypeId">FK_TechProcess004_TypeId</A></TD>
    <TD><P CLASS="Base2"><A HREF="#TBL_TechProcess004">TechProcess004</A></TD>
    <TD><P CLASS="Base2">TypeId</TD>
    <TD><P CLASS="Base2"><A HREF="#TBL_RevisionType">RevisionType</A></TD>
    <TD><P CLASS="Base2">Id</TD>
    <TD><P CLASS="Base2">NO ACTION</TD>
    <TD><P CLASS="Base2">NO ACTION</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2"><A HREF="#FKEY_FK_TechProcess004_UserId">FK_TechProcess004_UserId</A></TD>
    <TD><P CLASS="Base2"><A HREF="#TBL_TechProcess004">TechProcess004</A></TD>
    <TD><P CLASS="Base2">UserId</TD>
    <TD><P CLASS="Base2"><A HREF="#TBL_Users">Users</A></TD>
    <TD><P CLASS="Base2">Id</TD>
    <TD><P CLASS="Base2">NO ACTION</TD>
    <TD><P CLASS="Base2">NO ACTION</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2"><A HREF="#FKEY_FK_TechProcess005_CopyDrawingId">FK_TechProcess005_CopyDrawingId</A></TD>
    <TD><P CLASS="Base2"><A HREF="#TBL_TechProcess005">TechProcess005</A></TD>
    <TD><P CLASS="Base2">CopyDrawingId</TD>
    <TD><P CLASS="Base2"><A HREF="#TBL_Drawing">Drawing</A></TD>
    <TD><P CLASS="Base2">Id</TD>
    <TD><P CLASS="Base2">SET NULL</TD>
    <TD><P CLASS="Base2">NO ACTION</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2"><A HREF="#FKEY_FK_TechProcess005_DrawingId">FK_TechProcess005_DrawingId</A></TD>
    <TD><P CLASS="Base2"><A HREF="#TBL_TechProcess005">TechProcess005</A></TD>
    <TD><P CLASS="Base2">DrawingId</TD>
    <TD><P CLASS="Base2"><A HREF="#TBL_Drawing">Drawing</A></TD>
    <TD><P CLASS="Base2">Id</TD>
    <TD><P CLASS="Base2">SET NULL</TD>
    <TD><P CLASS="Base2">NO ACTION</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2"><A HREF="#FKEY_FK_TechProcess005_ParentId">FK_TechProcess005_ParentId</A></TD>
    <TD><P CLASS="Base2"><A HREF="#TBL_TechProcess005">TechProcess005</A></TD>
    <TD><P CLASS="Base2">ParentId</TD>
    <TD><P CLASS="Base2"><A HREF="#TBL_TechProcess005">TechProcess005</A></TD>
    <TD><P CLASS="Base2">Id</TD>
    <TD><P CLASS="Base2">SET NULL</TD>
    <TD><P CLASS="Base2">NO ACTION</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2"><A HREF="#FKEY_FK_TechProcess005_RevisionId">FK_TechProcess005_RevisionId</A></TD>
    <TD><P CLASS="Base2"><A HREF="#TBL_TechProcess005">TechProcess005</A></TD>
    <TD><P CLASS="Base2">RevisionId</TD>
    <TD><P CLASS="Base2"><A HREF="#TBL_Revisions">Revisions</A></TD>
    <TD><P CLASS="Base2">Id</TD>
    <TD><P CLASS="Base2">NO ACTION</TD>
    <TD><P CLASS="Base2">NO ACTION</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2"><A HREF="#FKEY_FK_TechProcess005_TypeId">FK_TechProcess005_TypeId</A></TD>
    <TD><P CLASS="Base2"><A HREF="#TBL_TechProcess005">TechProcess005</A></TD>
    <TD><P CLASS="Base2">TypeId</TD>
    <TD><P CLASS="Base2"><A HREF="#TBL_RevisionType">RevisionType</A></TD>
    <TD><P CLASS="Base2">Id</TD>
    <TD><P CLASS="Base2">NO ACTION</TD>
    <TD><P CLASS="Base2">NO ACTION</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2"><A HREF="#FKEY_FK_TechProcess005_UserId">FK_TechProcess005_UserId</A></TD>
    <TD><P CLASS="Base2"><A HREF="#TBL_TechProcess005">TechProcess005</A></TD>
    <TD><P CLASS="Base2">UserId</TD>
    <TD><P CLASS="Base2"><A HREF="#TBL_Users">Users</A></TD>
    <TD><P CLASS="Base2">Id</TD>
    <TD><P CLASS="Base2">NO ACTION</TD>
    <TD><P CLASS="Base2">NO ACTION</TD>
  </TR>
  <TR>
    <TD><P CLASS="Base2"><A HREF="#FKEY_FK_Users_RoleId">FK_Users_RoleId</A></TD>
    <TD><P CLASS="Base2"><A HREF="#TBL_Users">Users</A></TD>
    <TD><P CLASS="Base2">RoleId</TD>
    <TD><P CLASS="Base2"><A HREF="#TBL_UserRole">UserRole</A></TD>
    <TD><P CLASS="Base2">Id</TD>
    <TD><P CLASS="Base2">NO ACTION</TD>
    <TD><P CLASS="Base2">NO ACTION</TD>
  </TR>
</TABLE>

<HR>
<A NAME="FKEY_FK_ColorId_CurrentLevelMenuId"><P CLASS="Header0">Foreign Key: FK_ColorId_CurrentLevelMenuId</P><P CLASS="Base">&nbsp;</P>
<P CLASS="Header1">Definition</P>
<P CLASS="Base"><span class="DDLCode">
<code><pre>
<b>ALTER</b><b> </b><b>TABLE</b><b> </b><font color="# 080 0"><u>&quot;Drawings&quot;</u></font><b> </b><b>ADD</b><b> </b><b>CONSTRAINT</b><b> </b>&quot;FK_ColorId_CurrentLevelMenuId&quot;
<b>FOREIGN</b><b> </b><b>KEY</b><b> </b><b>(</b>CurrentLevelMenuColorId<b>)</b>
<b>REFERENCES</b><b> </b><font color="# 080 0"><u>&quot;Colors&quot;</u></font><b> </b><b>(</b>Id<b>)</b>
<b>ON</b><b> </b><b>DELETE</b><b> </b><b>SET</b><b> </b><b>NULL</b>

</pre></code>
</span></P>

<HR>
<A NAME="FKEY_FK_ColorId_DrawingId"><P CLASS="Header0">Foreign Key: FK_ColorId_DrawingId</P><P CLASS="Base">&nbsp;</P>
<P CLASS="Header1">Definition</P>
<P CLASS="Base"><span class="DDLCode">
<code><pre>
<b>ALTER</b><b> </b><b>TABLE</b><b> </b><font color="# 080 0"><u>&quot;Drawings&quot;</u></font><b> </b><b>ADD</b><b> </b><b>CONSTRAINT</b><b> </b>&quot;FK_ColorId_DrawingId&quot;
<b>FOREIGN</b><b> </b><b>KEY</b><b> </b><b>(</b>DrawingColorId<b>)</b>
<b>REFERENCES</b><b> </b><font color="# 080 0"><u>&quot;Colors&quot;</u></font><b> </b><b>(</b>Id<b>)</b>
<b>ON</b><b> </b><b>DELETE</b><b> </b><b>SET</b><b> </b><b>NULL</b>

</pre></code>
</span></P>

<HR>
<A NAME="FKEY_FK_ColorId_MaterialId"><P CLASS="Header0">Foreign Key: FK_ColorId_MaterialId</P><P CLASS="Base">&nbsp;</P>
<P CLASS="Header1">Definition</P>
<P CLASS="Base"><span class="DDLCode">
<code><pre>
<b>ALTER</b><b> </b><b>TABLE</b><b> </b><font color="# 080 0"><u>&quot;Drawings&quot;</u></font><b> </b><b>ADD</b><b> </b><b>CONSTRAINT</b><b> </b>&quot;FK_ColorId_MaterialId&quot;
<b>FOREIGN</b><b> </b><b>KEY</b><b> </b><b>(</b>MaterialColorId<b>)</b>
<b>REFERENCES</b><b> </b><font color="# 080 0"><u>&quot;Colors&quot;</u></font><b> </b><b>(</b>Id<b>)</b>
<b>ON</b><b> </b><b>DELETE</b><b> </b><b>SET</b><b> </b><b>NULL</b>

</pre></code>
</span></P>

<HR>
<A NAME="FKEY_FK_Drawing_DetId"><P CLASS="Header0">Foreign Key: FK_Drawing_DetId</P><P CLASS="Base">&nbsp;</P>
<P CLASS="Header1">Definition</P>
<P CLASS="Base"><span class="DDLCode">
<code><pre>
<b>ALTER</b><b> </b><b>TABLE</b><b> </b><font color="# 080 0"><u>&quot;Drawing&quot;</u></font><b> </b><b>ADD</b><b> </b><b>CONSTRAINT</b><b> </b>&quot;FK_Drawing_DetId&quot;
<b>FOREIGN</b><b> </b><b>KEY</b><b> </b><b>(</b>DetailId<b>)</b>
<b>REFERENCES</b><b> </b><font color="# 080 0"><u>&quot;Details&quot;</u></font><b> </b><b>(</b>Id<b>)</b>
<b>ON</b><b> </b><b>DELETE</b><b> </b><b>SET</b><b> </b><b>NULL</b>

</pre></code>
</span></P>

<HR>
<A NAME="FKEY_FK_Drawing_MatId"><P CLASS="Header0">Foreign Key: FK_Drawing_MatId</P><P CLASS="Base">&nbsp;</P>
<P CLASS="Header1">Definition</P>
<P CLASS="Base"><span class="DDLCode">
<code><pre>
<b>ALTER</b><b> </b><b>TABLE</b><b> </b><font color="# 080 0"><u>&quot;Drawing&quot;</u></font><b> </b><b>ADD</b><b> </b><b>CONSTRAINT</b><b> </b>&quot;FK_Drawing_MatId&quot;
<b>FOREIGN</b><b> </b><b>KEY</b><b> </b><b>(</b>MaterialId<b>)</b>
<b>REFERENCES</b><b> </b><font color="# 080 0"><u>&quot;Materials&quot;</u></font><b> </b><b>(</b>Id<b>)</b>
<b>ON</b><b> </b><b>DELETE</b><b> </b><b>SET</b><b> </b><b>NULL</b>

</pre></code>
</span></P>

<HR>
<A NAME="FKEY_FK_Drawing_ParentId"><P CLASS="Header0">Foreign Key: FK_Drawing_ParentId</P><P CLASS="Base">&nbsp;</P>
<P CLASS="Header1">Definition</P>
<P CLASS="Base"><span class="DDLCode">
<code><pre>
<b>ALTER</b><b> </b><b>TABLE</b><b> </b><font color="# 080 0"><u>&quot;Drawing&quot;</u></font><b> </b><b>ADD</b><b> </b><b>CONSTRAINT</b><b> </b>&quot;FK_Drawing_ParentId&quot;
<b>FOREIGN</b><b> </b><b>KEY</b><b> </b><b>(</b>ParentId<b>)</b>
<b>REFERENCES</b><b> </b><font color="# 080 0"><u>&quot;Drawing&quot;</u></font><b> </b><b>(</b>Id<b>)</b>
<b>ON</b><b> </b><b>DELETE</b><b> </b><b>SET</b><b> </b><b>NULL</b>

</pre></code>
</span></P>

<HR>
<A NAME="FKEY_FK_Drawing_RevId"><P CLASS="Header0">Foreign Key: FK_Drawing_RevId</P><P CLASS="Base">&nbsp;</P>
<P CLASS="Header1">Definition</P>
<P CLASS="Base"><span class="DDLCode">
<code><pre>
<b>ALTER</b><b> </b><b>TABLE</b><b> </b><font color="# 080 0"><u>&quot;Drawing&quot;</u></font><b> </b><b>ADD</b><b> </b><b>CONSTRAINT</b><b> </b>&quot;FK_Drawing_RevId&quot;
<b>FOREIGN</b><b> </b><b>KEY</b><b> </b><b>(</b>RevisionId<b>)</b>
<b>REFERENCES</b><b> </b><font color="# 080 0"><u>&quot;Revisions&quot;</u></font><b> </b><b>(</b>Id<b>)</b>

</pre></code>
</span></P>

<HR>
<A NAME="FKEY_FK_Drawing_TypeId"><P CLASS="Header0">Foreign Key: FK_Drawing_TypeId</P><P CLASS="Base">&nbsp;</P>
<P CLASS="Header1">Definition</P>
<P CLASS="Base"><span class="DDLCode">
<code><pre>
<b>ALTER</b><b> </b><b>TABLE</b><b> </b><font color="# 080 0"><u>&quot;Drawing&quot;</u></font><b> </b><b>ADD</b><b> </b><b>CONSTRAINT</b><b> </b>&quot;FK_Drawing_TypeId&quot;
<b>FOREIGN</b><b> </b><b>KEY</b><b> </b><b>(</b>TypeId<b>)</b>
<b>REFERENCES</b><b> </b><font color="# 080 0"><u>&quot;Type&quot;</u></font><b> </b><b>(</b>Id<b>)</b>
<b>ON</b><b> </b><b>DELETE</b><b> </b><b>SET</b><b> </b><b>NULL</b>

</pre></code>
</span></P>

<HR>
<A NAME="FKEY_FK_Drawing_UserId"><P CLASS="Header0">Foreign Key: FK_Drawing_UserId</P><P CLASS="Base">&nbsp;</P>
<P CLASS="Header1">Definition</P>
<P CLASS="Base"><span class="DDLCode">
<code><pre>
<b>ALTER</b><b> </b><b>TABLE</b><b> </b><font color="# 080 0"><u>&quot;Drawing&quot;</u></font><b> </b><b>ADD</b><b> </b><b>CONSTRAINT</b><b> </b>&quot;FK_Drawing_UserId&quot;
<b>FOREIGN</b><b> </b><b>KEY</b><b> </b><b>(</b>UserId<b>)</b>
<b>REFERENCES</b><b> </b><font color="# 080 0"><u>&quot;Users&quot;</u></font><b> </b><b>(</b>Id<b>)</b>

</pre></code>
</span></P>

<HR>
<A NAME="FKEY_FK_Drawings_DrawingId"><P CLASS="Header0">Foreign Key: FK_Drawings_DrawingId</P><P CLASS="Base">&nbsp;</P>
<P CLASS="Header1">Definition</P>
<P CLASS="Base"><span class="DDLCode">
<code><pre>
<b>ALTER</b><b> </b><b>TABLE</b><b> </b><font color="# 080 0"><u>&quot;Drawings&quot;</u></font><b> </b><b>ADD</b><b> </b><b>CONSTRAINT</b><b> </b>&quot;FK_Drawings_DrawingId&quot;
<b>FOREIGN</b><b> </b><b>KEY</b><b> </b><b>(</b>DrawingId<b>)</b>
<b>REFERENCES</b><b> </b><font color="# 080 0"><u>&quot;Drawing&quot;</u></font><b> </b><b>(</b>Id<b>)</b>
<b>ON</b><b> </b><b>DELETE</b><b> </b><b>SET</b><b> </b><b>NULL</b>

</pre></code>
</span></P>

<HR>
<A NAME="FKEY_FK_Drawings_Id"><P CLASS="Header0">Foreign Key: FK_Drawings_Id</P><P CLASS="Base">&nbsp;</P>
<P CLASS="Header1">Definition</P>
<P CLASS="Base"><span class="DDLCode">
<code><pre>
<b>ALTER</b><b> </b><b>TABLE</b><b> </b><font color="# 080 0"><u>&quot;Drawings&quot;</u></font><b> </b><b>ADD</b><b> </b><b>CONSTRAINT</b><b> </b>&quot;FK_Drawings_Id&quot;
<b>FOREIGN</b><b> </b><b>KEY</b><b> </b><b>(</b>ParentId<b>)</b>
<b>REFERENCES</b><b> </b><font color="# 080 0"><u>&quot;Drawings&quot;</u></font><b> </b><b>(</b>Id<b>)</b>
<b>ON</b><b> </b><b>DELETE</b><b> </b><b>CASCADE</b>

</pre></code>
</span></P>

<HR>
<A NAME="FKEY_FK_Drawings_OccurrenceId"><P CLASS="Header0">Foreign Key: FK_Drawings_OccurrenceId</P><P CLASS="Base">&nbsp;</P>
<P CLASS="Header1">Definition</P>
<P CLASS="Base"><span class="DDLCode">
<code><pre>
<b>ALTER</b><b> </b><b>TABLE</b><b> </b><font color="# 080 0"><u>&quot;Drawings&quot;</u></font><b> </b><b>ADD</b><b> </b><b>CONSTRAINT</b><b> </b>&quot;FK_Drawings_OccurrenceId&quot;
<b>FOREIGN</b><b> </b><b>KEY</b><b> </b><b>(</b>OccurrenceId<b>)</b>
<b>REFERENCES</b><b> </b><font color="# 080 0"><u>&quot;Drawing&quot;</u></font><b> </b><b>(</b>Id<b>)</b>
<b>ON</b><b> </b><b>DELETE</b><b> </b><b>SET</b><b> </b><b>NULL</b>

</pre></code>
</span></P>

<HR>
<A NAME="FKEY_FK_Drawings_ReplaceDrawingId"><P CLASS="Header0">Foreign Key: FK_Drawings_ReplaceDrawingId</P><P CLASS="Base">&nbsp;</P>
<P CLASS="Header1">Definition</P>
<P CLASS="Base"><span class="DDLCode">
<code><pre>
<b>ALTER</b><b> </b><b>TABLE</b><b> </b><font color="# 080 0"><u>&quot;Drawings&quot;</u></font><b> </b><b>ADD</b><b> </b><b>CONSTRAINT</b><b> </b>&quot;FK_Drawings_ReplaceDrawingId&quot;
<b>FOREIGN</b><b> </b><b>KEY</b><b> </b><b>(</b>ReplaceDrawingId<b>)</b>
<b>REFERENCES</b><b> </b><font color="# 080 0"><u>&quot;Drawing&quot;</u></font><b> </b><b>(</b>Id<b>)</b>
<b>ON</b><b> </b><b>DELETE</b><b> </b><b>SET</b><b> </b><b>NULL</b>

</pre></code>
</span></P>

<HR>
<A NAME="FKEY_FK_DrawingScan_Drawing"><P CLASS="Header0">Foreign Key: FK_DrawingScan_Drawing</P><P CLASS="Base">&nbsp;</P>
<P CLASS="Header1">Definition</P>
<P CLASS="Base"><span class="DDLCode">
<code><pre>
<b>ALTER</b><b> </b><b>TABLE</b><b> </b><font color="# 080 0"><u>&quot;DrawingScan&quot;</u></font><b> </b><b>ADD</b><b> </b><b>CONSTRAINT</b><b> </b>&quot;FK_DrawingScan_Drawing&quot;
<b>FOREIGN</b><b> </b><b>KEY</b><b> </b><b>(</b>DrawingId<b>)</b>
<b>REFERENCES</b><b> </b><font color="# 080 0"><u>&quot;Drawing&quot;</u></font><b> </b><b>(</b>Id<b>)</b>
<b>ON</b><b> </b><b>DELETE</b><b> </b><b>CASCADE</b>

</pre></code>
</span></P>

<HR>
<A NAME="FKEY_FK_TechProcess001_CopyDrawingId"><P CLASS="Header0">Foreign Key: FK_TechProcess001_CopyDrawingId</P><P CLASS="Base">&nbsp;</P>
<P CLASS="Header1">Definition</P>
<P CLASS="Base"><span class="DDLCode">
<code><pre>
<b>ALTER</b><b> </b><b>TABLE</b><b> </b><font color="# 080 0"><u>&quot;TechProcess001&quot;</u></font><b> </b><b>ADD</b><b> </b><b>CONSTRAINT</b><b> </b>&quot;FK_TechProcess001_CopyDrawingId&quot;
<b>FOREIGN</b><b> </b><b>KEY</b><b> </b><b>(</b>CopyDrawingId<b>)</b>
<b>REFERENCES</b><b> </b><font color="# 080 0"><u>&quot;Drawing&quot;</u></font><b> </b><b>(</b>Id<b>)</b>
<b>ON</b><b> </b><b>DELETE</b><b> </b><b>SET</b><b> </b><b>NULL</b>

</pre></code>
</span></P>

<HR>
<A NAME="FKEY_FK_TechProcess001_DrawingId"><P CLASS="Header0">Foreign Key: FK_TechProcess001_DrawingId</P><P CLASS="Base">&nbsp;</P>
<P CLASS="Header1">Definition</P>
<P CLASS="Base"><span class="DDLCode">
<code><pre>
<b>ALTER</b><b> </b><b>TABLE</b><b> </b><font color="# 080 0"><u>&quot;TechProcess001&quot;</u></font><b> </b><b>ADD</b><b> </b><b>CONSTRAINT</b><b> </b>&quot;FK_TechProcess001_DrawingId&quot;
<b>FOREIGN</b><b> </b><b>KEY</b><b> </b><b>(</b>DrawingId<b>)</b>
<b>REFERENCES</b><b> </b><font color="# 080 0"><u>&quot;Drawing&quot;</u></font><b> </b><b>(</b>Id<b>)</b>
<b>ON</b><b> </b><b>DELETE</b><b> </b><b>SET</b><b> </b><b>NULL</b>

</pre></code>
</span></P>

<HR>
<A NAME="FKEY_FK_TechProcess001_ParentId"><P CLASS="Header0">Foreign Key: FK_TechProcess001_ParentId</P><P CLASS="Base">&nbsp;</P>
<P CLASS="Header1">Definition</P>
<P CLASS="Base"><span class="DDLCode">
<code><pre>
<b>ALTER</b><b> </b><b>TABLE</b><b> </b><font color="# 080 0"><u>&quot;TechProcess001&quot;</u></font><b> </b><b>ADD</b><b> </b><b>CONSTRAINT</b><b> </b>&quot;FK_TechProcess001_ParentId&quot;
<b>FOREIGN</b><b> </b><b>KEY</b><b> </b><b>(</b>ParentId<b>)</b>
<b>REFERENCES</b><b> </b><font color="# 080 0"><u>&quot;TechProcess001&quot;</u></font><b> </b><b>(</b>Id<b>)</b>
<b>ON</b><b> </b><b>DELETE</b><b> </b><b>SET</b><b> </b><b>NULL</b>

</pre></code>
</span></P>

<HR>
<A NAME="FKEY_FK_TechProcess001_RevisionId"><P CLASS="Header0">Foreign Key: FK_TechProcess001_RevisionId</P><P CLASS="Base">&nbsp;</P>
<P CLASS="Header1">Definition</P>
<P CLASS="Base"><span class="DDLCode">
<code><pre>
<b>ALTER</b><b> </b><b>TABLE</b><b> </b><font color="# 080 0"><u>&quot;TechProcess001&quot;</u></font><b> </b><b>ADD</b><b> </b><b>CONSTRAINT</b><b> </b>&quot;FK_TechProcess001_RevisionId&quot;
<b>FOREIGN</b><b> </b><b>KEY</b><b> </b><b>(</b>RevisionId<b>)</b>
<b>REFERENCES</b><b> </b><font color="# 080 0"><u>&quot;Revisions&quot;</u></font><b> </b><b>(</b>Id<b>)</b>

</pre></code>
</span></P>

<HR>
<A NAME="FKEY_FK_TechProcess001_TypeId"><P CLASS="Header0">Foreign Key: FK_TechProcess001_TypeId</P><P CLASS="Base">&nbsp;</P>
<P CLASS="Header1">Definition</P>
<P CLASS="Base"><span class="DDLCode">
<code><pre>
<b>ALTER</b><b> </b><b>TABLE</b><b> </b><font color="# 080 0"><u>&quot;TechProcess001&quot;</u></font><b> </b><b>ADD</b><b> </b><b>CONSTRAINT</b><b> </b>&quot;FK_TechProcess001_TypeId&quot;
<b>FOREIGN</b><b> </b><b>KEY</b><b> </b><b>(</b>TypeId<b>)</b>
<b>REFERENCES</b><b> </b><font color="# 080 0"><u>&quot;RevisionType&quot;</u></font><b> </b><b>(</b>Id<b>)</b>

</pre></code>
</span></P>

<HR>
<A NAME="FKEY_FK_TechProcess001_UserId"><P CLASS="Header0">Foreign Key: FK_TechProcess001_UserId</P><P CLASS="Base">&nbsp;</P>
<P CLASS="Header1">Definition</P>
<P CLASS="Base"><span class="DDLCode">
<code><pre>
<b>ALTER</b><b> </b><b>TABLE</b><b> </b><font color="# 080 0"><u>&quot;TechProcess001&quot;</u></font><b> </b><b>ADD</b><b> </b><b>CONSTRAINT</b><b> </b>&quot;FK_TechProcess001_UserId&quot;
<b>FOREIGN</b><b> </b><b>KEY</b><b> </b><b>(</b>UserId<b>)</b>
<b>REFERENCES</b><b> </b><font color="# 080 0"><u>&quot;Users&quot;</u></font><b> </b><b>(</b>Id<b>)</b>

</pre></code>
</span></P>

<HR>
<A NAME="FKEY_FK_TechProcess002_CopyDrawingId"><P CLASS="Header0">Foreign Key: FK_TechProcess002_CopyDrawingId</P><P CLASS="Base">&nbsp;</P>
<P CLASS="Header1">Definition</P>
<P CLASS="Base"><span class="DDLCode">
<code><pre>
<b>ALTER</b><b> </b><b>TABLE</b><b> </b><font color="# 080 0"><u>&quot;TechProcess002&quot;</u></font><b> </b><b>ADD</b><b> </b><b>CONSTRAINT</b><b> </b>&quot;FK_TechProcess002_CopyDrawingId&quot;
<b>FOREIGN</b><b> </b><b>KEY</b><b> </b><b>(</b>CopyDrawingId<b>)</b>
<b>REFERENCES</b><b> </b><font color="# 080 0"><u>&quot;Drawing&quot;</u></font><b> </b><b>(</b>Id<b>)</b>
<b>ON</b><b> </b><b>DELETE</b><b> </b><b>SET</b><b> </b><b>NULL</b>

</pre></code>
</span></P>

<HR>
<A NAME="FKEY_FK_TechProcess002_DrawingId"><P CLASS="Header0">Foreign Key: FK_TechProcess002_DrawingId</P><P CLASS="Base">&nbsp;</P>
<P CLASS="Header1">Definition</P>
<P CLASS="Base"><span class="DDLCode">
<code><pre>
<b>ALTER</b><b> </b><b>TABLE</b><b> </b><font color="# 080 0"><u>&quot;TechProcess002&quot;</u></font><b> </b><b>ADD</b><b> </b><b>CONSTRAINT</b><b> </b>&quot;FK_TechProcess002_DrawingId&quot;
<b>FOREIGN</b><b> </b><b>KEY</b><b> </b><b>(</b>DrawingId<b>)</b>
<b>REFERENCES</b><b> </b><font color="# 080 0"><u>&quot;Drawing&quot;</u></font><b> </b><b>(</b>Id<b>)</b>
<b>ON</b><b> </b><b>DELETE</b><b> </b><b>SET</b><b> </b><b>NULL</b>

</pre></code>
</span></P>

<HR>
<A NAME="FKEY_FK_TechProcess002_ParentId"><P CLASS="Header0">Foreign Key: FK_TechProcess002_ParentId</P><P CLASS="Base">&nbsp;</P>
<P CLASS="Header1">Definition</P>
<P CLASS="Base"><span class="DDLCode">
<code><pre>
<b>ALTER</b><b> </b><b>TABLE</b><b> </b><font color="# 080 0"><u>&quot;TechProcess002&quot;</u></font><b> </b><b>ADD</b><b> </b><b>CONSTRAINT</b><b> </b>&quot;FK_TechProcess002_ParentId&quot;
<b>FOREIGN</b><b> </b><b>KEY</b><b> </b><b>(</b>ParentId<b>)</b>
<b>REFERENCES</b><b> </b><font color="# 080 0"><u>&quot;TechProcess002&quot;</u></font><b> </b><b>(</b>Id<b>)</b>
<b>ON</b><b> </b><b>DELETE</b><b> </b><b>SET</b><b> </b><b>NULL</b>

</pre></code>
</span></P>

<HR>
<A NAME="FKEY_FK_TechProcess002_RevisionId"><P CLASS="Header0">Foreign Key: FK_TechProcess002_RevisionId</P><P CLASS="Base">&nbsp;</P>
<P CLASS="Header1">Definition</P>
<P CLASS="Base"><span class="DDLCode">
<code><pre>
<b>ALTER</b><b> </b><b>TABLE</b><b> </b><font color="# 080 0"><u>&quot;TechProcess002&quot;</u></font><b> </b><b>ADD</b><b> </b><b>CONSTRAINT</b><b> </b>&quot;FK_TechProcess002_RevisionId&quot;
<b>FOREIGN</b><b> </b><b>KEY</b><b> </b><b>(</b>RevisionId<b>)</b>
<b>REFERENCES</b><b> </b><font color="# 080 0"><u>&quot;Revisions&quot;</u></font><b> </b><b>(</b>Id<b>)</b>

</pre></code>
</span></P>

<HR>
<A NAME="FKEY_FK_TechProcess002_TypeId"><P CLASS="Header0">Foreign Key: FK_TechProcess002_TypeId</P><P CLASS="Base">&nbsp;</P>
<P CLASS="Header1">Definition</P>
<P CLASS="Base"><span class="DDLCode">
<code><pre>
<b>ALTER</b><b> </b><b>TABLE</b><b> </b><font color="# 080 0"><u>&quot;TechProcess002&quot;</u></font><b> </b><b>ADD</b><b> </b><b>CONSTRAINT</b><b> </b>&quot;FK_TechProcess002_TypeId&quot;
<b>FOREIGN</b><b> </b><b>KEY</b><b> </b><b>(</b>TypeId<b>)</b>
<b>REFERENCES</b><b> </b><font color="# 080 0"><u>&quot;RevisionType&quot;</u></font><b> </b><b>(</b>Id<b>)</b>

</pre></code>
</span></P>

<HR>
<A NAME="FKEY_FK_TechProcess002_UserId"><P CLASS="Header0">Foreign Key: FK_TechProcess002_UserId</P><P CLASS="Base">&nbsp;</P>
<P CLASS="Header1">Definition</P>
<P CLASS="Base"><span class="DDLCode">
<code><pre>
<b>ALTER</b><b> </b><b>TABLE</b><b> </b><font color="# 080 0"><u>&quot;TechProcess002&quot;</u></font><b> </b><b>ADD</b><b> </b><b>CONSTRAINT</b><b> </b>&quot;FK_TechProcess002_UserId&quot;
<b>FOREIGN</b><b> </b><b>KEY</b><b> </b><b>(</b>UserId<b>)</b>
<b>REFERENCES</b><b> </b><font color="# 080 0"><u>&quot;Users&quot;</u></font><b> </b><b>(</b>Id<b>)</b>

</pre></code>
</span></P>

<HR>
<A NAME="FKEY_FK_TechProcess003_CopyDrawingId"><P CLASS="Header0">Foreign Key: FK_TechProcess003_CopyDrawingId</P><P CLASS="Base">&nbsp;</P>
<P CLASS="Header1">Definition</P>
<P CLASS="Base"><span class="DDLCode">
<code><pre>
<b>ALTER</b><b> </b><b>TABLE</b><b> </b><font color="# 080 0"><u>&quot;TechProcess003&quot;</u></font><b> </b><b>ADD</b><b> </b><b>CONSTRAINT</b><b> </b>&quot;FK_TechProcess003_CopyDrawingId&quot;
<b>FOREIGN</b><b> </b><b>KEY</b><b> </b><b>(</b>CopyDrawingId<b>)</b>
<b>REFERENCES</b><b> </b><font color="# 080 0"><u>&quot;Drawing&quot;</u></font><b> </b><b>(</b>Id<b>)</b>
<b>ON</b><b> </b><b>DELETE</b><b> </b><b>SET</b><b> </b><b>NULL</b>

</pre></code>
</span></P>

<HR>
<A NAME="FKEY_FK_TechProcess003_DrawingId"><P CLASS="Header0">Foreign Key: FK_TechProcess003_DrawingId</P><P CLASS="Base">&nbsp;</P>
<P CLASS="Header1">Definition</P>
<P CLASS="Base"><span class="DDLCode">
<code><pre>
<b>ALTER</b><b> </b><b>TABLE</b><b> </b><font color="# 080 0"><u>&quot;TechProcess003&quot;</u></font><b> </b><b>ADD</b><b> </b><b>CONSTRAINT</b><b> </b>&quot;FK_TechProcess003_DrawingId&quot;
<b>FOREIGN</b><b> </b><b>KEY</b><b> </b><b>(</b>DrawingId<b>)</b>
<b>REFERENCES</b><b> </b><font color="# 080 0"><u>&quot;Drawing&quot;</u></font><b> </b><b>(</b>Id<b>)</b>
<b>ON</b><b> </b><b>DELETE</b><b> </b><b>SET</b><b> </b><b>NULL</b>

</pre></code>
</span></P>

<HR>
<A NAME="FKEY_FK_TechProcess003_ParentId"><P CLASS="Header0">Foreign Key: FK_TechProcess003_ParentId</P><P CLASS="Base">&nbsp;</P>
<P CLASS="Header1">Definition</P>
<P CLASS="Base"><span class="DDLCode">
<code><pre>
<b>ALTER</b><b> </b><b>TABLE</b><b> </b><font color="# 080 0"><u>&quot;TechProcess003&quot;</u></font><b> </b><b>ADD</b><b> </b><b>CONSTRAINT</b><b> </b>&quot;FK_TechProcess003_ParentId&quot;
<b>FOREIGN</b><b> </b><b>KEY</b><b> </b><b>(</b>ParentId<b>)</b>
<b>REFERENCES</b><b> </b><font color="# 080 0"><u>&quot;TechProcess003&quot;</u></font><b> </b><b>(</b>Id<b>)</b>
<b>ON</b><b> </b><b>DELETE</b><b> </b><b>SET</b><b> </b><b>NULL</b>

</pre></code>
</span></P>

<HR>
<A NAME="FKEY_FK_TechProcess003_RevisionId"><P CLASS="Header0">Foreign Key: FK_TechProcess003_RevisionId</P><P CLASS="Base">&nbsp;</P>
<P CLASS="Header1">Definition</P>
<P CLASS="Base"><span class="DDLCode">
<code><pre>
<b>ALTER</b><b> </b><b>TABLE</b><b> </b><font color="# 080 0"><u>&quot;TechProcess003&quot;</u></font><b> </b><b>ADD</b><b> </b><b>CONSTRAINT</b><b> </b>&quot;FK_TechProcess003_RevisionId&quot;
<b>FOREIGN</b><b> </b><b>KEY</b><b> </b><b>(</b>RevisionId<b>)</b>
<b>REFERENCES</b><b> </b><font color="# 080 0"><u>&quot;Revisions&quot;</u></font><b> </b><b>(</b>Id<b>)</b>

</pre></code>
</span></P>

<HR>
<A NAME="FKEY_FK_TechProcess003_TypeId"><P CLASS="Header0">Foreign Key: FK_TechProcess003_TypeId</P><P CLASS="Base">&nbsp;</P>
<P CLASS="Header1">Definition</P>
<P CLASS="Base"><span class="DDLCode">
<code><pre>
<b>ALTER</b><b> </b><b>TABLE</b><b> </b><font color="# 080 0"><u>&quot;TechProcess003&quot;</u></font><b> </b><b>ADD</b><b> </b><b>CONSTRAINT</b><b> </b>&quot;FK_TechProcess003_TypeId&quot;
<b>FOREIGN</b><b> </b><b>KEY</b><b> </b><b>(</b>TypeId<b>)</b>
<b>REFERENCES</b><b> </b><font color="# 080 0"><u>&quot;RevisionType&quot;</u></font><b> </b><b>(</b>Id<b>)</b>

</pre></code>
</span></P>

<HR>
<A NAME="FKEY_FK_TechProcess003_UserId"><P CLASS="Header0">Foreign Key: FK_TechProcess003_UserId</P><P CLASS="Base">&nbsp;</P>
<P CLASS="Header1">Definition</P>
<P CLASS="Base"><span class="DDLCode">
<code><pre>
<b>ALTER</b><b> </b><b>TABLE</b><b> </b><font color="# 080 0"><u>&quot;TechProcess003&quot;</u></font><b> </b><b>ADD</b><b> </b><b>CONSTRAINT</b><b> </b>&quot;FK_TechProcess003_UserId&quot;
<b>FOREIGN</b><b> </b><b>KEY</b><b> </b><b>(</b>UserId<b>)</b>
<b>REFERENCES</b><b> </b><font color="# 080 0"><u>&quot;Users&quot;</u></font><b> </b><b>(</b>Id<b>)</b>

</pre></code>
</span></P>

<HR>
<A NAME="FKEY_FK_TechProcess004_CopyDrawingId"><P CLASS="Header0">Foreign Key: FK_TechProcess004_CopyDrawingId</P><P CLASS="Base">&nbsp;</P>
<P CLASS="Header1">Definition</P>
<P CLASS="Base"><span class="DDLCode">
<code><pre>
<b>ALTER</b><b> </b><b>TABLE</b><b> </b><font color="# 080 0"><u>&quot;TechProcess004&quot;</u></font><b> </b><b>ADD</b><b> </b><b>CONSTRAINT</b><b> </b>&quot;FK_TechProcess004_CopyDrawingId&quot;
<b>FOREIGN</b><b> </b><b>KEY</b><b> </b><b>(</b>CopyDrawingId<b>)</b>
<b>REFERENCES</b><b> </b><font color="# 080 0"><u>&quot;Drawing&quot;</u></font><b> </b><b>(</b>Id<b>)</b>
<b>ON</b><b> </b><b>DELETE</b><b> </b><b>SET</b><b> </b><b>NULL</b>

</pre></code>
</span></P>

<HR>
<A NAME="FKEY_FK_TechProcess004_DrawingId"><P CLASS="Header0">Foreign Key: FK_TechProcess004_DrawingId</P><P CLASS="Base">&nbsp;</P>
<P CLASS="Header1">Definition</P>
<P CLASS="Base"><span class="DDLCode">
<code><pre>
<b>ALTER</b><b> </b><b>TABLE</b><b> </b><font color="# 080 0"><u>&quot;TechProcess004&quot;</u></font><b> </b><b>ADD</b><b> </b><b>CONSTRAINT</b><b> </b>&quot;FK_TechProcess004_DrawingId&quot;
<b>FOREIGN</b><b> </b><b>KEY</b><b> </b><b>(</b>DrawingId<b>)</b>
<b>REFERENCES</b><b> </b><font color="# 080 0"><u>&quot;Drawing&quot;</u></font><b> </b><b>(</b>Id<b>)</b>
<b>ON</b><b> </b><b>DELETE</b><b> </b><b>SET</b><b> </b><b>NULL</b>

</pre></code>
</span></P>

<HR>
<A NAME="FKEY_FK_TechProcess004_ParentId"><P CLASS="Header0">Foreign Key: FK_TechProcess004_ParentId</P><P CLASS="Base">&nbsp;</P>
<P CLASS="Header1">Definition</P>
<P CLASS="Base"><span class="DDLCode">
<code><pre>
<b>ALTER</b><b> </b><b>TABLE</b><b> </b><font color="# 080 0"><u>&quot;TechProcess004&quot;</u></font><b> </b><b>ADD</b><b> </b><b>CONSTRAINT</b><b> </b>&quot;FK_TechProcess004_ParentId&quot;
<b>FOREIGN</b><b> </b><b>KEY</b><b> </b><b>(</b>ParentId<b>)</b>
<b>REFERENCES</b><b> </b><font color="# 080 0"><u>&quot;TechProcess004&quot;</u></font><b> </b><b>(</b>Id<b>)</b>
<b>ON</b><b> </b><b>DELETE</b><b> </b><b>SET</b><b> </b><b>NULL</b>

</pre></code>
</span></P>

<HR>
<A NAME="FKEY_FK_TechProcess004_RevisionId"><P CLASS="Header0">Foreign Key: FK_TechProcess004_RevisionId</P><P CLASS="Base">&nbsp;</P>
<P CLASS="Header1">Definition</P>
<P CLASS="Base"><span class="DDLCode">
<code><pre>
<b>ALTER</b><b> </b><b>TABLE</b><b> </b><font color="# 080 0"><u>&quot;TechProcess004&quot;</u></font><b> </b><b>ADD</b><b> </b><b>CONSTRAINT</b><b> </b>&quot;FK_TechProcess004_RevisionId&quot;
<b>FOREIGN</b><b> </b><b>KEY</b><b> </b><b>(</b>RevisionId<b>)</b>
<b>REFERENCES</b><b> </b><font color="# 080 0"><u>&quot;Revisions&quot;</u></font><b> </b><b>(</b>Id<b>)</b>

</pre></code>
</span></P>
 
 </details>


