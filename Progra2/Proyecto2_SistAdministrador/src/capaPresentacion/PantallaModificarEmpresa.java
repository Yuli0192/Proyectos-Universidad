package capaPresentacion;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import javax.swing.ImageIcon;
import javax.swing.JButton;
import javax.swing.JLabel;
import javax.swing.JOptionPane;
import javax.swing.JTextField;

import javax.swing.WindowConstants;
import javax.swing.SwingUtilities;

import capaLogica.Empresa;
import capaLogica.Gestor;


/**
* This code was edited or generated using CloudGarden's Jigloo
* SWT/Swing GUI Builder, which is free for non-commercial
* use. If Jigloo is being used commercially (ie, by a corporation,
* company or business for any purpose whatever) then you
* should purchase a license for each developer using Jigloo.
* Please visit www.cloudgarden.com for details.
* Use of Jigloo implies acceptance of these licensing terms.
* A COMMERCIAL LICENSE HAS NOT BEEN PURCHASED FOR
* THIS MACHINE, SO JIGLOO OR THIS CODE CANNOT BE USED
* LEGALLY FOR ANY CORPORATE OR COMMERCIAL PURPOSE.
*/
public class PantallaModificarEmpresa extends javax.swing.JFrame {
	private JTextField txtBuscar;
	private JLabel direcEmpresa;
	private JLabel jLabel1;
	private JButton btnRegresar;
	private JButton btnAgregar;
	private JTextField txtContEmpresa;
	private JLabel contEmpresa;
	private JLabel telEmpresa;
	private JTextField txtTelEmpresa;
	private JTextField txtDirecEmpresa;
	private JTextField txtNomEmpresa;
	private JLabel nomEmpresa;
	private JLabel numEmpresa;
	private JTextField txtNumEmpresa;
	private JButton btnBuscar;
	private Gestor gestor;
	/**
	* Auto-generated main method to display this JFrame
	*/
	public static void main(String[] args) {
		SwingUtilities.invokeLater(new Runnable() {
			public void run() {
				PantallaModificarEmpresa inst = new PantallaModificarEmpresa();
				inst.setLocationRelativeTo(null);
				inst.setVisible(true);
			}
		});
	}
	
	public PantallaModificarEmpresa() {
		super();
		initGUI();
		gestor=new Gestor();
	}
	
