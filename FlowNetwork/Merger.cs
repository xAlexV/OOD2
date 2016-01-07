using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowNetwork
{
    public class Merger : Component
    {
    }
}
<DirectedGraph xmlns="http://schemas.microsoft.com/vs/2009/dgml">
  <Nodes>
    <Node Id="(@1 Namespace=FlowNetwork Type=Drawing)" Category="CodeSchema_Class" CodeSchemaProperty_IsPublic="True" CommonLabel="Drawing" Icon="Microsoft.VisualStudio.Class.Public" IsDragSource="True" Label="Drawing" Language="{B5E9BD34-6D3E-4B5D-925E-8A43B79820B4}" SourceLocation="(Assembly=&quot;file:///c:/users/romina/documents/visual studio 2013/Projects/FlowNetwork/FlowNetwork/Drawing.cs&quot; StartLineNumber=8 StartCharacterOffset=3 EndLineNumber=8 EndCharacterOffset=3)" />
    <Node Id="(Namespace=FlowNetwork)" Visibility="Hidden" />
  </Nodes>
  <Links>
    <Link Source="(Namespace=FlowNetwork)" Target="(@1 Namespace=FlowNetwork Type=Drawing)" Category="Contains" />
  </Links>
  <Categories>
    <Category Id="CodeSchema_Class" Label="Class" BasedOn="CodeSchema_Type" CanBeDataDriven="True" DefaultAction="Node:Both:CodeSchema_Member" Icon="CodeSchema_Class" NavigationActionLabel="Classes" />
    <Category Id="CodeSchema_Type" Label="Type" CanBeDataDriven="True" DefaultAction="Node:Both:CodeSchema_Member" Icon="CodeSchema_Class" NavigationActionLabel="Types" />
    <Category Id="Contains" Label="Contains" Description="Whether the source of the link contains the target object" CanBeDataDriven="False" CanLinkedNodesBeDataDriven="True" IncomingActionLabel="Contained By" IsContainment="True" OutgoingActionLabel="Contains" />
  </Categories>
  <Properties>
    <Property Id="CanBeDataDriven" Label="CanBeDataDriven" Description="CanBeDataDriven" DataType="System.Boolean" />
    <Property Id="CanLinkedNodesBeDataDriven" Label="CanLinkedNodesBeDataDriven" Description="CanLinkedNodesBeDataDriven" DataType="System.Boolean" />
    <Property Id="CodeSchemaProperty_IsPublic" Label="Is Public" Description="Flag to indicate the scope is Public" DataType="System.Boolean" />
    <Property Id="CommonLabel" DataType="System.String" />
    <Property Id="DefaultAction" Label="DefaultAction" Description="DefaultAction" DataType="System.String" />
    <Property Id="Icon" Label="Icon" Description="Icon" DataType="System.String" />
    <Property Id="IncomingActionLabel" Label="IncomingActionLabel" Description="IncomingActionLabel" DataType="System.String" />
    <Property Id="IsContainment" DataType="System.Boolean" />
    <Property Id="IsDragSource" Label="IsDragSource" Description="IsDragSource" DataType="System.Boolean" />
    <Property Id="Label" Label="Label" Description="Displayable label of an Annotatable object" DataType="System.String" />
    <Property Id="Language" Label="Language" Description="Language" DataType="System.String" />
    <Property Id="NavigationActionLabel" Label="NavigationActionLabel" Description="NavigationActionLabel" DataType="System.String" />
    <Property Id="OutgoingActionLabel" Label="OutgoingActionLabel" Description="OutgoingActionLabel" DataType="System.String" />
    <Property Id="SourceLocation" Label="Start Line Number" DataType="Microsoft.VisualStudio.GraphModel.CodeSchema.SourceLocation" />
    <Property Id="Visibility" Label="Visibility" Description="Defines whether a node in the graph is visible or not" DataType="System.Windows.Visibility" />
  </Properties>
  <QualifiedNames>
    <Name Id="Assembly" Label="Assembly" ValueType="Uri" />
    <Name Id="Namespace" Label="Namespace" ValueType="System.String" />
    <Name Id="Type" Label="Type" ValueType="System.Object" />
  </QualifiedNames>
  <IdentifierAliases>
    <Alias n="1" Uri="Assembly=$(17836c01-8f16-4942-81af-7ebd52e72526.OutputPathUri)" />
  </IdentifierAliases>
  <Paths>
    <Path Id="17836c01-8f16-4942-81af-7ebd52e72526.OutputPathUri" Value="file:///c:/users/romina/documents/visual studio 2013/Projects/FlowNetwork/FlowNetwork/bin/Debug/FlowNetwork.exe" />
  </Paths>
</DirectedGraph>