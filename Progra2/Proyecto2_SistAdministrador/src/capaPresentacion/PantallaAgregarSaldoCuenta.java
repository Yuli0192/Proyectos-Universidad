package capaPresentacion;
import javax.swing.ComboBoxModel;
import javax.swing.DefaultComboBoxModel;
import javax.swing.ImageIcon;
import javax.swing.JButton;
import javax.swing.JComboBox;
import javax.swing.JLabel;
import javax.swing.JOptionPane;
import javax.swing.JTextField;

import javax.swing.WindowConstants;
import javax.swing.SwingUtilities;

import capaLogica.Gestor;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;

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
public class PantallaAgregarSaldoCuenta extends javax.swing.JFrame {
	private JLabel numCuentas;
	private JComboBox cbxNumCuentas;
	private JTextField txtMonto;
	private JLabel mon;
	private JButton btnRegresar;
	private JButton btnAgregarMonto;
	Gestor gestor;
	/**
	* Auto-generated main method to display this JFrame
	*/
	public static void main(String[] args) {
		SwingUtilities.invokeLater(new Runnable() {
			public void run() {
				PantallaAgregarSaldoCuenta inst = new PantallaAgregarSaldoCuenta();
				inst.setLocationRelativeTo(null);
				inst.setVisible(true);
			}
		});
	}
	
	public PantallaAgregarSaldoCuenta() {
		super();
		initGUI();
		gestor= new Gestor();
		cargarNumCuentas();
	}
	
	private void cargarNumCuentas() {
		String [] listaAbogados = gestor.obtenerTodasLasCuentas();
		for(int i=0; i<listaAbogados.length;i++){
			cbxNumCuentas.addItem(listaAbogados[i]);				
		}
		
	}

	private void initGUI() {
		try {
			setDefaultCloseOperation(WindowConstants.DISPOSE_ON_CLOSE);
			getContentPane().setLayout(null);
			getContentPane().setBackground(new java.awt.Color(0,128,255));
			this.setIconImage(new ImageIcon(getClass().getClassLoader().getResource("capaObjetos/abo.jpg")).getImage());
			this.setTitle("Agregar Saldo Cuenta");
			{
				numCuentas = new JLabel();
				getContentPane().add(numCuentas);
				numCuentas.setText("Numeros de Cuentas");
				numCuentas.setBounds(17, 23, 127, 19);
			}
			{
				ComboBoxModel cbxNumCuentasModel = 
					new DefaultComboBoxModel(
							new String[] {  });
				cbxNumCuentas = new JComboBox();
				getContentPane().add(cbxNumCuentas);
				cbxNumCuentas.setModel(cbxNumCuentasModel);
				cbxNumCuentas.setBounds(150, 21, 211, 23);
			}
			{
				txtMonto = new JTextField();
				getContentPane().add(txtMonto);
				txtMonto.setBounds(150, 71, 211, 23);
			}
			{
				mon = new JLabel();
				getContentPane().add(mon);
				mon.setText("Monto");
				mon.setBounds(17, 71, 133, 23);
			}
			{
				btnAgregarMonto = new JButton();
				getContentPane().add(btnAgregarMonto);
				btnAgregarMonto.setText("Agregar Monto");
				btnAgregarMonto.setBounds(17, 124, 151, 42);
				btnAgregarMonto.setBackground(new java.awt.Color(255,255,255));
				btnAgregarMonto.setIcon(new ImageIcon(getClass().getClassLoader().getResource("capaObjetos/modificar3.gif")));
				btnAgregarMonto.addActionListener(new ActionListener() {
					public void actionPerformed(ActionEvent evt) {
						System.out.println("btnAgregarMonto.actionPerformed, event="+evt);
						//TODO add your code for btnAgregarMonto.actionPerformed
						btnAgregarMonto_actionPerformed(evt);
					}

				});
			}
			{
				btnRegresar = new JButton();
				getContentPane().add(btnRegresar);
				btnRegresar.setText("Regresar");
				btnRegresar.setBounds(229, 124, 132, 42);
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
			pack();
			this.setSize(403, 226);
		} catch (Exception e) {
		    //add your error handling code here
			e.printStackTrace();
		}
	}
	private void btnAgregarMonto_actionPerformed(ActionEvent evt) {
		String numCuenta,mjs;
		int monto;
		numCuenta= (String) cbxNumCuentas.getSelectedItem();
		monto=Integer.parseInt(txtMonto.getText()+"");
		mjs=gestor.aumentarMontoCuenta(numCuenta, monto);
		JOptionPane.showMessageDialog(this,mjs,"Mensaje",JOptionPane.INFORMATION_MESSAGE);
	}


	private void btnRegresar_actionPerformed(ActionEvent evt) {
		PantallaPrincipal PP= new PantallaPrincipal();
		PP.setVisible(true);
		PantallaAgregarSaldoCuenta.this.dispose();
	}
}
