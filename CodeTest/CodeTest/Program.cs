using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CodeTest
{
	class Program
	{
		
			public Sub Main(SymDocumentType() As String, )

		Try
			_dtParameters = DjjData.GetApplicationParameters(ApplicationType)


			ErrorPanel.DJJ_ApplicationType = ApplicationType

			ErrorPanel.DJJ_BizType = BizType

			ErrorPanel.DJJ_EmailOnError = True

			ErrorPanel.DJJ_EmailRecipients = DJJFunctions.GetParameterValue(_dtParameters, "EmailOnErrorRecipients")


			Select Case sDocumentType(0)

				Case "PO", "SO"

					ContractPrintFunctions.ProcessContractDocuments(BizType, "PO", ApplicationType)

				Case "PCO", "SCO"

					ContractPrintFunctions.ProcessChangeOrderDocuments(BizType, sDocumentType(0), ApplicationType)

				Case Else

					Exit Sub

			End Select

		Catch ex As Exception

			ErrorPanel.HandleError(ex, "PrintProcessor")

		End Try

	End Sub

		
	}
}