	private void initGUI() {
		try {
			setDefaultCloseOperation(WindowConstants.DISPOSE_ON_CLOSE);
			getContentPane().setLayout(null);
			getContentPane().setBackground(new java.awt.Color(0,128,255));
			this.setTitle("Modificar Empresa");
			this.setIconImage(new ImageIcon(getClass().getClassLoader().getResource("capaObjetos/abo.jpg")).getImage());
			{
				txtBuscar = new JTextField();
				getContentPane().add(txtBuscar);
				txtBuscar.setBounds(23, 42, 197, 23);
			}
			{
				btnBuscar = new JButton();
				getContentPane().add(btnBuscar);
				btnBuscar.setText("Buscar");
				btnBuscar.setBounds(238, 36, 125, 36);
				btnBuscar.setIcon(new ImageIcon(getClass().getClassLoader().getResource("capaObjetos/bus1.gif")));
				btnBuscar.addActionListener(new ActionListener() {
					public void actionPerformed(ActionEvent evt) {
						System.out.println("btnBuscar.actionPerformed, event="+evt);
						//TODO add your code for btnBuscar.actionPerformed
						btnBuscar_actionPerformed(evt);
					}
				});
			}
			{
				txtNumEmpresa = new JTextField();
				getContentPane().add(txtNumEmpresa);
				txtNumEmpresa.setBounds(129, 74, 103, 23);
				txtNumEmpresa.setEditable(false);
			}
			{
				numEmpresa = new JLabel();
				getContentPane().add(numEmpresa);
				numEmpresa.setText("Numero");
				numEmpresa.setBounds(23, 77, 106, 16);
			}
			{
				nomEmpresa = new JLabel();
				getContentPane().add(nomEmpresa);
				nomEmpresa.setText("Nombre ");
				nomEmpresa.setBounds(23, 117, 106, 16);
			}
			{
				txtNomEmpresa = new JTextField();
				getContentPane().add(txtNomEmpresa);
				txtNomEmpresa.setBounds(129, 114, 228, 23);
			}
			{
				direcEmpresa = new JLabel();
				getContentPane().add(direcEmpresa);
				direcEmpresa.setText("Direccion");
				direcEmpresa.setBounds(23, 155, 106, 16);
			}
			{
				txtDirecEmpresa = new JTextField();
				getContentPane().add(txtDirecEmpresa);
				txtDirecEmpresa.setBounds(129, 152, 228, 23);
			}
			{
				txtTelEmpresa = new JTextField();
				getContentPane().add(txtTelEmpresa);
				txtTelEmpresa.setBounds(129, 195, 228, 23);
			}
			{
				telEmpresa = new JLabel();
				getContentPane().add(telEmpresa);
				telEmpresa.setText("Telefono");
				telEmpresa.setBounds(23, 195, 106, 23);
			}
			{
				contEmpresa = new JLabel();
				getContentPane().add(contEmpresa);
				contEmpresa.setText("Contacto");
				contEmpresa.setBounds(23, 236, 106, 16);
			}
			{
				txtContEmpresa = new JTextField();
				getContentPane().add(txtContEmpresa);
				txtContEmpresa.setBounds(129, 233, 228, 23);
			}
			{
				btnAgregar = new JButton();
				getContentPane().add(btnAgregar);
				btnAgregar.setText("Modificar");
				btnAgregar.setBounds(23, 276, 138, 37);
				btnAgregar.setBackground(new java.awt.Color(255,255,255));
				btnAgregar.setIcon(new ImageIcon(getClass().getClassLoader().getResource("capaObjetos/modificar.gif")));
				btnAgregar.addActionListener(new ActionListener() {
					public void actionPerformed(ActionEvent evt) {
						System.out.println("btnAgregar.actionPerformed, event="+evt);
						//TODO add your code for btnAgregar.actionPerformed
						btnAgregar_actionPerformed(evt);
					}

				});
			}
			{
				btnRegresar = new JButton();
				getContentPane().add(btnRegresar);
				btnRegresar.setText("Regresar");
				btnRegresar.setBounds(219, 276, 138, 37);
				btnRegresar.setBackground(new java.awt.Color(255,255,255));
				btnRegresar.setIcon(new ImageIcon(getClass().getClassLoader().getResource("capaObjetos/salir.gif")));
				btnRegresar.addActionListener(new ActionListener() {
					public void actionPerformed(ActionEvent evt) {
						System.out.println("btnRegresar.actionPerformed, event="+evt);
						//TODO add your code for btnRegresar.actionPerformed
						btnRegresar_actionPerformed(evt);
					}

				});
			}
			{
				jLabel1 = new JLabel();
				getContentPane().add(jLabel1);
				jLabel1.setText("Buscar por Numero Empresa");
				jLabel1.setBounds(23, 12, 209, 18);
			}
			pack();
			this.setSize(401, 372);
		} catch (Exception e) {
		    //add your error handling code here
			e.printStackTrace();
		}
	}
	
	private void btnBuscar_actionPerformed(ActionEvent evt) {
		String numEmpresa;
		Empresa empresa;
		
		try {
			numEmpresa=txtBuscar.getText();
			empresa=gestor.buscarEmpresa(numEmpresa);
			txtNumEmpresa.setText(empresa.getNumEmpresa()+"");
			txtNomEmpresa.setText(empresa.getNomEmpresa()+"");
			txtDirecEmpresa.setText(empresa.getDirecEmpresa()+"");
			txtTelEmpresa.setText(empresa.getTelEmpresa()+"");
			txtContEmpresa.setText(empresa.getContactoEmpresa()+"");
		} catch (Exception e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
		
	}
	

	private void btnRegresar_actionPerformed(ActionEvent evt) {
		PantallaPrincipal PP= new PantallaPrincipal();
		PP.setVisible(true);
		PantallaModificarEmpresa.this.dispose();
		
	}
	

	private void btnAgregar_actionPerformed(ActionEvent evt) {
		//String pnumEmpresa,String pnomEmpresa,String pdirecEmpresa,String ptelEmpresa,String pcontactoEmpresa
		String numEmpresa, nomEmpresa,direcEmpresa,telEmpresa,contactoEmpresa,mjs;
		numEmpresa=txtNumEmpresa.getText();
		nomEmpresa=txtNomEmpresa.getText();
		direcEmpresa=txtDirecEmpresa.getText();
		telEmpresa=txtTelEmpresa.getText();
		contactoEmpresa=txtContEmpresa.getText();
		mjs=gestor.modificarEmpresa(numEmpresa, nomEmpresa, direcEmpresa, telEmpresa, contactoEmpresa);
		JOptionPane.showMessageDialog(this,mjs,"Mensaje",JOptionPane.INFORMATION_MESSAGE);
		txtNumEmpresa.setText("");
		txtNomEmpresa.setText("");
		txtDirecEmpresa.setText("");
		txtTelEmpresa.setText("");
		txtContEmpresa.setText("");
		txtBuscar.setText("");
	}

}
